using System;
using System.Collections.Generic;

namespace  AW.WCF.Dominio.Especificaciones
{
    public class Factura
    {
        public Factura()
        {
        }

        public IList<Model.SalesOrderHeader> FaturasRangoFecha(int fecha)
        {
            var elRepositorio = new Repositorio.Factura();
            var laFactura = elRepositorio.FaturasRangoFecha(fecha);
            return laFactura;
        }

        public IList<Model.SalesOrderHeader> FaturaArticulosOrdenRango(string fecha)
        {
            var elRepositorio = new Repositorio.Factura();
            var laFactura = elRepositorio.FaturaArticulosOrdenRango(fecha);
            return laFactura;
        }

        public IList<Model.SalesOrderHeader> FaturaGeneroEspecVendedor(string fecha)
        {
            var elRepositorio = new Repositorio.Factura();
            var laFactura = elRepositorio.FaturaGeneroEspecVendedor(fecha);
            return laFactura;
        }

        public IList<Model.SalesOrderHeader> FaturaMontoDescuento(int fecha)
        {
            var elRepositorio = new Repositorio.Factura();
            var laFactura = elRepositorio.FaturaMontoDescuento(fecha);
            return laFactura;
        }

        public IList<Model.SalesOrderHeader> FaturasRangoTotal(int fecha)
        {
            var elRepositorio = new Repositorio.Factura();
            var laFactura = elRepositorio.FaturasRangoTotal(fecha);
            return laFactura;
        }

        public IList<Model.SalesOrderHeader> FaturasVendedoresRangAntiguedad(int fecha)
        {
            var elRepositorio = new Repositorio.Factura();
            var laFactura = elRepositorio.FaturasVendedoresRangAntiguedad(fecha);
            return laFactura;
        }

        public IList<Model.SalesOrderHeader> FaturasVendedoresRangoEdad(int fecha)
        {
            var elRepositorio = new Repositorio.Factura();
            var laFactura = elRepositorio.FaturasVendedoresRangoEdad(fecha);
            return laFactura;
        }

        public IList<Model.SalesOrderHeader> FaturasVendedoresTextEespeciNomoApell(string fecha)
        {
            var elRepositorio = new Repositorio.Factura();
            var laFactura = elRepositorio.FaturasVendedoresTextEespeciNomoApell(fecha);
            return laFactura;
        }
    }
}