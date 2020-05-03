using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_projects_assignment5
{
    class Task3
    {
        public void generateInnerJoin(List<Item_mast> itemlist, List<Purchase> purchaselist)
        {
            //Method syntax
            var innerJoin1 = itemlist.Join( //outer sequence
                            purchaselist, //inner sequence
                            items => items.ItemId, //outer key sequence
                            purchase => purchase.ItemId, // inner key sequence
                            (items, purchase) => new // result selector
                            {
                                ItemId = items.ItemId,
                                ItemDescription=items.ItemDes,
                                InvoiceNo = purchase.InvNo,
                                Quantity= purchase.PurQty
                            }
                );


            //Query syntax
            var innerJoin2 = from i in itemlist
                             join p in purchaselist
                             on i.ItemId equals p.ItemId
                             select new
                             {
                                 ItemId = i.ItemId,
                                 ItemDescription = i.ItemDes,
                                 InvoiceNo = p.InvNo,
                                 Quantity = p.PurQty
                             };

            Console.WriteLine("Using Method syntax");
            Console.WriteLine("\nItemId     Description     InvoiceNo   Quantity");
            foreach (var obj in innerJoin1)
            {
                Console.WriteLine("{0}          {1}           {2}          {3}", obj.ItemId, obj.ItemDescription, obj.InvoiceNo, obj.Quantity);
            }

            Console.WriteLine("Using Query syntax");
            Console.WriteLine("\nItemId     Description     InvoiceNo   Quantity");
            foreach (var obj in innerJoin2)
            {
                Console.WriteLine("{0}          {1}           {2}          {3}", obj.ItemId, obj.ItemDescription, obj.InvoiceNo, obj.Quantity);
            }
        }
    }
    public class Item_mast
    {
        public int ItemId { get; set; }
        public string ItemDes { get; set; }
    }

    public class Purchase
    {
        public int InvNo { get; set; }
        public int ItemId { get; set; }
        public int PurQty { get; set; }
    }


}
