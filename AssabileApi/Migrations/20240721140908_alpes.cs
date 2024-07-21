using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssabileApi.Migrations
{
    /// <inheritdoc />
    public partial class alpes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ASSETCONFIGURATION",
                columns: table => new
                {
                    RdaInternetUrl = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    RemoteInstanceName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    RemoteDatabaseName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    CODE_AGENCE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "BACKGROUNDIMAGE",
                columns: table => new
                {
                    BACKGROUNDIMAGE_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    BACKGROUNDIMAGE = table.Column<byte[]>(type: "image", nullable: false),
                    TOPLEFT_X = table.Column<int>(type: "int", nullable: false),
                    TOPLEFT_Y = table.Column<int>(type: "int", nullable: false),
                    BOTTOMRIGHT_X = table.Column<int>(type: "int", nullable: false),
                    BOTTOMRIGHT_Y = table.Column<int>(type: "int", nullable: false),
                    Z = table.Column<int>(type: "int", nullable: false),
                    TRANSPARENCYCOLOR_COE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    NOTES = table.Column<string>(type: "ntext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OBJECTPICTURE", x => x.BACKGROUNDIMAGE_CODE);
                });

            migrationBuilder.CreateTable(
                name: "BANK",
                columns: table => new
                {
                    BANK_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    CODE_AGENCE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BANK", x => x.BANK_CODE);
                });

            migrationBuilder.CreateTable(
                name: "BRANCH",
                columns: table => new
                {
                    BRANCH_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CODE_AGENCE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMPANY_1", x => x.BRANCH_CODE);
                });

            migrationBuilder.CreateTable(
                name: "DATABASE",
                columns: table => new
                {
                    DATABASE_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    LASTDATAUPDATE = table.Column<DateTime>(type: "datetime", nullable: false),
                    LASTTRANSFERDATE = table.Column<DateTime>(type: "datetime", nullable: false),
                    SELECTIVEDOWNLOAD = table.Column<bool>(type: "bit", nullable: false),
                    CODE_AGENCE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DATABASE", x => x.DATABASE_CODE);
                });

            migrationBuilder.CreateTable(
                name: "DBTABLE",
                columns: table => new
                {
                    TABLENAME = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DBTABLE", x => x.TABLENAME);
                });

            migrationBuilder.CreateTable(
                name: "GEOOBJECT",
                columns: table => new
                {
                    GEOOBJECT_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    BACKGROUNGCOLOR_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    BORDERCOLOR_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    X = table.Column<int>(type: "int", nullable: false),
                    Y = table.Column<int>(type: "int", nullable: false),
                    Z = table.Column<int>(type: "int", nullable: false),
                    ATTRIBUTE1 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ATTRIBUTE2 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ATTRIBUTE3 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ATTRIBUTE4 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ATTRIBUTE5 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    GEOOBJECTTYPE = table.Column<int>(type: "int", nullable: false),
                    OBJECT_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CODE_AGENCE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GEOOBJECT", x => x.GEOOBJECT_CODE);
                });

            migrationBuilder.CreateTable(
                name: "GEOPLAN",
                columns: table => new
                {
                    GEOPLAN_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    TOPLEFT_X = table.Column<int>(type: "int", nullable: false),
                    TOPLEFT_Y = table.Column<int>(type: "int", nullable: false),
                    BOTTOMRIGHT_X = table.Column<int>(type: "int", nullable: false),
                    BOTTOMRIGHT_Y = table.Column<int>(type: "int", nullable: false),
                    Z = table.Column<int>(type: "int", nullable: false),
                    BACKGROUNDCOLOR_COE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    NOTES = table.Column<string>(type: "ntext", nullable: true),
                    CODE_AGENCE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PLANVIEW", x => x.GEOPLAN_CODE);
                });

            migrationBuilder.CreateTable(
                name: "ITINERARY",
                columns: table => new
                {
                    ITINERARY_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    SECURITYLEVEL = table.Column<int>(type: "int", nullable: false),
                    CODE_AGENCE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITINERARY_1", x => x.ITINERARY_CODE);
                });

            migrationBuilder.CreateTable(
                name: "LANGUAGE",
                columns: table => new
                {
                    LANGUAGE_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LANGUAGE", x => x.LANGUAGE_CODE);
                });

            migrationBuilder.CreateTable(
                name: "PARTNERCATEGORY",
                columns: table => new
                {
                    PARTNERCATEGORY_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    RANK = table.Column<int>(type: "int", nullable: false),
                    UPPARTNERCATEGORY_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PARTNERCATEGORY", x => x.PARTNERCATEGORY_CODE);
                });

            migrationBuilder.CreateTable(
                name: "PARTNERIDTYPE",
                columns: table => new
                {
                    PARTNERIDTYPE_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PARTNERIDTYPE", x => x.PARTNERIDTYPE_CODE);
                });

            migrationBuilder.CreateTable(
                name: "PARTNERSTATUS",
                columns: table => new
                {
                    PARTNERSTATUS_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    RANK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PARTNERSTATUS", x => x.PARTNERSTATUS_CODE);
                });

            migrationBuilder.CreateTable(
                name: "PAYMENT",
                columns: table => new
                {
                    PAYMENT_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    REFERENCE = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    PAYMENTTERM_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    AMOUNT = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    MATURITY_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    THEDATE = table.Column<DateTime>(type: "datetime", nullable: false),
                    PARTNER_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    PERSON_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ROUND_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    VISIT_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    LOCKED = table.Column<bool>(type: "bit", nullable: false),
                    BANK_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    BANKAGENCY = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    PAYERREFERENCE = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    PRINTED = table.Column<int>(type: "int", nullable: false),
                    CODE_AGENCE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PAYMENT", x => x.PAYMENT_CODE);
                });

            migrationBuilder.CreateTable(
                name: "PAYMENTTERM",
                columns: table => new
                {
                    PAYMENTTERM_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    DISCOUNT = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    RANK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PAYMENTTERM", x => x.PAYMENTTERM_CODE);
                });

            migrationBuilder.CreateTable(
                name: "POSITION_GPS",
                columns: table => new
                {
                    CODE_INSTALLATION = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    READINGORDERCODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LATITUDE = table.Column<double>(type: "float", nullable: true),
                    LONGITUDE = table.Column<double>(type: "float", nullable: true),
                    ALTITUDE = table.Column<double>(type: "float", nullable: true),
                    CODE_AGENCE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IMAGE = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    MARICULE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    TELEPHONE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_POSITION_GPS", x => new { x.CODE_INSTALLATION, x.READINGORDERCODE });
                });

            migrationBuilder.CreateTable(
                name: "prmASSABILFUNCTION",
                columns: table => new
                {
                    ASSABILFUNCTION_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prmASSABILFUNCTION", x => x.ASSABILFUNCTION_CODE);
                });

            migrationBuilder.CreateTable(
                name: "prmREADINGORDERRESULT",
                columns: table => new
                {
                    READINGORDERRESULT_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_READINGORDERRESULT", x => x.READINGORDERRESULT_CODE);
                });

            migrationBuilder.CreateTable(
                name: "PRODUCTCATEGORY",
                columns: table => new
                {
                    PRODUCTCATEGORY_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    RANK = table.Column<int>(type: "int", nullable: false),
                    UPPRODUCTCATEGORY_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITEMCATEGORY", x => x.PRODUCTCATEGORY_CODE);
                });

            migrationBuilder.CreateTable(
                name: "PRODUCTSALESGROUP",
                columns: table => new
                {
                    PRODUCTSALESGROUP_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITEMSALESGROUP", x => x.PRODUCTSALESGROUP_CODE);
                });

            migrationBuilder.CreateTable(
                name: "PROFILE",
                columns: table => new
                {
                    PROFILE_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PROFILE", x => x.PROFILE_CODE);
                });

            migrationBuilder.CreateTable(
                name: "RECLAMATION",
                columns: table => new
                {
                    RECLAMATION_ID = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    LAST_NAME = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    PHONE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CONTRACT_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    DESCRIPTION = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    AGENT = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CODE_AGENCE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RECLAMATION", x => x.RECLAMATION_ID);
                });

            migrationBuilder.CreateTable(
                name: "sapREADING_ORDER",
                columns: table => new
                {
                    DOCUMENT_NUMBER = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    BATCH_NUMBER = table.Column<int>(type: "int", nullable: false),
                    READING_ORDER_REASON = table.Column<decimal>(type: "numeric(2,0)", nullable: false),
                    DEVICE_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    AGENCY_CODE = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    SEQUENCE = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    INPUT_KEY = table.Column<decimal>(type: "numeric(8,0)", nullable: false),
                    CONTROL_KEY = table.Column<decimal>(type: "numeric(2,0)", nullable: true),
                    READING_ORDER_UNIT_SEQUENCE = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    LOCATION = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    POSTAL_CODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    STREET = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    NUMBER = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    USUAL_STREET = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    INTERNAL_COUNTER = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    LASTNAME = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    FIRSTNAME = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CONTRACT_CODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    INSTALLATION = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    EQPT_SERIAL_NUMBER = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: false),
                    EQPT_TYPE = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: false),
                    EQPT_FACTORY_SERIAL_NUMBER = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    INFORMATION = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    COEFFICIENT = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    READING_ORDER_STARTDATE = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    READING_ORDER_ENDDATE = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    PREVIOUS_INDEX = table.Column<decimal>(type: "numeric(17,0)", nullable: false),
                    PREVIOUS_INDEX_DATE = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    PREVIOUS_INDEX_REASON = table.Column<decimal>(type: "numeric(2,0)", nullable: false),
                    ENVISAGED_INDEX = table.Column<decimal>(type: "numeric(17,0)", nullable: false),
                    MAXIMUM_INDEX = table.Column<decimal>(type: "numeric(17,0)", nullable: false),
                    MINIMUM_INDEX = table.Column<decimal>(type: "numeric(17,0)", nullable: false),
                    EXTRACTION_DATE = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    TRANSFER_DATE = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    NEW_INDEX = table.Column<decimal>(type: "numeric(17,0)", nullable: true),
                    NEW_INDEX_DATE = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    PERSON_CODE = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    PERSON_NOTICE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    EXTERNAL_REFERENCE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CODE_AGENCE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SINVOICE_LINE",
                columns: table => new
                {
                    SINVOICE_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SINVOICE_LINE_NUMBER = table.Column<int>(type: "int", nullable: false),
                    PRODUCT_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    QUANTITY = table.Column<decimal>(type: "decimal(14,3)", nullable: false),
                    RETURNEDQUANTITY = table.Column<decimal>(type: "decimal(14,3)", nullable: false),
                    DAMAGEDQUANTITY = table.Column<decimal>(type: "decimal(14,3)", nullable: false),
                    FREEQUANTITY = table.Column<decimal>(type: "decimal(14,3)", nullable: false),
                    UNITPRICE = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    VAT1 = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    VAT2 = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    DESCRIPTION = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    REQUESTEDDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    CONFIRMEDDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    DISCOUNT1 = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    DISCOUNT2 = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    DISCOUNT3 = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    DISCOUNT4 = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    SOLDOUT = table.Column<bool>(type: "bit", nullable: false),
                    USERFIELD1 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    USERFIELD2 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    NETUNITPRICE = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    PROMORATE = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    CODE_AGENCE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SINVOICE_LINE", x => new { x.SINVOICE_CODE, x.SINVOICE_LINE_NUMBER });
                });

            migrationBuilder.CreateTable(
                name: "TMP_PAYMENT",
                columns: table => new
                {
                    PAYMENT_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    AMOUNT = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
                    CODE_AGENCE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TMP_PERFORMANCE",
                columns: table => new
                {
                    ITINERAR_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    COMPTER_NUMBER = table.Column<int>(type: "int", nullable: true),
                    TAUXRELVE = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    INSTALLATIONNULL_NUMBER = table.Column<int>(type: "int", nullable: true),
                    ANNOMALIE_NUMBER = table.Column<int>(type: "int", nullable: true),
                    PERSON_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    STARTDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    ENDDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    CODE_AGENCE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TMP_SITUATIONPERFORMANCE",
                columns: table => new
                {
                    PERSON_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ITINERARY_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    STARTDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    ENDDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    UNITERELEVE_NUMBER = table.Column<int>(type: "int", nullable: true),
                    RELEVE_NUMBER = table.Column<int>(type: "int", nullable: true),
                    TAUX_RELEVE = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    CODE_AGENCE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TOKENSERIE",
                columns: table => new
                {
                    TOKENSERIE_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    DIGITSINCOUNTER = table.Column<int>(type: "int", nullable: false),
                    INVOICEPREFIX = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    INVOICENEXTNUMBER = table.Column<int>(type: "int", nullable: false),
                    PAYMENTPREFIX = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    PAYMENTNEXTNUMBER = table.Column<int>(type: "int", nullable: false),
                    VISITPREFIX = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    VISITNEXTNUMBER = table.Column<int>(type: "int", nullable: false),
                    LOADPREFIX = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    LOADNEXTNUMBER = table.Column<int>(type: "int", nullable: false),
                    ORDERPREFIX = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    ORDERNEXTNUMBER = table.Column<int>(type: "int", nullable: false),
                    DELNOTEPREFIX = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    DELNOTENEXTNUMBER = table.Column<int>(type: "int", nullable: false),
                    ROUNDPREFIX = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    ROUNDNEXTNUMBER = table.Column<int>(type: "int", nullable: false),
                    EXPENSEPREFIX = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    EXPENSENEXTNUMBER = table.Column<int>(type: "int", nullable: false),
                    INVENTORYPREFIX = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    INVENTORYNEXTNUMBER = table.Column<int>(type: "int", nullable: false),
                    PROJECTPREFIX = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    PROJECTNEXTNUMBER = table.Column<int>(type: "int", nullable: false),
                    FACINGPREFIX = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    FACINGNEXTNUMBER = table.Column<int>(type: "int", nullable: false),
                    INTERVIEWPREFIX = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    INTERVIEWNEXTNUMBER = table.Column<int>(type: "int", nullable: false),
                    PARTNERPREFIX = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    PARTNERNEXTNUMBER = table.Column<int>(type: "int", nullable: false),
                    EQUIPMENTPREFIX = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    EQUIPMENTNEXTNUMBER = table.Column<int>(type: "int", nullable: false),
                    WM_REQUESTPREFIX = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    WM_REQUESTNEXTNUMBER = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TOKENSERIE", x => x.TOKENSERIE_CODE);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Matricule = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NomUtilisateur = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MotDePasse = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Telephone = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Prenom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateCreation = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    DateDerniereConnexion = table.Column<DateTime>(type: "datetime", nullable: true),
                    Actif = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    Code_agence = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Users__3214EC075A2672A1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WORKORDERBATCH",
                columns: table => new
                {
                    WORKORDERBATCH_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    THEDATE = table.Column<DateTime>(type: "datetime", nullable: false),
                    WORKSTATION_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    WORKORDERBATCHTYPE_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    WORKORDERBATCHSTATUS_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CODE_AGENCE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WORKORDERBATCH", x => x.WORKORDERBATCH_CODE);
                });

            migrationBuilder.CreateTable(
                name: "GEOAREA",
                columns: table => new
                {
                    GEOAREA_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    UPGEOAREA_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    GEOOBJECT_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    NOTES = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: true),
                    USERFIELD1 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    USERFIELD2 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    CODE_AGENCE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LOCATION", x => x.GEOAREA_CODE);
                    table.ForeignKey(
                        name: "FK_GEOAREA_GEOAREA",
                        column: x => x.UPGEOAREA_CODE,
                        principalTable: "GEOAREA",
                        principalColumn: "GEOAREA_CODE");
                    table.ForeignKey(
                        name: "FK_GEOAREA_GEOOBJECT",
                        column: x => x.GEOOBJECT_CODE,
                        principalTable: "GEOOBJECT",
                        principalColumn: "GEOOBJECT_CODE");
                });

            migrationBuilder.CreateTable(
                name: "GEOOBJECT_BORDER",
                columns: table => new
                {
                    GEOOBJECT_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    RANK = table.Column<int>(type: "int", nullable: false),
                    X = table.Column<int>(type: "int", nullable: false),
                    Y = table.Column<int>(type: "int", nullable: false),
                    Z = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GEOAREA_BORDER", x => new { x.GEOOBJECT_CODE, x.RANK });
                    table.ForeignKey(
                        name: "FK_GEOOBJECT_BORDER_GEOOBJECT",
                        column: x => x.GEOOBJECT_CODE,
                        principalTable: "GEOOBJECT",
                        principalColumn: "GEOOBJECT_CODE");
                });

            migrationBuilder.CreateTable(
                name: "GEOPLAN_BACKGROUNDIMAGE",
                columns: table => new
                {
                    GEOPLAN_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    BACKGROUNDIMAGE_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ISSELECTED = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CODE_AGENCE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GEOPLAN_BACKGROUNDIMAGE", x => new { x.GEOPLAN_CODE, x.BACKGROUNDIMAGE_CODE });
                    table.ForeignKey(
                        name: "FK_GEOPLAN_BACKGROUNDIMAGE_BACKGROUNDIMAGE",
                        column: x => x.BACKGROUNDIMAGE_CODE,
                        principalTable: "BACKGROUNDIMAGE",
                        principalColumn: "BACKGROUNDIMAGE_CODE");
                    table.ForeignKey(
                        name: "FK_GEOPLAN_BACKGROUNDIMAGE_GEOPLAN1",
                        column: x => x.GEOPLAN_CODE,
                        principalTable: "GEOPLAN",
                        principalColumn: "GEOPLAN_CODE");
                });

            migrationBuilder.CreateTable(
                name: "GEOPLAN_GEOOBJECT",
                columns: table => new
                {
                    GEOPLAN_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    GEOOBJECT_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ISSELECTED = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CODE_AGENCE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GEOPLAN_GEOOBJECT", x => new { x.GEOPLAN_CODE, x.GEOOBJECT_CODE });
                    table.ForeignKey(
                        name: "FK_GEOPLAN_GEOOBJECT_GEOOBJECT",
                        column: x => x.GEOOBJECT_CODE,
                        principalTable: "GEOOBJECT",
                        principalColumn: "GEOOBJECT_CODE");
                    table.ForeignKey(
                        name: "FK_GEOPLAN_GEOOBJECT_GEOPLAN",
                        column: x => x.GEOPLAN_CODE,
                        principalTable: "GEOPLAN",
                        principalColumn: "GEOPLAN_CODE");
                });

            migrationBuilder.CreateTable(
                name: "ROUND",
                columns: table => new
                {
                    ROUND_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    BRANCH_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ITINERARY_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    WORKSTATION_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PERSON_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ATTENDEDBYPERSON_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ATTENDEDBY2PERSON_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    STARTTIME = table.Column<DateTime>(type: "datetime", nullable: false),
                    ENDTIME = table.Column<DateTime>(type: "datetime", nullable: true),
                    DEPARTURETIME = table.Column<DateTime>(type: "datetime", nullable: true),
                    RETURNTIME = table.Column<DateTime>(type: "datetime", nullable: true),
                    DEPARTUREMILAGE = table.Column<int>(type: "int", nullable: true),
                    RETURNMILAGE = table.Column<int>(type: "int", nullable: true),
                    ASSET_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    PROGRESSLEVEL = table.Column<int>(type: "int", nullable: false),
                    TRANSERDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    TRANSERBATCH_CODE = table.Column<int>(type: "int", nullable: true),
                    CODE_AGENCE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ROUND", x => x.ROUND_CODE);
                    table.ForeignKey(
                        name: "FK_ROUND_COMPANY",
                        column: x => x.BRANCH_CODE,
                        principalTable: "BRANCH",
                        principalColumn: "BRANCH_CODE");
                    table.ForeignKey(
                        name: "FK_ROUND_ITINERARY",
                        column: x => x.ITINERARY_CODE,
                        principalTable: "ITINERARY",
                        principalColumn: "ITINERARY_CODE");
                });

            migrationBuilder.CreateTable(
                name: "SINVOICE",
                columns: table => new
                {
                    SINVOICE_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PARTNER_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    AMOUNT = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    DUEAMOUNT = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    FIXEDTAXAMOUNT = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    REQUESTEDDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    THEDATE = table.Column<DateTime>(type: "datetime", nullable: false),
                    CONTRACTACCOUNT = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CONTRACT_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CONTACT_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    PERSON_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PRODUCTSALESGROUP_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PROJECT_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    WAREHOUSE_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CURRENCY_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PAYMENTTERM_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CONFIRMEDDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    SINVOICETYPE_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    SINVOICESTATUS_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    DESCRIPTION = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    EXTERNALREFERENCE1 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    EXTERNALREFERENCE2 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    EXONERATIONREFERENCE = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    DISCOUNT1 = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    DISCOUNT2 = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    DISCOUNT3 = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    DISCOUNT4 = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    FINALDISCOUNT = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    FINALDISCOUNTRATE = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    VAT1AMOUNT = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    VAT2AMOUNT = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    EMPTYAMOUNT = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    CONSIGNMENTTYPE = table.Column<int>(type: "int", nullable: false),
                    PRINTINGACCOUNT = table.Column<int>(type: "int", nullable: true),
                    CANCELED = table.Column<bool>(type: "bit", nullable: false),
                    SUPPLIER_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ROUND_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    VISIT_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    PROGRESSLEVEL = table.Column<int>(type: "int", nullable: false),
                    CLOSED = table.Column<bool>(type: "bit", nullable: false),
                    USERFIELD1 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    USERFIELD2 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    SECURITYLEVEL = table.Column<int>(type: "int", nullable: false),
                    LASTUPDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    USER_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    TRACKINGKEY = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    SORDER_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    PAYMENT_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ITINERARY_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CODE_AGENCE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SINVOICE", x => x.SINVOICE_CODE);
                    table.ForeignKey(
                        name: "FK_SINVOICE_ITINERARY",
                        column: x => x.ITINERARY_CODE,
                        principalTable: "ITINERARY",
                        principalColumn: "ITINERARY_CODE");
                });

            migrationBuilder.CreateTable(
                name: "LANGUAGE_TABLEFIELDATTRIBUTE",
                columns: table => new
                {
                    LANGUAGE_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    TABLENAME = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    FIELDNAME = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    FIELDLABEL = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    FIELDHELP = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prm_FIELD_LANGUAGE_ATTRIBUTE", x => new { x.LANGUAGE_CODE, x.TABLENAME, x.FIELDNAME });
                    table.ForeignKey(
                        name: "FK_LANGUAGE_TABLEFIELDATTRIBUTE_LANGUAGE",
                        column: x => x.LANGUAGE_CODE,
                        principalTable: "LANGUAGE",
                        principalColumn: "LANGUAGE_CODE");
                });

            migrationBuilder.CreateTable(
                name: "PARTNERCATEGORYTYPE",
                columns: table => new
                {
                    PARTNERCATEGORY_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PARTNERCATEGORYTYPE_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    RANK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PARTNERCATEGORYTYPE", x => new { x.PARTNERCATEGORY_CODE, x.PARTNERCATEGORYTYPE_CODE });
                    table.ForeignKey(
                        name: "FK_PARTNERCATEGORYTYPE_PARTNERCATEGORY",
                        column: x => x.PARTNERCATEGORY_CODE,
                        principalTable: "PARTNERCATEGORY",
                        principalColumn: "PARTNERCATEGORY_CODE");
                });

            migrationBuilder.CreateTable(
                name: "READINGORDERRESULTNOTE",
                columns: table => new
                {
                    READINGORDERRESULT_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    READINGORDERRESULTNOTE_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Categorie = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    NoticeCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    NoticeText = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NoticeType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_READINGORDERRESULTNOTICE", x => new { x.READINGORDERRESULT_CODE, x.READINGORDERRESULTNOTE_CODE });
                    table.ForeignKey(
                        name: "FK_READINGORDERRESULTNOTE_prmREADINGORDERRESULT",
                        column: x => x.READINGORDERRESULT_CODE,
                        principalTable: "prmREADINGORDERRESULT",
                        principalColumn: "READINGORDERRESULT_CODE");
                });

            migrationBuilder.CreateTable(
                name: "PRODUCTCATEGORY_ATTRIBUTE",
                columns: table => new
                {
                    PRODUCTCATEGORY_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ATTRIBUTE_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    COEFFICIENT = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    STOREDPROCEDURENAME = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    MINIMUMVAUE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MAXIMUMVALUE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DEFAULTVALUE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITEMCATEGORY_ATTRIBUTE", x => new { x.PRODUCTCATEGORY_CODE, x.ATTRIBUTE_CODE });
                    table.ForeignKey(
                        name: "FK_PRODUCTCATEGORY_ATTRIBUTE_PRODUCTCATEGORY",
                        column: x => x.PRODUCTCATEGORY_CODE,
                        principalTable: "PRODUCTCATEGORY",
                        principalColumn: "PRODUCTCATEGORY_CODE");
                });

            migrationBuilder.CreateTable(
                name: "PRODUCTCATEGORYTYPE",
                columns: table => new
                {
                    PRODUCTCATEGORY_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PRODUCTCATEGORYTYPE_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    RANK = table.Column<int>(type: "int", nullable: false),
                    ICON = table.Column<byte[]>(type: "image", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITEMCATEGORYTYPE", x => new { x.PRODUCTCATEGORY_CODE, x.PRODUCTCATEGORYTYPE_CODE });
                    table.ForeignKey(
                        name: "FK_PRODUCTCATEGORYTYPE_PRODUCTCATEGORY",
                        column: x => x.PRODUCTCATEGORY_CODE,
                        principalTable: "PRODUCTCATEGORY",
                        principalColumn: "PRODUCTCATEGORY_CODE");
                });

            migrationBuilder.CreateTable(
                name: "COMPANY_PRODUCTSALESGROUP",
                columns: table => new
                {
                    BRANCH_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PRODUCTSALESGROUP_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    HEADER1 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    HEADER2 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    HEADER3 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    HEADER4 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    HEADER5 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    HEADER6 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    FOOTER1 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    FOOTER2 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    FOOTER3 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    FOOTER4 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    FOOTER5 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    FOOTER6 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    CODE_AGENCE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMPANY", x => new { x.BRANCH_CODE, x.PRODUCTSALESGROUP_CODE });
                    table.ForeignKey(
                        name: "FK_COMPANY_PRODUCTSALESGROUP_COMPANY",
                        column: x => x.BRANCH_CODE,
                        principalTable: "BRANCH",
                        principalColumn: "BRANCH_CODE");
                    table.ForeignKey(
                        name: "FK_COMPANY_PRODUCTSALESGROUP_PRODUCTSALESGROUP",
                        column: x => x.PRODUCTSALESGROUP_CODE,
                        principalTable: "PRODUCTSALESGROUP",
                        principalColumn: "PRODUCTSALESGROUP_CODE");
                });

            migrationBuilder.CreateTable(
                name: "PERSON",
                columns: table => new
                {
                    PERSON_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    FIRSTNAME = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    PROFILE_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PHONE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CELLULARPHONE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    FAX = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    EMAIL = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    PASSWORD = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    LANGUAGE_CODE = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    REQUIREDCONTROLNUMBER = table.Column<int>(type: "int", nullable: false),
                    HOLD = table.Column<bool>(type: "bit", nullable: false),
                    HOLD_REASON = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    USERFIELD1 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    USERFIELD2 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    SECURITYLEVEL = table.Column<int>(type: "int", nullable: false),
                    LASTUPDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    USER_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CODE_AGENCE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PERSON", x => x.PERSON_CODE);
                    table.ForeignKey(
                        name: "FK_PERSON_PROFILE",
                        column: x => x.PROFILE_CODE,
                        principalTable: "PROFILE",
                        principalColumn: "PROFILE_CODE");
                });

            migrationBuilder.CreateTable(
                name: "PROFILE_ASSABILFUNCTION",
                columns: table => new
                {
                    PROFILE_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ASSABILFUNCTION_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PROFILE_ASSABILFUNCTION", x => new { x.PROFILE_CODE, x.ASSABILFUNCTION_CODE });
                    table.ForeignKey(
                        name: "FK_PROFILE_ASSABILFUNCTION_PROFILE",
                        column: x => x.PROFILE_CODE,
                        principalTable: "PROFILE",
                        principalColumn: "PROFILE_CODE");
                    table.ForeignKey(
                        name: "FK_PROFILE_ASSABILFUNCTION_prmASSABILFUNCTION",
                        column: x => x.ASSABILFUNCTION_CODE,
                        principalTable: "prmASSABILFUNCTION",
                        principalColumn: "ASSABILFUNCTION_CODE");
                });

            migrationBuilder.CreateTable(
                name: "PROFILE_TABLEATTRIBUTE",
                columns: table => new
                {
                    PROFILE_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    TABLENAME = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    READROWS = table.Column<bool>(type: "bit", nullable: false),
                    INSERTROWS = table.Column<bool>(type: "bit", nullable: false),
                    MODIFYROWS = table.Column<bool>(type: "bit", nullable: false),
                    DELETEROWS = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prmPROFILE_TABLEATTRIBUTE", x => new { x.PROFILE_CODE, x.TABLENAME });
                    table.ForeignKey(
                        name: "FK_PROFILE_TABLEATTRIBUTE_PROFILE",
                        column: x => x.PROFILE_CODE,
                        principalTable: "PROFILE",
                        principalColumn: "PROFILE_CODE");
                });

            migrationBuilder.CreateTable(
                name: "READINGORDER",
                columns: table => new
                {
                    READINGORDER_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    WORKORDERBATCH_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    READINGORDERTYPE_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ITINERARY_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, defaultValue: "xxx"),
                    SEQUENCE = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    CREATIONDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    STARTDATE = table.Column<DateTime>(type: "datetime", nullable: false),
                    ENDDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    PREVIOUSINDEX = table.Column<decimal>(type: "numeric(17,0)", nullable: false),
                    PREVIOUSINDEXDATE = table.Column<DateTime>(type: "datetime", nullable: false),
                    PREVIOUSINDEXREASON_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ENVISAGEDINDEX = table.Column<decimal>(type: "numeric(17,0)", nullable: false),
                    MAXIMUMINDEX = table.Column<decimal>(type: "numeric(17,0)", nullable: false),
                    MINIMUMINDEX = table.Column<decimal>(type: "numeric(17,0)", nullable: false),
                    NEWINDEX = table.Column<decimal>(type: "numeric(17,0)", nullable: true),
                    NEWINDEXDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    EXECUTEDBYPERSON_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ROUND_CODE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NUM = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    STREETNAME1 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    STREETNAME2 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    POSTALCODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CITY = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    INTERNAL_COUNTER = table.Column<bool>(type: "bit", nullable: true),
                    NAME = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    NAME2 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CONTRACT_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    INSTALLATION_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PRICELIST_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ASSET_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PRODUCT_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SERIALNUMBER = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    INFORMATION = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    EXTERNALREFERENCE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    READINGORDERRESULT_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    READINGORDERRESULTNOTE_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    DIGITSNUMBER = table.Column<int>(type: "int", nullable: false),
                    COEFFICIENT = table.Column<decimal>(type: "decimal(9,4)", nullable: false),
                    ZWNUMMER = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ZPRUEFKL = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ZZWTYP = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ZKENNZIFF = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ZWERT1 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_READINGORDER", x => x.READINGORDER_CODE);
                    table.ForeignKey(
                        name: "FK_READINGORDER_ITINERARY",
                        column: x => x.ITINERARY_CODE,
                        principalTable: "ITINERARY",
                        principalColumn: "ITINERARY_CODE");
                    table.ForeignKey(
                        name: "FK_READINGORDER_WORKORDERBATCH",
                        column: x => x.WORKORDERBATCH_CODE,
                        principalTable: "WORKORDERBATCH",
                        principalColumn: "WORKORDERBATCH_CODE");
                });

            migrationBuilder.CreateTable(
                name: "PRODUCTCATEGORY_ATTRIBUTE_LOV",
                columns: table => new
                {
                    PRODUCTCATEGORY_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ATTRIBUTE_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ATTRIBUTETEXTVALUE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ATTRIBUTETEXTVALUENOTATION = table.Column<decimal>(type: "decimal(18,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITEMCATEGORY_ATTRIBUTE_LOV", x => new { x.PRODUCTCATEGORY_CODE, x.ATTRIBUTE_CODE, x.ATTRIBUTETEXTVALUE });
                    table.ForeignKey(
                        name: "FK_PRODUCTCATEGORY_ATTRIBUTE_LOV_PRODUCTCATEGORY_ATTRIBUTE",
                        columns: x => new { x.PRODUCTCATEGORY_CODE, x.ATTRIBUTE_CODE },
                        principalTable: "PRODUCTCATEGORY_ATTRIBUTE",
                        principalColumns: new[] { "PRODUCTCATEGORY_CODE", "ATTRIBUTE_CODE" });
                });

            migrationBuilder.CreateTable(
                name: "PRODUCT",
                columns: table => new
                {
                    PRODUCT_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    RANK = table.Column<int>(type: "int", nullable: false),
                    LONGDESCRIPTION = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    BRAND_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    PRODUCTSALESGROUP_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PRODUCTPAGE_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PRODUCTGROUP_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PRODUCTCATEGORY_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    PRODUCTCATEGORYTYPE_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    PRODUCTANALYSISGROUP1_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    PRODUCTANALYSISGROUP2_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    PRODUCTANALYSISGROUP3_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    PRODUCTANALYSISGROUP4_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    PRODUCTANALYSISGROUP5_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    UNIT_CODE = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    MANAGEMENTMODE_CODE = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    ACCOUNT_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    DELIVERYLEADTIME = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    PURCHASEPRICE = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    PURCHASEDISCOUNT = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    SHIPMENTCOST = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    NETPURCHASEPRICE = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    SALESMARGIN = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    SALESPRICE = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    RETURNPRICE = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    SALESDISCOUNT = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    NETSALESPRICE = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    AWP = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    VAT1_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    VAT2_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    THE_RATE = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    CUSTOMS_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    SUPPLIERREFERENCE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    HOLD = table.Column<bool>(type: "bit", nullable: false),
                    HOLD_REASON = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    PACKING = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    SALABLE = table.Column<bool>(type: "bit", nullable: false),
                    RETURNABLE = table.Column<bool>(type: "bit", nullable: false),
                    EXPIRABLE = table.Column<bool>(type: "bit", nullable: false),
                    INVENTORYABLE = table.Column<bool>(type: "bit", nullable: false),
                    PRESENCECHECKABLE = table.Column<bool>(type: "bit", nullable: false),
                    FACINGABLE = table.Column<bool>(type: "bit", nullable: false),
                    APOS = table.Column<bool>(type: "bit", nullable: false),
                    FREEGOOD = table.Column<bool>(type: "bit", nullable: false),
                    EQUIPMENT = table.Column<bool>(type: "bit", nullable: false),
                    VIRTUALPRODUCT = table.Column<bool>(type: "bit", nullable: false),
                    PROMOSEQUENCE = table.Column<int>(type: "int", nullable: false),
                    PROMORATE = table.Column<decimal>(type: "decimal(18,4)", nullable: false, defaultValue: 1m),
                    EMPTYPRODUCT = table.Column<bool>(type: "bit", nullable: false),
                    SPACEREQUIREMENT = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    WEIGHT = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    VOLUME = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    STATUNITRATE = table.Column<decimal>(type: "decimal(18,4)", nullable: false, defaultValue: 1m),
                    USERFIELD1 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    USERFIELD2 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    SECURITYLEVEL = table.Column<int>(type: "int", nullable: true),
                    LASTUPDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    USER_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITEM", x => x.PRODUCT_CODE);
                    table.ForeignKey(
                        name: "FK_PRODUCT_PRODUCTCATEGORYTYPE",
                        columns: x => new { x.PRODUCTPAGE_CODE, x.PRODUCTGROUP_CODE },
                        principalTable: "PRODUCTCATEGORYTYPE",
                        principalColumns: new[] { "PRODUCTCATEGORY_CODE", "PRODUCTCATEGORYTYPE_CODE" });
                });

            migrationBuilder.CreateTable(
                name: "PROFILE_TABLEFIELDATTRIBUTE",
                columns: table => new
                {
                    PROFILE_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    TABLENAME = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    FIELDNAME = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    READONLY = table.Column<bool>(type: "bit", nullable: false),
                    INSERTONLY = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PROFILE_TABLEFIELDATTRIBUTE", x => new { x.PROFILE_CODE, x.TABLENAME, x.FIELDNAME });
                    table.ForeignKey(
                        name: "FK_PROFILE_TABLEFIELDATTRIBUTE_PROFILE_TABLEATTRIBUTE",
                        columns: x => new { x.PROFILE_CODE, x.TABLENAME },
                        principalTable: "PROFILE_TABLEATTRIBUTE",
                        principalColumns: new[] { "PROFILE_CODE", "TABLENAME" });
                });

            migrationBuilder.CreateTable(
                name: "ASSET",
                columns: table => new
                {
                    ASSET_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    PRODUCT_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ASSETSTATUS_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    UPASSET_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    WORKSITE_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    WORKSTATION_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    MANGEMENTWORKSTATION_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    SERIALNUMBER = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    BARCODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    NOTES = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    INSTALLATIONDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    GARANTIEENDDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    GARANTIECONDITION = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    GARANTIEPARTNER_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    GARANTIECONTACT_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    COSTCENTER_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    PORDER_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    PDELNOTE_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    SDELNOTE_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    AQUISITIONMODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ACCOUNT_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    INITIALVALUE = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
                    PURCHASEDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    DPRMODEID = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    DPRSTARTDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    DPRBASE = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
                    CLOSED = table.Column<bool>(type: "bit", nullable: false),
                    USERFIELD1 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    USERFIELD2 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    SECURITYLEVEL = table.Column<int>(type: "int", nullable: true),
                    LASTUPDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    USER_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CODE_AGENCE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ASSET", x => x.ASSET_CODE);
                    table.ForeignKey(
                        name: "FK_ASSET_ASSET",
                        column: x => x.UPASSET_CODE,
                        principalTable: "ASSET",
                        principalColumn: "ASSET_CODE");
                    table.ForeignKey(
                        name: "FK_ASSET_PRODUCT",
                        column: x => x.PRODUCT_CODE,
                        principalTable: "PRODUCT",
                        principalColumn: "PRODUCT_CODE");
                });

            migrationBuilder.CreateTable(
                name: "ASSET_ATTRIBUTE",
                columns: table => new
                {
                    ASSET_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ATTRIBUTE_CODE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ATTRIBUTENUMERICTVALUE = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
                    ATTRIBUTETEXTVALUE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ATTRIBUTEDATEVALUE = table.Column<DateTime>(type: "datetime", nullable: true),
                    LASTUPDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    CODE_AGENCE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ASSET_ATTRIBUTE", x => new { x.ASSET_CODE, x.ATTRIBUTE_CODE });
                    table.ForeignKey(
                        name: "FK_ASSET_ATTRIBUTE_ASSET",
                        column: x => x.ASSET_CODE,
                        principalTable: "ASSET",
                        principalColumn: "ASSET_CODE");
                });

            migrationBuilder.CreateTable(
                name: "CONTACT",
                columns: table => new
                {
                    CONTACT_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    MR_MS = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    FIRSTNAME = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    CONTACTCATEGORY_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CONTACTTYPE_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PARTNER_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    JOBTITLE_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PARTNER_DEPARTMENT_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PERSON_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SPECIFICADDRESS = table.Column<bool>(type: "bit", nullable: false),
                    ADDRESS = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    ZIPCODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CITY = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    STATE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    COUNTRY = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PHONE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    FAX = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    EMAIL = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    CELLULARPHONE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PERSONALPHONE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ASSISTANTNAME = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ASSISTANTPHONE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    NOTES = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    USERFIELD1 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    USERFIELD2 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    SECURITYLEVEL = table.Column<int>(type: "int", nullable: false),
                    LASTUPDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    USER_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CODE_AGENCE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONTACT", x => x.CONTACT_CODE);
                });

            migrationBuilder.CreateTable(
                name: "CONTRACT",
                columns: table => new
                {
                    CONTRACT_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CONTRACTCATEGORY_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CONTRACTCATEGORYTYPE_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    PARTNER_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CONTACT_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    STARTDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    ENDDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    WORKSTATION_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    EXTERNALREFERENCE1 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    EXTERNALREFERENCE2 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    DOCUMENTNAME = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    CODE_AGENCE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONTRACT", x => x.CONTRACT_CODE);
                });

            migrationBuilder.CreateTable(
                name: "INSTALLATION",
                columns: table => new
                {
                    INSTALLATION_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    INSTALLATIONCATEGORY_CODE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    INSTALLATIONCATEGORYTYPE_CODE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CONTRACT_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ASSET_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    WORKSITE_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    INSTALLATIONDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    UNINSTALLATIONDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    CLOSED = table.Column<bool>(type: "bit", nullable: false),
                    CODE_AGENCE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INSTALLATION", x => x.INSTALLATION_CODE);
                    table.ForeignKey(
                        name: "FK_INSTALLATION_ASSET",
                        column: x => x.ASSET_CODE,
                        principalTable: "ASSET",
                        principalColumn: "ASSET_CODE");
                    table.ForeignKey(
                        name: "FK_INSTALLATION_CONTRACT",
                        column: x => x.CONTRACT_CODE,
                        principalTable: "CONTRACT",
                        principalColumn: "CONTRACT_CODE");
                });

            migrationBuilder.CreateTable(
                name: "ITINERARY_LINE",
                columns: table => new
                {
                    ITINERARY_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    WORKSITE_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    RANK = table.Column<int>(type: "int", nullable: false),
                    CODE_AGENCE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITINERARY", x => new { x.ITINERARY_CODE, x.WORKSITE_CODE });
                    table.ForeignKey(
                        name: "FK_ITINERARY_LINE_ITINERARY",
                        column: x => x.ITINERARY_CODE,
                        principalTable: "ITINERARY",
                        principalColumn: "ITINERARY_CODE");
                });

            migrationBuilder.CreateTable(
                name: "PARTNER",
                columns: table => new
                {
                    PARTNER_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    NAME2 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    UPPARTNER_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ROOTPARTNER_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    PARTNERID = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    PARTNERIDTYPE_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    PARTNERCATEGORY_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PARTNERTYPE_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PARTNERSTATUS_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    NOTES = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    SALESCHANNEL_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    GEOAREA_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    RANK = table.Column<int>(type: "int", nullable: false),
                    PARTNERANALYSISGROUP1_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    PARTNERANALYSISGROUP2_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    PARTNERANALYSISGROUP3_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    PARTNERANALYSISGROUP4_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    PARTNERANALYSISGROUP5_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ADDRESS = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    ZIPCODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CITY = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    STATE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    COUNTRY = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    PHONE1 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    PHONE2 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    FAX = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    EMAIL = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    WEBADDRESS = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    WORKSTATION_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CURRENCY_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    PAYMENTTERM_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PRICELIST_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    PRICELIST2_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    PRICELIST2STARTDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    VAT1_EXONERATION = table.Column<bool>(type: "bit", nullable: false),
                    VAT2_EXONERATION = table.Column<bool>(type: "bit", nullable: false),
                    FIXEDTAX_EXONERATION = table.Column<bool>(type: "bit", nullable: false),
                    FISCALID = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    MAXIMUMCREDIT = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
                    CURRENTCREDIT = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
                    ARABICNAME = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    MAXIMUMCREDIT2 = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
                    CURRENTCREDIT2 = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
                    HOLD = table.Column<bool>(type: "bit", nullable: false),
                    HOLD_REASON = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    COMMON = table.Column<bool>(type: "bit", nullable: false),
                    USERFIELD1 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    USERFIELD2 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    SECURITYLEVEL = table.Column<int>(type: "int", nullable: false),
                    LASTUPDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    USER_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CODE_AGENCE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PARTNER", x => x.PARTNER_CODE);
                    table.ForeignKey(
                        name: "FK_PARTNER_PARTNER",
                        column: x => x.UPPARTNER_CODE,
                        principalTable: "PARTNER",
                        principalColumn: "PARTNER_CODE");
                    table.ForeignKey(
                        name: "FK_PARTNER_PARTNERCATEGORYTYPE",
                        columns: x => new { x.PARTNERCATEGORY_CODE, x.PARTNERTYPE_CODE },
                        principalTable: "PARTNERCATEGORYTYPE",
                        principalColumns: new[] { "PARTNERCATEGORY_CODE", "PARTNERCATEGORYTYPE_CODE" });
                    table.ForeignKey(
                        name: "FK_PARTNER_PARTNERIDTYPE",
                        column: x => x.PARTNERIDTYPE_CODE,
                        principalTable: "PARTNERIDTYPE",
                        principalColumn: "PARTNERIDTYPE_CODE");
                    table.ForeignKey(
                        name: "FK_PARTNER_PARTNERSTATUS",
                        column: x => x.PARTNERSTATUS_CODE,
                        principalTable: "PARTNERSTATUS",
                        principalColumn: "PARTNERSTATUS_CODE");
                });

            migrationBuilder.CreateTable(
                name: "WORKSITE",
                columns: table => new
                {
                    WORKSITE_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    WORKSITECATEGORY_CODE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    WORKSITECATEGORYTYPE_CODE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PARTNER_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    NUM = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    STREETNAME1 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    STREETNAME2 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    POSTALCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    CITY = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    STATE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    COUNTRY = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    EXTENDEDADRESS = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    PHONE1 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    PHONE2 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    FAX = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    GEOAREA_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    X = table.Column<int>(type: "int", nullable: false),
                    Y = table.Column<int>(type: "int", nullable: false),
                    Z = table.Column<int>(type: "int", nullable: false),
                    CODE_AGENCE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PARTNERSITE", x => x.WORKSITE_CODE);
                    table.ForeignKey(
                        name: "FK_PARTNERSITE_PARTNER",
                        column: x => x.PARTNER_CODE,
                        principalTable: "PARTNER",
                        principalColumn: "PARTNER_CODE");
                    table.ForeignKey(
                        name: "FK_WORKSITE_GEOAREA",
                        column: x => x.GEOAREA_CODE,
                        principalTable: "GEOAREA",
                        principalColumn: "GEOAREA_CODE");
                });

            migrationBuilder.CreateTable(
                name: "WORKSTATION",
                columns: table => new
                {
                    WORKSTATION_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    WORKSTATIONCATEGORY_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    WORKSTATIONCATEGORYTYPE_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    PHONE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    UPWORKSTATION_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    GEOAREA_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    PROFILE_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, defaultValue: "?"),
                    BRANCH_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DATABASE_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, defaultValue: "MYDOCUMENTS"),
                    WORKSITE_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, defaultValue: "?"),
                    PERSON_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ATTENDEDBYPERSON_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ATTENDEDBY2PERSON_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    BUDGET_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    MAXIMUMCREDIT = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
                    CURRENTCREDIT = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
                    MAXIMUMSTOCKVALUE = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
                    CURRENTSTOCKVALUE = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
                    USERFIELD1 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    USERFIELD2 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    SECURITYLEVEL = table.Column<int>(type: "int", nullable: true),
                    LASTUPDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    USER_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CODE_AGENCE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WORKSTATION", x => x.WORKSTATION_CODE);
                    table.ForeignKey(
                        name: "FK_WORKSTATION_COMPANY",
                        column: x => x.BRANCH_CODE,
                        principalTable: "BRANCH",
                        principalColumn: "BRANCH_CODE");
                    table.ForeignKey(
                        name: "FK_WORKSTATION_DATABASE",
                        column: x => x.DATABASE_CODE,
                        principalTable: "DATABASE",
                        principalColumn: "DATABASE_CODE");
                    table.ForeignKey(
                        name: "FK_WORKSTATION_LOCATION",
                        column: x => x.GEOAREA_CODE,
                        principalTable: "GEOAREA",
                        principalColumn: "GEOAREA_CODE");
                    table.ForeignKey(
                        name: "FK_WORKSTATION_PERSON",
                        column: x => x.PERSON_CODE,
                        principalTable: "PERSON",
                        principalColumn: "PERSON_CODE");
                    table.ForeignKey(
                        name: "FK_WORKSTATION_WORKSITE",
                        column: x => x.WORKSITE_CODE,
                        principalTable: "WORKSITE",
                        principalColumn: "WORKSITE_CODE");
                });

            migrationBuilder.CreateTable(
                name: "WORKSTATION_ITINERARY",
                columns: table => new
                {
                    WORKSTATION_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ITINERARY_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    RANK = table.Column<int>(type: "int", nullable: false),
                    CODE_AGENCE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WORKSTATION_LOCATION", x => new { x.WORKSTATION_CODE, x.ITINERARY_CODE });
                    table.ForeignKey(
                        name: "FK_WORKSTATION_ITINERARY_ITINERARY",
                        column: x => x.ITINERARY_CODE,
                        principalTable: "ITINERARY",
                        principalColumn: "ITINERARY_CODE");
                    table.ForeignKey(
                        name: "FK_WORKSTATION_ITINERARY_WORKSTATION",
                        column: x => x.WORKSTATION_CODE,
                        principalTable: "WORKSTATION",
                        principalColumn: "WORKSTATION_CODE");
                });

            migrationBuilder.CreateTable(
                name: "WORKSTATION_TOKENSERIE",
                columns: table => new
                {
                    WORKSTATION_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PRODUCTSALESGROUP_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    TOKENSERIE_CODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CODE_AGENCE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WORKSTATION_TOKENSERIE", x => new { x.WORKSTATION_CODE, x.PRODUCTSALESGROUP_CODE });
                    table.ForeignKey(
                        name: "FK_WORKSTATION_TOKENSERIE_PRODUCTSALESGROUP",
                        column: x => x.PRODUCTSALESGROUP_CODE,
                        principalTable: "PRODUCTSALESGROUP",
                        principalColumn: "PRODUCTSALESGROUP_CODE");
                    table.ForeignKey(
                        name: "FK_WORKSTATION_TOKENSERIE_TOKENSERIE",
                        column: x => x.TOKENSERIE_CODE,
                        principalTable: "TOKENSERIE",
                        principalColumn: "TOKENSERIE_CODE");
                    table.ForeignKey(
                        name: "FK_WORKSTATION_TOKENSERIE_WORKSTATION",
                        column: x => x.WORKSTATION_CODE,
                        principalTable: "WORKSTATION",
                        principalColumn: "WORKSTATION_CODE");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ASSET_MANGEMENTWORKSTATION_CODE",
                table: "ASSET",
                column: "MANGEMENTWORKSTATION_CODE");

            migrationBuilder.CreateIndex(
                name: "IX_ASSET_PRODUCT_CODE",
                table: "ASSET",
                column: "PRODUCT_CODE");

            migrationBuilder.CreateIndex(
                name: "IX_ASSET_UPASSET_CODE",
                table: "ASSET",
                column: "UPASSET_CODE");

            migrationBuilder.CreateIndex(
                name: "IX_ASSET_WORKSITE_CODE",
                table: "ASSET",
                column: "WORKSITE_CODE");

            migrationBuilder.CreateIndex(
                name: "IX_ASSET_WORKSTATION_CODE",
                table: "ASSET",
                column: "WORKSTATION_CODE");

            migrationBuilder.CreateIndex(
                name: "IX_COMPANY_PRODUCTSALESGROUP_PRODUCTSALESGROUP_CODE",
                table: "COMPANY_PRODUCTSALESGROUP",
                column: "PRODUCTSALESGROUP_CODE");

            migrationBuilder.CreateIndex(
                name: "IX_CONTACT_PARTNER_CODE",
                table: "CONTACT",
                column: "PARTNER_CODE");

            migrationBuilder.CreateIndex(
                name: "IX_CONTRACT_PARTNER_CODE",
                table: "CONTRACT",
                column: "PARTNER_CODE");

            migrationBuilder.CreateIndex(
                name: "IX_GEOAREA_GEOOBJECT_CODE",
                table: "GEOAREA",
                column: "GEOOBJECT_CODE");

            migrationBuilder.CreateIndex(
                name: "IX_GEOAREA_UPGEOAREA_CODE",
                table: "GEOAREA",
                column: "UPGEOAREA_CODE");

            migrationBuilder.CreateIndex(
                name: "IX_GEOPLAN_BACKGROUNDIMAGE_BACKGROUNDIMAGE_CODE",
                table: "GEOPLAN_BACKGROUNDIMAGE",
                column: "BACKGROUNDIMAGE_CODE");

            migrationBuilder.CreateIndex(
                name: "IX_GEOPLAN_GEOOBJECT_GEOOBJECT_CODE",
                table: "GEOPLAN_GEOOBJECT",
                column: "GEOOBJECT_CODE");

            migrationBuilder.CreateIndex(
                name: "IX_INSTALLATION_ASSET_CODE",
                table: "INSTALLATION",
                column: "ASSET_CODE");

            migrationBuilder.CreateIndex(
                name: "IX_INSTALLATION_CONTRACT_CODE",
                table: "INSTALLATION",
                column: "CONTRACT_CODE");

            migrationBuilder.CreateIndex(
                name: "IX_INSTALLATION_WORKSITE_CODE",
                table: "INSTALLATION",
                column: "WORKSITE_CODE");

            migrationBuilder.CreateIndex(
                name: "IX_ITINERARY_LINE_WORKSITE_CODE",
                table: "ITINERARY_LINE",
                column: "WORKSITE_CODE");

            migrationBuilder.CreateIndex(
                name: "IX_PARTNER_PARTNERCATEGORY_CODE_PARTNERTYPE_CODE",
                table: "PARTNER",
                columns: new[] { "PARTNERCATEGORY_CODE", "PARTNERTYPE_CODE" });

            migrationBuilder.CreateIndex(
                name: "IX_PARTNER_PARTNERIDTYPE_CODE",
                table: "PARTNER",
                column: "PARTNERIDTYPE_CODE");

            migrationBuilder.CreateIndex(
                name: "IX_PARTNER_PARTNERSTATUS_CODE",
                table: "PARTNER",
                column: "PARTNERSTATUS_CODE");

            migrationBuilder.CreateIndex(
                name: "IX_PARTNER_UPPARTNER_CODE",
                table: "PARTNER",
                column: "UPPARTNER_CODE");

            migrationBuilder.CreateIndex(
                name: "IX_PARTNER_WORKSTATION_CODE",
                table: "PARTNER",
                column: "WORKSTATION_CODE");

            migrationBuilder.CreateIndex(
                name: "IX_PERSON_PROFILE_CODE",
                table: "PERSON",
                column: "PROFILE_CODE");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUCT_PRODUCTPAGE_CODE_PRODUCTGROUP_CODE",
                table: "PRODUCT",
                columns: new[] { "PRODUCTPAGE_CODE", "PRODUCTGROUP_CODE" });

            migrationBuilder.CreateIndex(
                name: "IX_PROFILE_ASSABILFUNCTION_ASSABILFUNCTION_CODE",
                table: "PROFILE_ASSABILFUNCTION",
                column: "ASSABILFUNCTION_CODE");

            migrationBuilder.CreateIndex(
                name: "IX_READINGORDER_ITINERARY_CODE",
                table: "READINGORDER",
                column: "ITINERARY_CODE");

            migrationBuilder.CreateIndex(
                name: "IX_READINGORDER_WORKORDERBATCH_CODE",
                table: "READINGORDER",
                column: "WORKORDERBATCH_CODE");

            migrationBuilder.CreateIndex(
                name: "IX_ROUND_BRANCH_CODE",
                table: "ROUND",
                column: "BRANCH_CODE");

            migrationBuilder.CreateIndex(
                name: "IX_ROUND_ITINERARY_CODE",
                table: "ROUND",
                column: "ITINERARY_CODE");

            migrationBuilder.CreateIndex(
                name: "IX_SINVOICE_ITINERARY_CODE",
                table: "SINVOICE",
                column: "ITINERARY_CODE");

            migrationBuilder.CreateIndex(
                name: "IX_WORKSITE_GEOAREA_CODE",
                table: "WORKSITE",
                column: "GEOAREA_CODE");

            migrationBuilder.CreateIndex(
                name: "IX_WORKSITE_PARTNER_CODE",
                table: "WORKSITE",
                column: "PARTNER_CODE");

            migrationBuilder.CreateIndex(
                name: "IX_WORKSTATION_BRANCH_CODE",
                table: "WORKSTATION",
                column: "BRANCH_CODE");

            migrationBuilder.CreateIndex(
                name: "IX_WORKSTATION_DATABASE_CODE",
                table: "WORKSTATION",
                column: "DATABASE_CODE");

            migrationBuilder.CreateIndex(
                name: "IX_WORKSTATION_GEOAREA_CODE",
                table: "WORKSTATION",
                column: "GEOAREA_CODE");

            migrationBuilder.CreateIndex(
                name: "IX_WORKSTATION_PERSON_CODE",
                table: "WORKSTATION",
                column: "PERSON_CODE");

            migrationBuilder.CreateIndex(
                name: "IX_WORKSTATION_WORKSITE_CODE",
                table: "WORKSTATION",
                column: "WORKSITE_CODE");

            migrationBuilder.CreateIndex(
                name: "IX_WORKSTATION_ITINERARY_ITINERARY_CODE",
                table: "WORKSTATION_ITINERARY",
                column: "ITINERARY_CODE");

            migrationBuilder.CreateIndex(
                name: "IX_WORKSTATION_TOKENSERIE_PRODUCTSALESGROUP_CODE",
                table: "WORKSTATION_TOKENSERIE",
                column: "PRODUCTSALESGROUP_CODE");

            migrationBuilder.CreateIndex(
                name: "IX_WORKSTATION_TOKENSERIE_TOKENSERIE_CODE",
                table: "WORKSTATION_TOKENSERIE",
                column: "TOKENSERIE_CODE");

            migrationBuilder.AddForeignKey(
                name: "FK_ASSET_WORKSITE",
                table: "ASSET",
                column: "WORKSITE_CODE",
                principalTable: "WORKSITE",
                principalColumn: "WORKSITE_CODE");

            migrationBuilder.AddForeignKey(
                name: "FK_ASSET_WORKSTATION",
                table: "ASSET",
                column: "WORKSTATION_CODE",
                principalTable: "WORKSTATION",
                principalColumn: "WORKSTATION_CODE");

            migrationBuilder.AddForeignKey(
                name: "FK_ASSET_WORKSTATION1",
                table: "ASSET",
                column: "MANGEMENTWORKSTATION_CODE",
                principalTable: "WORKSTATION",
                principalColumn: "WORKSTATION_CODE");

            migrationBuilder.AddForeignKey(
                name: "FK_CONTACT_PARTNER",
                table: "CONTACT",
                column: "PARTNER_CODE",
                principalTable: "PARTNER",
                principalColumn: "PARTNER_CODE");

            migrationBuilder.AddForeignKey(
                name: "FK_CONTRACT_PARTNER",
                table: "CONTRACT",
                column: "PARTNER_CODE",
                principalTable: "PARTNER",
                principalColumn: "PARTNER_CODE");

            migrationBuilder.AddForeignKey(
                name: "FK_INSTALLATION_WORKSITE",
                table: "INSTALLATION",
                column: "WORKSITE_CODE",
                principalTable: "WORKSITE",
                principalColumn: "WORKSITE_CODE");

            migrationBuilder.AddForeignKey(
                name: "FK_ITINERARY_LINE_WORKSITE",
                table: "ITINERARY_LINE",
                column: "WORKSITE_CODE",
                principalTable: "WORKSITE",
                principalColumn: "WORKSITE_CODE");

            migrationBuilder.AddForeignKey(
                name: "FK_PARTNER_WORKSTATION",
                table: "PARTNER",
                column: "WORKSTATION_CODE",
                principalTable: "WORKSTATION",
                principalColumn: "WORKSTATION_CODE");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WORKSTATION_WORKSITE",
                table: "WORKSTATION");

            migrationBuilder.DropTable(
                name: "ASSET_ATTRIBUTE");

            migrationBuilder.DropTable(
                name: "ASSETCONFIGURATION");

            migrationBuilder.DropTable(
                name: "BANK");

            migrationBuilder.DropTable(
                name: "COMPANY_PRODUCTSALESGROUP");

            migrationBuilder.DropTable(
                name: "CONTACT");

            migrationBuilder.DropTable(
                name: "DBTABLE");

            migrationBuilder.DropTable(
                name: "GEOOBJECT_BORDER");

            migrationBuilder.DropTable(
                name: "GEOPLAN_BACKGROUNDIMAGE");

            migrationBuilder.DropTable(
                name: "GEOPLAN_GEOOBJECT");

            migrationBuilder.DropTable(
                name: "INSTALLATION");

            migrationBuilder.DropTable(
                name: "ITINERARY_LINE");

            migrationBuilder.DropTable(
                name: "LANGUAGE_TABLEFIELDATTRIBUTE");

            migrationBuilder.DropTable(
                name: "PAYMENT");

            migrationBuilder.DropTable(
                name: "PAYMENTTERM");

            migrationBuilder.DropTable(
                name: "POSITION_GPS");

            migrationBuilder.DropTable(
                name: "PRODUCTCATEGORY_ATTRIBUTE_LOV");

            migrationBuilder.DropTable(
                name: "PROFILE_ASSABILFUNCTION");

            migrationBuilder.DropTable(
                name: "PROFILE_TABLEFIELDATTRIBUTE");

            migrationBuilder.DropTable(
                name: "READINGORDER");

            migrationBuilder.DropTable(
                name: "READINGORDERRESULTNOTE");

            migrationBuilder.DropTable(
                name: "RECLAMATION");

            migrationBuilder.DropTable(
                name: "ROUND");

            migrationBuilder.DropTable(
                name: "sapREADING_ORDER");

            migrationBuilder.DropTable(
                name: "SINVOICE");

            migrationBuilder.DropTable(
                name: "SINVOICE_LINE");

            migrationBuilder.DropTable(
                name: "TMP_PAYMENT");

            migrationBuilder.DropTable(
                name: "TMP_PERFORMANCE");

            migrationBuilder.DropTable(
                name: "TMP_SITUATIONPERFORMANCE");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "WORKSTATION_ITINERARY");

            migrationBuilder.DropTable(
                name: "WORKSTATION_TOKENSERIE");

            migrationBuilder.DropTable(
                name: "BACKGROUNDIMAGE");

            migrationBuilder.DropTable(
                name: "GEOPLAN");

            migrationBuilder.DropTable(
                name: "ASSET");

            migrationBuilder.DropTable(
                name: "CONTRACT");

            migrationBuilder.DropTable(
                name: "LANGUAGE");

            migrationBuilder.DropTable(
                name: "PRODUCTCATEGORY_ATTRIBUTE");

            migrationBuilder.DropTable(
                name: "prmASSABILFUNCTION");

            migrationBuilder.DropTable(
                name: "PROFILE_TABLEATTRIBUTE");

            migrationBuilder.DropTable(
                name: "WORKORDERBATCH");

            migrationBuilder.DropTable(
                name: "prmREADINGORDERRESULT");

            migrationBuilder.DropTable(
                name: "ITINERARY");

            migrationBuilder.DropTable(
                name: "PRODUCTSALESGROUP");

            migrationBuilder.DropTable(
                name: "TOKENSERIE");

            migrationBuilder.DropTable(
                name: "PRODUCT");

            migrationBuilder.DropTable(
                name: "PRODUCTCATEGORYTYPE");

            migrationBuilder.DropTable(
                name: "PRODUCTCATEGORY");

            migrationBuilder.DropTable(
                name: "WORKSITE");

            migrationBuilder.DropTable(
                name: "PARTNER");

            migrationBuilder.DropTable(
                name: "PARTNERCATEGORYTYPE");

            migrationBuilder.DropTable(
                name: "PARTNERIDTYPE");

            migrationBuilder.DropTable(
                name: "PARTNERSTATUS");

            migrationBuilder.DropTable(
                name: "WORKSTATION");

            migrationBuilder.DropTable(
                name: "PARTNERCATEGORY");

            migrationBuilder.DropTable(
                name: "BRANCH");

            migrationBuilder.DropTable(
                name: "DATABASE");

            migrationBuilder.DropTable(
                name: "GEOAREA");

            migrationBuilder.DropTable(
                name: "PERSON");

            migrationBuilder.DropTable(
                name: "GEOOBJECT");

            migrationBuilder.DropTable(
                name: "PROFILE");
        }
    }
}
