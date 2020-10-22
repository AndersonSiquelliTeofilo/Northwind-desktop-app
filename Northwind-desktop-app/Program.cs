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
            var Test = db.Employees
                .Join(
                db.EmployeeTerritories,
                employees => employees.EmployeeID,
                employeeTerritories => employeeTerritories.EmployeeID,
                (employees, employeeTerritories) => new
                {
                    EmployeeID = employees.EmployeeID,
                    FirstName = employees.FirstName,
                    TerritoryID = employeeTerritories.TerritoryID
                }
                ).ToList();

            foreach(var list in Test)
            {
                Console.WriteLine("EmployeeID = {0} \t FirstName = {1} \t TerritoryID = {2}",
                                   list.EmployeeID, list.FirstName, list.TerritoryID);
            }

        }
    }
}
