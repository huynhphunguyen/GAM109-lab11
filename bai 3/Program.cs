using bai_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static int Main(string[] args)
    {
        Calculator calculator = new Calculator(3,7);
        int resultCong = calculator.Cong();
        Console.WriteLine("Cong: " + resultCong);
        return 0;
    }
       
}
