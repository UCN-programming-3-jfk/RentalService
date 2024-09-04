using NUnit.Framework;
using RentalService.ClassLibrary;

namespace RentalService.Test;

public class Tests
{
 

    [Test]
    public void TestRentingHorse()
    {
        //Arrange

        IRentable horse = new Horse("Clara", "Persian trotter");

        //Act
        horse.Rent();

        //Assert
        Assert.IsFalse(horse.IsAvailable, "The horse was not rented, when the Rent() method was called");
        
    }

    [Test]
    public void TestRentingCar()
    {
        //Arrange

        IRentable car = new Car("Blue Ford Focus", 200, 5000);

        //Act
        car.Rent();

        //Assert
        Assert.IsFalse(car.IsAvailable, "The car was not rented, when the Rent() method was called");

    }


    [Test]
    public void TestServiceIntervalForCar()
    {
        //Arrange

        Car car = new Car("Blue Ford Focus", 200, 5000);

        //Act and Assert
        car.Drive(3000);
        Assert.IsFalse(car.NeedsService, "The car reported needing service, even though the mileage was too low");
        
        car.Drive(3000);
        Assert.IsTrue(car.NeedsService, "The car didn't report needing service, even though the mileage was high enough");
        Assert.IsFalse(car.IsAvailable, "The car reported it was available for renting, even though the car needed service.");

        car.ResetNeedForService();
        Assert.IsFalse(car.NeedsService, "The car reported needing service, even though a service was just performed");

    }
}