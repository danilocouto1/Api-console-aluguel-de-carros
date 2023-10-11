namespace RentCars.Models;

public abstract class Person
{
    public string? Name { get; set; }
    public double? Debit { get; set; } = 0;
    public string? Email { get; set; }
    public string? Address { get; set; }
    public string? Contact { get; set; }

    public virtual string SendEmail()
    {
        return $"Sendind email to {this.Email}.";
    }

    public virtual string MakeContact()
    {
        return $"Calling {this.Contact}.";
    }

}