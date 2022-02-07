using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gbAlgorithms
{
    public class Lesson
    {
        public List<Task> Tasks;
        public string Description { get; set; }
        public Lesson()
        {
            Tasks = new List<Task>();
        }

        public void TasksMenu()
        {
            foreach (var task in Tasks)
            {
                Console.WriteLine(task.Description);
            }
        }

        public virtual void RunTask(int taskNumber)
        {

        }
    }
}
