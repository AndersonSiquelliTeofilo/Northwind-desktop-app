using System;
using System.Linq;
using System.Data.Entity;
using Northwind_desktop_app.Data;
using Northwind_desktop_app.Models;

namespace Northwind_desktop_app
{
    class Program
    {
        static void Main(string[] args)
        {
            NorthwindContext db = new NorthwindContext();
            var Test = db.Orders
                .Join(
                db.Shippers,
                orders => orders.ShipVia,
                shippers => shippers.ShipperID,
                (orders, shippers) => new
                {
                    OrderID = orders.OrderID,
                    ShipperID = shippers.ShipperID
                }
                ).ToList();;

            foreach(var list in Test)
            {
                Console.WriteLine("OrderID = {0} \t ShipperID = {1}",
                                   list.OrderID, list.ShipperID);
            }

        }
    }
}
