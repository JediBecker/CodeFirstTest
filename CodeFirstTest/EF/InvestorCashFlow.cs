namespace CodeFirstTest.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InvestorCashFlow")]
    public partial class InvestorCashFlow
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InvestorCashFlowID { get; set; }

        public int PropertyID { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public decimal Amount { get; set; }

        public int CashFlowCategoryID { get; set; }

        public DateTime CreatedDate { get; set; }

        [Required]
        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        [Required]
        [StringLength(50)]
        public string UpdatedBy { get; set; }

        public virtual CashFlowCategory CashFlowCategory { get; set; }

        public virtual Property Property { get; set; }
    }
}
