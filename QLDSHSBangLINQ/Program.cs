using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDSHS
{
    class Hocsinh
    {
        public int SBD { get; set; }
        public string Ten { get; set; }
        public int Tuoi { get; set; }
        public override string ToString()
        {
            return $"SBD: {SBD}, Ten: {Ten}, Tuoi: {Tuoi}";
        }
    }
}
