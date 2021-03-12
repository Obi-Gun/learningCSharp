using System;
using System.Collections.Generic;
using System.Linq;

namespace _9.CW_8._11._2020_Delegates
{
    public delegate double CalcDelegate(double x, double y);
    public delegate void ExamDelegate(string t);
    public delegate double AnonimDelegateDouble(double x, double y);
    public delegate void AnonimDelegateInt(int n);
    public delegate void AnonimDelegateVoid();

    public class Program
    {
        static void Main(string[] args)
        {
            // Task1();
            // Task2();
            // Task3();
            // Task4();
            //Task5();
            //Task6();
            //Task7();
            //Task8();
            //Task9();
            //Task10Extentions();
            //Task10Extentions2();
            //Task11Linq();
            //Task11Linq2();
            //Task11Linq4();
            Task12TestLazyQuerry();
        }

        private static void Task12TestLazyQuerry()
        {
            var arr = new List<int> { 1, 4, 65, 3, 8, 43, 85 };
            var res = arr.Select(x => x);
            arr[0] = 6666;
            foreach (var i in res)
                Console.WriteLine(i);

            arr[1] = 6666;
            foreach (var i in res)
                Console.WriteLine(i);

            arr[2] = 6666;
            foreach (var i in res)
                Console.WriteLine(i);
        }

