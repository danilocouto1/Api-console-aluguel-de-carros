namespace RentCars.Models;

public class LegalPerson : Person
{
    public string? SocialReason { get; set; }
    public string? CNPJ { get; set; }
}