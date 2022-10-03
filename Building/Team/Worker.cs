﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building.Team
{
    internal class Worker : IWorker
    {
        string Name { get; set; }
        string IWorker.Name => Name;

        public Worker(string name) {
            Name = name;
        }

        public void Build(House house, TeamLeader leader) 
        {
            if (house.basement == null) {
                Basement basement = new Basement();
                basement.create(house);
                leader.report.Add($"Worker {Name} builded the basement");
            } 
        
        }






    }
}
