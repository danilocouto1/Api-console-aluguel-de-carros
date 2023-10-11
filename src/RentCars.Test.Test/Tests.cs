using Xunit;
using FluentAssertions;
using System;
using System.Reflection;
using System.Collections.Generic;
using RentCars.Types;
using RentCars.Models;

#pragma warning disable CS8600
#pragma warning disable CS8602

namespace RentCars.Test;

public class TestReq01
{
    [Trait("Category", "1. Crie uma `Struct` para as **Cores**")]
    [Theory(DisplayName = "Color deve ter a propriedade Nome do tipo String")]
    [MemberData(nameof(ColorShouldHaveNameAttributeData))]
    public void ColorShouldHaveNameAttribute(Color colorEntry, string expected)
    {
        colorEntry.Name.Should().Be(expected);
    }

    public static TheoryData<Color, string> ColorShouldHaveNameAttributeData = new()
    {
        { new Color() { Name = "SomeName" }, "SomeName" },
        { new Color() { Name = "SomeName2" }, "SomeName2" },
        { new Color() { Name = "SomeName3" }, "SomeName3" },
    };

    [Trait("Category", "1. Crie uma `Struct` para as **Cores**")]
    [Theory(DisplayName = "Color deve ter a propriedade Hex do tipo String")]
    [MemberData(nameof(ColorShouldHaveHexAttributeData))]
    public void ColorShouldHaveHexAttribute(Color colorEntry, string expected)
    {
        colorEntry.Hex.Should().Be(expected);
    }

    public static TheoryData<Color, string> ColorShouldHaveHexAttributeData = new()
    {
        { new Color() { Hex = "SomeName" }, "SomeName" },
        { new Color() { Hex = "SomeName2" }, "SomeName2" },
        { new Color() { Hex = "SomeName3" }, "SomeName3" },
    };
}

public class TestReq02
{
    [Trait("Category", "2. Crie um enum `FuelType`")]
    [Theory(DisplayName = "FuelType deve ter as constantes e valores corretos")]
    [InlineData(10, "Alcohol")]
    [InlineData(20, "Gasoline")]
    [InlineData(30, "Flex")]
    [InlineData(40, "Diesel")]
    [InlineData(50, "Electric")]
    [InlineData(60, "Hybrid")]
    public void FuelTypeShouldHaveCorrectValues(int valueEntry, string expected)
    {
        var value = valueEntry;
        var actual = Enum.GetName(typeof(FuelType), value);
        Assert.Equal(expected, actual);
    }
}

public class TestReq03
{
    [Trait("Category", "3. Crie a classe `Vehicle`")]
    [Fact(DisplayName = "Vehicle deve ter a propriedade Brand do tipo String")]
    public void VehicleShouldHaveBrandAttribute()
    {
        try
        {
            var vehicle = new Vehicle();
            var property = vehicle.GetType().GetProperty("Brand");
            Assert.NotNull(property);
            Assert.Equal(typeof(string), property.PropertyType);
            Assert.True(property.CanRead);
            Assert.True(property.CanWrite);
        }
        catch (Exception)
        {
            Assert.True(false, "A propriedade Brand não foi encontrada");
        }
    }

    [Trait("Category", "3. Crie a classe `Vehicle`")]
    [Fact(DisplayName = "Vehicle deve ter a propriedade Model do tipo String")]
    public void VehicleShouldHaveModelAttribute()
    {
        try
        {
            var vehicle = new Vehicle();
            var property = vehicle.GetType().GetProperty("Model");
            Assert.NotNull(property);
            Assert.Equal(typeof(string), property.PropertyType);
            Assert.True(property.CanRead);
            Assert.True(property.CanWrite);
        }
        catch (Exception)
        {
            Assert.True(false, "A propriedade Model não foi encontrada");
        }
    }

    [Trait("Category", "3. Crie a classe `Vehicle`")]
    [Fact(DisplayName = "Vehicle deve ter a propriedade Price do tipo decimal")]
    public void VehicleShouldHavePriceAttribute()
    {
        try
        {
            var vehicle = new Vehicle();
            var property = vehicle.GetType().GetProperty("Price");
            Assert.NotNull(property);
            Assert.Equal(typeof(decimal), property.PropertyType);
            Assert.True(property.CanRead);
            Assert.True(property.CanWrite);
        }
        catch (Exception)
        {
            Assert.True(false, "A propriedade Price não foi encontrada");
        }
    }


