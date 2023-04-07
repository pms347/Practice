using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Net;

namespace Practice
{
    class LinqExample
    {
        // string collection
        private IList<string> stringList = new List<string>() {
            "C# Tutorials",
            "VB.NET Tutorials",
            "Learn C++",
            "MVC Tutorials" ,
            "Java"
        };

        public LinqExample()
        {
            LinqExampleMethod(stringList);
            //StudExample();

        }
        private void LinqExampleMethod(IList<string> stringList)
        {
            

            var result = from s in stringList where s.Contains("Tutorials") select s;

            foreach (var t in result)
            {
                Console.WriteLine(t);
            }

            IList<int> listE = new List<int>() { 6,1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 5, 5, 5, 5 };
            IList<string> listS = new List<string>() { "A","A","B","B"};
            var rst = listE.GroupBy(i => i).Where(g => g.Count() > 1).Select(g => g.Key).ToList();
            var result1 = listE.GroupBy(i => i).Where(g => g.Count() > 1).Select(g => g.Key).ToList().OrderBy(x => x);
            var result2 = listS.GroupBy(i => i).Where(g => g.Count() > 1).Select(g => g.Key).ToArray();
            string str = "MMOOHHAANN";
            var s1 = str.Distinct().ToString();

        }

        private void StudExample()
        {
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
                new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 13 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 21} ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 13 }
            };

            var groupedResult = from s in studentList
                                group s by s.Age;

            var lookupResult = studentList.ToLookup(s => s.Age);

            foreach (Student std in studentList)
            {
                Console.WriteLine(std.StudentID+"," + std.StudentName+"," + std.Age);
            }

            var t1 = studentList.Where(x => x.Age > 12 && x.Age < 20).OrderBy(y => y.Age).ThenBy(z => z.StudentName).ToList<Student>();

            // LINQ Query Syntax to find out teenager students
            var teenAgerStudent = from s in studentList
                                  where s.Age > 12 && s.Age < 20
                                  select s;
        }


    }

    public class Student
    {
        public int StudentID = 0;
        public string StudentName = string.Empty;
        public int Age = 0;
    }

    public class parent
    {

    }
}
