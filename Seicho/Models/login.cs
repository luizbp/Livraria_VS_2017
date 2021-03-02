namespace Seicho.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dblivraria.login")]
    public partial class login
    {
        public int ID { get; set; }

        [Column("LOGIN")]
        [StringLength(20)]
        public string LOGIN1 { get; set; }

        [StringLength(16)]
        public string SENHA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(50)]
        public string NOME { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string PERMISSAO { get; set; }
    }
}
