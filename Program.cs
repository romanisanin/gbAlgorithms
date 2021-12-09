// See https://aka.ms/new-console-template for more information

using gbAlgorithms;

Console.WriteLine("1. Lesson1. Block diagrams, asymptotic complexity, recursion");
Console.WriteLine("Enter a lesson number");
int lessonid = Int32.Parse(Console.ReadLine());
Console.Clear();
switch (lessonid-1)
{
    case 0: Lesson1 lesson1 = new Lesson1();
        break;
    default:
        break;
}



List<Lesson> lessons= new List<Lesson>();
lessons.Add(new Lesson("Lesson1"));

while (true)
{
    int counter = 1;
    foreach (var item in lessons)
    {
        Console.WriteLine($"{counter}. {item.Description}");
        counter++;
    }
    int number;
    Int32.TryParse(Console.ReadLine(), out number);
    Task1.GetTasks(lessons[number - 1]);
}
