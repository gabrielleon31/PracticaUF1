internal class Program
{
    private static void Main(string[] args)
    {
         int number1, number2, total;
        Console.WriteLine("Escribe un numero: ");
        number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escribe otro numero: ");
        number2 = Convert.ToInt32(Console.ReadLine());
        total = number1 + number2;
        Console.WriteLine("La suma correcta és: " + total);
        Console.ReadLine();
    }
}