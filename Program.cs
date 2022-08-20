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


Dictionary<int,int> GeneratePrimeValues(int value)
{
    var factorDictionary = new Dictionary<int, int>();

    for (int i = 2; i < (value / 2 ) + 1; i++)
    {
        if(value % i == 0)
        {
            if (factorDictionary.ContainsKey(value / i))
            {
                continue;
            }
            factorDictionary[i] = value / i;
        }
    }

    return factorDictionary;
}