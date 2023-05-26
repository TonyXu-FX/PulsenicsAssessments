using Microsoft.EntityFrameworkCore;
using PulsenicsAssessments.Database;
using PulsenicsAssessments.Models;

namespace PulsenicsAssessments.Helpers
{
    public class FileHandler
    {
        public const string PATH = "C:\\Users\\Tony Xu\\source\\repos\\PulsenicsAssessments\\PulsenicsAssessments\\Files\\";

        /*
         * Go through all files in the folder, compare to DB, and update if necessary
         */
        public static void UpdateAllFiles()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(PATH);
            List<FileData> filesInFolder = (from f in directoryInfo.EnumerateFiles()
                                                 orderby Path.GetFileNameWithoutExtension(f.Name), f.Extension
                                                 select ConvertToFileData(f)).ToList();
           
            using (var context = new FilesContext())
            {
                List<FileData> filesInDb = new List<FileData>();
                filesInDb = context.Files
                    .OrderBy(file => file.Name)
                    .ThenBy(file => file.Extension)
                    .ToList();

                int folderIndex = 0, dbIndex = 0;
                while (folderIndex < filesInFolder.Count && dbIndex < filesInDb.Count)
                {
                    FileData folderFile = filesInFolder[folderIndex];
                    FileData dbFile = filesInDb[dbIndex];
                    int fileComparison = CompareFileNames(folderFile, dbFile);
                    if (fileComparison == 0)
                    {
                        //Same file
                        if (dbFile.Updated != folderFile.Updated)
                        {
                            dbFile.Updated = folderFile.Updated;
                            dbFile.Created = folderFile.Created;
                            context.Files.Update(dbFile);
                        }
                        folderIndex++;
                        dbIndex++;
                    }
                    else if (fileComparison > 0)
                    {
                        //Current folder file comes after db file -> db file no longer exists
                        context.Files.Remove(dbFile);
                        dbIndex++;
                    }
                    else
                    {
                        //Current folder file comes before db file -> new file
                        context.Files.Add(folderFile);
                        folderIndex++;
                    }
                }

                context.AddRange(filesInFolder.GetRange(folderIndex, filesInFolder.Count - folderIndex));
                context.RemoveRange(filesInDb.GetRange(dbIndex, filesInDb.Count - dbIndex));

                context.SaveChanges();
            }
        }

        /*
         * Convert a FileInfo object to FileData
         */
        public static FileData ConvertToFileData(FileInfo file)
        {
            FileData data = new FileData();
            data.Updated = file.LastWriteTime;
            data.Created = file.CreationTime;
            data.Name = Path.GetFileNameWithoutExtension(file.Name);
            data.Extension = file.Extension;
            return data;
        }

        public static int CompareFileNames(FileData file1, FileData file2)
        {
            if (file1 == null || file2 == null) return 0;

            int nameComp = String.Compare(file1.Name, file2.Name);
            int extComp = String.Compare(file1.Extension, file2.Extension);
            if (nameComp != 0)
            {
                return nameComp;
            } 
            else
            {
                return extComp;
            }
        }

        public static List<FileData> GetDbFiles(String searchText)
        {
            using var context = new FilesContext();
            return context.Files.Where(f => (f.Name + f.Extension).Contains(searchText)).ToList();
        }

        public static FileData? GetDbFileWithUsers(String fileName)
        {
            using var context = new FilesContext();
            return context.Files.Where(f => f.Name + f.Extension == fileName).Include("Users").FirstOrDefault();
        }
    }
}
