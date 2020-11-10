using System;

namespace Bills1
{
    class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());

            const double waterBill = 20;
            const double internetBill = 15;
            double otherBills = 0;

            double waterBillCnt = 0;
            double internetBillCnt = 0;
            double electricityBillCnt = 0;
            double otherBillsCnt = 0;

            for (int i = 1; i <= months; i++)
            {
                double electricityBill = double.Parse(Console.ReadLine());

                electricityBillCnt += electricityBill;
                waterBillCnt += waterBill;
                internetBillCnt += internetBill;
                otherBills = (electricityBill + waterBill + internetBill) * 1.2;
                otherBillsCnt += otherBills;
            }
            double avg = (electricityBillCnt + waterBillCnt + internetBillCnt + otherBillsCnt) / months;
            Console.WriteLine("Electricity: {0:f2} lv", electricityBillCnt);
            Console.WriteLine("Water: {0:f2} lv", waterBillCnt);
            Console.WriteLine("Internet: {0:f2} lv", internetBillCnt);
            Console.WriteLine("Other: {0:f2} lv", otherBillsCnt);
            Console.WriteLine("Average: {0:f2} lv", avg);
        }
    }
}
