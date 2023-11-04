namespace RentCars.Types;

//9 - Crie um enum `RentStatus`
public enum RentStatus
{
    Confirmed,
    Finished,
    Canceled = Finished
}