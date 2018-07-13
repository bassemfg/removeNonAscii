using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Data;

namespace removeNonAscii
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue headers = new Queue();
            StringBuilder sb = new StringBuilder();
            StringBuilder sbFileRemoveSpaces = new StringBuilder();
           // String[] columns = null;
            string line = "";
            //object[] columnNames = null;
            StreamReader sr = null;
            Stream stream = null;
            StreamWriter sw = new StreamWriter(@"c:\test\metadata\metadata_asciionly.csv");
            FileInfo file = new FileInfo(@"c:\test\metadata\metadata.csv");
            //stream = f.OpenText().BaseStream;
            sr = file.OpenText();
            int i = 0;
            while (sr.Peek() >= 0)
            {
                //read a line in the CSV file
                line = sr.ReadLine();
                if (line.Trim().Length > 0) 
                {
                    if (line.IndexOf(".") > 0)
                      i++; // Console.WriteLine(line);
                    line = Encoding.ASCII.GetString(Encoding.ASCII.GetBytes(line));
                    sb.Append(line);
                    sb.Append(@"
");
                    
                }
            }

            sw.Write(sb.ToString());
            sw.Flush();
                sw.Close();

            Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}
