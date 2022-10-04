using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building.Team
{
    internal class TeamLeader : IWorker
    {
        public string Name { get; set; }

        public List<string> reportList = new List<string>(); //создание списка отчета
        
        public TeamLeader(string name) {
            Name = name;
        }

        public void ProgressReport() {//подсчет и вывод прогресса стройки
            double count = (reportList.Count / 11.0) * 100;
            Console.WriteLine($"{(int) count}% of work completed");
        }
    }
}
