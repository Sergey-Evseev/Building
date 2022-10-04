using Building.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Building.Team
{
    internal class Worker : IWorker
    {
        string Name { get; set; }//поле от интерфейса
        string IWorker.Name => Name;

        public Worker(string name) {//конструктор объекта Worker
            Name = name;
        }

        public void Build(House house, TeamLeader leader) 
        {
            if (house.basement == null)
            {
                Basement basement = new Basement();
                basement.create(house); //метод создания бассейна в классе House
                //после созд. объекта в список отчета добавляется имя работника
                leader.reportList.Add($"Worker {Name} built the basement");
            }
            else if (house.walls == null || house.walls.Count < 4)
            {
                if (house.walls == null) house.walls = new List<Walls>();
                Walls wall = new Walls();
                wall.create(house);
                leader.reportList.Add($"Worker {Name} built the wall {house.walls.Count}");
            }
            else if (house.door == null)
            {
                Door door = new Door();
                door.create(house);
                leader.reportList.Add($"Worker {Name} built the door {house.window.Count}");
            }
            else if (house.window == null || house.window.Count < 4)
            {
                if (house.window == null) house.window = new List<Window>();
                Window window = new Window();
                window.create(house);
                leader.reportList.Add($"Worker {Name} built the window {house.window.Count}");
            }
            else if (house.roof == null)
            {
                Roof roof = new Roof();
                roof.create(house);
                leader.reportList.Add($"Worker {Name} built the roof");
            }        
        }
    }
}
