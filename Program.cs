using System.Globalization;

namespace DolgozatPotlasAsztali0916
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // B csoport: 12, 22, 37, 43, 62

            // 12. feladat
            Console.WriteLine("Feladat 12:");

            Console.Write("Add meg a téglatest a oldalát: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Add meg a téglatest b oldalát: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Add meg a téglatest c oldalát: ");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine($"A téglatest térfogata: {a * b * c}e");
            Console.WriteLine($"A téglatest felszíne: {2 * (a * b + b * c + c * a)}e");


            // 22. feladat

            Console.WriteLine("\nFeladat 22:");

            int sum = 0;
            int input;
            do
            {
                Console.Write("Adj meg egy számot: ");
                input = int.Parse(Console.ReadLine());
                if (input < 10) sum += input;

            } while (input < 10);

            Console.WriteLine($"Az összeg: {sum}");


            // 37. feladat

            Console.WriteLine("\nFeladat 37:");

            Console.Write("Add meg hány soros legyen a háromszög: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // 43. feladat
            Console.WriteLine("\nFeladat 43:");

            Console.Write("Add meg hány elemet adsz meg: ");
            int len = int.Parse(Console.ReadLine());

            int[] intArray = new int[len];

            for (int i = 0; i < len; i++)
            {
                Console.Write($"Add meg a(z) {i + 1}. számot: ");
                intArray[i] = int.Parse(Console.ReadLine());
            }

            int devisibleBy2Sum = 0;
            for (int i = 0; i < len; i++)
            {
                if (intArray[i] % 2 == 0) devisibleBy2Sum += intArray[i];
            }
            Console.WriteLine($"A párosok összege: {devisibleBy2Sum}");

            // 62. feladat

            Console.WriteLine("\nFeladat 62:");

            string[] strings = [];
            try
            {
                using (StreamReader sr = new("forras62.be"))
                {
                    strings = new string[int.Parse(sr.ReadLine())];
                    int arrayIndex = 0;

                    while(!sr.EndOfStream)
                    {
                        strings[arrayIndex] = sr.ReadLine();
                        arrayIndex++;
                    }
                    Console.WriteLine("Sikeres beolvasás!");
                }
            } 
            catch (IOException ex)
            {
                Console.WriteLine($"Hiba történt a beolvasás során: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Váratlan hiba történt: {ex.Message}");
            }

            Console.WriteLine("Az a betűvel kezdődő szavak:");
            for (int i = 0; i < strings.Length; i++)
            {
                if (strings[i].StartsWith('a')) Console.WriteLine(strings[i]);
            }

            Console.ReadKey();
        }
    }
}
