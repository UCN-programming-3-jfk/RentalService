namespace RentalService.ClassLibrary;
public interface IServiceable
{
    bool NeedsService { get; }
    void ResetNeedForService();
} 