namespace BubbleSort
{
    internal class Program
    {
        public struct Student
        {
            public string lastName;
        }

        static StreamReader sr;
        static void Main(string[] args)
        {
            sr = new StreamReader(@"assignmentName.txt");
            Student[] student = new Student[3];
            Student temp;
            int i = 0;
            while (!sr.EndOfStream && i < student.Length)
            {
                student[i].lastName = sr.ReadLine();
                i++;
            }
            for(i = 0; i < student.Length; i++)
            {
                for(int j = 0; j < student.Length - 1; j++)
                {
                    if (student[j].lastName.CompareTo(student[j+1].lastName) > 0)
                    {
                        temp = student[j];
                        student[j] = student[j + 1];
                        student[j + 1] = temp;
                    }
                }
            }
            for(i = 0; i < student.Length; i++)
            {
                Console.WriteLine(student[i].lastName);
            }
            sr.Close();
            Console.ReadLine();
        }
    }
}
