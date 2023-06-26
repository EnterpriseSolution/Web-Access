#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  CompanySettingRow.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Basic.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("BasicInformation"), TableName("[dbo].[GBSETS]")]
    [DisplayName("Company Setting"), InstanceName("Company Setting"), TwoLevelCached]   
    public sealed class CompanySettingRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Sl Init"), Column("SL_INIT"), Size(1), QuickSearch]
        public String SlInit
        {
            get { return Fields.SlInit[this]; }
            set { Fields.SlInit[this] = value; }
        }

        [DisplayName("Slso Multiship"), Column("SLSO_MULTISHIP"), Size(1)]
        public String SlsoMultiship
        {
            get { return Fields.SlsoMultiship[this]; }
            set { Fields.SlsoMultiship[this] = value; }
        }

        [DisplayName("Slso Resv"), Column("SLSO_RESV"), Size(1)]
        public String SlsoResv
        {
            get { return Fields.SlsoResv[this]; }
            set { Fields.SlsoResv[this] = value; }
        }

        [DisplayName("Slso Assortment"), Column("SLSO_ASSORTMENT"), Size(1)]
        public String SlsoAssortment
        {
            get { return Fields.SlsoAssortment[this]; }
            set { Fields.SlsoAssortment[this] = value; }
        }

        [DisplayName("Slso Deposits"), Column("SLSO_DEPOSITS"), Size(1)]
        public String SlsoDeposits
        {
            get { return Fields.SlsoDeposits[this]; }
            set { Fields.SlsoDeposits[this] = value; }
        }

        [DisplayName("Slso Measures"), Column("SLSO_MEASURES"), Size(1)]
        public String SlsoMeasures
        {
            get { return Fields.SlsoMeasures[this]; }
            set { Fields.SlsoMeasures[this] = value; }
        }

        [DisplayName("Slso Ptax"), Column("SLSO_PTAX"), Size(1)]
        public String SlsoPtax
        {
            get { return Fields.SlsoPtax[this]; }
            set { Fields.SlsoPtax[this] = value; }
        }

        [DisplayName("Slso Atax"), Column("SLSO_ATAX"), Size(1)]
        public String SlsoAtax
        {
            get { return Fields.SlsoAtax[this]; }
            set { Fields.SlsoAtax[this] = value; }
        }

        [DisplayName("Slso Gtax"), Column("SLSO_GTAX"), Size(1)]
        public String SlsoGtax
        {
            get { return Fields.SlsoGtax[this]; }
            set { Fields.SlsoGtax[this] = value; }
        }

        [DisplayName("Slso Line Disc"), Column("SLSO_LINE_DISC"), Size(1)]
        public String SlsoLineDisc
        {
            get { return Fields.SlsoLineDisc[this]; }
            set { Fields.SlsoLineDisc[this] = value; }
        }

        [DisplayName("Slso Auto Po"), Column("SLSO_AUTO_PO"), Size(1)]
        public String SlsoAutoPo
        {
            get { return Fields.SlsoAutoPo[this]; }
            set { Fields.SlsoAutoPo[this] = value; }
        }

        [DisplayName("Slso Auto Job"), Column("SLSO_AUTO_JOB"), Size(1)]
        public String SlsoAutoJob
        {
            get { return Fields.SlsoAutoJob[this]; }
            set { Fields.SlsoAutoJob[this] = value; }
        }

        [DisplayName("Slso Ext Inst"), Column("SLSO_EXT_INST"), Size(1)]
        public String SlsoExtInst
        {
            get { return Fields.SlsoExtInst[this]; }
            set { Fields.SlsoExtInst[this] = value; }
        }

        [DisplayName("Slso Ext Desc"), Column("SLSO_EXT_DESC"), Size(1)]
        public String SlsoExtDesc
        {
            get { return Fields.SlsoExtDesc[this]; }
            set { Fields.SlsoExtDesc[this] = value; }
        }

        [DisplayName("Slso Fixed Uom"), Column("SLSO_FIXED_UOM"), Size(1)]
        public String SlsoFixedUom
        {
            get { return Fields.SlsoFixedUom[this]; }
            set { Fields.SlsoFixedUom[this] = value; }
        }

        [DisplayName("Slso Req Sman"), Column("SLSO_REQ_SMAN"), Size(1)]
        public String SlsoReqSman
        {
            get { return Fields.SlsoReqSman[this]; }
            set { Fields.SlsoReqSman[this] = value; }
        }

        [DisplayName("Slso Sman"), Column("SLSO_SMAN"), Size(6)]
        public String SlsoSman
        {
            get { return Fields.SlsoSman[this]; }
            set { Fields.SlsoSman[this] = value; }
        }

        [DisplayName("Slso Text 1"), Column("SLSO_TEXT_1"), Size(6)]
        public String SlsoText1
        {
            get { return Fields.SlsoText1[this]; }
            set { Fields.SlsoText1[this] = value; }
        }

        [DisplayName("Slso Text 2"), Column("SLSO_TEXT_2"), Size(6)]
        public String SlsoText2
        {
            get { return Fields.SlsoText2[this]; }
            set { Fields.SlsoText2[this] = value; }
        }

        [DisplayName("Slso Text 3"), Column("SLSO_TEXT_3"), Size(6)]
        public String SlsoText3
        {
            get { return Fields.SlsoText3[this]; }
            set { Fields.SlsoText3[this] = value; }
        }

        [DisplayName("Slso Text 4"), Column("SLSO_TEXT_4"), Size(6)]
        public String SlsoText4
        {
            get { return Fields.SlsoText4[this]; }
            set { Fields.SlsoText4[this] = value; }
        }

        [DisplayName("Slso Due Lead"), Column("SLSO_DUE_LEAD"), Size(4)]
        public Decimal? SlsoDueLead
        {
            get { return Fields.SlsoDueLead[this]; }
            set { Fields.SlsoDueLead[this] = value; }
        }

        [DisplayName("Slso Sch Lead"), Column("SLSO_SCH_LEAD"), Size(4)]
        public Decimal? SlsoSchLead
        {
            get { return Fields.SlsoSchLead[this]; }
            set { Fields.SlsoSchLead[this] = value; }
        }

        [DisplayName("Slso Addr Code"), Column("SLSO_ADDR_CODE"), Size(6)]
        public String SlsoAddrCode
        {
            get { return Fields.SlsoAddrCode[this]; }
            set { Fields.SlsoAddrCode[this] = value; }
        }

        [DisplayName("Slso Addr Type"), Column("SLSO_ADDR_TYPE"), Size(12)]
        public String SlsoAddrType
        {
            get { return Fields.SlsoAddrType[this]; }
            set { Fields.SlsoAddrType[this] = value; }
        }

        [DisplayName("Slso Quote Days"), Column("SLSO_QUOTE_DAYS"), Size(4)]
        public Decimal? SlsoQuoteDays
        {
            get { return Fields.SlsoQuoteDays[this]; }
            set { Fields.SlsoQuoteDays[this] = value; }
        }

        [DisplayName("Slsh Cut Days"), Column("SLSH_CUT_DAYS"), Size(4)]
        public Decimal? SlshCutDays
        {
            get { return Fields.SlshCutDays[this]; }
            set { Fields.SlshCutDays[this] = value; }
        }

        [DisplayName("Slso Ship Via"), Column("SLSO_SHIP_VIA"), Size(30)]
        public String SlsoShipVia
        {
            get { return Fields.SlsoShipVia[this]; }
            set { Fields.SlsoShipVia[this] = value; }
        }

        [DisplayName("Slso Ship Terms"), Column("SLSO_SHIP_TERMS"), Size(15)]
        public String SlsoShipTerms
        {
            get { return Fields.SlsoShipTerms[this]; }
            set { Fields.SlsoShipTerms[this] = value; }
        }

        [DisplayName("Sl Revised Date"), Column("SL_REVISED_DATE")]
        public DateTime? SlRevisedDate
        {
            get { return Fields.SlRevisedDate[this]; }
            set { Fields.SlRevisedDate[this] = value; }
        }

        [DisplayName("Sl Revised By"), Column("SL_REVISED_BY"), Size(10)]
        public String SlRevisedBy
        {
            get { return Fields.SlRevisedBy[this]; }
            set { Fields.SlRevisedBy[this] = value; }
        }

        [DisplayName("Pu Init"), Column("PU_INIT"), Size(1)]
        public String PuInit
        {
            get { return Fields.PuInit[this]; }
            set { Fields.PuInit[this] = value; }
        }

        [DisplayName("Pupo Multiship"), Column("PUPO_MULTISHIP"), Size(1)]
        public String PupoMultiship
        {
            get { return Fields.PupoMultiship[this]; }
            set { Fields.PupoMultiship[this] = value; }
        }

        [DisplayName("Pupo Deposits"), Column("PUPO_DEPOSITS"), Size(1)]
        public String PupoDeposits
        {
            get { return Fields.PupoDeposits[this]; }
            set { Fields.PupoDeposits[this] = value; }
        }

        [DisplayName("Pupo Measures"), Column("PUPO_MEASURES"), Size(1)]
        public String PupoMeasures
        {
            get { return Fields.PupoMeasures[this]; }
            set { Fields.PupoMeasures[this] = value; }
        }

        [DisplayName("Pupo Ptax"), Column("PUPO_PTAX"), Size(1)]
        public String PupoPtax
        {
            get { return Fields.PupoPtax[this]; }
            set { Fields.PupoPtax[this] = value; }
        }

        [DisplayName("Pupo Atax"), Column("PUPO_ATAX"), Size(1)]
        public String PupoAtax
        {
            get { return Fields.PupoAtax[this]; }
            set { Fields.PupoAtax[this] = value; }
        }

        [DisplayName("Pupo Gtax"), Column("PUPO_GTAX"), Size(1)]
        public String PupoGtax
        {
            get { return Fields.PupoGtax[this]; }
            set { Fields.PupoGtax[this] = value; }
        }

        [DisplayName("Pupo Line Disc"), Column("PUPO_LINE_DISC"), Size(1)]
        public String PupoLineDisc
        {
            get { return Fields.PupoLineDisc[this]; }
            set { Fields.PupoLineDisc[this] = value; }
        }

        [DisplayName("Pupo Ext Inst"), Column("PUPO_EXT_INST"), Size(1)]
        public String PupoExtInst
        {
            get { return Fields.PupoExtInst[this]; }
            set { Fields.PupoExtInst[this] = value; }
        }

        [DisplayName("Pupo Ext Desc"), Column("PUPO_EXT_DESC"), Size(1)]
        public String PupoExtDesc
        {
            get { return Fields.PupoExtDesc[this]; }
            set { Fields.PupoExtDesc[this] = value; }
        }

        [DisplayName("Pupo Fixed Uom"), Column("PUPO_FIXED_UOM"), Size(1)]
        public String PupoFixedUom
        {
            get { return Fields.PupoFixedUom[this]; }
            set { Fields.PupoFixedUom[this] = value; }
        }

        [DisplayName("Pupo Text 1"), Column("PUPO_TEXT_1"), Size(6)]
        public String PupoText1
        {
            get { return Fields.PupoText1[this]; }
            set { Fields.PupoText1[this] = value; }
        }

        [DisplayName("Pupo Text 2"), Column("PUPO_TEXT_2"), Size(6)]
        public String PupoText2
        {
            get { return Fields.PupoText2[this]; }
            set { Fields.PupoText2[this] = value; }
        }

        [DisplayName("Pupo Text 3"), Column("PUPO_TEXT_3"), Size(6)]
        public String PupoText3
        {
            get { return Fields.PupoText3[this]; }
            set { Fields.PupoText3[this] = value; }
        }

        [DisplayName("Pupo Text 4"), Column("PUPO_TEXT_4"), Size(6)]
        public String PupoText4
        {
            get { return Fields.PupoText4[this]; }
            set { Fields.PupoText4[this] = value; }
        }

        [DisplayName("Pupo Cut Days"), Column("PUPO_CUT_DAYS"), Size(4)]
        public Decimal? PupoCutDays
        {
            get { return Fields.PupoCutDays[this]; }
            set { Fields.PupoCutDays[this] = value; }
        }

        [DisplayName("Pupo Reorder"), Column("PUPO_REORDER"), Size(1)]
        public String PupoReorder
        {
            get { return Fields.PupoReorder[this]; }
            set { Fields.PupoReorder[this] = value; }
        }

        [DisplayName("Pupo Req Buyer"), Column("PUPO_REQ_BUYER"), Size(1)]
        public String PupoReqBuyer
        {
            get { return Fields.PupoReqBuyer[this]; }
            set { Fields.PupoReqBuyer[this] = value; }
        }

        [DisplayName("Pupo Buyer"), Column("PUPO_BUYER"), Size(6)]
        public String PupoBuyer
        {
            get { return Fields.PupoBuyer[this]; }
            set { Fields.PupoBuyer[this] = value; }
        }

        [DisplayName("Pupo Ship Via"), Column("PUPO_SHIP_VIA"), Size(30)]
        public String PupoShipVia
        {
            get { return Fields.PupoShipVia[this]; }
            set { Fields.PupoShipVia[this] = value; }
        }

        [DisplayName("Pupo Ship Terms"), Column("PUPO_SHIP_TERMS"), Size(15)]
        public String PupoShipTerms
        {
            get { return Fields.PupoShipTerms[this]; }
            set { Fields.PupoShipTerms[this] = value; }
        }

        [DisplayName("Pu Revised Date"), Column("PU_REVISED_DATE")]
        public DateTime? PuRevisedDate
        {
            get { return Fields.PuRevisedDate[this]; }
            set { Fields.PuRevisedDate[this] = value; }
        }

        [DisplayName("Pu Revised By"), Column("PU_REVISED_BY"), Size(10)]
        public String PuRevisedBy
        {
            get { return Fields.PuRevisedBy[this]; }
            set { Fields.PuRevisedBy[this] = value; }
        }

        [DisplayName("Prod Init"), Column("PROD_INIT"), Size(1)]
        public String ProdInit
        {
            get { return Fields.ProdInit[this]; }
            set { Fields.ProdInit[this] = value; }
        }

        [DisplayName("Prod Ecn Req"), Column("PROD_ECN_REQ"), Size(1)]
        public String ProdEcnReq
        {
            get { return Fields.ProdEcnReq[this]; }
            set { Fields.ProdEcnReq[this] = value; }
        }

        [DisplayName("Prod Byprod"), Column("PROD_BYPROD"), Size(1)]
        public String ProdByprod
        {
            get { return Fields.ProdByprod[this]; }
            set { Fields.ProdByprod[this] = value; }
        }

        [DisplayName("Prod Scrap Rate"), Column("PROD_SCRAP_RATE"), Size(6), Scale(2)]
        public Decimal? ProdScrapRate
        {
            get { return Fields.ProdScrapRate[this]; }
            set { Fields.ProdScrapRate[this] = value; }
        }

        [DisplayName("Prod Pict Desc1"), Column("PROD_PICT_DESC1"), Size(30)]
        public String ProdPictDesc1
        {
            get { return Fields.ProdPictDesc1[this]; }
            set { Fields.ProdPictDesc1[this] = value; }
        }

        [DisplayName("Prod Pict Desc2"), Column("PROD_PICT_DESC2"), Size(30)]
        public String ProdPictDesc2
        {
            get { return Fields.ProdPictDesc2[this]; }
            set { Fields.ProdPictDesc2[this] = value; }
        }

        [DisplayName("Prod Pict Desc3"), Column("PROD_PICT_DESC3"), Size(30)]
        public String ProdPictDesc3
        {
            get { return Fields.ProdPictDesc3[this]; }
            set { Fields.ProdPictDesc3[this] = value; }
        }

        [DisplayName("Prod Pict Desc4"), Column("PROD_PICT_DESC4"), Size(30)]
        public String ProdPictDesc4
        {
            get { return Fields.ProdPictDesc4[this]; }
            set { Fields.ProdPictDesc4[this] = value; }
        }

        [DisplayName("Prod Weight Uom"), Column("PROD_WEIGHT_UOM"), Size(4)]
        public String ProdWeightUom
        {
            get { return Fields.ProdWeightUom[this]; }
            set { Fields.ProdWeightUom[this] = value; }
        }

        [DisplayName("Prod Dimen Uom"), Column("PROD_DIMEN_UOM"), Size(4)]
        public String ProdDimenUom
        {
            get { return Fields.ProdDimenUom[this]; }
            set { Fields.ProdDimenUom[this] = value; }
        }

        [DisplayName("Prod Fixed Wtum"), Column("PROD_FIXED_WTUM"), Size(1)]
        public String ProdFixedWtum
        {
            get { return Fields.ProdFixedWtum[this]; }
            set { Fields.ProdFixedWtum[this] = value; }
        }

        [DisplayName("Prod Fixed Dmum"), Column("PROD_FIXED_DMUM"), Size(1)]
        public String ProdFixedDmum
        {
            get { return Fields.ProdFixedDmum[this]; }
            set { Fields.ProdFixedDmum[this] = value; }
        }

        [DisplayName("Prod Std Lsize"), Column("PROD_STD_LSIZE"), Size(6)]
        public Decimal? ProdStdLsize
        {
            get { return Fields.ProdStdLsize[this]; }
            set { Fields.ProdStdLsize[this] = value; }
        }

        [DisplayName("Prod Min Lsize"), Column("PROD_MIN_LSIZE"), Size(6)]
        public Decimal? ProdMinLsize
        {
            get { return Fields.ProdMinLsize[this]; }
            set { Fields.ProdMinLsize[this] = value; }
        }

        [DisplayName("Prod Max Lsize"), Column("PROD_MAX_LSIZE"), Size(6)]
        public Decimal? ProdMaxLsize
        {
            get { return Fields.ProdMaxLsize[this]; }
            set { Fields.ProdMaxLsize[this] = value; }
        }

        [DisplayName("Prod Std Output"), Column("PROD_STD_OUTPUT"), Size(12), Scale(4)]
        public Decimal? ProdStdOutput
        {
            get { return Fields.ProdStdOutput[this]; }
            set { Fields.ProdStdOutput[this] = value; }
        }

        [DisplayName("Pr Revised Date"), Column("PR_REVISED_DATE")]
        public DateTime? PrRevisedDate
        {
            get { return Fields.PrRevisedDate[this]; }
            set { Fields.PrRevisedDate[this] = value; }
        }

        [DisplayName("Pr Revised By"), Column("PR_REVISED_BY"), Size(10)]
        public String PrRevisedBy
        {
            get { return Fields.PrRevisedBy[this]; }
            set { Fields.PrRevisedBy[this] = value; }
        }

        [DisplayName("Shop Req Jcat"), Column("SHOP_REQ_JCAT"), Size(1)]
        public String ShopReqJcat
        {
            get { return Fields.ShopReqJcat[this]; }
            set { Fields.ShopReqJcat[this] = value; }
        }

        [DisplayName("Shop Wks Cover"), Column("SHOP_WKS_COVER"), Size(4)]
        public Decimal? ShopWksCover
        {
            get { return Fields.ShopWksCover[this]; }
            set { Fields.ShopWksCover[this] = value; }
        }

        [DisplayName("Shop Planner"), Column("SHOP_PLANNER"), Size(1)]
        public String ShopPlanner
        {
            get { return Fields.ShopPlanner[this]; }
            set { Fields.ShopPlanner[this] = value; }
        }

        [DisplayName("Shop Def Plnr"), Column("SHOP_DEF_PLNR"), Size(6)]
        public String ShopDefPlnr
        {
            get { return Fields.ShopDefPlnr[this]; }
            set { Fields.ShopDefPlnr[this] = value; }
        }

        [DisplayName("Shop Mps Horz"), Column("SHOP_MPS_HORZ"), Size(4)]
        public Decimal? ShopMpsHorz
        {
            get { return Fields.ShopMpsHorz[this]; }
            set { Fields.ShopMpsHorz[this] = value; }
        }

        [DisplayName("Shop Pur Ltime"), Column("SHOP_PUR_LTIME"), Size(4)]
        public Decimal? ShopPurLtime
        {
            get { return Fields.ShopPurLtime[this]; }
            set { Fields.ShopPurLtime[this] = value; }
        }

        [DisplayName("Shop Pur Lunit"), Column("SHOP_PUR_LUNIT"), Size(1)]
        public String ShopPurLunit
        {
            get { return Fields.ShopPurLunit[this]; }
            set { Fields.ShopPurLunit[this] = value; }
        }

        [DisplayName("Shop Job Cat"), Column("SHOP_JOB_CAT"), Size(10)]
        public String ShopJobCat
        {
            get { return Fields.ShopJobCat[this]; }
            set { Fields.ShopJobCat[this] = value; }
        }

        [DisplayName("Shop Mrp Horz"), Column("SHOP_MRP_HORZ"), Size(4)]
        public Decimal? ShopMrpHorz
        {
            get { return Fields.ShopMrpHorz[this]; }
            set { Fields.ShopMrpHorz[this] = value; }
        }

        [DisplayName("Sh Revised Date"), Column("SH_REVISED_DATE")]
        public DateTime? ShRevisedDate
        {
            get { return Fields.ShRevisedDate[this]; }
            set { Fields.ShRevisedDate[this] = value; }
        }

        [DisplayName("Sh Revised By"), Column("SH_REVISED_BY"), Size(10)]
        public String ShRevisedBy
        {
            get { return Fields.ShRevisedBy[this]; }
            set { Fields.ShRevisedBy[this] = value; }
        }

        [DisplayName("Mrp Count"), Column("MRP_COUNT"), Size(6)]
        public Decimal? MrpCount
        {
            get { return Fields.MrpCount[this]; }
            set { Fields.MrpCount[this] = value; }
        }

        [DisplayName("Mrp Ref No"), Column("MRP_REF_NO"), Size(16)]
        public String MrpRefNo
        {
            get { return Fields.MrpRefNo[this]; }
            set { Fields.MrpRefNo[this] = value; }
        }

        [DisplayName("Mrp Run Date"), Column("MRP_RUN_DATE")]
        public DateTime? MrpRunDate
        {
            get { return Fields.MrpRunDate[this]; }
            set { Fields.MrpRunDate[this] = value; }
        }

        [DisplayName("Mrp Horz Date"), Column("MRP_HORZ_DATE")]
        public DateTime? MrpHorzDate
        {
            get { return Fields.MrpHorzDate[this]; }
            set { Fields.MrpHorzDate[this] = value; }
        }

        [DisplayName("Ic Init"), Column("IC_INIT"), Size(1)]
        public String IcInit
        {
            get { return Fields.IcInit[this]; }
            set { Fields.IcInit[this] = value; }
        }

        [DisplayName("Ic Receipts"), Column("IC_RECEIPTS"), Size(6)]
        public String IcReceipts
        {
            get { return Fields.IcReceipts[this]; }
            set { Fields.IcReceipts[this] = value; }
        }

        [DisplayName("Ic Issuance"), Column("IC_ISSUANCE"), Size(6)]
        public String IcIssuance
        {
            get { return Fields.IcIssuance[this]; }
            set { Fields.IcIssuance[this] = value; }
        }

        [DisplayName("Ic Transfer"), Column("IC_TRANSFER"), Size(6)]
        public String IcTransfer
        {
            get { return Fields.IcTransfer[this]; }
            set { Fields.IcTransfer[this] = value; }
        }

        [DisplayName("Ic Adjustment"), Column("IC_ADJUSTMENT"), Size(6)]
        public String IcAdjustment
        {
            get { return Fields.IcAdjustment[this]; }
            set { Fields.IcAdjustment[this] = value; }
        }

        [DisplayName("Ic Revised Date"), Column("IC_REVISED_DATE")]
        public DateTime? IcRevisedDate
        {
            get { return Fields.IcRevisedDate[this]; }
            set { Fields.IcRevisedDate[this] = value; }
        }

        [DisplayName("Ic Revised By"), Column("IC_REVISED_BY"), Size(10)]
        public String IcRevisedBy
        {
            get { return Fields.IcRevisedBy[this]; }
            set { Fields.IcRevisedBy[this] = value; }
        }

        [DisplayName("Pr Job Sched"), Column("PR_JOB_SCHED"), Size(1)]
        public String PrJobSched
        {
            get { return Fields.PrJobSched[this]; }
            set { Fields.PrJobSched[this] = value; }
        }

        [DisplayName("Pr By Prod"), Column("PR_BY_PROD"), Size(1)]
        public String PrByProd
        {
            get { return Fields.PrByProd[this]; }
            set { Fields.PrByProd[this] = value; }
        }

        [DisplayName("Pr Job Batches"), Column("PR_JOB_BATCHES"), Size(1)]
        public String PrJobBatches
        {
            get { return Fields.PrJobBatches[this]; }
            set { Fields.PrJobBatches[this] = value; }
        }

        [DisplayName("Last Resv No"), Column("LAST_RESV_NO"), Size(14)]
        public Decimal? LastResvNo
        {
            get { return Fields.LastResvNo[this]; }
            set { Fields.LastResvNo[this] = value; }
        }

        [DisplayName("No Mrp Fence"), Column("NO_MRP_FENCE"), Size(1)]
        public String NoMrpFence
        {
            get { return Fields.NoMrpFence[this]; }
            set { Fields.NoMrpFence[this] = value; }
        }

        [DisplayName("Mvt Rm Issue"), Column("MVT_RM_ISSUE"), Size(6)]
        public String MvtRmIssue
        {
            get { return Fields.MvtRmIssue[this]; }
            set { Fields.MvtRmIssue[this] = value; }
        }

        [DisplayName("Mvt Sp Issue"), Column("MVT_SP_ISSUE"), Size(6)]
        public String MvtSpIssue
        {
            get { return Fields.MvtSpIssue[this]; }
            set { Fields.MvtSpIssue[this] = value; }
        }

        [DisplayName("Mvt Fg Return"), Column("MVT_FG_RETURN"), Size(6)]
        public String MvtFgReturn
        {
            get { return Fields.MvtFgReturn[this]; }
            set { Fields.MvtFgReturn[this] = value; }
        }

        [DisplayName("Mvt Rm Return"), Column("MVT_RM_RETURN"), Size(6)]
        public String MvtRmReturn
        {
            get { return Fields.MvtRmReturn[this]; }
            set { Fields.MvtRmReturn[this] = value; }
        }

        [DisplayName("Mvt Sl Shipment"), Column("MVT_SL_SHIPMENT"), Size(6)]
        public String MvtSlShipment
        {
            get { return Fields.MvtSlShipment[this]; }
            set { Fields.MvtSlShipment[this] = value; }
        }

        [DisplayName("Mvt Sl Return"), Column("MVT_SL_RETURN"), Size(6)]
        public String MvtSlReturn
        {
            get { return Fields.MvtSlReturn[this]; }
            set { Fields.MvtSlReturn[this] = value; }
        }

        [DisplayName("Mvt Pu Receipt"), Column("MVT_PU_RECEIPT"), Size(6)]
        public String MvtPuReceipt
        {
            get { return Fields.MvtPuReceipt[this]; }
            set { Fields.MvtPuReceipt[this] = value; }
        }

        [DisplayName("Mvt Pu Inspect"), Column("MVT_PU_INSPECT"), Size(6)]
        public String MvtPuInspect
        {
            get { return Fields.MvtPuInspect[this]; }
            set { Fields.MvtPuInspect[this] = value; }
        }

        [DisplayName("Mvt Pu Return"), Column("MVT_PU_RETURN"), Size(6)]
        public String MvtPuReturn
        {
            get { return Fields.MvtPuReturn[this]; }
            set { Fields.MvtPuReturn[this] = value; }
        }

        [DisplayName("Gl Init"), Column("GL_INIT"), Size(1)]
        public String GlInit
        {
            get { return Fields.GlInit[this]; }
            set { Fields.GlInit[this] = value; }
        }

        [DisplayName("Gl Hdr Txt"), Column("GL_HDR_TXT"), Size(1)]
        public String GlHdrTxt
        {
            get { return Fields.GlHdrTxt[this]; }
            set { Fields.GlHdrTxt[this] = value; }
        }

        [DisplayName("Gl Dtl Txt"), Column("GL_DTL_TXT"), Size(1)]
        public String GlDtlTxt
        {
            get { return Fields.GlDtlTxt[this]; }
            set { Fields.GlDtlTxt[this] = value; }
        }

        [DisplayName("Gl Ref Entry"), Column("GL_REF_ENTRY"), Size(1)]
        public String GlRefEntry
        {
            get { return Fields.GlRefEntry[this]; }
            set { Fields.GlRefEntry[this] = value; }
        }

        [DisplayName("Gl Ref Label"), Column("GL_REF_LABEL"), Size(12)]
        public String GlRefLabel
        {
            get { return Fields.GlRefLabel[this]; }
            set { Fields.GlRefLabel[this] = value; }
        }

        [DisplayName("Gl Lref Entry"), Column("GL_LREF_ENTRY"), Size(1)]
        public String GlLrefEntry
        {
            get { return Fields.GlLrefEntry[this]; }
            set { Fields.GlLrefEntry[this] = value; }
        }

        [DisplayName("Gl Lref Label"), Column("GL_LREF_LABEL"), Size(12)]
        public String GlLrefLabel
        {
            get { return Fields.GlLrefLabel[this]; }
            set { Fields.GlLrefLabel[this] = value; }
        }

        [DisplayName("Gl Exch Comp"), Column("GL_EXCH_COMP"), Size(1)]
        public String GlExchComp
        {
            get { return Fields.GlExchComp[this]; }
            set { Fields.GlExchComp[this] = value; }
        }

        [DisplayName("Gl Revised By"), Column("GL_REVISED_BY"), Size(10)]
        public String GlRevisedBy
        {
            get { return Fields.GlRevisedBy[this]; }
            set { Fields.GlRevisedBy[this] = value; }
        }

        [DisplayName("Gl Revised Date"), Column("GL_REVISED_DATE")]
        public DateTime? GlRevisedDate
        {
            get { return Fields.GlRevisedDate[this]; }
            set { Fields.GlRevisedDate[this] = value; }
        }

        [DisplayName("Voch Ar Invo"), Column("VOCH_AR_INVO"), Size(6)]
        public String VochArInvo
        {
            get { return Fields.VochArInvo[this]; }
            set { Fields.VochArInvo[this] = value; }
        }

        [DisplayName("Voch Ar Memo"), Column("VOCH_AR_MEMO"), Size(6)]
        public String VochArMemo
        {
            get { return Fields.VochArMemo[this]; }
            set { Fields.VochArMemo[this] = value; }
        }

        [DisplayName("Voch Ar Adj"), Column("VOCH_AR_ADJ"), Size(6)]
        public String VochArAdj
        {
            get { return Fields.VochArAdj[this]; }
            set { Fields.VochArAdj[this] = value; }
        }

        [DisplayName("Voch Ar Pay"), Column("VOCH_AR_PAY"), Size(6)]
        public String VochArPay
        {
            get { return Fields.VochArPay[this]; }
            set { Fields.VochArPay[this] = value; }
        }

        [DisplayName("Voch Ar Alloc"), Column("VOCH_AR_ALLOC"), Size(6)]
        public String VochArAlloc
        {
            get { return Fields.VochArAlloc[this]; }
            set { Fields.VochArAlloc[this] = value; }
        }

        [DisplayName("Voch Ar Invocan"), Column("VOCH_AR_INVOCAN"), Size(6)]
        public String VochArInvocan
        {
            get { return Fields.VochArInvocan[this]; }
            set { Fields.VochArInvocan[this] = value; }
        }

        [DisplayName("Voch Ar Paycan"), Column("VOCH_AR_PAYCAN"), Size(6)]
        public String VochArPaycan
        {
            get { return Fields.VochArPaycan[this]; }
            set { Fields.VochArPaycan[this] = value; }
        }

        [DisplayName("Voch Ap Invo"), Column("VOCH_AP_INVO"), Size(6)]
        public String VochApInvo
        {
            get { return Fields.VochApInvo[this]; }
            set { Fields.VochApInvo[this] = value; }
        }

        [DisplayName("Voch Ap Memo"), Column("VOCH_AP_MEMO"), Size(6)]
        public String VochApMemo
        {
            get { return Fields.VochApMemo[this]; }
            set { Fields.VochApMemo[this] = value; }
        }

        [DisplayName("Voch Ap Adj"), Column("VOCH_AP_ADJ"), Size(6)]
        public String VochApAdj
        {
            get { return Fields.VochApAdj[this]; }
            set { Fields.VochApAdj[this] = value; }
        }

        [DisplayName("Voch Ap Pay"), Column("VOCH_AP_PAY"), Size(6)]
        public String VochApPay
        {
            get { return Fields.VochApPay[this]; }
            set { Fields.VochApPay[this] = value; }
        }

        [DisplayName("Voch Ap Alloc"), Column("VOCH_AP_ALLOC"), Size(6)]
        public String VochApAlloc
        {
            get { return Fields.VochApAlloc[this]; }
            set { Fields.VochApAlloc[this] = value; }
        }

        [DisplayName("Voch Ap Invocan"), Column("VOCH_AP_INVOCAN"), Size(6)]
        public String VochApInvocan
        {
            get { return Fields.VochApInvocan[this]; }
            set { Fields.VochApInvocan[this] = value; }
        }

        [DisplayName("Voch Ap Paycan"), Column("VOCH_AP_PAYCAN"), Size(6)]
        public String VochApPaycan
        {
            get { return Fields.VochApPaycan[this]; }
            set { Fields.VochApPaycan[this] = value; }
        }

        [DisplayName("Voch Ic Issue"), Column("VOCH_IC_ISSUE"), Size(6)]
        public String VochIcIssue
        {
            get { return Fields.VochIcIssue[this]; }
            set { Fields.VochIcIssue[this] = value; }
        }

        [DisplayName("Voch Ic Rcpt"), Column("VOCH_IC_RCPT"), Size(6)]
        public String VochIcRcpt
        {
            get { return Fields.VochIcRcpt[this]; }
            set { Fields.VochIcRcpt[this] = value; }
        }

        [DisplayName("Voch Ic Adj"), Column("VOCH_IC_ADJ"), Size(6)]
        public String VochIcAdj
        {
            get { return Fields.VochIcAdj[this]; }
            set { Fields.VochIcAdj[this] = value; }
        }

        [DisplayName("Voch Pr Issue"), Column("VOCH_PR_ISSUE"), Size(6)]
        public String VochPrIssue
        {
            get { return Fields.VochPrIssue[this]; }
            set { Fields.VochPrIssue[this] = value; }
        }

        [DisplayName("Voch Pr Return"), Column("VOCH_PR_RETURN"), Size(6)]
        public String VochPrReturn
        {
            get { return Fields.VochPrReturn[this]; }
            set { Fields.VochPrReturn[this] = value; }
        }

        [DisplayName("Voch Pr Prod"), Column("VOCH_PR_PROD"), Size(6)]
        public String VochPrProd
        {
            get { return Fields.VochPrProd[this]; }
            set { Fields.VochPrProd[this] = value; }
        }

        [DisplayName("Voch Pr Subcon"), Column("VOCH_PR_SUBCON"), Size(6)]
        public String VochPrSubcon
        {
            get { return Fields.VochPrSubcon[this]; }
            set { Fields.VochPrSubcon[this] = value; }
        }

        [DisplayName("Voch Payroll"), Column("VOCH_PAYROLL"), Size(6)]
        public String VochPayroll
        {
            get { return Fields.VochPayroll[this]; }
            set { Fields.VochPayroll[this] = value; }
        }

        [DisplayName("Voch Commission"), Column("VOCH_COMMISSION"), Size(6)]
        public String VochCommission
        {
            get { return Fields.VochCommission[this]; }
            set { Fields.VochCommission[this] = value; }
        }

        [DisplayName("Voch Fa Acquire"), Column("VOCH_FA_ACQUIRE"), Size(6)]
        public String VochFaAcquire
        {
            get { return Fields.VochFaAcquire[this]; }
            set { Fields.VochFaAcquire[this] = value; }
        }

        [DisplayName("Voch Fa Deprec"), Column("VOCH_FA_DEPREC"), Size(6)]
        public String VochFaDeprec
        {
            get { return Fields.VochFaDeprec[this]; }
            set { Fields.VochFaDeprec[this] = value; }
        }

        [DisplayName("Voch Fa Maint"), Column("VOCH_FA_MAINT"), Size(6)]
        public String VochFaMaint
        {
            get { return Fields.VochFaMaint[this]; }
            set { Fields.VochFaMaint[this] = value; }
        }

        [DisplayName("Voch Fa Dispo"), Column("VOCH_FA_DISPO"), Size(6)]
        public String VochFaDispo
        {
            get { return Fields.VochFaDispo[this]; }
            set { Fields.VochFaDispo[this] = value; }
        }

        [DisplayName("Ar Bcount Invo"), Column("AR_BCOUNT_INVO"), Size(8)]
        public Decimal? ArBcountInvo
        {
            get { return Fields.ArBcountInvo[this]; }
            set { Fields.ArBcountInvo[this] = value; }
        }

        [DisplayName("Ar Bcount Memo"), Column("AR_BCOUNT_MEMO"), Size(8)]
        public Decimal? ArBcountMemo
        {
            get { return Fields.ArBcountMemo[this]; }
            set { Fields.ArBcountMemo[this] = value; }
        }

        [DisplayName("Ar Bcount Adj"), Column("AR_BCOUNT_ADJ"), Size(8)]
        public Decimal? ArBcountAdj
        {
            get { return Fields.ArBcountAdj[this]; }
            set { Fields.ArBcountAdj[this] = value; }
        }

        [DisplayName("Ar Bcount Pay"), Column("AR_BCOUNT_PAY"), Size(8)]
        public Decimal? ArBcountPay
        {
            get { return Fields.ArBcountPay[this]; }
            set { Fields.ArBcountPay[this] = value; }
        }

        [DisplayName("Ar Bcount Alloc"), Column("AR_BCOUNT_ALLOC"), Size(8)]
        public Decimal? ArBcountAlloc
        {
            get { return Fields.ArBcountAlloc[this]; }
            set { Fields.ArBcountAlloc[this] = value; }
        }

        [DisplayName("Ap Bcount Invo"), Column("AP_BCOUNT_INVO"), Size(8)]
        public Decimal? ApBcountInvo
        {
            get { return Fields.ApBcountInvo[this]; }
            set { Fields.ApBcountInvo[this] = value; }
        }

        [DisplayName("Ap Bcount Memo"), Column("AP_BCOUNT_MEMO"), Size(8)]
        public Decimal? ApBcountMemo
        {
            get { return Fields.ApBcountMemo[this]; }
            set { Fields.ApBcountMemo[this] = value; }
        }

        [DisplayName("Ap Bcount Adj"), Column("AP_BCOUNT_ADJ"), Size(8)]
        public Decimal? ApBcountAdj
        {
            get { return Fields.ApBcountAdj[this]; }
            set { Fields.ApBcountAdj[this] = value; }
        }

        [DisplayName("Ap Bcount Pay"), Column("AP_BCOUNT_PAY"), Size(8)]
        public Decimal? ApBcountPay
        {
            get { return Fields.ApBcountPay[this]; }
            set { Fields.ApBcountPay[this] = value; }
        }

        [DisplayName("Ap Bcount Alloc"), Column("AP_BCOUNT_ALLOC"), Size(8)]
        public Decimal? ApBcountAlloc
        {
            get { return Fields.ApBcountAlloc[this]; }
            set { Fields.ApBcountAlloc[this] = value; }
        }

        [DisplayName("Cost Init"), Column("COST_INIT"), Size(1)]
        public String CostInit
        {
            get { return Fields.CostInit[this]; }
            set { Fields.CostInit[this] = value; }
        }

        [DisplayName("Cost Basis"), Column("COST_BASIS"), Size(1)]
        public String CostBasis
        {
            get { return Fields.CostBasis[this]; }
            set { Fields.CostBasis[this] = value; }
        }

        [DisplayName("Cost Rm Pr Mul"), Column("COST_RM_PR_MUL"), Size(6), Scale(2)]
        public Decimal? CostRmPrMul
        {
            get { return Fields.CostRmPrMul[this]; }
            set { Fields.CostRmPrMul[this] = value; }
        }

        [DisplayName("Cost Lb Pr Mul"), Column("COST_LB_PR_MUL"), Size(6), Scale(2)]
        public Decimal? CostLbPrMul
        {
            get { return Fields.CostLbPrMul[this]; }
            set { Fields.CostLbPrMul[this] = value; }
        }

        [DisplayName("Cost Ov Pr Mul"), Column("COST_OV_PR_MUL"), Size(6), Scale(2)]
        public Decimal? CostOvPrMul
        {
            get { return Fields.CostOvPrMul[this]; }
            set { Fields.CostOvPrMul[this] = value; }
        }

        [DisplayName("Cost Rm Sl Mul"), Column("COST_RM_SL_MUL"), Size(6), Scale(2)]
        public Decimal? CostRmSlMul
        {
            get { return Fields.CostRmSlMul[this]; }
            set { Fields.CostRmSlMul[this] = value; }
        }

        [DisplayName("Cost Lb Sl Mul"), Column("COST_LB_SL_MUL"), Size(6), Scale(2)]
        public Decimal? CostLbSlMul
        {
            get { return Fields.CostLbSlMul[this]; }
            set { Fields.CostLbSlMul[this] = value; }
        }

        [DisplayName("Cost Ov Sl Mul"), Column("COST_OV_SL_MUL"), Size(6), Scale(2)]
        public Decimal? CostOvSlMul
        {
            get { return Fields.CostOvSlMul[this]; }
            set { Fields.CostOvSlMul[this] = value; }
        }

        [DisplayName("Cost Revised By"), Column("COST_REVISED_BY"), Size(10)]
        public String CostRevisedBy
        {
            get { return Fields.CostRevisedBy[this]; }
            set { Fields.CostRevisedBy[this] = value; }
        }

        [DisplayName("Cost Rev Date"), Column("COST_REV_DATE")]
        public DateTime? CostRevDate
        {
            get { return Fields.CostRevDate[this]; }
            set { Fields.CostRevDate[this] = value; }
        }

        [DisplayName("Pr Cost Verify"), Column("PR_COST_VERIFY"), Size(1)]
        public String PrCostVerify
        {
            get { return Fields.PrCostVerify[this]; }
            set { Fields.PrCostVerify[this] = value; }
        }

        [DisplayName("Pr Cost Edit"), Column("PR_COST_EDIT"), Size(1)]
        public String PrCostEdit
        {
            get { return Fields.PrCostEdit[this]; }
            set { Fields.PrCostEdit[this] = value; }
        }

        [DisplayName("Commis Type"), Column("COMMIS_TYPE"), Size(6)]
        public String CommisType
        {
            get { return Fields.CommisType[this]; }
            set { Fields.CommisType[this] = value; }
        }

        [DisplayName("Slso Cust Item"), Column("SLSO_CUST_ITEM"), Size(1)]
        public String SlsoCustItem
        {
            get { return Fields.SlsoCustItem[this]; }
            set { Fields.SlsoCustItem[this] = value; }
        }

        [DisplayName("Slso Pkg Type"), Column("SLSO_PKG_TYPE"), Size(6)]
        public String SlsoPkgType
        {
            get { return Fields.SlsoPkgType[this]; }
            set { Fields.SlsoPkgType[this] = value; }
        }

        [DisplayName("Ic Auto Ship"), Column("IC_AUTO_SHIP"), Size(1)]
        public String IcAutoShip
        {
            get { return Fields.IcAutoShip[this]; }
            set { Fields.IcAutoShip[this] = value; }
        }

        [DisplayName("Ic Auto Slret"), Column("IC_AUTO_SLRET"), Size(1)]
        public String IcAutoSlret
        {
            get { return Fields.IcAutoSlret[this]; }
            set { Fields.IcAutoSlret[this] = value; }
        }

        [DisplayName("Ic Auto Grn"), Column("IC_AUTO_GRN"), Size(1)]
        public String IcAutoGrn
        {
            get { return Fields.IcAutoGrn[this]; }
            set { Fields.IcAutoGrn[this] = value; }
        }

        [DisplayName("Ic Auto Qc"), Column("IC_AUTO_QC"), Size(1)]
        public String IcAutoQc
        {
            get { return Fields.IcAutoQc[this]; }
            set { Fields.IcAutoQc[this] = value; }
        }

        [DisplayName("Ic Auto Puret"), Column("IC_AUTO_PURET"), Size(1)]
        public String IcAutoPuret
        {
            get { return Fields.IcAutoPuret[this]; }
            set { Fields.IcAutoPuret[this] = value; }
        }

        [DisplayName("Ic Auto Workc"), Column("IC_AUTO_WORKC"), Size(1)]
        public String IcAutoWorkc
        {
            get { return Fields.IcAutoWorkc[this]; }
            set { Fields.IcAutoWorkc[this] = value; }
        }

        [DisplayName("Ap Ovride Rate"), Column("AP_OVRIDE_RATE"), Size(1)]
        public String ApOvrideRate
        {
            get { return Fields.ApOvrideRate[this]; }
            set { Fields.ApOvrideRate[this] = value; }
        }

        [DisplayName("Slso Sch Entry"), Column("SLSO_SCH_ENTRY"), Size(1)]
        public String SlsoSchEntry
        {
            get { return Fields.SlsoSchEntry[this]; }
            set { Fields.SlsoSchEntry[this] = value; }
        }

        [DisplayName("Pupo Sch Entry"), Column("PUPO_SCH_ENTRY"), Size(1)]
        public String PupoSchEntry
        {
            get { return Fields.PupoSchEntry[this]; }
            set { Fields.PupoSchEntry[this] = value; }
        }

        [DisplayName("Slso Contact"), Column("SLSO_CONTACT"), Size(12)]
        public String SlsoContact
        {
            get { return Fields.SlsoContact[this]; }
            set { Fields.SlsoContact[this] = value; }
        }

        [DisplayName("Slso Ordr Pack"), Column("SLSO_ORDR_PACK"), Size(1)]
        public String SlsoOrdrPack
        {
            get { return Fields.SlsoOrdrPack[this]; }
            set { Fields.SlsoOrdrPack[this] = value; }
        }

        [DisplayName("Max Users"), Column("MAX_USERS"), Size(6)]
        public Decimal? MaxUsers
        {
            get { return Fields.MaxUsers[this]; }
            set { Fields.MaxUsers[this] = value; }
        }

        [DisplayName("Mmu Key"), Column("MMU_KEY"), Size(20)]
        public String MmuKey
        {
            get { return Fields.MmuKey[this]; }
            set { Fields.MmuKey[this] = value; }
        }

        [DisplayName("Acct Anlys 1"), Column("ACCT_ANLYS_1"), Size(30)]
        public String AcctAnlys1
        {
            get { return Fields.AcctAnlys1[this]; }
            set { Fields.AcctAnlys1[this] = value; }
        }

        [DisplayName("Acct Anlys 2"), Column("ACCT_ANLYS_2"), Size(30)]
        public String AcctAnlys2
        {
            get { return Fields.AcctAnlys2[this]; }
            set { Fields.AcctAnlys2[this] = value; }
        }

        [DisplayName("Acct Anlys 3"), Column("ACCT_ANLYS_3"), Size(30)]
        public String AcctAnlys3
        {
            get { return Fields.AcctAnlys3[this]; }
            set { Fields.AcctAnlys3[this] = value; }
        }

        [DisplayName("Acct Anlys 4"), Column("ACCT_ANLYS_4"), Size(30)]
        public String AcctAnlys4
        {
            get { return Fields.AcctAnlys4[this]; }
            set { Fields.AcctAnlys4[this] = value; }
        }

        [DisplayName("Voch Anlys 1"), Column("VOCH_ANLYS_1"), Size(30)]
        public String VochAnlys1
        {
            get { return Fields.VochAnlys1[this]; }
            set { Fields.VochAnlys1[this] = value; }
        }

        [DisplayName("Voch Anlys 2"), Column("VOCH_ANLYS_2"), Size(30)]
        public String VochAnlys2
        {
            get { return Fields.VochAnlys2[this]; }
            set { Fields.VochAnlys2[this] = value; }
        }

        [DisplayName("Voch Anlys 3"), Column("VOCH_ANLYS_3"), Size(30)]
        public String VochAnlys3
        {
            get { return Fields.VochAnlys3[this]; }
            set { Fields.VochAnlys3[this] = value; }
        }

        [DisplayName("Voch Anlys 4"), Column("VOCH_ANLYS_4"), Size(30)]
        public String VochAnlys4
        {
            get { return Fields.VochAnlys4[this]; }
            set { Fields.VochAnlys4[this] = value; }
        }

        [DisplayName("Voch Anlys 5"), Column("VOCH_ANLYS_5"), Size(30)]
        public String VochAnlys5
        {
            get { return Fields.VochAnlys5[this]; }
            set { Fields.VochAnlys5[this] = value; }
        }

        [DisplayName("Voch Anlys 6"), Column("VOCH_ANLYS_6"), Size(30)]
        public String VochAnlys6
        {
            get { return Fields.VochAnlys6[this]; }
            set { Fields.VochAnlys6[this] = value; }
        }

        [DisplayName("Item Anlys 1"), Column("ITEM_ANLYS_1"), Size(30)]
        public String ItemAnlys1
        {
            get { return Fields.ItemAnlys1[this]; }
            set { Fields.ItemAnlys1[this] = value; }
        }

        [DisplayName("Item Anlys 2"), Column("ITEM_ANLYS_2"), Size(30)]
        public String ItemAnlys2
        {
            get { return Fields.ItemAnlys2[this]; }
            set { Fields.ItemAnlys2[this] = value; }
        }

        [DisplayName("Item Anlys 3"), Column("ITEM_ANLYS_3"), Size(30)]
        public String ItemAnlys3
        {
            get { return Fields.ItemAnlys3[this]; }
            set { Fields.ItemAnlys3[this] = value; }
        }

        [DisplayName("Item Anlys 4"), Column("ITEM_ANLYS_4"), Size(30)]
        public String ItemAnlys4
        {
            get { return Fields.ItemAnlys4[this]; }
            set { Fields.ItemAnlys4[this] = value; }
        }

        [DisplayName("Cust Anlys 1"), Column("CUST_ANLYS_1"), Size(30)]
        public String CustAnlys1
        {
            get { return Fields.CustAnlys1[this]; }
            set { Fields.CustAnlys1[this] = value; }
        }

        [DisplayName("Cust Anlys 2"), Column("CUST_ANLYS_2"), Size(30)]
        public String CustAnlys2
        {
            get { return Fields.CustAnlys2[this]; }
            set { Fields.CustAnlys2[this] = value; }
        }

        [DisplayName("Cust Anlys 3"), Column("CUST_ANLYS_3"), Size(30)]
        public String CustAnlys3
        {
            get { return Fields.CustAnlys3[this]; }
            set { Fields.CustAnlys3[this] = value; }
        }

        [DisplayName("Cust Anlys 4"), Column("CUST_ANLYS_4"), Size(30)]
        public String CustAnlys4
        {
            get { return Fields.CustAnlys4[this]; }
            set { Fields.CustAnlys4[this] = value; }
        }

        [DisplayName("Vend Anlys 1"), Column("VEND_ANLYS_1"), Size(30)]
        public String VendAnlys1
        {
            get { return Fields.VendAnlys1[this]; }
            set { Fields.VendAnlys1[this] = value; }
        }

        [DisplayName("Vend Anlys 2"), Column("VEND_ANLYS_2"), Size(30)]
        public String VendAnlys2
        {
            get { return Fields.VendAnlys2[this]; }
            set { Fields.VendAnlys2[this] = value; }
        }

        [DisplayName("Vend Anlys 3"), Column("VEND_ANLYS_3"), Size(30)]
        public String VendAnlys3
        {
            get { return Fields.VendAnlys3[this]; }
            set { Fields.VendAnlys3[this] = value; }
        }

        [DisplayName("Vend Anlys 4"), Column("VEND_ANLYS_4"), Size(30)]
        public String VendAnlys4
        {
            get { return Fields.VendAnlys4[this]; }
            set { Fields.VendAnlys4[this] = value; }
        }

        [DisplayName("Sale Anlys 1"), Column("SALE_ANLYS_1"), Size(30)]
        public String SaleAnlys1
        {
            get { return Fields.SaleAnlys1[this]; }
            set { Fields.SaleAnlys1[this] = value; }
        }

        [DisplayName("Sale Anlys 2"), Column("SALE_ANLYS_2"), Size(30)]
        public String SaleAnlys2
        {
            get { return Fields.SaleAnlys2[this]; }
            set { Fields.SaleAnlys2[this] = value; }
        }

        [DisplayName("Sale Anlys 3"), Column("SALE_ANLYS_3"), Size(30)]
        public String SaleAnlys3
        {
            get { return Fields.SaleAnlys3[this]; }
            set { Fields.SaleAnlys3[this] = value; }
        }

        [DisplayName("Sale Anlys 4"), Column("SALE_ANLYS_4"), Size(30)]
        public String SaleAnlys4
        {
            get { return Fields.SaleAnlys4[this]; }
            set { Fields.SaleAnlys4[this] = value; }
        }

        [DisplayName("Sale Anlys 5"), Column("SALE_ANLYS_5"), Size(30)]
        public String SaleAnlys5
        {
            get { return Fields.SaleAnlys5[this]; }
            set { Fields.SaleAnlys5[this] = value; }
        }

        [DisplayName("Sale Anlys 6"), Column("SALE_ANLYS_6"), Size(30)]
        public String SaleAnlys6
        {
            get { return Fields.SaleAnlys6[this]; }
            set { Fields.SaleAnlys6[this] = value; }
        }

        [DisplayName("Purc Anlys 1"), Column("PURC_ANLYS_1"), Size(30)]
        public String PurcAnlys1
        {
            get { return Fields.PurcAnlys1[this]; }
            set { Fields.PurcAnlys1[this] = value; }
        }

        [DisplayName("Purc Anlys 2"), Column("PURC_ANLYS_2"), Size(30)]
        public String PurcAnlys2
        {
            get { return Fields.PurcAnlys2[this]; }
            set { Fields.PurcAnlys2[this] = value; }
        }

        [DisplayName("Purc Anlys 3"), Column("PURC_ANLYS_3"), Size(30)]
        public String PurcAnlys3
        {
            get { return Fields.PurcAnlys3[this]; }
            set { Fields.PurcAnlys3[this] = value; }
        }

        [DisplayName("Purc Anlys 4"), Column("PURC_ANLYS_4"), Size(30)]
        public String PurcAnlys4
        {
            get { return Fields.PurcAnlys4[this]; }
            set { Fields.PurcAnlys4[this] = value; }
        }

        [DisplayName("Purc Anlys 5"), Column("PURC_ANLYS_5"), Size(30)]
        public String PurcAnlys5
        {
            get { return Fields.PurcAnlys5[this]; }
            set { Fields.PurcAnlys5[this] = value; }
        }

        [DisplayName("Purc Anlys 6"), Column("PURC_ANLYS_6"), Size(30)]
        public String PurcAnlys6
        {
            get { return Fields.PurcAnlys6[this]; }
            set { Fields.PurcAnlys6[this] = value; }
        }

        [DisplayName("Mvmt Anlys 1"), Column("MVMT_ANLYS_1"), Size(30)]
        public String MvmtAnlys1
        {
            get { return Fields.MvmtAnlys1[this]; }
            set { Fields.MvmtAnlys1[this] = value; }
        }

        [DisplayName("Mvmt Anlys 2"), Column("MVMT_ANLYS_2"), Size(30)]
        public String MvmtAnlys2
        {
            get { return Fields.MvmtAnlys2[this]; }
            set { Fields.MvmtAnlys2[this] = value; }
        }

        [DisplayName("Mvmt Anlys 3"), Column("MVMT_ANLYS_3"), Size(30)]
        public String MvmtAnlys3
        {
            get { return Fields.MvmtAnlys3[this]; }
            set { Fields.MvmtAnlys3[this] = value; }
        }

        [DisplayName("Mvmt Anlys 4"), Column("MVMT_ANLYS_4"), Size(30)]
        public String MvmtAnlys4
        {
            get { return Fields.MvmtAnlys4[this]; }
            set { Fields.MvmtAnlys4[this] = value; }
        }

        [DisplayName("Mvmt Anlys 5"), Column("MVMT_ANLYS_5"), Size(30)]
        public String MvmtAnlys5
        {
            get { return Fields.MvmtAnlys5[this]; }
            set { Fields.MvmtAnlys5[this] = value; }
        }

        [DisplayName("Mvmt Anlys 6"), Column("MVMT_ANLYS_6"), Size(30)]
        public String MvmtAnlys6
        {
            get { return Fields.MvmtAnlys6[this]; }
            set { Fields.MvmtAnlys6[this] = value; }
        }

        [DisplayName("Nrevised Date"), Column("NREVISED_DATE")]
        public DateTime? NrevisedDate
        {
            get { return Fields.NrevisedDate[this]; }
            set { Fields.NrevisedDate[this] = value; }
        }

        [DisplayName("Nrevised By"), Column("NREVISED_BY"), Size(10)]
        public String NrevisedBy
        {
            get { return Fields.NrevisedBy[this]; }
            set { Fields.NrevisedBy[this] = value; }
        }

        [DisplayName("Ship Wt Uom"), Column("SHIP_WT_UOM"), Size(4)]
        public String ShipWtUom
        {
            get { return Fields.ShipWtUom[this]; }
            set { Fields.ShipWtUom[this] = value; }
        }

        [DisplayName("Ship Dim Uom"), Column("SHIP_DIM_UOM"), Size(4)]
        public String ShipDimUom
        {
            get { return Fields.ShipDimUom[this]; }
            set { Fields.ShipDimUom[this] = value; }
        }

        [DisplayName("Item Packing"), Column("ITEM_PACKING"), Size(1)]
        public String ItemPacking
        {
            get { return Fields.ItemPacking[this]; }
            set { Fields.ItemPacking[this] = value; }
        }

        [DisplayName("No Ovhd Acctg"), Column("NO_OVHD_ACCTG"), Size(1)]
        public String NoOvhdAcctg
        {
            get { return Fields.NoOvhdAcctg[this]; }
            set { Fields.NoOvhdAcctg[this] = value; }
        }

        [DisplayName("No Varia Acctg"), Column("NO_VARIA_ACCTG"), Size(1)]
        public String NoVariaAcctg
        {
            get { return Fields.NoVariaAcctg[this]; }
            set { Fields.NoVariaAcctg[this] = value; }
        }

        [DisplayName("No Fg Acctg"), Column("NO_FG_ACCTG"), Size(1)]
        public String NoFgAcctg
        {
            get { return Fields.NoFgAcctg[this]; }
            set { Fields.NoFgAcctg[this] = value; }
        }

        [DisplayName("Fg Cost Limit"), Column("FG_COST_LIMIT"), Size(1)]
        public String FgCostLimit
        {
            get { return Fields.FgCostLimit[this]; }
            set { Fields.FgCostLimit[this] = value; }
        }

        [DisplayName("Allow Desc Chg"), Column("ALLOW_DESC_CHG"), Size(1)]
        public String AllowDescChg
        {
            get { return Fields.AllowDescChg[this]; }
            set { Fields.AllowDescChg[this] = value; }
        }

        [DisplayName("No Labor Acctg"), Column("NO_LABOR_ACCTG"), Size(1)]
        public String NoLaborAcctg
        {
            get { return Fields.NoLaborAcctg[this]; }
            set { Fields.NoLaborAcctg[this] = value; }
        }

        [DisplayName("No Subcon Acctg"), Column("NO_SUBCON_ACCTG"), Size(1)]
        public String NoSubconAcctg
        {
            get { return Fields.NoSubconAcctg[this]; }
            set { Fields.NoSubconAcctg[this] = value; }
        }

        [DisplayName("Reorder Is New"), Column("REORDER_IS_NEW"), Size(1)]
        public String ReorderIsNew
        {
            get { return Fields.ReorderIsNew[this]; }
            set { Fields.ReorderIsNew[this] = value; }
        }

        [DisplayName("Def Insp Std"), Column("DEF_INSP_STD"), Size(10)]
        public String DefInspStd
        {
            get { return Fields.DefInspStd[this]; }
            set { Fields.DefInspStd[this] = value; }
        }

        [DisplayName("Def Insp Lvl"), Column("DEF_INSP_LVL"), Size(1)]
        public String DefInspLvl
        {
            get { return Fields.DefInspLvl[this]; }
            set { Fields.DefInspLvl[this] = value; }
        }

        [DisplayName("Def Aql Lvl Maj"), Column("DEF_AQL_LVL_MAJ"), Size(10)]
        public String DefAqlLvlMaj
        {
            get { return Fields.DefAqlLvlMaj[this]; }
            set { Fields.DefAqlLvlMaj[this] = value; }
        }

        [DisplayName("Def Aql Lvl Min"), Column("DEF_AQL_LVL_MIN"), Size(10)]
        public String DefAqlLvlMin
        {
            get { return Fields.DefAqlLvlMin[this]; }
            set { Fields.DefAqlLvlMin[this] = value; }
        }

        [DisplayName("Return Email"), Column("RETURN_EMAIL"), Size(100)]
        public String ReturnEmail
        {
            get { return Fields.ReturnEmail[this]; }
            set { Fields.ReturnEmail[this] = value; }
        }

        [DisplayName("Smtp Server"), Column("SMTP_SERVER"), Size(50)]
        public String SmtpServer
        {
            get { return Fields.SmtpServer[this]; }
            set { Fields.SmtpServer[this] = value; }
        }

        [DisplayName("Web Setting1"), Column("WEB_SETTING1"), Size(1)]
        public String WebSetting1
        {
            get { return Fields.WebSetting1[this]; }
            set { Fields.WebSetting1[this] = value; }
        }

        [DisplayName("Web Setting2"), Column("WEB_SETTING2"), Size(1)]
        public String WebSetting2
        {
            get { return Fields.WebSetting2[this]; }
            set { Fields.WebSetting2[this] = value; }
        }

        [DisplayName("Web Setting3"), Column("WEB_SETTING3"), Size(1)]
        public String WebSetting3
        {
            get { return Fields.WebSetting3[this]; }
            set { Fields.WebSetting3[this] = value; }
        }

        [DisplayName("Web Setting4"), Column("WEB_SETTING4"), Size(1)]
        public String WebSetting4
        {
            get { return Fields.WebSetting4[this]; }
            set { Fields.WebSetting4[this] = value; }
        }

        [DisplayName("Pupo Price Ctrl"), Column("PUPO_PRICE_CTRL"), Size(1)]
        public String PupoPriceCtrl
        {
            get { return Fields.PupoPriceCtrl[this]; }
            set { Fields.PupoPriceCtrl[this] = value; }
        }

        [DisplayName("Jord Anlys 1"), Column("JORD_ANLYS_1"), Size(30)]
        public String JordAnlys1
        {
            get { return Fields.JordAnlys1[this]; }
            set { Fields.JordAnlys1[this] = value; }
        }

        [DisplayName("Jord Anlys 2"), Column("JORD_ANLYS_2"), Size(30)]
        public String JordAnlys2
        {
            get { return Fields.JordAnlys2[this]; }
            set { Fields.JordAnlys2[this] = value; }
        }

        [DisplayName("Jord Anlys 3"), Column("JORD_ANLYS_3"), Size(30)]
        public String JordAnlys3
        {
            get { return Fields.JordAnlys3[this]; }
            set { Fields.JordAnlys3[this] = value; }
        }

        [DisplayName("Jord Anlys 4"), Column("JORD_ANLYS_4"), Size(30)]
        public String JordAnlys4
        {
            get { return Fields.JordAnlys4[this]; }
            set { Fields.JordAnlys4[this] = value; }
        }

        [DisplayName("Jord Anlys 5"), Column("JORD_ANLYS_5"), Size(30)]
        public String JordAnlys5
        {
            get { return Fields.JordAnlys5[this]; }
            set { Fields.JordAnlys5[this] = value; }
        }

        [DisplayName("Jord Anlys 6"), Column("JORD_ANLYS_6"), Size(30)]
        public String JordAnlys6
        {
            get { return Fields.JordAnlys6[this]; }
            set { Fields.JordAnlys6[this] = value; }
        }

        [DisplayName("Prod Pos Entry"), Column("PROD_POS_ENTRY"), Size(1)]
        public String ProdPosEntry
        {
            get { return Fields.ProdPosEntry[this]; }
            set { Fields.ProdPosEntry[this] = value; }
        }

        [DisplayName("Glar Text 1"), Column("GLAR_TEXT_1"), Size(6)]
        public String GlarText1
        {
            get { return Fields.GlarText1[this]; }
            set { Fields.GlarText1[this] = value; }
        }

        [DisplayName("Glar Text 2"), Column("GLAR_TEXT_2"), Size(6)]
        public String GlarText2
        {
            get { return Fields.GlarText2[this]; }
            set { Fields.GlarText2[this] = value; }
        }

        [DisplayName("Glar Text 3"), Column("GLAR_TEXT_3"), Size(6)]
        public String GlarText3
        {
            get { return Fields.GlarText3[this]; }
            set { Fields.GlarText3[this] = value; }
        }

        [DisplayName("Glar Text 4"), Column("GLAR_TEXT_4"), Size(6)]
        public String GlarText4
        {
            get { return Fields.GlarText4[this]; }
            set { Fields.GlarText4[this] = value; }
        }

        [DisplayName("Pr Job Close"), Column("PR_JOB_CLOSE"), Size(1)]
        public String PrJobClose
        {
            get { return Fields.PrJobClose[this]; }
            set { Fields.PrJobClose[this] = value; }
        }

        [DisplayName("Slso Unfull Pack Response"), Column("SLSO_UNFULL_PACK_RESPONSE"), Size(10)]
        public String SlsoUnfullPackResponse
        {
            get { return Fields.SlsoUnfullPackResponse[this]; }
            set { Fields.SlsoUnfullPackResponse[this] = value; }
        }

        [DisplayName("Slso Def Multi Ship"), Column("SLSO_DEF_MULTI_SHIP"), Size(1)]
        public String SlsoDefMultiShip
        {
            get { return Fields.SlsoDefMultiShip[this]; }
            set { Fields.SlsoDefMultiShip[this] = value; }
        }

        [DisplayName("Slso Def Auto Po"), Column("SLSO_DEF_AUTO_PO"), Size(1)]
        public String SlsoDefAutoPo
        {
            get { return Fields.SlsoDefAutoPo[this]; }
            set { Fields.SlsoDefAutoPo[this] = value; }
        }

        [DisplayName("Slso Def Auto Jo"), Column("SLSO_DEF_AUTO_JO"), Size(1)]
        public String SlsoDefAutoJo
        {
            get { return Fields.SlsoDefAutoJo[this]; }
            set { Fields.SlsoDefAutoJo[this] = value; }
        }

        [DisplayName("Slpa Ext Desc"), Column("SLPA_EXT_DESC"), Size(1)]
        public String SlpaExtDesc
        {
            get { return Fields.SlpaExtDesc[this]; }
            set { Fields.SlpaExtDesc[this] = value; }
        }

        [DisplayName("Pupo Due Lead"), Column("PUPO_DUE_LEAD"), Size(4)]
        public Decimal? PupoDueLead
        {
            get { return Fields.PupoDueLead[this]; }
            set { Fields.PupoDueLead[this] = value; }
        }

        [DisplayName("Pupo Sch Lead"), Column("PUPO_SCH_LEAD"), Size(4)]
        public Decimal? PupoSchLead
        {
            get { return Fields.PupoSchLead[this]; }
            set { Fields.PupoSchLead[this] = value; }
        }

        [DisplayName("Pr Multi Issue"), Column("PR_MULTI_ISSUE"), Size(1)]
        public String PrMultiIssue
        {
            get { return Fields.PrMultiIssue[this]; }
            set { Fields.PrMultiIssue[this] = value; }
        }

        [DisplayName("Prod Sep Route"), Column("PROD_SEP_ROUTE"), Size(1)]
        public String ProdSepRoute
        {
            get { return Fields.ProdSepRoute[this]; }
            set { Fields.ProdSepRoute[this] = value; }
        }

        [DisplayName("Prod Hide Wc Subcon"), Column("PROD_HIDE_WC_SUBCON"), Size(1)]
        public String ProdHideWcSubcon
        {
            get { return Fields.ProdHideWcSubcon[this]; }
            set { Fields.ProdHideWcSubcon[this] = value; }
        }

        [DisplayName("Copy Text From So"), Column("COPY_TEXT_FROM_SO"), Size(1)]
        public String CopyTextFromSo
        {
            get { return Fields.CopyTextFromSo[this]; }
            set { Fields.CopyTextFromSo[this] = value; }
        }

        [DisplayName("Prpm Text 1"), Column("PRPM_TEXT_1"), Size(6)]
        public String PrpmText1
        {
            get { return Fields.PrpmText1[this]; }
            set { Fields.PrpmText1[this] = value; }
        }

        [DisplayName("Prpm Text 2"), Column("PRPM_TEXT_2"), Size(6)]
        public String PrpmText2
        {
            get { return Fields.PrpmText2[this]; }
            set { Fields.PrpmText2[this] = value; }
        }

        [DisplayName("Prpm Text 3"), Column("PRPM_TEXT_3"), Size(6)]
        public String PrpmText3
        {
            get { return Fields.PrpmText3[this]; }
            set { Fields.PrpmText3[this] = value; }
        }

        [DisplayName("Prpm Text 4"), Column("PRPM_TEXT_4"), Size(6)]
        public String PrpmText4
        {
            get { return Fields.PrpmText4[this]; }
            set { Fields.PrpmText4[this] = value; }
        }

        [DisplayName("Prpm Ext Inst"), Column("PRPM_EXT_INST"), Size(1)]
        public String PrpmExtInst
        {
            get { return Fields.PrpmExtInst[this]; }
            set { Fields.PrpmExtInst[this] = value; }
        }

        [DisplayName("Bom Ver Len"), Column("BOM_VER_LEN")]
        public Int32? BomVerLen
        {
            get { return Fields.BomVerLen[this]; }
            set { Fields.BomVerLen[this] = value; }
        }

        [DisplayName("Prod Po Price"), Column("PROD_PO_PRICE"), Size(1)]
        public String ProdPoPrice
        {
            get { return Fields.ProdPoPrice[this]; }
            set { Fields.ProdPoPrice[this] = value; }
        }

        [DisplayName("Sale Anlys 7"), Column("SALE_ANLYS_7"), Size(30)]
        public String SaleAnlys7
        {
            get { return Fields.SaleAnlys7[this]; }
            set { Fields.SaleAnlys7[this] = value; }
        }

        [DisplayName("Sale Anlys 8"), Column("SALE_ANLYS_8"), Size(30)]
        public String SaleAnlys8
        {
            get { return Fields.SaleAnlys8[this]; }
            set { Fields.SaleAnlys8[this] = value; }
        }

        [DisplayName("Purc Anlys 7"), Column("PURC_ANLYS_7"), Size(30)]
        public String PurcAnlys7
        {
            get { return Fields.PurcAnlys7[this]; }
            set { Fields.PurcAnlys7[this] = value; }
        }

        [DisplayName("Purc Anlys 8"), Column("PURC_ANLYS_8"), Size(30)]
        public String PurcAnlys8
        {
            get { return Fields.PurcAnlys8[this]; }
            set { Fields.PurcAnlys8[this] = value; }
        }

        [DisplayName("Mvmt Anlys 7"), Column("MVMT_ANLYS_7"), Size(30)]
        public String MvmtAnlys7
        {
            get { return Fields.MvmtAnlys7[this]; }
            set { Fields.MvmtAnlys7[this] = value; }
        }

        [DisplayName("Mvmt Anlys 8"), Column("MVMT_ANLYS_8"), Size(30)]
        public String MvmtAnlys8
        {
            get { return Fields.MvmtAnlys8[this]; }
            set { Fields.MvmtAnlys8[this] = value; }
        }

        [DisplayName("Voch Anlys 7"), Column("VOCH_ANLYS_7"), Size(30)]
        public String VochAnlys7
        {
            get { return Fields.VochAnlys7[this]; }
            set { Fields.VochAnlys7[this] = value; }
        }

        [DisplayName("Voch Anlys 8"), Column("VOCH_ANLYS_8"), Size(30)]
        public String VochAnlys8
        {
            get { return Fields.VochAnlys8[this]; }
            set { Fields.VochAnlys8[this] = value; }
        }

        [DisplayName("Jord Anlys 7"), Column("JORD_ANLYS_7"), Size(30)]
        public String JordAnlys7
        {
            get { return Fields.JordAnlys7[this]; }
            set { Fields.JordAnlys7[this] = value; }
        }

        [DisplayName("Jord Anlys 8"), Column("JORD_ANLYS_8"), Size(30)]
        public String JordAnlys8
        {
            get { return Fields.JordAnlys8[this]; }
            set { Fields.JordAnlys8[this] = value; }
        }

        [DisplayName("Ar Anlys 1"), Column("AR_ANLYS_1"), Size(30)]
        public String ArAnlys1
        {
            get { return Fields.ArAnlys1[this]; }
            set { Fields.ArAnlys1[this] = value; }
        }

        [DisplayName("Ar Anlys 2"), Column("AR_ANLYS_2"), Size(30)]
        public String ArAnlys2
        {
            get { return Fields.ArAnlys2[this]; }
            set { Fields.ArAnlys2[this] = value; }
        }

        [DisplayName("Ar Anlys 3"), Column("AR_ANLYS_3"), Size(30)]
        public String ArAnlys3
        {
            get { return Fields.ArAnlys3[this]; }
            set { Fields.ArAnlys3[this] = value; }
        }

        [DisplayName("Ar Anlys 4"), Column("AR_ANLYS_4"), Size(30)]
        public String ArAnlys4
        {
            get { return Fields.ArAnlys4[this]; }
            set { Fields.ArAnlys4[this] = value; }
        }

        [DisplayName("Ar Anlys 5"), Column("AR_ANLYS_5"), Size(30)]
        public String ArAnlys5
        {
            get { return Fields.ArAnlys5[this]; }
            set { Fields.ArAnlys5[this] = value; }
        }

        [DisplayName("Ar Anlys 6"), Column("AR_ANLYS_6"), Size(30)]
        public String ArAnlys6
        {
            get { return Fields.ArAnlys6[this]; }
            set { Fields.ArAnlys6[this] = value; }
        }

        [DisplayName("Ar Anlys 7"), Column("AR_ANLYS_7"), Size(30)]
        public String ArAnlys7
        {
            get { return Fields.ArAnlys7[this]; }
            set { Fields.ArAnlys7[this] = value; }
        }

        [DisplayName("Ar Anlys 8"), Column("AR_ANLYS_8"), Size(30)]
        public String ArAnlys8
        {
            get { return Fields.ArAnlys8[this]; }
            set { Fields.ArAnlys8[this] = value; }
        }

        [DisplayName("Ap Anlys 1"), Column("AP_ANLYS_1"), Size(30)]
        public String ApAnlys1
        {
            get { return Fields.ApAnlys1[this]; }
            set { Fields.ApAnlys1[this] = value; }
        }

        [DisplayName("Ap Anlys 2"), Column("AP_ANLYS_2"), Size(30)]
        public String ApAnlys2
        {
            get { return Fields.ApAnlys2[this]; }
            set { Fields.ApAnlys2[this] = value; }
        }

        [DisplayName("Ap Anlys 3"), Column("AP_ANLYS_3"), Size(30)]
        public String ApAnlys3
        {
            get { return Fields.ApAnlys3[this]; }
            set { Fields.ApAnlys3[this] = value; }
        }

        [DisplayName("Ap Anlys 4"), Column("AP_ANLYS_4"), Size(30)]
        public String ApAnlys4
        {
            get { return Fields.ApAnlys4[this]; }
            set { Fields.ApAnlys4[this] = value; }
        }

        [DisplayName("Ap Anlys 5"), Column("AP_ANLYS_5"), Size(30)]
        public String ApAnlys5
        {
            get { return Fields.ApAnlys5[this]; }
            set { Fields.ApAnlys5[this] = value; }
        }

        [DisplayName("Ap Anlys 6"), Column("AP_ANLYS_6"), Size(30)]
        public String ApAnlys6
        {
            get { return Fields.ApAnlys6[this]; }
            set { Fields.ApAnlys6[this] = value; }
        }

        [DisplayName("Ap Anlys 7"), Column("AP_ANLYS_7"), Size(30)]
        public String ApAnlys7
        {
            get { return Fields.ApAnlys7[this]; }
            set { Fields.ApAnlys7[this] = value; }
        }

        [DisplayName("Ap Anlys 8"), Column("AP_ANLYS_8"), Size(30)]
        public String ApAnlys8
        {
            get { return Fields.ApAnlys8[this]; }
            set { Fields.ApAnlys8[this] = value; }
        }

        [DisplayName("Sl Add Info"), Column("SL_ADD_INFO"), Size(1)]
        public String SlAddInfo
        {
            get { return Fields.SlAddInfo[this]; }
            set { Fields.SlAddInfo[this] = value; }
        }

        [DisplayName("Pu Add Info"), Column("PU_ADD_INFO"), Size(1)]
        public String PuAddInfo
        {
            get { return Fields.PuAddInfo[this]; }
            set { Fields.PuAddInfo[this] = value; }
        }

        [DisplayName("Pr Add Info"), Column("PR_ADD_INFO"), Size(1)]
        public String PrAddInfo
        {
            get { return Fields.PrAddInfo[this]; }
            set { Fields.PrAddInfo[this] = value; }
        }

        [DisplayName("Ic Add Info"), Column("IC_ADD_INFO"), Size(1)]
        public String IcAddInfo
        {
            get { return Fields.IcAddInfo[this]; }
            set { Fields.IcAddInfo[this] = value; }
        }

        [DisplayName("Chk Mat Iss"), Column("CHK_MAT_ISS"), Size(1)]
        public String ChkMatIss
        {
            get { return Fields.ChkMatIss[this]; }
            set { Fields.ChkMatIss[this] = value; }
        }

        [DisplayName("Ic Def Std Cost"), Column("IC_DEF_STD_COST"), Size(1)]
        public String IcDefStdCost
        {
            get { return Fields.IcDefStdCost[this]; }
            set { Fields.IcDefStdCost[this] = value; }
        }

        [DisplayName("Check Custpo"), Column("CHECK_CUSTPO"), Size(1)]
        public String CheckCustpo
        {
            get { return Fields.CheckCustpo[this]; }
            set { Fields.CheckCustpo[this] = value; }
        }

        [DisplayName("Ctl Fg Rtn"), Column("CTL_FG_RTN"), Size(1)]
        public String CtlFgRtn
        {
            get { return Fields.CtlFgRtn[this]; }
            set { Fields.CtlFgRtn[this] = value; }
        }

        [DisplayName("Voch Ar Refund"), Column("VOCH_AR_REFUND"), Size(6)]
        public String VochArRefund
        {
            get { return Fields.VochArRefund[this]; }
            set { Fields.VochArRefund[this] = value; }
        }

        [DisplayName("Voch Ap Refund"), Column("VOCH_AP_REFUND"), Size(6)]
        public String VochApRefund
        {
            get { return Fields.VochApRefund[this]; }
            set { Fields.VochApRefund[this] = value; }
        }

        [DisplayName("Slso Dn"), Column("SLSO_DN"), Size(1), NotNull]
        public String SlsoDn
        {
            get { return Fields.SlsoDn[this]; }
            set { Fields.SlsoDn[this] = value; }
        }

        [DisplayName("Auto Inc By"), Column("AUTO_INC_BY"), Size(6)]
        public Decimal? AutoIncBy
        {
            get { return Fields.AutoIncBy[this]; }
            set { Fields.AutoIncBy[this] = value; }
        }

        [DisplayName("Quo Gen Multi So"), Column("QUO_GEN_MULTI_SO"), Size(1)]
        public String QuoGenMultiSo
        {
            get { return Fields.QuoGenMultiSo[this]; }
            set { Fields.QuoGenMultiSo[this] = value; }
        }

        [DisplayName("Pu Receive All"), Column("PU_RECEIVE_ALL"), Size(1)]
        public String PuReceiveAll
        {
            get { return Fields.PuReceiveAll[this]; }
            set { Fields.PuReceiveAll[this] = value; }
        }

        [DisplayName("Prpm Item Master Scrap"), Column("PRPM_ITEM_MASTER_SCRAP"), Size(1)]
        public String PrpmItemMasterScrap
        {
            get { return Fields.PrpmItemMasterScrap[this]; }
            set { Fields.PrpmItemMasterScrap[this] = value; }
        }

        [DisplayName("Ic Disable Commit"), Column("IC_DISABLE_COMMIT"), Size(1)]
        public String IcDisableCommit
        {
            get { return Fields.IcDisableCommit[this]; }
            set { Fields.IcDisableCommit[this] = value; }
        }

        [DisplayName("Prod Def Mat Remarks"), Column("PROD_DEF_MAT_REMARKS"), Size(1)]
        public String ProdDefMatRemarks
        {
            get { return Fields.ProdDefMatRemarks[this]; }
            set { Fields.ProdDefMatRemarks[this] = value; }
        }

        [DisplayName("Slso Update Qty From Sch"), Column("SLSO_UPDATE_QTY_FROM_SCH"), Size(1)]
        public String SlsoUpdateQtyFromSch
        {
            get { return Fields.SlsoUpdateQtyFromSch[this]; }
            set { Fields.SlsoUpdateQtyFromSch[this] = value; }
        }

        [DisplayName("Pupo Update Qty From Sch"), Column("PUPO_UPDATE_QTY_FROM_SCH"), Size(1)]
        public String PupoUpdateQtyFromSch
        {
            get { return Fields.PupoUpdateQtyFromSch[this]; }
            set { Fields.PupoUpdateQtyFromSch[this] = value; }
        }

        [DisplayName("Slso Default Base Price"), Column("SLSO_DEFAULT_BASE_PRICE"), Size(1)]
        public String SlsoDefaultBasePrice
        {
            get { return Fields.SlsoDefaultBasePrice[this]; }
            set { Fields.SlsoDefaultBasePrice[this] = value; }
        }

        [DisplayName("Slso Discount By Customer"), Column("SLSO_DISCOUNT_BY_CUSTOMER"), Size(1)]
        public String SlsoDiscountByCustomer
        {
            get { return Fields.SlsoDiscountByCustomer[this]; }
            set { Fields.SlsoDiscountByCustomer[this] = value; }
        }

        [DisplayName("Prpm Max Qty In Storage"), Column("PRPM_MAX_QTY_IN_STORAGE"), Size(1)]
        public String PrpmMaxQtyInStorage
        {
            get { return Fields.PrpmMaxQtyInStorage[this]; }
            set { Fields.PrpmMaxQtyInStorage[this] = value; }
        }

        [DisplayName("Ic Def Cost Type"), Column("IC_DEF_COST_TYPE"), Size(1), NotNull]
        public String IcDefCostType
        {
            get { return Fields.IcDefCostType[this]; }
            set { Fields.IcDefCostType[this] = value; }
        }

        [DisplayName("Prod Bom Create Item"), Column("PROD_BOM_CREATE_ITEM"), Size(1)]
        public String ProdBomCreateItem
        {
            get { return Fields.ProdBomCreateItem[this]; }
            set { Fields.ProdBomCreateItem[this] = value; }
        }

        [DisplayName("Pupo Rtv Loc"), Column("PUPO_RTV_LOC"), Size(4)]
        public String PupoRtvLoc
        {
            get { return Fields.PupoRtvLoc[this]; }
            set { Fields.PupoRtvLoc[this] = value; }
        }

        [DisplayName("Prpm Use All Mat Last Wc"), Column("PRPM_USE_ALL_MAT_LAST_WC"), Size(1)]
        public String PrpmUseAllMatLastWc
        {
            get { return Fields.PrpmUseAllMatLastWc[this]; }
            set { Fields.PrpmUseAllMatLastWc[this] = value; }
        }

        [DisplayName("Ic No Def Charge"), Column("IC_NO_DEF_CHARGE"), Size(1)]
        public String IcNoDefCharge
        {
            get { return Fields.IcNoDefCharge[this]; }
            set { Fields.IcNoDefCharge[this] = value; }
        }

        [DisplayName("Prod Def Phantom Bom"), Column("PROD_DEF_PHANTOM_BOM"), Size(1)]
        public String ProdDefPhantomBom
        {
            get { return Fields.ProdDefPhantomBom[this]; }
            set { Fields.ProdDefPhantomBom[this] = value; }
        }

        [DisplayName("Slso Need Cm Approval"), Column("SLSO_NEED_CM_APPROVAL"), Size(1)]
        public String SlsoNeedCmApproval
        {
            get { return Fields.SlsoNeedCmApproval[this]; }
            set { Fields.SlsoNeedCmApproval[this] = value; }
        }

        [DisplayName("Pupo Need Vm Approval"), Column("PUPO_NEED_VM_APPROVAL"), Size(1)]
        public String PupoNeedVmApproval
        {
            get { return Fields.PupoNeedVmApproval[this]; }
            set { Fields.PupoNeedVmApproval[this] = value; }
        }

        [DisplayName("Prod Need Bom Approval"), Column("PROD_NEED_BOM_APPROVAL"), Size(1)]
        public String ProdNeedBomApproval
        {
            get { return Fields.ProdNeedBomApproval[this]; }
            set { Fields.ProdNeedBomApproval[this] = value; }
        }

        [DisplayName("Prod Need Im Approval"), Column("PROD_NEED_IM_APPROVAL"), Size(1)]
        public String ProdNeedImApproval
        {
            get { return Fields.ProdNeedImApproval[this]; }
            set { Fields.ProdNeedImApproval[this] = value; }
        }

        [DisplayName("Prpm Need Scrap Reason"), Column("PRPM_NEED_SCRAP_REASON"), Size(1)]
        public String PrpmNeedScrapReason
        {
            get { return Fields.PrpmNeedScrapReason[this]; }
            set { Fields.PrpmNeedScrapReason[this] = value; }
        }

        [DisplayName("Prpm Must Backflush"), Column("PRPM_MUST_BACKFLUSH"), Size(1)]
        public String PrpmMustBackflush
        {
            get { return Fields.PrpmMustBackflush[this]; }
            set { Fields.PrpmMustBackflush[this] = value; }
        }

        [DisplayName("Pupo Auto Order Link"), Column("PUPO_AUTO_ORDER_LINK"), Size(1)]
        public String PupoAutoOrderLink
        {
            get { return Fields.PupoAutoOrderLink[this]; }
            set { Fields.PupoAutoOrderLink[this] = value; }
        }

        [DisplayName("Prpm Auto Order Link"), Column("PRPM_AUTO_ORDER_LINK"), Size(1)]
        public String PrpmAutoOrderLink
        {
            get { return Fields.PrpmAutoOrderLink[this]; }
            set { Fields.PrpmAutoOrderLink[this] = value; }
        }

        [DisplayName("Prpe Allow Chg Job"), Column("PRPE_ALLOW_CHG_JOB"), Size(1)]
        public String PrpeAllowChgJob
        {
            get { return Fields.PrpeAllowChgJob[this]; }
            set { Fields.PrpeAllowChgJob[this] = value; }
        }

        [DisplayName("Voch Pr Inspect"), Column("VOCH_PR_INSPECT"), Size(6)]
        public String VochPrInspect
        {
            get { return Fields.VochPrInspect[this]; }
            set { Fields.VochPrInspect[this] = value; }
        }

        [DisplayName("Voch Pr Rework"), Column("VOCH_PR_REWORK"), Size(6)]
        public String VochPrRework
        {
            get { return Fields.VochPrRework[this]; }
            set { Fields.VochPrRework[this] = value; }
        }

        [DisplayName("Prod Need Plan Rlse Approval"), Column("PROD_NEED_PLAN_RLSE_APPROVAL"), Size(1)]
        public String ProdNeedPlanRlseApproval
        {
            get { return Fields.ProdNeedPlanRlseApproval[this]; }
            set { Fields.ProdNeedPlanRlseApproval[this] = value; }
        }

        [DisplayName("Prpm Include Scrap In Mmi"), Column("PRPM_INCLUDE_SCRAP_IN_MMI"), Size(1)]
        public String PrpmIncludeScrapInMmi
        {
            get { return Fields.PrpmIncludeScrapInMmi[this]; }
            set { Fields.PrpmIncludeScrapInMmi[this] = value; }
        }

        [DisplayName("Prod Scrap Loc"), Column("PROD_SCRAP_LOC"), Size(4)]
        public String ProdScrapLoc
        {
            get { return Fields.ProdScrapLoc[this]; }
            set { Fields.ProdScrapLoc[this] = value; }
        }

        [DisplayName("Mvt Pr Scrap"), Column("MVT_PR_SCRAP"), Size(6)]
        public String MvtPrScrap
        {
            get { return Fields.MvtPrScrap[this]; }
            set { Fields.MvtPrScrap[this] = value; }
        }

        [DisplayName("Sl Need Cl Approval"), Column("SL_NEED_CL_APPROVAL"), Size(1)]
        public String SlNeedClApproval
        {
            get { return Fields.SlNeedClApproval[this]; }
            set { Fields.SlNeedClApproval[this] = value; }
        }

        [DisplayName("Warn On Mat Consum"), Column("WARN_ON_MAT_CONSUM"), Size(1)]
        public String WarnOnMatConsum
        {
            get { return Fields.WarnOnMatConsum[this]; }
            set { Fields.WarnOnMatConsum[this] = value; }
        }

        [DisplayName("Icim Autogen Lot"), Column("ICIM_AUTOGEN_LOT"), Size(1)]
        public String IcimAutogenLot
        {
            get { return Fields.IcimAutogenLot[this]; }
            set { Fields.IcimAutogenLot[this] = value; }
        }

        [DisplayName("Icim Autogen Serial"), Column("ICIM_AUTOGEN_SERIAL"), Size(1)]
        public String IcimAutogenSerial
        {
            get { return Fields.IcimAutogenSerial[this]; }
            set { Fields.IcimAutogenSerial[this] = value; }
        }

        [DisplayName("Item Anlys 5"), Column("ITEM_ANLYS_5"), Size(30)]
        public String ItemAnlys5
        {
            get { return Fields.ItemAnlys5[this]; }
            set { Fields.ItemAnlys5[this] = value; }
        }

        [DisplayName("Item Anlys 6"), Column("ITEM_ANLYS_6"), Size(30)]
        public String ItemAnlys6
        {
            get { return Fields.ItemAnlys6[this]; }
            set { Fields.ItemAnlys6[this] = value; }
        }

        [DisplayName("Item Anlys 7"), Column("ITEM_ANLYS_7"), Size(30)]
        public String ItemAnlys7
        {
            get { return Fields.ItemAnlys7[this]; }
            set { Fields.ItemAnlys7[this] = value; }
        }

        [DisplayName("Item Anlys 8"), Column("ITEM_ANLYS_8"), Size(30)]
        public String ItemAnlys8
        {
            get { return Fields.ItemAnlys8[this]; }
            set { Fields.ItemAnlys8[this] = value; }
        }

        [DisplayName("Item Anlys 9"), Column("ITEM_ANLYS_9"), Size(30)]
        public String ItemAnlys9
        {
            get { return Fields.ItemAnlys9[this]; }
            set { Fields.ItemAnlys9[this] = value; }
        }

        [DisplayName("Item Anlys 10"), Column("ITEM_ANLYS_10"), Size(30)]
        public String ItemAnlys10
        {
            get { return Fields.ItemAnlys10[this]; }
            set { Fields.ItemAnlys10[this] = value; }
        }

        [DisplayName("Cust Anlys 5"), Column("CUST_ANLYS_5"), Size(30)]
        public String CustAnlys5
        {
            get { return Fields.CustAnlys5[this]; }
            set { Fields.CustAnlys5[this] = value; }
        }

        [DisplayName("Cust Anlys 6"), Column("CUST_ANLYS_6"), Size(30)]
        public String CustAnlys6
        {
            get { return Fields.CustAnlys6[this]; }
            set { Fields.CustAnlys6[this] = value; }
        }

        [DisplayName("Cust Anlys 7"), Column("CUST_ANLYS_7"), Size(30)]
        public String CustAnlys7
        {
            get { return Fields.CustAnlys7[this]; }
            set { Fields.CustAnlys7[this] = value; }
        }

        [DisplayName("Cust Anlys 8"), Column("CUST_ANLYS_8"), Size(30)]
        public String CustAnlys8
        {
            get { return Fields.CustAnlys8[this]; }
            set { Fields.CustAnlys8[this] = value; }
        }

        [DisplayName("Cust Anlys 9"), Column("CUST_ANLYS_9"), Size(30)]
        public String CustAnlys9
        {
            get { return Fields.CustAnlys9[this]; }
            set { Fields.CustAnlys9[this] = value; }
        }

        [DisplayName("Cust Anlys 10"), Column("CUST_ANLYS_10"), Size(30)]
        public String CustAnlys10
        {
            get { return Fields.CustAnlys10[this]; }
            set { Fields.CustAnlys10[this] = value; }
        }

        [DisplayName("Vend Anlys 5"), Column("VEND_ANLYS_5"), Size(30)]
        public String VendAnlys5
        {
            get { return Fields.VendAnlys5[this]; }
            set { Fields.VendAnlys5[this] = value; }
        }

        [DisplayName("Vend Anlys 6"), Column("VEND_ANLYS_6"), Size(30)]
        public String VendAnlys6
        {
            get { return Fields.VendAnlys6[this]; }
            set { Fields.VendAnlys6[this] = value; }
        }

        [DisplayName("Vend Anlys 7"), Column("VEND_ANLYS_7"), Size(30)]
        public String VendAnlys7
        {
            get { return Fields.VendAnlys7[this]; }
            set { Fields.VendAnlys7[this] = value; }
        }

        [DisplayName("Vend Anlys 8"), Column("VEND_ANLYS_8"), Size(30)]
        public String VendAnlys8
        {
            get { return Fields.VendAnlys8[this]; }
            set { Fields.VendAnlys8[this] = value; }
        }

        [DisplayName("Vend Anlys 9"), Column("VEND_ANLYS_9"), Size(30)]
        public String VendAnlys9
        {
            get { return Fields.VendAnlys9[this]; }
            set { Fields.VendAnlys9[this] = value; }
        }

        [DisplayName("Vend Anlys 10"), Column("VEND_ANLYS_10"), Size(30)]
        public String VendAnlys10
        {
            get { return Fields.VendAnlys10[this]; }
            set { Fields.VendAnlys10[this] = value; }
        }

        [DisplayName("Acct Anlys 5"), Column("ACCT_ANLYS_5"), Size(30)]
        public String AcctAnlys5
        {
            get { return Fields.AcctAnlys5[this]; }
            set { Fields.AcctAnlys5[this] = value; }
        }

        [DisplayName("Acct Anlys 6"), Column("ACCT_ANLYS_6"), Size(30)]
        public String AcctAnlys6
        {
            get { return Fields.AcctAnlys6[this]; }
            set { Fields.AcctAnlys6[this] = value; }
        }

        [DisplayName("Acct Anlys 7"), Column("ACCT_ANLYS_7"), Size(30)]
        public String AcctAnlys7
        {
            get { return Fields.AcctAnlys7[this]; }
            set { Fields.AcctAnlys7[this] = value; }
        }

        [DisplayName("Acct Anlys 8"), Column("ACCT_ANLYS_8"), Size(30)]
        public String AcctAnlys8
        {
            get { return Fields.AcctAnlys8[this]; }
            set { Fields.AcctAnlys8[this] = value; }
        }

        [DisplayName("Acct Anlys 9"), Column("ACCT_ANLYS_9"), Size(30)]
        public String AcctAnlys9
        {
            get { return Fields.AcctAnlys9[this]; }
            set { Fields.AcctAnlys9[this] = value; }
        }

        [DisplayName("Acct Anlys 10"), Column("ACCT_ANLYS_10"), Size(30)]
        public String AcctAnlys10
        {
            get { return Fields.AcctAnlys10[this]; }
            set { Fields.AcctAnlys10[this] = value; }
        }

        [DisplayName("Sale Anlys 9"), Column("SALE_ANLYS_9"), Size(30)]
        public String SaleAnlys9
        {
            get { return Fields.SaleAnlys9[this]; }
            set { Fields.SaleAnlys9[this] = value; }
        }

        [DisplayName("Sale Anlys 10"), Column("SALE_ANLYS_10"), Size(30)]
        public String SaleAnlys10
        {
            get { return Fields.SaleAnlys10[this]; }
            set { Fields.SaleAnlys10[this] = value; }
        }

        [DisplayName("Sale Anlys 11"), Column("SALE_ANLYS_11"), Size(30)]
        public String SaleAnlys11
        {
            get { return Fields.SaleAnlys11[this]; }
            set { Fields.SaleAnlys11[this] = value; }
        }

        [DisplayName("Sale Anlys 12"), Column("SALE_ANLYS_12"), Size(30)]
        public String SaleAnlys12
        {
            get { return Fields.SaleAnlys12[this]; }
            set { Fields.SaleAnlys12[this] = value; }
        }

        [DisplayName("Sale Anlys 13"), Column("SALE_ANLYS_13"), Size(30)]
        public String SaleAnlys13
        {
            get { return Fields.SaleAnlys13[this]; }
            set { Fields.SaleAnlys13[this] = value; }
        }

        [DisplayName("Sale Anlys 14"), Column("SALE_ANLYS_14"), Size(30)]
        public String SaleAnlys14
        {
            get { return Fields.SaleAnlys14[this]; }
            set { Fields.SaleAnlys14[this] = value; }
        }

        [DisplayName("Sale Anlys 15"), Column("SALE_ANLYS_15"), Size(30)]
        public String SaleAnlys15
        {
            get { return Fields.SaleAnlys15[this]; }
            set { Fields.SaleAnlys15[this] = value; }
        }

        [DisplayName("Sale Anlys 16"), Column("SALE_ANLYS_16"), Size(30)]
        public String SaleAnlys16
        {
            get { return Fields.SaleAnlys16[this]; }
            set { Fields.SaleAnlys16[this] = value; }
        }

        [DisplayName("Sale Anlys 17"), Column("SALE_ANLYS_17"), Size(30)]
        public String SaleAnlys17
        {
            get { return Fields.SaleAnlys17[this]; }
            set { Fields.SaleAnlys17[this] = value; }
        }

        [DisplayName("Sale Anlys 18"), Column("SALE_ANLYS_18"), Size(30)]
        public String SaleAnlys18
        {
            get { return Fields.SaleAnlys18[this]; }
            set { Fields.SaleAnlys18[this] = value; }
        }

        [DisplayName("Sale Anlys 19"), Column("SALE_ANLYS_19"), Size(30)]
        public String SaleAnlys19
        {
            get { return Fields.SaleAnlys19[this]; }
            set { Fields.SaleAnlys19[this] = value; }
        }

        [DisplayName("Sale Anlys 20"), Column("SALE_ANLYS_20"), Size(30)]
        public String SaleAnlys20
        {
            get { return Fields.SaleAnlys20[this]; }
            set { Fields.SaleAnlys20[this] = value; }
        }

        [DisplayName("Purc Anlys 9"), Column("PURC_ANLYS_9"), Size(30)]
        public String PurcAnlys9
        {
            get { return Fields.PurcAnlys9[this]; }
            set { Fields.PurcAnlys9[this] = value; }
        }

        [DisplayName("Purc Anlys 10"), Column("PURC_ANLYS_10"), Size(30)]
        public String PurcAnlys10
        {
            get { return Fields.PurcAnlys10[this]; }
            set { Fields.PurcAnlys10[this] = value; }
        }

        [DisplayName("Purc Anlys 11"), Column("PURC_ANLYS_11"), Size(30)]
        public String PurcAnlys11
        {
            get { return Fields.PurcAnlys11[this]; }
            set { Fields.PurcAnlys11[this] = value; }
        }

        [DisplayName("Purc Anlys 12"), Column("PURC_ANLYS_12"), Size(30)]
        public String PurcAnlys12
        {
            get { return Fields.PurcAnlys12[this]; }
            set { Fields.PurcAnlys12[this] = value; }
        }

        [DisplayName("Purc Anlys 13"), Column("PURC_ANLYS_13"), Size(30)]
        public String PurcAnlys13
        {
            get { return Fields.PurcAnlys13[this]; }
            set { Fields.PurcAnlys13[this] = value; }
        }

        [DisplayName("Purc Anlys 14"), Column("PURC_ANLYS_14"), Size(30)]
        public String PurcAnlys14
        {
            get { return Fields.PurcAnlys14[this]; }
            set { Fields.PurcAnlys14[this] = value; }
        }

        [DisplayName("Purc Anlys 15"), Column("PURC_ANLYS_15"), Size(30)]
        public String PurcAnlys15
        {
            get { return Fields.PurcAnlys15[this]; }
            set { Fields.PurcAnlys15[this] = value; }
        }

        [DisplayName("Purc Anlys 16"), Column("PURC_ANLYS_16"), Size(30)]
        public String PurcAnlys16
        {
            get { return Fields.PurcAnlys16[this]; }
            set { Fields.PurcAnlys16[this] = value; }
        }

        [DisplayName("Purc Anlys 17"), Column("PURC_ANLYS_17"), Size(30)]
        public String PurcAnlys17
        {
            get { return Fields.PurcAnlys17[this]; }
            set { Fields.PurcAnlys17[this] = value; }
        }

        [DisplayName("Purc Anlys 18"), Column("PURC_ANLYS_18"), Size(30)]
        public String PurcAnlys18
        {
            get { return Fields.PurcAnlys18[this]; }
            set { Fields.PurcAnlys18[this] = value; }
        }

        [DisplayName("Purc Anlys 19"), Column("PURC_ANLYS_19"), Size(30)]
        public String PurcAnlys19
        {
            get { return Fields.PurcAnlys19[this]; }
            set { Fields.PurcAnlys19[this] = value; }
        }

        [DisplayName("Purc Anlys 20"), Column("PURC_ANLYS_20"), Size(30)]
        public String PurcAnlys20
        {
            get { return Fields.PurcAnlys20[this]; }
            set { Fields.PurcAnlys20[this] = value; }
        }

        [DisplayName("Mvmt Anlys 9"), Column("MVMT_ANLYS_9"), Size(30)]
        public String MvmtAnlys9
        {
            get { return Fields.MvmtAnlys9[this]; }
            set { Fields.MvmtAnlys9[this] = value; }
        }

        [DisplayName("Mvmt Anlys 10"), Column("MVMT_ANLYS_10"), Size(30)]
        public String MvmtAnlys10
        {
            get { return Fields.MvmtAnlys10[this]; }
            set { Fields.MvmtAnlys10[this] = value; }
        }

        [DisplayName("Mvmt Anlys 11"), Column("MVMT_ANLYS_11"), Size(30)]
        public String MvmtAnlys11
        {
            get { return Fields.MvmtAnlys11[this]; }
            set { Fields.MvmtAnlys11[this] = value; }
        }

        [DisplayName("Mvmt Anlys 12"), Column("MVMT_ANLYS_12"), Size(30)]
        public String MvmtAnlys12
        {
            get { return Fields.MvmtAnlys12[this]; }
            set { Fields.MvmtAnlys12[this] = value; }
        }

        [DisplayName("Mvmt Anlys 13"), Column("MVMT_ANLYS_13"), Size(30)]
        public String MvmtAnlys13
        {
            get { return Fields.MvmtAnlys13[this]; }
            set { Fields.MvmtAnlys13[this] = value; }
        }

        [DisplayName("Mvmt Anlys 14"), Column("MVMT_ANLYS_14"), Size(30)]
        public String MvmtAnlys14
        {
            get { return Fields.MvmtAnlys14[this]; }
            set { Fields.MvmtAnlys14[this] = value; }
        }

        [DisplayName("Mvmt Anlys 15"), Column("MVMT_ANLYS_15"), Size(30)]
        public String MvmtAnlys15
        {
            get { return Fields.MvmtAnlys15[this]; }
            set { Fields.MvmtAnlys15[this] = value; }
        }

        [DisplayName("Mvmt Anlys 16"), Column("MVMT_ANLYS_16"), Size(30)]
        public String MvmtAnlys16
        {
            get { return Fields.MvmtAnlys16[this]; }
            set { Fields.MvmtAnlys16[this] = value; }
        }

        [DisplayName("Mvmt Anlys 17"), Column("MVMT_ANLYS_17"), Size(30)]
        public String MvmtAnlys17
        {
            get { return Fields.MvmtAnlys17[this]; }
            set { Fields.MvmtAnlys17[this] = value; }
        }

        [DisplayName("Mvmt Anlys 18"), Column("MVMT_ANLYS_18"), Size(30)]
        public String MvmtAnlys18
        {
            get { return Fields.MvmtAnlys18[this]; }
            set { Fields.MvmtAnlys18[this] = value; }
        }

        [DisplayName("Mvmt Anlys 19"), Column("MVMT_ANLYS_19"), Size(30)]
        public String MvmtAnlys19
        {
            get { return Fields.MvmtAnlys19[this]; }
            set { Fields.MvmtAnlys19[this] = value; }
        }

        [DisplayName("Mvmt Anlys 20"), Column("MVMT_ANLYS_20"), Size(30)]
        public String MvmtAnlys20
        {
            get { return Fields.MvmtAnlys20[this]; }
            set { Fields.MvmtAnlys20[this] = value; }
        }

        [DisplayName("Voch Anlys 9"), Column("VOCH_ANLYS_9"), Size(30)]
        public String VochAnlys9
        {
            get { return Fields.VochAnlys9[this]; }
            set { Fields.VochAnlys9[this] = value; }
        }

        [DisplayName("Voch Anlys 10"), Column("VOCH_ANLYS_10"), Size(30)]
        public String VochAnlys10
        {
            get { return Fields.VochAnlys10[this]; }
            set { Fields.VochAnlys10[this] = value; }
        }

        [DisplayName("Voch Anlys 11"), Column("VOCH_ANLYS_11"), Size(30)]
        public String VochAnlys11
        {
            get { return Fields.VochAnlys11[this]; }
            set { Fields.VochAnlys11[this] = value; }
        }

        [DisplayName("Voch Anlys 12"), Column("VOCH_ANLYS_12"), Size(30)]
        public String VochAnlys12
        {
            get { return Fields.VochAnlys12[this]; }
            set { Fields.VochAnlys12[this] = value; }
        }

        [DisplayName("Voch Anlys 13"), Column("VOCH_ANLYS_13"), Size(30)]
        public String VochAnlys13
        {
            get { return Fields.VochAnlys13[this]; }
            set { Fields.VochAnlys13[this] = value; }
        }

        [DisplayName("Voch Anlys 14"), Column("VOCH_ANLYS_14"), Size(30)]
        public String VochAnlys14
        {
            get { return Fields.VochAnlys14[this]; }
            set { Fields.VochAnlys14[this] = value; }
        }

        [DisplayName("Voch Anlys 15"), Column("VOCH_ANLYS_15"), Size(30)]
        public String VochAnlys15
        {
            get { return Fields.VochAnlys15[this]; }
            set { Fields.VochAnlys15[this] = value; }
        }

        [DisplayName("Voch Anlys 16"), Column("VOCH_ANLYS_16"), Size(30)]
        public String VochAnlys16
        {
            get { return Fields.VochAnlys16[this]; }
            set { Fields.VochAnlys16[this] = value; }
        }

        [DisplayName("Voch Anlys 17"), Column("VOCH_ANLYS_17"), Size(30)]
        public String VochAnlys17
        {
            get { return Fields.VochAnlys17[this]; }
            set { Fields.VochAnlys17[this] = value; }
        }

        [DisplayName("Voch Anlys 18"), Column("VOCH_ANLYS_18"), Size(30)]
        public String VochAnlys18
        {
            get { return Fields.VochAnlys18[this]; }
            set { Fields.VochAnlys18[this] = value; }
        }

        [DisplayName("Voch Anlys 19"), Column("VOCH_ANLYS_19"), Size(30)]
        public String VochAnlys19
        {
            get { return Fields.VochAnlys19[this]; }
            set { Fields.VochAnlys19[this] = value; }
        }

        [DisplayName("Voch Anlys 20"), Column("VOCH_ANLYS_20"), Size(30)]
        public String VochAnlys20
        {
            get { return Fields.VochAnlys20[this]; }
            set { Fields.VochAnlys20[this] = value; }
        }

        [DisplayName("Jord Anlys 9"), Column("JORD_ANLYS_9"), Size(30)]
        public String JordAnlys9
        {
            get { return Fields.JordAnlys9[this]; }
            set { Fields.JordAnlys9[this] = value; }
        }

        [DisplayName("Jord Anlys 10"), Column("JORD_ANLYS_10"), Size(30)]
        public String JordAnlys10
        {
            get { return Fields.JordAnlys10[this]; }
            set { Fields.JordAnlys10[this] = value; }
        }

        [DisplayName("Jord Anlys 11"), Column("JORD_ANLYS_11"), Size(30)]
        public String JordAnlys11
        {
            get { return Fields.JordAnlys11[this]; }
            set { Fields.JordAnlys11[this] = value; }
        }

        [DisplayName("Jord Anlys 12"), Column("JORD_ANLYS_12"), Size(30)]
        public String JordAnlys12
        {
            get { return Fields.JordAnlys12[this]; }
            set { Fields.JordAnlys12[this] = value; }
        }

        [DisplayName("Jord Anlys 13"), Column("JORD_ANLYS_13"), Size(30)]
        public String JordAnlys13
        {
            get { return Fields.JordAnlys13[this]; }
            set { Fields.JordAnlys13[this] = value; }
        }

        [DisplayName("Jord Anlys 14"), Column("JORD_ANLYS_14"), Size(30)]
        public String JordAnlys14
        {
            get { return Fields.JordAnlys14[this]; }
            set { Fields.JordAnlys14[this] = value; }
        }

        [DisplayName("Jord Anlys 15"), Column("JORD_ANLYS_15"), Size(30)]
        public String JordAnlys15
        {
            get { return Fields.JordAnlys15[this]; }
            set { Fields.JordAnlys15[this] = value; }
        }

        [DisplayName("Jord Anlys 16"), Column("JORD_ANLYS_16"), Size(30)]
        public String JordAnlys16
        {
            get { return Fields.JordAnlys16[this]; }
            set { Fields.JordAnlys16[this] = value; }
        }

        [DisplayName("Jord Anlys 17"), Column("JORD_ANLYS_17"), Size(30)]
        public String JordAnlys17
        {
            get { return Fields.JordAnlys17[this]; }
            set { Fields.JordAnlys17[this] = value; }
        }

        [DisplayName("Jord Anlys 18"), Column("JORD_ANLYS_18"), Size(30)]
        public String JordAnlys18
        {
            get { return Fields.JordAnlys18[this]; }
            set { Fields.JordAnlys18[this] = value; }
        }

        [DisplayName("Jord Anlys 19"), Column("JORD_ANLYS_19"), Size(30)]
        public String JordAnlys19
        {
            get { return Fields.JordAnlys19[this]; }
            set { Fields.JordAnlys19[this] = value; }
        }

        [DisplayName("Jord Anlys 20"), Column("JORD_ANLYS_20"), Size(30)]
        public String JordAnlys20
        {
            get { return Fields.JordAnlys20[this]; }
            set { Fields.JordAnlys20[this] = value; }
        }

        [DisplayName("Ar Anlys 9"), Column("AR_ANLYS_9"), Size(30)]
        public String ArAnlys9
        {
            get { return Fields.ArAnlys9[this]; }
            set { Fields.ArAnlys9[this] = value; }
        }

        [DisplayName("Ar Anlys 10"), Column("AR_ANLYS_10"), Size(30)]
        public String ArAnlys10
        {
            get { return Fields.ArAnlys10[this]; }
            set { Fields.ArAnlys10[this] = value; }
        }

        [DisplayName("Ar Anlys 11"), Column("AR_ANLYS_11"), Size(30)]
        public String ArAnlys11
        {
            get { return Fields.ArAnlys11[this]; }
            set { Fields.ArAnlys11[this] = value; }
        }

        [DisplayName("Ar Anlys 12"), Column("AR_ANLYS_12"), Size(30)]
        public String ArAnlys12
        {
            get { return Fields.ArAnlys12[this]; }
            set { Fields.ArAnlys12[this] = value; }
        }

        [DisplayName("Ar Anlys 13"), Column("AR_ANLYS_13"), Size(30)]
        public String ArAnlys13
        {
            get { return Fields.ArAnlys13[this]; }
            set { Fields.ArAnlys13[this] = value; }
        }

        [DisplayName("Ar Anlys 14"), Column("AR_ANLYS_14"), Size(30)]
        public String ArAnlys14
        {
            get { return Fields.ArAnlys14[this]; }
            set { Fields.ArAnlys14[this] = value; }
        }

        [DisplayName("Ar Anlys 15"), Column("AR_ANLYS_15"), Size(30)]
        public String ArAnlys15
        {
            get { return Fields.ArAnlys15[this]; }
            set { Fields.ArAnlys15[this] = value; }
        }

        [DisplayName("Ar Anlys 16"), Column("AR_ANLYS_16"), Size(30)]
        public String ArAnlys16
        {
            get { return Fields.ArAnlys16[this]; }
            set { Fields.ArAnlys16[this] = value; }
        }

        [DisplayName("Ar Anlys 17"), Column("AR_ANLYS_17"), Size(30)]
        public String ArAnlys17
        {
            get { return Fields.ArAnlys17[this]; }
            set { Fields.ArAnlys17[this] = value; }
        }

        [DisplayName("Ar Anlys 18"), Column("AR_ANLYS_18"), Size(30)]
        public String ArAnlys18
        {
            get { return Fields.ArAnlys18[this]; }
            set { Fields.ArAnlys18[this] = value; }
        }

        [DisplayName("Ar Anlys 19"), Column("AR_ANLYS_19"), Size(30)]
        public String ArAnlys19
        {
            get { return Fields.ArAnlys19[this]; }
            set { Fields.ArAnlys19[this] = value; }
        }

        [DisplayName("Ar Anlys 20"), Column("AR_ANLYS_20"), Size(30)]
        public String ArAnlys20
        {
            get { return Fields.ArAnlys20[this]; }
            set { Fields.ArAnlys20[this] = value; }
        }

        [DisplayName("Ap Anlys 9"), Column("AP_ANLYS_9"), Size(30)]
        public String ApAnlys9
        {
            get { return Fields.ApAnlys9[this]; }
            set { Fields.ApAnlys9[this] = value; }
        }

        [DisplayName("Ap Anlys 10"), Column("AP_ANLYS_10"), Size(30)]
        public String ApAnlys10
        {
            get { return Fields.ApAnlys10[this]; }
            set { Fields.ApAnlys10[this] = value; }
        }

        [DisplayName("Ap Anlys 11"), Column("AP_ANLYS_11"), Size(30)]
        public String ApAnlys11
        {
            get { return Fields.ApAnlys11[this]; }
            set { Fields.ApAnlys11[this] = value; }
        }

        [DisplayName("Ap Anlys 12"), Column("AP_ANLYS_12"), Size(30)]
        public String ApAnlys12
        {
            get { return Fields.ApAnlys12[this]; }
            set { Fields.ApAnlys12[this] = value; }
        }

        [DisplayName("Ap Anlys 13"), Column("AP_ANLYS_13"), Size(30)]
        public String ApAnlys13
        {
            get { return Fields.ApAnlys13[this]; }
            set { Fields.ApAnlys13[this] = value; }
        }

        [DisplayName("Ap Anlys 14"), Column("AP_ANLYS_14"), Size(30)]
        public String ApAnlys14
        {
            get { return Fields.ApAnlys14[this]; }
            set { Fields.ApAnlys14[this] = value; }
        }

        [DisplayName("Ap Anlys 15"), Column("AP_ANLYS_15"), Size(30)]
        public String ApAnlys15
        {
            get { return Fields.ApAnlys15[this]; }
            set { Fields.ApAnlys15[this] = value; }
        }

        [DisplayName("Ap Anlys 16"), Column("AP_ANLYS_16"), Size(30)]
        public String ApAnlys16
        {
            get { return Fields.ApAnlys16[this]; }
            set { Fields.ApAnlys16[this] = value; }
        }

        [DisplayName("Ap Anlys 17"), Column("AP_ANLYS_17"), Size(30)]
        public String ApAnlys17
        {
            get { return Fields.ApAnlys17[this]; }
            set { Fields.ApAnlys17[this] = value; }
        }

        [DisplayName("Ap Anlys 18"), Column("AP_ANLYS_18"), Size(30)]
        public String ApAnlys18
        {
            get { return Fields.ApAnlys18[this]; }
            set { Fields.ApAnlys18[this] = value; }
        }

        [DisplayName("Ap Anlys 19"), Column("AP_ANLYS_19"), Size(30)]
        public String ApAnlys19
        {
            get { return Fields.ApAnlys19[this]; }
            set { Fields.ApAnlys19[this] = value; }
        }

        [DisplayName("Ap Anlys 20"), Column("AP_ANLYS_20"), Size(30)]
        public String ApAnlys20
        {
            get { return Fields.ApAnlys20[this]; }
            set { Fields.ApAnlys20[this] = value; }
        }

        [DisplayName("Prpe Mold Audit Trail"), Column("PRPE_MOLD_AUDIT_TRAIL")]
        public Boolean? PrpeMoldAuditTrail
        {
            get { return Fields.PrpeMoldAuditTrail[this]; }
            set { Fields.PrpeMoldAuditTrail[this] = value; }
        }

        [DisplayName("Icim Issue By Available Qty"), Column("ICIM_ISSUE_BY_AVAILABLE_QTY")]
        public Boolean? IcimIssueByAvailableQty
        {
            get { return Fields.IcimIssueByAvailableQty[this]; }
            set { Fields.IcimIssueByAvailableQty[this] = value; }
        }

        [DisplayName("Prpm Jamend Issue Control"), Column("PRPM_JAMEND_ISSUE_CONTROL")]
        public Boolean? PrpmJamendIssueControl
        {
            get { return Fields.PrpmJamendIssueControl[this]; }
            set { Fields.PrpmJamendIssueControl[this] = value; }
        }

        [DisplayName("Pr Auto Multi Spare Issue"), Column("PR_AUTO_MULTI_SPARE_ISSUE")]
        public Boolean? PrAutoMultiSpareIssue
        {
            get { return Fields.PrAutoMultiSpareIssue[this]; }
            set { Fields.PrAutoMultiSpareIssue[this] = value; }
        }

        [DisplayName("Sl Shipment Price Control"), Column("SL_SHIPMENT_PRICE_CONTROL")]
        public Boolean? SlShipmentPriceControl
        {
            get { return Fields.SlShipmentPriceControl[this]; }
            set { Fields.SlShipmentPriceControl[this] = value; }
        }

        [DisplayName("Ar Multi Settle"), Column("AR_MULTI_SETTLE")]
        public Boolean? ArMultiSettle
        {
            get { return Fields.ArMultiSettle[this]; }
            set { Fields.ArMultiSettle[this] = value; }
        }

        [DisplayName("Pupo Def Multiship"), Column("PUPO_DEF_MULTISHIP")]
        public Boolean? PupoDefMultiship
        {
            get { return Fields.PupoDefMultiship[this]; }
            set { Fields.PupoDefMultiship[this] = value; }
        }

        [DisplayName("Pupo Def Reorder"), Column("PUPO_DEF_REORDER")]
        public Boolean? PupoDefReorder
        {
            get { return Fields.PupoDefReorder[this]; }
            set { Fields.PupoDefReorder[this] = value; }
        }

        [DisplayName("Slso Def Reorder"), Column("SLSO_DEF_REORDER")]
        public Boolean? SlsoDefReorder
        {
            get { return Fields.SlsoDefReorder[this]; }
            set { Fields.SlsoDefReorder[this] = value; }
        }

        [DisplayName("Voch By Vdate"), Column("VOCH_BY_VDATE")]
        public Boolean? VochByVdate
        {
            get { return Fields.VochByVdate[this]; }
            set { Fields.VochByVdate[this] = value; }
        }

        [DisplayName("Pupo Tax Terms"), Column("PUPO_TAX_TERMS")]
        public Boolean? PupoTaxTerms
        {
            get { return Fields.PupoTaxTerms[this]; }
            set { Fields.PupoTaxTerms[this] = value; }
        }

        [DisplayName("Sample Acct"), Column("SAMPLE_ACCT"), Size(30), NotNull]
        public String SampleAcct
        {
            get { return Fields.SampleAcct[this]; }
            set { Fields.SampleAcct[this] = value; }
        }

        [DisplayName("Ctl Fg Rtn Tot Qty"), Column("CTL_FG_RTN_TOT_QTY")]
        public Boolean? CtlFgRtnTotQty
        {
            get { return Fields.CtlFgRtnTotQty[this]; }
            set { Fields.CtlFgRtnTotQty[this] = value; }
        }

        [DisplayName("Allow Multi Wc"), Column("ALLOW_MULTI_WC")]
        public Boolean? AllowMultiWc
        {
            get { return Fields.AllowMultiWc[this]; }
            set { Fields.AllowMultiWc[this] = value; }
        }

        [DisplayName("Poa Ignore Min Qty"), Column("POA_IGNORE_MIN_QTY")]
        public Boolean? PoaIgnoreMinQty
        {
            get { return Fields.PoaIgnoreMinQty[this]; }
            set { Fields.PoaIgnoreMinQty[this] = value; }
        }

        [DisplayName("Grn Mat Cost"), Column("GRN_MAT_COST")]
        public Boolean? GrnMatCost
        {
            get { return Fields.GrnMatCost[this]; }
            set { Fields.GrnMatCost[this] = value; }
        }

        [DisplayName("Grn Lot No Import"), Column("GRN_LOT_NO_IMPORT")]
        public Boolean? GrnLotNoImport
        {
            get { return Fields.GrnLotNoImport[this]; }
            set { Fields.GrnLotNoImport[this] = value; }
        }

        [DisplayName("Issue Materials By Routing"), Column("ISSUE_MATERIALS_BY_ROUTING")]
        public Boolean? IssueMaterialsByRouting
        {
            get { return Fields.IssueMaterialsByRouting[this]; }
            set { Fields.IssueMaterialsByRouting[this] = value; }
        }

        [DisplayName("Consume Mat In Last Routing"), Column("CONSUME_MAT_IN_LAST_ROUTING")]
        public Boolean? ConsumeMatInLastRouting
        {
            get { return Fields.ConsumeMatInLastRouting[this]; }
            set { Fields.ConsumeMatInLastRouting[this] = value; }
        }

        [DisplayName("Def Aql Lvl Critical"), Column("DEF_AQL_LVL_CRITICAL"), Size(10)]
        public String DefAqlLvlCritical
        {
            get { return Fields.DefAqlLvlCritical[this]; }
            set { Fields.DefAqlLvlCritical[this] = value; }
        }

        [DisplayName("Def Insp Lvl Sp"), Column("DEF_INSP_LVL_SP"), Size(1)]
        public String DefInspLvlSp
        {
            get { return Fields.DefInspLvlSp[this]; }
            set { Fields.DefInspLvlSp[this] = value; }
        }

        [DisplayName("Def Aql Lvl Critical Sp"), Column("DEF_AQL_LVL_CRITICAL_SP"), Size(10)]
        public String DefAqlLvlCriticalSp
        {
            get { return Fields.DefAqlLvlCriticalSp[this]; }
            set { Fields.DefAqlLvlCriticalSp[this] = value; }
        }

        [DisplayName("Def Aql Lvl Maj Sp"), Column("DEF_AQL_LVL_MAJ_SP"), Size(10)]
        public String DefAqlLvlMajSp
        {
            get { return Fields.DefAqlLvlMajSp[this]; }
            set { Fields.DefAqlLvlMajSp[this] = value; }
        }

        [DisplayName("Def Aql Lvl Min Sp"), Column("DEF_AQL_LVL_MIN_SP"), Size(10)]
        public String DefAqlLvlMinSp
        {
            get { return Fields.DefAqlLvlMinSp[this]; }
            set { Fields.DefAqlLvlMinSp[this] = value; }
        }

        [DisplayName("Wc Auto Mat Return"), Column("WC_AUTO_MAT_RETURN")]
        public Boolean? WcAutoMatReturn
        {
            get { return Fields.WcAutoMatReturn[this]; }
            set { Fields.WcAutoMatReturn[this] = value; }
        }

        [DisplayName("Ar Inv Multi Pay Terms"), Column("AR_INV_MULTI_PAY_TERMS")]
        public Boolean? ArInvMultiPayTerms
        {
            get { return Fields.ArInvMultiPayTerms[this]; }
            set { Fields.ArInvMultiPayTerms[this] = value; }
        }

        [DisplayName("Ic Adj Code A Pcent"), Column("IC_ADJ_CODE_A_PCENT"), Size(6), Scale(2)]
        public Decimal? IcAdjCodeAPcent
        {
            get { return Fields.IcAdjCodeAPcent[this]; }
            set { Fields.IcAdjCodeAPcent[this] = value; }
        }

        [DisplayName("Ic Adj Code B Pcent"), Column("IC_ADJ_CODE_B_PCENT"), Size(6), Scale(2)]
        public Decimal? IcAdjCodeBPcent
        {
            get { return Fields.IcAdjCodeBPcent[this]; }
            set { Fields.IcAdjCodeBPcent[this] = value; }
        }

        [DisplayName("Ic Adj Code C Pcent"), Column("IC_ADJ_CODE_C_PCENT"), Size(6), Scale(2)]
        public Decimal? IcAdjCodeCPcent
        {
            get { return Fields.IcAdjCodeCPcent[this]; }
            set { Fields.IcAdjCodeCPcent[this] = value; }
        }

        [DisplayName("Tailor Include Job"), Column("TAILOR_INCLUDE_JOB")]
        public Boolean? TailorIncludeJob
        {
            get { return Fields.TailorIncludeJob[this]; }
            set { Fields.TailorIncludeJob[this] = value; }
        }

        [DisplayName("Jo Multi Source"), Column("JO_MULTI_SOURCE")]
        public Boolean? JoMultiSource
        {
            get { return Fields.JoMultiSource[this]; }
            set { Fields.JoMultiSource[this] = value; }
        }

        [DisplayName("Show Shipment Info In Packing"), Column("SHOW_SHIPMENT_INFO_IN_PACKING")]
        public Boolean? ShowShipmentInfoInPacking
        {
            get { return Fields.ShowShipmentInfoInPacking[this]; }
            set { Fields.ShowShipmentInfoInPacking[this] = value; }
        }

        [DisplayName("Mrp With Reorder Pt"), Column("MRP_WITH_REORDER_PT")]
        public Boolean? MrpWithReorderPt
        {
            get { return Fields.MrpWithReorderPt[this]; }
            set { Fields.MrpWithReorderPt[this] = value; }
        }

        [DisplayName("Allow Follow List Without Mi"), Column("ALLOW_FOLLOW_LIST_WITHOUT_MI")]
        public Boolean? AllowFollowListWithoutMi
        {
            get { return Fields.AllowFollowListWithoutMi[this]; }
            set { Fields.AllowFollowListWithoutMi[this] = value; }
        }

        [DisplayName("Pr Multi Follow List"), Column("PR_MULTI_FOLLOW_LIST")]
        public Boolean? PrMultiFollowList
        {
            get { return Fields.PrMultiFollowList[this]; }
            set { Fields.PrMultiFollowList[this] = value; }
        }

        [DisplayName("Sqietk Mat Bal Subtract Commit"), Column("SQIETK_MAT_BAL_SUBTRACT_COMMIT")]
        public Boolean? SqietkMatBalSubtractCommit
        {
            get { return Fields.SqietkMatBalSubtractCommit[this]; }
            set { Fields.SqietkMatBalSubtractCommit[this] = value; }
        }

        [DisplayName("So Line Auto Inc By"), Column("SO_LINE_AUTO_INC_BY"), Size(6)]
        public Decimal? SoLineAutoIncBy
        {
            get { return Fields.SoLineAutoIncBy[this]; }
            set { Fields.SoLineAutoIncBy[this] = value; }
        }

        [DisplayName("Po Line Auto Inc By"), Column("PO_LINE_AUTO_INC_BY"), Size(6)]
        public Decimal? PoLineAutoIncBy
        {
            get { return Fields.PoLineAutoIncBy[this]; }
            set { Fields.PoLineAutoIncBy[this] = value; }
        }

        [DisplayName("Pu Over Rcpt By Line"), Column("PU_OVER_RCPT_BY_LINE")]
        public Boolean? PuOverRcptByLine
        {
            get { return Fields.PuOverRcptByLine[this]; }
            set { Fields.PuOverRcptByLine[this] = value; }
        }

        [DisplayName("Pu Lme Cost"), Column("PU_LME_COST")]
        public Boolean? PuLmeCost
        {
            get { return Fields.PuLmeCost[this]; }
            set { Fields.PuLmeCost[this] = value; }
        }

        [DisplayName("Soa Update Pending Shipment"), Column("SOA_UPDATE_PENDING_SHIPMENT")]
        public Boolean? SoaUpdatePendingShipment
        {
            get { return Fields.SoaUpdatePendingShipment[this]; }
            set { Fields.SoaUpdatePendingShipment[this] = value; }
        }

        [DisplayName("Pr Mat Issue On Avail Percent"), Column("PR_MAT_ISSUE_ON_AVAIL_PERCENT"), Size(6), Scale(2)]
        public Decimal? PrMatIssueOnAvailPercent
        {
            get { return Fields.PrMatIssueOnAvailPercent[this]; }
            set { Fields.PrMatIssueOnAvailPercent[this] = value; }
        }

        [DisplayName("Job Hourly Rate"), Column("JOB_HOURLY_RATE"), Size(6), Scale(2)]
        public Decimal? JobHourlyRate
        {
            get { return Fields.JobHourlyRate[this]; }
            set { Fields.JobHourlyRate[this] = value; }
        }

        [DisplayName("Item Custom Prod Code Required"), Column("ITEM_CUSTOM_PROD_CODE_REQUIRED")]
        public Boolean? ItemCustomProdCodeRequired
        {
            get { return Fields.ItemCustomProdCodeRequired[this]; }
            set { Fields.ItemCustomProdCodeRequired[this] = value; }
        }

        [DisplayName("Icim Autogen Lot Issue"), Column("ICIM_AUTOGEN_LOT_ISSUE")]
        public Boolean? IcimAutogenLotIssue
        {
            get { return Fields.IcimAutogenLotIssue[this]; }
            set { Fields.IcimAutogenLotIssue[this] = value; }
        }

        [DisplayName("Icim Autogen Serial Issue"), Column("ICIM_AUTOGEN_SERIAL_ISSUE")]
        public Boolean? IcimAutogenSerialIssue
        {
            get { return Fields.IcimAutogenSerialIssue[this]; }
            set { Fields.IcimAutogenSerialIssue[this] = value; }
        }

        [DisplayName("Shipment Info From First Order"), Column("SHIPMENT_INFO_FROM_FIRST_ORDER")]
        public Boolean? ShipmentInfoFromFirstOrder
        {
            get { return Fields.ShipmentInfoFromFirstOrder[this]; }
            set { Fields.ShipmentInfoFromFirstOrder[this] = value; }
        }

        [DisplayName("Mrp Exclude Leadtime"), Column("MRP_EXCLUDE_LEADTIME")]
        public Boolean? MrpExcludeLeadtime
        {
            get { return Fields.MrpExcludeLeadtime[this]; }
            set { Fields.MrpExcludeLeadtime[this] = value; }
        }

        [DisplayName("Item Prelot Sopo"), Column("ITEM_PRELOT_SOPO")]
        public Boolean? ItemPrelotSopo
        {
            get { return Fields.ItemPrelotSopo[this]; }
            set { Fields.ItemPrelotSopo[this] = value; }
        }

        [DisplayName("Slso Ctrl Btm Ceil"), Column("SLSO_CTRL_BTM_CEIL")]
        public Boolean? SlsoCtrlBtmCeil
        {
            get { return Fields.SlsoCtrlBtmCeil[this]; }
            set { Fields.SlsoCtrlBtmCeil[this] = value; }
        }

        [DisplayName("Wc Over Accepted Lot"), Column("WC_OVER_ACCEPTED_LOT")]
        public Boolean? WcOverAcceptedLot
        {
            get { return Fields.WcOverAcceptedLot[this]; }
            set { Fields.WcOverAcceptedLot[this] = value; }
        }

        [DisplayName("Slso Auto Resv"), Column("SLSO_AUTO_RESV")]
        public Boolean? SlsoAutoResv
        {
            get { return Fields.SlsoAutoResv[this]; }
            set { Fields.SlsoAutoResv[this] = value; }
        }

        [DisplayName("Percent A"), Column("PERCENT_A"), Size(4), Scale(2)]
        public Decimal? PercentA
        {
            get { return Fields.PercentA[this]; }
            set { Fields.PercentA[this] = value; }
        }

        [DisplayName("Percent B"), Column("PERCENT_B"), Size(4), Scale(2)]
        public Decimal? PercentB
        {
            get { return Fields.PercentB[this]; }
            set { Fields.PercentB[this] = value; }
        }

        [DisplayName("Percent C"), Column("PERCENT_C"), Size(4), Scale(2)]
        public Decimal? PercentC
        {
            get { return Fields.PercentC[this]; }
            set { Fields.PercentC[this] = value; }
        }

        [DisplayName("Entry Posted Requird Before Print"), Column("ENTRY_POSTED_REQUIRD_BEFORE_PRINT"), Size(1)]
        public String EntryPostedRequirdBeforePrint
        {
            get { return Fields.EntryPostedRequirdBeforePrint[this]; }
            set { Fields.EntryPostedRequirdBeforePrint[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Recnum; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.SlInit; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public CompanySettingRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField SlInit;
            public StringField SlsoMultiship;
            public StringField SlsoResv;
            public StringField SlsoAssortment;
            public StringField SlsoDeposits;
            public StringField SlsoMeasures;
            public StringField SlsoPtax;
            public StringField SlsoAtax;
            public StringField SlsoGtax;
            public StringField SlsoLineDisc;
            public StringField SlsoAutoPo;
            public StringField SlsoAutoJob;
            public StringField SlsoExtInst;
            public StringField SlsoExtDesc;
            public StringField SlsoFixedUom;
            public StringField SlsoReqSman;
            public StringField SlsoSman;
            public StringField SlsoText1;
            public StringField SlsoText2;
            public StringField SlsoText3;
            public StringField SlsoText4;
            public DecimalField SlsoDueLead;
            public DecimalField SlsoSchLead;
            public StringField SlsoAddrCode;
            public StringField SlsoAddrType;
            public DecimalField SlsoQuoteDays;
            public DecimalField SlshCutDays;
            public StringField SlsoShipVia;
            public StringField SlsoShipTerms;
            public DateTimeField SlRevisedDate;
            public StringField SlRevisedBy;
            public StringField PuInit;
            public StringField PupoMultiship;
            public StringField PupoDeposits;
            public StringField PupoMeasures;
            public StringField PupoPtax;
            public StringField PupoAtax;
            public StringField PupoGtax;
            public StringField PupoLineDisc;
            public StringField PupoExtInst;
            public StringField PupoExtDesc;
            public StringField PupoFixedUom;
            public StringField PupoText1;
            public StringField PupoText2;
            public StringField PupoText3;
            public StringField PupoText4;
            public DecimalField PupoCutDays;
            public StringField PupoReorder;
            public StringField PupoReqBuyer;
            public StringField PupoBuyer;
            public StringField PupoShipVia;
            public StringField PupoShipTerms;
            public DateTimeField PuRevisedDate;
            public StringField PuRevisedBy;
            public StringField ProdInit;
            public StringField ProdEcnReq;
            public StringField ProdByprod;
            public DecimalField ProdScrapRate;
            public StringField ProdPictDesc1;
            public StringField ProdPictDesc2;
            public StringField ProdPictDesc3;
            public StringField ProdPictDesc4;
            public StringField ProdWeightUom;
            public StringField ProdDimenUom;
            public StringField ProdFixedWtum;
            public StringField ProdFixedDmum;
            public DecimalField ProdStdLsize;
            public DecimalField ProdMinLsize;
            public DecimalField ProdMaxLsize;
            public DecimalField ProdStdOutput;
            public DateTimeField PrRevisedDate;
            public StringField PrRevisedBy;
            public StringField ShopReqJcat;
            public DecimalField ShopWksCover;
            public StringField ShopPlanner;
            public StringField ShopDefPlnr;
            public DecimalField ShopMpsHorz;
            public DecimalField ShopPurLtime;
            public StringField ShopPurLunit;
            public StringField ShopJobCat;
            public DecimalField ShopMrpHorz;
            public DateTimeField ShRevisedDate;
            public StringField ShRevisedBy;
            public DecimalField MrpCount;
            public StringField MrpRefNo;
            public DateTimeField MrpRunDate;
            public DateTimeField MrpHorzDate;
            public StringField IcInit;
            public StringField IcReceipts;
            public StringField IcIssuance;
            public StringField IcTransfer;
            public StringField IcAdjustment;
            public DateTimeField IcRevisedDate;
            public StringField IcRevisedBy;
            public StringField PrJobSched;
            public StringField PrByProd;
            public StringField PrJobBatches;
            public DecimalField LastResvNo;
            public StringField NoMrpFence;
            public StringField MvtRmIssue;
            public StringField MvtSpIssue;
            public StringField MvtFgReturn;
            public StringField MvtRmReturn;
            public StringField MvtSlShipment;
            public StringField MvtSlReturn;
            public StringField MvtPuReceipt;
            public StringField MvtPuInspect;
            public StringField MvtPuReturn;
            public StringField GlInit;
            public StringField GlHdrTxt;
            public StringField GlDtlTxt;
            public StringField GlRefEntry;
            public StringField GlRefLabel;
            public StringField GlLrefEntry;
            public StringField GlLrefLabel;
            public StringField GlExchComp;
            public StringField GlRevisedBy;
            public DateTimeField GlRevisedDate;
            public StringField VochArInvo;
            public StringField VochArMemo;
            public StringField VochArAdj;
            public StringField VochArPay;
            public StringField VochArAlloc;
            public StringField VochArInvocan;
            public StringField VochArPaycan;
            public StringField VochApInvo;
            public StringField VochApMemo;
            public StringField VochApAdj;
            public StringField VochApPay;
            public StringField VochApAlloc;
            public StringField VochApInvocan;
            public StringField VochApPaycan;
            public StringField VochIcIssue;
            public StringField VochIcRcpt;
            public StringField VochIcAdj;
            public StringField VochPrIssue;
            public StringField VochPrReturn;
            public StringField VochPrProd;
            public StringField VochPrSubcon;
            public StringField VochPayroll;
            public StringField VochCommission;
            public StringField VochFaAcquire;
            public StringField VochFaDeprec;
            public StringField VochFaMaint;
            public StringField VochFaDispo;
            public DecimalField ArBcountInvo;
            public DecimalField ArBcountMemo;
            public DecimalField ArBcountAdj;
            public DecimalField ArBcountPay;
            public DecimalField ArBcountAlloc;
            public DecimalField ApBcountInvo;
            public DecimalField ApBcountMemo;
            public DecimalField ApBcountAdj;
            public DecimalField ApBcountPay;
            public DecimalField ApBcountAlloc;
            public StringField CostInit;
            public StringField CostBasis;
            public DecimalField CostRmPrMul;
            public DecimalField CostLbPrMul;
            public DecimalField CostOvPrMul;
            public DecimalField CostRmSlMul;
            public DecimalField CostLbSlMul;
            public DecimalField CostOvSlMul;
            public StringField CostRevisedBy;
            public DateTimeField CostRevDate;
            public StringField PrCostVerify;
            public StringField PrCostEdit;
            public StringField CommisType;
            public StringField SlsoCustItem;
            public StringField SlsoPkgType;
            public StringField IcAutoShip;
            public StringField IcAutoSlret;
            public StringField IcAutoGrn;
            public StringField IcAutoQc;
            public StringField IcAutoPuret;
            public StringField IcAutoWorkc;
            public StringField ApOvrideRate;
            public StringField SlsoSchEntry;
            public StringField PupoSchEntry;
            public StringField SlsoContact;
            public StringField SlsoOrdrPack;
            public DecimalField MaxUsers;
            public StringField MmuKey;
            public StringField AcctAnlys1;
            public StringField AcctAnlys2;
            public StringField AcctAnlys3;
            public StringField AcctAnlys4;
            public StringField VochAnlys1;
            public StringField VochAnlys2;
            public StringField VochAnlys3;
            public StringField VochAnlys4;
            public StringField VochAnlys5;
            public StringField VochAnlys6;
            public StringField ItemAnlys1;
            public StringField ItemAnlys2;
            public StringField ItemAnlys3;
            public StringField ItemAnlys4;
            public StringField CustAnlys1;
            public StringField CustAnlys2;
            public StringField CustAnlys3;
            public StringField CustAnlys4;
            public StringField VendAnlys1;
            public StringField VendAnlys2;
            public StringField VendAnlys3;
            public StringField VendAnlys4;
            public StringField SaleAnlys1;
            public StringField SaleAnlys2;
            public StringField SaleAnlys3;
            public StringField SaleAnlys4;
            public StringField SaleAnlys5;
            public StringField SaleAnlys6;
            public StringField PurcAnlys1;
            public StringField PurcAnlys2;
            public StringField PurcAnlys3;
            public StringField PurcAnlys4;
            public StringField PurcAnlys5;
            public StringField PurcAnlys6;
            public StringField MvmtAnlys1;
            public StringField MvmtAnlys2;
            public StringField MvmtAnlys3;
            public StringField MvmtAnlys4;
            public StringField MvmtAnlys5;
            public StringField MvmtAnlys6;
            public DateTimeField NrevisedDate;
            public StringField NrevisedBy;
            public StringField ShipWtUom;
            public StringField ShipDimUom;
            public StringField ItemPacking;
            public StringField NoOvhdAcctg;
            public StringField NoVariaAcctg;
            public StringField NoFgAcctg;
            public StringField FgCostLimit;
            public StringField AllowDescChg;
            public StringField NoLaborAcctg;
            public StringField NoSubconAcctg;
            public StringField ReorderIsNew;
            public StringField DefInspStd;
            public StringField DefInspLvl;
            public StringField DefAqlLvlMaj;
            public StringField DefAqlLvlMin;
            public StringField ReturnEmail;
            public StringField SmtpServer;
            public StringField WebSetting1;
            public StringField WebSetting2;
            public StringField WebSetting3;
            public StringField WebSetting4;
            public StringField PupoPriceCtrl;
            public StringField JordAnlys1;
            public StringField JordAnlys2;
            public StringField JordAnlys3;
            public StringField JordAnlys4;
            public StringField JordAnlys5;
            public StringField JordAnlys6;
            public StringField ProdPosEntry;
            public StringField GlarText1;
            public StringField GlarText2;
            public StringField GlarText3;
            public StringField GlarText4;
            public StringField PrJobClose;
            public StringField SlsoUnfullPackResponse;
            public StringField SlsoDefMultiShip;
            public StringField SlsoDefAutoPo;
            public StringField SlsoDefAutoJo;
            public StringField SlpaExtDesc;
            public DecimalField PupoDueLead;
            public DecimalField PupoSchLead;
            public StringField PrMultiIssue;
            public StringField ProdSepRoute;
            public StringField ProdHideWcSubcon;
            public StringField CopyTextFromSo;
            public StringField PrpmText1;
            public StringField PrpmText2;
            public StringField PrpmText3;
            public StringField PrpmText4;
            public StringField PrpmExtInst;
            public Int32Field BomVerLen;
            public StringField ProdPoPrice;
            public StringField SaleAnlys7;
            public StringField SaleAnlys8;
            public StringField PurcAnlys7;
            public StringField PurcAnlys8;
            public StringField MvmtAnlys7;
            public StringField MvmtAnlys8;
            public StringField VochAnlys7;
            public StringField VochAnlys8;
            public StringField JordAnlys7;
            public StringField JordAnlys8;
            public StringField ArAnlys1;
            public StringField ArAnlys2;
            public StringField ArAnlys3;
            public StringField ArAnlys4;
            public StringField ArAnlys5;
            public StringField ArAnlys6;
            public StringField ArAnlys7;
            public StringField ArAnlys8;
            public StringField ApAnlys1;
            public StringField ApAnlys2;
            public StringField ApAnlys3;
            public StringField ApAnlys4;
            public StringField ApAnlys5;
            public StringField ApAnlys6;
            public StringField ApAnlys7;
            public StringField ApAnlys8;
            public StringField SlAddInfo;
            public StringField PuAddInfo;
            public StringField PrAddInfo;
            public StringField IcAddInfo;
            public StringField ChkMatIss;
            public StringField IcDefStdCost;
            public StringField CheckCustpo;
            public StringField CtlFgRtn;
            public StringField VochArRefund;
            public StringField VochApRefund;
            public StringField SlsoDn;
            public DecimalField AutoIncBy;
            public StringField QuoGenMultiSo;
            public StringField PuReceiveAll;
            public StringField PrpmItemMasterScrap;
            public StringField IcDisableCommit;
            public StringField ProdDefMatRemarks;
            public StringField SlsoUpdateQtyFromSch;
            public StringField PupoUpdateQtyFromSch;
            public StringField SlsoDefaultBasePrice;
            public StringField SlsoDiscountByCustomer;
            public StringField PrpmMaxQtyInStorage;
            public StringField IcDefCostType;
            public StringField ProdBomCreateItem;
            public StringField PupoRtvLoc;
            public StringField PrpmUseAllMatLastWc;
            public StringField IcNoDefCharge;
            public StringField ProdDefPhantomBom;
            public StringField SlsoNeedCmApproval;
            public StringField PupoNeedVmApproval;
            public StringField ProdNeedBomApproval;
            public StringField ProdNeedImApproval;
            public StringField PrpmNeedScrapReason;
            public StringField PrpmMustBackflush;
            public StringField PupoAutoOrderLink;
            public StringField PrpmAutoOrderLink;
            public StringField PrpeAllowChgJob;
            public StringField VochPrInspect;
            public StringField VochPrRework;
            public StringField ProdNeedPlanRlseApproval;
            public StringField PrpmIncludeScrapInMmi;
            public StringField ProdScrapLoc;
            public StringField MvtPrScrap;
            public StringField SlNeedClApproval;
            public StringField WarnOnMatConsum;
            public StringField IcimAutogenLot;
            public StringField IcimAutogenSerial;
            public StringField ItemAnlys5;
            public StringField ItemAnlys6;
            public StringField ItemAnlys7;
            public StringField ItemAnlys8;
            public StringField ItemAnlys9;
            public StringField ItemAnlys10;
            public StringField CustAnlys5;
            public StringField CustAnlys6;
            public StringField CustAnlys7;
            public StringField CustAnlys8;
            public StringField CustAnlys9;
            public StringField CustAnlys10;
            public StringField VendAnlys5;
            public StringField VendAnlys6;
            public StringField VendAnlys7;
            public StringField VendAnlys8;
            public StringField VendAnlys9;
            public StringField VendAnlys10;
            public StringField AcctAnlys5;
            public StringField AcctAnlys6;
            public StringField AcctAnlys7;
            public StringField AcctAnlys8;
            public StringField AcctAnlys9;
            public StringField AcctAnlys10;
            public StringField SaleAnlys9;
            public StringField SaleAnlys10;
            public StringField SaleAnlys11;
            public StringField SaleAnlys12;
            public StringField SaleAnlys13;
            public StringField SaleAnlys14;
            public StringField SaleAnlys15;
            public StringField SaleAnlys16;
            public StringField SaleAnlys17;
            public StringField SaleAnlys18;
            public StringField SaleAnlys19;
            public StringField SaleAnlys20;
            public StringField PurcAnlys9;
            public StringField PurcAnlys10;
            public StringField PurcAnlys11;
            public StringField PurcAnlys12;
            public StringField PurcAnlys13;
            public StringField PurcAnlys14;
            public StringField PurcAnlys15;
            public StringField PurcAnlys16;
            public StringField PurcAnlys17;
            public StringField PurcAnlys18;
            public StringField PurcAnlys19;
            public StringField PurcAnlys20;
            public StringField MvmtAnlys9;
            public StringField MvmtAnlys10;
            public StringField MvmtAnlys11;
            public StringField MvmtAnlys12;
            public StringField MvmtAnlys13;
            public StringField MvmtAnlys14;
            public StringField MvmtAnlys15;
            public StringField MvmtAnlys16;
            public StringField MvmtAnlys17;
            public StringField MvmtAnlys18;
            public StringField MvmtAnlys19;
            public StringField MvmtAnlys20;
            public StringField VochAnlys9;
            public StringField VochAnlys10;
            public StringField VochAnlys11;
            public StringField VochAnlys12;
            public StringField VochAnlys13;
            public StringField VochAnlys14;
            public StringField VochAnlys15;
            public StringField VochAnlys16;
            public StringField VochAnlys17;
            public StringField VochAnlys18;
            public StringField VochAnlys19;
            public StringField VochAnlys20;
            public StringField JordAnlys9;
            public StringField JordAnlys10;
            public StringField JordAnlys11;
            public StringField JordAnlys12;
            public StringField JordAnlys13;
            public StringField JordAnlys14;
            public StringField JordAnlys15;
            public StringField JordAnlys16;
            public StringField JordAnlys17;
            public StringField JordAnlys18;
            public StringField JordAnlys19;
            public StringField JordAnlys20;
            public StringField ArAnlys9;
            public StringField ArAnlys10;
            public StringField ArAnlys11;
            public StringField ArAnlys12;
            public StringField ArAnlys13;
            public StringField ArAnlys14;
            public StringField ArAnlys15;
            public StringField ArAnlys16;
            public StringField ArAnlys17;
            public StringField ArAnlys18;
            public StringField ArAnlys19;
            public StringField ArAnlys20;
            public StringField ApAnlys9;
            public StringField ApAnlys10;
            public StringField ApAnlys11;
            public StringField ApAnlys12;
            public StringField ApAnlys13;
            public StringField ApAnlys14;
            public StringField ApAnlys15;
            public StringField ApAnlys16;
            public StringField ApAnlys17;
            public StringField ApAnlys18;
            public StringField ApAnlys19;
            public StringField ApAnlys20;
            public BooleanField PrpeMoldAuditTrail;
            public BooleanField IcimIssueByAvailableQty;
            public BooleanField PrpmJamendIssueControl;
            public BooleanField PrAutoMultiSpareIssue;
            public BooleanField SlShipmentPriceControl;
            public BooleanField ArMultiSettle;
            public BooleanField PupoDefMultiship;
            public BooleanField PupoDefReorder;
            public BooleanField SlsoDefReorder;
            public BooleanField VochByVdate;
            public BooleanField PupoTaxTerms;
            public StringField SampleAcct;
            public BooleanField CtlFgRtnTotQty;
            public BooleanField AllowMultiWc;
            public BooleanField PoaIgnoreMinQty;
            public BooleanField GrnMatCost;
            public BooleanField GrnLotNoImport;
            public BooleanField IssueMaterialsByRouting;
            public BooleanField ConsumeMatInLastRouting;
            public StringField DefAqlLvlCritical;
            public StringField DefInspLvlSp;
            public StringField DefAqlLvlCriticalSp;
            public StringField DefAqlLvlMajSp;
            public StringField DefAqlLvlMinSp;
            public BooleanField WcAutoMatReturn;
            public BooleanField ArInvMultiPayTerms;
            public DecimalField IcAdjCodeAPcent;
            public DecimalField IcAdjCodeBPcent;
            public DecimalField IcAdjCodeCPcent;
            public BooleanField TailorIncludeJob;
            public BooleanField JoMultiSource;
            public BooleanField ShowShipmentInfoInPacking;
            public BooleanField MrpWithReorderPt;
            public BooleanField AllowFollowListWithoutMi;
            public BooleanField PrMultiFollowList;
            public BooleanField SqietkMatBalSubtractCommit;
            public DecimalField SoLineAutoIncBy;
            public DecimalField PoLineAutoIncBy;
            public BooleanField PuOverRcptByLine;
            public BooleanField PuLmeCost;
            public BooleanField SoaUpdatePendingShipment;
            public DecimalField PrMatIssueOnAvailPercent;
            public DecimalField JobHourlyRate;
            public BooleanField ItemCustomProdCodeRequired;
            public BooleanField IcimAutogenLotIssue;
            public BooleanField IcimAutogenSerialIssue;
            public BooleanField ShipmentInfoFromFirstOrder;
            public BooleanField MrpExcludeLeadtime;
            public BooleanField ItemPrelotSopo;
            public BooleanField SlsoCtrlBtmCeil;
            public BooleanField WcOverAcceptedLot;
            public BooleanField SlsoAutoResv;
            public DecimalField PercentA;
            public DecimalField PercentB;
            public DecimalField PercentC;
            public StringField EntryPostedRequirdBeforePrint;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "BasicInformation.CompanySetting";
            }
        }
    }
}
