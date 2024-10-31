using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZompyDogsLib
{
    public class Productos
    {
        private int idProducto;
        private string nombreProducto;
        private string descripcionProducto;
        private int codUnidadMedida;
        private float precioUnitario;
        private int cantidadProducto;
        private int codigoProducto;
        private DateOnly fechadeCompra;

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public string DescripcionProducto { get => descripcionProducto; set => descripcionProducto = value; }
        public int CodUnidadMedida { get => codUnidadMedida; set => codUnidadMedida = value; }
        public float PrecioUnitario { get => precioUnitario; set => precioUnitario = value; }
        public int CantidadProducto { get => cantidadProducto; set => cantidadProducto = value; }
        public int CodigoProducto { get => codigoProducto; set => codigoProducto = value; }
        public DateOnly FechadeCompra { get => fechadeCompra; set => fechadeCompra = value; }

        public Productos()
        {
            idProducto = 0;
            nombreProducto = string.Empty;
            descripcionProducto= string.Empty;
            codUnidadMedida= 0;
            precioUnitario= 0;
            cantidadProducto= 0;
            fechadeCompra = DateOnly.MaxValue;
        }

        public Productos(int id, string nombreProducto, string descripcion, int codUnidadMedida, float precionUnitario, int cantidadProducto, DateOnly fechadeCompra)
        {
            IdProducto = id;
            NombreProducto = nombreProducto;
            DescripcionProducto = descripcion;
            CodUnidadMedida = codUnidadMedida;
            PrecioUnitario = precionUnitario;
            CodigoProducto = codigoProducto;
            FechadeCompra = fechadeCompra;
        }


    }
}
