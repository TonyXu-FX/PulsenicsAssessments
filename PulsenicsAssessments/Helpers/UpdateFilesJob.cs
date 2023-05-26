using Quartz;

namespace PulsenicsAssessments.Helpers
{
    public class UpdateFilesJob : IJob
    {
        public const int TRIGGER_SECONDS = 10;

        public async Task Execute(IJobExecutionContext context)
        {
            if (FileWatcher.fileChanged)
            {
                FileWatcher.fileChanged = false;
                FileHandler.UpdateAllFiles();
            }
        }
    }
}
