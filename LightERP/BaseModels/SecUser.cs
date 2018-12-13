using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LightERP.BaseModels
{
    [Table("SEC_USERS")]
  public  class SecUser
    {
        [Key, Column("USER_ID", TypeName = "NUMBER(4,0)"), Range(1000, 9999, ErrorMessage = "User id should be in 4 number length")]
        public int UserId { get; set; }
        [StringLength(30), Column("LOGON_NAME", TypeName = "VARCHAR2(30 BYTE)")]
        public string Logon { get; set; }

        [StringLength(150), Column("DESCRIPTION", TypeName = "VARCHAR2(150 BYTE)")]
        public string Description { get; set; }
        [Column("ACTIVE", TypeName = "NUMBER(1,0)")]
        public bool Active { get; set; }
        [Column("EFFECTIVE_FROM",TypeName ="DATE")]
        public DateTime EffectiveFrom { get; set; }
        [Column("EFFECTIVE_TO", TypeName = "DATE")]
        public DateTime EffectiveTo { get; set; }
        [Column("EMP_AID" ,TypeName ="NUMBER(14, 0)")]
        public long EmployeeId { get; set; }
        [MinLength(7), Column("PWD", TypeName = "VARCHAR2(250 BYTE)")]
        public string Pwd { get; set; }
        [Column("PWD_EXPIR_TYPE" ,TypeName = "NUMBER(14, 0)")]
        public long PasswordExpireType { get; set; }
        [Column("PWD_EXP_VALUE",TypeName ="NUMBER(4,0)")]
        public Int16 PasswordExpireValue { get; set; }


    }
}
