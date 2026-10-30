namespace BubbleSort
{
    internal class Program
    {
        public struct Student
        {
            public string firstName;
            public string lastName;
            public string interest;
            public int score;
        }

        static StreamReader sr;
        static void Main(string[] args)
        {
            HandInLab();
            Console.ReadLine();
        }



        static void HandInLab()
        {
            sr = new StreamReader(@"wheelOfFortune.txt");
            Student[] student = new Student[23];
            Student temp;
            int i = 0;
            while (!sr.EndOfStream && i < student.Length)
            {
                student[i].firstName = sr.ReadLine();
                student[i].lastName = sr.ReadLine();
                student[i].interest = sr.ReadLine();
                student[i].score = int.Parse(sr.ReadLine());
                i++;
            }
            for (i = 0; i < student.Length; i++)
            {
                for (int j = 0; j < student.Length - 1; j++)
                {
                    if (student[j].lastName.CompareTo(student[j + 1].lastName) > 0)
                    {
                        temp = student[j];
                        student[j] = student[j + 1];
                        student[j + 1] = temp;
                    }
                }
            }
            Console.Write("First Name".PadRight(25));
            Console.Write("Last Name".PadRight(25));
            Console.Write("Interest Name".PadRight(25));
            Console.WriteLine("Score".PadRight(25));
            for (i = 0; i < student.Length; i++)
            {
                Console.Write(student[i].firstName.PadRight(25));
                Console.Write(student[i].lastName.PadRight(25));
                Console.Write(student[i].interest.PadRight(25));
                Console.WriteLine($"{student[i].score}".PadRight(25));
            }
            sr.Close();
        }
    }
}
