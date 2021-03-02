namespace Seicho.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dblivraria.produtos")]
    public partial class produtos
    {
        public int ID { get; set; }

        public int? CODIGO { get; set; }

        [StringLength(100)]
        public string DESCRICAO { get; set; }

        public int? QTDE { get; set; }

        [StringLength(100)]
        public string INFO_ADICIONAIS { get; set; }

        [StringLength(45)]
        public string DT_ENTRADA { get; set; }
    }
}
