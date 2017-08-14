using System;
using System.Collections.Generic;

namespace Ulatina.PrograAvanzada.AW.WCF.Dominio.Acciones
{
    public class Factura
    {
        public Factura()
        {
        }       

        public IList<Model.SalesOrderHeader> FacturasRangoFecha(DateTime fechaInferior, DateTime fechaSuperior)
        {
            var laEspecificacion = new Especificaciones.Factura();
            var laFactura = laEspecificacion.FacturasRangoFecha(fechaInferior, fechaSuperior);
            return laFactura;
        }

        public IList<Model.SalesOrderHeader> FacturasRangoTotal(decimal rangoInferior, decimal rangoSuperior)
        {
            var laEspecificacion = new Especificaciones.Factura();
            var laFactura = laEspecificacion.FacturasRangoTotal(rangoInferior, rangoSuperior);
            return laFactura;
        }

        public IList<Model.SalesOrderHeader> FacturaMontoDescuento(decimal descuentoMenor, decimal descuentoMayor)
        {
            var laEspecificacion = new Especificaciones.Factura();
            var laFactura = laEspecificacion.FacturaMontoDescuento(descuentoMenor, descuentoMayor);
            return laFactura;
        }

        public IList<Model.SalesOrderHeader> FacturaArticulosOrdenRango(short cantidadArticuloMenor, short cantidadArticuloMayor)
        {
            var laEspecificacion = new Especificaciones.Factura();
            var laFactura = laEspecificacion.FacturaArticulosOrdenRango(cantidadArticuloMenor, cantidadArticuloMayor);
            return laFactura;
        }

        public IList<Model.SalesOrderHeader> FacturaGeneroEspecVendedor(string genero)
        {
            var laEspecificacion = new Especificaciones.Factura();
            var laFactura = laEspecificacion.FacturaGeneroEspecVendedor(genero);
            return laFactura;
        }

        public IList<Model.SalesOrderHeader> FacturasVendedoresRangoEdad(int edadMenor, int edadMayor)
        {
            var laEspecificacion = new Especificaciones.Factura();
            var laFactura = laEspecificacion.FacturasVendedoresRangoEdad(edadMenor, edadMayor);
            return laFactura;
        }

        public IList<Model.SalesOrderHeader> FacturasVendedoresRangAntiguedad(int fecha)
        {
            var laEspecificacion = new Especificaciones.Factura();
            var laFactura = laEspecificacion.FacturasVendedoresRangAntiguedad(fecha);
            return laFactura;
        }

        public IList<Model.SalesOrderHeader> FacturasVendedoresTextEespeciNomoApell(string Nombre, string Apellido)
        {
            var laEspecificacion = new Especificaciones.Factura();
            var laFactura = laEspecificacion.FacturasVendedoresTextEespeciNomoApell(Nombre, Apellido);
            return laFactura;
        }
    }
}