// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace InsuranceWebApi
{
    [Table("Customer")]
    public partial class Customer
    {
        public Customer()
        {
            AppliedPolicies = new HashSet<AppliedPolicy>();
            Questions = new HashSet<Question>();
        }

        [Key]
        public int CustId { get; set; }
        [StringLength(90)]
        [Unicode(false)]
        public string CustName { get; set; }
        [StringLength(90)]
        [Unicode(false)]
        public string Nominee { get; set; }
        [StringLength(40)]
        [Unicode(false)]
        public string Mail { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string Mobileno { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DOB { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string Gender { get; set; }
        [StringLength(40)]
        [Unicode(false)]
        public string Address { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string Pwd { get; set; }

        [InverseProperty("Cust")]
        public virtual ICollection<AppliedPolicy> AppliedPolicies { get; set; }
        [InverseProperty("Cust")]
        public virtual ICollection<Question> Questions { get; set; }
    }
}