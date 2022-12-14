using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerEnrique.Shared.Entidades
{
    public class Compra
    {
        [Key]
        public int Id { get; set; }

        public long NFactura { get; set; }

        [Required(ErrorMessage = "La Fecha es obligatorio")]
        public DateTime Fecha { get; set; } = DateTime.Today;
        public decimal CostoTotal 
        { get { return DCompras.Sum(x => IVA - (IVA * 
        (x.Descuento / 100M))); } set { } }

        public decimal SubTotal { get { return DCompras.Sum
                    (x => (x.Cantidad * x.PrecioUnitario)); } set { } }
        
        public decimal IVA { get { return  SubTotal + 
                    (SubTotal*(15M/100M)); } set { } }
        //public decimal IVA { get { return SubTotal + (SubTotal * (15M / 100M)); } set { } }
        public bool Estado { get; set; } = true;

        //Relacionando las tablas 
        //public int InventarioId { get; set; }
        public int ProveedorId { get; set; }
        ///public int ArticuloId { get; set; }
        //public int UsuarioId { get; set; }

        //public Inventario Inventario { get; set; }
        public Proveedor Proveedor { get; set; }
        //public Articulo Articulo { get; set; } //probando el maestro detalle
        // public Mecanico Mecanico { get; set; }
        public List<DCompra> DCompras { get; set; } = new List<DCompra>(); //probando el maestro detalle
        //public List<Articulo> Articulos { get; set; } = new List<Articulo>(); //probando el maestro detalle
    }
}
