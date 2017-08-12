using System;
using System.Collections.Generic;

namespace  AW.WCF.Dominio.Especificaciones
{
    public class Factura
    {
        public Factura()
        {
        }

        

        public IList<Model.SalesOrderHeader> FaturasRangoFecha(DateTime fechaInferior, DateTime fechaSuperior)
        {
            var elRepositorio = new Repositorio.Factura();
            var laFactura = elRepositorio.FaturasRangoFecha(fechaInferior, fechaSuperior);
            return laFactura;
        }

        public IList<Model.SalesOrderHeader> FaturaArticulosOrdenRango(decimal rangoInferior, decimal rangoSuperior)
        {
            var elRepositorio = new Repositorio.Factura();
            var laFactura = elRepositorio.FaturaArticulosOrdenRango(rangoInferior, rangoSuperior);
            return laFactura;
        }

        public IList<Model.SalesOrderHeader> FaturaMontoDescuento(decimal descuento)
        {
            var elRepositorio = new Repositorio.Factura();
            var laFactura = elRepositorio.FaturaMontoDescuento(descuento);
            return laFactura;
        }

        public IList<Model.SalesOrderHeader> FaturaGeneroEspecVendedor(string fecha)
        {
            var elRepositorio = new Repositorio.Factura();
            var laFactura = elRepositorio.FaturaGeneroEspecVendedor(fecha);
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