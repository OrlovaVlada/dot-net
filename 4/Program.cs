using System;
using System.IO;

namespace orlova4
{
    public class Program
    {
        static void Main(string[] args)
        {
            var studList = new StudCont();
            studList.Add(new Student("Орлова Влада Станиславовна", new DateTime(2001, 12, 8), new DateTime(2019, 9, 1), "Б", 119, "КИТ", "Компьютерные игры", 94));
            studList.Add(new Student("Луговой Александр Евгениевич", new DateTime(2002, 4, 2), new DateTime(2019, 9, 1), "Б", 119, "КИТ", "Компьютерные игры", 95));
            studList.Add(new Student("Мыглин Андрей Александрович", new DateTime(2002, 3, 31), new DateTime(2019, 9, 1), "Б", 119, "КИТ", "Компьютерные игры", 67));
            studList.Add(new Student("Хлебникова Анастасия Дмитриевна", new DateTime(2002, 12, 10), new DateTime(2019, 9, 1), "Б", 119, "КИТ", "Компьютерные игры", 90));
            var name = "Орлова Влада Станиславовна";
            var stud = studList.GetStudent(name);

            Console.WriteLine($"Группа студента {name}: {stud.Group}");
            Console.WriteLine("\n");

            Console.WriteLine($"Курс студента {name}: {stud.Year}");
            Console.WriteLine("\n");

            Console.WriteLine($"Семестр студента {name}: {stud.Semester}");
            Console.WriteLine("\n");

            Console.WriteLine($"Возраст студента {name}: {stud.Age}");
            Console.WriteLine("\n");
        }
    }
}