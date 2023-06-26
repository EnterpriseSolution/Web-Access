#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  OperationRow.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.MasterData.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("MasterData"), TableName("[dbo].[GBOPER]")]
    [DisplayName("Operation"), InstanceName("Operation"), TwoLevelCached]   
    public sealed class OperationRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Op Code"), Column("OP_CODE"), Size(8), PrimaryKey, QuickSearch]
        public String OpCode
        {
            get { return Fields.OpCode[this]; }
            set { Fields.OpCode[this] = value; }
        }

        [DisplayName("Description"), Column("DESCRIPTION"), Size(40), NotNull]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Suspended"), Column("SUSPENDED"), Size(1)]
        [BoolStringConverter]
        public bool? Suspended
        {
            get { return Fields.Suspended[this]; }
            set { Fields.Suspended[this] = value; }
        }

        [DisplayName("Ticket Issued"), Column("TICKET_ISSUED"), Size(1)]
        [BoolStringConverter]
        public bool? TicketIssued
        {
            get { return Fields.TicketIssued[this]; }
            set { Fields.TicketIssued[this] = value; }
        }

        [DisplayName("Report Required"), Column("REPORT_REQUIRED"), Size(1)]
        [BoolStringConverter]
        public bool? ReportRequired
        {
            get { return Fields.ReportRequired[this]; }
            set { Fields.ReportRequired[this] = value; }
        }

        [DisplayName("Operation Type"), Column("OPER_TYPE"), Size(1)]
        public String OperType
        {
            get { return Fields.OperType[this]; }
            set { Fields.OperType[this] = value; }
        }

        [DisplayName("Production Mode"), Column("PRODN_MODE"), Size(6)]
        public String ProdnMode
        {
            get { return Fields.ProdnMode[this]; }
            set { Fields.ProdnMode[this] = value; }
        }

        [DisplayName("Work Centre"), Column("WORK_CENTRE"), Size(10)]
        public String WorkCentre
        {
            get { return Fields.WorkCentre[this]; }
            set { Fields.WorkCentre[this] = value; }
        }

        [DisplayName("Fixed Workcenter"), Column("FIXED_WCTR"), Size(1)]
        [BoolStringConverter]
        public bool? FixedWctr
        {
            get { return Fields.FixedWctr[this]; }
            set { Fields.FixedWctr[this] = value; }
        }

        [DisplayName("Min Lot Size"), Column("MIN_LOT_SIZE"), Size(10), Scale(4)]
        public Decimal? MinLotSize
        {
            get { return Fields.MinLotSize[this]; }
            set { Fields.MinLotSize[this] = value; }
        }

        [DisplayName("Std Lot Size"), Column("STD_LOT_SIZE"), Size(10), Scale(4)]
        public Decimal? StdLotSize
        {
            get { return Fields.StdLotSize[this]; }
            set { Fields.StdLotSize[this] = value; }
        }

        [DisplayName("Direct Labor"), Column("DIRECT_LABOR"), Size(4)]
        public Decimal? DirectLabor
        {
            get { return Fields.DirectLabor[this]; }
            set { Fields.DirectLabor[this] = value; }
        }

        [DisplayName("Mach Load Hr"), Column("MACH_LOAD_HR"), Size(8), Scale(4)]
        public Decimal? MachLoadHr
        {
            get { return Fields.MachLoadHr[this]; }
            set { Fields.MachLoadHr[this] = value; }
        }

        [DisplayName("Man Load Hr"), Column("MAN_LOAD_HR"), Size(8), Scale(4)]
        public Decimal? ManLoadHr
        {
            get { return Fields.ManLoadHr[this]; }
            set { Fields.ManLoadHr[this] = value; }
        }

        [DisplayName("Mach Process Hr"), Column("MACH_PROCESS_HR"), Size(8), Scale(4)]
        public Decimal? MachProcessHr
        {
            get { return Fields.MachProcessHr[this]; }
            set { Fields.MachProcessHr[this] = value; }
        }

        [DisplayName("Man Process Hr"), Column("MAN_PROCESS_HR"), Size(8), Scale(4)]
        public Decimal? ManProcessHr
        {
            get { return Fields.ManProcessHr[this]; }
            set { Fields.ManProcessHr[this] = value; }
        }

        [DisplayName("Mach Unload Hr"), Column("MACH_UNLOAD_HR"), Size(8), Scale(4)]
        public Decimal? MachUnloadHr
        {
            get { return Fields.MachUnloadHr[this]; }
            set { Fields.MachUnloadHr[this] = value; }
        }

        [DisplayName("Man Unload Hr"), Column("MAN_UNLOAD_HR"), Size(8), Scale(4)]
        public Decimal? ManUnloadHr
        {
            get { return Fields.ManUnloadHr[this]; }
            set { Fields.ManUnloadHr[this] = value; }
        }

        [DisplayName("Machine Cost"), Column("MACHINE_COST"), Size(18), Scale(6)]
        public Decimal? MachineCost
        {
            get { return Fields.MachineCost[this]; }
            set { Fields.MachineCost[this] = value; }
        }

        [DisplayName("Energy Cost"), Column("ENERGY_COST"), Size(18), Scale(6)]
        public Decimal? EnergyCost
        {
            get { return Fields.EnergyCost[this]; }
            set { Fields.EnergyCost[this] = value; }
        }

        [DisplayName("Water Cost"), Column("WATER_COST"), Size(18), Scale(6)]
        public Decimal? WaterCost
        {
            get { return Fields.WaterCost[this]; }
            set { Fields.WaterCost[this] = value; }
        }

        [DisplayName("Rental Cost"), Column("RENTAL_COST"), Size(18), Scale(6)]
        public Decimal? RentalCost
        {
            get { return Fields.RentalCost[this]; }
            set { Fields.RentalCost[this] = value; }
        }

        [DisplayName("Labor Cost"), Column("LABOR_COST"), Size(18), Scale(6)]
        public Decimal? LaborCost
        {
            get { return Fields.LaborCost[this]; }
            set { Fields.LaborCost[this] = value; }
        }

        [DisplayName("Inlab Cost"), Column("INLAB_COST"), Size(18), Scale(6)]
        public Decimal? InlabCost
        {
            get { return Fields.InlabCost[this]; }
            set { Fields.InlabCost[this] = value; }
        }

        [DisplayName("Inmat Cost"), Column("INMAT_COST"), Size(18), Scale(6)]
        public Decimal? InmatCost
        {
            get { return Fields.InmatCost[this]; }
            set { Fields.InmatCost[this] = value; }
        }

        [DisplayName("Misc Cost"), Column("MISC_COST"), Size(18), Scale(6)]
        public Decimal? MiscCost
        {
            get { return Fields.MiscCost[this]; }
            set { Fields.MiscCost[this] = value; }
        }

        [DisplayName("Subcon Cost"), Column("SUBCON_COST"), Size(18), Scale(6)]
        public Decimal? SubconCost
        {
            get { return Fields.SubconCost[this]; }
            set { Fields.SubconCost[this] = value; }
        }

        [DisplayName("Subcon Vendor"), Column("SUBCON_VENDOR"), Size(8)]
        public String SubconVendor
        {
            get { return Fields.SubconVendor[this]; }
            set { Fields.SubconVendor[this] = value; }
        }

        [DisplayName("Piece Rate"), Column("PIECE_RATE"), Size(12), Scale(4)]
        public Decimal? PieceRate
        {
            get { return Fields.PieceRate[this]; }
            set { Fields.PieceRate[this] = value; }
        }

        [DisplayName("Acct Machine"), Column("ACCT_MACHINE"), Size(30)]
        public String AcctMachine
        {
            get { return Fields.AcctMachine[this]; }
            set { Fields.AcctMachine[this] = value; }
        }

        [DisplayName("Acct Energy"), Column("ACCT_ENERGY"), Size(30)]
        public String AcctEnergy
        {
            get { return Fields.AcctEnergy[this]; }
            set { Fields.AcctEnergy[this] = value; }
        }

        [DisplayName("Acct Water"), Column("ACCT_WATER"), Size(30)]
        public String AcctWater
        {
            get { return Fields.AcctWater[this]; }
            set { Fields.AcctWater[this] = value; }
        }

        [DisplayName("Acct Rental"), Column("ACCT_RENTAL"), Size(30)]
        public String AcctRental
        {
            get { return Fields.AcctRental[this]; }
            set { Fields.AcctRental[this] = value; }
        }

        [DisplayName("Acct Labor"), Column("ACCT_LABOR"), Size(30)]
        public String AcctLabor
        {
            get { return Fields.AcctLabor[this]; }
            set { Fields.AcctLabor[this] = value; }
        }

        [DisplayName("Acct Inlab"), Column("ACCT_INLAB"), Size(30)]
        public String AcctInlab
        {
            get { return Fields.AcctInlab[this]; }
            set { Fields.AcctInlab[this] = value; }
        }

        [DisplayName("Acct Inmat"), Column("ACCT_INMAT"), Size(30)]
        public String AcctInmat
        {
            get { return Fields.AcctInmat[this]; }
            set { Fields.AcctInmat[this] = value; }
        }

        [DisplayName("Acct Misc"), Column("ACCT_MISC"), Size(30)]
        public String AcctMisc
        {
            get { return Fields.AcctMisc[this]; }
            set { Fields.AcctMisc[this] = value; }
        }

        [DisplayName("Created Date"), Column("CREATED_DATE")]
        public DateTime? CreatedDate
        {
            get { return Fields.CreatedDate[this]; }
            set { Fields.CreatedDate[this] = value; }
        }

        [DisplayName("Created By"), Column("CREATED_BY"), Size(10)]
        public String CreatedBy
        {
            get { return Fields.CreatedBy[this]; }
            set { Fields.CreatedBy[this] = value; }
        }

        [DisplayName("Revised Date"), Column("REVISED_DATE")]
        public DateTime? RevisedDate
        {
            get { return Fields.RevisedDate[this]; }
            set { Fields.RevisedDate[this] = value; }
        }

        [DisplayName("Revised By"), Column("REVISED_BY"), Size(10)]
        public String RevisedBy
        {
            get { return Fields.RevisedBy[this]; }
            set { Fields.RevisedBy[this] = value; }
        }

        [DisplayName("Brevised Date"), Column("BREVISED_DATE")]
        public DateTime? BrevisedDate
        {
            get { return Fields.BrevisedDate[this]; }
            set { Fields.BrevisedDate[this] = value; }
        }

        [DisplayName("Brevised By"), Column("BREVISED_BY"), Size(10)]
        public String BrevisedBy
        {
            get { return Fields.BrevisedBy[this]; }
            set { Fields.BrevisedBy[this] = value; }
        }

        [DisplayName("Owner Branch"), Column("OWNER_BRANCH"), Size(4)]
        public String OwnerBranch
        {
            get { return Fields.OwnerBranch[this]; }
            set { Fields.OwnerBranch[this] = value; }
        }

        [DisplayName("Source Branch"), Column("SOURCE_BRANCH"), Size(4)]
        public String SourceBranch
        {
            get { return Fields.SourceBranch[this]; }
            set { Fields.SourceBranch[this] = value; }
        }

        [DisplayName("Specifications"), Column("SPECIFICATIONS"), Size(1073741823)]
        public String Specifications
        {
            get { return Fields.Specifications[this]; }
            set { Fields.Specifications[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Recnum; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.OpCode; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public OperationRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField OpCode;
            public StringField Description;
            public BooleanField Suspended;
            public BooleanField TicketIssued;
            public BooleanField ReportRequired;
            public StringField OperType;
            public StringField ProdnMode;
            public StringField WorkCentre;
            public BooleanField FixedWctr;
            public DecimalField MinLotSize;
            public DecimalField StdLotSize;
            public DecimalField DirectLabor;
            public DecimalField MachLoadHr;
            public DecimalField ManLoadHr;
            public DecimalField MachProcessHr;
            public DecimalField ManProcessHr;
            public DecimalField MachUnloadHr;
            public DecimalField ManUnloadHr;
            public DecimalField MachineCost;
            public DecimalField EnergyCost;
            public DecimalField WaterCost;
            public DecimalField RentalCost;
            public DecimalField LaborCost;
            public DecimalField InlabCost;
            public DecimalField InmatCost;
            public DecimalField MiscCost;
            public DecimalField SubconCost;
            public StringField SubconVendor;
            public DecimalField PieceRate;
            public StringField AcctMachine;
            public StringField AcctEnergy;
            public StringField AcctWater;
            public StringField AcctRental;
            public StringField AcctLabor;
            public StringField AcctInlab;
            public StringField AcctInmat;
            public StringField AcctMisc;
            public DateTimeField CreatedDate;
            public StringField CreatedBy;
            public DateTimeField RevisedDate;
            public StringField RevisedBy;
            public DateTimeField BrevisedDate;
            public StringField BrevisedBy;
            public StringField OwnerBranch;
            public StringField SourceBranch;
            public StringField Specifications;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "MasterData.Operation";
            }
        }
    }
}
