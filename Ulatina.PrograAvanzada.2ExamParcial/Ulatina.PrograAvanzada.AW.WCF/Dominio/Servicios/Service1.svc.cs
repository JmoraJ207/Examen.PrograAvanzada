using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using AW.Model;

namespace AW.WCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        

        public IList<Model.SalesOrderHeader> FaturasRangoFecha(DateTime fechaInferior, DateTime fechaSuperior)
        {

            var laAccion = new Dominio.Acciones.Factura();
            var laFactura = laAccion.FaturasRangoFecha(fechaInferior,fechaSuperior);
            return laFactura;

        }

        public IList<SalesOrderHeader> FaturaArticulosOrdenRango(decimal rangoInferior, decimal rangoSuperior)
        {
            var laAccion = new Dominio.Acciones.Factura();
            var laFactura = laAccion.FaturaArticulosOrdenRango(rangoInferior, rangoSuperior);
            return laFactura;
        }

        public IList<SalesOrderHeader> FaturaMontoDescuento(decimal descuento)
        {
            var laAccion = new Dominio.Acciones.Factura();
            var laFactura = laAccion.FaturaMontoDescuento(descuento);
            return laFactura;
        }

        public IList<SalesOrderHeader> FaturaGeneroEspecVendedor(string fecha)
        {
            var laAccion = new Dominio.Acciones.Factura();
            var laFactura = laAccion.FaturaGeneroEspecVendedor(fecha);
            return laFactura;
        }

        



        public IList<SalesOrderHeader> FaturasRangoTotal(int fecha)
        {
            var laAccion = new Dominio.Acciones.Factura();
            var laFactura = laAccion.FaturasRangoTotal(fecha);
            return laFactura;
        }

        public  IList<SalesOrderHeader> FaturasVendedoresRangAntiguedad(int fecha)
        {
            var laAccion = new Dominio.Acciones.Factura();
            var laFactura = laAccion.FaturasVendedoresRangAntiguedad(fecha);
            return laFactura;
        }

        public IList<SalesOrderHeader> FaturasVendedoresRangoEdad(int fecha)
        {
            var laAccion = new Dominio.Acciones.Factura();
            var laFactura = laAccion.FaturasVendedoresRangoEdad(fecha);
            return laFactura;
        }

        public IList<SalesOrderHeader> FaturasVendedoresTextEespeciNomoApell(string fecha)
        {
            var laAccion = new Dominio.Acciones.Factura();
            var laFactura = laAccion.FaturasVendedoresTextEespeciNomoApell(fecha);
            return laFactura;
        }







        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

       

        string IService1.GetData(int value)
        {
            throw new NotImplementedException();
        }

        CompositeType IService1.GetDataUsingDataContract(CompositeType composite)
        {
            throw new NotImplementedException();
        }
    }
}
