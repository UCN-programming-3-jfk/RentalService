namespace RentalService.ClassLibrary;

public class Car : IRentable, IServiceable
{
    public string Description { get; set; }
    public int TopSpeed { get; set; }
    public int Mileage { get; set; }
    public int ServiceIntervalInKilometers { get; set; } = 10000;
    private bool isAvailable;
    public bool IsAvailable { get { return isAvailable && NeedsService; } set { isAvailable = value; } }
    public bool NeedsService { get { return Mileage - mileageAtLastService > ServiceIntervalInKilometers; } }

    private int mileageAtLastService = 0;
    

    public Car(string description, int topSpeed, int mileage = 0)
    {
        Description = description;
        TopSpeed = topSpeed;
        Mileage = mileage;
    }

    public void Drive(int distance)
    {
        Mileage += distance;
    }
    public void ResetNeedForService()
    {
        mileageAtLastService = Mileage;
    }

    public void Rent()
    {
        IsAvailable = false;
    }
}
