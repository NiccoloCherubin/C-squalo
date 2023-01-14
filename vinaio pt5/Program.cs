using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Vinaio_pt5
{
    class Program
    {
        static void Main(string[] args)
        {
            // barbera in bottoglioni (1.5L). Sconti  10 %acquisti superiori 45L. L = 2. Domicilio = 3
            // lugana (1.5), 10 euro
            // merlot, 4
            // soave, 6
            int bott, botTot = 0, scontrini = 0, domicilioTot = 0, scelta, barb = 0, merl = 0, lug = 0, soa = 0, pzL = 0;
            double litri, litriTot = 0, parziale, totale = 0, sconto = 0, scontoTot = 0, totL, incasso = 0;
            string endday, domicilio, descrizioneVino = "";
            const int scontoPer = 10, litriMin = 45, pzBarb = 2, pzMer = 4, pzLug = 10, pzSoa = 6, pzDom = 3;
            const double lBott = 1.5;
            // inizio ciclo di fine giornata
            do
            {
                // calcolo numero scontrini
                scontrini++;
                // scelta vino + verifica
                do
                {
                    Console.Clear();
                    Console.WriteLine(" Che vino vuole ordinare? \r \n (1) barbera 2E/L \r \n (2) lugana 10E/L \r \n (3) merlot 4E/L \r \n (4) soave 6E/L");
                    scelta = Convert.ToInt32(Console.ReadLine());
                } while (scelta < 1 || scelta > 4);
                // inserimento bottiglioni + verifica
                do
                {
                    Console.WriteLine("Benvenuto alla tana dei goti quanti bottiglioni (1.5L) ordinare? ");
                    bott = Convert.ToInt32(Console.ReadLine());
                }
                while (bott <= 0);

                // calcolo litri
                litri = lBott * bott;
                switch (scelta)
                {
                    case (1):
                        descrizioneVino = "barbera";
                        pzL = pzBarb;
                        barb++;

                        break;
                    case (2):
                        descrizioneVino = "lugana";
                        pzL = pzLug;
                        lug++;
                        break;
                    case (3):
                        descrizioneVino = "merlot";
                        pzL = pzMer;
                        merl++;
                        break;
                    case (4):
                        descrizioneVino = "saove";
                        pzL = pzSoa;
                        soa++;
                        break;
                }
                // chiedo domicilio
                do
                {
                    Console.WriteLine("Vuoi la consegna a domicilio (3 euro)");
                    domicilio = Console.ReadLine();
                } while (domicilio != "sì" && domicilio != "no");
                totale = litri * pzL;
                // verifico litri per sconto
                if (litri > litriMin)
                {
                    totL = totale;
                    sconto = totale / scontoPer;
                    totale = totale - sconto;
                }
                else
                {
                    totL = totale;
                }
                parziale = totale;
                Console.WriteLine(" (========= Tana dei Goti ===========) ");
                Console.WriteLine(" ({0} n° bottiglioni {1} litri Totali {2}) ", descrizioneVino, bott, litri);
                // verifico risposta e calcoli
                if (sconto != 0)
                {
                    //stampo scontrino sconto

                    Console.WriteLine(" (Sconto 10 % {0})", sconto);
                }
                if (domicilio == "sì")
                {
                    Console.WriteLine(" (Spese di trasporto {0}) ", domicilio);
                    totale = totale + pzDom;
                   
                    // calcolo domicilio tot solo quando c'è domicilio
                    domicilioTot = domicilioTot + pzDom;
                }
                
                Console.WriteLine(" (=======================================) ");
                Console.WriteLine(" (Totale parziale {0}) ", parziale);

                Console.WriteLine(" ( =======================================) ");
                Console.WriteLine(" (Importo Totale {0}) ", totale);
                Console.WriteLine(" (n° scontrino) {0}", scontrini);
                Console.WriteLine(" (========= Arrivederci =========) ");
                // chiedo se fine giornata
                Console.WriteLine("Siamo a fine giornata? ");
                endday = Console.ReadLine();
                // calcolo tot per fare recap
                botTot = botTot + bott;
                litriTot = litriTot + litri;
                scontoTot = scontoTot + sconto;
                incasso = incasso + totale;
            }
            while (endday == "no");
            // scontrino per il titolare
            Console.WriteLine("(========= Tana dei Goti =========== )");
            Console.WriteLine("(========= Chiusura Cassa =========== )");
            Console.WriteLine("( n° barbera   {0}, ", botTot, litriTot);
            Console.WriteLine("( n° bottiglioni   {0}, n° litri     {1})", botTot, litriTot);
            Console.WriteLine("(=======================================)");
            Console.WriteLine("(Totale Sconto  {0})", scontoTot);
            Console.WriteLine("(Totale Incasso {0}", incasso);
            Console.WriteLine("(Totale Spese di trasporto {0})", domicilioTot);
            Console.WriteLine("(n° scontrini emessi     {0})", scontrini);
            Console.WriteLine("(========= Arrivederci =========)");
            Console.ReadLine();
        }
    }
}