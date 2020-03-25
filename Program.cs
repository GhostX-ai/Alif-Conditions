using System;

namespace IFHW
{
    class Program
    {
        static void Main(string[] args)
        {
            //#1
            int a = 5, b = 7;
            if(a!=b){
                a = a > b ? a : b;
                b = a;                
            }
            else{
                a = 0;
                b = 0;
            }
            Console.WriteLine(a+" "+b);
            //#2
            double operand1,operand2,result = 0;
            char sign = ' ';
            Console.Write("Enter first value");
            operand1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter function");
            sign = char.Parse(Console.ReadLine());
            Console.Write("Enter first value");
            operand2 = double.Parse(Console.ReadLine());
            if(sign == '/' && operand1 == 0 || sign == '/' && operand2 == 0){
                Console.WriteLine("Error I can't devide on zero");
            }
            else{
                switch(sign){
                    case '*':result=operand1*operand2;break;
                    case '/':result=operand1/operand2;break;
                    case '+':result=operand1+operand2;break;
                    case '-':result=operand1-operand2;break;
                }
                Console.WriteLine(result);
            }
            //#3
            Console.Write("Enter number please:");
            int num = int.Parse(Console.ReadLine());
            string results = num > -1 && num < 15 ? "[0-14]" : "This number is not in any intervals";
            results = num > 14 && num < 36 ? "[15-35]" : results;
            results = num > 35 && num < 51 ? "[36-50]" : results;
            results = num > 50 && num < 101 ? "[51-100]" : results;
            Console.WriteLine(results);
            Console.ReadKey();
        }
    }
}
