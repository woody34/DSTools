using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DSTools
{
    class FileMove
    {
        public static void FileMover(string from, string to)
        {
            MessageBox.Show(from + ">" + to);
            foreach (string file in Directory.GetFiles(from))
            {
                string fileName = Path.GetFileName(file);

                string moveToFileName = to + fileName;

                File.Move(file, moveToFileName);
            }
        }
        public static void DirectoryMover(string source, string destination)
        {
            Directory.Move(source, destination);
        }
    }
}