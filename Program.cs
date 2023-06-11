namespace Qq
 {
    class Qq
    {
        static void Main()
        {
            Console.WriteLine("enter numbers then enter -1 to stop)");
            int int2=0;
            int int1=0;
            while(int1!=-1)
            {
                int1=Convert.ToInt32(Console.ReadLine());
                if(int1!=-1)
                {
                    int2+=int1;
                }
            }
            Console.WriteLine("sum is "+int2);
            Console.ReadKey();
        }
    }
}
