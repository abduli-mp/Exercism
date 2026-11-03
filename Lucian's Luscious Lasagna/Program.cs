class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven() => 40;

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int MinutesInOven) => 40 - MinutesInOven;

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int NumberOfLayers) => NumberOfLayers * 2;

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int NumberOfLayers, int MinutesInOven)
    {
        NumberOfLayers *= 2;

        return NumberOfLayers + MinutesInOven;
    }
}

class Program
{
    public static void Main()
    {
        Lasagna food = new Lasagna();

        Console.WriteLine($"Expected Minutes in Oven: {food.ExpectedMinutesInOven()} Minutes");
        Console.WriteLine($"Remaining Minutes in Oven: {food.RemainingMinutesInOven(30)} Minutes");
        Console.WriteLine($"Preparation Time in Minutes: {food.PreparationTimeInMinutes(2)} Minutes");
        Console.WriteLine($"Elapsed Time in Minutes: {food.ElapsedTimeInMinutes(4, 8)} Minutes");
    }
}