        private static void Task1()
        {
            var calculator = new Calculator();
            CalcDelegate delAll = calculator.Add;
            delAll += Calculator.Sub;
            delAll += calculator.Mult;
            delAll += calculator.Div;

            Console.WriteLine($"Result: {delAll(5.7, 3.2)}");
            foreach (CalcDelegate item in delAll.GetInvocationList())
            {
                try
                {
                    Console.WriteLine($"Result: {item(5.7, 3.2)}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private static void Task2()
        {
            var group = new List<Student> {
                 new Student {
                 FirstName = "John",
                 LastName = "Miller",
                 BirthDate = new DateTime(1997,3,12)
                 },
                 new Student {
                 FirstName = "Candice",
                 LastName = "Leman",
                 BirthDate = new DateTime(1998,7,22)
                 },
                 new Student {
                 FirstName = "Joey",
                 LastName = "Finch",
                 BirthDate = new DateTime(1996,11,30)
                 },
                 new Student {
                 FirstName = "Nicole",
                 LastName = "Taylor",
                 BirthDate = new DateTime(1996,5,10)
                 }
            };
            Console.WriteLine("List of students:");
            group.ForEach(FullName);
        }

        private static void Task3()
        {
            var group = new List<Student> {
                 new Student {
                 FirstName = "John",
                 LastName = "Miller",
                 BirthDate = new DateTime(1997,3,12)
                 },
                 new Student {
                 FirstName = "Candice",
                 LastName = "Leman",
                 BirthDate = new DateTime(1998,7,22)
                 },
                 new Student {
                 FirstName = "Joey",
                 LastName = "Finch",
                 BirthDate = new DateTime(1996,11,30)
                 },
                 new Student {
                 FirstName = "Nicole",
                 LastName = "Taylor",
                 BirthDate = new DateTime(1996,5,10)
                 }
            };
            Console.WriteLine("List of students:");
            var arr = group.Select(FullName2);
            foreach (var s in arr)
                Console.WriteLine(s);
        }

        private static void Task4()
        {
            var group = new List<Student> {
                 new Student {
                 FirstName = "John",
                 LastName = "Miller",
                 BirthDate = new DateTime(1997,3,12)
                 },
                 new Student {
                 FirstName = "Candice",
                 LastName = "Leman",
                 BirthDate = new DateTime(1998,7,22)
                 },
                 new Student {
                 FirstName = "Joey",
                 LastName = "Finch",
                 BirthDate = new DateTime(1996,11,30)
                 },
                 new Student {
                 FirstName = "Nicole",
                 LastName = "Taylor",
                 BirthDate = new DateTime(1996,5,10)
                 }
            };
            Console.WriteLine("List of students:");
            var arr = group.FindAll(OnlySpring);
            foreach (var s in arr)
                Console.WriteLine(s);
        }

        private static void Task5()
        {
            var group = new List<Student> {
                 new Student {
                 FirstName = "John",
                 LastName = "Miller",
                 BirthDate = new DateTime(1997,3,12)
                 },
                 new Student {
                 FirstName = "Candice",
                 LastName = "Leman",
                 BirthDate = new DateTime(1998,7,22)
                 },
                 new Student {
                 FirstName = "Joey",
                 LastName = "Finch",
                 BirthDate = new DateTime(1996,11,30)
                 },
                 new Student {
                 FirstName = "Nicole",
                 LastName = "Taylor",
                 BirthDate = new DateTime(1996,5,10)
                 }
            };
            Console.WriteLine("List of students:");
            group.Sort(SortByBirthDate);
            foreach (var s in group)
                Console.WriteLine(s);
        }

        private static void Task6()
        {
            var group = new List<Student> {
                 new Student {
                 FirstName = "John",
                 LastName = "Miller",
                 BirthDate = new DateTime(1997,3,12)
                 },
                 new Student {
                 FirstName = "Candice",
                 LastName = "Leman",
                 BirthDate = new DateTime(1998,7,22)
                 },
                 new Student {
                 FirstName = "Joey",
                 LastName = "Finch",
                 BirthDate = new DateTime(1996,11,30)
                 },
                 new Student {
                 FirstName = "Nicole",
                 LastName = "Taylor",
                 BirthDate = new DateTime(1996,5,10)
                 }
            };
            var teacher = new Teacher();
            foreach (var student in group)
                teacher.ExamEvent += student.Exam;

            teacher.Exam("Task");
        }

        private static void Task7()
        {
            var group = new List<Student> {
                 new Student {
                 FirstName = "John",
                 LastName = "Miller",
                 BirthDate = new DateTime(1997,3,12)
                 },
                 new Student {
                 FirstName = "Candice",
                 LastName = "Leman",
                 BirthDate = new DateTime(1998,7,22)
                 },
                 new Student {
                 FirstName = "Joey",
                 LastName = "Finch",
                 BirthDate = new DateTime(1996,11,30)
                 },
                 new Student {
                 FirstName = "Nicole",
                 LastName = "Taylor",
                 BirthDate = new DateTime(1996,5,10)
                 }
            };
            var teacher = new Teacher();
            foreach (var student in group)
                teacher.ExamEvent2 += student.Exam;

            var eventArgs = new ExamEventArgs { Task = "Task 2 2 2 " };
            teacher.Exam(eventArgs);
        }

        private static void Task8()
        {
            Console.WriteLine("\tThe use of events");
            Dispacher dispacher = new Dispacher();
            // анонимный метод
            dispacher.eventDouble +=
            delegate (double a, double b)
            {
                if (b != 0)
                {
                    return a / b;
                }
                throw new DivideByZeroException();
            };
            double n1 = 5.7, n2 = 3.2;
            Console.WriteLine($"{n1} / {n2} = { dispacher.OnEventDouble(n1, n2)}"); // вызов
            Console.WriteLine(" Using a local variable");
            int number = 5;
            dispacher.eventVoid += delegate (int n)// анонимный
                                                   // метод
            {
                Console.WriteLine($"{number} + {n} = { number + n}");
            };
            dispacher.OnEventVoid();
            dispacher.OnEventVoid(6);
            Console.WriteLine("\tThe use of a delegate");
            AnonimDelegateVoid voidDel = new AnonimDelegateVoid(delegate
            { 
                Console.WriteLine("Ok!"); 
            });
            voidDel += delegate 
            { 
                Console.WriteLine("Bye!"); 
            };
            voidDel();
        }

        private static void Task9()
        {
            Console.WriteLine("\tThe use of events");
            var dispacher = new Dispacher();
            dispacher.eventDouble += (a, b) => 
            {
                if (b != 0)
                    return a / b;
                throw new DivideByZeroException();
            };
            double n1 = 5.7, n2 = 3.2;
            Console.WriteLine($"{n1} / {n2} = { dispacher.OnEventDouble(n1, n2)}");
            Console.WriteLine(" Using a local variable");
            int number = 5;
            dispacher.eventVoid += n => Console.WriteLine($"{number} + {n} = { number + n}");
            dispacher.OnEventVoid();
            dispacher.OnEventVoid(6);
            Console.WriteLine("\tThe use of a delegate");
            AnonimDelegateVoid voidDel = () => Console.WriteLine("Ok!");
            voidDel += () => Console.WriteLine("Bye!");
            voidDel();
        }

        private static void FullName(Student student)
        {
            Console.WriteLine($" {student.LastName}\t{student.FirstName}");
        }

        private static string FullName2(Student student)
        {
            return $" {student.LastName}\t{student.FirstName}";
        }

        private static bool OnlySpring(Student student)
        {
            return student.BirthDate.Month >=
            3 && student.BirthDate.Month <= 5;
        }

        private static int SortByBirthDate(Student student, Student student2)
        {
            return DateTime.Compare(student.BirthDate, student2.BirthDate);
        }

        private static void Task10Extentions()
        {
            Console.WriteLine("Enter the string:");
            string str = Console.ReadLine();
            Console.WriteLine($"The number of words in the string: { str.NumberWords()}");
        }

        private static void Task10Extentions2()
        {
            Console.WriteLine("Enter the string:");
            string str = Console.ReadLine();
            Console.WriteLine($"The number of words in the string: { str.NumberWords(str)}");
        }

        private static void Task11Linq()
        {
            int[] arrayInt = { 5, 34, 67, 12, 94, 42, 54, 33, 21, 90, 65 };
            IEnumerable<IGrouping<int, int>> query =
                from i in arrayInt
                group i by i % 10 into res
                where res.Count() > 1
                select res;

            Console.WriteLine("Groups with the number of elements is greater than 1:");
            foreach (IGrouping<int, int> key in query)
            {
                Console.Write($"Key: {key.Key}\nValue:");
                foreach (int item in key)
                {
                    Console.Write($"\t{item}");
                }
                Console.WriteLine();
            }
        }

        private static void Task11Linq2()
        {
            List<Group> groups = new List<Group>
            { 
                new Group { Id = 1, Name = "27PPS11" },
                new Group { Id = 2, Name = "27PPS12" },
                new Group { Id = 1, Name = "27PPS13" },
                new Group { Id = 2, Name = "27PPS14" }
            };
            List<Student> students = new List<Student> 
            {
                new Student { FirstName = "John",
                LastName = "Miller", GroupId = 2 },
                new Student { FirstName = "Candice",
                LastName = "Leman", GroupId = 1 },
                new Student { FirstName = "John",
                LastName = "Bob", GroupId = 4 },
                new Student { FirstName = "Candice",
                LastName = "Tod", GroupId = 1 },
                new Student { FirstName = "Joey",
                LastName = "Finch", GroupId = 1 },
                new Student { FirstName = "Nicole",
                LastName = "Taylor", GroupId = 2 },
                new Student { FirstName = "Joey",
                LastName = "Rex", GroupId = 3 },
                new Student { FirstName = "Nicole",
                LastName = "Poop", GroupId = 4 }
            };
            IEnumerable<Student> query = from g in groups
                                         join st in students on g.Id equals
                                         st.GroupId into res
                                         from r in res
                                         select r;
            Console.WriteLine("\tStudents in groups:");
            foreach (Student item in query)
            {
                Console.WriteLine($"Surname: { item.LastName}, " +
                    $"Name: { item.FirstName}, " +
                    $"Group: { groups.First(g => g.Id == item.GroupId).Name}");
            }
        }

        private static void Task11Linq3()
        {
            List<Group> groups = new List<Group>
            {
                new Group { Id = 1, Name = "27PPS11" },
                new Group { Id = 2, Name = "27PPS12" },
                new Group { Id = 1, Name = "27PPS13" },
                new Group { Id = 2, Name = "27PPS14" }
            };
            List<Student> students = new List<Student>
            {
                new Student { FirstName = "John",
                LastName = "Miller", GroupId = 2 },
                new Student { FirstName = "Candice",
                LastName = "Leman", GroupId = 1 },
                new Student { FirstName = "John",
                LastName = "Bob", GroupId = 4 },
                new Student { FirstName = "Candice",
                LastName = "Tod", GroupId = 1 },
                new Student { FirstName = "Joey",
                LastName = "Finch", GroupId = 1 },
                new Student { FirstName = "Nicole",
                LastName = "Taylor", GroupId = 2 },
                new Student { FirstName = "Joey",
                LastName = "Rex", GroupId = 3 },
                new Student { FirstName = "Nicole",
                LastName = "Poop", GroupId = 4 }
            };
            var query = from g in groups
                        join st in students on g.Id
                        equals st.GroupId
                        select new
                        {
                            FirstName = st.FirstName,
                            LastName = st.LastName,
                            GroupName = g.Name
                        };
            Console.WriteLine("\tStudents in groups:");
            foreach (var item in query)
            {
                Console.WriteLine($"Surname: { item.LastName}, " +
                    $"Name: { item.FirstName}, " +
                    $"Group: { item.GroupName}");
            }
        }

        private static void Task11Linq4()
        {
            List<Group> groups = new List<Group>
            {
                new Group { Id = 1, Name = "27PPS11" },
                new Group { Id = 2, Name = "27PPS12" },
                new Group { Id = 1, Name = "27PPS13" },
                new Group { Id = 2, Name = "27PPS14" }
            };
            List<Student> students = new List<Student>
            {
                new Student { FirstName = "John",
                LastName = "Miller", GroupId = 2, BirthDate = new DateTime(01, 01, 2003)},
                new Student { FirstName = "Candice",
                LastName = "Leman", GroupId = 1, BirthDate = new DateTime(01, 01, 2001) },
                new Student { FirstName = "John",
                LastName = "Bob", GroupId = 4, BirthDate = new DateTime(01, 01, 2009) },
                new Student { FirstName = "Candice",
                LastName = "Tod", GroupId = 1, BirthDate = new DateTime(01, 01, 1990) },
                new Student { FirstName = "Joey",
                LastName = "Finch", GroupId = 1, BirthDate = new DateTime(04, 01, 1996) },
                new Student { FirstName = "Nicole",
                LastName = "Taylor", GroupId = 2, BirthDate = new DateTime(11, 01, 1980) },
                new Student { FirstName = "Joey",
                LastName = "Rex", GroupId = 3, BirthDate = new DateTime(6, 01, 1969) },
                new Student { FirstName = "Nicole",
                LastName = "Poop", GroupId = 4, BirthDate = new DateTime(01, 01, 1986) }
            };
            const double daysOfYear = 365.25;
            var query = students.Where(s => (DateTime.Now - s.BirthDate).Days / daysOfYear > 20).Select(s => s);
            Console.WriteLine("\tStudents in groups:");
            foreach (var item in query)
            {
                Console.WriteLine($"Surname: { item.LastName}, " +
                    $"Name: { item.FirstName}, " +
                    $"Group: { item.BirthDate}");
            }
        }
    }
}
