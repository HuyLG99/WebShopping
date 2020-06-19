namespace WebApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Item")]
    public partial class Item
    {
        [Key]
        public int ProductID { get; set; }

        public int CatalogID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Discount { get; set; }

        public string ImageLink { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string ImageList { get; set; }

        public int Created { get; set; }

        public decimal? PriceNew { get; set; }
    }
}
