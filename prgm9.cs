using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    
class Consumer
    {
        private int consumerId;
        private string consumerName;

        public int ConsumerId { get => consumerId; set => consumerId = value; }
        public string ConsumerName { get => consumerName; set => consumerName = value; }

        public void Consumer_Read()
        {
            Console.WriteLine("Enter the Consumer ID: ");
            ConsumerId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Consumer Name: ");
            ConsumerName = Console.ReadLine();
        }

        public void Consumer_Display()
        {
            Console.WriteLine("Consumer ID: " + ConsumerId);
            Console.WriteLine("Consumer Name: " + ConsumerName);
        }
    }

    class Consumption : Consumer
    {
        private double unitPrevious;
        private double unitCurrent;
        private double unitConsumed;

        protected double UnitConsumed { get => unitConsumed; set => unitConsumed = value; }

        public double UnitPrevious { get => unitPrevious; set => unitPrevious = value; }
        public double UnitCurrent { get => unitCurrent; set => unitCurrent = value; }

        public void Consumption_Read()
        {
            base.Consumer_Read();
            Console.WriteLine("Enter the Previous unit ");
            UnitPrevious = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the current unit");
            UnitCurrent = Convert.ToDouble(Console.ReadLine());
        }

        public void Consumption_Calculate()
        {
            UnitConsumed = UnitCurrent - UnitPrevious;
        }

        public void Consumption_Display()
        {
            base.Consumer_Display();
            Console.WriteLine("Unit Consumed: " + UnitConsumed);
        }
    }

    class Bill : Consumption
    {
        private double amount;

        public double Amount { get => amount; set => amount = value; }

        public void Bill_Calculate()
        {

            Consumption_Calculate();
            Amount = UnitConsumed * 0.5;
        }

        public void Bill_Display()
        {
            Consumption_Display();
            Console.WriteLine("Amount Payable: " + Amount);
        }
    }
    class Assignment9_Class
    {
        static void Main(string[] args)
        {
            Bill bill = new Bill();
            bill.Consumption_Read();
            bill.Bill_Calculate();
            bill.Bill_Display();


            Console.ReadLine();
        }
    }
}
/*
Assignment 9: Multilevel Inheritanc
*/

