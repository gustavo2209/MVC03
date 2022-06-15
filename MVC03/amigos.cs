namespace MVC03
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class amigos
    {
        [Key]
        public int idamigo { get; set; }

        [Required]
        [StringLength(200)]
        public string nombre { get; set; }

        [StringLength(200)]
        public string correo { get; set; }

        [StringLength(20)]
        public string telefono { get; set; }

        [StringLength(200)]
        public string direccion { get; set; }
    }
}
