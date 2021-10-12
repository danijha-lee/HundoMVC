using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HundoMVC.Models
{
    public class HundoNumbers
    {
        public int StartValue { get; set; }
        public int EndValue { get; set; }

        public List<string> Results { get; set; } = new List<string>();
    }
}