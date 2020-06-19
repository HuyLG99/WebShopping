namespace WebApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        public int Id { get; set; }

        public int? CatalogID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public decimal? NewPrice { get; set; }

        public decimal? Price { get; set; }

        public int? Discount { get; set; }

        public string ImageLink { get; set; }

        public string ImageList { get; set; }

        [StringLength(50)]
        public string Latest { get; set; }

        [StringLength(50)]
        public string Special { get; set; }

        public int? created { get; set; }

        public int? view { get; set; }

        [StringLength(2000)]
        public string Description { get; set; }
    }
}
