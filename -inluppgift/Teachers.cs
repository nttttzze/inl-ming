namespace _inluppgift;

public class Teachers : Students
{
    public string Kunskapsområde { get; private set; } = "";
    public string Courses { get; private set; } = "";


     public Teachers(string firstName, string lastName, string phone, string ssNumber, string address, string postalCode, string city, string kunskapsområde, string courses)
        : base (firstName, lastName, phone, ssNumber, address, postalCode, city) 
     {
        Kunskapsområde = kunskapsområde;
        Courses = courses;
     }

    public override string ToString()
    {
        return $"First name: {FirstName} Last name: {LastName} Phone: {Phone} Social security: {SsNumber} Address: {Address} Postal code: {PostalCode} City: {City} Kunskapsområde: {Kunskapsområde} Course: {Courses}";
    }
    
}