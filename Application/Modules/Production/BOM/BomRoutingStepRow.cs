#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  BomRoutingStepRow.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Production.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Production"), TableName("[dbo].[PRPROC]")]
    [DisplayName("Bom Routing Step"), InstanceName("Bom Routing Step"), TwoLevelCached]   
    public sealed class BomRoutingStepRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Bom No"), Column("BOM_NO"), Size(30), PrimaryKey, ForeignKey("[dbo].[PRSBOM]", "BOM_NO"), LeftJoin("jBomNo"), QuickSearch, TextualField("BomNoSuspended")]
        public String BomNo
        {
            get { return Fields.BomNo[this]; }
            set { Fields.BomNo[this] = value; }
        }

        [DisplayName("Seq No"), Column("SEQ_NO"), Size(6), PrimaryKey]
        public Decimal? SeqNo
        {
            get { return Fields.SeqNo[this]; }
            set { Fields.SeqNo[this] = value; }
        }

        [DisplayName("Op Code"), Column("OP_CODE"), Size(8), NotNull]
        public String OpCode
        {
            get { return Fields.OpCode[this]; }
            set { Fields.OpCode[this] = value; }
        }

        [DisplayName("Description"), Column("DESCRIPTION"), Size(40)]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Ticketed"), Column("TICKETED"), Size(1)]
        public String Ticketed
        {
            get { return Fields.Ticketed[this]; }
            set { Fields.Ticketed[this] = value; }
        }

        [DisplayName("Reported"), Column("REPORTED"), Size(1)]
        public String Reported
        {
            get { return Fields.Reported[this]; }
            set { Fields.Reported[this] = value; }
        }

        [DisplayName("Prodn Mode"), Column("PRODN_MODE"), Size(6)]
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

        [DisplayName("Fixed Wcentre"), Column("FIXED_WCENTRE"), Size(1)]
        public String FixedWcentre
        {
            get { return Fields.FixedWcentre[this]; }
            set { Fields.FixedWcentre[this] = value; }
        }

        [DisplayName("No Of Workers"), Column("NO_OF_WORKERS"), Size(4)]
        public Decimal? NoOfWorkers
        {
            get { return Fields.NoOfWorkers[this]; }
            set { Fields.NoOfWorkers[this] = value; }
        }

        [DisplayName("Piece Rate"), Column("PIECE_RATE"), Size(12), Scale(4)]
        public Decimal? PieceRate
        {
            get { return Fields.PieceRate[this]; }
            set { Fields.PieceRate[this] = value; }
        }

        [DisplayName("Subcon Vendor"), Column("SUBCON_VENDOR"), Size(8)]
        public String SubconVendor
        {
            get { return Fields.SubconVendor[this]; }
            set { Fields.SubconVendor[this] = value; }
        }

        [DisplayName("Subcon Rate"), Column("SUBCON_RATE"), Size(12), Scale(4)]
        public Decimal? SubconRate
        {
            get { return Fields.SubconRate[this]; }
            set { Fields.SubconRate[this] = value; }
        }

        [DisplayName("Fixed Vendor"), Column("FIXED_VENDOR"), Size(1)]
        public String FixedVendor
        {
            get { return Fields.FixedVendor[this]; }
            set { Fields.FixedVendor[this] = value; }
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

        [DisplayName("Specifications"), Column("SPECIFICATIONS"), Size(1073741823)]
        public String Specifications
        {
            get { return Fields.Specifications[this]; }
            set { Fields.Specifications[this] = value; }
        }

        [DisplayName("Depend To"), Column("DEPEND_TO"), Size(6)]
        public Decimal? DependTo
        {
            get { return Fields.DependTo[this]; }
            set { Fields.DependTo[this] = value; }
        }

        [DisplayName("Dependency"), Column("DEPENDENCY"), Size(2)]
        public String Dependency
        {
            get { return Fields.Dependency[this]; }
            set { Fields.Dependency[this] = value; }
        }

        [DisplayName("Lag Hour"), Column("LAG_HOUR"), Size(5)]
        public Decimal? LagHour
        {
            get { return Fields.LagHour[this]; }
            set { Fields.LagHour[this] = value; }
        }

        [DisplayName("Machine No"), Column("MACHINE_NO"), Size(30)]
        public String MachineNo
        {
            get { return Fields.MachineNo[this]; }
            set { Fields.MachineNo[this] = value; }
        }

        [DisplayName("Mold No"), Column("MOLD_NO"), Size(30)]
        public String MoldNo
        {
            get { return Fields.MoldNo[this]; }
            set { Fields.MoldNo[this] = value; }
        }

        [DisplayName("User Defined Field 1"), Column("USER_DEFINED_FIELD_1"), Size(100)]
        public String UserDefinedField1
        {
            get { return Fields.UserDefinedField1[this]; }
            set { Fields.UserDefinedField1[this] = value; }
        }

        [DisplayName("User Defined Field 2"), Column("USER_DEFINED_FIELD_2"), Size(100)]
        public String UserDefinedField2
        {
            get { return Fields.UserDefinedField2[this]; }
            set { Fields.UserDefinedField2[this] = value; }
        }

        [DisplayName("User Defined Field 3"), Column("USER_DEFINED_FIELD_3"), Size(100)]
        public String UserDefinedField3
        {
            get { return Fields.UserDefinedField3[this]; }
            set { Fields.UserDefinedField3[this] = value; }
        }

        [DisplayName("User Defined Field 4"), Column("USER_DEFINED_FIELD_4"), Size(100)]
        public String UserDefinedField4
        {
            get { return Fields.UserDefinedField4[this]; }
            set { Fields.UserDefinedField4[this] = value; }
        }

        [DisplayName("User Defined Field 5"), Column("USER_DEFINED_FIELD_5"), Size(100)]
        public String UserDefinedField5
        {
            get { return Fields.UserDefinedField5[this]; }
            set { Fields.UserDefinedField5[this] = value; }
        }

        [DisplayName("User Defined Field 6"), Column("USER_DEFINED_FIELD_6"), Size(100)]
        public String UserDefinedField6
        {
            get { return Fields.UserDefinedField6[this]; }
            set { Fields.UserDefinedField6[this] = value; }
        }

        [DisplayName("User Defined Field 7"), Column("USER_DEFINED_FIELD_7"), Size(100)]
        public String UserDefinedField7
        {
            get { return Fields.UserDefinedField7[this]; }
            set { Fields.UserDefinedField7[this] = value; }
        }

        [DisplayName("User Defined Field 8"), Column("USER_DEFINED_FIELD_8"), Size(100)]
        public String UserDefinedField8
        {
            get { return Fields.UserDefinedField8[this]; }
            set { Fields.UserDefinedField8[this] = value; }
        }

        [DisplayName("User Defined Field 9"), Column("USER_DEFINED_FIELD_9"), Size(100)]
        public String UserDefinedField9
        {
            get { return Fields.UserDefinedField9[this]; }
            set { Fields.UserDefinedField9[this] = value; }
        }

        [DisplayName("User Defined Field 10"), Column("USER_DEFINED_FIELD_10"), Size(100)]
        public String UserDefinedField10
        {
            get { return Fields.UserDefinedField10[this]; }
            set { Fields.UserDefinedField10[this] = value; }
        }

        [DisplayName("User Defined Field 11"), Column("USER_DEFINED_FIELD_11"), Size(100)]
        public String UserDefinedField11
        {
            get { return Fields.UserDefinedField11[this]; }
            set { Fields.UserDefinedField11[this] = value; }
        }

        [DisplayName("User Defined Field 12"), Column("USER_DEFINED_FIELD_12"), Size(100)]
        public String UserDefinedField12
        {
            get { return Fields.UserDefinedField12[this]; }
            set { Fields.UserDefinedField12[this] = value; }
        }

        [DisplayName("User Defined Field 13"), Column("USER_DEFINED_FIELD_13"), Size(100)]
        public String UserDefinedField13
        {
            get { return Fields.UserDefinedField13[this]; }
            set { Fields.UserDefinedField13[this] = value; }
        }

        [DisplayName("User Defined Field 14"), Column("USER_DEFINED_FIELD_14"), Size(100)]
        public String UserDefinedField14
        {
            get { return Fields.UserDefinedField14[this]; }
            set { Fields.UserDefinedField14[this] = value; }
        }

        [DisplayName("User Defined Field 15"), Column("USER_DEFINED_FIELD_15"), Size(100)]
        public String UserDefinedField15
        {
            get { return Fields.UserDefinedField15[this]; }
            set { Fields.UserDefinedField15[this] = value; }
        }

        [DisplayName("User Defined Field 16"), Column("USER_DEFINED_FIELD_16"), Size(100)]
        public String UserDefinedField16
        {
            get { return Fields.UserDefinedField16[this]; }
            set { Fields.UserDefinedField16[this] = value; }
        }

        [DisplayName("User Defined Field 17"), Column("USER_DEFINED_FIELD_17"), Size(100)]
        public String UserDefinedField17
        {
            get { return Fields.UserDefinedField17[this]; }
            set { Fields.UserDefinedField17[this] = value; }
        }

        [DisplayName("User Defined Field 18"), Column("USER_DEFINED_FIELD_18"), Size(100)]
        public String UserDefinedField18
        {
            get { return Fields.UserDefinedField18[this]; }
            set { Fields.UserDefinedField18[this] = value; }
        }

        [DisplayName("User Defined Field 19"), Column("USER_DEFINED_FIELD_19"), Size(100)]
        public String UserDefinedField19
        {
            get { return Fields.UserDefinedField19[this]; }
            set { Fields.UserDefinedField19[this] = value; }
        }

        [DisplayName("User Defined Field 20"), Column("USER_DEFINED_FIELD_20"), Size(100)]
        public String UserDefinedField20
        {
            get { return Fields.UserDefinedField20[this]; }
            set { Fields.UserDefinedField20[this] = value; }
        }

        [DisplayName("Bom No Recnum"), Expression("jBomNo.[RECNUM]")]
        public Decimal? BomNoRecnum
        {
            get { return Fields.BomNoRecnum[this]; }
            set { Fields.BomNoRecnum[this] = value; }
        }

        [DisplayName("Bom No Suspended"), Expression("jBomNo.[SUSPENDED]")]
        public String BomNoSuspended
        {
            get { return Fields.BomNoSuspended[this]; }
            set { Fields.BomNoSuspended[this] = value; }
        }

        [DisplayName("Bom No Assm Item No"), Expression("jBomNo.[ASSM_ITEM_NO]")]
        public String BomNoAssmItemNo
        {
            get { return Fields.BomNoAssmItemNo[this]; }
            set { Fields.BomNoAssmItemNo[this] = value; }
        }

        [DisplayName("Bom No Description"), Expression("jBomNo.[DESCRIPTION]")]
        public String BomNoDescription
        {
            get { return Fields.BomNoDescription[this]; }
            set { Fields.BomNoDescription[this] = value; }
        }

        [DisplayName("Bom No Uom"), Expression("jBomNo.[UOM]")]
        public String BomNoUom
        {
            get { return Fields.BomNoUom[this]; }
            set { Fields.BomNoUom[this] = value; }
        }

        [DisplayName("Bom No Std Output"), Expression("jBomNo.[STD_OUTPUT]")]
        public Decimal? BomNoStdOutput
        {
            get { return Fields.BomNoStdOutput[this]; }
            set { Fields.BomNoStdOutput[this] = value; }
        }

        [DisplayName("Bom No Effect From"), Expression("jBomNo.[EFFECT_FROM]")]
        public DateTime? BomNoEffectFrom
        {
            get { return Fields.BomNoEffectFrom[this]; }
            set { Fields.BomNoEffectFrom[this] = value; }
        }

        [DisplayName("Bom No Effect To"), Expression("jBomNo.[EFFECT_TO]")]
        public DateTime? BomNoEffectTo
        {
            get { return Fields.BomNoEffectTo[this]; }
            set { Fields.BomNoEffectTo[this] = value; }
        }

        [DisplayName("Bom No Parts Verified"), Expression("jBomNo.[PARTS_VERIFIED]")]
        public String BomNoPartsVerified
        {
            get { return Fields.BomNoPartsVerified[this]; }
            set { Fields.BomNoPartsVerified[this] = value; }
        }

        [DisplayName("Bom No Proc Verified"), Expression("jBomNo.[PROC_VERIFIED]")]
        public String BomNoProcVerified
        {
            get { return Fields.BomNoProcVerified[this]; }
            set { Fields.BomNoProcVerified[this] = value; }
        }

        [DisplayName("Bom No Ecn Required"), Expression("jBomNo.[ECN_REQUIRED]")]
        public String BomNoEcnRequired
        {
            get { return Fields.BomNoEcnRequired[this]; }
            set { Fields.BomNoEcnRequired[this] = value; }
        }

        [DisplayName("Bom No Branch No"), Expression("jBomNo.[BRANCH_NO]")]
        public String BomNoBranchNo
        {
            get { return Fields.BomNoBranchNo[this]; }
            set { Fields.BomNoBranchNo[this] = value; }
        }

        [DisplayName("Bom No Assembly Line"), Expression("jBomNo.[ASSEMBLY_LINE]")]
        public String BomNoAssemblyLine
        {
            get { return Fields.BomNoAssemblyLine[this]; }
            set { Fields.BomNoAssemblyLine[this] = value; }
        }

        [DisplayName("Bom No Fixed Asm Line"), Expression("jBomNo.[FIXED_ASM_LINE]")]
        public String BomNoFixedAsmLine
        {
            get { return Fields.BomNoFixedAsmLine[this]; }
            set { Fields.BomNoFixedAsmLine[this] = value; }
        }

        [DisplayName("Bom No Work Est Basis"), Expression("jBomNo.[WORK_EST_BASIS]")]
        public String BomNoWorkEstBasis
        {
            get { return Fields.BomNoWorkEstBasis[this]; }
            set { Fields.BomNoWorkEstBasis[this] = value; }
        }

        [DisplayName("Bom No Std Lot Size"), Expression("jBomNo.[STD_LOT_SIZE]")]
        public Decimal? BomNoStdLotSize
        {
            get { return Fields.BomNoStdLotSize[this]; }
            set { Fields.BomNoStdLotSize[this] = value; }
        }

        [DisplayName("Bom No Min Lot Size"), Expression("jBomNo.[MIN_LOT_SIZE]")]
        public Decimal? BomNoMinLotSize
        {
            get { return Fields.BomNoMinLotSize[this]; }
            set { Fields.BomNoMinLotSize[this] = value; }
        }

        [DisplayName("Bom No Max Lot Size"), Expression("jBomNo.[MAX_LOT_SIZE]")]
        public Decimal? BomNoMaxLotSize
        {
            get { return Fields.BomNoMaxLotSize[this]; }
            set { Fields.BomNoMaxLotSize[this] = value; }
        }

        [DisplayName("Bom No Scrap Rate"), Expression("jBomNo.[SCRAP_RATE]")]
        public Decimal? BomNoScrapRate
        {
            get { return Fields.BomNoScrapRate[this]; }
            set { Fields.BomNoScrapRate[this] = value; }
        }

        [DisplayName("Bom No Last Line No"), Expression("jBomNo.[LAST_LINE_NO]")]
        public Decimal? BomNoLastLineNo
        {
            get { return Fields.BomNoLastLineNo[this]; }
            set { Fields.BomNoLastLineNo[this] = value; }
        }

        [DisplayName("Bom No Last Log No"), Expression("jBomNo.[LAST_LOG_NO]")]
        public Decimal? BomNoLastLogNo
        {
            get { return Fields.BomNoLastLogNo[this]; }
            set { Fields.BomNoLastLogNo[this] = value; }
        }

        [DisplayName("Bom No Parts Count"), Expression("jBomNo.[PARTS_COUNT]")]
        public Decimal? BomNoPartsCount
        {
            get { return Fields.BomNoPartsCount[this]; }
            set { Fields.BomNoPartsCount[this] = value; }
        }

        [DisplayName("Bom No Route Count"), Expression("jBomNo.[ROUTE_COUNT]")]
        public Decimal? BomNoRouteCount
        {
            get { return Fields.BomNoRouteCount[this]; }
            set { Fields.BomNoRouteCount[this] = value; }
        }

        [DisplayName("Bom No Bypro Count"), Expression("jBomNo.[BYPRO_COUNT]")]
        public Decimal? BomNoByproCount
        {
            get { return Fields.BomNoByproCount[this]; }
            set { Fields.BomNoByproCount[this] = value; }
        }

        [DisplayName("Bom No Bypro Share"), Expression("jBomNo.[BYPRO_SHARE]")]
        public Decimal? BomNoByproShare
        {
            get { return Fields.BomNoByproShare[this]; }
            set { Fields.BomNoByproShare[this] = value; }
        }

        [DisplayName("Bom No Mnpro Share"), Expression("jBomNo.[MNPRO_SHARE]")]
        public Decimal? BomNoMnproShare
        {
            get { return Fields.BomNoMnproShare[this]; }
            set { Fields.BomNoMnproShare[this] = value; }
        }

        [DisplayName("Bom No Created Date"), Expression("jBomNo.[CREATED_DATE]")]
        public DateTime? BomNoCreatedDate
        {
            get { return Fields.BomNoCreatedDate[this]; }
            set { Fields.BomNoCreatedDate[this] = value; }
        }

        [DisplayName("Bom No Created By"), Expression("jBomNo.[CREATED_BY]")]
        public String BomNoCreatedBy
        {
            get { return Fields.BomNoCreatedBy[this]; }
            set { Fields.BomNoCreatedBy[this] = value; }
        }

        [DisplayName("Bom No Revised Date"), Expression("jBomNo.[REVISED_DATE]")]
        public DateTime? BomNoRevisedDate
        {
            get { return Fields.BomNoRevisedDate[this]; }
            set { Fields.BomNoRevisedDate[this] = value; }
        }

        [DisplayName("Bom No Revised By"), Expression("jBomNo.[REVISED_BY]")]
        public String BomNoRevisedBy
        {
            get { return Fields.BomNoRevisedBy[this]; }
            set { Fields.BomNoRevisedBy[this] = value; }
        }

        [DisplayName("Bom No Lock Type"), Expression("jBomNo.[LOCK_TYPE]")]
        public String BomNoLockType
        {
            get { return Fields.BomNoLockType[this]; }
            set { Fields.BomNoLockType[this] = value; }
        }

        [DisplayName("Bom No Lock Ref No"), Expression("jBomNo.[LOCK_REF_NO]")]
        public String BomNoLockRefNo
        {
            get { return Fields.BomNoLockRefNo[this]; }
            set { Fields.BomNoLockRefNo[this] = value; }
        }

        [DisplayName("Bom No Owner Branch"), Expression("jBomNo.[OWNER_BRANCH]")]
        public String BomNoOwnerBranch
        {
            get { return Fields.BomNoOwnerBranch[this]; }
            set { Fields.BomNoOwnerBranch[this] = value; }
        }

        [DisplayName("Bom No Source Branch"), Expression("jBomNo.[SOURCE_BRANCH]")]
        public String BomNoSourceBranch
        {
            get { return Fields.BomNoSourceBranch[this]; }
            set { Fields.BomNoSourceBranch[this] = value; }
        }

        [DisplayName("Bom No Last Ecn No"), Expression("jBomNo.[LAST_ECN_NO]")]
        public String BomNoLastEcnNo
        {
            get { return Fields.BomNoLastEcnNo[this]; }
            set { Fields.BomNoLastEcnNo[this] = value; }
        }

        [DisplayName("Bom No Mass Cng Id"), Expression("jBomNo.[MASS_CNG_ID]")]
        public String BomNoMassCngId
        {
            get { return Fields.BomNoMassCngId[this]; }
            set { Fields.BomNoMassCngId[this] = value; }
        }

        [DisplayName("Bom No Allow Chg Job"), Expression("jBomNo.[ALLOW_CHG_JOB]")]
        public String BomNoAllowChgJob
        {
            get { return Fields.BomNoAllowChgJob[this]; }
            set { Fields.BomNoAllowChgJob[this] = value; }
        }

        [DisplayName("Bom No Net Wt"), Expression("jBomNo.[NET_WT]")]
        public Decimal? BomNoNetWt
        {
            get { return Fields.BomNoNetWt[this]; }
            set { Fields.BomNoNetWt[this] = value; }
        }

        [DisplayName("Bom No Net Wt Uom"), Expression("jBomNo.[NET_WT_UOM]")]
        public String BomNoNetWtUom
        {
            get { return Fields.BomNoNetWtUom[this]; }
            set { Fields.BomNoNetWtUom[this] = value; }
        }

        [DisplayName("Bom No Bom Revision"), Expression("jBomNo.[BOM_REVISION]")]
        public String BomNoBomRevision
        {
            get { return Fields.BomNoBomRevision[this]; }
            set { Fields.BomNoBomRevision[this] = value; }
        }

        [DisplayName("Bom No Flag"), Expression("jBomNo.[FLAG]")]
        public String BomNoFlag
        {
            get { return Fields.BomNoFlag[this]; }
            set { Fields.BomNoFlag[this] = value; }
        }

        [DisplayName("Bom No Hold By"), Expression("jBomNo.[HOLD_BY]")]
        public String BomNoHoldBy
        {
            get { return Fields.BomNoHoldBy[this]; }
            set { Fields.BomNoHoldBy[this] = value; }
        }

        [DisplayName("Bom No Last Parts Seq No"), Expression("jBomNo.[LAST_PARTS_SEQ_NO]")]
        public Decimal? BomNoLastPartsSeqNo
        {
            get { return Fields.BomNoLastPartsSeqNo[this]; }
            set { Fields.BomNoLastPartsSeqNo[this] = value; }
        }

        [DisplayName("Bom No Is Approved"), Expression("jBomNo.[IS_APPROVED]")]
        public String BomNoIsApproved
        {
            get { return Fields.BomNoIsApproved[this]; }
            set { Fields.BomNoIsApproved[this] = value; }
        }

        [DisplayName("Bom No Approved By"), Expression("jBomNo.[APPROVED_BY]")]
        public String BomNoApprovedBy
        {
            get { return Fields.BomNoApprovedBy[this]; }
            set { Fields.BomNoApprovedBy[this] = value; }
        }

        [DisplayName("Bom No Preapprove"), Expression("jBomNo.[PREAPPROVE]")]
        public String BomNoPreapprove
        {
            get { return Fields.BomNoPreapprove[this]; }
            set { Fields.BomNoPreapprove[this] = value; }
        }

        [DisplayName("Bom No Approved Date"), Expression("jBomNo.[APPROVED_DATE]")]
        public DateTime? BomNoApprovedDate
        {
            get { return Fields.BomNoApprovedDate[this]; }
            set { Fields.BomNoApprovedDate[this] = value; }
        }

        [DisplayName("Bom No Remarks"), Expression("jBomNo.[REMARKS]")]
        public String BomNoRemarks
        {
            get { return Fields.BomNoRemarks[this]; }
            set { Fields.BomNoRemarks[this] = value; }
        }

        [DisplayName("Bom No Issue Runner Waste"), Expression("jBomNo.[ISSUE_RUNNER_WASTE]")]
        public String BomNoIssueRunnerWaste
        {
            get { return Fields.BomNoIssueRunnerWaste[this]; }
            set { Fields.BomNoIssueRunnerWaste[this] = value; }
        }

        [DisplayName("Bom No Runner Waste Wt"), Expression("jBomNo.[RUNNER_WASTE_WT]")]
        public Decimal? BomNoRunnerWasteWt
        {
            get { return Fields.BomNoRunnerWasteWt[this]; }
            set { Fields.BomNoRunnerWasteWt[this] = value; }
        }

        [DisplayName("Bom No Runner Waste Uom"), Expression("jBomNo.[RUNNER_WASTE_UOM]")]
        public String BomNoRunnerWasteUom
        {
            get { return Fields.BomNoRunnerWasteUom[this]; }
            set { Fields.BomNoRunnerWasteUom[this] = value; }
        }

        [DisplayName("Bom No User Defined Field 1"), Expression("jBomNo.[USER_DEFINED_FIELD_1]")]
        public String BomNoUserDefinedField1
        {
            get { return Fields.BomNoUserDefinedField1[this]; }
            set { Fields.BomNoUserDefinedField1[this] = value; }
        }

        [DisplayName("Bom No User Defined Field 2"), Expression("jBomNo.[USER_DEFINED_FIELD_2]")]
        public String BomNoUserDefinedField2
        {
            get { return Fields.BomNoUserDefinedField2[this]; }
            set { Fields.BomNoUserDefinedField2[this] = value; }
        }

        [DisplayName("Bom No User Defined Field 3"), Expression("jBomNo.[USER_DEFINED_FIELD_3]")]
        public String BomNoUserDefinedField3
        {
            get { return Fields.BomNoUserDefinedField3[this]; }
            set { Fields.BomNoUserDefinedField3[this] = value; }
        }

        [DisplayName("Bom No User Defined Field 4"), Expression("jBomNo.[USER_DEFINED_FIELD_4]")]
        public String BomNoUserDefinedField4
        {
            get { return Fields.BomNoUserDefinedField4[this]; }
            set { Fields.BomNoUserDefinedField4[this] = value; }
        }

        [DisplayName("Bom No User Defined Field 5"), Expression("jBomNo.[USER_DEFINED_FIELD_5]")]
        public String BomNoUserDefinedField5
        {
            get { return Fields.BomNoUserDefinedField5[this]; }
            set { Fields.BomNoUserDefinedField5[this] = value; }
        }

        [DisplayName("Bom No User Defined Field 6"), Expression("jBomNo.[USER_DEFINED_FIELD_6]")]
        public String BomNoUserDefinedField6
        {
            get { return Fields.BomNoUserDefinedField6[this]; }
            set { Fields.BomNoUserDefinedField6[this] = value; }
        }

        [DisplayName("Bom No User Defined Field 7"), Expression("jBomNo.[USER_DEFINED_FIELD_7]")]
        public String BomNoUserDefinedField7
        {
            get { return Fields.BomNoUserDefinedField7[this]; }
            set { Fields.BomNoUserDefinedField7[this] = value; }
        }

        [DisplayName("Bom No User Defined Field 8"), Expression("jBomNo.[USER_DEFINED_FIELD_8]")]
        public String BomNoUserDefinedField8
        {
            get { return Fields.BomNoUserDefinedField8[this]; }
            set { Fields.BomNoUserDefinedField8[this] = value; }
        }

        [DisplayName("Bom No User Defined Field 9"), Expression("jBomNo.[USER_DEFINED_FIELD_9]")]
        public String BomNoUserDefinedField9
        {
            get { return Fields.BomNoUserDefinedField9[this]; }
            set { Fields.BomNoUserDefinedField9[this] = value; }
        }

        [DisplayName("Bom No User Defined Field 10"), Expression("jBomNo.[USER_DEFINED_FIELD_10]")]
        public String BomNoUserDefinedField10
        {
            get { return Fields.BomNoUserDefinedField10[this]; }
            set { Fields.BomNoUserDefinedField10[this] = value; }
        }

        [DisplayName("Bom No User Defined Field 11"), Expression("jBomNo.[USER_DEFINED_FIELD_11]")]
        public String BomNoUserDefinedField11
        {
            get { return Fields.BomNoUserDefinedField11[this]; }
            set { Fields.BomNoUserDefinedField11[this] = value; }
        }

        [DisplayName("Bom No User Defined Field 12"), Expression("jBomNo.[USER_DEFINED_FIELD_12]")]
        public String BomNoUserDefinedField12
        {
            get { return Fields.BomNoUserDefinedField12[this]; }
            set { Fields.BomNoUserDefinedField12[this] = value; }
        }

        [DisplayName("Bom No User Defined Field 13"), Expression("jBomNo.[USER_DEFINED_FIELD_13]")]
        public String BomNoUserDefinedField13
        {
            get { return Fields.BomNoUserDefinedField13[this]; }
            set { Fields.BomNoUserDefinedField13[this] = value; }
        }

        [DisplayName("Bom No User Defined Field 14"), Expression("jBomNo.[USER_DEFINED_FIELD_14]")]
        public String BomNoUserDefinedField14
        {
            get { return Fields.BomNoUserDefinedField14[this]; }
            set { Fields.BomNoUserDefinedField14[this] = value; }
        }

        [DisplayName("Bom No User Defined Field 15"), Expression("jBomNo.[USER_DEFINED_FIELD_15]")]
        public String BomNoUserDefinedField15
        {
            get { return Fields.BomNoUserDefinedField15[this]; }
            set { Fields.BomNoUserDefinedField15[this] = value; }
        }

        [DisplayName("Bom No User Defined Field 16"), Expression("jBomNo.[USER_DEFINED_FIELD_16]")]
        public String BomNoUserDefinedField16
        {
            get { return Fields.BomNoUserDefinedField16[this]; }
            set { Fields.BomNoUserDefinedField16[this] = value; }
        }

        [DisplayName("Bom No User Defined Field 17"), Expression("jBomNo.[USER_DEFINED_FIELD_17]")]
        public String BomNoUserDefinedField17
        {
            get { return Fields.BomNoUserDefinedField17[this]; }
            set { Fields.BomNoUserDefinedField17[this] = value; }
        }

        [DisplayName("Bom No User Defined Field 18"), Expression("jBomNo.[USER_DEFINED_FIELD_18]")]
        public String BomNoUserDefinedField18
        {
            get { return Fields.BomNoUserDefinedField18[this]; }
            set { Fields.BomNoUserDefinedField18[this] = value; }
        }

        [DisplayName("Bom No User Defined Field 19"), Expression("jBomNo.[USER_DEFINED_FIELD_19]")]
        public String BomNoUserDefinedField19
        {
            get { return Fields.BomNoUserDefinedField19[this]; }
            set { Fields.BomNoUserDefinedField19[this] = value; }
        }

        [DisplayName("Bom No User Defined Field 20"), Expression("jBomNo.[USER_DEFINED_FIELD_20]")]
        public String BomNoUserDefinedField20
        {
            get { return Fields.BomNoUserDefinedField20[this]; }
            set { Fields.BomNoUserDefinedField20[this] = value; }
        }

        [DisplayName("Bom No Allow Rohs Mat Only"), Expression("jBomNo.[ALLOW_ROHS_MAT_ONLY]")]
        public Boolean? BomNoAllowRohsMatOnly
        {
            get { return Fields.BomNoAllowRohsMatOnly[this]; }
            set { Fields.BomNoAllowRohsMatOnly[this] = value; }
        }

        [DisplayName("Bom No Issue Extra Runner Waste"), Expression("jBomNo.[ISSUE_EXTRA_RUNNER_WASTE]")]
        public Boolean? BomNoIssueExtraRunnerWaste
        {
            get { return Fields.BomNoIssueExtraRunnerWaste[this]; }
            set { Fields.BomNoIssueExtraRunnerWaste[this] = value; }
        }

        [DisplayName("Bom No Phantom"), Expression("jBomNo.[PHANTOM]")]
        public Boolean? BomNoPhantom
        {
            get { return Fields.BomNoPhantom[this]; }
            set { Fields.BomNoPhantom[this] = value; }
        }

        [DisplayName("Bom No Die Cutter"), Expression("jBomNo.[DIE_CUTTER]")]
        public Decimal? BomNoDieCutter
        {
            get { return Fields.BomNoDieCutter[this]; }
            set { Fields.BomNoDieCutter[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Recnum; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.BomNo; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public BomRoutingStepRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField BomNo;
            public DecimalField SeqNo;
            public StringField OpCode;
            public StringField Description;
            public StringField Ticketed;
            public StringField Reported;
            public StringField ProdnMode;
            public StringField WorkCentre;
            public StringField FixedWcentre;
            public DecimalField NoOfWorkers;
            public DecimalField PieceRate;
            public StringField SubconVendor;
            public DecimalField SubconRate;
            public StringField FixedVendor;
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
            public DateTimeField CreatedDate;
            public StringField CreatedBy;
            public DateTimeField RevisedDate;
            public StringField RevisedBy;
            public StringField OwnerBranch;
            public StringField SourceBranch;
            public StringField Specifications;
            public DecimalField DependTo;
            public StringField Dependency;
            public DecimalField LagHour;
            public StringField MachineNo;
            public StringField MoldNo;
            public StringField UserDefinedField1;
            public StringField UserDefinedField2;
            public StringField UserDefinedField3;
            public StringField UserDefinedField4;
            public StringField UserDefinedField5;
            public StringField UserDefinedField6;
            public StringField UserDefinedField7;
            public StringField UserDefinedField8;
            public StringField UserDefinedField9;
            public StringField UserDefinedField10;
            public StringField UserDefinedField11;
            public StringField UserDefinedField12;
            public StringField UserDefinedField13;
            public StringField UserDefinedField14;
            public StringField UserDefinedField15;
            public StringField UserDefinedField16;
            public StringField UserDefinedField17;
            public StringField UserDefinedField18;
            public StringField UserDefinedField19;
            public StringField UserDefinedField20;

            public DecimalField BomNoRecnum;
            public StringField BomNoSuspended;
            public StringField BomNoAssmItemNo;
            public StringField BomNoDescription;
            public StringField BomNoUom;
            public DecimalField BomNoStdOutput;
            public DateTimeField BomNoEffectFrom;
            public DateTimeField BomNoEffectTo;
            public StringField BomNoPartsVerified;
            public StringField BomNoProcVerified;
            public StringField BomNoEcnRequired;
            public StringField BomNoBranchNo;
            public StringField BomNoAssemblyLine;
            public StringField BomNoFixedAsmLine;
            public StringField BomNoWorkEstBasis;
            public DecimalField BomNoStdLotSize;
            public DecimalField BomNoMinLotSize;
            public DecimalField BomNoMaxLotSize;
            public DecimalField BomNoScrapRate;
            public DecimalField BomNoLastLineNo;
            public DecimalField BomNoLastLogNo;
            public DecimalField BomNoPartsCount;
            public DecimalField BomNoRouteCount;
            public DecimalField BomNoByproCount;
            public DecimalField BomNoByproShare;
            public DecimalField BomNoMnproShare;
            public DateTimeField BomNoCreatedDate;
            public StringField BomNoCreatedBy;
            public DateTimeField BomNoRevisedDate;
            public StringField BomNoRevisedBy;
            public StringField BomNoLockType;
            public StringField BomNoLockRefNo;
            public StringField BomNoOwnerBranch;
            public StringField BomNoSourceBranch;
            public StringField BomNoLastEcnNo;
            public StringField BomNoMassCngId;
            public StringField BomNoAllowChgJob;
            public DecimalField BomNoNetWt;
            public StringField BomNoNetWtUom;
            public StringField BomNoBomRevision;
            public StringField BomNoFlag;
            public StringField BomNoHoldBy;
            public DecimalField BomNoLastPartsSeqNo;
            public StringField BomNoIsApproved;
            public StringField BomNoApprovedBy;
            public StringField BomNoPreapprove;
            public DateTimeField BomNoApprovedDate;
            public StringField BomNoRemarks;
            public StringField BomNoIssueRunnerWaste;
            public DecimalField BomNoRunnerWasteWt;
            public StringField BomNoRunnerWasteUom;
            public StringField BomNoUserDefinedField1;
            public StringField BomNoUserDefinedField2;
            public StringField BomNoUserDefinedField3;
            public StringField BomNoUserDefinedField4;
            public StringField BomNoUserDefinedField5;
            public StringField BomNoUserDefinedField6;
            public StringField BomNoUserDefinedField7;
            public StringField BomNoUserDefinedField8;
            public StringField BomNoUserDefinedField9;
            public StringField BomNoUserDefinedField10;
            public StringField BomNoUserDefinedField11;
            public StringField BomNoUserDefinedField12;
            public StringField BomNoUserDefinedField13;
            public StringField BomNoUserDefinedField14;
            public StringField BomNoUserDefinedField15;
            public StringField BomNoUserDefinedField16;
            public StringField BomNoUserDefinedField17;
            public StringField BomNoUserDefinedField18;
            public StringField BomNoUserDefinedField19;
            public StringField BomNoUserDefinedField20;
            public BooleanField BomNoAllowRohsMatOnly;
            public BooleanField BomNoIssueExtraRunnerWaste;
            public BooleanField BomNoPhantom;
            public DecimalField BomNoDieCutter;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Production.BomRoutingStep";
            }
        }
    }
}
