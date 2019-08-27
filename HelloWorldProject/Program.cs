//Two forward slashes to add note in Visual Studios
// = an assignment, take the value on the right and use it on the left    
// == a check for equality, to see if the two things are equal  
//

using System;

namespace HelloWorldProject {
    class Program {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello C# Boot Camp World!");
            Console.WriteLine("At MAX Technical Trainning");
            int daysInBootcamp = 6;
            if (daysInBootcamp == 6)
            {
                Console.WriteLine("Yes"); //The if statement is controlling which lines get to be executed, when false the line is not executed
            }
            else
            {
                Console.WriteLine("No"); //after adding the else clause if statement is false it will write No

            }
            string instructor = "";
            instructor = "Greg";
            Console.WriteLine(instructor);
            string lastname = "Doud";
            Console.WriteLine(instructor + " " + lastname); // + sign is a way to put two strings together [like cacat() in SQL]
        }
    }
}
