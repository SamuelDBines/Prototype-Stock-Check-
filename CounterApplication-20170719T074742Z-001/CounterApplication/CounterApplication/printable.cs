using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterApplication
{
    class printable
    {

        private static string path = AppDomain.CurrentDomain.BaseDirectory;
        private string cleanPath;
        public printable()
        {
            string remove = @"\CounterApplication\bin\Debug";
            int index = path.IndexOf(remove);
            cleanPath = (index < 0) ? path : path.Remove(index, remove.Length);
           
        }
        public void print()
        {
            
            string path = cleanPath + "MyTest.txt";
            // This text is added only once to the file.
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Hello");
                    sw.WriteLine("And");
                    sw.WriteLine("Welcome");
                }
            }

            // This text is always added, making the file longer over time
            // if it is not deleted.
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("This");
                sw.WriteLine("is Extra");
                sw.WriteLine("Text");
            }

            // Open the file to read from.
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
