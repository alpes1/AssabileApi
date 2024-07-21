using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AssabileApi.Models;

public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Asset> Assets { get; set; }

    public virtual DbSet<AssetAttribute> AssetAttributes { get; set; }

    public virtual DbSet<Assetconfiguration> Assetconfigurations { get; set; }

    public virtual DbSet<Backgroundimage> Backgroundimages { get; set; }

    public virtual DbSet<Bank> Banks { get; set; }

    public virtual DbSet<Branch> Branches { get; set; }

    public virtual DbSet<CompanyProductsalesgroup> CompanyProductsalesgroups { get; set; }

    public virtual DbSet<Contact> Contacts { get; set; }

    public virtual DbSet<Contract> Contracts { get; set; }

    public virtual DbSet<Database> Databases { get; set; }

    public virtual DbSet<Dbtable> Dbtables { get; set; }

    public virtual DbSet<Geoarea> Geoareas { get; set; }

    public virtual DbSet<Geoobject> Geoobjects { get; set; }

    public virtual DbSet<GeoobjectBorder> GeoobjectBorders { get; set; }

    public virtual DbSet<Geoplan> Geoplans { get; set; }

    public virtual DbSet<GeoplanBackgroundimage> GeoplanBackgroundimages { get; set; }

    public virtual DbSet<GeoplanGeoobject> GeoplanGeoobjects { get; set; }

    public virtual DbSet<Installation> Installations { get; set; }

    public virtual DbSet<Itinerary> Itineraries { get; set; }

    public virtual DbSet<ItineraryLine> ItineraryLines { get; set; }

    public virtual DbSet<Language> Languages { get; set; }

    public virtual DbSet<LanguageTablefieldattribute> LanguageTablefieldattributes { get; set; }

    public virtual DbSet<Partner> Partners { get; set; }

    public virtual DbSet<Partnercategory> Partnercategories { get; set; }

    public virtual DbSet<Partnercategorytype> Partnercategorytypes { get; set; }

    public virtual DbSet<Partneridtype> Partneridtypes { get; set; }

    public virtual DbSet<Partnerstatus> Partnerstatuses { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<Paymentterm> Paymentterms { get; set; }

    public virtual DbSet<Person> People { get; set; }

    public virtual DbSet<PositionGp> PositionGps { get; set; }

    public virtual DbSet<PrmAssabilfunction> PrmAssabilfunctions { get; set; }

    public virtual DbSet<PrmReadingorderresult> PrmReadingorderresults { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Productcategory> Productcategories { get; set; }

    public virtual DbSet<ProductcategoryAttribute> ProductcategoryAttributes { get; set; }

    public virtual DbSet<ProductcategoryAttributeLov> ProductcategoryAttributeLovs { get; set; }

    public virtual DbSet<Productcategorytype> Productcategorytypes { get; set; }

    public virtual DbSet<Productsalesgroup> Productsalesgroups { get; set; }

    public virtual DbSet<Profile> Profiles { get; set; }

    public virtual DbSet<ProfileTableattribute> ProfileTableattributes { get; set; }

    public virtual DbSet<ProfileTablefieldattribute> ProfileTablefieldattributes { get; set; }

    public virtual DbSet<Readingorder> Readingorders { get; set; }

    public virtual DbSet<Readingorderresultnote> Readingorderresultnotes { get; set; }

    public virtual DbSet<Reclamation> Reclamations { get; set; }

    public virtual DbSet<Round> Rounds { get; set; }

    public virtual DbSet<SapReadingOrder> SapReadingOrders { get; set; }

    public virtual DbSet<Sinvoice> Sinvoices { get; set; }

    public virtual DbSet<SinvoiceLine> SinvoiceLines { get; set; }

    public virtual DbSet<TmpPayment> TmpPayments { get; set; }

    public virtual DbSet<TmpPerformance> TmpPerformances { get; set; }

    public virtual DbSet<TmpSituationperformance> TmpSituationperformances { get; set; }

    public virtual DbSet<Tokenserie> Tokenseries { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Workorderbatch> Workorderbatches { get; set; }

    public virtual DbSet<Worksite> Worksites { get; set; }

    public virtual DbSet<Workstation> Workstations { get; set; }

    public virtual DbSet<WorkstationItinerary> WorkstationItineraries { get; set; }

    public virtual DbSet<WorkstationTokenserie> WorkstationTokenseries { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=ALPES\\SQLEXPRESS; Database=ASSABILONE; Integrated Security=True; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("French_CI_AS");

        modelBuilder.Entity<Asset>(entity =>
        {
            entity.HasKey(e => e.AssetCode);

            entity.ToTable("ASSET");

            entity.Property(e => e.AssetCode)
                .HasMaxLength(30)
                .HasColumnName("ASSET_CODE");
            entity.Property(e => e.AccountCode)
                .HasMaxLength(30)
                .HasColumnName("ACCOUNT_CODE");
            entity.Property(e => e.Aquisitionmode)
                .HasMaxLength(30)
                .HasColumnName("AQUISITIONMODE");
            entity.Property(e => e.AssetstatusCode)
                .HasMaxLength(30)
                .HasColumnName("ASSETSTATUS_CODE");
            entity.Property(e => e.Barcode)
                .HasMaxLength(30)
                .HasColumnName("BARCODE");
            entity.Property(e => e.Closed).HasColumnName("CLOSED");
            entity.Property(e => e.CodeAgence)
                .HasMaxLength(50)
                .HasColumnName("CODE_AGENCE");
            entity.Property(e => e.CostcenterCode)
                .HasMaxLength(30)
                .HasColumnName("COSTCENTER_CODE");
            entity.Property(e => e.Dprbase)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DPRBASE");
            entity.Property(e => e.Dprmodeid)
                .HasMaxLength(30)
                .HasColumnName("DPRMODEID");
            entity.Property(e => e.Dprstartdate)
                .HasColumnType("datetime")
                .HasColumnName("DPRSTARTDATE");
            entity.Property(e => e.Garantiecondition)
                .HasMaxLength(60)
                .HasColumnName("GARANTIECONDITION");
            entity.Property(e => e.GarantiecontactCode)
                .HasMaxLength(30)
                .HasColumnName("GARANTIECONTACT_CODE");
            entity.Property(e => e.Garantieenddate)
                .HasColumnType("datetime")
                .HasColumnName("GARANTIEENDDATE");
            entity.Property(e => e.GarantiepartnerCode)
                .HasMaxLength(30)
                .HasColumnName("GARANTIEPARTNER_CODE");
            entity.Property(e => e.Initialvalue)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("INITIALVALUE");
            entity.Property(e => e.Installationdate)
                .HasColumnType("datetime")
                .HasColumnName("INSTALLATIONDATE");
            entity.Property(e => e.Lastupdate)
                .HasColumnType("datetime")
                .HasColumnName("LASTUPDATE");
            entity.Property(e => e.MangementworkstationCode)
                .HasMaxLength(30)
                .HasColumnName("MANGEMENTWORKSTATION_CODE");
            entity.Property(e => e.Name)
                .HasMaxLength(60)
                .HasColumnName("NAME");
            entity.Property(e => e.Notes)
                .HasMaxLength(256)
                .HasColumnName("NOTES");
            entity.Property(e => e.PdelnoteCode)
                .HasMaxLength(30)
                .HasColumnName("PDELNOTE_CODE");
            entity.Property(e => e.PorderCode)
                .HasMaxLength(30)
                .HasColumnName("PORDER_CODE");
            entity.Property(e => e.ProductCode)
                .HasMaxLength(30)
                .HasColumnName("PRODUCT_CODE");
            entity.Property(e => e.Purchasedate)
                .HasColumnType("datetime")
                .HasColumnName("PURCHASEDATE");
            entity.Property(e => e.SdelnoteCode)
                .HasMaxLength(30)
                .HasColumnName("SDELNOTE_CODE");
            entity.Property(e => e.Securitylevel).HasColumnName("SECURITYLEVEL");
            entity.Property(e => e.Serialnumber)
                .HasMaxLength(60)
                .HasColumnName("SERIALNUMBER");
            entity.Property(e => e.UpassetCode)
                .HasMaxLength(30)
                .HasColumnName("UPASSET_CODE");
            entity.Property(e => e.UserCode)
                .HasMaxLength(30)
                .HasColumnName("USER_CODE");
            entity.Property(e => e.Userfield1)
                .HasMaxLength(60)
                .HasColumnName("USERFIELD1");
            entity.Property(e => e.Userfield2)
                .HasMaxLength(30)
                .HasColumnName("USERFIELD2");
            entity.Property(e => e.WorksiteCode)
                .HasMaxLength(30)
                .HasColumnName("WORKSITE_CODE");
            entity.Property(e => e.WorkstationCode)
                .HasMaxLength(30)
                .HasColumnName("WORKSTATION_CODE");

            entity.HasOne(d => d.MangementworkstationCodeNavigation).WithMany(p => p.AssetMangementworkstationCodeNavigations)
                .HasForeignKey(d => d.MangementworkstationCode)
                .HasConstraintName("FK_ASSET_WORKSTATION1");

            entity.HasOne(d => d.ProductCodeNavigation).WithMany(p => p.Assets)
                .HasForeignKey(d => d.ProductCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ASSET_PRODUCT");

            entity.HasOne(d => d.UpassetCodeNavigation).WithMany(p => p.InverseUpassetCodeNavigation)
                .HasForeignKey(d => d.UpassetCode)
                .HasConstraintName("FK_ASSET_ASSET");

            entity.HasOne(d => d.WorksiteCodeNavigation).WithMany(p => p.Assets)
                .HasForeignKey(d => d.WorksiteCode)
                .HasConstraintName("FK_ASSET_WORKSITE");

            entity.HasOne(d => d.WorkstationCodeNavigation).WithMany(p => p.AssetWorkstationCodeNavigations)
                .HasForeignKey(d => d.WorkstationCode)
                .HasConstraintName("FK_ASSET_WORKSTATION");
        });

        modelBuilder.Entity<AssetAttribute>(entity =>
        {
            entity.HasKey(e => new { e.AssetCode, e.AttributeCode });

            entity.ToTable("ASSET_ATTRIBUTE");

            entity.Property(e => e.AssetCode)
                .HasMaxLength(30)
                .HasColumnName("ASSET_CODE");
            entity.Property(e => e.AttributeCode)
                .HasMaxLength(50)
                .HasColumnName("ATTRIBUTE_CODE");
            entity.Property(e => e.Attributedatevalue)
                .HasColumnType("datetime")
                .HasColumnName("ATTRIBUTEDATEVALUE");
            entity.Property(e => e.Attributenumerictvalue)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("ATTRIBUTENUMERICTVALUE");
            entity.Property(e => e.Attributetextvalue)
                .HasMaxLength(50)
                .HasColumnName("ATTRIBUTETEXTVALUE");
            entity.Property(e => e.CodeAgence)
                .HasMaxLength(50)
                .HasColumnName("CODE_AGENCE");
            entity.Property(e => e.Lastupdate)
                .HasColumnType("datetime")
                .HasColumnName("LASTUPDATE");

            entity.HasOne(d => d.AssetCodeNavigation).WithMany(p => p.AssetAttributes)
                .HasForeignKey(d => d.AssetCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ASSET_ATTRIBUTE_ASSET");
        });

        modelBuilder.Entity<Assetconfiguration>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ASSETCONFIGURATION");

            entity.Property(e => e.CodeAgence)
                .HasMaxLength(50)
                .HasColumnName("CODE_AGENCE");
            entity.Property(e => e.RdaInternetUrl).HasMaxLength(60);
            entity.Property(e => e.RemoteDatabaseName).HasMaxLength(60);
            entity.Property(e => e.RemoteInstanceName).HasMaxLength(60);
        });

        modelBuilder.Entity<Backgroundimage>(entity =>
        {
            entity.HasKey(e => e.BackgroundimageCode).HasName("PK_OBJECTPICTURE");

            entity.ToTable("BACKGROUNDIMAGE");

            entity.Property(e => e.BackgroundimageCode)
                .HasMaxLength(30)
                .HasColumnName("BACKGROUNDIMAGE_CODE");
            entity.Property(e => e.Backgroundimage1)
                .HasColumnType("image")
                .HasColumnName("BACKGROUNDIMAGE");
            entity.Property(e => e.BottomrightX).HasColumnName("BOTTOMRIGHT_X");
            entity.Property(e => e.BottomrightY).HasColumnName("BOTTOMRIGHT_Y");
            entity.Property(e => e.Name)
                .HasMaxLength(60)
                .HasColumnName("NAME");
            entity.Property(e => e.Notes)
                .HasColumnType("ntext")
                .HasColumnName("NOTES");
            entity.Property(e => e.TopleftX).HasColumnName("TOPLEFT_X");
            entity.Property(e => e.TopleftY).HasColumnName("TOPLEFT_Y");
            entity.Property(e => e.TransparencycolorCoe)
                .HasMaxLength(30)
                .HasColumnName("TRANSPARENCYCOLOR_COE");
        });

        modelBuilder.Entity<Bank>(entity =>
        {
            entity.HasKey(e => e.BankCode);

            entity.ToTable("BANK");

            entity.Property(e => e.BankCode)
                .HasMaxLength(30)
                .HasColumnName("BANK_CODE");
            entity.Property(e => e.CodeAgence)
                .HasMaxLength(50)
                .HasColumnName("CODE_AGENCE");
            entity.Property(e => e.Name)
                .HasMaxLength(60)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<Branch>(entity =>
        {
            entity.HasKey(e => e.BranchCode).HasName("PK_COMPANY_1");

            entity.ToTable("BRANCH");

            entity.Property(e => e.BranchCode)
                .HasMaxLength(30)
                .HasColumnName("BRANCH_CODE");
            entity.Property(e => e.CodeAgence)
                .HasMaxLength(50)
                .HasColumnName("CODE_AGENCE");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<CompanyProductsalesgroup>(entity =>
        {
            entity.HasKey(e => new { e.BranchCode, e.ProductsalesgroupCode }).HasName("PK_COMPANY");

            entity.ToTable("COMPANY_PRODUCTSALESGROUP");

            entity.Property(e => e.BranchCode)
                .HasMaxLength(30)
                .HasColumnName("BRANCH_CODE");
            entity.Property(e => e.ProductsalesgroupCode)
                .HasMaxLength(30)
                .HasColumnName("PRODUCTSALESGROUP_CODE");
            entity.Property(e => e.CodeAgence)
                .HasMaxLength(50)
                .HasColumnName("CODE_AGENCE");
            entity.Property(e => e.Footer1)
                .HasMaxLength(60)
                .HasColumnName("FOOTER1");
            entity.Property(e => e.Footer2)
                .HasMaxLength(60)
                .HasColumnName("FOOTER2");
            entity.Property(e => e.Footer3)
                .HasMaxLength(60)
                .HasColumnName("FOOTER3");
            entity.Property(e => e.Footer4)
                .HasMaxLength(60)
                .HasColumnName("FOOTER4");
            entity.Property(e => e.Footer5)
                .HasMaxLength(60)
                .HasColumnName("FOOTER5");
            entity.Property(e => e.Footer6)
                .HasMaxLength(60)
                .HasColumnName("FOOTER6");
            entity.Property(e => e.Header1)
                .HasMaxLength(60)
                .HasColumnName("HEADER1");
            entity.Property(e => e.Header2)
                .HasMaxLength(60)
                .HasColumnName("HEADER2");
            entity.Property(e => e.Header3)
                .HasMaxLength(60)
                .HasColumnName("HEADER3");
            entity.Property(e => e.Header4)
                .HasMaxLength(60)
                .HasColumnName("HEADER4");
            entity.Property(e => e.Header5)
                .HasMaxLength(60)
                .HasColumnName("HEADER5");
            entity.Property(e => e.Header6)
                .HasMaxLength(60)
                .HasColumnName("HEADER6");

            entity.HasOne(d => d.BranchCodeNavigation).WithMany(p => p.CompanyProductsalesgroups)
                .HasForeignKey(d => d.BranchCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_COMPANY_PRODUCTSALESGROUP_COMPANY");

            entity.HasOne(d => d.ProductsalesgroupCodeNavigation).WithMany(p => p.CompanyProductsalesgroups)
                .HasForeignKey(d => d.ProductsalesgroupCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_COMPANY_PRODUCTSALESGROUP_PRODUCTSALESGROUP");
        });

        modelBuilder.Entity<Contact>(entity =>
        {
            entity.HasKey(e => e.ContactCode);

            entity.ToTable("CONTACT");

            entity.Property(e => e.ContactCode)
                .HasMaxLength(30)
                .HasColumnName("CONTACT_CODE");
            entity.Property(e => e.Address)
                .HasMaxLength(256)
                .HasColumnName("ADDRESS");
            entity.Property(e => e.Assistantname)
                .HasMaxLength(30)
                .HasColumnName("ASSISTANTNAME");
            entity.Property(e => e.Assistantphone)
                .HasMaxLength(30)
                .HasColumnName("ASSISTANTPHONE");
            entity.Property(e => e.Cellularphone)
                .HasMaxLength(30)
                .HasColumnName("CELLULARPHONE");
            entity.Property(e => e.City)
                .HasMaxLength(30)
                .HasColumnName("CITY");
            entity.Property(e => e.CodeAgence)
                .HasMaxLength(50)
                .HasColumnName("CODE_AGENCE");
            entity.Property(e => e.ContactcategoryCode)
                .HasMaxLength(30)
                .HasColumnName("CONTACTCATEGORY_CODE");
            entity.Property(e => e.ContacttypeCode)
                .HasMaxLength(30)
                .HasColumnName("CONTACTTYPE_CODE");
            entity.Property(e => e.Country)
                .HasMaxLength(30)
                .HasColumnName("COUNTRY");
            entity.Property(e => e.Email)
                .HasMaxLength(60)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Fax)
                .HasMaxLength(30)
                .HasColumnName("FAX");
            entity.Property(e => e.Firstname)
                .HasMaxLength(60)
                .HasColumnName("FIRSTNAME");
            entity.Property(e => e.JobtitleCode)
                .HasMaxLength(30)
                .HasColumnName("JOBTITLE_CODE");
            entity.Property(e => e.Lastupdate)
                .HasColumnType("datetime")
                .HasColumnName("LASTUPDATE");
            entity.Property(e => e.MrMs)
                .HasMaxLength(5)
                .HasColumnName("MR_MS");
            entity.Property(e => e.Name)
                .HasMaxLength(60)
                .HasColumnName("NAME");
            entity.Property(e => e.Notes)
                .HasMaxLength(256)
                .HasColumnName("NOTES");
            entity.Property(e => e.PartnerCode)
                .HasMaxLength(30)
                .HasColumnName("PARTNER_CODE");
            entity.Property(e => e.PartnerDepartmentCode)
                .HasMaxLength(30)
                .HasColumnName("PARTNER_DEPARTMENT_CODE");
            entity.Property(e => e.PersonCode)
                .HasMaxLength(30)
                .HasColumnName("PERSON_CODE");
            entity.Property(e => e.Personalphone)
                .HasMaxLength(30)
                .HasColumnName("PERSONALPHONE");
            entity.Property(e => e.Phone)
                .HasMaxLength(30)
                .HasColumnName("PHONE");
            entity.Property(e => e.Securitylevel).HasColumnName("SECURITYLEVEL");
            entity.Property(e => e.Specificaddress).HasColumnName("SPECIFICADDRESS");
            entity.Property(e => e.State)
                .HasMaxLength(30)
                .HasColumnName("STATE");
            entity.Property(e => e.UserCode)
                .HasMaxLength(30)
                .HasColumnName("USER_CODE");
            entity.Property(e => e.Userfield1)
                .HasMaxLength(60)
                .HasColumnName("USERFIELD1");
            entity.Property(e => e.Userfield2)
                .HasMaxLength(60)
                .HasColumnName("USERFIELD2");
            entity.Property(e => e.Zipcode)
                .HasMaxLength(30)
                .HasColumnName("ZIPCODE");

            entity.HasOne(d => d.PartnerCodeNavigation).WithMany(p => p.Contacts)
                .HasForeignKey(d => d.PartnerCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CONTACT_PARTNER");
        });

        modelBuilder.Entity<Contract>(entity =>
        {
            entity.HasKey(e => e.ContractCode);

            entity.ToTable("CONTRACT");

            entity.Property(e => e.ContractCode)
                .HasMaxLength(30)
                .HasColumnName("CONTRACT_CODE");
            entity.Property(e => e.CodeAgence)
                .HasMaxLength(50)
                .HasColumnName("CODE_AGENCE");
            entity.Property(e => e.ContactCode)
                .HasMaxLength(30)
                .HasColumnName("CONTACT_CODE");
            entity.Property(e => e.ContractcategoryCode)
                .HasMaxLength(30)
                .HasColumnName("CONTRACTCATEGORY_CODE");
            entity.Property(e => e.ContractcategorytypeCode)
                .HasMaxLength(30)
                .HasColumnName("CONTRACTCATEGORYTYPE_CODE");
            entity.Property(e => e.Documentname)
                .HasMaxLength(60)
                .HasColumnName("DOCUMENTNAME");
            entity.Property(e => e.Enddate)
                .HasColumnType("datetime")
                .HasColumnName("ENDDATE");
            entity.Property(e => e.Externalreference1)
                .HasMaxLength(60)
                .HasColumnName("EXTERNALREFERENCE1");
            entity.Property(e => e.Externalreference2)
                .HasMaxLength(60)
                .HasColumnName("EXTERNALREFERENCE2");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("NAME");
            entity.Property(e => e.PartnerCode)
                .HasMaxLength(30)
                .HasColumnName("PARTNER_CODE");
            entity.Property(e => e.Startdate)
                .HasColumnType("datetime")
                .HasColumnName("STARTDATE");
            entity.Property(e => e.WorkstationCode)
                .HasMaxLength(30)
                .HasColumnName("WORKSTATION_CODE");

            entity.HasOne(d => d.PartnerCodeNavigation).WithMany(p => p.Contracts)
                .HasForeignKey(d => d.PartnerCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CONTRACT_PARTNER");
        });

        modelBuilder.Entity<Database>(entity =>
        {
            entity.HasKey(e => e.DatabaseCode);

            entity.ToTable("DATABASE");

            entity.Property(e => e.DatabaseCode)
                .HasMaxLength(30)
                .HasColumnName("DATABASE_CODE");
            entity.Property(e => e.CodeAgence)
                .HasMaxLength(50)
                .HasColumnName("CODE_AGENCE");
            entity.Property(e => e.Lastdataupdate)
                .HasColumnType("datetime")
                .HasColumnName("LASTDATAUPDATE");
            entity.Property(e => e.Lasttransferdate)
                .HasColumnType("datetime")
                .HasColumnName("LASTTRANSFERDATE");
            entity.Property(e => e.Name)
                .HasMaxLength(60)
                .HasColumnName("NAME");
            entity.Property(e => e.Selectivedownload).HasColumnName("SELECTIVEDOWNLOAD");
        });

        modelBuilder.Entity<Dbtable>(entity =>
        {
            entity.HasKey(e => e.Tablename);

            entity.ToTable("DBTABLE");

            entity.Property(e => e.Tablename)
                .HasMaxLength(60)
                .HasColumnName("TABLENAME");
            entity.Property(e => e.Name)
                .HasMaxLength(60)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<Geoarea>(entity =>
        {
            entity.HasKey(e => e.GeoareaCode).HasName("PK_LOCATION");

            entity.ToTable("GEOAREA");

            entity.Property(e => e.GeoareaCode)
                .HasMaxLength(30)
                .HasColumnName("GEOAREA_CODE");
            entity.Property(e => e.CodeAgence)
                .HasMaxLength(50)
                .HasColumnName("CODE_AGENCE");
            entity.Property(e => e.GeoobjectCode)
                .HasMaxLength(30)
                .HasColumnName("GEOOBJECT_CODE");
            entity.Property(e => e.Name)
                .HasMaxLength(60)
                .HasColumnName("NAME");
            entity.Property(e => e.Notes)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("NOTES");
            entity.Property(e => e.UpgeoareaCode)
                .HasMaxLength(30)
                .HasColumnName("UPGEOAREA_CODE");
            entity.Property(e => e.Userfield1)
                .HasMaxLength(60)
                .HasColumnName("USERFIELD1");
            entity.Property(e => e.Userfield2)
                .HasMaxLength(60)
                .HasColumnName("USERFIELD2");

            entity.HasOne(d => d.GeoobjectCodeNavigation).WithMany(p => p.Geoareas)
                .HasForeignKey(d => d.GeoobjectCode)
                .HasConstraintName("FK_GEOAREA_GEOOBJECT");

            entity.HasOne(d => d.UpgeoareaCodeNavigation).WithMany(p => p.InverseUpgeoareaCodeNavigation)
                .HasForeignKey(d => d.UpgeoareaCode)
                .HasConstraintName("FK_GEOAREA_GEOAREA");
        });

        modelBuilder.Entity<Geoobject>(entity =>
        {
            entity.HasKey(e => e.GeoobjectCode);

            entity.ToTable("GEOOBJECT");

            entity.Property(e => e.GeoobjectCode)
                .HasMaxLength(30)
                .HasColumnName("GEOOBJECT_CODE");
            entity.Property(e => e.Attribute1)
                .HasMaxLength(30)
                .HasColumnName("ATTRIBUTE1");
            entity.Property(e => e.Attribute2)
                .HasMaxLength(30)
                .HasColumnName("ATTRIBUTE2");
            entity.Property(e => e.Attribute3)
                .HasMaxLength(30)
                .HasColumnName("ATTRIBUTE3");
            entity.Property(e => e.Attribute4)
                .HasMaxLength(30)
                .HasColumnName("ATTRIBUTE4");
            entity.Property(e => e.Attribute5)
                .HasMaxLength(30)
                .HasColumnName("ATTRIBUTE5");
            entity.Property(e => e.BackgroungcolorCode)
                .HasMaxLength(30)
                .HasColumnName("BACKGROUNGCOLOR_CODE");
            entity.Property(e => e.BordercolorCode)
                .HasMaxLength(30)
                .HasColumnName("BORDERCOLOR_CODE");
            entity.Property(e => e.CodeAgence)
                .HasMaxLength(50)
                .HasColumnName("CODE_AGENCE");
            entity.Property(e => e.Geoobjecttype).HasColumnName("GEOOBJECTTYPE");
            entity.Property(e => e.Name)
                .HasMaxLength(60)
                .HasColumnName("NAME");
            entity.Property(e => e.ObjectCode)
                .HasMaxLength(30)
                .HasColumnName("OBJECT_CODE");
        });

        modelBuilder.Entity<GeoobjectBorder>(entity =>
        {
            entity.HasKey(e => new { e.GeoobjectCode, e.Rank }).HasName("PK_GEOAREA_BORDER");

            entity.ToTable("GEOOBJECT_BORDER");

            entity.Property(e => e.GeoobjectCode)
                .HasMaxLength(30)
                .HasColumnName("GEOOBJECT_CODE");
            entity.Property(e => e.Rank).HasColumnName("RANK");

            entity.HasOne(d => d.GeoobjectCodeNavigation).WithMany(p => p.GeoobjectBorders)
                .HasForeignKey(d => d.GeoobjectCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GEOOBJECT_BORDER_GEOOBJECT");
        });

        modelBuilder.Entity<Geoplan>(entity =>
        {
            entity.HasKey(e => e.GeoplanCode).HasName("PK_PLANVIEW");

            entity.ToTable("GEOPLAN");

            entity.Property(e => e.GeoplanCode)
                .HasMaxLength(30)
                .HasColumnName("GEOPLAN_CODE");
            entity.Property(e => e.BackgroundcolorCoe)
                .HasMaxLength(30)
                .HasColumnName("BACKGROUNDCOLOR_COE");
            entity.Property(e => e.BottomrightX).HasColumnName("BOTTOMRIGHT_X");
            entity.Property(e => e.BottomrightY).HasColumnName("BOTTOMRIGHT_Y");
            entity.Property(e => e.CodeAgence)
                .HasMaxLength(50)
                .HasColumnName("CODE_AGENCE");
            entity.Property(e => e.Name)
                .HasMaxLength(60)
                .HasColumnName("NAME");
            entity.Property(e => e.Notes)
                .HasColumnType("ntext")
                .HasColumnName("NOTES");
            entity.Property(e => e.TopleftX).HasColumnName("TOPLEFT_X");
            entity.Property(e => e.TopleftY).HasColumnName("TOPLEFT_Y");
        });

        modelBuilder.Entity<GeoplanBackgroundimage>(entity =>
        {
            entity.HasKey(e => new { e.GeoplanCode, e.BackgroundimageCode });

            entity.ToTable("GEOPLAN_BACKGROUNDIMAGE");

            entity.Property(e => e.GeoplanCode)
                .HasMaxLength(30)
                .HasColumnName("GEOPLAN_CODE");
            entity.Property(e => e.BackgroundimageCode)
                .HasMaxLength(30)
                .HasColumnName("BACKGROUNDIMAGE_CODE");
            entity.Property(e => e.CodeAgence)
                .HasMaxLength(50)
                .HasColumnName("CODE_AGENCE");
            entity.Property(e => e.Isselected)
                .HasDefaultValue(true)
                .HasColumnName("ISSELECTED");

            entity.HasOne(d => d.BackgroundimageCodeNavigation).WithMany(p => p.GeoplanBackgroundimages)
                .HasForeignKey(d => d.BackgroundimageCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GEOPLAN_BACKGROUNDIMAGE_BACKGROUNDIMAGE");

            entity.HasOne(d => d.GeoplanCodeNavigation).WithMany(p => p.GeoplanBackgroundimages)
                .HasForeignKey(d => d.GeoplanCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GEOPLAN_BACKGROUNDIMAGE_GEOPLAN1");
        });

        modelBuilder.Entity<GeoplanGeoobject>(entity =>
        {
            entity.HasKey(e => new { e.GeoplanCode, e.GeoobjectCode });

            entity.ToTable("GEOPLAN_GEOOBJECT");

            entity.Property(e => e.GeoplanCode)
                .HasMaxLength(30)
                .HasColumnName("GEOPLAN_CODE");
            entity.Property(e => e.GeoobjectCode)
                .HasMaxLength(30)
                .HasColumnName("GEOOBJECT_CODE");
            entity.Property(e => e.CodeAgence)
                .HasMaxLength(50)
                .HasColumnName("CODE_AGENCE");
            entity.Property(e => e.Isselected)
                .HasDefaultValue(true)
                .HasColumnName("ISSELECTED");

            entity.HasOne(d => d.GeoobjectCodeNavigation).WithMany(p => p.GeoplanGeoobjects)
                .HasForeignKey(d => d.GeoobjectCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GEOPLAN_GEOOBJECT_GEOOBJECT");

            entity.HasOne(d => d.GeoplanCodeNavigation).WithMany(p => p.GeoplanGeoobjects)
                .HasForeignKey(d => d.GeoplanCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GEOPLAN_GEOOBJECT_GEOPLAN");
        });

        modelBuilder.Entity<Installation>(entity =>
        {
            entity.HasKey(e => e.InstallationCode);

            entity.ToTable("INSTALLATION");

            entity.Property(e => e.InstallationCode)
                .HasMaxLength(30)
                .HasColumnName("INSTALLATION_CODE");
            entity.Property(e => e.AssetCode)
                .HasMaxLength(30)
                .HasColumnName("ASSET_CODE");
            entity.Property(e => e.Closed).HasColumnName("CLOSED");
            entity.Property(e => e.CodeAgence)
                .HasMaxLength(50)
                .HasColumnName("CODE_AGENCE");
            entity.Property(e => e.ContractCode)
                .HasMaxLength(30)
                .HasColumnName("CONTRACT_CODE");
            entity.Property(e => e.InstallationcategoryCode)
                .HasMaxLength(50)
                .HasColumnName("INSTALLATIONCATEGORY_CODE");
            entity.Property(e => e.InstallationcategorytypeCode)
                .HasMaxLength(50)
                .HasColumnName("INSTALLATIONCATEGORYTYPE_CODE");
            entity.Property(e => e.Installationdate)
                .HasColumnType("datetime")
                .HasColumnName("INSTALLATIONDATE");
            entity.Property(e => e.Name)
                .HasMaxLength(60)
                .HasColumnName("NAME");
            entity.Property(e => e.Uninstallationdate)
                .HasColumnType("datetime")
                .HasColumnName("UNINSTALLATIONDATE");
            entity.Property(e => e.WorksiteCode)
                .HasMaxLength(30)
                .HasColumnName("WORKSITE_CODE");

            entity.HasOne(d => d.AssetCodeNavigation).WithMany(p => p.Installations)
                .HasForeignKey(d => d.AssetCode)
                .HasConstraintName("FK_INSTALLATION_ASSET");

            entity.HasOne(d => d.ContractCodeNavigation).WithMany(p => p.Installations)
                .HasForeignKey(d => d.ContractCode)
                .HasConstraintName("FK_INSTALLATION_CONTRACT");

            entity.HasOne(d => d.WorksiteCodeNavigation).WithMany(p => p.Installations)
                .HasForeignKey(d => d.WorksiteCode)
                .HasConstraintName("FK_INSTALLATION_WORKSITE");
        });

        modelBuilder.Entity<Itinerary>(entity =>
        {
            entity.HasKey(e => e.ItineraryCode).HasName("PK_ITINERARY_1");

            entity.ToTable("ITINERARY");

            entity.Property(e => e.ItineraryCode)
                .HasMaxLength(30)
                .HasColumnName("ITINERARY_CODE");
            entity.Property(e => e.CodeAgence)
                .HasMaxLength(50)
                .HasColumnName("CODE_AGENCE");
            entity.Property(e => e.Name)
                .HasMaxLength(60)
                .HasColumnName("NAME");
            entity.Property(e => e.Securitylevel).HasColumnName("SECURITYLEVEL");
        });

        modelBuilder.Entity<ItineraryLine>(entity =>
        {
            entity.HasKey(e => new { e.ItineraryCode, e.WorksiteCode }).HasName("PK_ITINERARY");

            entity.ToTable("ITINERARY_LINE");

            entity.Property(e => e.ItineraryCode)
                .HasMaxLength(30)
                .HasColumnName("ITINERARY_CODE");
            entity.Property(e => e.WorksiteCode)
                .HasMaxLength(30)
                .HasColumnName("WORKSITE_CODE");
            entity.Property(e => e.CodeAgence)
                .HasMaxLength(50)
                .HasColumnName("CODE_AGENCE");
            entity.Property(e => e.Rank).HasColumnName("RANK");

            entity.HasOne(d => d.ItineraryCodeNavigation).WithMany(p => p.ItineraryLines)
                .HasForeignKey(d => d.ItineraryCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ITINERARY_LINE_ITINERARY");

            entity.HasOne(d => d.WorksiteCodeNavigation).WithMany(p => p.ItineraryLines)
                .HasForeignKey(d => d.WorksiteCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ITINERARY_LINE_WORKSITE");
        });

        modelBuilder.Entity<Language>(entity =>
        {
            entity.HasKey(e => e.LanguageCode);

            entity.ToTable("LANGUAGE");

            entity.Property(e => e.LanguageCode)
                .HasMaxLength(30)
                .HasColumnName("LANGUAGE_CODE");
            entity.Property(e => e.Name)
                .HasMaxLength(60)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<LanguageTablefieldattribute>(entity =>
        {
            entity.HasKey(e => new { e.LanguageCode, e.Tablename, e.Fieldname }).HasName("PK_prm_FIELD_LANGUAGE_ATTRIBUTE");

            entity.ToTable("LANGUAGE_TABLEFIELDATTRIBUTE");

            entity.Property(e => e.LanguageCode)
                .HasMaxLength(30)
                .HasColumnName("LANGUAGE_CODE");
            entity.Property(e => e.Tablename)
                .HasMaxLength(60)
                .HasColumnName("TABLENAME");
            entity.Property(e => e.Fieldname)
                .HasMaxLength(60)
                .HasColumnName("FIELDNAME");
            entity.Property(e => e.Fieldhelp)
                .HasMaxLength(140)
                .HasColumnName("FIELDHELP");
            entity.Property(e => e.Fieldlabel)
                .HasMaxLength(30)
                .HasColumnName("FIELDLABEL");

            entity.HasOne(d => d.LanguageCodeNavigation).WithMany(p => p.LanguageTablefieldattributes)
                .HasForeignKey(d => d.LanguageCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LANGUAGE_TABLEFIELDATTRIBUTE_LANGUAGE");
        });

        modelBuilder.Entity<Partner>(entity =>
        {
            entity.HasKey(e => e.PartnerCode);

            entity.ToTable("PARTNER");

            entity.Property(e => e.PartnerCode)
                .HasMaxLength(30)
                .HasColumnName("PARTNER_CODE");
            entity.Property(e => e.Address)
                .HasMaxLength(140)
                .HasColumnName("ADDRESS");
            entity.Property(e => e.Arabicname)
                .HasMaxLength(60)
                .HasColumnName("ARABICNAME");
            entity.Property(e => e.City)
                .HasMaxLength(30)
                .HasColumnName("CITY");
            entity.Property(e => e.CodeAgence)
                .HasMaxLength(50)
                .HasColumnName("CODE_AGENCE");
            entity.Property(e => e.Common).HasColumnName("COMMON");
            entity.Property(e => e.Country)
                .HasMaxLength(30)
                .HasColumnName("COUNTRY");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(30)
                .HasColumnName("CURRENCY_CODE");
            entity.Property(e => e.Currentcredit)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CURRENTCREDIT");
            entity.Property(e => e.Currentcredit2)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CURRENTCREDIT2");
            entity.Property(e => e.Email)
                .HasMaxLength(60)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Fax)
                .HasMaxLength(30)
                .HasColumnName("FAX");
            entity.Property(e => e.Fiscalid)
                .HasMaxLength(60)
                .HasColumnName("FISCALID");
            entity.Property(e => e.FixedtaxExoneration).HasColumnName("FIXEDTAX_EXONERATION");
            entity.Property(e => e.GeoareaCode)
                .HasMaxLength(30)
                .HasColumnName("GEOAREA_CODE");
            entity.Property(e => e.Hold).HasColumnName("HOLD");
            entity.Property(e => e.HoldReason)
                .HasMaxLength(140)
                .HasColumnName("HOLD_REASON");
            entity.Property(e => e.Lastupdate)
                .HasColumnType("datetime")
                .HasColumnName("LASTUPDATE");
            entity.Property(e => e.Maximumcredit)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("MAXIMUMCREDIT");
            entity.Property(e => e.Maximumcredit2)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("MAXIMUMCREDIT2");
            entity.Property(e => e.Name)
                .HasMaxLength(60)
                .HasColumnName("NAME");
            entity.Property(e => e.Name2)
                .HasMaxLength(60)
                .HasColumnName("NAME2");
            entity.Property(e => e.Notes)
                .HasMaxLength(256)
                .HasColumnName("NOTES");
            entity.Property(e => e.Partneranalysisgroup1Code)
                .HasMaxLength(30)
                .HasColumnName("PARTNERANALYSISGROUP1_CODE");
            entity.Property(e => e.Partneranalysisgroup2Code)
                .HasMaxLength(30)
                .HasColumnName("PARTNERANALYSISGROUP2_CODE");
            entity.Property(e => e.Partneranalysisgroup3Code)
                .HasMaxLength(30)
                .HasColumnName("PARTNERANALYSISGROUP3_CODE");
            entity.Property(e => e.Partneranalysisgroup4Code)
                .HasMaxLength(30)
                .HasColumnName("PARTNERANALYSISGROUP4_CODE");
            entity.Property(e => e.Partneranalysisgroup5Code)
                .HasMaxLength(30)
                .HasColumnName("PARTNERANALYSISGROUP5_CODE");
            entity.Property(e => e.PartnercategoryCode)
                .HasMaxLength(30)
                .HasColumnName("PARTNERCATEGORY_CODE");
            entity.Property(e => e.Partnerid)
                .HasMaxLength(140)
                .HasColumnName("PARTNERID");
            entity.Property(e => e.PartneridtypeCode)
                .HasMaxLength(30)
                .HasColumnName("PARTNERIDTYPE_CODE");
            entity.Property(e => e.PartnerstatusCode)
                .HasMaxLength(30)
                .HasColumnName("PARTNERSTATUS_CODE");
            entity.Property(e => e.PartnertypeCode)
                .HasMaxLength(30)
                .HasColumnName("PARTNERTYPE_CODE");
            entity.Property(e => e.PaymenttermCode)
                .HasMaxLength(30)
                .HasColumnName("PAYMENTTERM_CODE");
            entity.Property(e => e.Phone1)
                .HasMaxLength(30)
                .HasColumnName("PHONE1");
            entity.Property(e => e.Phone2)
                .HasMaxLength(30)
                .HasColumnName("PHONE2");
            entity.Property(e => e.Pricelist2Code)
                .HasMaxLength(30)
                .HasColumnName("PRICELIST2_CODE");
            entity.Property(e => e.Pricelist2startdate)
                .HasColumnType("datetime")
                .HasColumnName("PRICELIST2STARTDATE");
            entity.Property(e => e.PricelistCode)
                .HasMaxLength(30)
                .HasColumnName("PRICELIST_CODE");
            entity.Property(e => e.Rank).HasColumnName("RANK");
            entity.Property(e => e.RootpartnerCode)
                .HasMaxLength(30)
                .HasColumnName("ROOTPARTNER_CODE");
            entity.Property(e => e.SaleschannelCode)
                .HasMaxLength(30)
                .HasColumnName("SALESCHANNEL_CODE");
            entity.Property(e => e.Securitylevel).HasColumnName("SECURITYLEVEL");
            entity.Property(e => e.State)
                .HasMaxLength(30)
                .HasColumnName("STATE");
            entity.Property(e => e.UppartnerCode)
                .HasMaxLength(30)
                .HasColumnName("UPPARTNER_CODE");
            entity.Property(e => e.UserCode)
                .HasMaxLength(30)
                .HasColumnName("USER_CODE");
            entity.Property(e => e.Userfield1)
                .HasMaxLength(60)
                .HasColumnName("USERFIELD1");
            entity.Property(e => e.Userfield2)
                .HasMaxLength(60)
                .HasColumnName("USERFIELD2");
            entity.Property(e => e.Vat1Exoneration).HasColumnName("VAT1_EXONERATION");
            entity.Property(e => e.Vat2Exoneration).HasColumnName("VAT2_EXONERATION");
            entity.Property(e => e.Webaddress)
                .HasMaxLength(60)
                .HasColumnName("WEBADDRESS");
            entity.Property(e => e.WorkstationCode)
                .HasMaxLength(30)
                .HasColumnName("WORKSTATION_CODE");
            entity.Property(e => e.Zipcode)
                .HasMaxLength(30)
                .HasColumnName("ZIPCODE");

            entity.HasOne(d => d.PartneridtypeCodeNavigation).WithMany(p => p.Partners)
                .HasForeignKey(d => d.PartneridtypeCode)
                .HasConstraintName("FK_PARTNER_PARTNERIDTYPE");

            entity.HasOne(d => d.PartnerstatusCodeNavigation).WithMany(p => p.Partners)
                .HasForeignKey(d => d.PartnerstatusCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PARTNER_PARTNERSTATUS");

            entity.HasOne(d => d.UppartnerCodeNavigation).WithMany(p => p.InverseUppartnerCodeNavigation)
                .HasForeignKey(d => d.UppartnerCode)
                .HasConstraintName("FK_PARTNER_PARTNER");

            entity.HasOne(d => d.WorkstationCodeNavigation).WithMany(p => p.Partners)
                .HasForeignKey(d => d.WorkstationCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PARTNER_WORKSTATION");

            entity.HasOne(d => d.Partnercategorytype).WithMany(p => p.Partners)
                .HasForeignKey(d => new { d.PartnercategoryCode, d.PartnertypeCode })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PARTNER_PARTNERCATEGORYTYPE");
        });

        modelBuilder.Entity<Partnercategory>(entity =>
        {
            entity.HasKey(e => e.PartnercategoryCode);

            entity.ToTable("PARTNERCATEGORY");

            entity.Property(e => e.PartnercategoryCode)
                .HasMaxLength(30)
                .HasColumnName("PARTNERCATEGORY_CODE");
            entity.Property(e => e.Name)
                .HasMaxLength(60)
                .HasColumnName("NAME");
            entity.Property(e => e.Rank).HasColumnName("RANK");
            entity.Property(e => e.UppartnercategoryCode)
                .HasMaxLength(30)
                .HasColumnName("UPPARTNERCATEGORY_CODE");
        });

        modelBuilder.Entity<Partnercategorytype>(entity =>
        {
            entity.HasKey(e => new { e.PartnercategoryCode, e.PartnercategorytypeCode });

            entity.ToTable("PARTNERCATEGORYTYPE");

            entity.Property(e => e.PartnercategoryCode)
                .HasMaxLength(30)
                .HasColumnName("PARTNERCATEGORY_CODE");
            entity.Property(e => e.PartnercategorytypeCode)
                .HasMaxLength(30)
                .HasColumnName("PARTNERCATEGORYTYPE_CODE");
            entity.Property(e => e.Name)
                .HasMaxLength(60)
                .HasColumnName("NAME");
            entity.Property(e => e.Rank).HasColumnName("RANK");

            entity.HasOne(d => d.PartnercategoryCodeNavigation).WithMany(p => p.Partnercategorytypes)
                .HasForeignKey(d => d.PartnercategoryCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PARTNERCATEGORYTYPE_PARTNERCATEGORY");
        });

        modelBuilder.Entity<Partneridtype>(entity =>
        {
            entity.HasKey(e => e.PartneridtypeCode);

            entity.ToTable("PARTNERIDTYPE");

            entity.Property(e => e.PartneridtypeCode)
                .HasMaxLength(30)
                .HasColumnName("PARTNERIDTYPE_CODE");
            entity.Property(e => e.Name)
                .HasMaxLength(60)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<Partnerstatus>(entity =>
        {
            entity.HasKey(e => e.PartnerstatusCode);

            entity.ToTable("PARTNERSTATUS");

            entity.Property(e => e.PartnerstatusCode)
                .HasMaxLength(30)
                .HasColumnName("PARTNERSTATUS_CODE");
            entity.Property(e => e.Name)
                .HasMaxLength(60)
                .HasColumnName("NAME");
            entity.Property(e => e.Rank).HasColumnName("RANK");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.HasKey(e => e.PaymentCode);

            entity.ToTable("PAYMENT");

            entity.Property(e => e.PaymentCode)
                .HasMaxLength(30)
                .HasColumnName("PAYMENT_CODE");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMOUNT");
            entity.Property(e => e.BankCode)
                .HasMaxLength(30)
                .HasColumnName("BANK_CODE");
            entity.Property(e => e.Bankagency)
                .HasMaxLength(30)
                .HasColumnName("BANKAGENCY");
            entity.Property(e => e.CodeAgence)
                .HasMaxLength(50)
                .HasColumnName("CODE_AGENCE");
            entity.Property(e => e.Locked).HasColumnName("LOCKED");
            entity.Property(e => e.MaturityDate)
                .HasColumnType("datetime")
                .HasColumnName("MATURITY_DATE");
            entity.Property(e => e.PartnerCode)
                .HasMaxLength(30)
                .HasColumnName("PARTNER_CODE");
            entity.Property(e => e.Payerreference)
                .HasMaxLength(140)
                .HasColumnName("PAYERREFERENCE");
            entity.Property(e => e.PaymenttermCode)
                .HasMaxLength(30)
                .HasColumnName("PAYMENTTERM_CODE");
            entity.Property(e => e.PersonCode)
                .HasMaxLength(30)
                .HasColumnName("PERSON_CODE");
            entity.Property(e => e.Printed).HasColumnName("PRINTED");
            entity.Property(e => e.Reference)
                .HasMaxLength(60)
                .HasColumnName("REFERENCE");
            entity.Property(e => e.RoundCode)
                .HasMaxLength(30)
                .HasColumnName("ROUND_CODE");
            entity.Property(e => e.Thedate)
                .HasColumnType("datetime")
                .HasColumnName("THEDATE");
            entity.Property(e => e.VisitCode)
                .HasMaxLength(30)
                .HasColumnName("VISIT_CODE");
        });

        modelBuilder.Entity<Paymentterm>(entity =>
        {
            entity.HasKey(e => e.PaymenttermCode);

            entity.ToTable("PAYMENTTERM");

            entity.Property(e => e.PaymenttermCode)
                .HasMaxLength(30)
                .HasColumnName("PAYMENTTERM_CODE");
            entity.Property(e => e.Discount)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DISCOUNT");
            entity.Property(e => e.Name)
                .HasMaxLength(60)
                .HasColumnName("NAME");
            entity.Property(e => e.Rank).HasColumnName("RANK");
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity.HasKey(e => e.PersonCode);

            entity.ToTable("PERSON");

            entity.Property(e => e.PersonCode)
                .HasMaxLength(30)
                .HasColumnName("PERSON_CODE");
            entity.Property(e => e.Cellularphone)
                .HasMaxLength(30)
                .HasColumnName("CELLULARPHONE");
            entity.Property(e => e.CodeAgence)
                .HasMaxLength(50)
                .HasColumnName("CODE_AGENCE");
            entity.Property(e => e.Email)
                .HasMaxLength(30)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Fax)
                .HasMaxLength(30)
                .HasColumnName("FAX");
            entity.Property(e => e.Firstname)
                .HasMaxLength(60)
                .HasColumnName("FIRSTNAME");
            entity.Property(e => e.Hold).HasColumnName("HOLD");
            entity.Property(e => e.HoldReason)
                .HasMaxLength(140)
                .HasColumnName("HOLD_REASON");
            entity.Property(e => e.LanguageCode)
                .HasMaxLength(20)
                .HasColumnName("LANGUAGE_CODE");
            entity.Property(e => e.Lastupdate)
                .HasColumnType("datetime")
                .HasColumnName("LASTUPDATE");
            entity.Property(e => e.Name)
                .HasMaxLength(60)
                .HasColumnName("NAME");
            entity.Property(e => e.Password)
                .HasMaxLength(10)
                .HasColumnName("PASSWORD");
            entity.Property(e => e.Phone)
                .HasMaxLength(30)
                .HasColumnName("PHONE");
            entity.Property(e => e.ProfileCode)
                .HasMaxLength(30)
                .HasColumnName("PROFILE_CODE");
            entity.Property(e => e.Requiredcontrolnumber).HasColumnName("REQUIREDCONTROLNUMBER");
            entity.Property(e => e.Securitylevel).HasColumnName("SECURITYLEVEL");
            entity.Property(e => e.UserCode)
                .HasMaxLength(30)
                .HasColumnName("USER_CODE");
            entity.Property(e => e.Userfield1)
                .HasMaxLength(60)
                .HasColumnName("USERFIELD1");
            entity.Property(e => e.Userfield2)
                .HasMaxLength(30)
                .HasColumnName("USERFIELD2");

            entity.HasOne(d => d.ProfileCodeNavigation).WithMany(p => p.People)
                .HasForeignKey(d => d.ProfileCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PERSON_PROFILE");
        });

        modelBuilder.Entity<PositionGp>(entity =>
        {
            entity.HasKey(e => new { e.CodeInstallation, e.Readingordercode });

            entity.ToTable("POSITION_GPS");

            entity.Property(e => e.CodeInstallation)
                .HasMaxLength(30)
                .HasColumnName("CODE_INSTALLATION");
            entity.Property(e => e.Readingordercode)
                .HasMaxLength(30)
                .HasColumnName("READINGORDERCODE");
            entity.Property(e => e.Altitude).HasColumnName("ALTITUDE");
            entity.Property(e => e.CodeAgence)
                .HasMaxLength(50)
                .HasColumnName("CODE_AGENCE");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("DATE");
            entity.Property(e => e.Image).HasColumnName("IMAGE");
            entity.Property(e => e.Latitude).HasColumnName("LATITUDE");
            entity.Property(e => e.Longitude).HasColumnName("LONGITUDE");
            entity.Property(e => e.Maricule)
                .HasMaxLength(30)
                .HasColumnName("MARICULE");
            entity.Property(e => e.Telephone)
                .HasMaxLength(30)
                .HasColumnName("TELEPHONE");
        });

        modelBuilder.Entity<PrmAssabilfunction>(entity =>
        {
            entity.HasKey(e => e.AssabilfunctionCode);

            entity.ToTable("prmASSABILFUNCTION");

            entity.Property(e => e.AssabilfunctionCode)
                .HasMaxLength(30)
                .HasColumnName("ASSABILFUNCTION_CODE");
            entity.Property(e => e.Name)
                .HasMaxLength(60)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<PrmReadingorderresult>(entity =>
        {
            entity.HasKey(e => e.ReadingorderresultCode).HasName("PK_READINGORDERRESULT");

            entity.ToTable("prmREADINGORDERRESULT");

            entity.Property(e => e.ReadingorderresultCode)
                .HasMaxLength(30)
                .HasColumnName("READINGORDERRESULT_CODE");
            entity.Property(e => e.Name)
                .HasMaxLength(60)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductCode).HasName("PK_ITEM");

            entity.ToTable("PRODUCT");

            entity.Property(e => e.ProductCode)
                .HasMaxLength(30)
                .HasColumnName("PRODUCT_CODE");
            entity.Property(e => e.AccountCode)
                .HasMaxLength(30)
                .HasColumnName("ACCOUNT_CODE");
            entity.Property(e => e.Apos).HasColumnName("APOS");
            entity.Property(e => e.Awp)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AWP");
            entity.Property(e => e.BrandCode)
                .HasMaxLength(30)
                .HasColumnName("BRAND_CODE");
            entity.Property(e => e.CustomsCode)
                .HasMaxLength(30)
                .HasColumnName("CUSTOMS_CODE");
            entity.Property(e => e.Deliveryleadtime)
                .HasMaxLength(30)
                .HasColumnName("DELIVERYLEADTIME");
            entity.Property(e => e.Emptyproduct).HasColumnName("EMPTYPRODUCT");
            entity.Property(e => e.Equipment).HasColumnName("EQUIPMENT");
            entity.Property(e => e.Expirable).HasColumnName("EXPIRABLE");
            entity.Property(e => e.Facingable).HasColumnName("FACINGABLE");
            entity.Property(e => e.Freegood).HasColumnName("FREEGOOD");
            entity.Property(e => e.Hold).HasColumnName("HOLD");
            entity.Property(e => e.HoldReason)
                .HasMaxLength(60)
                .HasColumnName("HOLD_REASON");
            entity.Property(e => e.Inventoryable).HasColumnName("INVENTORYABLE");
            entity.Property(e => e.Lastupdate)
                .HasColumnType("datetime")
                .HasColumnName("LASTUPDATE");
            entity.Property(e => e.Longdescription)
                .HasMaxLength(256)
                .HasColumnName("LONGDESCRIPTION");
            entity.Property(e => e.ManagementmodeCode)
                .HasMaxLength(5)
                .HasColumnName("MANAGEMENTMODE_CODE");
            entity.Property(e => e.Name)
                .HasMaxLength(60)
                .HasColumnName("NAME");
            entity.Property(e => e.Netpurchaseprice)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("NETPURCHASEPRICE");
            entity.Property(e => e.Netsalesprice)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("NETSALESPRICE");
            entity.Property(e => e.Packing)
                .HasDefaultValue(0)
                .HasColumnName("PACKING");
            entity.Property(e => e.Presencecheckable).HasColumnName("PRESENCECHECKABLE");
            entity.Property(e => e.Productanalysisgroup1Code)
                .HasMaxLength(30)
                .HasColumnName("PRODUCTANALYSISGROUP1_CODE");
            entity.Property(e => e.Productanalysisgroup2Code)
                .HasMaxLength(30)
                .HasColumnName("PRODUCTANALYSISGROUP2_CODE");
            entity.Property(e => e.Productanalysisgroup3Code)
                .HasMaxLength(30)
                .HasColumnName("PRODUCTANALYSISGROUP3_CODE");
            entity.Property(e => e.Productanalysisgroup4Code)
                .HasMaxLength(30)
                .HasColumnName("PRODUCTANALYSISGROUP4_CODE");
            entity.Property(e => e.Productanalysisgroup5Code)
                .HasMaxLength(30)
                .HasColumnName("PRODUCTANALYSISGROUP5_CODE");
            entity.Property(e => e.ProductcategoryCode)
                .HasMaxLength(30)
                .HasColumnName("PRODUCTCATEGORY_CODE");
            entity.Property(e => e.ProductcategorytypeCode)
                .HasMaxLength(30)
                .HasColumnName("PRODUCTCATEGORYTYPE_CODE");
            entity.Property(e => e.ProductgroupCode)
                .HasMaxLength(30)
                .HasColumnName("PRODUCTGROUP_CODE");
            entity.Property(e => e.ProductpageCode)
                .HasMaxLength(30)
                .HasColumnName("PRODUCTPAGE_CODE");
            entity.Property(e => e.ProductsalesgroupCode)
                .HasMaxLength(30)
                .HasColumnName("PRODUCTSALESGROUP_CODE");
            entity.Property(e => e.Promorate)
                .HasDefaultValue(1m)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PROMORATE");
            entity.Property(e => e.Promosequence).HasColumnName("PROMOSEQUENCE");
            entity.Property(e => e.Purchasediscount)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PURCHASEDISCOUNT");
            entity.Property(e => e.Purchaseprice)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PURCHASEPRICE");
            entity.Property(e => e.Rank).HasColumnName("RANK");
            entity.Property(e => e.Returnable).HasColumnName("RETURNABLE");
            entity.Property(e => e.Returnprice)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("RETURNPRICE");
            entity.Property(e => e.Salable).HasColumnName("SALABLE");
            entity.Property(e => e.Salesdiscount)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("SALESDISCOUNT");
            entity.Property(e => e.Salesmargin)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("SALESMARGIN");
            entity.Property(e => e.Salesprice)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("SALESPRICE");
            entity.Property(e => e.Securitylevel).HasColumnName("SECURITYLEVEL");
            entity.Property(e => e.Shipmentcost)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("SHIPMENTCOST");
            entity.Property(e => e.Spacerequirement)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("SPACEREQUIREMENT");
            entity.Property(e => e.Statunitrate)
                .HasDefaultValue(1m)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("STATUNITRATE");
            entity.Property(e => e.Supplierreference)
                .HasMaxLength(30)
                .HasColumnName("SUPPLIERREFERENCE");
            entity.Property(e => e.TheRate)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("THE_RATE");
            entity.Property(e => e.UnitCode)
                .HasMaxLength(5)
                .HasColumnName("UNIT_CODE");
            entity.Property(e => e.UserCode)
                .HasMaxLength(30)
                .HasColumnName("USER_CODE");
            entity.Property(e => e.Userfield1)
                .HasMaxLength(60)
                .HasColumnName("USERFIELD1");
            entity.Property(e => e.Userfield2)
                .HasMaxLength(30)
                .HasColumnName("USERFIELD2");
            entity.Property(e => e.Vat1Code)
                .HasMaxLength(30)
                .HasColumnName("VAT1_CODE");
            entity.Property(e => e.Vat2Code)
                .HasMaxLength(30)
                .HasColumnName("VAT2_CODE");
            entity.Property(e => e.Virtualproduct).HasColumnName("VIRTUALPRODUCT");
            entity.Property(e => e.Volume)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("VOLUME");
            entity.Property(e => e.Weight)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("WEIGHT");

            entity.HasOne(d => d.Productcategorytype).WithMany(p => p.Products)
                .HasForeignKey(d => new { d.ProductpageCode, d.ProductgroupCode })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PRODUCT_PRODUCTCATEGORYTYPE");
        });

        modelBuilder.Entity<Productcategory>(entity =>
        {
            entity.HasKey(e => e.ProductcategoryCode).HasName("PK_ITEMCATEGORY");

            entity.ToTable("PRODUCTCATEGORY");

            entity.Property(e => e.ProductcategoryCode)
                .HasMaxLength(30)
                .HasColumnName("PRODUCTCATEGORY_CODE");
            entity.Property(e => e.Name)
                .HasMaxLength(60)
                .HasColumnName("NAME");
            entity.Property(e => e.Rank).HasColumnName("RANK");
            entity.Property(e => e.UpproductcategoryCode)
                .HasMaxLength(30)
                .HasColumnName("UPPRODUCTCATEGORY_CODE");
        });

        modelBuilder.Entity<ProductcategoryAttribute>(entity =>
        {
            entity.HasKey(e => new { e.ProductcategoryCode, e.AttributeCode }).HasName("PK_ITEMCATEGORY_ATTRIBUTE");

            entity.ToTable("PRODUCTCATEGORY_ATTRIBUTE");

            entity.Property(e => e.ProductcategoryCode)
                .HasMaxLength(30)
                .HasColumnName("PRODUCTCATEGORY_CODE");
            entity.Property(e => e.AttributeCode)
                .HasMaxLength(30)
                .HasColumnName("ATTRIBUTE_CODE");
            entity.Property(e => e.Coefficient)
                .HasDefaultValue(1)
                .HasColumnName("COEFFICIENT");
            entity.Property(e => e.Defaultvalue)
                .HasMaxLength(50)
                .HasColumnName("DEFAULTVALUE");
            entity.Property(e => e.Maximumvalue)
                .HasMaxLength(50)
                .HasColumnName("MAXIMUMVALUE");
            entity.Property(e => e.Minimumvaue)
                .HasMaxLength(50)
                .HasColumnName("MINIMUMVAUE");
            entity.Property(e => e.Name)
                .HasMaxLength(60)
                .HasColumnName("NAME");
            entity.Property(e => e.Storedprocedurename)
                .HasMaxLength(60)
                .HasColumnName("STOREDPROCEDURENAME");

            entity.HasOne(d => d.ProductcategoryCodeNavigation).WithMany(p => p.ProductcategoryAttributes)
                .HasForeignKey(d => d.ProductcategoryCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PRODUCTCATEGORY_ATTRIBUTE_PRODUCTCATEGORY");
        });

        modelBuilder.Entity<ProductcategoryAttributeLov>(entity =>
        {
            entity.HasKey(e => new { e.ProductcategoryCode, e.AttributeCode, e.Attributetextvalue }).HasName("PK_ITEMCATEGORY_ATTRIBUTE_LOV");

            entity.ToTable("PRODUCTCATEGORY_ATTRIBUTE_LOV");

            entity.Property(e => e.ProductcategoryCode)
                .HasMaxLength(30)
                .HasColumnName("PRODUCTCATEGORY_CODE");
            entity.Property(e => e.AttributeCode)
                .HasMaxLength(30)
                .HasColumnName("ATTRIBUTE_CODE");
            entity.Property(e => e.Attributetextvalue)
                .HasMaxLength(30)
                .HasColumnName("ATTRIBUTETEXTVALUE");
            entity.Property(e => e.Attributetextvaluenotation)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("ATTRIBUTETEXTVALUENOTATION");

            entity.HasOne(d => d.ProductcategoryAttribute).WithMany(p => p.ProductcategoryAttributeLovs)
                .HasForeignKey(d => new { d.ProductcategoryCode, d.AttributeCode })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PRODUCTCATEGORY_ATTRIBUTE_LOV_PRODUCTCATEGORY_ATTRIBUTE");
        });

        modelBuilder.Entity<Productcategorytype>(entity =>
        {
            entity.HasKey(e => new { e.ProductcategoryCode, e.ProductcategorytypeCode }).HasName("PK_ITEMCATEGORYTYPE");

            entity.ToTable("PRODUCTCATEGORYTYPE");

            entity.Property(e => e.ProductcategoryCode)
                .HasMaxLength(30)
                .HasColumnName("PRODUCTCATEGORY_CODE");
            entity.Property(e => e.ProductcategorytypeCode)
                .HasMaxLength(30)
                .HasColumnName("PRODUCTCATEGORYTYPE_CODE");
            entity.Property(e => e.Icon)
                .HasColumnType("image")
                .HasColumnName("ICON");
            entity.Property(e => e.Name)
                .HasMaxLength(60)
                .HasColumnName("NAME");
            entity.Property(e => e.Rank).HasColumnName("RANK");

            entity.HasOne(d => d.ProductcategoryCodeNavigation).WithMany(p => p.Productcategorytypes)
                .HasForeignKey(d => d.ProductcategoryCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PRODUCTCATEGORYTYPE_PRODUCTCATEGORY");
        });

        modelBuilder.Entity<Productsalesgroup>(entity =>
        {
            entity.HasKey(e => e.ProductsalesgroupCode).HasName("PK_ITEMSALESGROUP");

            entity.ToTable("PRODUCTSALESGROUP");

            entity.Property(e => e.ProductsalesgroupCode)
                .HasMaxLength(30)
                .HasColumnName("PRODUCTSALESGROUP_CODE");
            entity.Property(e => e.Name)
                .HasMaxLength(60)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<Profile>(entity =>
        {
            entity.HasKey(e => e.ProfileCode);

            entity.ToTable("PROFILE");

            entity.Property(e => e.ProfileCode)
                .HasMaxLength(30)
                .HasColumnName("PROFILE_CODE");
            entity.Property(e => e.Name)
                .HasMaxLength(60)
                .HasColumnName("NAME");

            entity.HasMany(d => d.AssabilfunctionCodes).WithMany(p => p.ProfileCodes)
                .UsingEntity<Dictionary<string, object>>(
                    "ProfileAssabilfunction",
                    r => r.HasOne<PrmAssabilfunction>().WithMany()
                        .HasForeignKey("AssabilfunctionCode")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_PROFILE_ASSABILFUNCTION_prmASSABILFUNCTION"),
                    l => l.HasOne<Profile>().WithMany()
                        .HasForeignKey("ProfileCode")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_PROFILE_ASSABILFUNCTION_PROFILE"),
                    j =>
                    {
                        j.HasKey("ProfileCode", "AssabilfunctionCode");
                        j.ToTable("PROFILE_ASSABILFUNCTION");
                        j.IndexerProperty<string>("ProfileCode")
                            .HasMaxLength(30)
                            .HasColumnName("PROFILE_CODE");
                        j.IndexerProperty<string>("AssabilfunctionCode")
                            .HasMaxLength(30)
                            .HasColumnName("ASSABILFUNCTION_CODE");
                    });
        });

        modelBuilder.Entity<ProfileTableattribute>(entity =>
        {
            entity.HasKey(e => new { e.ProfileCode, e.Tablename }).HasName("PK_prmPROFILE_TABLEATTRIBUTE");

            entity.ToTable("PROFILE_TABLEATTRIBUTE");

            entity.Property(e => e.ProfileCode)
                .HasMaxLength(30)
                .HasColumnName("PROFILE_CODE");
            entity.Property(e => e.Tablename)
                .HasMaxLength(60)
                .HasColumnName("TABLENAME");
            entity.Property(e => e.Deleterows).HasColumnName("DELETEROWS");
            entity.Property(e => e.Insertrows).HasColumnName("INSERTROWS");
            entity.Property(e => e.Modifyrows).HasColumnName("MODIFYROWS");
            entity.Property(e => e.Readrows).HasColumnName("READROWS");

            entity.HasOne(d => d.ProfileCodeNavigation).WithMany(p => p.ProfileTableattributes)
                .HasForeignKey(d => d.ProfileCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PROFILE_TABLEATTRIBUTE_PROFILE");
        });

        modelBuilder.Entity<ProfileTablefieldattribute>(entity =>
        {
            entity.HasKey(e => new { e.ProfileCode, e.Tablename, e.Fieldname });

            entity.ToTable("PROFILE_TABLEFIELDATTRIBUTE");

            entity.Property(e => e.ProfileCode)
                .HasMaxLength(30)
                .HasColumnName("PROFILE_CODE");
            entity.Property(e => e.Tablename)
                .HasMaxLength(60)
                .HasColumnName("TABLENAME");
            entity.Property(e => e.Fieldname)
                .HasMaxLength(60)
                .HasColumnName("FIELDNAME");
            entity.Property(e => e.Insertonly).HasColumnName("INSERTONLY");
            entity.Property(e => e.Readonly).HasColumnName("READONLY");

            entity.HasOne(d => d.ProfileTableattribute).WithMany(p => p.ProfileTablefieldattributes)
                .HasForeignKey(d => new { d.ProfileCode, d.Tablename })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PROFILE_TABLEFIELDATTRIBUTE_PROFILE_TABLEATTRIBUTE");
        });

        modelBuilder.Entity<Readingorder>(entity =>
        {
            entity.HasKey(e => e.ReadingorderCode);

            entity.ToTable("READINGORDER");

            entity.Property(e => e.ReadingorderCode)
                .HasMaxLength(30)
                .HasColumnName("READINGORDER_CODE");
            entity.Property(e => e.AssetCode)
                .HasMaxLength(30)
                .HasColumnName("ASSET_CODE");
            entity.Property(e => e.City)
                .HasMaxLength(30)
                .HasColumnName("CITY");
            entity.Property(e => e.Coefficient)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("COEFFICIENT");
            entity.Property(e => e.ContractCode)
                .HasMaxLength(30)
                .HasColumnName("CONTRACT_CODE");
            entity.Property(e => e.Creationdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATIONDATE");
            entity.Property(e => e.Digitsnumber).HasColumnName("DIGITSNUMBER");
            entity.Property(e => e.Enddate)
                .HasColumnType("datetime")
                .HasColumnName("ENDDATE");
            entity.Property(e => e.Envisagedindex)
                .HasColumnType("numeric(17, 0)")
                .HasColumnName("ENVISAGEDINDEX");
            entity.Property(e => e.ExecutedbypersonCode)
                .HasMaxLength(30)
                .HasColumnName("EXECUTEDBYPERSON_CODE");
            entity.Property(e => e.Externalreference)
                .HasMaxLength(30)
                .HasColumnName("EXTERNALREFERENCE");
            entity.Property(e => e.Information)
                .HasMaxLength(30)
                .HasColumnName("INFORMATION");
            entity.Property(e => e.InstallationCode)
                .HasMaxLength(30)
                .HasColumnName("INSTALLATION_CODE");
            entity.Property(e => e.InternalCounter).HasColumnName("INTERNAL_COUNTER");
            entity.Property(e => e.ItineraryCode)
                .HasMaxLength(30)
                .HasDefaultValue("xxx")
                .HasColumnName("ITINERARY_CODE");
            entity.Property(e => e.Maximumindex)
                .HasColumnType("numeric(17, 0)")
                .HasColumnName("MAXIMUMINDEX");
            entity.Property(e => e.Minimumindex)
                .HasColumnType("numeric(17, 0)")
                .HasColumnName("MINIMUMINDEX");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("NAME");
            entity.Property(e => e.Name2)
                .HasMaxLength(30)
                .HasColumnName("NAME2");
            entity.Property(e => e.Newindex)
                .HasColumnType("numeric(17, 0)")
                .HasColumnName("NEWINDEX");
            entity.Property(e => e.Newindexdate)
                .HasColumnType("datetime")
                .HasColumnName("NEWINDEXDATE");
            entity.Property(e => e.Num)
                .HasMaxLength(10)
                .HasColumnName("NUM");
            entity.Property(e => e.Postalcode)
                .HasMaxLength(30)
                .HasColumnName("POSTALCODE");
            entity.Property(e => e.Previousindex)
                .HasColumnType("numeric(17, 0)")
                .HasColumnName("PREVIOUSINDEX");
            entity.Property(e => e.Previousindexdate)
                .HasColumnType("datetime")
                .HasColumnName("PREVIOUSINDEXDATE");
            entity.Property(e => e.PreviousindexreasonCode)
                .HasMaxLength(30)
                .HasColumnName("PREVIOUSINDEXREASON_CODE");
            entity.Property(e => e.PricelistCode)
                .HasMaxLength(30)
                .HasColumnName("PRICELIST_CODE");
            entity.Property(e => e.ProductCode)
                .HasMaxLength(30)
                .HasColumnName("PRODUCT_CODE");
            entity.Property(e => e.ReadingorderresultCode)
                .HasMaxLength(30)
                .HasColumnName("READINGORDERRESULT_CODE");
            entity.Property(e => e.ReadingorderresultnoteCode)
                .HasMaxLength(30)
                .HasColumnName("READINGORDERRESULTNOTE_CODE");
            entity.Property(e => e.ReadingordertypeCode)
                .HasMaxLength(30)
                .HasColumnName("READINGORDERTYPE_CODE");
            entity.Property(e => e.RoundCode)
                .HasMaxLength(50)
                .HasColumnName("ROUND_CODE");
            entity.Property(e => e.Sequence)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("SEQUENCE");
            entity.Property(e => e.Serialnumber)
                .HasMaxLength(30)
                .HasColumnName("SERIALNUMBER");
            entity.Property(e => e.Startdate)
                .HasColumnType("datetime")
                .HasColumnName("STARTDATE");
            entity.Property(e => e.Streetname1)
                .HasMaxLength(60)
                .HasColumnName("STREETNAME1");
            entity.Property(e => e.Streetname2)
                .HasMaxLength(60)
                .HasColumnName("STREETNAME2");
            entity.Property(e => e.WorkorderbatchCode)
                .HasMaxLength(30)
                .HasColumnName("WORKORDERBATCH_CODE");
            entity.Property(e => e.Zkennziff)
                .HasMaxLength(30)
                .HasColumnName("ZKENNZIFF");
            entity.Property(e => e.Zpruefkl)
                .HasMaxLength(30)
                .HasColumnName("ZPRUEFKL");
            entity.Property(e => e.Zwert1)
                .HasMaxLength(30)
                .HasColumnName("ZWERT1");
            entity.Property(e => e.Zwnummer)
                .HasMaxLength(30)
                .HasColumnName("ZWNUMMER");
            entity.Property(e => e.Zzwtyp)
                .HasMaxLength(30)
                .HasColumnName("ZZWTYP");

            entity.HasOne(d => d.ItineraryCodeNavigation).WithMany(p => p.Readingorders)
                .HasForeignKey(d => d.ItineraryCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_READINGORDER_ITINERARY");

            entity.HasOne(d => d.WorkorderbatchCodeNavigation).WithMany(p => p.Readingorders)
                .HasForeignKey(d => d.WorkorderbatchCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_READINGORDER_WORKORDERBATCH");
        });

        modelBuilder.Entity<Readingorderresultnote>(entity =>
        {
            entity.HasKey(e => new { e.ReadingorderresultCode, e.ReadingorderresultnoteCode }).HasName("PK_READINGORDERRESULTNOTICE");

            entity.ToTable("READINGORDERRESULTNOTE");

            entity.Property(e => e.ReadingorderresultCode)
                .HasMaxLength(30)
                .HasColumnName("READINGORDERRESULT_CODE");
            entity.Property(e => e.ReadingorderresultnoteCode)
                .HasMaxLength(30)
                .HasColumnName("READINGORDERRESULTNOTE_CODE");
            entity.Property(e => e.Categorie).HasMaxLength(15);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("NAME");
            entity.Property(e => e.NoticeCode).HasMaxLength(10);
            entity.Property(e => e.NoticeText).HasMaxLength(50);

            entity.HasOne(d => d.ReadingorderresultCodeNavigation).WithMany(p => p.Readingorderresultnotes)
                .HasForeignKey(d => d.ReadingorderresultCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_READINGORDERRESULTNOTE_prmREADINGORDERRESULT");
        });

        modelBuilder.Entity<Reclamation>(entity =>
        {
            entity.ToTable("RECLAMATION");

            entity.Property(e => e.ReclamationId)
                .HasMaxLength(30)
                .HasColumnName("RECLAMATION_ID");
            entity.Property(e => e.Agent)
                .HasMaxLength(30)
                .HasColumnName("AGENT");
            entity.Property(e => e.CodeAgence)
                .HasMaxLength(50)
                .HasColumnName("CODE_AGENCE");
            entity.Property(e => e.ContractCode)
                .HasMaxLength(30)
                .HasColumnName("CONTRACT_CODE");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("DATE");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.LastName)
                .HasMaxLength(40)
                .HasColumnName("LAST_NAME");
            entity.Property(e => e.Name)
                .HasMaxLength(40)
                .HasColumnName("NAME");
            entity.Property(e => e.Phone)
                .HasMaxLength(30)
                .HasColumnName("PHONE");
        });

        modelBuilder.Entity<Round>(entity =>
        {
            entity.HasKey(e => e.RoundCode);

            entity.ToTable("ROUND");

            entity.Property(e => e.RoundCode)
                .HasMaxLength(30)
                .HasColumnName("ROUND_CODE");
            entity.Property(e => e.AssetCode)
                .HasMaxLength(30)
                .HasColumnName("ASSET_CODE");
            entity.Property(e => e.Attendedby2personCode)
                .HasMaxLength(30)
                .HasColumnName("ATTENDEDBY2PERSON_CODE");
            entity.Property(e => e.AttendedbypersonCode)
                .HasMaxLength(30)
                .HasColumnName("ATTENDEDBYPERSON_CODE");
            entity.Property(e => e.BranchCode)
                .HasMaxLength(30)
                .HasColumnName("BRANCH_CODE");
            entity.Property(e => e.CodeAgence)
                .HasMaxLength(50)
                .HasColumnName("CODE_AGENCE");
            entity.Property(e => e.Departuremilage).HasColumnName("DEPARTUREMILAGE");
            entity.Property(e => e.Departuretime)
                .HasColumnType("datetime")
                .HasColumnName("DEPARTURETIME");
            entity.Property(e => e.Endtime)
                .HasColumnType("datetime")
                .HasColumnName("ENDTIME");
            entity.Property(e => e.ItineraryCode)
                .HasMaxLength(30)
                .HasColumnName("ITINERARY_CODE");
            entity.Property(e => e.PersonCode)
                .HasMaxLength(30)
                .HasColumnName("PERSON_CODE");
            entity.Property(e => e.Progresslevel).HasColumnName("PROGRESSLEVEL");
            entity.Property(e => e.Returnmilage).HasColumnName("RETURNMILAGE");
            entity.Property(e => e.Returntime)
                .HasColumnType("datetime")
                .HasColumnName("RETURNTIME");
            entity.Property(e => e.Starttime)
                .HasColumnType("datetime")
                .HasColumnName("STARTTIME");
            entity.Property(e => e.TranserbatchCode).HasColumnName("TRANSERBATCH_CODE");
            entity.Property(e => e.Transerdate)
                .HasColumnType("datetime")
                .HasColumnName("TRANSERDATE");
            entity.Property(e => e.WorkstationCode)
                .HasMaxLength(30)
                .HasColumnName("WORKSTATION_CODE");

            entity.HasOne(d => d.BranchCodeNavigation).WithMany(p => p.Rounds)
                .HasForeignKey(d => d.BranchCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ROUND_COMPANY");

            entity.HasOne(d => d.ItineraryCodeNavigation).WithMany(p => p.Rounds)
                .HasForeignKey(d => d.ItineraryCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ROUND_ITINERARY");
        });

        modelBuilder.Entity<SapReadingOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sapREADING_ORDER");

            entity.Property(e => e.AgencyCode)
                .HasMaxLength(3)
                .HasColumnName("AGENCY_CODE");
            entity.Property(e => e.BatchNumber).HasColumnName("BATCH_NUMBER");
            entity.Property(e => e.CodeAgence)
                .HasMaxLength(50)
                .HasColumnName("CODE_AGENCE");
            entity.Property(e => e.Coefficient)
                .HasMaxLength(30)
                .HasColumnName("COEFFICIENT");
            entity.Property(e => e.ContractCode)
                .HasMaxLength(10)
                .HasColumnName("CONTRACT_CODE");
            entity.Property(e => e.ControlKey)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("CONTROL_KEY");
            entity.Property(e => e.DeviceCode)
                .HasMaxLength(30)
                .HasColumnName("DEVICE_CODE");
            entity.Property(e => e.DocumentNumber)
                .HasMaxLength(20)
                .HasColumnName("DOCUMENT_NUMBER");
            entity.Property(e => e.EnvisagedIndex)
                .HasColumnType("numeric(17, 0)")
                .HasColumnName("ENVISAGED_INDEX");
            entity.Property(e => e.EqptFactorySerialNumber)
                .HasMaxLength(30)
                .HasColumnName("EQPT_FACTORY_SERIAL_NUMBER");
            entity.Property(e => e.EqptSerialNumber)
                .HasMaxLength(18)
                .HasColumnName("EQPT_SERIAL_NUMBER");
            entity.Property(e => e.EqptType)
                .HasMaxLength(18)
                .HasColumnName("EQPT_TYPE");
            entity.Property(e => e.ExternalReference)
                .HasMaxLength(30)
                .HasColumnName("EXTERNAL_REFERENCE");
            entity.Property(e => e.ExtractionDate)
                .HasMaxLength(8)
                .HasColumnName("EXTRACTION_DATE");
            entity.Property(e => e.Firstname)
                .HasMaxLength(40)
                .HasColumnName("FIRSTNAME");
            entity.Property(e => e.Information)
                .HasMaxLength(10)
                .HasColumnName("INFORMATION");
            entity.Property(e => e.InputKey)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("INPUT_KEY");
            entity.Property(e => e.Installation)
                .HasMaxLength(10)
                .HasColumnName("INSTALLATION");
            entity.Property(e => e.InternalCounter)
                .HasMaxLength(1)
                .HasColumnName("INTERNAL_COUNTER");
            entity.Property(e => e.Lastname)
                .HasMaxLength(40)
                .HasColumnName("LASTNAME");
            entity.Property(e => e.Location)
                .HasMaxLength(40)
                .HasColumnName("LOCATION");
            entity.Property(e => e.MaximumIndex)
                .HasColumnType("numeric(17, 0)")
                .HasColumnName("MAXIMUM_INDEX");
            entity.Property(e => e.MinimumIndex)
                .HasColumnType("numeric(17, 0)")
                .HasColumnName("MINIMUM_INDEX");
            entity.Property(e => e.NewIndex)
                .HasColumnType("numeric(17, 0)")
                .HasColumnName("NEW_INDEX");
            entity.Property(e => e.NewIndexDate)
                .HasMaxLength(8)
                .HasColumnName("NEW_INDEX_DATE");
            entity.Property(e => e.Number)
                .HasMaxLength(10)
                .HasColumnName("NUMBER");
            entity.Property(e => e.PersonCode)
                .HasMaxLength(6)
                .HasColumnName("PERSON_CODE");
            entity.Property(e => e.PersonNotice)
                .HasMaxLength(4)
                .HasColumnName("PERSON_NOTICE");
            entity.Property(e => e.PostalCode)
                .HasMaxLength(10)
                .HasColumnName("POSTAL_CODE");
            entity.Property(e => e.PreviousIndex)
                .HasColumnType("numeric(17, 0)")
                .HasColumnName("PREVIOUS_INDEX");
            entity.Property(e => e.PreviousIndexDate)
                .HasMaxLength(8)
                .HasColumnName("PREVIOUS_INDEX_DATE");
            entity.Property(e => e.PreviousIndexReason)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("PREVIOUS_INDEX_REASON");
            entity.Property(e => e.ReadingOrderEnddate)
                .HasMaxLength(8)
                .HasColumnName("READING_ORDER_ENDDATE");
            entity.Property(e => e.ReadingOrderReason)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("READING_ORDER_REASON");
            entity.Property(e => e.ReadingOrderStartdate)
                .HasMaxLength(8)
                .HasColumnName("READING_ORDER_STARTDATE");
            entity.Property(e => e.ReadingOrderUnitSequence)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("READING_ORDER_UNIT_SEQUENCE");
            entity.Property(e => e.Rowguid).HasColumnName("rowguid");
            entity.Property(e => e.Sequence)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("SEQUENCE");
            entity.Property(e => e.Street)
                .HasMaxLength(60)
                .HasColumnName("STREET");
            entity.Property(e => e.TransferDate)
                .HasMaxLength(8)
                .HasColumnName("TRANSFER_DATE");
            entity.Property(e => e.UsualStreet)
                .HasMaxLength(60)
                .HasColumnName("USUAL_STREET");
        });

        modelBuilder.Entity<Sinvoice>(entity =>
        {
            entity.HasKey(e => e.SinvoiceCode);

            entity.ToTable("SINVOICE");

            entity.Property(e => e.SinvoiceCode)
                .HasMaxLength(30)
                .HasColumnName("SINVOICE_CODE");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMOUNT");
            entity.Property(e => e.Canceled).HasColumnName("CANCELED");
            entity.Property(e => e.Closed).HasColumnName("CLOSED");
            entity.Property(e => e.CodeAgence)
                .HasMaxLength(50)
                .HasColumnName("CODE_AGENCE");
            entity.Property(e => e.Confirmeddate)
                .HasColumnType("datetime")
                .HasColumnName("CONFIRMEDDATE");
            entity.Property(e => e.Consignmenttype).HasColumnName("CONSIGNMENTTYPE");
            entity.Property(e => e.ContactCode)
                .HasMaxLength(30)
                .HasColumnName("CONTACT_CODE");
            entity.Property(e => e.ContractCode)
                .HasMaxLength(30)
                .HasColumnName("CONTRACT_CODE");
            entity.Property(e => e.Contractaccount)
                .HasMaxLength(30)
                .HasColumnName("CONTRACTACCOUNT");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(30)
                .HasColumnName("CURRENCY_CODE");
            entity.Property(e => e.Description)
                .HasMaxLength(140)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Discount1)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DISCOUNT1");
            entity.Property(e => e.Discount2)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DISCOUNT2");
            entity.Property(e => e.Discount3)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DISCOUNT3");
            entity.Property(e => e.Discount4)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DISCOUNT4");
            entity.Property(e => e.Dueamount)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DUEAMOUNT");
            entity.Property(e => e.Emptyamount)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("EMPTYAMOUNT");
            entity.Property(e => e.Exonerationreference)
                .HasMaxLength(140)
                .HasColumnName("EXONERATIONREFERENCE");
            entity.Property(e => e.Externalreference1)
                .HasMaxLength(60)
                .HasColumnName("EXTERNALREFERENCE1");
            entity.Property(e => e.Externalreference2)
                .HasMaxLength(60)
                .HasColumnName("EXTERNALREFERENCE2");
            entity.Property(e => e.Finaldiscount)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FINALDISCOUNT");
            entity.Property(e => e.Finaldiscountrate)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FINALDISCOUNTRATE");
            entity.Property(e => e.Fixedtaxamount)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FIXEDTAXAMOUNT");
            entity.Property(e => e.ItineraryCode)
                .HasMaxLength(30)
                .HasColumnName("ITINERARY_CODE");
            entity.Property(e => e.Lastupdate)
                .HasColumnType("datetime")
                .HasColumnName("LASTUPDATE");
            entity.Property(e => e.PartnerCode)
                .HasMaxLength(30)
                .HasColumnName("PARTNER_CODE");
            entity.Property(e => e.PaymentCode)
                .HasMaxLength(30)
                .HasColumnName("PAYMENT_CODE");
            entity.Property(e => e.PaymenttermCode)
                .HasMaxLength(30)
                .HasColumnName("PAYMENTTERM_CODE");
            entity.Property(e => e.PersonCode)
                .HasMaxLength(30)
                .HasColumnName("PERSON_CODE");
            entity.Property(e => e.Printingaccount).HasColumnName("PRINTINGACCOUNT");
            entity.Property(e => e.ProductsalesgroupCode)
                .HasMaxLength(30)
                .HasColumnName("PRODUCTSALESGROUP_CODE");
            entity.Property(e => e.Progresslevel).HasColumnName("PROGRESSLEVEL");
            entity.Property(e => e.ProjectCode)
                .HasMaxLength(30)
                .HasColumnName("PROJECT_CODE");
            entity.Property(e => e.Requesteddate)
                .HasColumnType("datetime")
                .HasColumnName("REQUESTEDDATE");
            entity.Property(e => e.RoundCode)
                .HasMaxLength(30)
                .HasColumnName("ROUND_CODE");
            entity.Property(e => e.Securitylevel).HasColumnName("SECURITYLEVEL");
            entity.Property(e => e.SinvoicestatusCode)
                .HasMaxLength(30)
                .HasColumnName("SINVOICESTATUS_CODE");
            entity.Property(e => e.SinvoicetypeCode)
                .HasMaxLength(30)
                .HasColumnName("SINVOICETYPE_CODE");
            entity.Property(e => e.SorderCode)
                .HasMaxLength(30)
                .HasColumnName("SORDER_CODE");
            entity.Property(e => e.SupplierCode)
                .HasMaxLength(30)
                .HasColumnName("SUPPLIER_CODE");
            entity.Property(e => e.Thedate)
                .HasColumnType("datetime")
                .HasColumnName("THEDATE");
            entity.Property(e => e.Trackingkey)
                .HasMaxLength(30)
                .HasColumnName("TRACKINGKEY");
            entity.Property(e => e.UserCode)
                .HasMaxLength(30)
                .HasColumnName("USER_CODE");
            entity.Property(e => e.Userfield1)
                .HasMaxLength(60)
                .HasColumnName("USERFIELD1");
            entity.Property(e => e.Userfield2)
                .HasMaxLength(30)
                .HasColumnName("USERFIELD2");
            entity.Property(e => e.Vat1amount)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("VAT1AMOUNT");
            entity.Property(e => e.Vat2amount)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("VAT2AMOUNT");
            entity.Property(e => e.VisitCode)
                .HasMaxLength(30)
                .HasColumnName("VISIT_CODE");
            entity.Property(e => e.WarehouseCode)
                .HasMaxLength(30)
                .HasColumnName("WAREHOUSE_CODE");

            entity.HasOne(d => d.ItineraryCodeNavigation).WithMany(p => p.Sinvoices)
                .HasForeignKey(d => d.ItineraryCode)
                .HasConstraintName("FK_SINVOICE_ITINERARY");
        });

        modelBuilder.Entity<SinvoiceLine>(entity =>
        {
            entity.HasKey(e => new { e.SinvoiceCode, e.SinvoiceLineNumber });

            entity.ToTable("SINVOICE_LINE");

            entity.Property(e => e.SinvoiceCode)
                .HasMaxLength(30)
                .HasColumnName("SINVOICE_CODE");
            entity.Property(e => e.SinvoiceLineNumber).HasColumnName("SINVOICE_LINE_NUMBER");
            entity.Property(e => e.CodeAgence)
                .HasMaxLength(50)
                .HasColumnName("CODE_AGENCE");
            entity.Property(e => e.Confirmeddate)
                .HasColumnType("datetime")
                .HasColumnName("CONFIRMEDDATE");
            entity.Property(e => e.Damagedquantity)
                .HasColumnType("decimal(14, 3)")
                .HasColumnName("DAMAGEDQUANTITY");
            entity.Property(e => e.Description)
                .HasMaxLength(140)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Discount1)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DISCOUNT1");
            entity.Property(e => e.Discount2)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DISCOUNT2");
            entity.Property(e => e.Discount3)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DISCOUNT3");
            entity.Property(e => e.Discount4)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DISCOUNT4");
            entity.Property(e => e.Freequantity)
                .HasColumnType("decimal(14, 3)")
                .HasColumnName("FREEQUANTITY");
            entity.Property(e => e.Netunitprice)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("NETUNITPRICE");
            entity.Property(e => e.ProductCode)
                .HasMaxLength(30)
                .HasColumnName("PRODUCT_CODE");
            entity.Property(e => e.Promorate)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PROMORATE");
            entity.Property(e => e.Quantity)
                .HasColumnType("decimal(14, 3)")
                .HasColumnName("QUANTITY");
            entity.Property(e => e.Requesteddate)
                .HasColumnType("datetime")
                .HasColumnName("REQUESTEDDATE");
            entity.Property(e => e.Returnedquantity)
                .HasColumnType("decimal(14, 3)")
                .HasColumnName("RETURNEDQUANTITY");
            entity.Property(e => e.Soldout).HasColumnName("SOLDOUT");
            entity.Property(e => e.Unitprice)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("UNITPRICE");
            entity.Property(e => e.Userfield1)
                .HasMaxLength(60)
                .HasColumnName("USERFIELD1");
            entity.Property(e => e.Userfield2)
                .HasMaxLength(30)
                .HasColumnName("USERFIELD2");
            entity.Property(e => e.Vat1)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("VAT1");
            entity.Property(e => e.Vat2)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("VAT2");
        });

        modelBuilder.Entity<TmpPayment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TMP_PAYMENT");

            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMOUNT");
            entity.Property(e => e.CodeAgence)
                .HasMaxLength(50)
                .HasColumnName("CODE_AGENCE");
            entity.Property(e => e.PaymentCode)
                .HasMaxLength(30)
                .HasColumnName("PAYMENT_CODE");
        });

        modelBuilder.Entity<TmpPerformance>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TMP_PERFORMANCE");

            entity.Property(e => e.AnnomalieNumber).HasColumnName("ANNOMALIE_NUMBER");
            entity.Property(e => e.CodeAgence)
                .HasMaxLength(50)
                .HasColumnName("CODE_AGENCE");
            entity.Property(e => e.CompterNumber).HasColumnName("COMPTER_NUMBER");
            entity.Property(e => e.Enddate)
                .HasColumnType("datetime")
                .HasColumnName("ENDDATE");
            entity.Property(e => e.InstallationnullNumber).HasColumnName("INSTALLATIONNULL_NUMBER");
            entity.Property(e => e.ItinerarCode)
                .HasMaxLength(30)
                .HasColumnName("ITINERAR_CODE");
            entity.Property(e => e.PersonCode)
                .HasMaxLength(30)
                .HasColumnName("PERSON_CODE");
            entity.Property(e => e.Startdate)
                .HasColumnType("datetime")
                .HasColumnName("STARTDATE");
            entity.Property(e => e.Tauxrelve)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("TAUXRELVE");
        });

        modelBuilder.Entity<TmpSituationperformance>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TMP_SITUATIONPERFORMANCE");

            entity.Property(e => e.CodeAgence)
                .HasMaxLength(50)
                .HasColumnName("CODE_AGENCE");
            entity.Property(e => e.Enddate)
                .HasColumnType("datetime")
                .HasColumnName("ENDDATE");
            entity.Property(e => e.ItineraryCode)
                .HasMaxLength(30)
                .HasColumnName("ITINERARY_CODE");
            entity.Property(e => e.PersonCode)
                .HasMaxLength(30)
                .HasColumnName("PERSON_CODE");
            entity.Property(e => e.ReleveNumber).HasColumnName("RELEVE_NUMBER");
            entity.Property(e => e.Startdate)
                .HasColumnType("datetime")
                .HasColumnName("STARTDATE");
            entity.Property(e => e.TauxReleve)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("TAUX_RELEVE");
            entity.Property(e => e.UnitereleveNumber).HasColumnName("UNITERELEVE_NUMBER");
        });

        modelBuilder.Entity<Tokenserie>(entity =>
        {
            entity.HasKey(e => e.TokenserieCode);

            entity.ToTable("TOKENSERIE");

            entity.Property(e => e.TokenserieCode)
                .HasMaxLength(30)
                .HasColumnName("TOKENSERIE_CODE");
            entity.Property(e => e.Delnotenextnumber).HasColumnName("DELNOTENEXTNUMBER");
            entity.Property(e => e.Delnoteprefix)
                .HasMaxLength(4)
                .HasColumnName("DELNOTEPREFIX");
            entity.Property(e => e.Digitsincounter).HasColumnName("DIGITSINCOUNTER");
            entity.Property(e => e.Equipmentnextnumber).HasColumnName("EQUIPMENTNEXTNUMBER");
            entity.Property(e => e.Equipmentprefix)
                .HasMaxLength(4)
                .HasColumnName("EQUIPMENTPREFIX");
            entity.Property(e => e.Expensenextnumber).HasColumnName("EXPENSENEXTNUMBER");
            entity.Property(e => e.Expenseprefix)
                .HasMaxLength(4)
                .HasColumnName("EXPENSEPREFIX");
            entity.Property(e => e.Facingnextnumber).HasColumnName("FACINGNEXTNUMBER");
            entity.Property(e => e.Facingprefix)
                .HasMaxLength(4)
                .HasColumnName("FACINGPREFIX");
            entity.Property(e => e.Interviewnextnumber).HasColumnName("INTERVIEWNEXTNUMBER");
            entity.Property(e => e.Interviewprefix)
                .HasMaxLength(4)
                .HasColumnName("INTERVIEWPREFIX");
            entity.Property(e => e.Inventorynextnumber).HasColumnName("INVENTORYNEXTNUMBER");
            entity.Property(e => e.Inventoryprefix)
                .HasMaxLength(4)
                .HasColumnName("INVENTORYPREFIX");
            entity.Property(e => e.Invoicenextnumber).HasColumnName("INVOICENEXTNUMBER");
            entity.Property(e => e.Invoiceprefix)
                .HasMaxLength(4)
                .HasColumnName("INVOICEPREFIX");
            entity.Property(e => e.Loadnextnumber).HasColumnName("LOADNEXTNUMBER");
            entity.Property(e => e.Loadprefix)
                .HasMaxLength(4)
                .HasColumnName("LOADPREFIX");
            entity.Property(e => e.Name)
                .HasMaxLength(60)
                .HasColumnName("NAME");
            entity.Property(e => e.Ordernextnumber).HasColumnName("ORDERNEXTNUMBER");
            entity.Property(e => e.Orderprefix)
                .HasMaxLength(4)
                .HasColumnName("ORDERPREFIX");
            entity.Property(e => e.Partnernextnumber).HasColumnName("PARTNERNEXTNUMBER");
            entity.Property(e => e.Partnerprefix)
                .HasMaxLength(4)
                .HasColumnName("PARTNERPREFIX");
            entity.Property(e => e.Paymentnextnumber).HasColumnName("PAYMENTNEXTNUMBER");
            entity.Property(e => e.Paymentprefix)
                .HasMaxLength(4)
                .HasColumnName("PAYMENTPREFIX");
            entity.Property(e => e.Projectnextnumber).HasColumnName("PROJECTNEXTNUMBER");
            entity.Property(e => e.Projectprefix)
                .HasMaxLength(4)
                .HasColumnName("PROJECTPREFIX");
            entity.Property(e => e.Roundnextnumber).HasColumnName("ROUNDNEXTNUMBER");
            entity.Property(e => e.Roundprefix)
                .HasMaxLength(4)
                .HasColumnName("ROUNDPREFIX");
            entity.Property(e => e.Visitnextnumber).HasColumnName("VISITNEXTNUMBER");
            entity.Property(e => e.Visitprefix)
                .HasMaxLength(4)
                .HasColumnName("VISITPREFIX");
            entity.Property(e => e.WmRequestnextnumber).HasColumnName("WM_REQUESTNEXTNUMBER");
            entity.Property(e => e.WmRequestprefix)
                .HasMaxLength(4)
                .HasColumnName("WM_REQUESTPREFIX");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Users__3214EC075A2672A1");

            entity.Property(e => e.Actif).HasDefaultValue(true);
            entity.Property(e => e.CodeAgence)
                .HasMaxLength(50)
                .HasColumnName("Code_agence");
            entity.Property(e => e.DateCreation)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DateDerniereConnexion).HasColumnType("datetime");
            entity.Property(e => e.Matricule).HasMaxLength(50);
            entity.Property(e => e.MotDePasse).HasMaxLength(100);
            entity.Property(e => e.Nom).HasMaxLength(50);
            entity.Property(e => e.NomUtilisateur).HasMaxLength(50);
            entity.Property(e => e.Prenom).HasMaxLength(50);
            entity.Property(e => e.Telephone).HasMaxLength(100);
        });

        modelBuilder.Entity<Workorderbatch>(entity =>
        {
            entity.HasKey(e => e.WorkorderbatchCode);

            entity.ToTable("WORKORDERBATCH");

            entity.Property(e => e.WorkorderbatchCode)
                .HasMaxLength(30)
                .HasColumnName("WORKORDERBATCH_CODE");
            entity.Property(e => e.CodeAgence)
                .HasMaxLength(50)
                .HasColumnName("CODE_AGENCE");
            entity.Property(e => e.Thedate)
                .HasColumnType("datetime")
                .HasColumnName("THEDATE");
            entity.Property(e => e.WorkorderbatchstatusCode)
                .HasMaxLength(30)
                .HasColumnName("WORKORDERBATCHSTATUS_CODE");
            entity.Property(e => e.WorkorderbatchtypeCode)
                .HasMaxLength(30)
                .HasColumnName("WORKORDERBATCHTYPE_CODE");
            entity.Property(e => e.WorkstationCode)
                .HasMaxLength(30)
                .HasColumnName("WORKSTATION_CODE");
        });

        modelBuilder.Entity<Worksite>(entity =>
        {
            entity.HasKey(e => e.WorksiteCode).HasName("PK_PARTNERSITE");

            entity.ToTable("WORKSITE");

            entity.Property(e => e.WorksiteCode)
                .HasMaxLength(30)
                .HasColumnName("WORKSITE_CODE");
            entity.Property(e => e.City)
                .HasMaxLength(30)
                .HasColumnName("CITY");
            entity.Property(e => e.CodeAgence)
                .HasMaxLength(50)
                .HasColumnName("CODE_AGENCE");
            entity.Property(e => e.Country)
                .HasMaxLength(30)
                .HasColumnName("COUNTRY");
            entity.Property(e => e.Extendedadress)
                .HasMaxLength(140)
                .HasColumnName("EXTENDEDADRESS");
            entity.Property(e => e.Fax)
                .HasMaxLength(30)
                .HasColumnName("FAX");
            entity.Property(e => e.GeoareaCode)
                .HasMaxLength(30)
                .HasColumnName("GEOAREA_CODE");
            entity.Property(e => e.Name)
                .HasMaxLength(60)
                .HasColumnName("NAME");
            entity.Property(e => e.Num)
                .HasMaxLength(10)
                .HasColumnName("NUM");
            entity.Property(e => e.PartnerCode)
                .HasMaxLength(30)
                .HasColumnName("PARTNER_CODE");
            entity.Property(e => e.Phone1)
                .HasMaxLength(30)
                .HasColumnName("PHONE1");
            entity.Property(e => e.Phone2)
                .HasMaxLength(30)
                .HasColumnName("PHONE2");
            entity.Property(e => e.Postalcode)
                .HasMaxLength(10)
                .HasColumnName("POSTALCODE");
            entity.Property(e => e.State)
                .HasMaxLength(30)
                .HasColumnName("STATE");
            entity.Property(e => e.Streetname1)
                .HasMaxLength(60)
                .HasColumnName("STREETNAME1");
            entity.Property(e => e.Streetname2)
                .HasMaxLength(60)
                .HasColumnName("STREETNAME2");
            entity.Property(e => e.WorksitecategoryCode)
                .HasMaxLength(50)
                .HasColumnName("WORKSITECATEGORY_CODE");
            entity.Property(e => e.WorksitecategorytypeCode)
                .HasMaxLength(50)
                .HasColumnName("WORKSITECATEGORYTYPE_CODE");

            entity.HasOne(d => d.GeoareaCodeNavigation).WithMany(p => p.Worksites)
                .HasForeignKey(d => d.GeoareaCode)
                .HasConstraintName("FK_WORKSITE_GEOAREA");

            entity.HasOne(d => d.PartnerCodeNavigation).WithMany(p => p.Worksites)
                .HasForeignKey(d => d.PartnerCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PARTNERSITE_PARTNER");
        });

        modelBuilder.Entity<Workstation>(entity =>
        {
            entity.HasKey(e => e.WorkstationCode);

            entity.ToTable("WORKSTATION");

            entity.Property(e => e.WorkstationCode)
                .HasMaxLength(30)
                .HasColumnName("WORKSTATION_CODE");
            entity.Property(e => e.Attendedby2personCode)
                .HasMaxLength(30)
                .HasColumnName("ATTENDEDBY2PERSON_CODE");
            entity.Property(e => e.AttendedbypersonCode)
                .HasMaxLength(30)
                .HasColumnName("ATTENDEDBYPERSON_CODE");
            entity.Property(e => e.BranchCode)
                .HasMaxLength(30)
                .HasColumnName("BRANCH_CODE");
            entity.Property(e => e.BudgetCode)
                .HasMaxLength(30)
                .HasColumnName("BUDGET_CODE");
            entity.Property(e => e.CodeAgence)
                .HasMaxLength(50)
                .HasColumnName("CODE_AGENCE");
            entity.Property(e => e.Currentcredit)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CURRENTCREDIT");
            entity.Property(e => e.Currentstockvalue)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CURRENTSTOCKVALUE");
            entity.Property(e => e.DatabaseCode)
                .HasMaxLength(30)
                .HasDefaultValue("MYDOCUMENTS")
                .HasColumnName("DATABASE_CODE");
            entity.Property(e => e.GeoareaCode)
                .HasMaxLength(30)
                .HasColumnName("GEOAREA_CODE");
            entity.Property(e => e.Lastupdate)
                .HasColumnType("datetime")
                .HasColumnName("LASTUPDATE");
            entity.Property(e => e.Maximumcredit)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("MAXIMUMCREDIT");
            entity.Property(e => e.Maximumstockvalue)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("MAXIMUMSTOCKVALUE");
            entity.Property(e => e.Name)
                .HasMaxLength(60)
                .HasColumnName("NAME");
            entity.Property(e => e.PersonCode)
                .HasMaxLength(30)
                .HasColumnName("PERSON_CODE");
            entity.Property(e => e.Phone)
                .HasMaxLength(30)
                .HasColumnName("PHONE");
            entity.Property(e => e.ProfileCode)
                .HasMaxLength(30)
                .HasDefaultValue("?")
                .HasColumnName("PROFILE_CODE");
            entity.Property(e => e.Securitylevel).HasColumnName("SECURITYLEVEL");
            entity.Property(e => e.UpworkstationCode)
                .HasMaxLength(30)
                .HasColumnName("UPWORKSTATION_CODE");
            entity.Property(e => e.UserCode)
                .HasMaxLength(30)
                .HasColumnName("USER_CODE");
            entity.Property(e => e.Userfield1)
                .HasMaxLength(60)
                .HasColumnName("USERFIELD1");
            entity.Property(e => e.Userfield2)
                .HasMaxLength(30)
                .HasColumnName("USERFIELD2");
            entity.Property(e => e.WorksiteCode)
                .HasMaxLength(30)
                .HasDefaultValue("?")
                .HasColumnName("WORKSITE_CODE");
            entity.Property(e => e.WorkstationcategoryCode)
                .HasMaxLength(30)
                .HasColumnName("WORKSTATIONCATEGORY_CODE");
            entity.Property(e => e.WorkstationcategorytypeCode)
                .HasMaxLength(30)
                .HasColumnName("WORKSTATIONCATEGORYTYPE_CODE");

            entity.HasOne(d => d.BranchCodeNavigation).WithMany(p => p.Workstations)
                .HasForeignKey(d => d.BranchCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WORKSTATION_COMPANY");

            entity.HasOne(d => d.DatabaseCodeNavigation).WithMany(p => p.Workstations)
                .HasForeignKey(d => d.DatabaseCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WORKSTATION_DATABASE");

            entity.HasOne(d => d.GeoareaCodeNavigation).WithMany(p => p.Workstations)
                .HasForeignKey(d => d.GeoareaCode)
                .HasConstraintName("FK_WORKSTATION_LOCATION");

            entity.HasOne(d => d.PersonCodeNavigation).WithMany(p => p.Workstations)
                .HasForeignKey(d => d.PersonCode)
                .HasConstraintName("FK_WORKSTATION_PERSON");

            entity.HasOne(d => d.WorksiteCodeNavigation).WithMany(p => p.Workstations)
                .HasForeignKey(d => d.WorksiteCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WORKSTATION_WORKSITE");
        });

        modelBuilder.Entity<WorkstationItinerary>(entity =>
        {
            entity.HasKey(e => new { e.WorkstationCode, e.ItineraryCode }).HasName("PK_WORKSTATION_LOCATION");

            entity.ToTable("WORKSTATION_ITINERARY");

            entity.Property(e => e.WorkstationCode)
                .HasMaxLength(30)
                .HasColumnName("WORKSTATION_CODE");
            entity.Property(e => e.ItineraryCode)
                .HasMaxLength(30)
                .HasColumnName("ITINERARY_CODE");
            entity.Property(e => e.CodeAgence)
                .HasMaxLength(50)
                .HasColumnName("CODE_AGENCE");
            entity.Property(e => e.Rank).HasColumnName("RANK");

            entity.HasOne(d => d.ItineraryCodeNavigation).WithMany(p => p.WorkstationItineraries)
                .HasForeignKey(d => d.ItineraryCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WORKSTATION_ITINERARY_ITINERARY");

            entity.HasOne(d => d.WorkstationCodeNavigation).WithMany(p => p.WorkstationItineraries)
                .HasForeignKey(d => d.WorkstationCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WORKSTATION_ITINERARY_WORKSTATION");
        });

        modelBuilder.Entity<WorkstationTokenserie>(entity =>
        {
            entity.HasKey(e => new { e.WorkstationCode, e.ProductsalesgroupCode });

            entity.ToTable("WORKSTATION_TOKENSERIE");

            entity.Property(e => e.WorkstationCode)
                .HasMaxLength(30)
                .HasColumnName("WORKSTATION_CODE");
            entity.Property(e => e.ProductsalesgroupCode)
                .HasMaxLength(30)
                .HasColumnName("PRODUCTSALESGROUP_CODE");
            entity.Property(e => e.CodeAgence)
                .HasMaxLength(50)
                .HasColumnName("CODE_AGENCE");
            entity.Property(e => e.TokenserieCode)
                .HasMaxLength(30)
                .HasColumnName("TOKENSERIE_CODE");

            entity.HasOne(d => d.ProductsalesgroupCodeNavigation).WithMany(p => p.WorkstationTokenseries)
                .HasForeignKey(d => d.ProductsalesgroupCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WORKSTATION_TOKENSERIE_PRODUCTSALESGROUP");

            entity.HasOne(d => d.TokenserieCodeNavigation).WithMany(p => p.WorkstationTokenseries)
                .HasForeignKey(d => d.TokenserieCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WORKSTATION_TOKENSERIE_TOKENSERIE");

            entity.HasOne(d => d.WorkstationCodeNavigation).WithMany(p => p.WorkstationTokenseries)
                .HasForeignKey(d => d.WorkstationCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WORKSTATION_TOKENSERIE_WORKSTATION");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
