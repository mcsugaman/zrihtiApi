using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DAL.Entities
{
    public partial class ZrihtiContext : DbContext
    {
        public virtual DbSet<AspNetRoleClaims1> AspNetRoleClaims1 { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Badge> Badge { get; set; }
        public virtual DbSet<BadgeImg> BadgeImg { get; set; }
        public virtual DbSet<Banner1> Banner1 { get; set; }
        public virtual DbSet<CodArea> CodArea { get; set; }
        public virtual DbSet<CodCategory1> CodCategory1 { get; set; }
        public virtual DbSet<CodContractType> CodContractType { get; set; }
        public virtual DbSet<CodCurrency> CodCurrency { get; set; }
        public virtual DbSet<CodDay> CodDay { get; set; }
        public virtual DbSet<CodDbtable> CodDbtable { get; set; }
        public virtual DbSet<CodFeedbackType> CodFeedbackType { get; set; }
        public virtual DbSet<CodLanguage> CodLanguage { get; set; }
        public virtual DbSet<CodOs> CodOs { get; set; }
        public virtual DbSet<CodPhone> CodPhone { get; set; }
        public virtual DbSet<CodPlace> CodPlace { get; set; }
        public virtual DbSet<CodPlanType> CodPlanType { get; set; }
        public virtual DbSet<CodPriceSetter> CodPriceSetter { get; set; }
        public virtual DbSet<CodPriceSetterType> CodPriceSetterType { get; set; }
        public virtual DbSet<CodPriceType> CodPriceType { get; set; }
        public virtual DbSet<CodProvince> CodProvince { get; set; }
        public virtual DbSet<CodService> CodService { get; set; }
        public virtual DbSet<CodSocialNetwork> CodSocialNetwork { get; set; }
        public virtual DbSet<CodelistTr> CodelistTr { get; set; }
        public virtual DbSet<Feedback> Feedback { get; set; }
        public virtual DbSet<MobilePackage> MobilePackage { get; set; }
        public virtual DbSet<MobilePackagePrice> MobilePackagePrice { get; set; }
        public virtual DbSet<MobilePackagePriceTr> MobilePackagePriceTr { get; set; }
        public virtual DbSet<MobileProvider> MobileProvider { get; set; }
        public virtual DbSet<Office> Office { get; set; }
        public virtual DbSet<Package> Package { get; set; }
        public virtual DbSet<PackageTr> PackageTr { get; set; }
        public virtual DbSet<PlanPackage> PlanPackage { get; set; }
        public virtual DbSet<PlanPackageTr> PlanPackageTr { get; set; }
        public virtual DbSet<PortalUser> PortalUser { get; set; }
        public virtual DbSet<PortalUserImg> PortalUserImg { get; set; }
        public virtual DbSet<PriceSetter> PriceSetter { get; set; }
        public virtual DbSet<PriceSetterTr> PriceSetterTr { get; set; }
        public virtual DbSet<PromotionPlan> PromotionPlan { get; set; }
        public virtual DbSet<Provider> Provider { get; set; }
        public virtual DbSet<ProviderImg> ProviderImg { get; set; }
        public virtual DbSet<ProviderTr> ProviderTr { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Service> Service { get; set; }
        public virtual DbSet<ServiceDescription> ServiceDescription { get; set; }
        public virtual DbSet<ServiceDescriptionImg> ServiceDescriptionImg { get; set; }
        public virtual DbSet<ServiceDescriptionTr> ServiceDescriptionTr { get; set; }
        public virtual DbSet<ServiceTr> ServiceTr { get; set; }
        public virtual DbSet<SocialNetwork> SocialNetwork { get; set; }
        public virtual DbSet<WorkingTime> WorkingTime { get; set; }

        // Unable to generate entity type for table 'dbo.tmp_Badge'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_BadgeIMG'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_Banner'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_COD_Area'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.__EFMigrationsHistory$'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_COD_Category'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AspNetRoleClaims$'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Banner$'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_COD_ContractType'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.COD_Category$'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_COD_Currency'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_COD_DBTable'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_COD_Day'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_COD_FeedbackType'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_COD_Language'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_COD_OS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_COD_Phone'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_COD_Place'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_COD_PlanType'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_COD_PriceSetter'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_COD_PriceSetterType'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_COD_PriceType'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_COD_Province'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_COD_Service'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_COD_SocialNetwork'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_CodelistTR'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_Feedback'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_MobilePackage'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_MobilePackagePrice'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_MobilePackagePriceTR'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_MobileProvider'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_Office'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_Package'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_PlanPackage'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_PortalUser'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_PriceSetter'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_PromotionPlan'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_Provider'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_Role'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_Service'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_ServiceDescription'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_SocialNetwork'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_WorkingTime'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer(@"Data Source=zrihti.database.windows.net;Initial Catalog=zrihtisi;Persist Security Info=True;User ID=david.jeras;Password=Pujs3ks3mpujs3ksi");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoleClaims1>(entity =>
            {
                entity.ToTable("AspNetRoleClaims");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_AspNetRoleClaims_RoleId");

                entity.Property(e => e.RoleId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims1)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex");

                entity.Property(e => e.Id).HasMaxLength(450);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId)
                    .HasName("IX_AspNetUserClaims_UserId");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey })
                    .HasName("PK_AspNetUserLogins");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_AspNetUserLogins_UserId");

                entity.Property(e => e.LoginProvider).HasMaxLength(450);

                entity.Property(e => e.ProviderKey).HasMaxLength(450);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PK_AspNetUserRoles");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_AspNetUserRoles_RoleId");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_AspNetUserRoles_UserId");

                entity.Property(e => e.UserId).HasMaxLength(450);

                entity.Property(e => e.RoleId).HasMaxLength(450);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name })
                    .HasName("PK_AspNetUserTokens");

                entity.Property(e => e.UserId).HasMaxLength(450);

                entity.Property(e => e.LoginProvider).HasMaxLength(450);

                entity.Property(e => e.Name).HasMaxLength(450);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(450);

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<Badge>(entity =>
            {
                entity.HasKey(e => e.IdBadge)
                    .HasName("PK_BADGE");

                entity.HasIndex(e => e.IdBadgeImg)
                    .HasName("BadgeIMG_FK");

                entity.HasIndex(e => e.IdMobilePackage)
                    .HasName("MobilePackage_Badge_FK");

                entity.HasIndex(e => e.IdPhonePrice)
                    .HasName("Badge_MobilePackagePrice_FK");

                entity.Property(e => e.IdBadge).HasColumnName("ID_Badge");

                entity.Property(e => e.Colour).HasColumnType("text");

                entity.Property(e => e.IdBadgeImg).HasColumnName("ID_BadgeIMG");

                entity.Property(e => e.IdMobilePackage).HasColumnName("ID_MobilePackage");

                entity.Property(e => e.IdPhonePrice).HasColumnName("ID_PhonePrice");

                entity.Property(e => e.Text).HasColumnType("text");

                entity.HasOne(d => d.IdBadgeImgNavigation)
                    .WithMany(p => p.Badge)
                    .HasForeignKey(d => d.IdBadgeImg)
                    .HasConstraintName("FK_BADGE_BADGEIMG_BADGEIMG");

                entity.HasOne(d => d.IdMobilePackageNavigation)
                    .WithMany(p => p.Badge)
                    .HasForeignKey(d => d.IdMobilePackage)
                    .HasConstraintName("FK_BADGE_MOBILEPAC_MOBILEPA");

                entity.HasOne(d => d.IdPhonePriceNavigation)
                    .WithMany(p => p.Badge)
                    .HasForeignKey(d => d.IdPhonePrice)
                    .HasConstraintName("FK_BADGE_BADGE_MOB_MOBILEPA");
            });

            modelBuilder.Entity<BadgeImg>(entity =>
            {
                entity.HasKey(e => e.IdBadgeImg)
                    .HasName("PK_BADGEIMG");

                entity.ToTable("BadgeIMG");

                entity.Property(e => e.IdBadgeImg).HasColumnName("ID_BadgeIMG");

                entity.Property(e => e.ImageUrl).HasColumnType("text");

                entity.Property(e => e.Name).HasColumnType("text");
            });

            modelBuilder.Entity<Banner1>(entity =>
            {
                entity.HasKey(e => e.IdBanner)
                    .HasName("PK_BANNER");

                entity.ToTable("Banner");

                entity.HasIndex(e => e.IdProvider)
                    .HasName("Banner_Provider_FK");

                entity.Property(e => e.IdBanner).HasColumnName("ID_Banner");

                entity.Property(e => e.DateChanged).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.ImageUrl)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Url).HasColumnType("text");

                entity.HasOne(d => d.IdProviderNavigation)
                    .WithMany(p => p.Banner1)
                    .HasForeignKey(d => d.IdProvider)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BANNER_BANNER_PR_PROVIDER");
            });

            modelBuilder.Entity<CodArea>(entity =>
            {
                entity.HasKey(e => e.IdAreaCod)
                    .HasName("PK_COD_AREA");

                entity.ToTable("COD_Area");

                entity.Property(e => e.IdAreaCod).HasColumnName("ID_AreaCOD");

                entity.Property(e => e.Name).HasColumnType("text");
            });

            modelBuilder.Entity<CodCategory1>(entity =>
            {
                entity.HasKey(e => e.IdCategoryCod)
                    .HasName("PK_COD_CATEGORY");

                entity.ToTable("COD_Category");

                entity.HasIndex(e => e.IdAreaCod)
                    .HasName("PReCategory_Category_FK");

                entity.Property(e => e.IdCategoryCod).HasColumnName("ID_CategoryCOD");

                entity.Property(e => e.IdAreaCod).HasColumnName("ID_AreaCOD");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("text");

                entity.HasOne(d => d.IdAreaCodNavigation)
                    .WithMany(p => p.CodCategory1)
                    .HasForeignKey(d => d.IdAreaCod)
                    .HasConstraintName("FK_COD_CATE_PRECATEGO_COD_AREA");
            });

            modelBuilder.Entity<CodContractType>(entity =>
            {
                entity.HasKey(e => e.IdContarctTypeCod)
                    .HasName("PK_COD_CONTRACTTYPE");

                entity.ToTable("COD_ContractType");

                entity.Property(e => e.IdContarctTypeCod).HasColumnName("ID_ContarctTypeCOD");

                entity.Property(e => e.Name).HasColumnType("text");
            });

            modelBuilder.Entity<CodCurrency>(entity =>
            {
                entity.HasKey(e => e.IdCurrencyCod)
                    .HasName("PK_COD_CURRENCY");

                entity.ToTable("COD_Currency");

                entity.Property(e => e.IdCurrencyCod).HasColumnName("ID_CurrencyCOD");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Symbol)
                    .IsRequired()
                    .HasColumnType("text");
            });

            modelBuilder.Entity<CodDay>(entity =>
            {
                entity.HasKey(e => e.IdDayCod)
                    .HasName("PK_COD_DAY");

                entity.ToTable("COD_Day");

                entity.Property(e => e.IdDayCod).HasColumnName("ID_DayCOD");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("text");
            });

            modelBuilder.Entity<CodDbtable>(entity =>
            {
                entity.HasKey(e => e.IdDbtableCod)
                    .HasName("PK_COD_DBTABLE");

                entity.ToTable("COD_DBTable");

                entity.Property(e => e.IdDbtableCod).HasColumnName("ID_DBTableCOD");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("text");
            });

            modelBuilder.Entity<CodFeedbackType>(entity =>
            {
                entity.HasKey(e => e.IdFeedbackTypeCod)
                    .HasName("PK_COD_FEEDBACKTYPE");

                entity.ToTable("COD_FeedbackType");

                entity.Property(e => e.IdFeedbackTypeCod).HasColumnName("ID_FeedbackTypeCOD");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("text");
            });

            modelBuilder.Entity<CodLanguage>(entity =>
            {
                entity.HasKey(e => e.IdLanguageCod)
                    .HasName("PK_COD_LANGUAGE");

                entity.ToTable("COD_Language");

                entity.Property(e => e.IdLanguageCod).HasColumnName("ID_LanguageCOD");

                entity.Property(e => e.IsDefault).HasColumnName("IS_Default");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("text");
            });

            modelBuilder.Entity<CodOs>(entity =>
            {
                entity.HasKey(e => e.IdOscod)
                    .HasName("PK_COD_OS");

                entity.ToTable("COD_OS");

                entity.Property(e => e.IdOscod).HasColumnName("ID_OSCOD");

                entity.Property(e => e.Name).HasColumnType("text");
            });

            modelBuilder.Entity<CodPhone>(entity =>
            {
                entity.HasKey(e => e.IdPhoneCod)
                    .HasName("PK_COD_PHONE");

                entity.ToTable("COD_Phone");

                entity.HasIndex(e => e.IdOscod)
                    .HasName("Phone_OS_FK");

                entity.Property(e => e.IdPhoneCod).HasColumnName("ID_PhoneCOD");

                entity.Property(e => e.Battery).HasColumnType("text");

                entity.Property(e => e.Camera).HasColumnType("text");

                entity.Property(e => e.ColorDepth).HasColumnType("text");

                entity.Property(e => e.DateChanged).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.Dimensions).HasColumnType("text");

                entity.Property(e => e.IdOscod).HasColumnName("ID_OSCOD");

                entity.Property(e => e.ImageUrlPhone).HasColumnType("text");

                entity.Property(e => e.Name).HasColumnType("text");

                entity.Property(e => e.Processor).HasColumnType("text");

                entity.Property(e => e.Ram).HasColumnType("text");

                entity.Property(e => e.Resolution).HasColumnType("text");

                entity.Property(e => e.Weight).HasColumnType("text");

                entity.HasOne(d => d.IdOscodNavigation)
                    .WithMany(p => p.CodPhone)
                    .HasForeignKey(d => d.IdOscod)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_COD_PHON_PHONE_OS_COD_OS");
            });

            modelBuilder.Entity<CodPlace>(entity =>
            {
                entity.HasKey(e => e.IdPlaceCod)
                    .HasName("PK_COD_PLACE");

                entity.ToTable("COD_Place");

                entity.HasIndex(e => e.IdProvinceCod)
                    .HasName("Place_Province_FK");

                entity.Property(e => e.IdPlaceCod).HasColumnName("ID_PlaceCOD");

                entity.Property(e => e.IdProvinceCod).HasColumnName("ID_ProvinceCOD");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("text");

                entity.HasOne(d => d.IdProvinceCodNavigation)
                    .WithMany(p => p.CodPlace)
                    .HasForeignKey(d => d.IdProvinceCod)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_COD_PLAC_PLACE_PRO_COD_PROV");
            });

            modelBuilder.Entity<CodPlanType>(entity =>
            {
                entity.HasKey(e => e.IdPlanTypeCod)
                    .HasName("PK_COD_PLANTYPE");

                entity.ToTable("COD_PlanType");

                entity.Property(e => e.IdPlanTypeCod).HasColumnName("ID_PlanTypeCOD");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("text");
            });

            modelBuilder.Entity<CodPriceSetter>(entity =>
            {
                entity.HasKey(e => e.IdPriceSetterCod)
                    .HasName("PK_COD_PRICESETTER");

                entity.ToTable("COD_PriceSetter");

                entity.HasIndex(e => e.IdPriceSetterTypeCod)
                    .HasName("PriceSetter_PriceSetterType_FK");

                entity.Property(e => e.IdPriceSetterCod).HasColumnName("ID_PriceSetterCOD");

                entity.Property(e => e.IdPriceSetterTypeCod).HasColumnName("ID_PriceSetterTypeCOD");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("text");

                entity.HasOne(d => d.IdPriceSetterTypeCodNavigation)
                    .WithMany(p => p.CodPriceSetter)
                    .HasForeignKey(d => d.IdPriceSetterTypeCod)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_COD_PRIC_PRICESETT_COD_PRIC");
            });

            modelBuilder.Entity<CodPriceSetterType>(entity =>
            {
                entity.HasKey(e => e.IdPriceSetterTypeCod)
                    .HasName("PK_COD_PRICESETTERTYPE");

                entity.ToTable("COD_PriceSetterType");

                entity.Property(e => e.IdPriceSetterTypeCod).HasColumnName("ID_PriceSetterTypeCOD");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("text");
            });

            modelBuilder.Entity<CodPriceType>(entity =>
            {
                entity.HasKey(e => e.IdPriceTypeCod)
                    .HasName("PK_COD_PRICETYPE");

                entity.ToTable("COD_PriceType");

                entity.Property(e => e.IdPriceTypeCod).HasColumnName("ID_PriceTypeCOD");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("text");
            });

            modelBuilder.Entity<CodProvince>(entity =>
            {
                entity.HasKey(e => e.IdProvinceCod)
                    .HasName("PK_COD_PROVINCE");

                entity.ToTable("COD_Province");

                entity.Property(e => e.IdProvinceCod).HasColumnName("ID_ProvinceCOD");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("text");
            });

            modelBuilder.Entity<CodService>(entity =>
            {
                entity.HasKey(e => e.IdServiceCod)
                    .HasName("PK_COD_SERVICE");

                entity.ToTable("COD_Service");

                entity.HasIndex(e => e.IdCategoryCod)
                    .HasName("COD_Category_COD_Service_FK");

                entity.Property(e => e.IdServiceCod).HasColumnName("ID_ServiceCOD");

                entity.Property(e => e.IdCategoryCod).HasColumnName("ID_CategoryCOD");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("text");

                entity.HasOne(d => d.IdCategoryCodNavigation)
                    .WithMany(p => p.CodService)
                    .HasForeignKey(d => d.IdCategoryCod)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_COD_SERV_COD_CATEG_COD_CATE");
            });

            modelBuilder.Entity<CodSocialNetwork>(entity =>
            {
                entity.HasKey(e => e.IdSocialNetworkCod)
                    .HasName("PK_COD_SOCIALNETWORK");

                entity.ToTable("COD_SocialNetwork");

                entity.Property(e => e.IdSocialNetworkCod).HasColumnName("ID_SocialNetworkCOD");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("text");
            });

            modelBuilder.Entity<CodelistTr>(entity =>
            {
                entity.HasKey(e => e.IdCodelistTr)
                    .HasName("PK_CODELISTTR");

                entity.ToTable("CodelistTR");

                entity.HasIndex(e => e.IdDbtableCod)
                    .HasName("Codelist_Table_FK");

                entity.HasIndex(e => e.IdLanguageCod)
                    .HasName("Relationship_45_FK");

                entity.Property(e => e.IdCodelistTr).HasColumnName("ID_CodelistTR");

                entity.Property(e => e.IdDbtableCod).HasColumnName("ID_DBTableCOD");

                entity.Property(e => e.IdLanguageCod).HasColumnName("ID_LanguageCOD");

                entity.Property(e => e.Text).HasColumnType("text");

                entity.HasOne(d => d.IdDbtableCodNavigation)
                    .WithMany(p => p.CodelistTr)
                    .HasForeignKey(d => d.IdDbtableCod)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CODELIST_CODELIST__COD_DBTA");

                entity.HasOne(d => d.IdLanguageCodNavigation)
                    .WithMany(p => p.CodelistTr)
                    .HasForeignKey(d => d.IdLanguageCod)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CODELIST_RELATIONS_COD_LANG");
            });

            modelBuilder.Entity<Feedback>(entity =>
            {
                entity.HasKey(e => e.IdFeedback)
                    .HasName("PK_FEEDBACK");

                entity.HasIndex(e => e.IdDbtableCod)
                    .HasName("Feedbck_DBTable_FK");

                entity.HasIndex(e => e.IdFeedbackTypeCod)
                    .HasName("Feedback_FeedbackType_FK");

                entity.HasIndex(e => e.IdPortalUser)
                    .HasName("User_Feedback_FK");

                entity.Property(e => e.IdFeedback).HasColumnName("ID_Feedback");

                entity.Property(e => e.Comment).HasColumnType("text");

                entity.Property(e => e.DateChanged).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.FkEntityId).HasColumnName("FK_EntityID");

                entity.Property(e => e.IdDbtableCod).HasColumnName("ID_DBTableCOD");

                entity.Property(e => e.IdFeedbackTypeCod).HasColumnName("ID_FeedbackTypeCOD");

                entity.Property(e => e.IdPortalUser).HasColumnName("ID_PortalUser");

                entity.HasOne(d => d.IdDbtableCodNavigation)
                    .WithMany(p => p.Feedback)
                    .HasForeignKey(d => d.IdDbtableCod)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_FEEDBACK_FEEDBCK_D_COD_DBTA");

                entity.HasOne(d => d.IdFeedbackTypeCodNavigation)
                    .WithMany(p => p.Feedback)
                    .HasForeignKey(d => d.IdFeedbackTypeCod)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_FEEDBACK_FEEDBACK__COD_FEED");

                entity.HasOne(d => d.IdPortalUserNavigation)
                    .WithMany(p => p.Feedback)
                    .HasForeignKey(d => d.IdPortalUser)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_FEEDBACK_USER_FEED_PORTALUS");
            });

            modelBuilder.Entity<MobilePackage>(entity =>
            {
                entity.HasKey(e => e.IdMobilePackage)
                    .HasName("PK_MOBILEPACKAGE");

                entity.HasIndex(e => e.IdContarctTypeCod)
                    .HasName("ContractType_MobilePackage_FK");

                entity.Property(e => e.IdMobilePackage).HasColumnName("ID_MobilePackage");

                entity.Property(e => e.DateChanged).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.IdContarctTypeCod).HasColumnName("ID_ContarctTypeCOD");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.PriceMonthly).HasColumnType("money");

                entity.HasOne(d => d.IdContarctTypeCodNavigation)
                    .WithMany(p => p.MobilePackage)
                    .HasForeignKey(d => d.IdContarctTypeCod)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_MOBILEPA_CONTRACTT_COD_CONT");
            });

            modelBuilder.Entity<MobilePackagePrice>(entity =>
            {
                entity.HasKey(e => e.IdPhonePrice)
                    .HasName("PK_MOBILEPACKAGEPRICE");

                entity.HasIndex(e => e.IdContarctTypeCod)
                    .HasName("MobilePackagePrice_ContractType_FK");

                entity.HasIndex(e => e.IdMobilePackage)
                    .HasName("MobilePackagePrice_MobilePackage_FK");

                entity.HasIndex(e => e.IdMobileProvider)
                    .HasName("MobieProvider_MobilePackageProvider_FK");

                entity.HasIndex(e => e.IdPhoneCod)
                    .HasName("Phone_MobilePackagePrice_FK");

                entity.Property(e => e.IdPhonePrice).HasColumnName("ID_PhonePrice");

                entity.Property(e => e.DateChanged).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.IdContarctTypeCod).HasColumnName("ID_ContarctTypeCOD");

                entity.Property(e => e.IdMobilePackage).HasColumnName("ID_MobilePackage");

                entity.Property(e => e.IdMobileProvider).HasColumnName("ID_MobileProvider");

                entity.Property(e => e.IdPhoneCod).HasColumnName("ID_PhoneCOD");

                entity.Property(e => e.PriceMonthly).HasColumnType("money");

                entity.Property(e => e.PriceWithContract).HasColumnType("money");

                entity.Property(e => e.TotalCost).HasColumnType("money");

                entity.Property(e => e.Upfront).HasColumnType("money");

                entity.HasOne(d => d.IdContarctTypeCodNavigation)
                    .WithMany(p => p.MobilePackagePrice)
                    .HasForeignKey(d => d.IdContarctTypeCod)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_MOBILEPA_MOBILEPAC_COD_CONT");

                entity.HasOne(d => d.IdMobilePackageNavigation)
                    .WithMany(p => p.MobilePackagePrice)
                    .HasForeignKey(d => d.IdMobilePackage)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_MOBILEPA_MOBILEPAC_MOBILEPA");

                entity.HasOne(d => d.IdMobileProviderNavigation)
                    .WithMany(p => p.MobilePackagePrice)
                    .HasForeignKey(d => d.IdMobileProvider)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_MOBILEPA_MOBIEPROV_MOBILEPR");

                entity.HasOne(d => d.IdPhoneCodNavigation)
                    .WithMany(p => p.MobilePackagePrice)
                    .HasForeignKey(d => d.IdPhoneCod)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_MOBILEPA_PHONE_MOB_COD_PHON");
            });

            modelBuilder.Entity<MobilePackagePriceTr>(entity =>
            {
                entity.HasKey(e => e.IdMobilePackagePriceTr)
                    .HasName("PK_MOBILEPACKAGEPRICETR");

                entity.ToTable("MobilePackagePriceTR");

                entity.HasIndex(e => e.IdLanguageCod)
                    .HasName("MobilePackagePrice_Language_FK");

                entity.HasIndex(e => e.IdPhonePrice)
                    .HasName("MobilePackagePriceTR_FK");

                entity.Property(e => e.IdMobilePackagePriceTr).HasColumnName("ID_MobilePackagePriceTR");

                entity.Property(e => e.IdLanguageCod).HasColumnName("ID_LanguageCOD");

                entity.Property(e => e.IdPhonePrice).HasColumnName("ID_PhonePrice");

                entity.Property(e => e.Note).HasColumnType("text");

                entity.HasOne(d => d.IdLanguageCodNavigation)
                    .WithMany(p => p.MobilePackagePriceTr)
                    .HasForeignKey(d => d.IdLanguageCod)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_MOBILEPA_MOBILEPAC_COD_LANG");

                entity.HasOne(d => d.IdPhonePriceNavigation)
                    .WithMany(p => p.MobilePackagePriceTr)
                    .HasForeignKey(d => d.IdPhonePrice)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_MOBILEPA_MOBILEPAC_MOBILEPA1");
            });

            modelBuilder.Entity<MobileProvider>(entity =>
            {
                entity.HasKey(e => e.IdMobileProvider)
                    .HasName("PK_MOBILEPROVIDER");

                entity.HasIndex(e => e.IdProvider)
                    .HasName("Relationship_56_FK");

                entity.Property(e => e.IdMobileProvider).HasColumnName("ID_MobileProvider");

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.HasOne(d => d.IdProviderNavigation)
                    .WithMany(p => p.MobileProvider)
                    .HasForeignKey(d => d.IdProvider)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_MOBILEPR_RELATIONS_PROVIDER");
            });

            modelBuilder.Entity<Office>(entity =>
            {
                entity.HasKey(e => e.IdOffice)
                    .HasName("PK_OFFICE");

                entity.HasIndex(e => e.IdPlaceCod)
                    .HasName("Office_Place_FK");

                entity.HasIndex(e => e.IdProvider)
                    .HasName("Provider_Office_FK");

                entity.Property(e => e.IdOffice).HasColumnName("ID_Office");

                entity.Property(e => e.DateChanged).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.Email).HasColumnType("text");

                entity.Property(e => e.Fax).HasColumnType("text");

                entity.Property(e => e.HouseNumber)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.IdPlaceCod).HasColumnName("ID_PlaceCOD");

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.IsMain).HasColumnName("IS_Main");

                entity.Property(e => e.Latitude).HasColumnType("text");

                entity.Property(e => e.Longitude).HasColumnType("text");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Street)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Telephone).HasColumnType("text");

                entity.Property(e => e.TelephoneMobile).HasColumnType("text");

                entity.HasOne(d => d.IdPlaceCodNavigation)
                    .WithMany(p => p.Office)
                    .HasForeignKey(d => d.IdPlaceCod)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OFFICE_OFFICE_PL_COD_PLAC");

                entity.HasOne(d => d.IdProviderNavigation)
                    .WithMany(p => p.Office)
                    .HasForeignKey(d => d.IdProvider)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OFFICE_PROVIDER__PROVIDER");
            });

            modelBuilder.Entity<Package>(entity =>
            {
                entity.HasKey(e => e.IdPackage)
                    .HasName("PK_PACKAGE");

                entity.HasIndex(e => e.IdCurrencyCod)
                    .HasName("Package_COD_Currency_FK");

                entity.HasIndex(e => e.IdPriceTypeCod)
                    .HasName("Package_COD_PriceType_FK");

                entity.HasIndex(e => e.IdProvider)
                    .HasName("Provider_Package_FK");

                entity.Property(e => e.IdPackage).HasColumnName("ID_Package");

                entity.Property(e => e.DateChanged).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.IdCurrencyCod).HasColumnName("ID_CurrencyCOD");

                entity.Property(e => e.IdPriceTypeCod).HasColumnName("ID_PriceTypeCOD");

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.ValidFrom).HasColumnType("datetime");

                entity.Property(e => e.ValidTo).HasColumnType("datetime");

                entity.HasOne(d => d.IdCurrencyCodNavigation)
                    .WithMany(p => p.Package)
                    .HasForeignKey(d => d.IdCurrencyCod)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PACKAGE_PACKAGE_C_COD_CURR");

                entity.HasOne(d => d.IdPriceTypeCodNavigation)
                    .WithMany(p => p.Package)
                    .HasForeignKey(d => d.IdPriceTypeCod)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PACKAGE_PACKAGE_C_COD_PRIC");

                entity.HasOne(d => d.IdProviderNavigation)
                    .WithMany(p => p.Package)
                    .HasForeignKey(d => d.IdProvider)
                    .HasConstraintName("FK_PACKAGE_PROVIDER__PROVIDER");
            });

            modelBuilder.Entity<PackageTr>(entity =>
            {
                entity.HasKey(e => e.IdPackageTr)
                    .HasName("PK_PACKAGETR");

                entity.ToTable("PackageTR");

                entity.HasIndex(e => e.IdLanguageCod)
                    .HasName("Relationship_23_FK");

                entity.HasIndex(e => e.IdPackage)
                    .HasName("PackageTR_FK");

                entity.Property(e => e.IdPackageTr).HasColumnName("ID_PackageTR");

                entity.Property(e => e.IdLanguageCod).HasColumnName("ID_LanguageCOD");

                entity.Property(e => e.IdPackage).HasColumnName("ID_Package");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.SubTitle).HasColumnType("text");

                entity.HasOne(d => d.IdLanguageCodNavigation)
                    .WithMany(p => p.PackageTr)
                    .HasForeignKey(d => d.IdLanguageCod)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PACKAGET_RELATIONS_COD_LANG");

                entity.HasOne(d => d.IdPackageNavigation)
                    .WithMany(p => p.PackageTr)
                    .HasForeignKey(d => d.IdPackage)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PACKAGET_PACKAGETR_PACKAGE");
            });

            modelBuilder.Entity<PlanPackage>(entity =>
            {
                entity.HasKey(e => e.IdPlanPackage)
                    .HasName("PK_PLANPACKAGE");

                entity.HasIndex(e => e.IdCurrencyCod)
                    .HasName("PlanPackage_COD_Currency_FK");

                entity.HasIndex(e => e.IdPlanTypeCod)
                    .HasName("PlanPackage_PlanType_FK");

                entity.Property(e => e.IdPlanPackage).HasColumnName("ID_PlanPackage");

                entity.Property(e => e.DateChanged).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.IdCurrencyCod).HasColumnName("ID_CurrencyCOD");

                entity.Property(e => e.IdPlanTypeCod).HasColumnName("ID_PlanTypeCOD");

                entity.Property(e => e.PriceMonthly).HasColumnType("money");

                entity.Property(e => e.ValidFrom).HasColumnType("datetime");

                entity.Property(e => e.ValidTo).HasColumnType("datetime");

                entity.HasOne(d => d.IdCurrencyCodNavigation)
                    .WithMany(p => p.PlanPackage)
                    .HasForeignKey(d => d.IdCurrencyCod)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PLANPACK_PLANPACKA_COD_CURR");

                entity.HasOne(d => d.IdPlanTypeCodNavigation)
                    .WithMany(p => p.PlanPackage)
                    .HasForeignKey(d => d.IdPlanTypeCod)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PLANPACK_PLANPACKA_COD_PLAN");
            });

            modelBuilder.Entity<PlanPackageTr>(entity =>
            {
                entity.HasKey(e => e.IdPlanPackageTr)
                    .HasName("PK_PLANPACKAGETR");

                entity.ToTable("PlanPackageTR");

                entity.HasIndex(e => e.IdLanguageCod)
                    .HasName("PlanPackageTRLang_FK");

                entity.HasIndex(e => e.IdPlanPackage)
                    .HasName("PlanPackageTR_FK");

                entity.Property(e => e.IdPlanPackageTr).HasColumnName("ID_PlanPackageTR");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.IdLanguageCod).HasColumnName("ID_LanguageCOD");

                entity.Property(e => e.IdPlanPackage).HasColumnName("ID_PlanPackage");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("text");

                entity.HasOne(d => d.IdLanguageCodNavigation)
                    .WithMany(p => p.PlanPackageTr)
                    .HasForeignKey(d => d.IdLanguageCod)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PLANPACK_PLANPACKA_COD_LANG");

                entity.HasOne(d => d.IdPlanPackageNavigation)
                    .WithMany(p => p.PlanPackageTr)
                    .HasForeignKey(d => d.IdPlanPackage)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PLANPACK_PLANPACKA_PLANPACK");
            });

            modelBuilder.Entity<PortalUser>(entity =>
            {
                entity.HasKey(e => e.IdPortalUser)
                    .HasName("PK_PORTALUSER");

                entity.HasIndex(e => e.IdProvider)
                    .HasName("User_Provider_FK");

                entity.HasIndex(e => e.IdRole)
                    .HasName("PortalUser_Role_FK");

                entity.Property(e => e.IdPortalUser).HasColumnName("ID_PortalUser");

                entity.Property(e => e.ConfirmationHash).HasColumnType("varchar(1024)");

                entity.Property(e => e.DateChanged).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.IdRole).HasColumnName("ID_Role");

                entity.Property(e => e.IsProvider).HasColumnName("IS_Provider");

                entity.Property(e => e.IsResource).HasColumnName("IS_Resource");

                entity.Property(e => e.LoginId)
                    .IsRequired()
                    .HasColumnName("LoginID")
                    .HasMaxLength(450);

                entity.Property(e => e.NameFirst).HasColumnType("text");

                entity.Property(e => e.NameLast).HasColumnType("text");

                entity.Property(e => e.Password).HasColumnType("text");

                entity.Property(e => e.Username).HasColumnType("text");

                entity.HasOne(d => d.IdProviderNavigation)
                    .WithMany(p => p.PortalUser)
                    .HasForeignKey(d => d.IdProvider)
                    .HasConstraintName("FK_PORTALUS_USER_PROV_PROVIDER");

                entity.HasOne(d => d.IdRoleNavigation)
                    .WithMany(p => p.PortalUser)
                    .HasForeignKey(d => d.IdRole)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PORTALUS_PORTALUSE_ROLE");
            });

            modelBuilder.Entity<PortalUserImg>(entity =>
            {
                entity.HasKey(e => e.IdPortalUserImg)
                    .HasName("PK_PORTALUSERIMG");

                entity.ToTable("PortalUserIMG");

                entity.HasIndex(e => e.IdPortalUser)
                    .HasName("UserIMG_FK");

                entity.Property(e => e.IdPortalUserImg).HasColumnName("ID_PortalUserIMG");

                entity.Property(e => e.DateChanged).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.IdPortalUser).HasColumnName("ID_PortalUser");

                entity.Property(e => e.ImageUrl)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.IsAvatar).HasColumnName("IS_Avatar");

                entity.HasOne(d => d.IdPortalUserNavigation)
                    .WithMany(p => p.PortalUserImg)
                    .HasForeignKey(d => d.IdPortalUser)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PORTALUS_USERIMG_PORTALUS");
            });

            modelBuilder.Entity<PriceSetter>(entity =>
            {
                entity.HasKey(e => e.IdPriceSetter)
                    .HasName("PK_PRICESETTER");

                entity.HasIndex(e => e.IdPackage)
                    .HasName("Package_PriceSetter_FK");

                entity.HasIndex(e => e.IdPriceSetterCod)
                    .HasName("PriceSetter_COD_PriceSetter_FK");

                entity.Property(e => e.IdPriceSetter).HasColumnName("ID_PriceSetter");

                entity.Property(e => e.DateChanged).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.IdPackage).HasColumnName("ID_Package");

                entity.Property(e => e.IdPriceSetterCod).HasColumnName("ID_PriceSetterCOD");

                entity.HasOne(d => d.IdPackageNavigation)
                    .WithMany(p => p.PriceSetter)
                    .HasForeignKey(d => d.IdPackage)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PRICESET_PACKAGE_P_PACKAGE");

                entity.HasOne(d => d.IdPriceSetterCodNavigation)
                    .WithMany(p => p.PriceSetter)
                    .HasForeignKey(d => d.IdPriceSetterCod)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PRICESET_PRICESETT_COD_PRIC");
            });

            modelBuilder.Entity<PriceSetterTr>(entity =>
            {
                entity.HasKey(e => e.IdPriceSetterTr)
                    .HasName("PK_PRICESETTERTR");

                entity.ToTable("PriceSetterTR");

                entity.HasIndex(e => e.IdLanguageCod)
                    .HasName("PriceSetterTRLang_FK");

                entity.HasIndex(e => e.IdPriceSetter)
                    .HasName("PriceSetterTR_FK");

                entity.Property(e => e.IdPriceSetterTr).HasColumnName("ID_PriceSetterTR");

                entity.Property(e => e.IdLanguageCod).HasColumnName("ID_LanguageCOD");

                entity.Property(e => e.IdPriceSetter).HasColumnName("ID_PriceSetter");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnType("text");

                entity.HasOne(d => d.IdLanguageCodNavigation)
                    .WithMany(p => p.PriceSetterTr)
                    .HasForeignKey(d => d.IdLanguageCod)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PRICESET_PRICESETT_COD_LANG");

                entity.HasOne(d => d.IdPriceSetterNavigation)
                    .WithMany(p => p.PriceSetterTr)
                    .HasForeignKey(d => d.IdPriceSetter)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PRICESET_PRICESETT_PRICESET");
            });

            modelBuilder.Entity<PromotionPlan>(entity =>
            {
                entity.HasKey(e => e.IdPromotionPlan)
                    .HasName("PK_PROMOTIONPLAN");

                entity.HasIndex(e => e.IdDbtableCod)
                    .HasName("Plan_DBTable_FK");

                entity.HasIndex(e => e.IdPlanPackage)
                    .HasName("Plan_PlanPckage_FK");

                entity.HasIndex(e => e.IdProvider)
                    .HasName("Plan_Provider_FK");

                entity.Property(e => e.IdPromotionPlan).HasColumnName("ID_PromotionPlan");

                entity.Property(e => e.DateChanged).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.FkEntityId).HasColumnName("FK_EntityID");

                entity.Property(e => e.IdDbtableCod).HasColumnName("ID_DBTableCOD");

                entity.Property(e => e.IdPlanPackage).HasColumnName("ID_PlanPackage");

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.ValidFrom).HasColumnType("datetime");

                entity.Property(e => e.ValidTo).HasColumnType("datetime");

                entity.HasOne(d => d.IdDbtableCodNavigation)
                    .WithMany(p => p.PromotionPlan)
                    .HasForeignKey(d => d.IdDbtableCod)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PROMOTIO_PLAN_DBTA_COD_DBTA");

                entity.HasOne(d => d.IdPlanPackageNavigation)
                    .WithMany(p => p.PromotionPlan)
                    .HasForeignKey(d => d.IdPlanPackage)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PROMOTIO_PLAN_PLAN_PLANPACK");

                entity.HasOne(d => d.IdProviderNavigation)
                    .WithMany(p => p.PromotionPlan)
                    .HasForeignKey(d => d.IdProvider)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PROMOTIO_PLAN_PROV_PROVIDER");
            });

            modelBuilder.Entity<Provider>(entity =>
            {
                entity.HasKey(e => e.IdProvider)
                    .HasName("PK_PROVIDER");

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.DateChanged).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.Name).HasColumnType("text");

                entity.Property(e => e.Rating).HasColumnType("decimal");

                entity.Property(e => e.TransactionAccountNumber).HasColumnType("text");

                entity.Property(e => e.Vatnumber)
                    .HasColumnName("VATNumber")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<ProviderImg>(entity =>
            {
                entity.HasKey(e => e.IdProviderImg)
                    .HasName("PK_PROVIDERIMG");

                entity.ToTable("ProviderIMG");

                entity.HasIndex(e => e.IdProvider)
                    .HasName("ProviderIMG_FK");

                entity.Property(e => e.IdProviderImg).HasColumnName("ID_ProviderIMG");

                entity.Property(e => e.DateChanged).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.ImageUrl)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.IsLogo).HasColumnName("IS_Logo");

                entity.HasOne(d => d.IdProviderNavigation)
                    .WithMany(p => p.ProviderImg)
                    .HasForeignKey(d => d.IdProvider)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PROVIDER_PROVIDERI_PROVIDER");
            });

            modelBuilder.Entity<ProviderTr>(entity =>
            {
                entity.HasKey(e => e.IdProviderTr)
                    .HasName("PK_PROVIDERTR");

                entity.ToTable("ProviderTR");

                entity.HasIndex(e => e.IdLanguageCod)
                    .HasName("ProviderTRLang_FK");

                entity.HasIndex(e => e.IdProvider)
                    .HasName("ProviderTR_FK");

                entity.Property(e => e.IdProviderTr).HasColumnName("ID_ProviderTR");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.IdLanguageCod).HasColumnName("ID_LanguageCOD");

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.HasOne(d => d.IdLanguageCodNavigation)
                    .WithMany(p => p.ProviderTr)
                    .HasForeignKey(d => d.IdLanguageCod)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PROVIDER_PROVIDERT_COD_LANG");

                entity.HasOne(d => d.IdProviderNavigation)
                    .WithMany(p => p.ProviderTr)
                    .HasForeignKey(d => d.IdProvider)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PROVIDER_PROVIDERT_PROVIDER");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.IdRole)
                    .HasName("PK_ROLE");

                entity.Property(e => e.IdRole).HasColumnName("ID_Role");

                entity.Property(e => e.Name).HasColumnType("text");
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.HasKey(e => e.IdService)
                    .HasName("PK_SERVICE");

                entity.HasIndex(e => e.IdPackage)
                    .HasName("Service_Package_FK");

                entity.HasIndex(e => e.IdServiceCod)
                    .HasName("COD_Service_Service_FK");

                entity.Property(e => e.IdService).HasColumnName("ID_Service");

                entity.Property(e => e.DateChanged).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.IdPackage).HasColumnName("ID_Package");

                entity.Property(e => e.IdServiceCod).HasColumnName("ID_ServiceCOD");

                entity.HasOne(d => d.IdPackageNavigation)
                    .WithMany(p => p.Service)
                    .HasForeignKey(d => d.IdPackage)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SERVICE_SERVICE_P_PACKAGE");

                entity.HasOne(d => d.IdServiceCodNavigation)
                    .WithMany(p => p.Service)
                    .HasForeignKey(d => d.IdServiceCod)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SERVICE_COD_SERVI_COD_SERV");
            });

            modelBuilder.Entity<ServiceDescription>(entity =>
            {
                entity.HasKey(e => e.IdServiceDescription)
                    .HasName("PK_SERVICEDESCRIPTION");

                entity.HasIndex(e => e.IdProvider)
                    .HasName("Provider_ServiceDescription_FK");

                entity.HasIndex(e => e.IdServiceCod)
                    .HasName("COD_Service_ServiceDescription_FK");

                entity.Property(e => e.IdServiceDescription).HasColumnName("ID_ServiceDescription");

                entity.Property(e => e.DateChanged).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.IdServiceCod).HasColumnName("ID_ServiceCOD");

                entity.HasOne(d => d.IdProviderNavigation)
                    .WithMany(p => p.ServiceDescription)
                    .HasForeignKey(d => d.IdProvider)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SERVICED_PROVIDER__PROVIDER");

                entity.HasOne(d => d.IdServiceCodNavigation)
                    .WithMany(p => p.ServiceDescription)
                    .HasForeignKey(d => d.IdServiceCod)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SERVICED_COD_SERVI_COD_SERV");
            });

            modelBuilder.Entity<ServiceDescriptionImg>(entity =>
            {
                entity.HasKey(e => e.IdServiceDescriptionImg)
                    .HasName("PK_SERVICEDESCRIPTIONIMG");

                entity.ToTable("ServiceDescriptionIMG");

                entity.HasIndex(e => e.IdServiceDescription)
                    .HasName("ServiceDescriptionIMG_FK");

                entity.Property(e => e.IdServiceDescriptionImg).HasColumnName("ID_ServiceDescriptionIMG");

                entity.Property(e => e.DateChanged).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.IdServiceDescription).HasColumnName("ID_ServiceDescription");

                entity.Property(e => e.ImageUrl)
                    .IsRequired()
                    .HasColumnType("text");

                entity.HasOne(d => d.IdServiceDescriptionNavigation)
                    .WithMany(p => p.ServiceDescriptionImg)
                    .HasForeignKey(d => d.IdServiceDescription)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SERVICED_SERVICEDE_SERVICED");
            });

            modelBuilder.Entity<ServiceDescriptionTr>(entity =>
            {
                entity.HasKey(e => e.IdServiceDescriptionTr)
                    .HasName("PK_SERVICEDESCRIPTIONTR");

                entity.ToTable("ServiceDescriptionTR");

                entity.HasIndex(e => e.IdLanguageCod)
                    .HasName("ServiceDescriptionTRLang_FK");

                entity.HasIndex(e => e.IdServiceDescription)
                    .HasName("ServiceDescriptionTR_FK");

                entity.Property(e => e.IdServiceDescriptionTr).HasColumnName("ID_ServiceDescriptionTR");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.IdLanguageCod).HasColumnName("ID_LanguageCOD");

                entity.Property(e => e.IdServiceDescription).HasColumnName("ID_ServiceDescription");

                entity.HasOne(d => d.IdLanguageCodNavigation)
                    .WithMany(p => p.ServiceDescriptionTr)
                    .HasForeignKey(d => d.IdLanguageCod)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SERVICED_SERVICEDE_COD_LANG");

                entity.HasOne(d => d.IdServiceDescriptionNavigation)
                    .WithMany(p => p.ServiceDescriptionTr)
                    .HasForeignKey(d => d.IdServiceDescription)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SERVICED_SERVICEDE_SERVICED1");
            });

            modelBuilder.Entity<ServiceTr>(entity =>
            {
                entity.HasKey(e => e.IdServiceTr)
                    .HasName("PK_SERVICETR");

                entity.ToTable("ServiceTR");

                entity.HasIndex(e => e.IdLanguageCod)
                    .HasName("Relationship_22_FK");

                entity.HasIndex(e => e.IdService)
                    .HasName("ServiceTR_FK");

                entity.Property(e => e.IdServiceTr).HasColumnName("ID_ServiceTR");

                entity.Property(e => e.IdLanguageCod).HasColumnName("ID_LanguageCOD");

                entity.Property(e => e.IdService).HasColumnName("ID_Service");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnType("text");

                entity.HasOne(d => d.IdLanguageCodNavigation)
                    .WithMany(p => p.ServiceTr)
                    .HasForeignKey(d => d.IdLanguageCod)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SERVICET_RELATIONS_COD_LANG");

                entity.HasOne(d => d.IdServiceNavigation)
                    .WithMany(p => p.ServiceTr)
                    .HasForeignKey(d => d.IdService)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SERVICET_SERVICETR_SERVICE");
            });

            modelBuilder.Entity<SocialNetwork>(entity =>
            {
                entity.HasKey(e => e.IdSocialNetwork)
                    .HasName("PK_SOCIALNETWORK");

                entity.HasIndex(e => e.IdProvider)
                    .HasName("SocialNetwork_Provider_FK");

                entity.HasIndex(e => e.IdSocialNetworkCod)
                    .HasName("COD_SocialNetwork_SocialNEtwork_FK");

                entity.Property(e => e.IdSocialNetwork).HasColumnName("ID_SocialNetwork");

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.IdSocialNetworkCod).HasColumnName("ID_SocialNetworkCOD");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("UserID")
                    .HasColumnType("text");

                entity.HasOne(d => d.IdProviderNavigation)
                    .WithMany(p => p.SocialNetwork)
                    .HasForeignKey(d => d.IdProvider)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SOCIALNE_SOCIALNET_PROVIDER");

                entity.HasOne(d => d.IdSocialNetworkCodNavigation)
                    .WithMany(p => p.SocialNetwork)
                    .HasForeignKey(d => d.IdSocialNetworkCod)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SOCIALNE_COD_SOCIA_COD_SOCI");
            });

            modelBuilder.Entity<WorkingTime>(entity =>
            {
                entity.HasKey(e => e.IdWorkingTime)
                    .HasName("PK_WORKINGTIME");

                entity.HasIndex(e => e.IdDayCod)
                    .HasName("WorkingTime_Day_FK");

                entity.HasIndex(e => e.IdOffice)
                    .HasName("Office_WorkingTime_FK");

                entity.Property(e => e.IdWorkingTime).HasColumnName("ID_WorkingTime");

                entity.Property(e => e.DateChanged).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.From).HasColumnType("datetime");

                entity.Property(e => e.IdDayCod).HasColumnName("ID_DayCOD");

                entity.Property(e => e.IdOffice).HasColumnName("ID_Office");

                entity.Property(e => e.To).HasColumnType("datetime");

                entity.Property(e => e.ValidFrom).HasColumnType("datetime");

                entity.Property(e => e.ValidTo).HasColumnType("datetime");

                entity.HasOne(d => d.IdDayCodNavigation)
                    .WithMany(p => p.WorkingTime)
                    .HasForeignKey(d => d.IdDayCod)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_WORKINGT_WORKINGTI_COD_DAY");

                entity.HasOne(d => d.IdOfficeNavigation)
                    .WithMany(p => p.WorkingTime)
                    .HasForeignKey(d => d.IdOffice)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_WORKINGT_OFFICE_WO_OFFICE");
            });
        }
    }
}