
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int num1 = 10;
        int num2 = 20;
        float avg_score = 67.45f;
        double precise_value = 12345.678897660;
        decimal money_amount = 1234567890.12m;
        char grade = 'A';
        string message = "Hello,Welcome to session";
        //Console.WriteLine("Num1 value is" + num1);
        //Console.WriteLine("Num2 value is" + num2);

        //Console.WriteLine("Num1 value is {0}", num1);
        //Console.WriteLine("Num2 value is {1}", num2);
        //String Interpolation
        Console.WriteLine($"Num value is {num1} \n Num value is = {num2}");
        Console.WriteLine($"average_score={avg_score} \n precise_value={precise_value} \n money={money_amount}'" +
        $"\n Grade={grade} \n Message={message}");
        Console.ReadLine();
    }
}


