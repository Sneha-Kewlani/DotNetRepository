using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace folderService
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
            if (!System.Diagnostics.EventLog.SourceExists("FolderServiceSource"))
                System.Diagnostics.EventLog.CreateEventSource("FolderServiceSource", "FolderServiceLog");

            eventLog1.Source = "FolderServiceSource";
            eventLog1.Log = "FolderServiceLog";
        }

        protected override void OnStart(string[] args)
        {
            eventLog1.WriteEntry("Folder Service started successfully");

            FileSystemWatcher watcher = new FileSystemWatcher();

           
           string sourcePath = @"C:\Users\kewlani_s\Desktop\sneha";
         

            watcher.Path = sourcePath;



            watcher.IncludeSubdirectories = true;

            watcher.NotifyFilter = NotifyFilters.Attributes |
            NotifyFilters.CreationTime |
            NotifyFilters.DirectoryName |
            NotifyFilters.FileName |
            NotifyFilters.LastAccess |
            NotifyFilters.LastWrite |
            NotifyFilters.Security |
            NotifyFilters.Size;

            watcher.Filter = "*.*";

            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnCreated);
            watcher.Deleted += new FileSystemEventHandler(OnDeleted);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);



            watcher.EnableRaisingEvents = true;


        }

        protected override void OnStop()
        {
            eventLog1.WriteEntry("Folder Service started successfully");
        }

        public void OnCreated(object source, FileSystemEventArgs e)
        {



            eventLog1.WriteEntry("Created");


            string fileName = e.Name;
            string sourcePath = @"C:\Users\kewlani_s\Desktop\sneha";
            string targetPath = @"C:\Users\kewlani_s\Desktop\snehaCopy";
    
             
            string sourceFile = Path.Combine(sourcePath, fileName);
            string destFile = Path.Combine(targetPath, fileName);

           
            File.Copy(sourceFile, destFile, true);
            eventLog1.WriteEntry("File Copy DOne");

            /*if (System.IO.Directory.Exists(@"C:\Users\kewlani_s\Desktop\sneha\direc1"))
            {
                string[] files = System.IO.Directory.GetFiles(@"C:\Users\kewlani_s\Desktop\sneha\direc1");


                foreach (string s in files)
                {

                    string fileName1 = System.IO.Path.GetFileName(s);
                    string destFile1 = System.IO.Path.Combine(targetPath, fileName1);

                    if (!System.IO.Directory.Exists(destFile1))
                    {
                        System.IO.Directory.CreateDirectory(destFile1);
                    }
                    System.IO.File.Copy(s, destFile1, true);
                    eventLog1.WriteEntry("Directory Copy DOne");
                }
            }*/

        }



        public void OnChanged(object source, FileSystemEventArgs e)
        {

            eventLog1.WriteEntry("Changed");

            
        }

        public void OnRenamed(object source, RenamedEventArgs e)
        {
            eventLog1.WriteEntry("Renamed");
            string fileName = e.Name;
            string oldFileName = e.OldName;
            string sourcePath = @"C:\Users\kewlani_s\Desktop\sneha";
            string targetPath = @"C:\Users\kewlani_s\Desktop\snehaCopy";

            //string targetPath1 = @"C:\Users\kewlani_s\Desktop\snehaCopy";

            string sourceFile = Path.Combine(targetPath, oldFileName);
            string destFile = Path.Combine(targetPath, fileName);

       
            if(File.Exists(sourceFile))
            {
                File.Delete(sourceFile);
            }


            File.Copy(e.FullPath, destFile, true);
            eventLog1.WriteEntry("File Copy DOne");

           

        }

        public void OnDeleted(object source, FileSystemEventArgs e)
        {
            eventLog1.WriteEntry(" Deleted");
        }
    }
}
