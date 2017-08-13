using System;
using System.Collections.Generic;

namespace Ulatina.PrograAvanzada.AW.WCF.Dominio.Especificaciones
{
    public class Factura
    {
        public Factura()
        {
        }

        

        public IList<Model.SalesOrderHeader> FacturasRangoFecha(DateTime fechaInferior, DateTime fechaSuperior)
        {
            var elRepositorio = new Repositorio.Factura();
            var laFactura = elRepositorio.FacturasRangoFecha(fechaInferior, fechaSuperior);
            return laFactura;
        }

        public IList<Model.SalesOrderHeader> FacturasRangoTotal(decimal rangoInferior, decimal rangoSuperior)
        {
            var elRepositorio = new Repositorio.Factura();
            var laFactura = elRepositorio.FacturasRangoTotal(rangoInferior, rangoSuperior);
            return laFactura;
        }

        public IList<Model.SalesOrderHeader> FacturaMontoDescuento(decimal descuentoMenor, decimal descuentoMayor)
        {
            var elRepositorio = new Repositorio.Factura();
            var laFactura = elRepositorio.FacturaMontoDescuento(descuentoMenor, descuentoMayor);
            return laFactura;
        }

        public IList<Model.SalesOrderHeader> FacturaArticulosOrdenRango(decimal cantidadArticuloMenor, decimal cantidadArticuloMayor)
        {
            var elRepositorio = new Repositorio.Factura();
            var laFactura = elRepositorio.FacturaArticulosOrdenRango(cantidadArticuloMenor, cantidadArticuloMayor);
            return laFactura;
        }

        public IList<Model.SalesOrderHeader> FacturaGeneroEspecVendedor(string genero)
        {
            var elRepositorio = new Repositorio.Factura();
            var laFactura = elRepositorio.FacturaGeneroEspecVendedor(genero);
            return laFactura;
        }

        public IList<Model.SalesOrderHeader> FacturasVendedoresRangoEdad(int edadMenor, int edadMayor)
        {
            var elRepositorio = new Repositorio.Factura();
            var laFactura = elRepositorio.FacturasVendedoresRangoEdad(edadMenor, edadMayor);
            return laFactura;
        }

        public IList<Model.SalesOrderHeader> FacturasVendedoresRangAntiguedad(int fecha)
        {
            var elRepositorio = new Repositorio.Factura();
            var laFactura = elRepositorio.FacturasVendedoresRangAntiguedad(fecha);
            return laFactura;
        }

        public IList<Model.SalesOrderHeader> FacturasVendedoresTextEespeciNomoApell(string Nombre, string Apellido)
        {
            var elRepositorio = new Repositorio.Factura();
            var laFactura = elRepositorio.FacturasVendedoresTextEespeciNomoApell(Nombre, Apellido);
            return laFactura;
        }
    }
}