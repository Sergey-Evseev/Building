/*Задание 1.Реализовать программу “Строительство дома”. Реализовать:
• Классы: House(Дом), Basement(Фундамент), Walls(Стены), Door(Дверь), Window(Окно), Roof(Крыша); 
Team(Бригада строителей), Worker(Строитель), TeamLeader(Бригадир).
• Интерфейсы: IWorker, IPart. 
Все части дома должны реализовать интерфейс IPart (Часть дома), для рабочих и бригадира предоставляется
базовый интерфейс IWorker (Рабочий).
Бригада строителей(Team) строит дом(House). Дом состоит из фундамента (Basement), стен(Wall), окон (Window), дверей (Door), крыши(Part).
Согласно проекту, в доме должно быть 1 фундамент, 4 стены, 1 дверь, 4 окна и 1 крыша.
Бригада начинает работу, и строители последовательно “строят” дом, начиная с фундамента. Каждый строитель не знает заранее, 
на чём завершился предыдущий этап строительства, поэтому он “проверяет”, что уже построено и продолжает работу. Если в игру вступает бригадир
(TeamLeader), он не строит, а формирует отчёт, что уже построено и какая часть работы выполнена.
В конечном итоге на консоль выводится сообщение, что строительство дома завершено и отображается “рисунок дома” 
(вариант отображения выбрать самостоятельно).*/

using Building.Parts;
using Building.Team;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    internal class Program
    {        

        static void Main(string[] args)
        {
            House house = new House();
            Team.Team team = new Team.Team();                       
            
            Console.WriteLine(team.Name);

            Random random = new Random();
                        

            for (int i = 0; i < 6; i++)
            {
                team.workers[random.Next(0, 3)].Build(house, team.leader);
            }
            
            team.leader.ProgressReport();
            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                team.workers[random.Next(0, 3)].Build(house, team.leader);
            }

            foreach (var item in team.leader.reportList)
            {
                Console.WriteLine(item);
            }

            team.leader.ProgressReport();

            house.drawHouse(team.leader);
            Console.ReadKey();
        }
    }
}
