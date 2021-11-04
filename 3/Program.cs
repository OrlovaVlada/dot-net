using System;
using System.IO;

namespace orlova3
{
    public class Program
    {
        static void Main(string[] args)
        {
            var studList = new StudCont();
            studList.Add(new Student("Орлова Влада Станислвовна", new DateTime(2001, 12, 8), new DateTime(2019, 9, 1), "Б", 119, "КИТ", "Компьютерная инженерия", 94));
            studList.Add(new Student("Луговой Александр Евгениевич", new DateTime(2002, 4, 2), new DateTime(2019, 9, 1), "Б", 119, "КИТ", "Компьютерная инженерия", 95));
            studList.Add(new Student("Хлебникова Анастасия Дмитриевна", new DateTime(2002, 12, 10), new DateTime(2019, 9, 1), "Б", 119, "КИТ", "Компьютерная инженерия", 86));
            StudContFile helper = new StudContFile(studList);
            helper.Write(null , "C:\\Users\\Admin\\source\\repos\\orlova3\\orlova3\\output.txt");
            var studList2 = helper.Read("C:\\Users\\Admin\\source\\repos\\orlova3\\orlova3\\output.txt");
            var name = "Орлова Влада Станислвовна";
            var stud = studList2.GetStudent(name);
            stud.Performance += 5;
            studList2.ChangeStudent(name, stud);
        }
    }
}
