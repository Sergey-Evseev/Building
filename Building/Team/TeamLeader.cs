using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building.Team
{
    internal class TeamLeader : IWorker
    {
        string Name { get; set; }
        public List<string> reportList = new List<string>(); 
        string IWorker.Name => Name;

        public TeamLeader(string name) {
            Name = name;
        }
        public void Report() {
            double count = reportList.Count / 11.0 * 100;
        }

    }
}
