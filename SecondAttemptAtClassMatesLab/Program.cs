using System;
using System.Collections.Generic;
using System.Text;

namespace SecondAttemptAtClassMatesLab
{
    class Program
    {
        static void Main(string[] args)
        {
            //I was unable to figure out how to incorporte the list in the program
            // The three possible parts of an object are: Properties, Constructors, and Methods



            Console.WriteLine("Welcome To Our C# Class");
            Console.WriteLine();
            Console.WriteLine("Our Students Are: ");
            Console.WriteLine();
            Console.WriteLine("1. Calyn Greene");
            Console.WriteLine("2. Shawn Thomas");
            Console.WriteLine("3. Stone Capone");
            bool anotherStudent;
            do
            {


                int numOfStudents = 3;
                const int SIZE = 3;




                Student studentNames1 = new Student("Calyn Greene", "Portage, MI", "Mac and Cheese");
                Student studentNames2 = new Student("Shawn Thomas", "Detoit, MI", "Fried Chicken");
                Student studentNames3 = new Student("Stone Capone", "Canton, MI", "Salmon");

                Student[] menu = { new Student("Calyn Greene", "Portage, MI", "Mac and Cheese"), new Student("Shawn Thomas", "Detoit, MI", "Fried Chicken"), new Student("Stone Capone", "Canton, MI", "Salmon") };

                foreach (Student student in menu)
                {
                    Console.WriteLine(student.Name);
                    Console.WriteLine(student.HomeTown);
                    Console.WriteLine(student.FavoriteFood);
                }
                Console.ReadKey();

                menu[0] = studentNames1;
                menu[0] = studentNames2;
                menu[0] = studentNames3;






                string[] homeTowns = new string[SIZE];
                homeTowns[0] = "Portage, MI";
                homeTowns[1] = "Detroit, MI";
                homeTowns[2] = "Canton, MI";

                string[] favFoods = new string[SIZE];
                favFoods[0] = "Mac and Cheese";
                favFoods[1] = "Fried Chicken";
                favFoods[2] = "Salmon";
                //List<Student> students = new List<Student>();
                //students.Add(new Student("Calyn Greene", "Portgae, MI", "Mac and Cheese"));
                //students.Add(new Student("Shawn Thomas", "Detroit, MI", "Fried Chicken"));
                //students.Add(new Student("Stone Capone", "Canton, MI", "Salmon"));






                //Console.WriteLine();
                //Console.WriteLine("Would you like to select a student by name or number? ");
                //Console.WriteLine("To search by Student Name (Enter 1) To search by Student Number (Enter 2): ");
                //int userinput = int.Parse(Console.ReadLine());
                //Console.WriteLine();
                //while (userinput <= 0 || userinput > 2)
                //{
                //    Console.WriteLine("ERROR: That selection does not exist.");
                //    Console.WriteLine("To search by Student Name (Enter 1) To search by Student Number (Enter 2): ");
                //    userinput = int.Parse(Console.ReadLine());
                //}
                //if(userinput == 1)
                //{
                //    Console.WriteLine();
                //    Console.Write("Which student would you like to learn about? (Enter student's first and last name): ");
                //    string userinput2 = Console.ReadLine().ToLower();
                //    if(userinput2 == "Calyn Greene")
                //    {
                //        Console.WriteLine($" What would you like to know about {studentNames[0]}?");
                //    }
                //    else if(userinput2 == "Shawn Thomas")
                //    {
                //        Console.WriteLine($" What would you like to know about {studentNames[1]}?");
                //    }
                //    else if(userinput2 == "Stone Capone")
                //    {
                //        Console.WriteLine($" What would you like to know about {studentNames[2]}?");
                //    }

                //}else if(userinput == 2)
                //{
                //    Console.Write("Enter a number between 1 and 3: ");
                //}


                //    Console.WriteLine("Which student would you like to learn about? ");
                //    Console.Write("Enter a number between 1 and 3: ");
                //    int userInput = int.Parse(Console.ReadLine());
                //    while ( userInput <= 0 || userInput > 3)
                //    {
                //        Console.WriteLine("ERROR: This student does not exist.");
                //        Console.Write("Enter a number between 1 and 3: ");
                //        userInput = int.Parse(Console.ReadLine());
                //    }
                //    if (userInput == 1)
                //    {
                //        Console.WriteLine($"Student {userInput} is { students[0]}. What would you like to know about {students[0]}?");

                //    }
                //    else if (userInput == 2)
                //    {
                //        Console.WriteLine($"Student {userInput} is {students[1]}. What would you like to know about {students[1]}?");

                //    }
                //    else if (userInput == 3)
                //    {
                //        Console.WriteLine($"Student {userInput} is {students[2]}. What would you like to know about {students[2]}?");

                //    }

                //    Console.Write("Enter \"Hometown\" or \"Favorite Food\": ");
                //    string userInput2 = Console.ReadLine().ToLower(); ;



                //    while (userInput2 != "hometown" && userInput2 != "favorite food")
                //    {
                //        Console.WriteLine("ERROR: This data does not exist.");
                //        Console.Write("Enter \"Hometown\" or \"Favorite Food\": ");
                //        userInput2 = Console.ReadLine();

                //    }
                //    if (userInput2 == "hometown")
                //    {
                //        Console.WriteLine($"{students} is from {students[0]}");
                //    }
                //    else
                //    {
                //        Console.WriteLine($"{students} really likes {students[0]}");
                //    }

                //    Console.WriteLine("Would you like to learn about another student? ");
                //    Console.Write("Enter \"yes\" or \"no\": ");

                //    string userInput3 = Console.ReadLine().ToLower();

                //    while (userInput3 != "yes" && userInput3 != "no")
                //    {
                //        Console.WriteLine("I'm sorry, I didn't understand that.");
                //        Console.Write("Please Enter \"yes\" or \"no\": ");
                //        userInput3 = Console.ReadLine().ToLower();
                //    }


                //    if (userInput3 != "yes")
                //    {

                //        Console.WriteLine("Have a great day :)");
                //        break;

                //    }

                //} while (true);
                // }








        class Student
        {
            public string Name { get; set; }
            public string HomeTown { get; set; }
            public string FavoriteFood { get; set; }

            public Student(string Name, string HomeTown, string FavoriteFood)
            {
                this.Name = Name;
                this.HomeTown = HomeTown;
                this.FavoriteFood = FavoriteFood;

            }
        }

    }
}


        

