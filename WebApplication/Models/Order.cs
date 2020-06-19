namespace WebApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string CustomerId { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime RequireDate { get; set; }

        [Required]
        [StringLength(50)]
        public string Receiver { get; set; }

        [Required]
        [StringLength(60)]
        public string Address { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public double Amount { get; set; }
    }
}
