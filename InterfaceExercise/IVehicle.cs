namespace InterfaceExercise;

public interface IVehicle
{
    string Year { get; set; }
    string Make { get; set; }
    string Model { get; set; }
    void Drive();
}