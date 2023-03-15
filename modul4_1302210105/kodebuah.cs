using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302210105
{
    internal class kodebuah
    {
        public enum buah { Apel, Aprikot, Alpukat, Pisang, Paprika, Blackberry, Ceri, Kelapa, Jagung }
        String[] arr = { "A00", "B00", "C00", "D00", "E00", "F00", "G00", "H00", "I00", "J00" };

        public string getkodebuah(buah namaBuah) => arr[(int)namaBuah];
        
    }
}
