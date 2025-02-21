using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProxyDemo;

public class ActualService : IService
{
    public async Task<string> GetDataAsync(int key)
    {
        Console.WriteLine($"Fetching data for {key}");
        await Task.Delay(3000);
        return $"Data for {key}";
    }
}
