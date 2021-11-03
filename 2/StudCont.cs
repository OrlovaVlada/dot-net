using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace orlova2
{
    public class StudCont : IEnumerator, IEnumerable
    {
        private List<Student> list;
        private int position = -1;
        public StudCont()
        {
            list = new List<Student>();
        }
        public void Add(Student stud)
        {
            list.Add(stud);
        }
        public bool Delete(int index)
        {
            if (index < list.Count && index >= 0)
            {
                list.RemoveAt(index);
                return true;
            }
            return false;
        }

        public Student GetStudent(int index)
        {
            if (index < list.Count && index >= 0)
            {
                return list.ElementAt<Student>(index);
            }
            else throw new IndexOutOfRangeException();
        }

        public Student GetStudent(string name)
        {
            foreach (Student stud in list)
            {
                if (stud.Name == name)
                {
                    return stud;
                }
            }
            return null;
        }

        public int Count()
        {
            return list.Count;
        }
        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }
        //IEnumerator
        public bool MoveNext()
        {
            position++;
            return (position < list.Count());
        }
        //IEnumerable
        public void Reset()
        {
            position = 0;
        }
        //IEnumerable
        public object Current
        {
            get { return list.ElementAt<Student>(position); }
        }
        public string[] ToList()
        {
            string[] lines = new string[Count()];
            var i = 0;
            foreach (Student stud in list)
            {
                lines[i] = stud.ToString();
                i++;
            }
            return lines;
        }
    }
}