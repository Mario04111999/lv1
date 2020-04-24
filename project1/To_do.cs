using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class To_do
    {

        private List<TimeNote> tasks = new List<TimeNote>();

        public To_do(List<TimeNote> tasks)
        {
            this.tasks = tasks;
        }

        public void AddTask(string author, string text, int level)
        {
            TimeNote newTask = new TimeNote(author, text, level);
            tasks.Add(newTask);
        }

        public void CompleteTask(int index)
        {
            tasks.Remove(tasks[index]);
        }

        public TimeNote GetNote(int index)
        {
            if ((index <= tasks.Count) && index >= 0)
            {
                return tasks[index];
            }
            return null;
        }

        public string GetAllTasks()
        {
            string output = "";
            for (int i = 0; i < tasks.Count; i++)
            {
                output += tasks[i].ToString() + "\n";
            }
            return output;
        }

    }
}
