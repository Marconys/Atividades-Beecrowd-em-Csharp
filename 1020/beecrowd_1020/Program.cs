namespace beecrowd_1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32( Console.ReadLine());

            int ano = x / 365;
            x = (x%365);

            int mes = x / 30;
            x = (x%30);

            int dias = x / 1;

            Console.WriteLine($"{ano} ano(s)\n{mes} mes(es)\n{dias} dia(s)");
        }
    }
}
