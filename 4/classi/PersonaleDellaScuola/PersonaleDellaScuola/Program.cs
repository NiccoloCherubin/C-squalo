using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaleDellaScuola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Dipendente> dipendentes = new List<Dipendente>();
            dipendentes.Add(new Impiegato("ale","maschio","trasporti"));
            dipendentes.Add(new Docente("Mattia","femmina","motoria",Ruolo.supplente));
            
            dipendentes.ForEach(x=> { Console.WriteLine(x.ToString()); });
            Console.ReadLine();
        }
    }
}
