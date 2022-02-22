using System.Reflection;
using gbAlgorithms;

Assembly asm = Assembly.LoadFrom("LessonsLibrary.dll");

Type type = asm.GetType("gbAlgorithms.Lesson1");
object Lesson1 = Activator.CreateInstance(type);

type = asm.GetType("gbAlgorithms.Lesson2");
object Lesson2 = Activator.CreateInstance(type);

type = asm.GetType("gbAlgorithms.Lesson3");
object Lesson3 = Activator.CreateInstance(type);

type = asm.GetType("gbAlgorithms.Lesson4");
object Lesson4 = Activator.CreateInstance(type);

List<Lesson> lessons = new List<Lesson>();
lessons.Add((Lesson)Lesson1);
lessons.Add((Lesson)Lesson2);
lessons.Add((Lesson)Lesson3);
lessons.Add((Lesson)Lesson4);

while (true)
{
    GetTasksMenu(GetLessonMenu());
}

int GetLessonMenu()
{
    while (true)
    {
        int counter = 1;
        int lessonNumber;
        Console.Clear();
        Console.WriteLine("Lessons List:");

        foreach (var item in lessons)
        {
            Console.WriteLine($"{counter}. {item.Description}");
            counter++;
        }
        Console.WriteLine($"{counter}. Exit");

        Console.WriteLine("\nEnter Lesson Number:");

        Int32.TryParse(Console.ReadLine(), out lessonNumber);
        if (lessonNumber < counter && lessonNumber > 0)
        {
            return lessonNumber - 1;
        }
        else if (lessonNumber == counter)
        {
            Environment.Exit(0);
        }
    }
}

int GetTasksMenu(int lessonNumber)
{
    Console.Clear();
    Console.WriteLine("Tasks List:");
    int taskNumber;
    lessons[lessonNumber].TasksMenu();
    Console.WriteLine("\nEnter Task Number:");
    Int32.TryParse(Console.ReadLine(), out taskNumber);
    lessons[lessonNumber].RunTask(taskNumber - 1);

    return 0;
}

