using System;
using System.Collections.Generic;

namespace AW.WCF.Dominio.Acciones
{
    public class Factura
    {
        public Factura()
        {
        }

        public IList<Model.SalesOrderHeader> FaturasRangoFecha(int fecha)
        {
            var laEspecificacion = new Especificaciones.Factura();
            var laFactura = laEspecificacion.FaturasRangoFecha(fecha);
            return laFactura;
        }

        public IList<Model.SalesOrderHeader> FaturaArticulosOrdenRango(string fecha)
        {
            var laEspecificacion = new Especificaciones.Factura();
            var laFactura = laEspecificacion.FaturaArticulosOrdenRango(fecha);
            return laFactura;
        }

        public  IList<Model.SalesOrderHeader> FaturaGeneroEspecVendedor(string fecha)
        {
            var laEspecificacion = new Especificaciones.Factura();
            var laFactura = laEspecificacion.FaturaGeneroEspecVendedor(fecha);
            return laFactura;
        }

        public IList<Model.SalesOrderHeader> FaturaMontoDescuento(int fecha)
        {
            var laEspecificacion = new Especificaciones.Factura();
            var laFactura = laEspecificacion.FaturaMontoDescuento(fecha);
            return laFactura;
        }

        public IList<Model.SalesOrderHeader> FaturasRangoTotal(int fecha)
        {
            var laEspecificacion = new Especificaciones.Factura();
            var laFactura = laEspecificacion.FaturasRangoTotal(fecha);
            return laFactura;
        }

        public IList<Model.SalesOrderHeader> FaturasVendedoresRangAntiguedad(int fecha)
        {
            var laEspecificacion = new Especificaciones.Factura();
            var laFactura = laEspecificacion.FaturasVendedoresRangAntiguedad(fecha);
            return laFactura;
        }

        public IList<Model.SalesOrderHeader> FaturasVendedoresRangoEdad(int fecha)
        {
            var laEspecificacion = new Especificaciones.Factura();
            var laFactura = laEspecificacion.FaturasVendedoresRangoEdad(fecha);
            return laFactura;
        }

        public IList<Model.SalesOrderHeader> FaturasVendedoresTextEespeciNomoApell(string fecha)
        {
            var laEspecificacion = new Especificaciones.Factura();
            var laFactura = laEspecificacion.FaturasVendedoresTextEespeciNomoApell(fecha);
            return laFactura;
        }
    }
}