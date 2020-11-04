using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class PC
    {
        public string Name { get; set; }
        public Race PcRace { get; set; }
        public Class PcClass { get; set; }
        public PC(string name,Race pcRace,Class pcClass)
        {
            Name = name;
            PcRace = pcRace;
            PcClass = pcClass;

        }

    }
}
