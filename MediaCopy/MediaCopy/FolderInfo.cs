using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MediaCopy
{
    public class FolderInfo
    {
        Dictionary<string, FileInfo> fileData = new Dictionary<string, FileInfo>();
        public FolderInfo(string folderName)
        {
            if (!Directory.Exists(folderName)) Directory.CreateDirectory(folderName);
            string[] files = Directory.GetFiles(folderName, "*.*");

            foreach (string file in files)
            {
                fileData.Add(file.ToLower(), new FileInfo(file));    
            }
        }



        public bool HasSimilarFile(string file, long size, DateTime dateTime)
        {
            file = file.ToLower();
            foreach (string fileName in fileData.Keys)
            {
                if (fileData[fileName].Length == size &&
                    fileData[fileName].LastWriteTime.Year == dateTime.Year &&
                    fileData[fileName].LastWriteTime.Month == dateTime.Month &&
                    fileData[fileName].LastWriteTime.Day == dateTime.Day)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
