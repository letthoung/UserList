using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace UserListAPI.Models
{
    public partial class eHelpDeskContext : DbContext
    {
        public eHelpDeskContext()
        {
        }

        public eHelpDeskContext(DbContextOptions<eHelpDeskContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CamContacts> CamContacts { get; set; }
        public virtual DbSet<PhoneNumbers> PhoneNumbers { get; set; }
        public virtual DbSet<ShorelineUsers> ShorelineUsers { get; set; }
        public virtual DbSet<UserList> UserList { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;Database=eHelpDesk;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CamContacts>(entity =>
            {
                entity.ToTable("camContacts");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountCoord).HasMaxLength(20);

                entity.Property(e => e.AccountExec).HasMaxLength(20);

                entity.Property(e => e.AccountMgr).HasMaxLength(20);

                entity.Property(e => e.AccountOther).HasMaxLength(20);

                entity.Property(e => e.AcctReps).HasMaxLength(512);

                entity.Property(e => e.Address1).HasMaxLength(50);

                entity.Property(e => e.Address2).HasMaxLength(50);

                entity.Property(e => e.Address3).HasMaxLength(50);

                entity.Property(e => e.Anccard)
                    .HasColumnName("ANCCard")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Assistant).HasMaxLength(30);

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.Birthday).HasMaxLength(50);

                entity.Property(e => e.Btscount)
                    .HasColumnName("BTSCount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BtstimeStamp)
                    .HasColumnName("BTSTimeStamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.City).HasMaxLength(30);

                entity.Property(e => e.ClauseId)
                    .HasColumnName("ClauseID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Company).HasMaxLength(75);

                entity.Property(e => e.Competitor).HasDefaultValueSql("((0))");

                entity.Property(e => e.Contact).HasMaxLength(50);

                entity.Property(e => e.ContactType).HasMaxLength(30);

                entity.Property(e => e.Country).HasMaxLength(30);

                entity.Property(e => e.Dear).HasMaxLength(20);

                entity.Property(e => e.EFlyer).HasColumnName("eFlyer");

                entity.Property(e => e.Email).HasMaxLength(128);

                entity.Property(e => e.EnteredBy).HasMaxLength(20);

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.Extension).HasMaxLength(10);

                entity.Property(e => e.Fax).HasMaxLength(30);

                entity.Property(e => e.Fnecard)
                    .HasColumnName("FNECard")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GeneralInfo)
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Gift1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Gift2).HasDefaultValueSql("((0))");

                entity.Property(e => e.GmaccountNum)
                    .HasColumnName("GMAccountNum")
                    .HasMaxLength(20);

                entity.Property(e => e.HolidayGift).HasMaxLength(255);

                entity.Property(e => e.Interests).HasMaxLength(255);

                entity.Property(e => e.Kids).HasMaxLength(128);

                entity.Property(e => e.Label1).HasMaxLength(30);

                entity.Property(e => e.Label2).HasMaxLength(30);

                entity.Property(e => e.Label3).HasMaxLength(30);

                entity.Property(e => e.Label4).HasMaxLength(30);

                entity.Property(e => e.Lastname).HasMaxLength(30);

                entity.Property(e => e.MainVendor).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mfgs)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(20);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NumOfSites).HasDefaultValueSql("((0))");

                entity.Property(e => e.OldCompanyId).HasColumnName("OldCompanyID");

                entity.Property(e => e.OldContactId).HasColumnName("OldContactID");

                entity.Property(e => e.Other1).HasMaxLength(30);

                entity.Property(e => e.Other2).HasMaxLength(30);

                entity.Property(e => e.Other3).HasMaxLength(30);

                entity.Property(e => e.Other4).HasMaxLength(30);

                entity.Property(e => e.PhoneCell).HasMaxLength(30);

                entity.Property(e => e.PhoneDirect).HasMaxLength(30);

                entity.Property(e => e.PhoneMain).HasMaxLength(30);

                entity.Property(e => e.PoaccountNum)
                    .HasColumnName("POAccountNum")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')")
                    .HasComment("the RW account number for PO's");

                entity.Property(e => e.RwaccountNum)
                    .HasColumnName("RWAccountNum")
                    .HasMaxLength(20);

                entity.Property(e => e.SCompanyIds)
                    .HasColumnName("sCompanyIDs")
                    .HasMaxLength(512);

                entity.Property(e => e.SContactIds)
                    .HasColumnName("sContactIDs")
                    .HasMaxLength(512);

                entity.Property(e => e.SalesTeam).HasMaxLength(50);

                entity.Property(e => e.Source).HasMaxLength(50);

                entity.Property(e => e.Spouse).HasMaxLength(128);

                entity.Property(e => e.State).HasMaxLength(20);

                entity.Property(e => e.TempKatietoTimG).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.VerizonArea)
                    .HasMaxLength(25)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.VerizonMarket)
                    .HasMaxLength(25)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.VerizonRegion)
                    .HasMaxLength(25)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.WarrantyTerms).HasDefaultValueSql("((0))");

                entity.Property(e => e.Website).HasMaxLength(128);

                entity.Property(e => e.Zip).HasMaxLength(12);
            });

            modelBuilder.Entity<PhoneNumbers>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Note).HasMaxLength(255);

                entity.Property(e => e.PhoneName).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<ShorelineUsers>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Didnumber)
                    .HasColumnName("DIDNumber")
                    .HasMaxLength(16);

                entity.Property(e => e.Dntype).HasColumnName("DNType");

                entity.Property(e => e.PhoneName).HasMaxLength(50);
            });

            modelBuilder.Entity<UserList>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Didnumber)
                    .HasColumnName("DIDNumber")
                    .HasMaxLength(16);

                entity.Property(e => e.Ext).HasMaxLength(50);

                entity.Property(e => e.Fname)
                    .HasColumnName("FName")
                    .HasMaxLength(50);

                entity.Property(e => e.Lname)
                    .HasColumnName("LName")
                    .HasMaxLength(50);

                entity.Property(e => e.PhoneCell).HasMaxLength(30);

                entity.Property(e => e.Uname)
                    .HasColumnName("UName")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccessIds)
                    .HasColumnName("AccessIDs")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.ActiveSales).HasDefaultValueSql("((0))");

                entity.Property(e => e.ActivityPref).HasMaxLength(20);

                entity.Property(e => e.ActivityReporting).HasDefaultValueSql("((0))");

                entity.Property(e => e.CallReporting).HasDefaultValueSql("((0))");

                entity.Property(e => e.CanSchedule).HasDefaultValueSql("((1))");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("companyID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CrtDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeptId)
                    .HasColumnName("DeptID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DirectPhone)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Email2).HasMaxLength(50);

                entity.Property(e => e.Email3).HasMaxLength(50);

                entity.Property(e => e.Extension)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Fname)
                    .HasColumnName("FName")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('First')");

                entity.Property(e => e.GroupId)
                    .HasColumnName("groupID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Hdpw)
                    .HasColumnName("HDPW")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('1234')");

                entity.Property(e => e.InProd)
                    .HasColumnName("inProd")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("IPAddress")
                    .HasMaxLength(20);

                entity.Property(e => e.IsMgr)
                    .HasColumnName("isMgr")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.JobTitle).HasMaxLength(50);

                entity.Property(e => e.LastLogin).HasColumnType("datetime");

                entity.Property(e => e.Lname)
                    .HasColumnName("LName")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('Last')");

                entity.Property(e => e.LocationId)
                    .HasColumnName("LocationID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LoginCnt).HasDefaultValueSql("((0))");

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.MgrId)
                    .HasColumnName("MgrID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Mname)
                    .HasColumnName("MName")
                    .HasMaxLength(50);

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NewPortal)
                    .HasColumnName("newPortal")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OnHdstaff)
                    .HasColumnName("onHDstaff")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RwTeamName)
                    .HasColumnName("rwTeamName")
                    .HasMaxLength(10);

                entity.Property(e => e.RwUserId)
                    .HasColumnName("rwUserID")
                    .HasMaxLength(6)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SalesTeam)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('n/a')");

                entity.Property(e => e.SalesTeam2)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SalesTeam3)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SalesTeam4)
                    .HasMaxLength(50)
                    .HasComment("Uses for reporting purposes for reps associated with multiple accounts");

                entity.Property(e => e.SavePw)
                    .HasColumnName("SavePW")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SkillLevel).HasMaxLength(50);

                entity.Property(e => e.StartPage)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StartPage2)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StartPage3)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StartPage4)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StartPage5)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TeamGroup)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Uname)
                    .HasColumnName("UName")
                    .HasMaxLength(20);

                entity.Property(e => e.ZoomPref).HasDefaultValueSql("((100))");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
