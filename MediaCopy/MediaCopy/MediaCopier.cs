using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;

namespace MediaCopy
{
    class MediaCopier
    {
        string sourceFolder;
        string destinationFolder;
        string timeFormat;
        string[] extensions;

        public double FractionComplete = 0;
        public bool IsFinished = false;
        public bool NoCopy = false;
        DateTime fromDate;
        DateTime toDate;

        List<string> statusMessages = new List<string>();
        public string Status
        {
            get
            {
                string returnMe = null;
                lock (statusMessages)
                {
                    if (statusMessages.Count > 0)
                    {
                        returnMe = statusMessages[0];
                        statusMessages.RemoveAt(0);
                    }
                }
                return returnMe;
            }
        }

        public MediaCopier(string sourceFolder, string[] extensions, string destinationFolder, string timeFormat, DateTime fromDate, DateTime toDate)
        {
            this.sourceFolder = sourceFolder;
            this.extensions = extensions;
            this.destinationFolder = destinationFolder;
            this.timeFormat = timeFormat;
            this.fromDate = fromDate;
            this.toDate = toDate;
        }

        public void StartCopy()
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(CopyWorker));

        }

        class CopyData
        {
            public string Source;
            public string Destination;
            FileInfo info;

            public long Size
            {
                get
                {
                    return info.Length;
                }
            }

            public CopyData(string source, string destination, FileInfo info)
            {
                this.Source = source;
                this.Destination = destination;
                this.info = info;
            }
        }


        void CopyWorker(object state)
        {
            AddStatus("Searching for files...");
            string[] allFiles = null;
            try
            {
                allFiles = Directory.GetFiles(sourceFolder, "*.*", SearchOption.AllDirectories);
            }
            catch (Exception e)
            {
                AddStatus(e.Message);
                IsFinished = true;
                return;
            }

            FolderInfo folderInfo = new FolderInfo(destinationFolder);

            List<string> toCopy = new List<string>();
            foreach (string file in allFiles)
            {
                foreach (string extension in extensions)
                {
                    if (file.ToLower().EndsWith("." + extension))
                    {
                        toCopy.Add(file);
                    }
                }
            }

            AddStatus("FOUND: " + toCopy.Count + " files in source location.\r\n");

            List<CopyData> copyQueue = new List<CopyData>();
            long totalBytes = 0;
            foreach (string file in toCopy)
            {
                FileInfo info = new FileInfo(file);
                string destination = Path.Combine(destinationFolder,
                    info.LastWriteTime.ToString(timeFormat) + Path.GetExtension(file));

                if (info.LastWriteTime < fromDate)
                {
                    AddStatus("----- Skipping: (Too Old) " + file + " -> " + destination);
                }
                else if (info.LastWriteTime > toDate)
                {
                    AddStatus("----- Skipping: (Too New) " + file + " -> " + destination);
                }
                else if (File.Exists(destination))
                {
                    AddStatus("----- Skipping: (Already exists) " + file + " -> " + destination);

                }
                else if (folderInfo.HasSimilarFile(file, info.Length, info.LastWriteTime))
                {
                    AddStatus("----- Skipping: (* SIMILAR * exists) " + file + " -> " + destination);
                }
                else
                {
                    CopyData newData = new CopyData(file, destination, info);
                    copyQueue.Add(newData);
                    totalBytes += newData.Size;
                }
            }

            AddStatus("");
            AddStatus("-----------------------------------------------------------------------------");
            AddStatus("COPYING: " + copyQueue.Count + " files, " + (totalBytes/(1024 * 1024)).ToString("#,#") + " MB in source location.\r\n");


            long bytesCopied = 0;
            foreach (CopyData data in copyQueue)
            {
                AddStatus("copying " + data.Source + " to " + data.Destination);
                if (NoCopy)
                {
                    
                }
                else
                {
                    File.Copy(data.Source, data.Destination);
                }
                bytesCopied += data.Size;
                FractionComplete = (double)bytesCopied / totalBytes;
            }

            AddStatus("Done copying.\r\n");
            IsFinished = true;
        }

        private void AddStatus(string message)
        {
            lock (statusMessages)
            {
                statusMessages.Add(message);
            }
        }
    }
}
