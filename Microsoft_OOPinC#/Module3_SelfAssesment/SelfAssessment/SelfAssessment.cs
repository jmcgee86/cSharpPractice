using System;

namespace SelfAssessment
{
    class Program
    {
        static void Main(string[] args)
        {
            UProgram schoolProgram1 =  new UProgram("Information Technology");
            Degree bachelors = new Degree("Bachelors Degree");
            schoolProgram1.degrees[0] = bachelors;
            Course course1 = new Course("Programming with C#");
            bachelors.courses[0] = course1;

            Teacher teacher1 = new Teacher("Dr. Janet", "Doe", "Female", 38);
            course1.teachers[0] = teacher1;
            Student student1 = new Student ("Tom", "Sawyer");
            Student student2 = new Student ("Jane", "Smithers", "Female", 20);
            Student student3 = new Student ("Bob", "Smith", "Male", 22);
            course1.students[0] = student1;
            course1.students[1] = student2;
            course1.students[2] = student3;

            student3.WriteDetails("test.txt");
            student3.ReadDetails("test.txt");
            student3.Dispose();

            Console.WriteLine("The program of {0} offers a {1}", schoolProgram1.programName, schoolProgram1.degrees[0].degree);
            Console.WriteLine("The {0} program offers a great course called {1}", schoolProgram1.degrees[0].degree, bachelors.courses[0].course);
            Console.WriteLine("There are {0} students in the class and it is taught by {1} {2}", Student.studentCount, course1.teachers[0].firstName, course1.teachers[0].lastName);
            Console.WriteLine(course1.students[2].takeTest());
            Console.WriteLine(course1.students[1].takeTest());
            Console.WriteLine(course1.teachers[0].gradeTest());        
        }
    }
}
