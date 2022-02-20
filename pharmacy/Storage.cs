using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy
{
    public class Storage
    {
        public string path = @"C:\Users\blvck\source\repos\pharmacy\storage\medicines.txt";

        public List<Medicine> getFile()
        {
            List<Medicine> med = new List<Medicine>();
            if (File.Exists(path))
            {
                foreach (string line in File.ReadLines(path))
                {
                    string[] words = line.Split("/");
                    med.Add(new Medicine(words[0], int.Parse(words[1]), int.Parse(words[2]), int.Parse(words[3])));
                }
            }
            else
            {
                using (FileStream fs = File.Create(path)) fs.Close();
            }
            return med;
        }

        public void addMedicine(string name, int qty, float price, int i)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    sw.WriteLine(name + "/" + qty + "/" + price + "/" + i);
                    sw.Close();
                }
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
