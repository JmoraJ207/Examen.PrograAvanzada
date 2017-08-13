using System;
using System.Collections.Generic;
using Ulatina.PrograAvanzada.AW.Model;

namespace Ulatina.PrograAvanzada.AdventureWorks.Dominio.Acciones
{
    public class ConvertirFacturaEnViewModel
    {
        public IList<ViewModels.FacturasViewModels> ConviertaListaDeFacturas(IList<SalesOrderHeader> listaDeFacturas)
        {
            var elResultado = new List<ViewModels.FacturasViewModels>();

            foreach(var laFactura in listaDeFacturas)
            {
                var laFacturaViewModel = new ViewModels.FacturasViewModels();

                laFacturaViewModel.DueDate = laFactura.DueDate;
                laFacturaViewModel.TotalDue = laFactura.TotalDue;

                if (laFactura.SalesOrderDetail != null)
                    laFacturaViewModel.UnitPriceDiscount = laFactura.SalesOrderDetail.UnitPriceDiscount;
                else
                    laFacturaViewModel.UnitPriceDiscount = decimal.Zero;

                if (laFactura.SalesOrderDetail != null)
                    laFacturaViewModel.LineTotal = laFactura.SalesOrderDetail.LineTotal;
                else
                    laFacturaViewModel.LineTotal = decimal.Zero;

                if (laFactura.SalesPerson.Employee.Person != null)
                    laFacturaViewModel.FirstName = laFactura.SalesPerson.Employee.Person.FirstName;
                else
                    laFacturaViewModel.FirstName = string.Empty;

                if (laFactura.SalesPerson.Employee.Person != null)
                    laFacturaViewModel.LastName = laFactura.SalesPerson.Employee.Person.LastName;
                else
                    laFacturaViewModel.LastName = string.Empty;

                if (laFactura.SalesPerson.Employee != null)
                    laFacturaViewModel.Gender = laFactura.SalesPerson.Employee.Gender;
                else
                    laFacturaViewModel.Gender = string.Empty;

                elResultado.Add(laFacturaViewModel);
            }

            return elResultado;
        }
    }
}