using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Ulatina.PrograAvanzada.AW.Model;

namespace Ulatina.PrograAvanzada.AdventureWorks
{
    public class SalesOrderHeadersController : Controller
    {
        private AdventureWorks2014EntitiesContext db = new AdventureWorks2014EntitiesContext();

        // GET: SalesOrderHeaders
        public ActionResult Index()
        {
            var salesOrderHeaders = db.SalesOrderHeaders.Include(s => s.SalesPerson);
            return View(salesOrderHeaders.ToList());
        }

        public ActionResult IndexViewModelFecha()
        {
            DateTime laFecha = new DateTime(2011, 11, 26,00,00,00,000);
            DateTime laFecha2 = new DateTime(2012, 01, 03, 00, 00, 00, 000);

            var laAccion = new Ulatina.PrograAvanzada.AW.WCF.Dominio.Acciones.Factura();
            var factura = laAccion.FacturasRangoFecha(laFecha, laFecha2);
            var laAccionViewModel = new Dominio.Acciones.ConvertirFacturaEnViewModel();
            var facturaViewModel = laAccionViewModel.ConviertaListaDeFacturas(factura);
            return View(facturaViewModel.ToList());
        }

        public ActionResult IndexViewModelRangoTotal()
        {
            decimal monto1 = 23150;
            decimal monto2 = (decimal)231254.23;

            var laAccion = new Ulatina.PrograAvanzada.AW.WCF.Dominio.Acciones.Factura();
            var factura = laAccion.FacturasRangoTotal(monto1, monto2);
            var laAccionViewModel = new Dominio.Acciones.ConvertirFacturaEnViewModel();
            var facturaViewModel = laAccionViewModel.ConviertaListaDeFacturas(factura);
            return View(facturaViewModel.ToList());
        }

        public ActionResult IndexViewModelMontoDescuento()
        {
            decimal monto1 = 38;
            decimal monto2 = (decimal)50.55;

            var laAccion = new Ulatina.PrograAvanzada.AW.WCF.Dominio.Acciones.Factura();
            var factura = laAccion.FacturaMontoDescuento(monto1, monto2);
            var laAccionViewModel = new Dominio.Acciones.ConvertirFacturaEnViewModel();
            var facturaViewModel = laAccionViewModel.ConviertaListaDeFacturas(factura);
            return View(facturaViewModel.ToList());
        }

        public ActionResult IndexViewModelOrdenRango()
        {
            decimal monto1 = 1;
            decimal monto2 = (decimal)100.15;

            var laAccion = new Ulatina.PrograAvanzada.AW.WCF.Dominio.Acciones.Factura();
            var factura = laAccion.FacturaArticulosOrdenRango(monto1, monto2);
            var laAccionViewModel = new Dominio.Acciones.ConvertirFacturaEnViewModel();
            var facturaViewModel = laAccionViewModel.ConviertaListaDeFacturas(factura);
            return View(facturaViewModel.ToList());
        }

        public ActionResult IndexViewModelGenero()
        {
            string elNombre = "M";
            var laAccion = new Ulatina.PrograAvanzada.AW.WCF.Dominio.Acciones.Factura();
            var factura = laAccion.FacturaGeneroEspecVendedor(elNombre);
            var laAccionViewModel = new Dominio.Acciones.ConvertirFacturaEnViewModel();
            var facturaViewModel = laAccionViewModel.ConviertaListaDeFacturas(factura);
            return View(facturaViewModel.ToList());
        }       

        public ActionResult IndexViewModelNombre()
        {
            string elNombre = "José";
            string elApellido = "Saraiva";
            var laAccion = new Ulatina.PrograAvanzada.AW.WCF.Dominio.Acciones.Factura();
            var factura = laAccion.FacturasVendedoresTextEespeciNomoApell(elNombre,elApellido);
            var laAccionViewModel = new Dominio.Acciones.ConvertirFacturaEnViewModel();
            var facturaViewModel = laAccionViewModel.ConviertaListaDeFacturas(factura);
            return View(facturaViewModel.ToList());
        }






        // GET: SalesOrderHeaders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SalesOrderHeader salesOrderHeader = db.SalesOrderHeaders.Find(id);
            if (salesOrderHeader == null)
            {
                return HttpNotFound();
            }
            return View(salesOrderHeader);
        }

        // GET: SalesOrderHeaders/Create
        public ActionResult Create()
        {
            ViewBag.SalesPersonID = new SelectList(db.SalesPersons, "BusinessEntityID", "BusinessEntityID");
            return View();
        }

        // POST: SalesOrderHeaders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SalesOrderID,RevisionNumber,OrderDate,DueDate,ShipDate,Status,OnlineOrderFlag,SalesOrderNumber,PurchaseOrderNumber,AccountNumber,CustomerID,SalesPersonID,TerritoryID,BillToAddressID,ShipToAddressID,ShipMethodID,CreditCardID,CreditCardApprovalCode,CurrencyRateID,SubTotal,TaxAmt,Freight,TotalDue,Comment,rowguid,ModifiedDate")] SalesOrderHeader salesOrderHeader)
        {
            if (ModelState.IsValid)
            {
                db.SalesOrderHeaders.Add(salesOrderHeader);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.SalesPersonID = new SelectList(db.SalesPersons, "BusinessEntityID", "BusinessEntityID", salesOrderHeader.SalesPersonID);
            return View(salesOrderHeader);
        }

        // GET: SalesOrderHeaders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SalesOrderHeader salesOrderHeader = db.SalesOrderHeaders.Find(id);
            if (salesOrderHeader == null)
            {
                return HttpNotFound();
            }
            ViewBag.SalesPersonID = new SelectList(db.SalesPersons, "BusinessEntityID", "BusinessEntityID", salesOrderHeader.SalesPersonID);
            return View(salesOrderHeader);
        }

        // POST: SalesOrderHeaders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SalesOrderID,RevisionNumber,OrderDate,DueDate,ShipDate,Status,OnlineOrderFlag,SalesOrderNumber,PurchaseOrderNumber,AccountNumber,CustomerID,SalesPersonID,TerritoryID,BillToAddressID,ShipToAddressID,ShipMethodID,CreditCardID,CreditCardApprovalCode,CurrencyRateID,SubTotal,TaxAmt,Freight,TotalDue,Comment,rowguid,ModifiedDate")] SalesOrderHeader salesOrderHeader)
        {
            if (ModelState.IsValid)
            {
                db.Entry(salesOrderHeader).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.SalesPersonID = new SelectList(db.SalesPersons, "BusinessEntityID", "BusinessEntityID", salesOrderHeader.SalesPersonID);
            return View(salesOrderHeader);
        }

        // GET: SalesOrderHeaders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SalesOrderHeader salesOrderHeader = db.SalesOrderHeaders.Find(id);
            if (salesOrderHeader == null)
            {
                return HttpNotFound();
            }
            return View(salesOrderHeader);
        }

        // POST: SalesOrderHeaders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SalesOrderHeader salesOrderHeader = db.SalesOrderHeaders.Find(id);
            db.SalesOrderHeaders.Remove(salesOrderHeader);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
