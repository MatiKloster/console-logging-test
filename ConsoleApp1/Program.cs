var threshold = 14000;

IEnumerable<int> GetItems()
{
    var list = new List<int>();
    for (var i = 0; i < threshold; i++)
    { 
        list.Add(i);
    }

    return list;
}


Console.WriteLine("Test");


Console.WriteLine($"Test items {string.Join(',', GetItems())}");