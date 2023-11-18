class Zad
{
    static void Main(string[] args)
    {
        int[] tab1 = { 2, -5, 3, 5, 0 };
        int[] tab2 = new int[tab1.Length];
        for (int i=0; i<tab1.Length; i++)
        {
            tab2[(i + 1) % tab1.Length] = tab1[i];
        }
        for (int i = 0; i < tab1.Length; i++)
        {
            Console.Write(tab2[i] + " ");
        }
        Console.ReadKey();
    }
}