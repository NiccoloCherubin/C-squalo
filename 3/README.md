        static void SgrandaVettore(ref Agenda[] c1)
        {
            // se devo inserire passo per valore
            // se voglio creare si usa per out
            // se voglio cambiare dimensioner per ref
            Agenda[] c2 = new Agenda[c1.Length + 1];
            for(int i = 0; i < c1.Length; i++)
            {
                c2[i] = c1[i];
            }
            c1 = c2; 
