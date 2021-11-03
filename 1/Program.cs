using System;
namespace orlova1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stud1 = new Student("Орлова Влада Станиславовна", new DateTime(2001, 12, 8), new DateTime(2019, 9, 1), "Б", 119, "КИТ", "Компьютерная инженерия", 97);
            Student stud2 = new Student("Хлебникова Анастасия Дмитриевна", new DateTime(2001, 12, 10), new DateTime(2019, 9, 1), "Б", 119, "КИТ", "Компьютерная инженерия", 96); 
            
            Console.WriteLine(stud1.ToText());
            Console.WriteLine("\n");
            Console.WriteLine(stud2.ToText());
        }
    }
}
