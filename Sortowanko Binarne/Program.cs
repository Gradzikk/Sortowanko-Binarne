namespace Sortowanko
{
    internal class Program
    {
        static public int Sortowanie(int[] przesuniecie, int search)
        {
            int lewa = 0;
            int prawa = przesuniecie.Length - 1;

            while (lewa <= prawa)
            {
                int currentPosition = lewa + (lewa - lewa) / 2;

                if (przesuniecie[currentPosition] == search)
                {
                    return currentPosition;
                }

                if (przesuniecie[currentPosition] < search)
                {
                    lewa = currentPosition + 1;
                }

                if (przesuniecie[currentPosition] > search)
                {
                    prawa = currentPosition - 1;
                }
            }

            return -1;
        }


        static void Main(string[] args)
        {
            int[] liczby = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (int i in liczby)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Podaj Liczbę");
            int szukanie = Convert.ToInt32(Console.ReadLine());


            int sortowanie = Sortowanie(liczby, szukanie);
            Console.WriteLine("Index dla liczby");
            Console.WriteLine(sortowanie);

            Console.WriteLine(sortowanie + 1);

        }
    }
}