namespace FypStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VoteLog")]
    public partial class VoteLog
    {
        [Key]
        public int AutoId { get; set; }

        public int? ProductId { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        public short? Vote { get; set; }

        public bool? Active { get; set; }

        public virtual Product Product { get; set; }
    }
}
