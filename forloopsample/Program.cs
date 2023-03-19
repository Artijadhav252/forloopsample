public class program
{
    public static void Main()
    {
        firstNestedloop();
        secondnestedloopo();
        thirdnestedloop();
    }
    public static void firstNestedloop()
    {
        for(int i=1; i<=5; i++)
       
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.Write(" * ");
            }
            Console.WriteLine();
        }
       
    }

    public static void secondnestedloopo()
    {
        Console.WriteLine("-----------------------------------------------------------");
        for(int i=1; i<=5; i++)
        {
            for(int j=1; j<=10; j++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
    }

    public static void thirdnestedloop()
    {
        Console.WriteLine("----------------------------------------------------");
        for (int i = 5; i >= 1; i++)
        {
            for (int j = 5; j >= 1; j++)
            {
                Console.Write(" * ");
            }
            Console.WriteLine();
        }
    }
    
}