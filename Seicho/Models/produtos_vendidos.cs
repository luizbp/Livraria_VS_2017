namespace Seicho.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dblivraria.produtos_vendidos")]
    public partial class produtos_vendidos
    {
        public int ID { get; set; }

        public int? CODIGO { get; set; }

        [StringLength(100)]
        public string DESCRICAO { get; set; }

        public int? QTDE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_VENDA { get; set; }
    }
}
