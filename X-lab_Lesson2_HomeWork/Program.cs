using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_lab_Lesson2_HomeWork
{
    public class ActivePlayers
    {
        private List<string> activePlayers = new List<string>();

        public string this[int index]
        {
            get { return activePlayers[index]; }
            set { activePlayers[index] = value; }
        }
    }


    public class Program
    {
        static void Main(string[] args)
        {
            
            //Создаем Лист и сразу добавляем в него три элемента
            List<string> players = new List<string>() { "Alex", "Nico", "Max" };  

            Console.WriteLine("Players:");

            foreach (string layer in players) 
            {
                Console.WriteLine(layer);
            }
          
            //Добавляем по значению в Лист три элемента
            AddNewPlayers(players);
                                 
            Console.WriteLine("After Add players:");

            foreach (string layer in players)
            {
                Console.WriteLine(layer);
            }


            //Добавляем по индексу в Лист три элемента
            InsertNewPlayers(players);

            Console.WriteLine("After Insert players:");

            foreach (string layer in players)
            {
                Console.WriteLine(layer);
            }


            //Удаляем из Листа элемент по значению (первый совпавший по значению)
            RemovePlayers(players);

            Console.WriteLine("After Remove players:");

            foreach (string layer in players)
            {
                Console.WriteLine(layer);
            }


            //Удаляем из листа все элементы по значению
            RemoveAllPlayers(players);

            Console.WriteLine("After RemoveAll players:");

            foreach (string layer in players)
            {
                Console.WriteLine(layer);
            }


            //Удаляем из Листа элемент по индексу
            RemoveAtPlayers(players);

            Console.WriteLine("After RemoveAt players:");

            foreach (string layer in players)
            {
                Console.WriteLine(layer);
            }


            //Очищаем Лист
            ClearPlayersList(players);

            Console.WriteLine("After Clear players:");

            foreach (string layer in players)
            {
                Console.WriteLine(layer);
            }

        }

        private static void AddNewPlayers(List<string> players)
        {
            players.Add("Nik");


            players.Add("Roman");


            players.Add("Viki");
        }

        private static void InsertNewPlayers(List<string> players)
        {
            players.Insert(0, "Andy");

            players.Insert(3, "Lisa");

            players.Insert(4, "Alex");
        }

       private static void RemovePlayers(List<string> players)
       {
           string removeValue = "Max";

           players.Remove(removeValue);
       }

       private static void RemoveAllPlayers(List<string> players)
       {
           string removeValueAll = "Alex";

           players.RemoveAll(x => x == removeValueAll);
       }

       private static void RemoveAtPlayers(List<string> players)
       {
           players.RemoveAt(3);
       }

       private static void ClearPlayersList(List<string> players)
       {
           players.Clear();
       }
                
    }
        
}
