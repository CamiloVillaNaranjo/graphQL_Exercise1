using Pizzeria.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Pizzeria.Data.Entities
{
    public class DetalleOrdenes
    {
        #region Fields

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(40)]
        public string Direccion1 { get; set; }
        public string Direccion2 { get; set; }
        [Required]
        [StringLength(12)] 
        public string MovilNo { get; set; }
        public IList<DetallePizzas> PizzaDetails { get; set; }
        public int Monto { get; set; }
        [Required] 
        public DateTime Fecha { get; set; }
        [Required] 
        public EstadoOrden EstadoOrden { get; set; }

        #endregion

        #region ctor

        public DetalleOrdenes()
        {

        }

        public DetalleOrdenes(string direccion1, string direccion2, string numeroMovil, int monto)
        {
            Direccion1 = direccion1;
            Direccion2 = direccion2;
            MovilNo = numeroMovil;
            Monto = monto;
            Fecha = DateTime.Now;
            EstadoOrden = EstadoOrden.Created;
        }
        
        #endregion
    }
}
