// See https://aka.ms/new-console-template for more information

using gbAlgorithms;

List<Lesson> lessons = new List<Lesson>();
lessons.Add(new Lesson1());
lessons.Add(new Lesson2());
lessons.Add(new Lesson3());
lessons.Add(new Lesson4());

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

