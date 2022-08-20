Console.WriteLine("Input a number:");
string? input = Console.ReadLine();
int value = 0;


bool s = int.TryParse(input, out value);

if (s)
{
    var startTime = DateTime.Now;

    var dictionaryInts = GeneratePrimeValues(value);

    if (dictionaryInts.Count == 0)
        Console.WriteLine("This number is Prime!");
    
    foreach (var pair in dictionaryInts)
    {
        Console.WriteLine($"{pair.Key}, {pair.Value}");
    }

    var timeElapsed = DateTime.Now - startTime;

    Console.WriteLine("Time Elapsed {0}", timeElapsed);
}
else
{
    Console.WriteLine("Not an Integer");
}


Dictionary<int,int> GeneratePrimeValues(int value)
{
    var factorDictionary = new Dictionary<int, int>();

    if (value < 0)
    {
        throw new ArgumentOutOfRangeException(nameof(value));
    }

    for (int i = 2; i < Math.Sqrt(value) + 1; i++)
    {
        if(value % i == 0)
        {
            factorDictionary[i] = value / i;
        }
    }

    return factorDictionary;
}