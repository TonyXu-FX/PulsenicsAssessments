using PulsenicsAssessments.Database;
using PulsenicsAssessments.Helpers;
using Quartz;
using System.Collections.Specialized;

namespace PulsenicsAssessments
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            using (var context = new FilesContext())
            {
                context.Database.EnsureCreated();
            }

            FileHandler.UpdateAllFiles();

            using var watcher = new FileSystemWatcher(FileHandler.PATH);
            watcher.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName;
            watcher.Changed += FileWatcher.OnChanged;
            watcher.Created += FileWatcher.OnCreated;
            watcher.Deleted += FileWatcher.OnDeleted;
            watcher.Renamed += FileWatcher.OnRenamed;
            watcher.IncludeSubdirectories = false;
            watcher.EnableRaisingEvents = true;

            IScheduler scheduler = await SchedulerBuilder.Create().BuildScheduler();
            await scheduler.Start();

            IJobDetail job = JobBuilder.Create<UpdateFilesJob>().Build();
            ITrigger trigger = TriggerBuilder.Create()
                .StartNow()
                .WithSimpleSchedule(x => x
                    .WithIntervalInSeconds(UpdateFilesJob.TRIGGER_SECONDS)
                    .RepeatForever())
                .Build();

            await scheduler.ScheduleJob(job, trigger);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}