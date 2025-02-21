using MyProxyDemo;

IService myService = new CacheProxy(new ActualService());

Console.WriteLine(await myService.GetDataAsync(1));

Console.WriteLine(await myService.GetDataAsync(2));

Console.WriteLine(await myService.GetDataAsync(1));

