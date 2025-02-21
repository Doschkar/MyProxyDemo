using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProxyDemo;

public interface IService
{
    Task<string> GetDataAsync(int key);
}
