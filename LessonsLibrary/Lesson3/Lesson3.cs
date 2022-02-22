using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gbAlgorithms
{
    public class Lesson3 : Lesson
    {

        Lesson3Task1 Task1 = new Lesson3Task1();
        public Lesson3()
        {
            Description = "Lesson 3. Class, Structure, Distance";
            Tasks = new List<ITask>();

            Tasks.Add(Task1);
        }

        public override void RunTask(int taskNumber)
        {
            Console.Clear();
            switch (taskNumber)
            {
                case 0:
                    Task1.calculateTime(100000);
                    Task1.calculateTime(200000);
                    break;
                
                default:
                    break;
            }

            Console.WriteLine("Press any button to return to the main menu.");
            Console.ReadKey();

        }
    }
}
