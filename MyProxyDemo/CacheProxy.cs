using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProxyDemo;

public class CacheProxy(IService service) : IService
{
    private Dictionary<int, string> _cache = [];

    public async Task<string> GetDataAsync(int key)
    {
        if (_cache.ContainsKey(key))
        {
            Console.WriteLine("Returning data from cache");
            return _cache[key];
        }
        string result = await service.GetDataAsync(key);
        _cache[key] = result;
        return result;
    }
}
