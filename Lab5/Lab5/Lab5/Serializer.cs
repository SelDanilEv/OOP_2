using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public class Serializer
    {
        DataContractJsonSerializer jsonformatter = new DataContractJsonSerializer(typeof(List<Discipline>));

        public List<Discipline> ReadFile()
        {
            List<Discipline> disciplines;
            using (FileStream fs = new FileStream("Discipline.json", FileMode.OpenOrCreate))
            {
                disciplines = (List<Discipline>)jsonformatter.ReadObject(fs);
            }
            return disciplines;
        }

        public void WriteFile(Discipline discipline)
        {
            var list = ReadFile();
            list.Add(discipline);
            using (FileStream fs = new FileStream("Discipline.json", FileMode.Open))
            {
                jsonformatter.WriteObject(fs, list);
            }
        }
    }
}
