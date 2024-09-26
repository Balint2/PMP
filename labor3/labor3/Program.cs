namespace labor3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //előkészület
            Random random = new Random();

            //1. feladat
            /*
            string[] szinek = {"Kör","Káró","Treff","Pikk"}; //beteszem a színeket
            string[] magassagok = {"2", "3", "4", "5", "6", "7", "8", "9", "10","Jumbó", "Dáma", "Király", "Ász"}; //a magasságokat
            string[] kartyak = new string[52]; //létrehozom a kártyákat, ahova be fogom őket tenni
            int index = 0; //ezzel számoolom, hogy hányadik helyre kell betenni
            for (int i = 0; i < szinek.Length; i++) //végigmegyek a színeken
            {
                for (int j = 0; j < magassagok.Length; j++) //a for cikluson belül a magasságokon is végigmegyek
                {
                    kartyak[index] = szinek[i] + " " + magassagok[j];  //beteszem a kártyákba a szín és magasság összefzését
                    index++; //az indexet megnövelem, hogy előrébb tegye be
                }
            }

            for (int i = 0; i < kartyak.Length; i++) //kíírás
            {
                Console.WriteLine(kartyak[i]);
            }
            */
            //2. feladat
            /*
            for (int i = 0; i < kartyak.Length; i++)
            {
                int j = random.Next(kartyak.Length);
                string seged = kartyak[i];
                kartyak[i] = kartyak[j];
                kartyak[j] = seged;
            }

            //nem írja a feladat, de ha ki akarjuk írni az eredményt
            Console.WriteLine();
            for (int i = 0; i < kartyak.Length; i++) //kíírás
            {
                Console.WriteLine(kartyak[i]);
            }
            */

            //3. feladat
            /*
            int n = 5;
            string[] szavak = new string[n];
            Console.WriteLine();
            for (int i = 0; i < szavak.Length; i++)
            {
                Console.Write($"{i}. szó: ");
                szavak[i] = Console.ReadLine();
            }


            Console.Write($"Bekért szó: ");
            string bekertSzo = Console.ReadLine();
            bool benneVan = false;
            int index = -1;
            for (int i = 0; i < szavak.Length && !benneVan; i++)
            {
                if (szavak[i] == bekertSzo)
                {
                    benneVan = true;
                    index = i;
                }
            }
            if (benneVan)
            {
                Console.WriteLine($"Benne van a szó, és a {index}. helyen található elüször");
            }
            else
            {
                Console.WriteLine("Nincs benne a megadott szó");
            }
            */

            //5. feladat
            /*
            List<string> nevek = new List<string>();
            List<int> korok = new List<int>();
            List<bool> tapasztalatok = new List<bool>();
            string bekertNev;
            int bekertKor;
            bool bekertTapasztalat;

            do
            {
                bekertNev = Console.ReadLine();
                if (bekertNev != "")
                {
                    bekertKor = int.Parse(Console.ReadLine());
                    bekertTapasztalat = bool.Parse(Console.ReadLine());
                    nevek.Add(bekertNev);
                    korok.Add(bekertKor);
                    tapasztalatok.Add(bekertTapasztalat);
                }

            } while (bekertNev != "");

            int osszKor = 0;
            foreach (var kor in korok)
            {
                osszKor += kor;
            }
            Console.WriteLine($"Átlag életkor: {osszKor/korok.Count}");


            int progNelkuliSzama = 0;
            int osszProgNelkuliKor = 0;
            for (int i = 0; i < korok.Count; i++)
            {
                if (tapasztalatok[i] == false)
                {
                    progNelkuliSzama++;
                    osszProgNelkuliKor += korok[i];
                }
            }
            Console.WriteLine($"Átlag életkor a tapasztalat nélküliek közül: {osszProgNelkuliKor / progNelkuliSzama}");


            int maxTapasztalattalKor = -1;
            int maxTapasztalattalIndex = -1;
            for (int i = 0; i < korok.Count; i++)
            {
                if (tapasztalatok[i] == true && korok[i] > maxTapasztalattalKor)
                {
                    maxTapasztalattalKor = korok[i];
                    maxTapasztalattalIndex = i;
                }
            }
            Console.WriteLine($"{maxTapasztalattalKor} éves a legidősebb tapasztalat nélküli, a neve pedig {nevek[maxTapasztalattalIndex]}");
            */

            //7. feladat
            /*
            //generálás
            
            int sorSzam = 6;
            int oszlopSzam = 5;
            int[,] halak = new int[sorSzam, oszlopSzam];
            for (int i = 0; i < sorSzam; i++)
            {
                for (int j = 0; j < oszlopSzam; j++)
                {
                    halak[i, j] = random.Next(10);
                }
            }

            //kiírás
            for (int i = 0; i < sorSzam; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < oszlopSzam; j++)
                {
                    Console.Write(halak[i,j] + "\t");
                }
            }
            Console.WriteLine();

            //egyes halfajtákból mennyi fogtak
            //illetve volt e, aki nem fogott ki
            bool nemFogott = false;
            for (int j = 0; j < oszlopSzam; j++)
            {
                int osszeg = 0;
                for (int i = 0; i < sorSzam; i++)
                {
                    osszeg += halak[i, j];
                }
                if (osszeg == 0)
                {
                    nemFogott = true;
                }
                Console.WriteLine($"{j}. halfajtából {osszeg} db-ot fogtak");
            }

            Console.WriteLine();
            int maxHorgaszIndex = 0;
            int maxOsszeg = -1;
            for (int i = 0; i < sorSzam; i++)
            {
                int osszeg = 0;
                for (int j = 0; j < oszlopSzam; j++)
                {
                    osszeg += halak[i, j];
                }
                if (osszeg > maxOsszeg)
                {
                    maxOsszeg = osszeg;
                    maxHorgaszIndex = i;
                }
            }
            Console.WriteLine($"{maxHorgaszIndex}. horgász fogta a legtöbb halat");
            Console.WriteLine($"Volt e aki nem fogott: {nemFogott}");
            */

            //8. feladat
            /*
            double N = int.Parse(Console.ReadLine());
            double K = N;
            List<double> lista = new List<double>();
            lista.Add(K);
            while (K != 1)
            {
                if (K % 2 == 0)
                {
                    K = K / 2;
                }
                else
                {
                    K = 3 * K + 1;
                }
                lista.Add(K);
            }
            */

        }
    }
}
