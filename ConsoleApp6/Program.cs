namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Plase enter Number of small carpets: ");
            int Small = Convert.ToInt32(Console.ReadLine());
            Console.Write("Plase enter Number of large carpets: ");
            int Large = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("\nPrice per small room: 25$ ");
            Console.WriteLine("Price per large room: 35$ ");


            int Cost = (Small * 25) + (Large * 35);
            double Tax = Cost * 0.06;
            double total_estimate = Cost + Tax;

            Console.WriteLine($"Cost : {Cost}$");
            Console.WriteLine($"Tax : {Tax}$");


            Console.WriteLine("==============================================");
            Console.WriteLine($"Total estimate: {total_estimate}$");
            Console.WriteLine("This estimate is Value For 30 days");


        }
    }
}
