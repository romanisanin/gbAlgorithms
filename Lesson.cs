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
        public Lesson(string description)
        {
            tasks = new List<Task>();
            Description = description;
        }
    }
}
