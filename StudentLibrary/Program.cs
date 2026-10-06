

using StudentLibrary;

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student("Jay", 200);
        Student student1 = new Student("Darragh", 400);
        student.Display();
        student1.Display();
      
        int olderAge = student.GetOlder(student.Age);
        student.Age = olderAge;
        student.Display();
        //Console.WriteLine($" Older Age: {olderAge}");
    }
}