    [Trait("Category", "3. Crie a classe `Vehicle`")]
    [Fact(DisplayName = "Vehicle deve ter a propriedade Fuel do tipo FuelType")]
    public void VehicleShouldHaveFuelAttribute()
    {
        try
        {
            var vehicle = new Vehicle();
            var property = vehicle.GetType().GetProperty("Fuel");
            Assert.NotNull(property);
            Assert.Equal(typeof(FuelType), property.PropertyType);
            Assert.True(property.CanRead);
            Assert.True(property.CanWrite);
        }
        catch (Exception)
        {
            Assert.True(false, "A propriedade Fuel não foi encontrada");
        }
    }

    [Trait("Category", "3. Crie a classe `Vehicle`")]
    [Fact(DisplayName = "Vehicle deve ter a propriedade EngineCapacity do tipo int")]
    public void VehicleShouldHaveEngineCapacityAttribute()
    {
        try
        {
            var vehicle = new Vehicle();
            var property = vehicle.GetType().GetProperty("EngineCapacity");
            Assert.NotNull(property);
            Assert.Equal(typeof(int), property.PropertyType);
            Assert.True(property.CanRead);
            Assert.True(property.CanWrite);
        }
        catch (Exception)
        {
            Assert.True(false, "A propriedade EngineCapacity não foi encontrada");
        }
    }

    [Trait("Category", "3. Crie a classe `Vehicle`")]
    [Fact(DisplayName = "Vehicle deve ter a propriedade Year do tipo int")]
    public void VehicleShouldHaveYearAttribute()
    {
        try
        {
            var vehicle = new Vehicle();
            var property = vehicle.GetType().GetProperty("Year");
            Assert.NotNull(property);
            Assert.Equal(typeof(int), property.PropertyType);
            Assert.True(property.CanRead);
            Assert.True(property.CanWrite);
        }
        catch (Exception)
        {
            Assert.True(false, "A propriedade Year não foi encontrada");
        }
    }

    [Trait("Category", "3. Crie a classe `Vehicle`")]
    [Fact(DisplayName = "Vehicle deve ter a propriedade PricePerDay do tipo double")]
    public void VehicleShouldHavePricePerDayAttribute()
    {
        try
        {
            var vehicle = new Vehicle();
            var property = vehicle.GetType().GetProperty("PricePerDay");
            Assert.NotNull(property);
            Assert.Equal(typeof(double), property.PropertyType);
            Assert.True(property.CanRead);
            Assert.True(property.CanWrite);
        }
        catch (Exception)
        {
            Assert.True(false, "A propriedade PricePerDay não foi encontrada");
        }
    }

    [Trait("Category", "3. Crie a classe `Vehicle`")]
    [Fact(DisplayName = "Vehicle deve ter a propriedade IsRented do tipo bool")]
    public void VehicleShouldHaveIsRentedAttribute()
    {
        try
        {
            var vehicle = new Vehicle();
            var property = vehicle.GetType().GetProperty("IsRented");
            Assert.NotNull(property);
            Assert.Equal(typeof(bool), property.PropertyType);
            Assert.True(property.CanRead);
            Assert.True(property.CanWrite);
        }
        catch (Exception)
        {
            Assert.True(false, "A propriedade IsRented não foi encontrada");
        }
    }

}

public class TestReq04
{
    [Trait("Category", "4. Crie um enum `BrakeType`")]
    [Theory(DisplayName = "BrakeType deve ter as constantes e valores corretos")]
    [InlineData(1, "Chamber")]
    [InlineData(2, "Disc")]
    [InlineData(3, "Drum")]
    public void BrakeTypeShouldHaveCorrectValues(int valueEntry, string expected)
    {
        var value = valueEntry;
        var actual = Enum.GetName(typeof(BrakeType), value);
        Assert.Equal(expected, actual);
    }
}

public class TestReq05
{
    [Trait("Category", "5. Crie um enum `TractionType`")]
    [Theory(DisplayName = "TractionType deve ter as constantes e valores corretos")]
    [InlineData(0, "FrontWheelDrive")]
    [InlineData(1, "RearWheelDrive")]
    [InlineData(2, "AllWheelDrive")]
    public void TractionTypeShouldHaveCorrectValues(int valueEntry, string expected)
    {
        var value = valueEntry;
        var actual = Enum.GetName(typeof(TractionType), value);
        Assert.Equal(expected, actual);
    }
}

public class TestReq06
{
    [Trait("Category", "6. Faça a classe `Car` herdar de `Vehicle`")]
    [Fact(DisplayName = "Car deve herdar de Vehicle")]
    public void CarShouldInheritFromVehicle()
    {
        var car = new Car();
        Assert.IsAssignableFrom<Vehicle>(car);
    }

