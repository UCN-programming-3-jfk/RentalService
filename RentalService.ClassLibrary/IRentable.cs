namespace RentalService.ClassLibrary;
public interface IRentable
{
    bool IsAvailable { get; }
    void Rent();
}