using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotChocolate.Types;
namespace gbAlgorithms
{
    internal class Task1
    {
        public static void GetTasks(Lesson lesson)
        {
            List<object> tasks = new List<object>();   
            Type taskClass = null;
            foreach (Type t in typeof(Program).Assembly.GetTypes())
            {
                if (t.FullName.Contains(lesson.Description))
                {
                    Object instance = (Object)Activator.CreateInstance(t);
                    tasks.Add(instance);
                }                
            }
            foreach (var item in tasks)
            {
                
            }
        }

    }
}
