namespace LightERP.ERD
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BaseDB : DbContext
    {
        public BaseDB()
            : base("name=BaseDB")
        {
        }
        #region DBSets
        public virtual DbSet<SecUser> SEC_USERS { get; set; }
        public virtual DbSet<ACT_GROUP_TB> ACT_GROUP_TB { get; set; }
        public virtual DbSet<ACT_REFNO1_TB> ACT_REFNO1_TB { get; set; }
        public virtual DbSet<ACT_REFNO2_TB> ACT_REFNO2_TB { get; set; }
        public virtual DbSet<AccountBase> AccountBase { get; set; }
        public virtual DbSet<AddressBase> ADDR_TB { get; set; }
        public virtual DbSet<CUST_ACT_TB> CUST_ACT_TB { get; set; }
        public virtual DbSet<LineBase> LINE_BASE { get; set; }
        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("NOUR");
            modelBuilder.Entity<SecUser>()
                .Property(e => e.Logon)
                .IsUnicode(false);

            modelBuilder.Entity<SecUser>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<SecUser>()
                .Property(e => e.Password)
                .IsUnicode(false);
        }
    }
}
