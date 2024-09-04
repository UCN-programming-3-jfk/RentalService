namespace RentalService.ClassLibrary;
public class Horse : IRentable
{
    public string Name { get; set; }
    public string Breed { get; set; }
    public bool IsAvailable { get; private set; }
    public Horse(string name, string breed = null)
    {
        Name = name;
        Breed = breed;
    }

    public void Rent()
    {
        IsAvailable = false;
    }
}
