using System;

namespace filehandling2
{
    class Program
    {
        static void Main(string[] args)
        {
            string scrabblePath = ".\\scrabble.txt";
            FileHandling fh = new FileHandling();
            string filePath = fh.createFile("test1");
            fh.editFile(filePath);
            string filePath2 = fh.createFile("test2");
            fh.removeFile(filePath2);
            fh.longestWord(scrabblePath);
            fh.numberOfWords(scrabblePath);
            fh.numberChars(scrabblePath);

        }
    }
}
