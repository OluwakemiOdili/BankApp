namespace BankApp.Models.DB_Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Firstname { get; set; }

        [StringLength(50)]
        public string Middlename { get; set; }

        [Required]
        [StringLength(50)]
        public string Lastname { get; set; }

        [Column(TypeName = "date")]
        public DateTime DOB { get; set; }

        public DateTime Regdate { get; set; }
    }
}
