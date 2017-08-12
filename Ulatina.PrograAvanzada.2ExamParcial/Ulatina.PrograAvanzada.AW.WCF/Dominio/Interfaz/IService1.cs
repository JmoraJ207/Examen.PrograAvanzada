using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace AW.WCF


{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {
        //    a.Lista de facturas por rango de fecha de la orden.

        //b.Lista de facturas por rango de total.


        //c.Lista de facturas que incluyan al menos una línea de detalle cuyo monto total de descuento exceda un monto en específico.

        //d.Lista de facturas que incluyan al menos una línea de detalle cuya cantidad de artículos de la orden esté en un rango específico.

        //e.Lista de facturas de un género específico de vendedor.

        //f.Lista de facturas de vendedores que tengan un rango específico de edad.

        //g.Lista de facturas de vendedores que tengan un rango específico de antigüedad de trabajo en la empresa.

        //h.Lista de facturas de vendedores que tengan un texto específico en el apellido o en el nombre.

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);


        [OperationContract]
        IList<Model.SalesOrderHeader> FaturasRangoFecha(int fecha);

        [OperationContract]
        IList<Model.SalesOrderHeader> FaturasRangoTotal(int fecha);

        [OperationContract]
        IList<Model.SalesOrderHeader> FaturaMontoDescuento(int fecha);

        [OperationContract]
        IList<Model.SalesOrderHeader> FaturaArticulosOrdenRango(string fecha);


        [OperationContract]
        IList<Model.SalesOrderHeader> FaturaGeneroEspecVendedor(string fecha);


        [OperationContract]
        IList<Model.SalesOrderHeader> FaturasVendedoresRangoEdad(int fecha);

        [OperationContract]
        IList<Model.SalesOrderHeader> FaturasVendedoresRangAntiguedad(int fecha);

        [OperationContract]
        IList<Model.SalesOrderHeader> FaturasVendedoresTextEespeciNomoApell(string fecha);




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
