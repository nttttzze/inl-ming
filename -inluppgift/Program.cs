using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace _inluppgift;

class Program
{
    static void Main()
    {
        // Lägger till 2 kurser. 
        MenuManager.coursesList.Add(new SchoolCourses(10, "Programmering 4", 10, DateTime.Today, DateTime.Today.AddDays(70), true ));
        MenuManager.coursesList.Add(new SchoolCourses(9, "Intro C Sharp", 4, DateTime.Today, DateTime.Today.AddDays(28), false ));
        // Lägger till 2 elerver.
        MenuManager.studentList.Add(new Students("Nataniel", "Johansson", "0702401010", "011107", "Oxievång 1", "238 37", "Malmö"));
        MenuManager.studentList.Add(new Students("Simon", "Johansson", "070242020", "001107", "Kungsgatan 9", "264 51", "Ljungbyhed"));

        // Lägger till kurser i Json dokumnet //Lägger bara till när programmet körs.
        var path = string.Concat(Environment.CurrentDirectory, "/data/kurser.json");
        var json = JsonSerializer.Serialize(MenuManager.coursesList);
        File.WriteAllText(path, json);
        
        Console.Clear();
    
        bool runProgram = true;
        while (runProgram)
        {
            Menu.ShowMenu();

            string choice = Console.ReadLine()!;

            switch(choice)
            {
                case "1": /* Add Course */
                MenuManager.addCourse();
                break;

                case "2": // Add Student
                MenuManager.addStudent();
                break;

                case "3":  //Lärare
                MenuManager.addTeacher();
                break;

                case "4":  // Lägg Utbildningsledare (EdLeader)
                MenuManager.addEdLeader();
                break;


                case "5":  // Lägg till Administratör 
                MenuManager.addAdmin();
                break;

                case "6": /* Show all courses */
                MenuManager.showCourses();
                break;

                case "7": /* SHOW ALL STUDENTS */
                MenuManager.showStudents();
                break;

                case "0":
                runProgram = false;
                break;
            }
        }
    }
}