using System;

class Program
{
    static void Main()
    {

        while (true)
        {
            char[] chars = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            Console.Write("Matnni kiriting (yoki 'STOP' deb yozing): ");
            string matn = Console.ReadLine();

            if (matn.ToLower() == "stop")
            {
                Console.WriteLine("Dastur tugadi");
                break;
            }
            matn = matn.ToLower();
            int kalit_uzunligi = 0;

            while (matn.Length % 3 != 0 &&
                   matn.Length % 4 != 0 &&
                   matn.Length % 5 != 0 &&
                   matn.Length % 6 != 0)
            {
                matn += "1";
            }
            Console.WriteLine(matn);


            if (matn.Length % 6 == 0)
            {
                kalit_uzunligi = matn.Length / 6;
            }
            else if (matn.Length % 5 == 0)
            {
                kalit_uzunligi = matn.Length / 5;
            }
            else if (matn.Length % 4 == 0)
            {
                kalit_uzunligi = matn.Length / 4;
            }
            else if (matn.Length % 3 == 0)
            {
                kalit_uzunligi = matn.Length / 3;
            }


            Console.Write($"{kalit_uzunligi} ta harfdan iborat kalit kiriting: ");
            string key = Console.ReadLine();
            key = key.ToLower();
            Console.WriteLine();
            Console.WriteLine("Shifrlangan matn>>");

            char[] belgi = matn.ToCharArray();
            char[] kalit = key.ToCharArray();


            List<char> belgil = new List<char>(matn.ToCharArray());


            int qator_soni = matn.Length / key.Length;
            if (matn.Length % key.Length != 0)
                qator_soni++;

            string[] qator = new string[kalit.Length];

            for (int i = 0; i < kalit.Length; i++)
            {
                string qism = "";

                for (int j = 0; j < qator_soni; j++)
                {
                    qism += belgil[0];
                    belgil.RemoveAt(0);
                }

                qator[i] = kalit[i] + qism;
            }
            Array.Sort(qator, (a, b) => a[0].CompareTo(b[0]));
            for (int i = 0; i < qator.Length; i++)
            {
                List<char> belgila = new List<char>(qator[i].ToCharArray());
                belgila.RemoveAt(0);
                string chiquvchi = string.Join("", belgila);
                Console.Write(chiquvchi);
                
                

            }
            Console.WriteLine();
        }
       
    }
}