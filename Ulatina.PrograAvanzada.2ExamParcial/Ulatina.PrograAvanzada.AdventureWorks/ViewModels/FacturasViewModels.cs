using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ulatina.PrograAvanzada.AdventureWorks.ViewModels
{
    public class FacturasViewModels
    {
        public int BusinessEntityID { get; set; }
        public int SalesOrderID { get; set; }
        public int SalesOrderDetailID { get; set; }
        public DateTime DueDate { get; set; }
        public decimal LineTotal { get; set; }
        public decimal UnitPriceDiscount { get; set; }
        public decimal TotalDue { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public Nullable<System.DateTime> SellEndDate { get; set; }
    }
}