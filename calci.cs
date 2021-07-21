using System;
namespace Challenge1
{
    public class Program
    {
        public static void Main(string[] args){
        add();
        Console.ReadKey();
        }
        public static void add(){
            int a=Convert.ToInt32(Console.ReadLine());
            int b=Convert.ToInt32(Console.ReadLine());
            int c=a+b;
            Console.WriteLine("Addition program of a + b is "+c);
        }
    }
    
}
