using System.ComponentModel.DataAnnotations;

namespace _inluppgift;

public class Students
{
    public string FirstName { get; private set; } = "";
    public string LastName { get; private set; } = "";
    public string Phone { get; private set; } = "";
    public string SsNumber { get; private set; } = "";
    public string Address { get; private set; } = "";
    public string PostalCode { get; private set; } = "";
    public string City { get; private set; } = "";

    public Students(string firstName, string lastName, string phone, string ssNumber, string address, string postalCode, string city )
    {
        FirstName = firstName;
        LastName = lastName;
        Phone = phone;
        SsNumber = ssNumber;
        Address = address;
        PostalCode = postalCode;
        City = city;
    }


    public override string ToString()
    {
        return $"First name: {FirstName} Last name: {LastName} Phone: {Phone} Social security: {SsNumber} Address: {Address} Postal code: {PostalCode} City: {City}";
    }
}
