using System;
using System.Collections.Generic;

namespace AW.WCF.Dominio.Acciones
{
    public class Factura
    {
        public Factura()
        {
        }       

        public IList<Model.SalesOrderHeader> FaturasRangoFecha(DateTime fechaInferior, DateTime fechaSuperior)
        {
            var laEspecificacion = new Especificaciones.Factura();
            var laFactura = laEspecificacion.FaturasRangoFecha(fechaInferior, fechaSuperior);
            return laFactura;
        }

        public IList<Model.SalesOrderHeader> FaturaArticulosOrdenRango(decimal rangoInferior, decimal rangoSuperior)
        {
            var laEspecificacion = new Especificaciones.Factura();
            var laFactura = laEspecificacion.FaturaArticulosOrdenRango(rangoInferior, rangoSuperior);
            return laFactura;
        }

        public IList<Model.SalesOrderHeader> FaturaMontoDescuento(decimal descuento)
        {
            var laEspecificacion = new Especificaciones.Factura();
            var laFactura = laEspecificacion.FaturaMontoDescuento(descuento);
            return laFactura;
        }

        public  IList<Model.SalesOrderHeader> FaturaGeneroEspecVendedor(string fecha)
        {
            var laEspecificacion = new Especificaciones.Factura();
            var laFactura = laEspecificacion.FaturaGeneroEspecVendedor(fecha);
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