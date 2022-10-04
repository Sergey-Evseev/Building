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
        public List<Worker> workers; //список рабочих

        public Team() {
            leader = new TeamLeader("Ivan Petrovich");//создаем экземпляр бригадира
            
            workers = new List<Worker> {//инициализация списка workers
            new Worker ("Alex"), new Worker ("Den"), new Worker ("Sergey"), new Worker ("Vadim"), new Worker ("Oleg")
            };
        }
    }
}