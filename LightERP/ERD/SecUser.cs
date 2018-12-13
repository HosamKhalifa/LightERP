namespace LightERP.ERD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SEC_USERS")]
    public partial class SecUser
    {
        [Key,Column("USER_ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        [Required]
        [Column("LOGON_NAME"),StringLength(30)]
        public string Logon { get; set; }

        [Column("DESCRIPTION"),StringLength(150)]
        public string Description { get; set; }
        [Column("ACTIVE")]
        public bool  Active { get; set; }
        [Column("EFFECTIVE_FROM")]
        public DateTime? EffectiveFrom { get; set; }
        [Column("EFFECTIVE_TO")]
        public DateTime? EffectiveTo { get; set; }
        [Column("EMP_AID")]
        public long? EmployeeId { get; set; }
        [Column("PWD_EXPIR_VALUE")]
        public int? PasswordExpireValue { get; set; }
        [Column("PWD_EXPIR_TYPE")]
        public long?  PasswordExpireType { get; set; }

        [Column("PWD"),StringLength(250)]
        public string Password { get; set; }
    }
}
