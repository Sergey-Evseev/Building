using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building.Team
{
    internal class Team : IWorker
    {
        public string Name {
            get => "Best Contractors";
        }
        public TeamLeader leader;
        public List<Worker> workers;

        public Team() {
            leader = new TeamLeader("Petrovich");
            
            workers = new List<Worker> {
            new Worker ("Alex"), new Worker ("Den"), new Worker ("Ivan"), new Worker ("Vadim"), new Worker ("Oleg")
            };
        }
    }
}
