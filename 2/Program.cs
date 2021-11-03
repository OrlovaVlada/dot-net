using System;

namespace orlova2
{
    class Program
    {
        static void Main(string[] args)
        {
            StudCont studList = new StudCont();
            studList.Add(new Student("Луговой Александр Евгениевич", new DateTime(2002, 4, 2), new DateTime(2019, 9, 1), "Б", 119, "КИТ", "Компьютерные игры", 95));
            studList.Add(new Student("Орлова Влада Станислвовна", new DateTime(2001, 12, 8), new DateTime(2019, 9, 1), "Б", 119, "КИТ", "Компьютерные игры", 94));
            studList.Add(new Student("Мыглин Андрей Александрович", new DateTime(2002, 3, 31), new DateTime(2019, 9, 1), "Б", 119, "КИТ", "Компьютерные игры", 67));
            studList.Add(new Student("Хаврюта Андрей Юрьевич", new DateTime(2002, 3, 10), new DateTime(2019, 9, 1), "В", 419, "КИТ", "АТМ", 75));
            studList.Add(new Student("Васильев Даниил Анатолиевич", new DateTime(2002, 12, 24), new DateTime(2019, 9, 1), "В", 419, "КИТ", "АТМ", 71));
            Console.WriteLine("\nI.Вывод в полном формате\n");
            int a = 1;
            foreach (Student stud in studList) { 

                Console.WriteLine(a + "." + stud.ToText());
                a++;
            }
            Console.WriteLine("\n");
            Console.WriteLine("\nII.Удаление элемента на позиции 2 и вывод в кратком формате\n");
            studList.Delete(2);
            a = 1;
            foreach (Student stud in studList)
            {

                Console.WriteLine(a + "." + stud.ToText());
                a++;
            }
            Console.WriteLine("\n");
            Console.WriteLine("\nIII.Получение информации о конкретном студенте по имени (Хаврюта...)\n");
            Console.WriteLine("\n");
            Console.WriteLine(studList.GetStudent("Хаврюта Андрей Юрьевич").ToString());
            Console.WriteLine("\n");
            int i = 1;
            Console.WriteLine("\nIV.Вывод студентов с их успеваемостью при помощи foreach\n");
            foreach (Student stud in studList)
            {
                Console.WriteLine(i + "." + stud.Name + ": " + stud.Performance + "\n");
                i++;
            }
        }
    }
}
