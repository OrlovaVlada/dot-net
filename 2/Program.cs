using System;

namespace orlova2
{
    class Program
    {
        static void Main(string[] args)
        {
            StudCont studList = new StudCont();
            studList.Add(new Student("Орлова Влада Станислвовна", new DateTime(2001, 12, 8), new DateTime(2019, 9, 1), "Б", 119, "КИТ", "Компьютерная инженерия", 94));
            studList.Add(new Student("Луговой Александр Евгениевич", new DateTime(2002, 4, 2), new DateTime(2019, 9, 1), "Б", 119, "КИТ", "Компьютерная инженерия", 95));
            studList.Add(new Student("Хлебникова Анастасия Дмитриевна", new DateTime(2002, 12, 10), new DateTime(2019, 9, 1), "Б", 119, "КИТ", "Компьютерная инженерия", 86));
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
