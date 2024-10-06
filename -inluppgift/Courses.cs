using System.Dynamic;

namespace _inluppgift;

// Ska lägga till lista för att kunna lista alla kurser.
public class SchoolCourses
{
    public int CourseNumber { get; private set; }
    public string Title { get; private set; }
    public int LengthInWeeks { get; private set; }
    public DateTime StartDate { get; private set; }
    public DateTime EndDate { get; private set; }
    public bool IsDistanceCourse { get; private set; }


    //public List<SchoolCourses> Courses { get; private set; } = new List<SchoolCourses>();


    // Constructor
    public SchoolCourses(int courseNumber, string title, int lengthInWeeks, DateTime startDate, DateTime endDate, bool isDistanceCourse)
    {
        CourseNumber = courseNumber;
        Title = title;
        LengthInWeeks = lengthInWeeks;
        StartDate = startDate;
        EndDate = endDate;
        IsDistanceCourse = isDistanceCourse;
    }
    

    public override string ToString()
    {
        return $"Coursenumber: {CourseNumber} Course Title: {Title} Course Length in weeks: {LengthInWeeks} Start date: {StartDate} End date: {EndDate} Remote course: {IsDistanceCourse} ";
    }

}