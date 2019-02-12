using Microsoft.AspNetCore.Mvc;
using SampleEFProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace SampleEFProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Table> tables = new List<Table>();

            #region Add Table Data
            Table t1 = new Table()
            {
                Id = 1,
                Number = 101,
                Dealer = "Tina Bobango",
                Description = "On Thursday Nights Only",
                Game = GameType.FiveFivePot
            };
            Table t2 = new Table()
            {
                Id = 2,
                Number = 55,
                Dealer = "Tina Bobango",
                Description = "",
                Game = GameType.TwoFiveTexas
            };
            Table t3 = new Table()
            {
                Id = 3,
                Number = 32,
                Dealer = "Jeff Padgett",
                Description = "",
                Game = GameType.TwoFiveTexas
            };
            Table t4 = new Table()
            {
                Id = 4,
                Number = 87,
                Dealer = "John Smith",
                Description = "",
                Game = GameType.TwoFiveTexas
            };
            Table t5 = new Table()
            {
                Id = 5,
                Number = 23,
                Dealer = "Jeff Padgett",
                Description = "",
                Game = GameType.FiveFivePot
            };
            Table t6 = new Table()
            {
                Id = 6,
                Number = 5,
                Dealer = "Tina Bobango",
                Description = "",
                Game = GameType.FiveFivePot
            };
            Table t7 = new Table()
            {
                Id = 7,
                Number = 3,
                Dealer = "Jeff Padgett",
                Description = "",
                Game = GameType.FiveFivePot
            };
            Table t8 = new Table()
            {
                Id = 8,
                Number = 51,
                Dealer = "Jane Doe",
                Description = "",
                Game = GameType.FiveTenTexas
            };
            Table t9 = new Table()
            {
                Id = 9,
                Number = 19,
                Dealer = "Jane Doe",
                Description = "",
                Game = GameType.TwoFiveTexas
            };
            Table t10 = new Table()
            {
                Id = 10,
                Number = 12,
                Dealer = "Jane Doe",
                Description = "",
                Game = GameType.TwoTwoTexas
            };
            tables.Add(t1);
            tables.Add(t2);
            tables.Add(t3);
            tables.Add(t4);
            tables.Add(t5);
            tables.Add(t6);
            tables.Add(t7);
            tables.Add(t8);
            tables.Add(t9);
            tables.Add(t10);
            #endregion Add Table Data

            //Select Count of all tables -- Result should be 10
            //Query version: SELECT COUNT(*) FROM tables
           


            //Select Count of all tables where Jane Doe is the Dealer --Result should be 3
            //Query version: SELECT COUNT(*) FROM tables WHERE Dealer = 'Jane Doe'



            //Select Count of all tables where the GameType is TwoFiveTexas -- Result should be 4
            //Query version: SELECT COUNT(*) FROM tables WHERE GameType = '25'



            //Select the Smallest Table Number -- Result should return 1 table record that contains the smallest value in Number field
            //Query version: SELECT MIN(Number) FROM tables



            //Select the Largest Table Number -- Result should return 1 table record that contains the largest value in Number field.
            // Query version: SELECT MAX(Number) FROM tables



            //Order List by Table Number
            // Query version: Select * FROM tables Order By Number



            //Order list by GameType
            // Query version: Select * FROM tables Order By GameType


            return View();
        }

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
