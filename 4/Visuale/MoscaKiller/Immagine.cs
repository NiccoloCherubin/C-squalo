using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiro_a_segno
{
    internal class Immagine
    {
        string path;
        public Immagine(string path)
        {
            this.path = path;
        }

        /// <summary>
        /// Ritorna il percorso specificato nell'oggetto
        /// </summary>
        public string Percorso
        {
            get { return path; }
        }

        /// <summary>
        /// Ritorna l'immagine con percorso specificato nell'oggetto
        /// </summary>
        /// <returns></returns>
        public Image RitornoImmagine()
        {
            return Image.FromFile(path);
        }
    }
}
