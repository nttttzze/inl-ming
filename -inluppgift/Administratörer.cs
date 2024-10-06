namespace _inluppgift;

public class Admin : EdLeaders
{
    public Admin(string firstName, string lastName, string phone, string ssNumber, string address, string postalCode, string city, string kunskapsområde, string courses, DateTime employmentDate)
        : base (firstName, lastName, phone, ssNumber, address, postalCode, city, kunskapsområde, courses, employmentDate)
    {

    }

    public override string ToString()
    {
        return $"First name: {FirstName} Last name: {LastName} Phone: {Phone} Social security: {SsNumber} Address: {Address} Postal code: {PostalCode} City: {City} Kunskapsområde: {Kunskapsområde} Course: {Courses} Employment date: {EmploymentDate}";
    }
}