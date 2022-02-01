using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gbAlgorithms
{
    internal class Lesson
    {
        public List<Task> tasks;
        public string Description { get; set; }
        public Lesson()
        {
            tasks = new List<Task>();
        }

        public void TasksMenu()
        {
            foreach (var task in tasks)
            {
                Console.WriteLine(task.Description);
            }
        }

        public virtual void runTask(int taskNumber)
        {
            
        }
    }
}
