// See https://aka.ms/new-console-template for more information

using gbAlgorithms;

List<Lesson> lessons = new List<Lesson>();
Lesson lesson1 = new Lesson1();
Lesson lesson2 = new Lesson2();
lessons.Add(lesson1);
lessons.Add(lesson2);

while (true)
{
    getTasksMenu(getLessonMenu());
}

int getLessonMenu()
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

int getTasksMenu(int lessonNumber)
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