    [Trait("Category", "6. Faça a classe `Car` herdar de `Vehicle`")]
    [Fact(DisplayName = "Car deve ter a propriedade Seats do tipo int")]
    public void CarShouldHaveSeatsAttribute()
    {
        try
        {
            var car = new Car();
            var property = car.GetType().GetProperty("Seats");
            Assert.NotNull(property);
            Assert.Equal(typeof(int), property.PropertyType);
            Assert.True(property.CanRead);
            Assert.True(property.CanWrite);
        }
        catch (Exception)
        {
            Assert.True(false, "A propriedade Seats não foi encontrada");
        }
    }

    [Trait("Category", "6. Faça a classe `Car` herdar de `Vehicle`")]
    [Fact(DisplayName = "Car deve ter a propriedade Doors do tipo int")]
    public void CarShouldHaveDoorsAttribute()
    {
        try
        {
            var car = new Car();
            var property = car.GetType().GetProperty("Doors");
            Assert.NotNull(property);
            Assert.Equal(typeof(int), property.PropertyType);
            Assert.True(property.CanRead);
            Assert.True(property.CanWrite);
        }
        catch (Exception)
        {
            Assert.True(false, "A propriedade Doors não foi encontrada");
        }
    }

    [Trait("Category", "6. Faça a classe `Car` herdar de `Vehicle`")]
    [Fact(DisplayName = "Car deve ter a propriedade Traction do tipo TractionType")]
    public void CarShouldHaveTractionAttribute()
    {
        try
        {
            var car = new Car();
            var property = car.GetType().GetProperty("Traction");
            Assert.NotNull(property);
            Assert.Equal(typeof(TractionType), property.PropertyType);
            Assert.True(property.CanRead);
            Assert.True(property.CanWrite);
        }
        catch (Exception)
        {
            Assert.True(false, "A propriedade Traction não foi encontrada");
        }
    }

    [Trait("Category", "6. Faça a classe `Car` herdar de `Vehicle`")]
    [Fact(DisplayName = "Car deve ter a propriedade FrontBrake do tipo BrakeType")]
    public void CarShouldHaveFrontBrakeAttribute()
    {
        try
        {
            var car = new Car();
            var property = car.GetType().GetProperty("FrontBrake");
            Assert.NotNull(property);
            Assert.Equal(typeof(BrakeType), property.PropertyType);
            Assert.True(property.CanRead);
            Assert.True(property.CanWrite);
        }
        catch (Exception)
        {
            Assert.True(false, "A propriedade FrontBrake não foi encontrada");
        }
    }

    [Trait("Category", "6. Faça a classe `Car` herdar de `Vehicle`")]
    [Fact(DisplayName = "Car deve ter a propriedade RearBrake do tipo BrakeType")]
    public void CarShouldHaveRearBrakeAttribute()
    {
        try
        {
            var car = new Car();
            var property = car.GetType().GetProperty("RearBrake");
            Assert.NotNull(property);
            Assert.Equal(typeof(BrakeType), property.PropertyType);
            Assert.True(property.CanRead);
            Assert.True(property.CanWrite);
        }
        catch (Exception)
        {
            Assert.True(false, "A propriedade RearBrake não foi encontrada");
        }
    }
}

public class TestReq07
{
    [Trait("Category", "7. Faça a classe `Motorcycle` herdar de `Vehicle`")]
    [Fact(DisplayName = "Motorcycle deve herdar de Vehicle")]
    public void MotorcycleShouldInheritFromVehicle()
    {
        var motorcycle = new Motorcycle();
        Assert.IsAssignableFrom<Vehicle>(motorcycle);
    }

    [Trait("Category", "7. Faça a classe `Motorcycle` herdar de `Vehicle`")]
    [Fact(DisplayName = "Motorcycle deve ter a propriedade SeatHeight do tipo double")]
    public void MotorcycleShouldHaveSeatHeightAttribute()
    {
        try
        {
            var motorcycle = new Motorcycle();
            var property = motorcycle.GetType().GetProperty("SeatHeight");
            Assert.NotNull(property);
            Assert.Equal(typeof(double), property.PropertyType);
            Assert.True(property.CanRead);
            Assert.True(property.CanWrite);
        }
        catch (Exception)
        {
            Assert.True(false, "A propriedade SeatHeight não foi encontrada");
        }
    }

    [Trait("Category", "7. Faça a classe `Motorcycle` herdar de `Vehicle`")]
    [Fact(DisplayName = "Motorcycle deve ter a propriedade FrontBrake do tipo BrakeType")]
    public void MotorcycleShouldHaveFrontBrakeAttribute()
    {
        try
        {
            var motorcycle = new Motorcycle();
            var property = motorcycle.GetType().GetProperty("FrontBrake");
            Assert.NotNull(property);
            Assert.Equal(typeof(BrakeType), property.PropertyType);
            Assert.True(property.CanRead);
            Assert.True(property.CanWrite);
        }
        catch (Exception)
        {
            Assert.True(false, "A propriedade FrontBrake não foi encontrada");
        }
    }

