namespace C_Sharp_Assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course cSharp = new Course();
            cSharp.Name = "C# Fundamentals";
            cSharp.CourseID = 1;
            cSharp.Code = "CMSK154";

            cSharp.students.Add(new Student() { StudentId = 1, FirstName = "John", LastName = "Jones" });
            cSharp.students.Add(new Student() { StudentId = 2, FirstName = "Karen", LastName = "Knight" });
            cSharp.students.Add(new Student() { StudentId = 3, FirstName = "Susan", LastName = "Steavens" });


            Course javaScript = new Course();
            javaScript.Name = "JavaScript Fundamentals";
            javaScript.CourseID = 2;
            javaScript.Code = "CMSK152";

            javaScript.students.Add(new Student() { StudentId = 4, FirstName = "Allen", LastName = "Anderson" });
            javaScript.students.Add(new Student() { StudentId = 5, FirstName = "Gerry", LastName = "Garvis" });



            List<Course> courses = new List<Course> { cSharp, javaScript };


            Console.WriteLine("Course List");
            Console.WriteLine("--------------------------------------------");

            foreach (Course course in courses)
            {
                Console.WriteLine($"{course.CourseID} {course.Code} {course.Name}");

                foreach (Student student in course.students)
                {
                    Console.WriteLine($"       {student.StudentId} {student.FirstName} {student.LastName}");
                }

            }


        }
    }
}