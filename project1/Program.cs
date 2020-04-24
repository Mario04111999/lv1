using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Biljeska a = new Biljeska("Preston inovation");
            Biljeska b = new Biljeska("Milo Columbo", "tubertini tim");
            Biljeska c = new Biljeska("Senssas", "trabucco", 4);

            Console.WriteLine("a.GetTekst(), Autor: a.GetAutor()");
            Console.WriteLine("b.GetTekst(), Autor: b.GetAutor()");
            Console.WriteLine("c.GetTekst(), Autor: c.GetAutor()");


            TimeNote note = new TimeNote("mario", "maver tim", 0);
            Console.WriteLine(note.ToString());

            List<TimeNote> tasks = new List<TimeNote>();
            To_do todaysTasks = new To_do(tasks);
            string autor, tekst;
            int vaznost;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ime:");
                autor = Console.ReadLine();
                Console.WriteLine("Unesite biljesku:");
                tekst = Console.ReadLine();
                Console.WriteLine("Vaznost:");
                vaznost = Convert.ToInt32(Console.ReadLine());
                todaysTasks.AddTask(autor, tekst, vaznost);
            }


            Console.WriteLine(todaysTasks.GetAllTasks());

            int maxPriorityIndex = 0;
            int maxValue = tasks[0].GetVaznost();
            for (int i = 0; i <= tasks.Count; i++)
            {
                maxValue = tasks[i].GetVaznost();
                maxPriorityIndex = i;
                for (int j = 0; j < tasks.Count; j++)
                {
                    if (tasks[j].GetVaznost() > maxValue)
                    {
                        maxValue = tasks[j].GetVaznost();
                        maxPriorityIndex = j;
                    }
                }
                todaysTasks.CompleteTask(maxPriorityIndex);
            }
            todaysTasks.CompleteTask(0);

            Console.WriteLine(todaysTasks.GetAllTasks());
        }
    }
}
