#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  WorkCentreRow.cs
// Date: 2018/04/03 20:51

#endregion
using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace Matrix.MasterData.Entities
{
    [ConnectionKey("MasterData"), TableName("[dbo].[GBWCTR]")]
    [DisplayName("Work Centre"), InstanceName("Work Centre"), TwoLevelCached]   
    public sealed class WorkCentreRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Work Centre"), Column("WORK_CENTRE"), Size(10), PrimaryKey, QuickSearch]
        public String WorkCentre
        {
            get { return Fields.WorkCentre[this]; }
            set { Fields.WorkCentre[this] = value; }
        }

        [DisplayName("Description"), Column("DESCRIPTION"), Size(30), NotNull]
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

        [DisplayName("Critical"), Column("CRITICAL"), Size(1)]
        [BoolStringConverter]
        public bool? Critical
        {
            get { return Fields.Critical[this]; }
            set { Fields.Critical[this] = value; }
        }

        [DisplayName("Branch No"), Column("BRANCH_NO"), Size(4), NotNull]
        public String BranchNo
        {
            get { return Fields.BranchNo[this]; }
            set { Fields.BranchNo[this] = value; }
        }

        [DisplayName("No Of Persons"), Column("NO_OF_PERSONS"), Size(4)]
        public Decimal? NoOfPersons
        {
            get { return Fields.NoOfPersons[this]; }
            set { Fields.NoOfPersons[this] = value; }
        }

        [DisplayName("No Of Shifts"), Column("NO_OF_SHIFTS"), Size(2)]
        public Decimal? NoOfShifts
        {
            get { return Fields.NoOfShifts[this]; }
            set { Fields.NoOfShifts[this] = value; }
        }

        [DisplayName("First Setup Hr"), Column("FIRST_SETUP_HR"), Size(8), Scale(4)]
        public Decimal? FirstSetupHr
        {
            get { return Fields.FirstSetupHr[this]; }
            set { Fields.FirstSetupHr[this] = value; }
        }

        [DisplayName("First Clean Hr"), Column("FIRST_CLEAN_HR"), Size(8), Scale(4)]
        public Decimal? FirstCleanHr
        {
            get { return Fields.FirstCleanHr[this]; }
            set { Fields.FirstCleanHr[this] = value; }
        }

        [DisplayName("Other Setup Hr"), Column("OTHER_SETUP_HR"), Size(8), Scale(4)]
        public Decimal? OtherSetupHr
        {
            get { return Fields.OtherSetupHr[this]; }
            set { Fields.OtherSetupHr[this] = value; }
        }

        [DisplayName("Other Clean Hr"), Column("OTHER_CLEAN_HR"), Size(8), Scale(4)]
        public Decimal? OtherCleanHr
        {
            get { return Fields.OtherCleanHr[this]; }
            set { Fields.OtherCleanHr[this] = value; }
        }

        [DisplayName("Queue Hr"), Column("QUEUE_HR"), Size(8), Scale(4)]
        public Decimal? QueueHr
        {
            get { return Fields.QueueHr[this]; }
            set { Fields.QueueHr[this] = value; }
        }

        [DisplayName("Machine Unit"), Column("MACHINE_UNIT"), Size(1)]
        public String MachineUnit
        {
            get { return Fields.MachineUnit[this]; }
            set { Fields.MachineUnit[this] = value; }
        }

        [DisplayName("Machine Cost"), Column("MACHINE_COST"), Size(18), Scale(6)]
        public Decimal? MachineCost
        {
            get { return Fields.MachineCost[this]; }
            set { Fields.MachineCost[this] = value; }
        }

        [DisplayName("Energy Unit"), Column("ENERGY_UNIT"), Size(1)]
        public String EnergyUnit
        {
            get { return Fields.EnergyUnit[this]; }
            set { Fields.EnergyUnit[this] = value; }
        }

        [DisplayName("Energy Cost"), Column("ENERGY_COST"), Size(18), Scale(6)]
        public Decimal? EnergyCost
        {
            get { return Fields.EnergyCost[this]; }
            set { Fields.EnergyCost[this] = value; }
        }

        [DisplayName("Water Unit"), Column("WATER_UNIT"), Size(1)]
        public String WaterUnit
        {
            get { return Fields.WaterUnit[this]; }
            set { Fields.WaterUnit[this] = value; }
        }

        [DisplayName("Water Cost"), Column("WATER_COST"), Size(18), Scale(6)]
        public Decimal? WaterCost
        {
            get { return Fields.WaterCost[this]; }
            set { Fields.WaterCost[this] = value; }
        }

        [DisplayName("Rental Unit"), Column("RENTAL_UNIT"), Size(1)]
        public String RentalUnit
        {
            get { return Fields.RentalUnit[this]; }
            set { Fields.RentalUnit[this] = value; }
        }

        [DisplayName("Rental Cost"), Column("RENTAL_COST"), Size(18), Scale(6)]
        public Decimal? RentalCost
        {
            get { return Fields.RentalCost[this]; }
            set { Fields.RentalCost[this] = value; }
        }

        [DisplayName("Labor Unit"), Column("LABOR_UNIT"), Size(1)]
        public String LaborUnit
        {
            get { return Fields.LaborUnit[this]; }
            set { Fields.LaborUnit[this] = value; }
        }

        [DisplayName("Labor Cost"), Column("LABOR_COST"), Size(18), Scale(6)]
        public Decimal? LaborCost
        {
            get { return Fields.LaborCost[this]; }
            set { Fields.LaborCost[this] = value; }
        }

        [DisplayName("Inlab Unit"), Column("INLAB_UNIT"), Size(1)]
        public String InlabUnit
        {
            get { return Fields.InlabUnit[this]; }
            set { Fields.InlabUnit[this] = value; }
        }

        [DisplayName("Inlab Cost"), Column("INLAB_COST"), Size(18), Scale(6)]
        public Decimal? InlabCost
        {
            get { return Fields.InlabCost[this]; }
            set { Fields.InlabCost[this] = value; }
        }

        [DisplayName("Inmat Unit"), Column("INMAT_UNIT"), Size(1)]
        public String InmatUnit
        {
            get { return Fields.InmatUnit[this]; }
            set { Fields.InmatUnit[this] = value; }
        }

        [DisplayName("Inmat Cost"), Column("INMAT_COST"), Size(18), Scale(6)]
        public Decimal? InmatCost
        {
            get { return Fields.InmatCost[this]; }
            set { Fields.InmatCost[this] = value; }
        }

        [DisplayName("Misc Unit"), Column("MISC_UNIT"), Size(1)]
        public String MiscUnit
        {
            get { return Fields.MiscUnit[this]; }
            set { Fields.MiscUnit[this] = value; }
        }

        [DisplayName("Misc Cost"), Column("MISC_COST"), Size(18), Scale(6)]
        public Decimal? MiscCost
        {
            get { return Fields.MiscCost[this]; }
            set { Fields.MiscCost[this] = value; }
        }

        [DisplayName("Restrict0"), Column("RESTRICT0"), Size(10)]
        public String Restrict0
        {
            get { return Fields.Restrict0[this]; }
            set { Fields.Restrict0[this] = value; }
        }

        [DisplayName("Restrict1"), Column("RESTRICT1"), Size(10)]
        public String Restrict1
        {
            get { return Fields.Restrict1[this]; }
            set { Fields.Restrict1[this] = value; }
        }

        [DisplayName("Restrict2"), Column("RESTRICT2"), Size(10)]
        public String Restrict2
        {
            get { return Fields.Restrict2[this]; }
            set { Fields.Restrict2[this] = value; }
        }

        [DisplayName("Restrict3"), Column("RESTRICT3"), Size(10)]
        public String Restrict3
        {
            get { return Fields.Restrict3[this]; }
            set { Fields.Restrict3[this] = value; }
        }

        [DisplayName("Restrict4"), Column("RESTRICT4"), Size(10)]
        public String Restrict4
        {
            get { return Fields.Restrict4[this]; }
            set { Fields.Restrict4[this] = value; }
        }

        [DisplayName("Restrict5"), Column("RESTRICT5"), Size(10)]
        public String Restrict5
        {
            get { return Fields.Restrict5[this]; }
            set { Fields.Restrict5[this] = value; }
        }

        [DisplayName("Restrict6"), Column("RESTRICT6"), Size(10)]
        public String Restrict6
        {
            get { return Fields.Restrict6[this]; }
            set { Fields.Restrict6[this] = value; }
        }

        [DisplayName("Restrict7"), Column("RESTRICT7"), Size(10)]
        public String Restrict7
        {
            get { return Fields.Restrict7[this]; }
            set { Fields.Restrict7[this] = value; }
        }

        [DisplayName("Restrict8"), Column("RESTRICT8"), Size(10)]
        public String Restrict8
        {
            get { return Fields.Restrict8[this]; }
            set { Fields.Restrict8[this] = value; }
        }

        [DisplayName("Restrict9"), Column("RESTRICT9"), Size(10)]
        public String Restrict9
        {
            get { return Fields.Restrict9[this]; }
            set { Fields.Restrict9[this] = value; }
        }

        [DisplayName("Require0"), Column("REQUIRE0"), Size(10)]
        public String Require0
        {
            get { return Fields.Require0[this]; }
            set { Fields.Require0[this] = value; }
        }

        [DisplayName("Require1"), Column("REQUIRE1"), Size(10)]
        public String Require1
        {
            get { return Fields.Require1[this]; }
            set { Fields.Require1[this] = value; }
        }

        [DisplayName("Require2"), Column("REQUIRE2"), Size(10)]
        public String Require2
        {
            get { return Fields.Require2[this]; }
            set { Fields.Require2[this] = value; }
        }

        [DisplayName("Require3"), Column("REQUIRE3"), Size(10)]
        public String Require3
        {
            get { return Fields.Require3[this]; }
            set { Fields.Require3[this] = value; }
        }

        [DisplayName("Require4"), Column("REQUIRE4"), Size(10)]
        public String Require4
        {
            get { return Fields.Require4[this]; }
            set { Fields.Require4[this] = value; }
        }

        [DisplayName("Require5"), Column("REQUIRE5"), Size(10)]
        public String Require5
        {
            get { return Fields.Require5[this]; }
            set { Fields.Require5[this] = value; }
        }

        [DisplayName("Require6"), Column("REQUIRE6"), Size(10)]
        public String Require6
        {
            get { return Fields.Require6[this]; }
            set { Fields.Require6[this] = value; }
        }

        [DisplayName("Require7"), Column("REQUIRE7"), Size(10)]
        public String Require7
        {
            get { return Fields.Require7[this]; }
            set { Fields.Require7[this] = value; }
        }

        [DisplayName("Require8"), Column("REQUIRE8"), Size(10)]
        public String Require8
        {
            get { return Fields.Require8[this]; }
            set { Fields.Require8[this] = value; }
        }

        [DisplayName("Require9"), Column("REQUIRE9"), Size(10)]
        public String Require9
        {
            get { return Fields.Require9[this]; }
            set { Fields.Require9[this] = value; }
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

        [DisplayName("Oper Hrs Basis"), Column("OPER_HRS_BASIS"), Size(1)]
        public String OperHrsBasis
        {
            get { return Fields.OperHrsBasis[this]; }
            set { Fields.OperHrsBasis[this] = value; }
        }

        [DisplayName("No Of Machines"), Column("NO_OF_MACHINES"), Size(4)]
        public Decimal? NoOfMachines
        {
            get { return Fields.NoOfMachines[this]; }
            set { Fields.NoOfMachines[this] = value; }
        }

        [DisplayName("Capacity Unit"), Column("CAPACITY_UNIT"), Size(2)]
        public String CapacityUnit
        {
            get { return Fields.CapacityUnit[this]; }
            set { Fields.CapacityUnit[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Recnum; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.WorkCentre; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public WorkCentreRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField WorkCentre;
            public StringField Description;
            public BooleanField Suspended;
            public BooleanField Critical;
            public StringField BranchNo;
            public DecimalField NoOfPersons;
            public DecimalField NoOfShifts;
            public DecimalField FirstSetupHr;
            public DecimalField FirstCleanHr;
            public DecimalField OtherSetupHr;
            public DecimalField OtherCleanHr;
            public DecimalField QueueHr;
            public StringField MachineUnit;
            public DecimalField MachineCost;
            public StringField EnergyUnit;
            public DecimalField EnergyCost;
            public StringField WaterUnit;
            public DecimalField WaterCost;
            public StringField RentalUnit;
            public DecimalField RentalCost;
            public StringField LaborUnit;
            public DecimalField LaborCost;
            public StringField InlabUnit;
            public DecimalField InlabCost;
            public StringField InmatUnit;
            public DecimalField InmatCost;
            public StringField MiscUnit;
            public DecimalField MiscCost;
            public StringField Restrict0;
            public StringField Restrict1;
            public StringField Restrict2;
            public StringField Restrict3;
            public StringField Restrict4;
            public StringField Restrict5;
            public StringField Restrict6;
            public StringField Restrict7;
            public StringField Restrict8;
            public StringField Restrict9;
            public StringField Require0;
            public StringField Require1;
            public StringField Require2;
            public StringField Require3;
            public StringField Require4;
            public StringField Require5;
            public StringField Require6;
            public StringField Require7;
            public StringField Require8;
            public StringField Require9;
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
            public StringField OperHrsBasis;
            public DecimalField NoOfMachines;
            public StringField CapacityUnit;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "MasterData.WorkCentre";
            }
        }
    }
}
