// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace InsuranceWebApi
{
    public partial class Question
    {
        [Key]
        public int sno { get; set; }
        public int? CustId { get; set; }
        [Column("question")]
        [StringLength(500)]
        [Unicode(false)]
        public string question1 { get; set; }
        [StringLength(500)]
        [Unicode(false)]
        public string answer { get; set; }

        [ForeignKey("CustId")]
        [InverseProperty("Questions")]
        public virtual Customer Cust { get; set; }
    }
}