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

            //Looping
            var ints = new int[] { 1, 2, 3, 4, 5 };
            var total = 0;
            var index = 0;
            //Looping with while()
            while (index < 5) {
                total = total + (ints[index] * ints[index]);
                index = index + 1;
            }
            Console.WriteLine("Total is " + total);

            //Looping with for()
            total = 0;
            for (var idx = 0; idx < 5; idx = idx + 1) {
                total = total + (ints[idx] * ints[idx]); }
            Console.WriteLine("Total is " + total);

            //Assignment --- compute the average
            var scores = new int[] { 738, 609, 307, 959, 805, 689, 402, 972, 359, 140 };
            var tot = 0;
            for (var idx = 0; idx < 10; idx++) 
                { tot = tot + scores[idx];
            }
            var avg = tot / 10;
            Console.WriteLine("Average is " + avg);

            //looping with foreach()
            var grandtotal = 0;
            foreach(var score in scores) {
                grandtotal += score;
            }
            avg = grandtotal / 10;
            Console.WriteLine("Grandtotal " + grandtotal);
            Console.WriteLine("Avg " + avg);

            //Floting point numbers 
            var totalDistance = 0.0;
            var distances = new double[] {5.99, 3.56, 8.99, 7.47, 8.17, 6.78, 6.33};
            foreach(var distance in distances) {
                totalDistance += distance;
            }
            var avgdistance = totalDistance / distances.Length;
            Console.WriteLine("Avg is " + totalDistance / distances.Length);

            //Arrays 
            int[] students = new int[5];
            students[0] = 7;
            students[1] = 3;
            students[2] = 4;
            students[3] = 15;
            students[4] = 5;

            string[] names = new string[7];
            names[0] = "Jeremy";
            names[1] = "Justin";
            names[2] = "Alex";
            names[3] = "Nick";
            names[4] = "Phill";
            names[5] = "Tricia";
            names[6] = "Lidya";
        }


    }
    }



