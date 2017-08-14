using System;
using System.Collections.Generic;
using System.Linq;

namespace Ulatina.PrograAvanzada.AW.WCF.Dominio.Repositorio
{
    public class Factura
    {
        static Ulatina.PrograAvanzada.AW.Model.AdventureWorks2014Entities _Contexto = new Ulatina.PrograAvanzada.AW.Model.AdventureWorks2014Entities();

        public Factura()
        {
        }               

        public IList<Ulatina.PrograAvanzada.AW.Model.SalesOrderHeader> FacturasRangoFecha(DateTime fechaInferior, DateTime fechaSuperior)
        {
            var laFactura = _Contexto.SalesOrderHeaders.Where(p => fechaInferior <= p.DueDate && p.DueDate <= fechaSuperior).ToList();
            return laFactura;
        }

        public IList<Ulatina.PrograAvanzada.AW.Model.SalesOrderHeader> FacturasRangoTotal(decimal rangoInferior, decimal rangoSuperior)
        {
            var laFactura = _Contexto.SalesOrderHeaders.Where(p => rangoInferior <= p.TotalDue && p.TotalDue <= rangoSuperior).ToList();
            return laFactura;
        }

        public IList<Ulatina.PrograAvanzada.AW.Model.SalesOrderHeader> FacturaMontoDescuento(decimal descuentoMenor, decimal descuentoMayor)
        {
            var laFactura = _Contexto.SalesOrderHeaders.Where(p => descuentoMenor <= p.SalesOrderDetail.ProductID && p.SalesOrderDetail.ProductID  <= descuentoMayor).ToList();
            return laFactura;
        }

        public IList<Ulatina.PrograAvanzada.AW.Model.SalesOrderHeader> FacturaArticulosOrdenRango(decimal cantidadArticuloMenor, decimal cantidadArticuloMayor)
        {
            var laFactura = _Contexto.SalesOrderHeaders.Where(p => cantidadArticuloMenor <= p.SalesOrderDetail.LineTotal && p.SalesOrderDetail.LineTotal <= cantidadArticuloMayor).ToList();
            return laFactura;
        }

        public IList<Ulatina.PrograAvanzada.AW.Model.SalesOrderHeader> FacturaGeneroEspecVendedor(string genero)
        {
            var laFactura = _Contexto.SalesOrderHeaders.Where(p => p.SalesPerson.Employee.Gender.Equals(genero)).ToList();
            return laFactura;
        }

        public IList<Ulatina.PrograAvanzada.AW.Model.SalesOrderHeader> FacturasVendedoresRangoEdad(int edadMenor, int edadMayor)
        {            
            var laFactura = _Contexto.SalesOrderHeaders.Where(p => edadMenor <= p.SalesOrderDetail.LineTotal && p.SalesOrderDetail.LineTotal <= edadMayor).ToList();
            return laFactura;
        }

        public IList<Ulatina.PrograAvanzada.AW.Model.SalesOrderHeader> FacturasVendedoresRangAntiguedad(int fecha)
        {
            var laFactura = _Contexto.SalesOrderHeaders.Where(p => p.SalesOrderDetail.LineTotal == fecha).ToList();
            return laFactura;
        }

        public IList<Ulatina.PrograAvanzada.AW.Model.SalesOrderHeader> FacturasVendedoresTextEespeciNomoApell(string Nombre, string Apellido)
        {
            var laFactura = _Contexto.SalesOrderHeaders.Where(p => p.SalesPerson.Employee.Person.FirstName.Equals(Nombre) && p.SalesPerson.Employee.Person.LastName.Equals(Apellido)).ToList();
            return laFactura;
        }


        
    }
}