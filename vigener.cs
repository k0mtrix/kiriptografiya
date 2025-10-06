using System;
class Program
{    static void Main(string[] args)
    {
        Console.Write("matn:");
        string matn=Console.ReadLine();
        matn=matn.ToLower();
        char[] belgi =matn.ToCharArray();
        Console.Write("kalit:");
        string kalit= Console.ReadLine();
        kalit=kalit.ToLower();
        char[] key = kalit.ToCharArray();
        string print = null;        
        char[] chars = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',' '};
        for (int i = 0; i < belgi.Length; i++)
        {          
            int matnIndex = Array.IndexOf(chars, belgi[i]);
            int keyIndex = Array.IndexOf(chars, key[i % key.Length]);
            int chiqIndex= (matnIndex+keyIndex)%chars.Length;
            print += chars[chiqIndex];
        }
        Console.WriteLine("Shifrlangan matn: "+print);
        Console.Write("Matnni deshifrlaysizmi (y , n): ");
        string a = Console.ReadLine();
        if (a == "y")
        {
            string shifrlangan = print;
            char[] belgi1 = shifrlangan.ToCharArray();
            string print1 = null;
            for (int i = 0; i < belgi1.Length; i++)
            {
                int matnIndex1 = Array.IndexOf(chars, belgi1[i]);
                int key1Index = Array.IndexOf(chars, key[i % key.Length]);
                int chiqIndex1 = (matnIndex1 - key1Index + chars.Length) % chars.Length;
                print1 += chars[chiqIndex1];
            }
            Console.WriteLine("deshifrlangan matn: "+print1);
        }
        else Console.WriteLine("Shifrlash tugadi!");
    }
}