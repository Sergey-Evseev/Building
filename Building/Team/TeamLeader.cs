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

        public List<string> progressList = new List<string>(); //создание списка отчета
        
        public TeamLeader(string name) {
            Name = name;
        }

        public void PercentageReport() {//подсчет и вывод прогресса стройки
            double count = (progressList.Count / 11.0) * 100; //всего 11 этапов строительства
            Console.WriteLine($"Currently {(int) count}% of work completed");
        }
    }
}
