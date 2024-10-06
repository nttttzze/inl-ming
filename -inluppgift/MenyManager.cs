using System.ComponentModel;
using Microsoft.VisualBasic;

namespace _inluppgift;


public class MenuManager
{
    
    public static List<SchoolCourses> coursesList = new List<SchoolCourses>();
    public static List<Students> studentList = new List<Students>();
    public static List<Teachers> teacherList = new List<Teachers>();
    public static List<EdLeaders> edList = new List<EdLeaders>();
    public static List<Admin> adminList = new List<Admin>();

    public static void addCourse()
    {
        try
        {
        Console.WriteLine("Ange kursnummer: ");
        int courseNumber = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Ange titel: ");
        string title = Console.ReadLine()!;

        Console.WriteLine("Ange kurslängd i veckor: ");
        int lengthInWeeks = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Ange startdatum: (yyyy-mm-dd)");
        DateTime startDate = DateTime.Parse(Console.ReadLine()!);

        Console.WriteLine("Ange slutdatum: (yyyy-mm-dd)");
        DateTime endDate = DateTime.Parse(Console.ReadLine()!);

        Console.WriteLine("Distansutbildning: (true/false) ");
        bool isDistanceCourse = bool.Parse(Console.ReadLine()!);

        SchoolCourses newCourse = new SchoolCourses(courseNumber, title, lengthInWeeks, startDate, endDate, isDistanceCourse);
        coursesList.Add(newCourse);
        } 
        catch (Exception)
        {
            Console.WriteLine("Feeeeel! Skriv in rätt värde.");
        } 
    }

    public static void showCourses()
    {  
        foreach (var course in coursesList)
         {
            Console.WriteLine(course.ToString());
         } 
    }

    public static void addStudent()
    {
        try
        {
        Console.WriteLine("Förnamn: ");
        string firstName = Console.ReadLine()!;

        Console.WriteLine("Efternamn: ");
        string lastName = Console.ReadLine()!;

        Console.WriteLine("Telefonnummer: ");
        string phone = Console.ReadLine()!;

        Console.WriteLine("Personnummer: ");
        string ssNumber = Console.ReadLine()!;

        Console.WriteLine("Address: ");
        string address = Console.ReadLine()!;

        Console.WriteLine("Postnummer: ");
        string postalCode = Console.ReadLine()!;

        Console.WriteLine("Ort: ");
        string city = Console.ReadLine()!;

        Students newStudent = new Students(firstName, lastName, phone, ssNumber, address, postalCode, city );
        studentList.Add(newStudent);
        } 
        catch (Exception)
        {
            Console.WriteLine("Feeeeel! Skriv in rätt värde.");
        }

    }
    
    public static void showStudents()
    {
       foreach (var student in studentList)
        {
        Console.WriteLine(student.ToString());
        }
    }

    public static void addTeacher()
    {
        try
        {
         Console.WriteLine("Förnamn: ");
        string TeachersfirstName = Console.ReadLine()!;

        Console.WriteLine("Efternamn: ");
        string TeacherslastName = Console.ReadLine()!;

        Console.WriteLine("Telefonnummer: ");
        string Teachersphone = Console.ReadLine()!;

        Console.WriteLine("Personnummer: ");
        string TeachersssNumber = Console.ReadLine()!;

        Console.WriteLine("Address: ");
        string Teachersaddress = Console.ReadLine()!;

        Console.WriteLine("Postnummer: ");
        string TeacherspostalCode = Console.ReadLine()!;

        Console.WriteLine("Ort: ");
        string Teacherscity = Console.ReadLine()!;

        Console.WriteLine("Kunskapsområde: ");
        string kunskapsområde = Console.ReadLine()!;

        Console.WriteLine("Kurser: ");
        string courses = Console.ReadLine()!;

        Teachers newTeacher = new Teachers(TeachersfirstName, TeacherslastName, Teachersphone, TeachersssNumber, Teachersaddress, TeacherspostalCode, Teacherscity, kunskapsområde, courses);
        teacherList.Add(newTeacher);

        } 
        catch (Exception)
        {
            Console.WriteLine("Feeeeel! Skriv in rätt värde.");
        }
    }

    public static void addEdLeader()
    {
        try
        {
        Console.WriteLine("Förnamn: ");
        string EdLeaderfirstName = Console.ReadLine()!;

        Console.WriteLine("Efternamn: ");
        string EdLeaderlastName = Console.ReadLine()!;

        Console.WriteLine("Telefonnummer: ");
        string EdLeaderphone = Console.ReadLine()!;

        Console.WriteLine("Personnummer: ");
        string EdLeaderssNumber = Console.ReadLine()!;

        Console.WriteLine("Address: ");
        string EdLeaderaddress = Console.ReadLine()!;

        Console.WriteLine("Postnummer: ");
        string EdLeaderpostalCode = Console.ReadLine()!;

        Console.WriteLine("Ort: ");
        string EdLeadercity = Console.ReadLine()!;

        Console.WriteLine("Kunskapsområde: ");
        string EdLeaderkunskapsområde = Console.ReadLine()!;

        Console.WriteLine("Kurser: ");
        string  Edleaderscourses = Console.ReadLine()!;

        Console.WriteLine("Anställningsdatum: ");
        DateTime EmploymentDate = DateTime.Parse(Console.ReadLine()!);

        EdLeaders newEdleader = new EdLeaders(EdLeaderfirstName, EdLeaderlastName, EdLeaderphone, EdLeaderssNumber, EdLeaderaddress, EdLeaderpostalCode, EdLeadercity, EdLeaderkunskapsområde, Edleaderscourses, EmploymentDate);
        edList.Add(newEdleader);
        } 
        catch (Exception)
        {
            Console.WriteLine("Feeeeel! Skriv in rätt värde.");
        }
    }

    public static void addAdmin()
    {
        try
        {
        Console.WriteLine("Förnamn: ");
        string AdminfirstName = Console.ReadLine()!;

        Console.WriteLine("Efternamn: ");
        string AdminlastName = Console.ReadLine()!;

        Console.WriteLine("Telefonnummer: ");
        string Adminphone = Console.ReadLine()!;

        Console.WriteLine("Personnummer: ");
        string AdminssNumber = Console.ReadLine()!;

        Console.WriteLine("Address: ");
        string Adminaddress = Console.ReadLine()!;

        Console.WriteLine("Postnummer: ");
        string AdminpostalCode = Console.ReadLine()!;

        Console.WriteLine("Ort: ");
        string Admincity = Console.ReadLine()!;

        Console.WriteLine("Kunskapsområde: ");
        string Adminkunskapsområde = Console.ReadLine()!;

        Console.WriteLine("Kurser: ");
        string Admincourses = Console.ReadLine()!;

        Console.WriteLine("Anställningsdatum: ");
        DateTime AdminEmploymentDate = DateTime.Parse(Console.ReadLine()!);

        Admin newAdmin = new Admin(AdminfirstName, AdminlastName, Adminphone, AdminssNumber, Adminaddress, AdminpostalCode, Admincity, Adminkunskapsområde, Admincourses, AdminEmploymentDate);
        adminList.Add(newAdmin);
        } 
        catch (Exception)
        {
            Console.WriteLine("Feeeeel! Skriv in rätt värde.");
        }
    }


}