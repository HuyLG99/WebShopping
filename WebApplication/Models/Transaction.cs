namespace WebApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Transaction")]
    public partial class Transaction
    {
        public long Id { get; set; }

        public byte Status { get; set; }

        public int UserID { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        [StringLength(50)]
        public string UserEmail { get; set; }

        [Required]
        [StringLength(50)]
        public string UserPhone { get; set; }

        public decimal Amount { get; set; }

        [Required]
        [StringLength(50)]
        public string Payment { get; set; }

        [Required]
        [StringLength(250)]
        public string Message { get; set; }

        [Required]
        [StringLength(20)]
        public string Security { get; set; }

        public int Create { get; set; }
    }
}