    [Trait("Category", "7. Faça a classe `Motorcycle` herdar de `Vehicle`")]
    [Fact(DisplayName = "Motorcycle deve ter a propriedade RearBrake do tipo BrakeType")]
    public void MotorcycleShouldHaveRearBrakeAttribute()
    {
        try
        {
            var motorcycle = new Motorcycle();
            var property = motorcycle.GetType().GetProperty("RearBrake");
            Assert.NotNull(property);
            Assert.Equal(typeof(BrakeType), property.PropertyType);
            Assert.True(property.CanRead);
            Assert.True(property.CanWrite);
        }
        catch (Exception)
        {
            Assert.True(false, "A propriedade RearBrake não foi encontrada");
        }
    }
}

public class TestReq08
{
    [Trait("Category", "8. Faça a classe `PickupTruck` herdar de `Car`")]
    [Fact(DisplayName = "PickupTruck deve herdar de Car")]
    public void PickupTruckShouldInheritFromCar()
    {
        var pickupTruck = new PickupTruck();
        Assert.IsAssignableFrom<Car>(pickupTruck);
    }

    [Trait("Category", "8. Faça a classe `PickupTruck` herdar de `Car`")]
    [Fact(DisplayName = "PickupTruck deve ter a propriedade LoadCapacity do tipo double")]
    public void PickupTruckShouldHaveLoadCapacityAttribute()
    {
        try
        {
            var pickupTruck = new PickupTruck();
            var property = pickupTruck.GetType().GetProperty("LoadCapacity");
            Assert.NotNull(property);
            Assert.Equal(typeof(double), property.PropertyType);
            Assert.True(property.CanRead);
            Assert.True(property.CanWrite);
        }
        catch (Exception)
        {
            Assert.True(false, "A propriedade LoadCapacity não foi encontrada");
        }
    }
}

public class TestReq09
{
    [Trait("Category", "9. Crie um enum `RentStatus`")]
    [Theory(DisplayName = "RentStatus deve ter as constantes e valores corretos")]
    [InlineData(0, "Confirmed")]
    [InlineData(1, "Finished")]
    public void RentStatusShouldHaveCorrectValues(int valueEntry, string expected)
    {
        var value = valueEntry;
        var actual = Enum.GetName(typeof(RentStatus), value);
        Assert.Equal(expected, actual);
    }
}

public class TestReq10
{

    [Trait("Category", "10. Crie o construtor de `Rent` seguindo as regras de negócio")]
    [Fact(DisplayName = "O construtor de Rent deve criar um novo aluguel seguindo as regras corretamente")]
    public void TestCreateRent()
    {
        try
        {
            Vehicle vehicle = new Vehicle();
            PropertyInfo model = vehicle.GetType().GetProperty("Model");
            model.SetValue(vehicle, "Fusca");

            PropertyInfo year = vehicle.GetType().GetProperty("Year");
            year.SetValue(vehicle, 1970);

            PropertyInfo pricePerDay = vehicle.GetType().GetProperty("PricePerDay");
            pricePerDay.SetValue(vehicle, 70.0);

            PropertyInfo mainColor = vehicle.GetType().GetProperty("MainColor");
            mainColor.SetValue(vehicle, new Color() { Name = "Preto", Hex = "#000000" });

            PhysicalPerson person = new PhysicalPerson();
            PropertyInfo name = person.GetType().GetProperty("Name");
            name.SetValue(person, "joãozinho");

            PropertyInfo email = person.GetType().GetProperty("Email");
            email.SetValue(person, "joao@gmail.com");

            PropertyInfo address = person.GetType().GetProperty("Address");
            address.SetValue(person, "Rua antonio olinda, 204");

            PropertyInfo contact = person.GetType().GetProperty("Contact");
            contact.SetValue(person, "88 999554454");

            PropertyInfo cpf = person.GetType().GetProperty("CPF");
            cpf.SetValue(person, "011.787.456-65");

            var daysRented = 10;
            var expectedPrice = 700.0;
            Rent instance = new Rent(vehicle, person, 10);
            instance.Vehicle.Should().BeEquivalentTo(vehicle);
            instance.Person.Should().BeEquivalentTo(person);
            instance.Price.Should().Be(expectedPrice);
            person.Debit.Should().Be(instance.Price);
            instance.Price.Should().Be(expectedPrice);
        }
        catch (Exception)
        {
            Assert.True(false, "O construtor de Rent não foi implementado corretamente");
        }
    }
}
