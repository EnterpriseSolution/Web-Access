#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  AssemblyLineWorkCentreDetailRow.cs
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

    [ConnectionKey("MasterData"), TableName("[dbo].[GBASMW]")]
    [DisplayName("Assembly Line Work Centre Detail"), InstanceName("Assembly Line Work Centre Detail"), TwoLevelCached]   
    public sealed class AssemblyLineWorkCentreDetailRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Assembly Line"), Column("ASSEMBLY_LINE"), Size(6), PrimaryKey, ForeignKey("[dbo].[GBASML]", "ASSEMBLY_LINE"), LeftJoin("jAssemblyLine"), QuickSearch, TextualField("AssemblyLineDescription")]
        public String AssemblyLine
        {
            get { return Fields.AssemblyLine[this]; }
            set { Fields.AssemblyLine[this] = value; }
        }

        [DisplayName("Seq No"), Column("SEQ_NO"), Size(4), PrimaryKey]
        public Decimal? SeqNo
        {
            get { return Fields.SeqNo[this]; }
            set { Fields.SeqNo[this] = value; }
        }

        [DisplayName("Work Centre"), Column("WORK_CENTRE"), Size(10), NotNull, ForeignKey("[dbo].[GBWCTR]", "WORK_CENTRE"), LeftJoin("jWorkCentre"), TextualField("WorkCentreDescription")]
        public String WorkCentre
        {
            get { return Fields.WorkCentre[this]; }
            set { Fields.WorkCentre[this] = value; }
        }

        [DisplayName("Description"), Column("DESCRIPTION"), Size(30)]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Alternate"), Column("ALTERNATE"), Size(1)]
        [BoolStringConverter]
        public bool? Alternate
        {
            get { return Fields.Alternate[this]; }
            set { Fields.Alternate[this] = value; }
        }

        [DisplayName("Suspended"), Column("SUSPENDED"), Size(1)]
        [BoolStringConverter]
        public bool? Suspended
        {
            get { return Fields.Suspended[this]; }
            set { Fields.Suspended[this] = value; }
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

        [DisplayName("Assembly Line Recnum"), Expression("jAssemblyLine.[RECNUM]")]
        public Decimal? AssemblyLineRecnum
        {
            get { return Fields.AssemblyLineRecnum[this]; }
            set { Fields.AssemblyLineRecnum[this] = value; }
        }

        [DisplayName("Assembly Line Description"), Expression("jAssemblyLine.[DESCRIPTION]")]
        public String AssemblyLineDescription
        {
            get { return Fields.AssemblyLineDescription[this]; }
            set { Fields.AssemblyLineDescription[this] = value; }
        }

        [DisplayName("Assembly Line Branch No"), Expression("jAssemblyLine.[BRANCH_NO]")]
        public String AssemblyLineBranchNo
        {
            get { return Fields.AssemblyLineBranchNo[this]; }
            set { Fields.AssemblyLineBranchNo[this] = value; }
        }

        [DisplayName("Assembly Line Suspended"), Expression("jAssemblyLine.[SUSPENDED]")]
        public String AssemblyLineSuspended
        {
            get { return Fields.AssemblyLineSuspended[this]; }
            set { Fields.AssemblyLineSuspended[this] = value; }
        }

        [DisplayName("Assembly Line Priority"), Expression("jAssemblyLine.[PRIORITY]")]
        public String AssemblyLinePriority
        {
            get { return Fields.AssemblyLinePriority[this]; }
            set { Fields.AssemblyLinePriority[this] = value; }
        }

        [DisplayName("Assembly Line Effc Rating"), Expression("jAssemblyLine.[EFFC_RATING]")]
        public Decimal? AssemblyLineEffcRating
        {
            get { return Fields.AssemblyLineEffcRating[this]; }
            set { Fields.AssemblyLineEffcRating[this] = value; }
        }

        [DisplayName("Assembly Line Restrict0"), Expression("jAssemblyLine.[RESTRICT0]")]
        public String AssemblyLineRestrict0
        {
            get { return Fields.AssemblyLineRestrict0[this]; }
            set { Fields.AssemblyLineRestrict0[this] = value; }
        }

        [DisplayName("Assembly Line Restrict1"), Expression("jAssemblyLine.[RESTRICT1]")]
        public String AssemblyLineRestrict1
        {
            get { return Fields.AssemblyLineRestrict1[this]; }
            set { Fields.AssemblyLineRestrict1[this] = value; }
        }

        [DisplayName("Assembly Line Restrict2"), Expression("jAssemblyLine.[RESTRICT2]")]
        public String AssemblyLineRestrict2
        {
            get { return Fields.AssemblyLineRestrict2[this]; }
            set { Fields.AssemblyLineRestrict2[this] = value; }
        }

        [DisplayName("Assembly Line Restrict3"), Expression("jAssemblyLine.[RESTRICT3]")]
        public String AssemblyLineRestrict3
        {
            get { return Fields.AssemblyLineRestrict3[this]; }
            set { Fields.AssemblyLineRestrict3[this] = value; }
        }

        [DisplayName("Assembly Line Restrict4"), Expression("jAssemblyLine.[RESTRICT4]")]
        public String AssemblyLineRestrict4
        {
            get { return Fields.AssemblyLineRestrict4[this]; }
            set { Fields.AssemblyLineRestrict4[this] = value; }
        }

        [DisplayName("Assembly Line Restrict5"), Expression("jAssemblyLine.[RESTRICT5]")]
        public String AssemblyLineRestrict5
        {
            get { return Fields.AssemblyLineRestrict5[this]; }
            set { Fields.AssemblyLineRestrict5[this] = value; }
        }

        [DisplayName("Assembly Line Restrict6"), Expression("jAssemblyLine.[RESTRICT6]")]
        public String AssemblyLineRestrict6
        {
            get { return Fields.AssemblyLineRestrict6[this]; }
            set { Fields.AssemblyLineRestrict6[this] = value; }
        }

        [DisplayName("Assembly Line Restrict7"), Expression("jAssemblyLine.[RESTRICT7]")]
        public String AssemblyLineRestrict7
        {
            get { return Fields.AssemblyLineRestrict7[this]; }
            set { Fields.AssemblyLineRestrict7[this] = value; }
        }

        [DisplayName("Assembly Line Restrict8"), Expression("jAssemblyLine.[RESTRICT8]")]
        public String AssemblyLineRestrict8
        {
            get { return Fields.AssemblyLineRestrict8[this]; }
            set { Fields.AssemblyLineRestrict8[this] = value; }
        }

        [DisplayName("Assembly Line Restrict9"), Expression("jAssemblyLine.[RESTRICT9]")]
        public String AssemblyLineRestrict9
        {
            get { return Fields.AssemblyLineRestrict9[this]; }
            set { Fields.AssemblyLineRestrict9[this] = value; }
        }

        [DisplayName("Assembly Line Require0"), Expression("jAssemblyLine.[REQUIRE0]")]
        public String AssemblyLineRequire0
        {
            get { return Fields.AssemblyLineRequire0[this]; }
            set { Fields.AssemblyLineRequire0[this] = value; }
        }

        [DisplayName("Assembly Line Require1"), Expression("jAssemblyLine.[REQUIRE1]")]
        public String AssemblyLineRequire1
        {
            get { return Fields.AssemblyLineRequire1[this]; }
            set { Fields.AssemblyLineRequire1[this] = value; }
        }

        [DisplayName("Assembly Line Require2"), Expression("jAssemblyLine.[REQUIRE2]")]
        public String AssemblyLineRequire2
        {
            get { return Fields.AssemblyLineRequire2[this]; }
            set { Fields.AssemblyLineRequire2[this] = value; }
        }

        [DisplayName("Assembly Line Require3"), Expression("jAssemblyLine.[REQUIRE3]")]
        public String AssemblyLineRequire3
        {
            get { return Fields.AssemblyLineRequire3[this]; }
            set { Fields.AssemblyLineRequire3[this] = value; }
        }

        [DisplayName("Assembly Line Require4"), Expression("jAssemblyLine.[REQUIRE4]")]
        public String AssemblyLineRequire4
        {
            get { return Fields.AssemblyLineRequire4[this]; }
            set { Fields.AssemblyLineRequire4[this] = value; }
        }

        [DisplayName("Assembly Line Require5"), Expression("jAssemblyLine.[REQUIRE5]")]
        public String AssemblyLineRequire5
        {
            get { return Fields.AssemblyLineRequire5[this]; }
            set { Fields.AssemblyLineRequire5[this] = value; }
        }

        [DisplayName("Assembly Line Require6"), Expression("jAssemblyLine.[REQUIRE6]")]
        public String AssemblyLineRequire6
        {
            get { return Fields.AssemblyLineRequire6[this]; }
            set { Fields.AssemblyLineRequire6[this] = value; }
        }

        [DisplayName("Assembly Line Require7"), Expression("jAssemblyLine.[REQUIRE7]")]
        public String AssemblyLineRequire7
        {
            get { return Fields.AssemblyLineRequire7[this]; }
            set { Fields.AssemblyLineRequire7[this] = value; }
        }

        [DisplayName("Assembly Line Require8"), Expression("jAssemblyLine.[REQUIRE8]")]
        public String AssemblyLineRequire8
        {
            get { return Fields.AssemblyLineRequire8[this]; }
            set { Fields.AssemblyLineRequire8[this] = value; }
        }

        [DisplayName("Assembly Line Require9"), Expression("jAssemblyLine.[REQUIRE9]")]
        public String AssemblyLineRequire9
        {
            get { return Fields.AssemblyLineRequire9[this]; }
            set { Fields.AssemblyLineRequire9[this] = value; }
        }

        [DisplayName("Assembly Line Acct Machine"), Expression("jAssemblyLine.[ACCT_MACHINE]")]
        public String AssemblyLineAcctMachine
        {
            get { return Fields.AssemblyLineAcctMachine[this]; }
            set { Fields.AssemblyLineAcctMachine[this] = value; }
        }

        [DisplayName("Assembly Line Acct Energy"), Expression("jAssemblyLine.[ACCT_ENERGY]")]
        public String AssemblyLineAcctEnergy
        {
            get { return Fields.AssemblyLineAcctEnergy[this]; }
            set { Fields.AssemblyLineAcctEnergy[this] = value; }
        }

        [DisplayName("Assembly Line Acct Water"), Expression("jAssemblyLine.[ACCT_WATER]")]
        public String AssemblyLineAcctWater
        {
            get { return Fields.AssemblyLineAcctWater[this]; }
            set { Fields.AssemblyLineAcctWater[this] = value; }
        }

        [DisplayName("Assembly Line Acct Rental"), Expression("jAssemblyLine.[ACCT_RENTAL]")]
        public String AssemblyLineAcctRental
        {
            get { return Fields.AssemblyLineAcctRental[this]; }
            set { Fields.AssemblyLineAcctRental[this] = value; }
        }

        [DisplayName("Assembly Line Acct Labor"), Expression("jAssemblyLine.[ACCT_LABOR]")]
        public String AssemblyLineAcctLabor
        {
            get { return Fields.AssemblyLineAcctLabor[this]; }
            set { Fields.AssemblyLineAcctLabor[this] = value; }
        }

        [DisplayName("Assembly Line Acct Inlab"), Expression("jAssemblyLine.[ACCT_INLAB]")]
        public String AssemblyLineAcctInlab
        {
            get { return Fields.AssemblyLineAcctInlab[this]; }
            set { Fields.AssemblyLineAcctInlab[this] = value; }
        }

        [DisplayName("Assembly Line Acct Inmat"), Expression("jAssemblyLine.[ACCT_INMAT]")]
        public String AssemblyLineAcctInmat
        {
            get { return Fields.AssemblyLineAcctInmat[this]; }
            set { Fields.AssemblyLineAcctInmat[this] = value; }
        }

        [DisplayName("Assembly Line Acct Misc"), Expression("jAssemblyLine.[ACCT_MISC]")]
        public String AssemblyLineAcctMisc
        {
            get { return Fields.AssemblyLineAcctMisc[this]; }
            set { Fields.AssemblyLineAcctMisc[this] = value; }
        }

        [DisplayName("Assembly Line Created Date"), Expression("jAssemblyLine.[CREATED_DATE]")]
        public DateTime? AssemblyLineCreatedDate
        {
            get { return Fields.AssemblyLineCreatedDate[this]; }
            set { Fields.AssemblyLineCreatedDate[this] = value; }
        }

        [DisplayName("Assembly Line Created By"), Expression("jAssemblyLine.[CREATED_BY]")]
        public String AssemblyLineCreatedBy
        {
            get { return Fields.AssemblyLineCreatedBy[this]; }
            set { Fields.AssemblyLineCreatedBy[this] = value; }
        }

        [DisplayName("Assembly Line Revised Date"), Expression("jAssemblyLine.[REVISED_DATE]")]
        public DateTime? AssemblyLineRevisedDate
        {
            get { return Fields.AssemblyLineRevisedDate[this]; }
            set { Fields.AssemblyLineRevisedDate[this] = value; }
        }

        [DisplayName("Assembly Line Revised By"), Expression("jAssemblyLine.[REVISED_BY]")]
        public String AssemblyLineRevisedBy
        {
            get { return Fields.AssemblyLineRevisedBy[this]; }
            set { Fields.AssemblyLineRevisedBy[this] = value; }
        }

        [DisplayName("Assembly Line Brevised Date"), Expression("jAssemblyLine.[BREVISED_DATE]")]
        public DateTime? AssemblyLineBrevisedDate
        {
            get { return Fields.AssemblyLineBrevisedDate[this]; }
            set { Fields.AssemblyLineBrevisedDate[this] = value; }
        }

        [DisplayName("Assembly Line Brevised By"), Expression("jAssemblyLine.[BREVISED_BY]")]
        public String AssemblyLineBrevisedBy
        {
            get { return Fields.AssemblyLineBrevisedBy[this]; }
            set { Fields.AssemblyLineBrevisedBy[this] = value; }
        }

        [DisplayName("Assembly Line Owner Branch"), Expression("jAssemblyLine.[OWNER_BRANCH]")]
        public String AssemblyLineOwnerBranch
        {
            get { return Fields.AssemblyLineOwnerBranch[this]; }
            set { Fields.AssemblyLineOwnerBranch[this] = value; }
        }

        [DisplayName("Assembly Line Source Branch"), Expression("jAssemblyLine.[SOURCE_BRANCH]")]
        public String AssemblyLineSourceBranch
        {
            get { return Fields.AssemblyLineSourceBranch[this]; }
            set { Fields.AssemblyLineSourceBranch[this] = value; }
        }

        [DisplayName("Work Centre Recnum"), Expression("jWorkCentre.[RECNUM]")]
        public Decimal? WorkCentreRecnum
        {
            get { return Fields.WorkCentreRecnum[this]; }
            set { Fields.WorkCentreRecnum[this] = value; }
        }

        [DisplayName("Work Centre Description"), Expression("jWorkCentre.[DESCRIPTION]")]
        public String WorkCentreDescription
        {
            get { return Fields.WorkCentreDescription[this]; }
            set { Fields.WorkCentreDescription[this] = value; }
        }

        [DisplayName("Work Centre Suspended"), Expression("jWorkCentre.[SUSPENDED]")]
        public String WorkCentreSuspended
        {
            get { return Fields.WorkCentreSuspended[this]; }
            set { Fields.WorkCentreSuspended[this] = value; }
        }

        [DisplayName("Work Centre Critical"), Expression("jWorkCentre.[CRITICAL]")]
        public String WorkCentreCritical
        {
            get { return Fields.WorkCentreCritical[this]; }
            set { Fields.WorkCentreCritical[this] = value; }
        }

        [DisplayName("Work Centre Branch No"), Expression("jWorkCentre.[BRANCH_NO]")]
        public String WorkCentreBranchNo
        {
            get { return Fields.WorkCentreBranchNo[this]; }
            set { Fields.WorkCentreBranchNo[this] = value; }
        }

        [DisplayName("Work Centre No Of Persons"), Expression("jWorkCentre.[NO_OF_PERSONS]")]
        public Decimal? WorkCentreNoOfPersons
        {
            get { return Fields.WorkCentreNoOfPersons[this]; }
            set { Fields.WorkCentreNoOfPersons[this] = value; }
        }

        [DisplayName("Work Centre No Of Shifts"), Expression("jWorkCentre.[NO_OF_SHIFTS]")]
        public Decimal? WorkCentreNoOfShifts
        {
            get { return Fields.WorkCentreNoOfShifts[this]; }
            set { Fields.WorkCentreNoOfShifts[this] = value; }
        }

        [DisplayName("Work Centre First Setup Hr"), Expression("jWorkCentre.[FIRST_SETUP_HR]")]
        public Decimal? WorkCentreFirstSetupHr
        {
            get { return Fields.WorkCentreFirstSetupHr[this]; }
            set { Fields.WorkCentreFirstSetupHr[this] = value; }
        }

        [DisplayName("Work Centre First Clean Hr"), Expression("jWorkCentre.[FIRST_CLEAN_HR]")]
        public Decimal? WorkCentreFirstCleanHr
        {
            get { return Fields.WorkCentreFirstCleanHr[this]; }
            set { Fields.WorkCentreFirstCleanHr[this] = value; }
        }

        [DisplayName("Work Centre Other Setup Hr"), Expression("jWorkCentre.[OTHER_SETUP_HR]")]
        public Decimal? WorkCentreOtherSetupHr
        {
            get { return Fields.WorkCentreOtherSetupHr[this]; }
            set { Fields.WorkCentreOtherSetupHr[this] = value; }
        }

        [DisplayName("Work Centre Other Clean Hr"), Expression("jWorkCentre.[OTHER_CLEAN_HR]")]
        public Decimal? WorkCentreOtherCleanHr
        {
            get { return Fields.WorkCentreOtherCleanHr[this]; }
            set { Fields.WorkCentreOtherCleanHr[this] = value; }
        }

        [DisplayName("Work Centre Queue Hr"), Expression("jWorkCentre.[QUEUE_HR]")]
        public Decimal? WorkCentreQueueHr
        {
            get { return Fields.WorkCentreQueueHr[this]; }
            set { Fields.WorkCentreQueueHr[this] = value; }
        }

        [DisplayName("Work Centre Machine Unit"), Expression("jWorkCentre.[MACHINE_UNIT]")]
        public String WorkCentreMachineUnit
        {
            get { return Fields.WorkCentreMachineUnit[this]; }
            set { Fields.WorkCentreMachineUnit[this] = value; }
        }

        [DisplayName("Work Centre Machine Cost"), Expression("jWorkCentre.[MACHINE_COST]")]
        public Decimal? WorkCentreMachineCost
        {
            get { return Fields.WorkCentreMachineCost[this]; }
            set { Fields.WorkCentreMachineCost[this] = value; }
        }

        [DisplayName("Work Centre Energy Unit"), Expression("jWorkCentre.[ENERGY_UNIT]")]
        public String WorkCentreEnergyUnit
        {
            get { return Fields.WorkCentreEnergyUnit[this]; }
            set { Fields.WorkCentreEnergyUnit[this] = value; }
        }

        [DisplayName("Work Centre Energy Cost"), Expression("jWorkCentre.[ENERGY_COST]")]
        public Decimal? WorkCentreEnergyCost
        {
            get { return Fields.WorkCentreEnergyCost[this]; }
            set { Fields.WorkCentreEnergyCost[this] = value; }
        }

        [DisplayName("Work Centre Water Unit"), Expression("jWorkCentre.[WATER_UNIT]")]
        public String WorkCentreWaterUnit
        {
            get { return Fields.WorkCentreWaterUnit[this]; }
            set { Fields.WorkCentreWaterUnit[this] = value; }
        }

        [DisplayName("Work Centre Water Cost"), Expression("jWorkCentre.[WATER_COST]")]
        public Decimal? WorkCentreWaterCost
        {
            get { return Fields.WorkCentreWaterCost[this]; }
            set { Fields.WorkCentreWaterCost[this] = value; }
        }

        [DisplayName("Work Centre Rental Unit"), Expression("jWorkCentre.[RENTAL_UNIT]")]
        public String WorkCentreRentalUnit
        {
            get { return Fields.WorkCentreRentalUnit[this]; }
            set { Fields.WorkCentreRentalUnit[this] = value; }
        }

        [DisplayName("Work Centre Rental Cost"), Expression("jWorkCentre.[RENTAL_COST]")]
        public Decimal? WorkCentreRentalCost
        {
            get { return Fields.WorkCentreRentalCost[this]; }
            set { Fields.WorkCentreRentalCost[this] = value; }
        }

        [DisplayName("Work Centre Labor Unit"), Expression("jWorkCentre.[LABOR_UNIT]")]
        public String WorkCentreLaborUnit
        {
            get { return Fields.WorkCentreLaborUnit[this]; }
            set { Fields.WorkCentreLaborUnit[this] = value; }
        }

        [DisplayName("Work Centre Labor Cost"), Expression("jWorkCentre.[LABOR_COST]")]
        public Decimal? WorkCentreLaborCost
        {
            get { return Fields.WorkCentreLaborCost[this]; }
            set { Fields.WorkCentreLaborCost[this] = value; }
        }

        [DisplayName("Work Centre Inlab Unit"), Expression("jWorkCentre.[INLAB_UNIT]")]
        public String WorkCentreInlabUnit
        {
            get { return Fields.WorkCentreInlabUnit[this]; }
            set { Fields.WorkCentreInlabUnit[this] = value; }
        }

        [DisplayName("Work Centre Inlab Cost"), Expression("jWorkCentre.[INLAB_COST]")]
        public Decimal? WorkCentreInlabCost
        {
            get { return Fields.WorkCentreInlabCost[this]; }
            set { Fields.WorkCentreInlabCost[this] = value; }
        }

        [DisplayName("Work Centre Inmat Unit"), Expression("jWorkCentre.[INMAT_UNIT]")]
        public String WorkCentreInmatUnit
        {
            get { return Fields.WorkCentreInmatUnit[this]; }
            set { Fields.WorkCentreInmatUnit[this] = value; }
        }

        [DisplayName("Work Centre Inmat Cost"), Expression("jWorkCentre.[INMAT_COST]")]
        public Decimal? WorkCentreInmatCost
        {
            get { return Fields.WorkCentreInmatCost[this]; }
            set { Fields.WorkCentreInmatCost[this] = value; }
        }

        [DisplayName("Work Centre Misc Unit"), Expression("jWorkCentre.[MISC_UNIT]")]
        public String WorkCentreMiscUnit
        {
            get { return Fields.WorkCentreMiscUnit[this]; }
            set { Fields.WorkCentreMiscUnit[this] = value; }
        }

        [DisplayName("Work Centre Misc Cost"), Expression("jWorkCentre.[MISC_COST]")]
        public Decimal? WorkCentreMiscCost
        {
            get { return Fields.WorkCentreMiscCost[this]; }
            set { Fields.WorkCentreMiscCost[this] = value; }
        }

        [DisplayName("Work Centre Restrict0"), Expression("jWorkCentre.[RESTRICT0]")]
        public String WorkCentreRestrict0
        {
            get { return Fields.WorkCentreRestrict0[this]; }
            set { Fields.WorkCentreRestrict0[this] = value; }
        }

        [DisplayName("Work Centre Restrict1"), Expression("jWorkCentre.[RESTRICT1]")]
        public String WorkCentreRestrict1
        {
            get { return Fields.WorkCentreRestrict1[this]; }
            set { Fields.WorkCentreRestrict1[this] = value; }
        }

        [DisplayName("Work Centre Restrict2"), Expression("jWorkCentre.[RESTRICT2]")]
        public String WorkCentreRestrict2
        {
            get { return Fields.WorkCentreRestrict2[this]; }
            set { Fields.WorkCentreRestrict2[this] = value; }
        }

        [DisplayName("Work Centre Restrict3"), Expression("jWorkCentre.[RESTRICT3]")]
        public String WorkCentreRestrict3
        {
            get { return Fields.WorkCentreRestrict3[this]; }
            set { Fields.WorkCentreRestrict3[this] = value; }
        }

        [DisplayName("Work Centre Restrict4"), Expression("jWorkCentre.[RESTRICT4]")]
        public String WorkCentreRestrict4
        {
            get { return Fields.WorkCentreRestrict4[this]; }
            set { Fields.WorkCentreRestrict4[this] = value; }
        }

        [DisplayName("Work Centre Restrict5"), Expression("jWorkCentre.[RESTRICT5]")]
        public String WorkCentreRestrict5
        {
            get { return Fields.WorkCentreRestrict5[this]; }
            set { Fields.WorkCentreRestrict5[this] = value; }
        }

        [DisplayName("Work Centre Restrict6"), Expression("jWorkCentre.[RESTRICT6]")]
        public String WorkCentreRestrict6
        {
            get { return Fields.WorkCentreRestrict6[this]; }
            set { Fields.WorkCentreRestrict6[this] = value; }
        }

        [DisplayName("Work Centre Restrict7"), Expression("jWorkCentre.[RESTRICT7]")]
        public String WorkCentreRestrict7
        {
            get { return Fields.WorkCentreRestrict7[this]; }
            set { Fields.WorkCentreRestrict7[this] = value; }
        }

        [DisplayName("Work Centre Restrict8"), Expression("jWorkCentre.[RESTRICT8]")]
        public String WorkCentreRestrict8
        {
            get { return Fields.WorkCentreRestrict8[this]; }
            set { Fields.WorkCentreRestrict8[this] = value; }
        }

        [DisplayName("Work Centre Restrict9"), Expression("jWorkCentre.[RESTRICT9]")]
        public String WorkCentreRestrict9
        {
            get { return Fields.WorkCentreRestrict9[this]; }
            set { Fields.WorkCentreRestrict9[this] = value; }
        }

        [DisplayName("Work Centre Require0"), Expression("jWorkCentre.[REQUIRE0]")]
        public String WorkCentreRequire0
        {
            get { return Fields.WorkCentreRequire0[this]; }
            set { Fields.WorkCentreRequire0[this] = value; }
        }

        [DisplayName("Work Centre Require1"), Expression("jWorkCentre.[REQUIRE1]")]
        public String WorkCentreRequire1
        {
            get { return Fields.WorkCentreRequire1[this]; }
            set { Fields.WorkCentreRequire1[this] = value; }
        }

        [DisplayName("Work Centre Require2"), Expression("jWorkCentre.[REQUIRE2]")]
        public String WorkCentreRequire2
        {
            get { return Fields.WorkCentreRequire2[this]; }
            set { Fields.WorkCentreRequire2[this] = value; }
        }

        [DisplayName("Work Centre Require3"), Expression("jWorkCentre.[REQUIRE3]")]
        public String WorkCentreRequire3
        {
            get { return Fields.WorkCentreRequire3[this]; }
            set { Fields.WorkCentreRequire3[this] = value; }
        }

        [DisplayName("Work Centre Require4"), Expression("jWorkCentre.[REQUIRE4]")]
        public String WorkCentreRequire4
        {
            get { return Fields.WorkCentreRequire4[this]; }
            set { Fields.WorkCentreRequire4[this] = value; }
        }

        [DisplayName("Work Centre Require5"), Expression("jWorkCentre.[REQUIRE5]")]
        public String WorkCentreRequire5
        {
            get { return Fields.WorkCentreRequire5[this]; }
            set { Fields.WorkCentreRequire5[this] = value; }
        }

        [DisplayName("Work Centre Require6"), Expression("jWorkCentre.[REQUIRE6]")]
        public String WorkCentreRequire6
        {
            get { return Fields.WorkCentreRequire6[this]; }
            set { Fields.WorkCentreRequire6[this] = value; }
        }

        [DisplayName("Work Centre Require7"), Expression("jWorkCentre.[REQUIRE7]")]
        public String WorkCentreRequire7
        {
            get { return Fields.WorkCentreRequire7[this]; }
            set { Fields.WorkCentreRequire7[this] = value; }
        }

        [DisplayName("Work Centre Require8"), Expression("jWorkCentre.[REQUIRE8]")]
        public String WorkCentreRequire8
        {
            get { return Fields.WorkCentreRequire8[this]; }
            set { Fields.WorkCentreRequire8[this] = value; }
        }

        [DisplayName("Work Centre Require9"), Expression("jWorkCentre.[REQUIRE9]")]
        public String WorkCentreRequire9
        {
            get { return Fields.WorkCentreRequire9[this]; }
            set { Fields.WorkCentreRequire9[this] = value; }
        }

        [DisplayName("Work Centre Acct Machine"), Expression("jWorkCentre.[ACCT_MACHINE]")]
        public String WorkCentreAcctMachine
        {
            get { return Fields.WorkCentreAcctMachine[this]; }
            set { Fields.WorkCentreAcctMachine[this] = value; }
        }

        [DisplayName("Work Centre Acct Energy"), Expression("jWorkCentre.[ACCT_ENERGY]")]
        public String WorkCentreAcctEnergy
        {
            get { return Fields.WorkCentreAcctEnergy[this]; }
            set { Fields.WorkCentreAcctEnergy[this] = value; }
        }

        [DisplayName("Work Centre Acct Water"), Expression("jWorkCentre.[ACCT_WATER]")]
        public String WorkCentreAcctWater
        {
            get { return Fields.WorkCentreAcctWater[this]; }
            set { Fields.WorkCentreAcctWater[this] = value; }
        }

        [DisplayName("Work Centre Acct Rental"), Expression("jWorkCentre.[ACCT_RENTAL]")]
        public String WorkCentreAcctRental
        {
            get { return Fields.WorkCentreAcctRental[this]; }
            set { Fields.WorkCentreAcctRental[this] = value; }
        }

        [DisplayName("Work Centre Acct Labor"), Expression("jWorkCentre.[ACCT_LABOR]")]
        public String WorkCentreAcctLabor
        {
            get { return Fields.WorkCentreAcctLabor[this]; }
            set { Fields.WorkCentreAcctLabor[this] = value; }
        }

        [DisplayName("Work Centre Acct Inlab"), Expression("jWorkCentre.[ACCT_INLAB]")]
        public String WorkCentreAcctInlab
        {
            get { return Fields.WorkCentreAcctInlab[this]; }
            set { Fields.WorkCentreAcctInlab[this] = value; }
        }

        [DisplayName("Work Centre Acct Inmat"), Expression("jWorkCentre.[ACCT_INMAT]")]
        public String WorkCentreAcctInmat
        {
            get { return Fields.WorkCentreAcctInmat[this]; }
            set { Fields.WorkCentreAcctInmat[this] = value; }
        }

        [DisplayName("Work Centre Acct Misc"), Expression("jWorkCentre.[ACCT_MISC]")]
        public String WorkCentreAcctMisc
        {
            get { return Fields.WorkCentreAcctMisc[this]; }
            set { Fields.WorkCentreAcctMisc[this] = value; }
        }

        [DisplayName("Work Centre Created Date"), Expression("jWorkCentre.[CREATED_DATE]")]
        public DateTime? WorkCentreCreatedDate
        {
            get { return Fields.WorkCentreCreatedDate[this]; }
            set { Fields.WorkCentreCreatedDate[this] = value; }
        }

        [DisplayName("Work Centre Created By"), Expression("jWorkCentre.[CREATED_BY]")]
        public String WorkCentreCreatedBy
        {
            get { return Fields.WorkCentreCreatedBy[this]; }
            set { Fields.WorkCentreCreatedBy[this] = value; }
        }

        [DisplayName("Work Centre Revised Date"), Expression("jWorkCentre.[REVISED_DATE]")]
        public DateTime? WorkCentreRevisedDate
        {
            get { return Fields.WorkCentreRevisedDate[this]; }
            set { Fields.WorkCentreRevisedDate[this] = value; }
        }

        [DisplayName("Work Centre Revised By"), Expression("jWorkCentre.[REVISED_BY]")]
        public String WorkCentreRevisedBy
        {
            get { return Fields.WorkCentreRevisedBy[this]; }
            set { Fields.WorkCentreRevisedBy[this] = value; }
        }

        [DisplayName("Work Centre Brevised Date"), Expression("jWorkCentre.[BREVISED_DATE]")]
        public DateTime? WorkCentreBrevisedDate
        {
            get { return Fields.WorkCentreBrevisedDate[this]; }
            set { Fields.WorkCentreBrevisedDate[this] = value; }
        }

        [DisplayName("Work Centre Brevised By"), Expression("jWorkCentre.[BREVISED_BY]")]
        public String WorkCentreBrevisedBy
        {
            get { return Fields.WorkCentreBrevisedBy[this]; }
            set { Fields.WorkCentreBrevisedBy[this] = value; }
        }

        [DisplayName("Work Centre Owner Branch"), Expression("jWorkCentre.[OWNER_BRANCH]")]
        public String WorkCentreOwnerBranch
        {
            get { return Fields.WorkCentreOwnerBranch[this]; }
            set { Fields.WorkCentreOwnerBranch[this] = value; }
        }

        [DisplayName("Work Centre Source Branch"), Expression("jWorkCentre.[SOURCE_BRANCH]")]
        public String WorkCentreSourceBranch
        {
            get { return Fields.WorkCentreSourceBranch[this]; }
            set { Fields.WorkCentreSourceBranch[this] = value; }
        }

        [DisplayName("Work Centre Oper Hrs Basis"), Expression("jWorkCentre.[OPER_HRS_BASIS]")]
        public String WorkCentreOperHrsBasis
        {
            get { return Fields.WorkCentreOperHrsBasis[this]; }
            set { Fields.WorkCentreOperHrsBasis[this] = value; }
        }

        [DisplayName("Work Centre No Of Machines"), Expression("jWorkCentre.[NO_OF_MACHINES]")]
        public Decimal? WorkCentreNoOfMachines
        {
            get { return Fields.WorkCentreNoOfMachines[this]; }
            set { Fields.WorkCentreNoOfMachines[this] = value; }
        }

        [DisplayName("Work Centre Capacity Unit"), Expression("jWorkCentre.[CAPACITY_UNIT]")]
        public String WorkCentreCapacityUnit
        {
            get { return Fields.WorkCentreCapacityUnit[this]; }
            set { Fields.WorkCentreCapacityUnit[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Recnum; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.AssemblyLine; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public AssemblyLineWorkCentreDetailRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField AssemblyLine;
            public DecimalField SeqNo;
            public StringField WorkCentre;
            public StringField Description;
            public BooleanField Alternate;
            public BooleanField Suspended;
            public DateTimeField CreatedDate;
            public StringField CreatedBy;
            public DateTimeField RevisedDate;
            public StringField RevisedBy;
            public StringField OwnerBranch;
            public StringField SourceBranch;

            public DecimalField AssemblyLineRecnum;
            public StringField AssemblyLineDescription;
            public StringField AssemblyLineBranchNo;
            public StringField AssemblyLineSuspended;
            public StringField AssemblyLinePriority;
            public DecimalField AssemblyLineEffcRating;
            public StringField AssemblyLineRestrict0;
            public StringField AssemblyLineRestrict1;
            public StringField AssemblyLineRestrict2;
            public StringField AssemblyLineRestrict3;
            public StringField AssemblyLineRestrict4;
            public StringField AssemblyLineRestrict5;
            public StringField AssemblyLineRestrict6;
            public StringField AssemblyLineRestrict7;
            public StringField AssemblyLineRestrict8;
            public StringField AssemblyLineRestrict9;
            public StringField AssemblyLineRequire0;
            public StringField AssemblyLineRequire1;
            public StringField AssemblyLineRequire2;
            public StringField AssemblyLineRequire3;
            public StringField AssemblyLineRequire4;
            public StringField AssemblyLineRequire5;
            public StringField AssemblyLineRequire6;
            public StringField AssemblyLineRequire7;
            public StringField AssemblyLineRequire8;
            public StringField AssemblyLineRequire9;
            public StringField AssemblyLineAcctMachine;
            public StringField AssemblyLineAcctEnergy;
            public StringField AssemblyLineAcctWater;
            public StringField AssemblyLineAcctRental;
            public StringField AssemblyLineAcctLabor;
            public StringField AssemblyLineAcctInlab;
            public StringField AssemblyLineAcctInmat;
            public StringField AssemblyLineAcctMisc;
            public DateTimeField AssemblyLineCreatedDate;
            public StringField AssemblyLineCreatedBy;
            public DateTimeField AssemblyLineRevisedDate;
            public StringField AssemblyLineRevisedBy;
            public DateTimeField AssemblyLineBrevisedDate;
            public StringField AssemblyLineBrevisedBy;
            public StringField AssemblyLineOwnerBranch;
            public StringField AssemblyLineSourceBranch;

            public DecimalField WorkCentreRecnum;
            public StringField WorkCentreDescription;
            public StringField WorkCentreSuspended;
            public StringField WorkCentreCritical;
            public StringField WorkCentreBranchNo;
            public DecimalField WorkCentreNoOfPersons;
            public DecimalField WorkCentreNoOfShifts;
            public DecimalField WorkCentreFirstSetupHr;
            public DecimalField WorkCentreFirstCleanHr;
            public DecimalField WorkCentreOtherSetupHr;
            public DecimalField WorkCentreOtherCleanHr;
            public DecimalField WorkCentreQueueHr;
            public StringField WorkCentreMachineUnit;
            public DecimalField WorkCentreMachineCost;
            public StringField WorkCentreEnergyUnit;
            public DecimalField WorkCentreEnergyCost;
            public StringField WorkCentreWaterUnit;
            public DecimalField WorkCentreWaterCost;
            public StringField WorkCentreRentalUnit;
            public DecimalField WorkCentreRentalCost;
            public StringField WorkCentreLaborUnit;
            public DecimalField WorkCentreLaborCost;
            public StringField WorkCentreInlabUnit;
            public DecimalField WorkCentreInlabCost;
            public StringField WorkCentreInmatUnit;
            public DecimalField WorkCentreInmatCost;
            public StringField WorkCentreMiscUnit;
            public DecimalField WorkCentreMiscCost;
            public StringField WorkCentreRestrict0;
            public StringField WorkCentreRestrict1;
            public StringField WorkCentreRestrict2;
            public StringField WorkCentreRestrict3;
            public StringField WorkCentreRestrict4;
            public StringField WorkCentreRestrict5;
            public StringField WorkCentreRestrict6;
            public StringField WorkCentreRestrict7;
            public StringField WorkCentreRestrict8;
            public StringField WorkCentreRestrict9;
            public StringField WorkCentreRequire0;
            public StringField WorkCentreRequire1;
            public StringField WorkCentreRequire2;
            public StringField WorkCentreRequire3;
            public StringField WorkCentreRequire4;
            public StringField WorkCentreRequire5;
            public StringField WorkCentreRequire6;
            public StringField WorkCentreRequire7;
            public StringField WorkCentreRequire8;
            public StringField WorkCentreRequire9;
            public StringField WorkCentreAcctMachine;
            public StringField WorkCentreAcctEnergy;
            public StringField WorkCentreAcctWater;
            public StringField WorkCentreAcctRental;
            public StringField WorkCentreAcctLabor;
            public StringField WorkCentreAcctInlab;
            public StringField WorkCentreAcctInmat;
            public StringField WorkCentreAcctMisc;
            public DateTimeField WorkCentreCreatedDate;
            public StringField WorkCentreCreatedBy;
            public DateTimeField WorkCentreRevisedDate;
            public StringField WorkCentreRevisedBy;
            public DateTimeField WorkCentreBrevisedDate;
            public StringField WorkCentreBrevisedBy;
            public StringField WorkCentreOwnerBranch;
            public StringField WorkCentreSourceBranch;
            public StringField WorkCentreOperHrsBasis;
            public DecimalField WorkCentreNoOfMachines;
            public StringField WorkCentreCapacityUnit;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "MasterData.AssemblyLineWorkCentreDetail";
            }
        }
    }
}
