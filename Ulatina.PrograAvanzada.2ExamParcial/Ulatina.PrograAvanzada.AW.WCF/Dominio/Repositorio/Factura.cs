using System;
using System.Collections.Generic;
using System.Linq;

namespace AW.WCF.Dominio.Repositorio
{
    public class Factura
    {
        static Model.AdventureWorks2014Entities _Contexto = new Model.AdventureWorks2014Entities();

        public Factura()
        {
        }

        public IList<Model.SalesOrderHeader> FaturasRangoFecha( int fecha)
        {
            var laFactura = _Contexto.SalesOrderHeader.Where(p => p.DueDate.Contains(fecha)).ToList();
            return laFactura;
        }

        public IList<Model.SalesOrderHeader> FaturaArticulosOrdenRango(string fecha)
        {
            var laFactura = _Contexto.SalesOrderHeader.Where(p => p.DueDate.Contains(fecha)).ToList();
            return laFactura;
        }

        public IList<Model.SalesOrderHeader> FaturaGeneroEspecVendedor(string fecha)
        {
            var laFactura = _Contexto.SalesOrderHeader.Where(p => p.DueDate.Contains(fecha)).ToList();
            return laFactura;
        }

        public IList<Model.SalesOrderHeader> FaturaMontoDescuento(int fecha)
        {
            var laFactura = _Contexto.SalesOrderHeader.Where(p => p.DueDate.Contains(fecha)).ToList();
            return laFactura;
        }

        public IList<Model.SalesOrderHeader> FaturasRangoTotal(int fecha)
        {
            var laFactura = _Contexto.SalesOrderHeader.Where(p => p.DueDate.Contains(fecha)).ToList();
            return laFactura;
        }

        public IList<Model.SalesOrderHeader> FaturasVendedoresRangAntiguedad(int fecha)
        {
            var laFactura = _Contexto.SalesOrderHeader.Where(p => p.DueDate.Contains(fecha)).ToList();
            return laFactura;
        }

        public IList<Model.SalesOrderHeader> FaturasVendedoresRangoEdad(int fecha)
        {
            var laFactura = _Contexto.SalesOrderHeader.Where(p => p.DueDate.Contains(fecha)).ToList();
            return laFactura;
        }

        public IList<Model.SalesOrderHeader> FaturasVendedoresTextEespeciNomoApell(string fecha)
        {
            var laFactura = _Contexto.SalesOrderHeader.Where(p => p.DueDate.Contains(fecha)).ToList();
            return laFactura;
        }
    }
}