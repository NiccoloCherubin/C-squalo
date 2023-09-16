using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dDmMyY
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong data = 31022022;
            int cifre;
            do
            {
                Console.WriteLine("Inserire numero che corrisponda a dd/mm/yy. Mettere anche zeri non significativi");
                data = Convert.ToUInt64(Console.ReadLine());
            } while (ControlloData(data, out cifre));
            Console.WriteLine(DateMaker(data));

            Console.ReadLine();
        }
        static bool ControlloData(ulong data, out int cifre)
        {
            cifre = 0;
            int resto;
            while (data != 0)
            {
                resto = Convert.ToInt32(data % 10);
                data /= 10;
                cifre++;
            }
            if (cifre != 8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static string DateMaker(ulong data)
        {
            string date = "";
            date += Convert.ToString(data % 10000); // anno
            date += "/";
            date += Convert.ToString(data / 1000000); // giorno
            date += "/";
            data /= 10000;
            date += Convert.ToString(data % 100); // mese            
            // girato la data          
            string[] dd = date.Split('/');
            date = dd[1]+ "/"+dd[2] + "/" + dd[0];
            DataOk(ref date, dd);           
               
            
            return date;
        }
        static void DataOk(ref string date, string[] dd)
        {
            if (Convert.ToInt32(dd[2]) < 0 || Convert.ToInt32(dd[2]) > 12)
            {
                date = "Mese non valido";
            }
            // mesi con 31 giorni
            else if (dd[2] == "1" || dd[2] == "3" || dd[2] == "5" || dd[2] == "7" || dd[2] == "8" || dd[2] == "10" || dd[2] == "12")
            {
                if (Convert.ToInt32(dd[1]) > 31)
                {
                    date = "Giorno non valido";
                }
            }
            // febbraio
            else if (dd[2] == "2")
            {
                if (Convert.ToInt32(dd[1]) > 28)
                {
                    date = "Giorno non valido";
                }
            }
            // tutti i mesi con 30 giorni
            else
            {
                if (Convert.ToInt32(dd[1]) > 30)
                {
                    date = "Giorno non valido";
                }
            }
        }
    }
}
