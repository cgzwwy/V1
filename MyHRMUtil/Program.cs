using System;

namespace MyHRMUtil
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int result=new AnnualLeaveCalc().GetQuota(new DateTime(2018,11,15));
            Console.WriteLine(result);
        }
    }
}
