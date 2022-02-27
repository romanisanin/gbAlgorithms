using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gbAlgorithms
{
    public class Lesson7 : Lesson
    {

        Lesson7Task1 Task1 = new Lesson7Task1();
        public Lesson7()
        {
            Description = "Lesson 7. Dynamic Programming";
            Tasks = new List<ITask>();

            Tasks.Add(Task1);
        }

        public override void RunTask(int taskNumber)
        {
            Console.Clear();
            switch (taskNumber)
            {
                case 0:
                    Task1.RoutesNumber();
                    break;

                default:
                    break;
            }

            Console.WriteLine("Press any button to return to the main menu.");
            Console.ReadKey();

        }
    }
}
