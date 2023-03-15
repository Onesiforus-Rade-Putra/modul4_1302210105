using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302210105
{
    internal class PosisiKarakterGame
    {
        public enum posisi {tengkurap, jongkok, berdiri, terbang}
        public enum tombol { tombolW, tombolS, tombolX }

        public class gantiPosisi
        {
            public posisi posisiSebelum, posisiSesudah;
            public tombol triger;
            public gantiPosisi (posisi sebelum, posisi sesudah, tombol triger)
            {
                this.posisiSebelum= sebelum;
                this.posisiSesudah= sesudah;
                this.triger= triger;
            }
        }
        gantiPosisi[] arrgantiposisi =
        {
            new gantiPosisi(posisi.berdiri, posisi.jongkok, tombol.tombolS),
            new gantiPosisi(posisi.jongkok, posisi.berdiri, tombol.tombolW),
            new gantiPosisi(posisi.berdiri, posisi.terbang, tombol.tombolW),
            new gantiPosisi(posisi.terbang, posisi.berdiri, tombol.tombolS),
            new gantiPosisi(posisi.terbang, posisi.jongkok, tombol.tombolX),
            new gantiPosisi(posisi.jongkok, posisi.tengkurap, tombol.tombolS),
            new gantiPosisi(posisi.tengkurap, posisi.jongkok, tombol.tombolW),
        };

        public posisi sekarang = posisi.berdiri;
        public posisi langkah_berikut( posisi sebelum, tombol triger)
        {
            posisi langkahSetelah = sebelum;
            for (int i = 0; i < arrgantiposisi.Length; i++)
            {
                posisi langkahsebelum = arrgantiposisi[i].posisiSebelum;
                tombol tombolsebelum = arrgantiposisi[i].triger;
                if (langkahsebelum==sebelum && tombolsebelum==triger)
                {
                    langkahSetelah = arrgantiposisi[i].posisiSesudah;
                }
            }
            return langkahSetelah;
        }
        public void action ( tombol triger )
        {
            sekarang = langkah_berikut(sekarang, triger);
            if (sekarang == posisi.jongkok)
            {
                Console.WriteLine("posisi landing");
            }
            else if (sekarang == posisi.terbang)
            {
                Console.WriteLine("posisi take off");
            }
        }
    }


}
