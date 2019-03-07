using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace filehandling2
{
    class FileHandling
    {


        private string msg1 = "This is a text file.";
        private string msg2 = "This is a text file, and I can edit it.";
        //creates file 
        public string createFile(string myFileName)
        {
            string txt = ".txt";
            string fullFileName = myFileName + txt;
            string myPath = ".";
            //Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);


            string fullPath = $"{myPath}\\{fullFileName}";


            using (FileStream fs1 = File.Create(fullPath))
            using (StreamWriter sw = new StreamWriter(fs1))
            {

                sw.WriteLine(msg1);

            }

            Console.WriteLine("The file has been created.");
            return fullPath;


        }


        //edits existing files using StreamWriter
        public string editFile(string path)
        {


            using (FileStream f1 = File.OpenWrite(path))
            using (StreamWriter sw1 = new StreamWriter(f1))
            {
                sw1.WriteLine(msg2);

            }
            Console.WriteLine("The file at {0} was edited.", path);

            return path;
        }


        public void numberOfWords(string filePath)
        {
            string[] wordsArray;
            wordsArray = File.ReadAllLines(filePath, Encoding.UTF8);
            int count = wordsArray.Length;
            Console.WriteLine("Total count of words in the file is {0}.", count);

        }

        //extra method for counting chars
        public void numberChars(string filePath)
        {
            string[] wordsArray;
            wordsArray = File.ReadAllLines(filePath, Encoding.UTF8);
            int count = 0;
            foreach(string s in wordsArray)
            {
                foreach(char c in s)
                {
                    count++;
                }

            }

            Console.WriteLine("There are {0} characters in this file.", count);

        }


        public void longestWord(string filePath)
        {
            var file = File.ReadAllLines(filePath, Encoding.UTF8);
            var wordList = new List<string>(file);
            string longestWord = "";
            int longest = 0;

            foreach (string s in wordList)
            {
                if (s.Length > longest)
                {
                    longestWord = s;
                    longest = s.Length;
                }

            }

            Console.WriteLine("The longest word is {0}.", longestWord);

        }


        public void removeFile(string fileName)
        {
            if(File.Exists(fileName))
            {
                File.Delete(fileName);
                Console.WriteLine("The File has been deleted.");

            }
            else
            {
                Console.WriteLine("The file does not exist.");
            }
           
            //add additional method to check to see if the file exists.


        }



    }
}