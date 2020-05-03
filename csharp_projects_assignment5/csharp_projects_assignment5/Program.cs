using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_projects_assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Task 1");
            Console.WriteLine("--------------------------------------------------------------");
            Task1 task1 = new Task1();
            int[] arr = new int[] { 3,7,8,4,5,7,2,5,7,3,4,5,6,2,8 };
            //call to method to count number and frequency of number in an array
            Console.WriteLine("Array elements are: ");
            foreach(int a in arr)
            {
                Console.Write(a + " ");
            }
            task1.countNumberAndFrequencey(arr);

            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Task 2");
            Console.WriteLine("--------------------------------------------------------------");
            Task2 task2 = new Task2();

            //creating list
            List<int> list = new List<int>();
            //adding members
            list.Add(5);
            list.Add(7);
            list.Add(13);
            list.Add(24);
            list.Add(6);
            list.Add(9);
            list.Add(8);
            list.Add(7);

            Console.Write("\nThe members of the list are :");
            //printing members
            foreach (int member in list)
            {
                Console.Write(member + " ");
            }
            //asking for number of records
            Console.Write("\nHow many records you want to display ? :");
            int noOfRecords=Int32.Parse(Console.ReadLine());

            //call to method to display the top nth records
            task2.displayTopNthRecords(list,noOfRecords);

            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Task 3");
            Console.WriteLine("--------------------------------------------------------------");
            Task3 task3 = new Task3();

            //creating to lists
            List<Item_mast> itemlist = new List<Item_mast>
            {
               new Item_mast { ItemId = 101, ItemDes = "Cakes" },
               new Item_mast { ItemId = 102, ItemDes = "Juice" },
               new Item_mast { ItemId = 103, ItemDes = "Candy" },
               new Item_mast { ItemId = 104, ItemDes = "Curry" }
            };

            List<Purchase> purchaselist = new List<Purchase>
            {
               new Purchase { InvNo=1, ItemId = 101,  PurQty = 500 },
               new Purchase { InvNo=2, ItemId = 102,  PurQty = 600 },
               new Purchase { InvNo=3, ItemId = 103,  PurQty = 700 },
               new Purchase { InvNo=4, ItemId = 104,  PurQty = 800 },
               new Purchase { InvNo=4, ItemId = 102,  PurQty = 900 }
            };

            //call to method to generate inner join
            task3.generateInnerJoin(itemlist, purchaselist);

            Console.ReadKey();
        }
    }
}
