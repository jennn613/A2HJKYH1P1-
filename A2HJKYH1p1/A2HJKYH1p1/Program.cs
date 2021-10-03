﻿/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2HJKYHS1P1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Defining variables
            string quarter; // yearly quarter that the customer registered
            string membershipNum; // membership number
            int itemNum; // number of items purchased
            double itemCost; // cost of a single item
            double totalCost; // total cost
            double discountedTotalCost; // discounted total cost
            double furtherDiscountedTotalCost; // total cost after discounting twice
            double tax; // calculate tax
            double finalCost; // final cost

            /* --------------------------------------------------------------------------- */

            // Getting user input
            /*Console.WriteLine("Please enter the quarter you registered in: ");
            quarter = Console.ReadLine();

            Console.WriteLine("Please enter your membership number: ");
            membershipNum = Console.ReadLine();

            Console.WriteLine("Please enter the number of items you are purchasing today: ");
            itemNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the cost of the item you are purchasing today: ");
            itemCost = Convert.ToDouble(Console.ReadLine());

            // Calculations
            totalCost = itemCost * itemNum;
            discountedTotalCost = Discount(itemNum, totalCost); // total cost after discounted
            tax = 0.13 * totalCost;
            finalCost = totalCost + tax;


            if (discountedTotalCost < 0) 
            {
                discountedTotalCost = -(totalCost * 0.13);
            }

            //Console.WriteLine(discountedTotalCost);

            furtherDiscountedTotalCost = Discount(discountedTotalCost);

            if (furtherDiscountedTotalCost < 0)
            {
                furtherDiscountedTotalCost = 0;
            }

            //Console.WriteLine(furtherDiscountedTotalCost);

            // Displaying information to the user
            //Console.WriteLine("");
            //Console.WriteLine(quarter + " is the quarter you registered in.");
            //Console.WriteLine("Membership number: " + membershipNum);
            //Console.WriteLine("Total items: " + itemNum);
            //Console.WriteLine("Total cost before adjustment: " + totalCost);
            //Console.WriteLine("Final cost: " + finalCost);


        }

        static double Discount(int a, double b) // discount by number of purchsed items, a = itemNum, b = totalCost
        {
            double discountedTotalCost;

            if (5 < a && a < 10)
            {
                discountedTotalCost = b - 20;
                return discountedTotalCost;
            }
            else if (10 < a)
            {
                discountedTotalCost = b * 70 / 100;
                return discountedTotalCost;
            }
            else
            {
                return b;
            }
        }

        static double Discount(double a) // discount by first discounted cost, a = itemNum, b = totalCost
        {
            double furtherDiscountedTotalCost;

            if (a > 100)
            {
                furtherDiscountedTotalCost = a * 97.5 / 100;
                return furtherDiscountedTotalCost;
            }
            else if (a < 30)
            {
                furtherDiscountedTotalCost = a - 2;
                return furtherDiscountedTotalCost;
            }
            else
            {
                return a;
            }
        }
    }
}
*/
using System;

namespace A2HJKYHS1P1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Defining variables
            string quarter;
            string membershipNum;
            int itemNum;
            double itemCost;
            double totalCost;
            double discountedTotalCost;
            double furtherDiscountedTotalCost;
            double tax;
            double finalCost;

            // Getting user input
            Console.WriteLine("Please enter the quarter you registered in: ");
            quarter = Console.ReadLine();

            Console.WriteLine("Please enter your membership number: ");
            membershipNum = Console.ReadLine();

            Console.WriteLine("Please enter the number of items you are purchasing today: ");
            itemNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the cost of the item you are purchasing today: ");
            itemCost = Convert.ToDouble(Console.ReadLine());

            // Calculations
            totalCost = itemCost * itemNum;
            discountedTotalCost = Discount(itemNum, totalCost);
            tax = 0.13 * totalCost;
            finalCost = totalCost + tax;

            if (discountedTotalCost < 0)
            {
                discountedTotalCost = -(totalCost * 0.13);
            }

            furtherDiscountedTotalCost = Discount(discountedTotalCost);
            
            if (furtherDiscountedTotalCost < 0)
            {
                furtherDiscountedTotalCost = 0;
            }

            switch (Convert.ToInt32(quarter))
            {
                case 1:
                    furtherDiscountedTotalCost - 15;
                    break;
                case 2:
                    furtherDiscountedTotalCost - 15;
                    break;
                case 3:
                    furtherDiscountedTotalCost - 5;
                    break;
                case 4:
                    furtherDiscountedTotalCost - 1;
                    break;
            }

            // Displaying information to the user
            Console.WriteLine("");
            Console.WriteLine(quarter + " is the quarter you registered in.");
            Console.WriteLine("Membership number: " + membershipNum);
            Console.WriteLine("Total items: " + itemNum);
            Console.WriteLine("Total cost before adjustment: " + totalCost);
            Console.WriteLine("Final cost: " + finalCost);
            Console.WriteLine("First discounted price: " + discountedTotalCost);
            Console.WriteLine("Second discounted price: " + furtherDiscountedTotalCost);
        }
        /*if (5 < itemNum && itemNum < 10)
        {
            discountedTotalCost = totalCost - 20;
        }
        else (10 < itemNum)
        {
            discountedTotalCost = totalCost * 70 / 100;
        }

        if (discountedTotalCost = 0)
        {
            totalCost = totalCost * 0.13;
        }

        if (discountedTotalCost > 100)
        {
            furtherDiscountedTotalCost = discountedTotalCost * 97.5 / 100;
        }
        else (discountedTotalCost < 30)
        {
            furtherDiscountedTotalCost = discountedTotalCost - 2;
        }

        if (furtherDiscountedTotalCost < 0)
        {
            furtherDiscountedTotalCost = 0;
        }*/

        static double Discount(int a, double b) // discount by number of purchsed items, a = itemNum, b = totalCost
        {
            double discountedTotalCost;

            if (5 < a && a < 10)
            {
                discountedTotalCost = b - 20;
                return discountedTotalCost;
            }
            else if (10 < a)
            {
                discountedTotalCost = b * 70 / 100;
                return discountedTotalCost;
            }
            else
            {
                return b;

            }
        }


        static double Discount(double a)
        {
            double furtherDiscountedTotalCost;

            if (a > 100)
            {
                furtherDiscountedTotalCost = a * 97.5 / 100;
                return furtherDiscountedTotalCost;
            }
            else if (a < 30)
            {
                furtherDiscountedTotalCost = a - 2;
                return furtherDiscountedTotalCost;
            }
            else
            {
                return a;
            }
        }
    }
}
