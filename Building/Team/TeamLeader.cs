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
        public List<string> report = new List<string>(); 
        string IWorker.Name => Name;

        public Worker(string name) {
            Name = name;
        }

    }
}
