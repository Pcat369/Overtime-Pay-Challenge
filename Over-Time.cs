using System;

namespace Overtime_Pay_Challenge
{
    class Overtime
    {
        static void Main(string[] args)
        {
            decimal startDay;
            decimal endDay;
            decimal payPerHour;
            decimal overTime;
            bool x = true;

            while (x == true)
            {
                 try
                 {
                    Console.WriteLine("Please enter the start time of your shift in Decimal form using Military units. For example: 1pm = 13.00");
                    startDay = Convert.ToDecimal(Console.ReadLine());

                    if (startDay > 24 || startDay < 0)
                    {
                        Console.WriteLine("The number must be a standard measure of time within the work day. A positive number less than or equal to 24 hours. Please try again.");
                        continue;
                    }
                 }
                 catch (System.Exception)
                 {
                     Console.WriteLine("The information you put in was in the invalid format. Please try again.");
                     continue;
                 }
                

            Console.WriteLine("");

             try
                 {
                    Console.WriteLine("Please enter the end time of your shift in Decimal form using Military units. For example: 2pm = 14.00");
                    endDay = Convert.ToDecimal(Console.ReadLine());
                    if (endDay > 24 || endDay < 0)
                    {
                        Console.WriteLine("The number must be a standard measure of time. A positive number less than or equal to 24 hours");
                        continue;
                    }

                 }
                 catch (System.Exception)
                 {
                     
                     Console.WriteLine("The information you put in was in the invalid format. Please try again.");
                     continue;
                 }
            

            Console.WriteLine("");

             try
                 {
                    Console.WriteLine("Please enter the amount of money you are paid per hour of work in decimal form: ");
                    payPerHour = Convert.ToDecimal(Console.ReadLine());

                 }
                 catch (System.Exception)
                 {
                     
                    Console.WriteLine("The information you put in was in the invalid format. Please try again.");
                    continue;
                 }
            


            Console.WriteLine("");

             try
                 {
                    Console.WriteLine("Please enter the multiplier for payment in overtime: ");
                    overTime = Convert.ToDecimal(Console.ReadLine());
                    x = false;
                 }
                 catch (System.Exception)
                 {
                     
                    Console.WriteLine("The information you put in was in the invalid format. Please try again.");
                    continue;
                 }

            decimal[] arr = {startDay, endDay, payPerHour, overTime};

            DoOvertime(arr);
        }

            }
        public static void DoOvertime(decimal[] arr)
        {
            decimal totalPay;
            decimal workHours = Math.Abs(arr[0] - arr[1]);
            decimal overTimeHours;

            if (arr[0] >= arr[1])
            {
                workHours = Math.Abs(workHours - 24);
            }

            if (arr[0] < 9 && arr[1] >17)
            {
                overTimeHours = (Math.Abs(arr[0] - 9)) + (Math.Abs(arr[1] - 17));
                workHours = workHours - overTimeHours;
                totalPay = (workHours * arr[2]) + (overTimeHours * arr[2] * arr[3]);

                Console.WriteLine("Total Pay: $" + totalPay);
            }
            else if (arr[1] > 17)
            {
                overTimeHours = Math.Abs(arr[1] - 17);
                workHours = workHours - overTimeHours;
                totalPay = (workHours * arr[2]) + (overTimeHours * arr[2] * arr[3]);

                Console.WriteLine("Total Pay: $" + totalPay);
            }
            else if (arr[0] < 9)
            {
                overTimeHours = Math.Abs(arr[0] - 9);
                workHours = workHours - overTimeHours;
                totalPay = (workHours * arr[2]) + (overTimeHours * arr[2] * arr[3]);

                Console.WriteLine("Total Pay: $" + totalPay);
            }
            else
            {
                totalPay = workHours * arr[2];

                Console.WriteLine("Total Pay: $" + totalPay);
            }

        }


    }
}
