using System;
class Program
{
    static void Main(string[] args)
    {
        char[] chars = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        while (true)
        {
            Console.Write("Shifrlanadigan matn:");
            string matn = Console.ReadLine();
            matn = matn.ToLower();
            char[] belgi = matn.ToCharArray();
            if (belgi.Length % 2 == 0)
            {
                int[,] arr = new int[2, 2];

                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        Console.Write($"Matritsa({i + 1},{j + 1}) elementi:");
                        int element = int.Parse(Console.ReadLine());
                        arr[i, j] = element;
                    }
                }

                string chiquvchi = null;

                for (int a = 0; a < belgi.Length; a += 2)
                {
                    int index1 = Array.IndexOf(chars, belgi[a]);
                    int index2 = Array.IndexOf(chars, belgi[a + 1]);

                    int print1 = (arr[0, 0] * index1 + arr[0, 1] * index2) % chars.Length;
                    int print2 = (arr[1, 0] * index1 + arr[1, 1] * index2) % chars.Length;

                    chiquvchi += chars[print1];
                    chiquvchi += chars[print2];
                }
                Console.WriteLine("Shifrlangan matn: " + chiquvchi);
            }

            else
            {
                Array.Resize(ref belgi, belgi.Length+1);
                belgi[belgi.Length - 1] = 'a';
             
                int[,] arr = new int[2, 2];

                    for (int i = 0; i < 2; i++)
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            Console.Write($"Matritsa({i + 1},{j + 1}) elementi:");
                            int element = int.Parse(Console.ReadLine());
                            arr[i, j] = element;
                        }
                    }

                    string chiquvchi = null;

                    for (int a = 0; a < belgi.Length; a += 2)
                    {
                        int index1 = Array.IndexOf(chars, belgi[a]);
                        int index2 = Array.IndexOf(chars, belgi[a + 1]);

                        int print1 = (arr[0, 0] * index1 + arr[0, 1] * index2) % chars.Length;
                        int print2 = (arr[1, 0] * index1 + arr[1, 1] * index2) % chars.Length;

                        chiquvchi += chars[print1];
                        chiquvchi += chars[print2];
                    }
                    Console.WriteLine("Shifrlangan matn: " + chiquvchi);
                }
        }

    }
}