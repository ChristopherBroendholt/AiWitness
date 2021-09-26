using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiWitnessBaseLibrary
{
    public static class FileHandling
    {
        private static string GetFolderPath()
        {
            string filePathTmp = Directory.GetCurrentDirectory();
            string[] filePathSplitted = filePathTmp.Split('\\');

            string filePath = String.Join("\\", filePathSplitted.Take(6).ToArray());
            filePath += "\\Videos";

            if (!Directory.Exists(filePath))
            {
                throw new DirectoryNotFoundException();
            }

            return filePath;
        }

        public static string[] GetFilePaths ()
        {
            string folderPath = GetFolderPath();
            return Directory.GetFiles(folderPath);
        }

        public static string[] GetFileNames()
        {
            string[] filePaths = GetFilePaths();
            string[] fileNames = new string[filePaths.Length];

            for (int i = 0; i < filePaths.Length; i++)
            {
                fileNames[i] = Path.GetFileName(filePaths[i]);
            }

            return fileNames;
        }

        //public string[] GetFilePaths()
        //{

        //}

        //public string[] GetFileNames()
        //{

        //}

        //public string[] GetFilePathByName()
        //{

        //}
    }


}
