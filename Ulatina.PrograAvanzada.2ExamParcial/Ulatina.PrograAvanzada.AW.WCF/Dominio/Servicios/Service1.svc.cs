using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Ulatina.PrograAvanzada.AW.Model;

namespace Ulatina.PrograAvanzada.AW.WCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        

        public IList<Model.SalesOrderHeader> FacturasRangoFecha(DateTime fechaInferior, DateTime fechaSuperior)
        {

            var laAccion = new Dominio.Acciones.Factura();
            var laFactura = laAccion.FacturasRangoFecha(fechaInferior,fechaSuperior);
            return laFactura;

        }

        public IList<SalesOrderHeader> FacturasRangoTotal(decimal rangoInferior, decimal rangoSuperior)
        {
            var laAccion = new Dominio.Acciones.Factura();
            var laFactura = laAccion.FacturasRangoTotal(rangoInferior, rangoSuperior);
            return laFactura;
        }

        public IList<SalesOrderHeader> FacturaMontoDescuento(decimal descuento)
        {
            var laAccion = new Dominio.Acciones.Factura();
            var laFactura = laAccion.FacturaMontoDescuento(descuento);
            return laFactura;
        }

        public IList<SalesOrderHeader> FacturaArticulosOrdenRango(short cantidadArticuloMenor, short cantidadArticuloMayor)
        {
            var laAccion = new Dominio.Acciones.Factura();
            var laFactura = laAccion.FacturaArticulosOrdenRango(cantidadArticuloMenor,cantidadArticuloMayor);
            return laFactura;
        }

        public IList<SalesOrderHeader> FacturaGeneroEspecVendedor(string genero)
        {
            var laAccion = new Dominio.Acciones.Factura();
            var laFactura = laAccion.FacturaGeneroEspecVendedor(genero);
            return laFactura;
        }

        public IList<SalesOrderHeader> FacturasVendedoresRangoEdad(int edadMenor, int edadMayor)
        {
            var laAccion = new Dominio.Acciones.Factura();
            var laFactura = laAccion.FacturasVendedoresRangoEdad(edadMenor, edadMayor);
            return laFactura;
        }

        public IList<SalesOrderHeader> FacturasVendedoresRangAntiguedad(int fecha)
        {
            var laAccion = new Dominio.Acciones.Factura();
            var laFactura = laAccion.FacturasVendedoresRangAntiguedad(fecha);
            return laFactura;
        }



        public IList<SalesOrderHeader> FacturasVendedoresTextEespeciNomoApell(string Nombre, string Apellido)
        {
            var laAccion = new Dominio.Acciones.Factura();
            var laFactura = laAccion.FacturasVendedoresTextEespeciNomoApell(Nombre, Apellido);
            return laFactura;
        }

        /*********************************************************************************************/

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
