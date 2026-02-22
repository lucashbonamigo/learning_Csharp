using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportGenerators
{
    public class ReportGenerator
    {
        public List<Dictionary<string,string>> Input { get; set; }

        public ReportGenerator(List<Dictionary<string, string>> input)
        {
            Input = input;
        }

        public string GerarRelatorio()
        {
            if (Input.Count == 0 || Input == null)
            {
                throw new Exception("Lista vazio ou nula!");
            }


            StringBuilder relatorio = new StringBuilder();

            string header = string.Join(';',Input.First().Keys);
            relatorio.AppendLine(header);

            foreach(Dictionary<string,string> input in Input)
            {
                string line = string.Join(';', input.Values);

                relatorio.AppendLine(line);
            }

            File.WriteAllText("relatorio.csv", relatorio.ToString());

            return Path.GetFullPath("relatorio.csv");
        }

    }
}
