using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RipassoItinere2
{
    //classe statica che genera la targa
    static internal class Ministero
    {
        public static string Targa()
        {
            string targa = "";
            Random random = new Random();
            for (int i = 0; i < 7; i++)
            {
                if (i < 2 || i > 4)
                {
                    //lettere
                    targa += (char)random.Next('A', 'Z' + 1);
                }
                else
                {
                    //numeri
                    targa += random.Next(0, 10);
                }
            }
            return targa;
        }
        public static string Autorizzazione()
        {
            string vocali = "AEIOU";
            string autorizzazione = "";
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                autorizzazione += random.Next(0, 10);
            }
            autorizzazione += vocali[random.Next(0, vocali.Length + 1)];
            return autorizzazione;
        }
    }
}
