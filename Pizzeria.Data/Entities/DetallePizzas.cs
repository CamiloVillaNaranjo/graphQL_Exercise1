using Pizzeria.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Pizzeria.Data.Entities
{
    public class DetallePizzas
    {
        #region Fields

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required] 
        [StringLength(40)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(200)]
        public Ingredientes Ingredientes { get; set; }
        [Required] 
        public double Precio { get; set; }
        [Required] 
        public Sizes Tamano { get; set; }
        [Required]
        public int IdDetalleOrdenes { get; set; }
        [ForeignKey("IdDetalleOrdenes")]
        public DetalleOrdenes OrderDetails { get; set; }

        #endregion

        #region ctor

        public DetallePizzas()
        {

        }

        public DetallePizzas(string nombre, Ingredientes ingredientes, Sizes tamano, double precio, int idDetalleOrden)
        {
            Nombre = nombre;
            Ingredientes = ingredientes;
            Tamano = tamano;
            Precio = precio;
            IdDetalleOrdenes = idDetalleOrden;
        }

        #endregion
    }
}
