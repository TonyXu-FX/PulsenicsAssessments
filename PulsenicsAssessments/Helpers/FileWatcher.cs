using PulsenicsAssessments.Database;
using PulsenicsAssessments.Models;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace PulsenicsAssessments.Helpers
{
    /* Ideally I would have used this classes to handle the events properly
       But turns out changing files actual triggers multiple events involving 
       some temporary files. This complicates things.
    */
    public class FileWatcher
    {
        public static bool fileChanged = false;

        public static void OnChanged(object sender, FileSystemEventArgs e)
        {
            fileChanged = true;
        }

        public static void OnCreated(object sender, FileSystemEventArgs e)
        {

            fileChanged = true;
        }

        public static void OnDeleted(object sender, FileSystemEventArgs e)
        {
            fileChanged = true;
        }

        public static void OnRenamed(object sender, RenamedEventArgs e)
        {
            fileChanged = true;
        }
    }
}
