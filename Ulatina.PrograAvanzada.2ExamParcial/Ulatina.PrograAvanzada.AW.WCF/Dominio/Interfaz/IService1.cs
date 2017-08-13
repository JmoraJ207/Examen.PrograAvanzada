using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Ulatina.PrograAvanzada.AW.WCF


{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {      

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        

        [OperationContract]
        IList<Model.SalesOrderHeader> FacturasRangoFecha(DateTime fechaInferior, DateTime fechaSuperior);

        [OperationContract]
        IList<Model.SalesOrderHeader> FacturasRangoTotal(decimal rangoInferior, decimal rangoSuperior);

        [OperationContract]
        IList<Model.SalesOrderHeader> FacturaMontoDescuento(decimal descuentoMenor, decimal descuentoMayor);

        [OperationContract]
        IList<Model.SalesOrderHeader> FacturaArticulosOrdenRango(decimal cantidadArticuloMenor, decimal cantidadArticuloMayor);

        [OperationContract]
        IList<Model.SalesOrderHeader> FacturaGeneroEspecVendedor(string genero);

        [OperationContract]
        IList<Model.SalesOrderHeader> FacturasVendedoresRangoEdad(int edadMenor, int edadMayor);

        [OperationContract]
        IList<Model.SalesOrderHeader> FacturasVendedoresRangAntiguedad(int fecha);

        [OperationContract]
        IList<Model.SalesOrderHeader> FacturasVendedoresTextEespeciNomoApell(string Nombre, string Apellido);








    }



    

  

        
    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
