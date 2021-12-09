using System;

namespace Overtime_Pay_Challenge
{
    class Overtime
    {
        static void Main(string[] args)
        {

            

            Console.WriteLine("Please enter the start time of your shift in Decimal form using Military units. For example: 1pm = 13.00");
            decimal startDay = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Please enter the end time of your shift in Decimal form using Military units. For example: 2pm = 14.00");
            decimal endDay = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Please enter the amount of money you are paid per hour of work in decimal form: ");
            decimal payPerHour = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Please enter the multiplier for payment in overtime: ");
            decimal overTime = Convert.ToDecimal(Console.ReadLine());

            decimal[] arr = {startDay, endDay, payPerHour, overTime};

            DoOvertime(arr);
            
            
        }

        public static void DoOvertime(decimal[] arr)
        {
            decimal totalPay;
            decimal totalHours = Math.Abs(arr[0] - arr[1]);

            if(totalHours <= 8)
            {
                totalPay = totalHours * arr[2];
                totalPay = Math.Round(totalPay, 2);
                Console.WriteLine("Total Pay: $" + totalPay);
            }
            else if(totalHours > 8)
            {
                totalPay = (totalHours * arr[2]) * arr[3];
                totalPay = Math.Round(totalPay, 2);
                Console.WriteLine("Total Pay: $" + totalPay);
            }
        }


    }
}
