using System;
using System.IO
;
namespace filehandling2
{
    class FileHandling
    {
        
        
        private string msg1 = "This is a text file.";
        private string msg2 = "This is a text file, and I can edit it.";
        public string createFile(string myFileName)
        {
            string txt = ".txt";
            string fullFileName = myFileName + txt;
            string myPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            
            string fullPath = $"{myPath}\\{fullFileName}";
            

           using(FileStream fs1 =   File.Create(fullPath, FileMode.Create))
           using(StreamWriter sw = new StreamWriter(fs1))
           {

               sw.WriteLine(msg1);

           }

            Console.WriteLine("Done.");
            return fullPath;


        }


        public string editFile(string path)
        {


            using(FileStream f1 = File.OpenWrite(path))
                using( StreamWriter sw1 = new StreamWriter(f1))
                {
                    sw1.WriteLine(msg2);

                }
            Console.WriteLine("The file at {0} was edited.", path);

            return path;
        }

    }
}