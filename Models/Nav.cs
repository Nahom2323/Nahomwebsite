using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuarterlySales.Models
{
    public class Nav
    {
        public static string Active(string value, string current)
        {
            return (value == current) ? "active" : string.Empty;
        }
    }
}
