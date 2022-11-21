using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Smartphone : ICallable, IBrowseable
{
    public string Calling(string number)
    {
        return number.Any(x => char.IsDigit(x)) ?
            $"Calling... {number}" : "Invalid number!";
    }

    public string Browsing(string url)
    {
        return url.Any(x => char.IsDigit(x)) ?
            "Invalid URL!" : $"Browsing: {url}!";
    }
}

