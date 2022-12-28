

using Inheritance.Service;

Console.WriteLine(" Student: ");
var student1 = new Student(" Shahrom ", " Dushanbe ");

student1.AddCouseGrade("C++", 10);
student1.AddCouseGrade("Html", 25);
student1.AddCouseGrade("Css", 10);

Console.Write(" PrintGrades: ");
student1.PrintGrades();
Console.WriteLine();
Console.Write(" Avarege: ");
Console.WriteLine(student1.GetAvaregeGrade());

Console.WriteLine ( " Name and Addres:" );
Console.WriteLine(student1.ToString());
Console.WriteLine();



Console.WriteLine( " Teacher: " );
var teacher1 = new Teacher(" Teacher ", " Dushanbe " );

teacher1.AddCourse(" C++");
teacher1.AddCourse(" C#");
teacher1.AddCourse(" Css");

Console.WriteLine(" " + teacher1.AddCourse(" Css"));
teacher1.PrintCourse();
Console.WriteLine();

Console.WriteLine (teacher1.ToString());
