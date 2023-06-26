﻿#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  CompanySettingForm.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Basic.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("BasicInformation.CompanySetting")]
    [BasedOnRow(typeof(Entities.CompanySettingRow))]
    public class CompanySettingForm
    {
        public String SlInit { get; set; }
        public String SlsoMultiship { get; set; }
        public String SlsoResv { get; set; }
        public String SlsoAssortment { get; set; }
        public String SlsoDeposits { get; set; }
        public String SlsoMeasures { get; set; }
        public String SlsoPtax { get; set; }
        public String SlsoAtax { get; set; }
        public String SlsoGtax { get; set; }
        public String SlsoLineDisc { get; set; }
        public String SlsoAutoPo { get; set; }
        public String SlsoAutoJob { get; set; }
        public String SlsoExtInst { get; set; }
        public String SlsoExtDesc { get; set; }
        public String SlsoFixedUom { get; set; }
        public String SlsoReqSman { get; set; }
        public String SlsoSman { get; set; }
        public String SlsoText1 { get; set; }
        public String SlsoText2 { get; set; }
        public String SlsoText3 { get; set; }
        public String SlsoText4 { get; set; }
        public Decimal SlsoDueLead { get; set; }
        public Decimal SlsoSchLead { get; set; }
        public String SlsoAddrCode { get; set; }
        public String SlsoAddrType { get; set; }
        public Decimal SlsoQuoteDays { get; set; }
        public Decimal SlshCutDays { get; set; }
        public String SlsoShipVia { get; set; }
        public String SlsoShipTerms { get; set; }
        public DateTime SlRevisedDate { get; set; }
        public String SlRevisedBy { get; set; }

        public String PuInit { get; set; }
        public String PupoMultiship { get; set; }
        public String PupoDeposits { get; set; }
        public String PupoMeasures { get; set; }
        public String PupoPtax { get; set; }
        public String PupoAtax { get; set; }
        public String PupoGtax { get; set; }
        public String PupoLineDisc { get; set; }
        public String PupoExtInst { get; set; }
        public String PupoExtDesc { get; set; }
        public String PupoFixedUom { get; set; }
        public String PupoText1 { get; set; }
        public String PupoText2 { get; set; }
        public String PupoText3 { get; set; }
        public String PupoText4 { get; set; }
        public Decimal PupoCutDays { get; set; }
        public String PupoReorder { get; set; }
        public String PupoReqBuyer { get; set; }
        public String PupoBuyer { get; set; }
        public String PupoShipVia { get; set; }
        public String PupoShipTerms { get; set; }
        public DateTime PuRevisedDate { get; set; }
        public String PuRevisedBy { get; set; }
        public String ProdInit { get; set; }
        public String ProdEcnReq { get; set; }
        public String ProdByprod { get; set; }
        public Decimal ProdScrapRate { get; set; }
        public String ProdPictDesc1 { get; set; }
        public String ProdPictDesc2 { get; set; }
        public String ProdPictDesc3 { get; set; }
        public String ProdPictDesc4 { get; set; }
        public String ProdWeightUom { get; set; }
        public String ProdDimenUom { get; set; }
        public String ProdFixedWtum { get; set; }
        public String ProdFixedDmum { get; set; }
        public Decimal ProdStdLsize { get; set; }
        public Decimal ProdMinLsize { get; set; }
        public Decimal ProdMaxLsize { get; set; }
        public Decimal ProdStdOutput { get; set; }
        public DateTime PrRevisedDate { get; set; }
        public String PrRevisedBy { get; set; }

        public String ShopReqJcat { get; set; }
        public Decimal ShopWksCover { get; set; }
        public String ShopPlanner { get; set; }
        public String ShopDefPlnr { get; set; }
        public Decimal ShopMpsHorz { get; set; }
        public Decimal ShopPurLtime { get; set; }
        public String ShopPurLunit { get; set; }
        public String ShopJobCat { get; set; }
        public Decimal ShopMrpHorz { get; set; }
        public DateTime ShRevisedDate { get; set; }
        public String ShRevisedBy { get; set; }

        public Decimal MrpCount { get; set; }
        public String MrpRefNo { get; set; }
        public DateTime MrpRunDate { get; set; }
        public DateTime MrpHorzDate { get; set; }

        public String IcInit { get; set; }
        public String IcReceipts { get; set; }
        public String IcIssuance { get; set; }
        public String IcTransfer { get; set; }
        public String IcAdjustment { get; set; }
        public DateTime IcRevisedDate { get; set; }
        public String IcRevisedBy { get; set; }
        public String PrJobSched { get; set; }
        public String PrByProd { get; set; }
        public String PrJobBatches { get; set; }
        public Decimal LastResvNo { get; set; }
        public String NoMrpFence { get; set; }
        public String MvtRmIssue { get; set; }
        public String MvtSpIssue { get; set; }
        public String MvtFgReturn { get; set; }
        public String MvtRmReturn { get; set; }
        public String MvtSlShipment { get; set; }
        public String MvtSlReturn { get; set; }
        public String MvtPuReceipt { get; set; }
        public String MvtPuInspect { get; set; }
        public String MvtPuReturn { get; set; }
        public String GlInit { get; set; }
        public String GlHdrTxt { get; set; }
        public String GlDtlTxt { get; set; }
        public String GlRefEntry { get; set; }
        public String GlRefLabel { get; set; }
        public String GlLrefEntry { get; set; }
        public String GlLrefLabel { get; set; }
        public String GlExchComp { get; set; }
        public String GlRevisedBy { get; set; }
        public DateTime GlRevisedDate { get; set; }
        public String VochArInvo { get; set; }
        public String VochArMemo { get; set; }
        public String VochArAdj { get; set; }
        public String VochArPay { get; set; }
        public String VochArAlloc { get; set; }
        public String VochArInvocan { get; set; }
        public String VochArPaycan { get; set; }
        public String VochApInvo { get; set; }
        public String VochApMemo { get; set; }
        public String VochApAdj { get; set; }
        public String VochApPay { get; set; }
        public String VochApAlloc { get; set; }
        public String VochApInvocan { get; set; }
        public String VochApPaycan { get; set; }
        public String VochIcIssue { get; set; }
        public String VochIcRcpt { get; set; }
        public String VochIcAdj { get; set; }
        public String VochPrIssue { get; set; }
        public String VochPrReturn { get; set; }
        public String VochPrProd { get; set; }
        public String VochPrSubcon { get; set; }
        public String VochPayroll { get; set; }
        public String VochCommission { get; set; }
        public String VochFaAcquire { get; set; }
        public String VochFaDeprec { get; set; }
        public String VochFaMaint { get; set; }
        public String VochFaDispo { get; set; }
        public Decimal ArBcountInvo { get; set; }
        public Decimal ArBcountMemo { get; set; }
        public Decimal ArBcountAdj { get; set; }
        public Decimal ArBcountPay { get; set; }
        public Decimal ArBcountAlloc { get; set; }
        public Decimal ApBcountInvo { get; set; }
        public Decimal ApBcountMemo { get; set; }
        public Decimal ApBcountAdj { get; set; }
        public Decimal ApBcountPay { get; set; }
        public Decimal ApBcountAlloc { get; set; }
        public String CostInit { get; set; }
        public String CostBasis { get; set; }
        public Decimal CostRmPrMul { get; set; }
        public Decimal CostLbPrMul { get; set; }
        public Decimal CostOvPrMul { get; set; }
        public Decimal CostRmSlMul { get; set; }
        public Decimal CostLbSlMul { get; set; }
        public Decimal CostOvSlMul { get; set; }
        public String CostRevisedBy { get; set; }
        public DateTime CostRevDate { get; set; }
        public String PrCostVerify { get; set; }
        public String PrCostEdit { get; set; }
        public String CommisType { get; set; }
        public String SlsoCustItem { get; set; }
        public String SlsoPkgType { get; set; }
        public String IcAutoShip { get; set; }
        public String IcAutoSlret { get; set; }
        public String IcAutoGrn { get; set; }
        public String IcAutoQc { get; set; }
        public String IcAutoPuret { get; set; }
        public String IcAutoWorkc { get; set; }
        public String ApOvrideRate { get; set; }
        public String SlsoSchEntry { get; set; }
        public String PupoSchEntry { get; set; }
        public String SlsoContact { get; set; }
        public String SlsoOrdrPack { get; set; }
        public Decimal MaxUsers { get; set; }
        public String MmuKey { get; set; }
        public String AcctAnlys1 { get; set; }
        public String AcctAnlys2 { get; set; }
        public String AcctAnlys3 { get; set; }
        public String AcctAnlys4 { get; set; }
        public String VochAnlys1 { get; set; }
        public String VochAnlys2 { get; set; }
        public String VochAnlys3 { get; set; }
        public String VochAnlys4 { get; set; }
        public String VochAnlys5 { get; set; }
        public String VochAnlys6 { get; set; }
        public String ItemAnlys1 { get; set; }
        public String ItemAnlys2 { get; set; }
        public String ItemAnlys3 { get; set; }
        public String ItemAnlys4 { get; set; }
        public String CustAnlys1 { get; set; }
        public String CustAnlys2 { get; set; }
        public String CustAnlys3 { get; set; }
        public String CustAnlys4 { get; set; }
        public String VendAnlys1 { get; set; }
        public String VendAnlys2 { get; set; }
        public String VendAnlys3 { get; set; }
        public String VendAnlys4 { get; set; }
        public String SaleAnlys1 { get; set; }
        public String SaleAnlys2 { get; set; }
        public String SaleAnlys3 { get; set; }
        public String SaleAnlys4 { get; set; }
        public String SaleAnlys5 { get; set; }
        public String SaleAnlys6 { get; set; }
        public String PurcAnlys1 { get; set; }
        public String PurcAnlys2 { get; set; }
        public String PurcAnlys3 { get; set; }
        public String PurcAnlys4 { get; set; }
        public String PurcAnlys5 { get; set; }
        public String PurcAnlys6 { get; set; }
        public String MvmtAnlys1 { get; set; }
        public String MvmtAnlys2 { get; set; }
        public String MvmtAnlys3 { get; set; }
        public String MvmtAnlys4 { get; set; }
        public String MvmtAnlys5 { get; set; }
        public String MvmtAnlys6 { get; set; }
        public DateTime NrevisedDate { get; set; }
        public String NrevisedBy { get; set; }
        public String ShipWtUom { get; set; }
        public String ShipDimUom { get; set; }
        public String ItemPacking { get; set; }
        public String NoOvhdAcctg { get; set; }
        public String NoVariaAcctg { get; set; }
        public String NoFgAcctg { get; set; }
        public String FgCostLimit { get; set; }
        public String AllowDescChg { get; set; }
        public String NoLaborAcctg { get; set; }
        public String NoSubconAcctg { get; set; }
        public String ReorderIsNew { get; set; }
        public String DefInspStd { get; set; }
        public String DefInspLvl { get; set; }
        public String DefAqlLvlMaj { get; set; }
        public String DefAqlLvlMin { get; set; }
        public String ReturnEmail { get; set; }
        public String SmtpServer { get; set; }
        public String WebSetting1 { get; set; }
        public String WebSetting2 { get; set; }
        public String WebSetting3 { get; set; }
        public String WebSetting4 { get; set; }
        public String PupoPriceCtrl { get; set; }
        public String JordAnlys1 { get; set; }
        public String JordAnlys2 { get; set; }
        public String JordAnlys3 { get; set; }
        public String JordAnlys4 { get; set; }
        public String JordAnlys5 { get; set; }
        public String JordAnlys6 { get; set; }
        public String ProdPosEntry { get; set; }
        public String GlarText1 { get; set; }
        public String GlarText2 { get; set; }
        public String GlarText3 { get; set; }
        public String GlarText4 { get; set; }
        public String PrJobClose { get; set; }
        public String SlsoUnfullPackResponse { get; set; }
        public String SlsoDefMultiShip { get; set; }
        public String SlsoDefAutoPo { get; set; }
        public String SlsoDefAutoJo { get; set; }
        public String SlpaExtDesc { get; set; }
        public Decimal PupoDueLead { get; set; }
        public Decimal PupoSchLead { get; set; }
        public String PrMultiIssue { get; set; }
        public String ProdSepRoute { get; set; }
        public String ProdHideWcSubcon { get; set; }
        public String CopyTextFromSo { get; set; }
        public String PrpmText1 { get; set; }
        public String PrpmText2 { get; set; }
        public String PrpmText3 { get; set; }
        public String PrpmText4 { get; set; }
        public String PrpmExtInst { get; set; }
        public Int32 BomVerLen { get; set; }
        public String ProdPoPrice { get; set; }
        public String SaleAnlys7 { get; set; }
        public String SaleAnlys8 { get; set; }
        public String PurcAnlys7 { get; set; }
        public String PurcAnlys8 { get; set; }
        public String MvmtAnlys7 { get; set; }
        public String MvmtAnlys8 { get; set; }
        public String VochAnlys7 { get; set; }
        public String VochAnlys8 { get; set; }
        public String JordAnlys7 { get; set; }
        public String JordAnlys8 { get; set; }
        public String ArAnlys1 { get; set; }
        public String ArAnlys2 { get; set; }
        public String ArAnlys3 { get; set; }
        public String ArAnlys4 { get; set; }
        public String ArAnlys5 { get; set; }
        public String ArAnlys6 { get; set; }
        public String ArAnlys7 { get; set; }
        public String ArAnlys8 { get; set; }
        public String ApAnlys1 { get; set; }
        public String ApAnlys2 { get; set; }
        public String ApAnlys3 { get; set; }
        public String ApAnlys4 { get; set; }
        public String ApAnlys5 { get; set; }
        public String ApAnlys6 { get; set; }
        public String ApAnlys7 { get; set; }
        public String ApAnlys8 { get; set; }
        public String SlAddInfo { get; set; }
        public String PuAddInfo { get; set; }
        public String PrAddInfo { get; set; }
        public String IcAddInfo { get; set; }
        public String ChkMatIss { get; set; }
        public String IcDefStdCost { get; set; }
        public String CheckCustpo { get; set; }
        public String CtlFgRtn { get; set; }
        public String VochArRefund { get; set; }
        public String VochApRefund { get; set; }
        public String SlsoDn { get; set; }
        public Decimal AutoIncBy { get; set; }
        public String QuoGenMultiSo { get; set; }
        public String PuReceiveAll { get; set; }
        public String PrpmItemMasterScrap { get; set; }
        public String IcDisableCommit { get; set; }
        public String ProdDefMatRemarks { get; set; }
        public String SlsoUpdateQtyFromSch { get; set; }
        public String PupoUpdateQtyFromSch { get; set; }
        public String SlsoDefaultBasePrice { get; set; }
        public String SlsoDiscountByCustomer { get; set; }
        public String PrpmMaxQtyInStorage { get; set; }
        public String IcDefCostType { get; set; }
        public String ProdBomCreateItem { get; set; }
        public String PupoRtvLoc { get; set; }
        public String PrpmUseAllMatLastWc { get; set; }
        public String IcNoDefCharge { get; set; }
        public String ProdDefPhantomBom { get; set; }
        public String SlsoNeedCmApproval { get; set; }
        public String PupoNeedVmApproval { get; set; }
        public String ProdNeedBomApproval { get; set; }
        public String ProdNeedImApproval { get; set; }
        public String PrpmNeedScrapReason { get; set; }
        public String PrpmMustBackflush { get; set; }
        public String PupoAutoOrderLink { get; set; }
        public String PrpmAutoOrderLink { get; set; }
        public String PrpeAllowChgJob { get; set; }
        public String VochPrInspect { get; set; }
        public String VochPrRework { get; set; }
        public String ProdNeedPlanRlseApproval { get; set; }
        public String PrpmIncludeScrapInMmi { get; set; }
        public String ProdScrapLoc { get; set; }
        public String MvtPrScrap { get; set; }
        public String SlNeedClApproval { get; set; }
        public String WarnOnMatConsum { get; set; }
        public String IcimAutogenLot { get; set; }
        public String IcimAutogenSerial { get; set; }
        public String ItemAnlys5 { get; set; }
        public String ItemAnlys6 { get; set; }
        public String ItemAnlys7 { get; set; }
        public String ItemAnlys8 { get; set; }
        public String ItemAnlys9 { get; set; }
        public String ItemAnlys10 { get; set; }
        public String CustAnlys5 { get; set; }
        public String CustAnlys6 { get; set; }
        public String CustAnlys7 { get; set; }
        public String CustAnlys8 { get; set; }
        public String CustAnlys9 { get; set; }
        public String CustAnlys10 { get; set; }
        public String VendAnlys5 { get; set; }
        public String VendAnlys6 { get; set; }
        public String VendAnlys7 { get; set; }
        public String VendAnlys8 { get; set; }
        public String VendAnlys9 { get; set; }
        public String VendAnlys10 { get; set; }
        public String AcctAnlys5 { get; set; }
        public String AcctAnlys6 { get; set; }
        public String AcctAnlys7 { get; set; }
        public String AcctAnlys8 { get; set; }
        public String AcctAnlys9 { get; set; }
        public String AcctAnlys10 { get; set; }
        public String SaleAnlys9 { get; set; }
        public String SaleAnlys10 { get; set; }
        public String SaleAnlys11 { get; set; }
        public String SaleAnlys12 { get; set; }
        public String SaleAnlys13 { get; set; }
        public String SaleAnlys14 { get; set; }
        public String SaleAnlys15 { get; set; }
        public String SaleAnlys16 { get; set; }
        public String SaleAnlys17 { get; set; }
        public String SaleAnlys18 { get; set; }
        public String SaleAnlys19 { get; set; }
        public String SaleAnlys20 { get; set; }
        public String PurcAnlys9 { get; set; }
        public String PurcAnlys10 { get; set; }
        public String PurcAnlys11 { get; set; }
        public String PurcAnlys12 { get; set; }
        public String PurcAnlys13 { get; set; }
        public String PurcAnlys14 { get; set; }
        public String PurcAnlys15 { get; set; }
        public String PurcAnlys16 { get; set; }
        public String PurcAnlys17 { get; set; }
        public String PurcAnlys18 { get; set; }
        public String PurcAnlys19 { get; set; }
        public String PurcAnlys20 { get; set; }
        public String MvmtAnlys9 { get; set; }
        public String MvmtAnlys10 { get; set; }
        public String MvmtAnlys11 { get; set; }
        public String MvmtAnlys12 { get; set; }
        public String MvmtAnlys13 { get; set; }
        public String MvmtAnlys14 { get; set; }
        public String MvmtAnlys15 { get; set; }
        public String MvmtAnlys16 { get; set; }
        public String MvmtAnlys17 { get; set; }
        public String MvmtAnlys18 { get; set; }
        public String MvmtAnlys19 { get; set; }
        public String MvmtAnlys20 { get; set; }
        public String VochAnlys9 { get; set; }
        public String VochAnlys10 { get; set; }
        public String VochAnlys11 { get; set; }
        public String VochAnlys12 { get; set; }
        public String VochAnlys13 { get; set; }
        public String VochAnlys14 { get; set; }
        public String VochAnlys15 { get; set; }
        public String VochAnlys16 { get; set; }
        public String VochAnlys17 { get; set; }
        public String VochAnlys18 { get; set; }
        public String VochAnlys19 { get; set; }
        public String VochAnlys20 { get; set; }
        public String JordAnlys9 { get; set; }
        public String JordAnlys10 { get; set; }
        public String JordAnlys11 { get; set; }
        public String JordAnlys12 { get; set; }
        public String JordAnlys13 { get; set; }
        public String JordAnlys14 { get; set; }
        public String JordAnlys15 { get; set; }
        public String JordAnlys16 { get; set; }
        public String JordAnlys17 { get; set; }
        public String JordAnlys18 { get; set; }
        public String JordAnlys19 { get; set; }
        public String JordAnlys20 { get; set; }
        public String ArAnlys9 { get; set; }
        public String ArAnlys10 { get; set; }
        public String ArAnlys11 { get; set; }
        public String ArAnlys12 { get; set; }
        public String ArAnlys13 { get; set; }
        public String ArAnlys14 { get; set; }
        public String ArAnlys15 { get; set; }
        public String ArAnlys16 { get; set; }
        public String ArAnlys17 { get; set; }
        public String ArAnlys18 { get; set; }
        public String ArAnlys19 { get; set; }
        public String ArAnlys20 { get; set; }
        public String ApAnlys9 { get; set; }
        public String ApAnlys10 { get; set; }
        public String ApAnlys11 { get; set; }
        public String ApAnlys12 { get; set; }
        public String ApAnlys13 { get; set; }
        public String ApAnlys14 { get; set; }
        public String ApAnlys15 { get; set; }
        public String ApAnlys16 { get; set; }
        public String ApAnlys17 { get; set; }
        public String ApAnlys18 { get; set; }
        public String ApAnlys19 { get; set; }
        public String ApAnlys20 { get; set; }
        public Boolean PrpeMoldAuditTrail { get; set; }
        public Boolean IcimIssueByAvailableQty { get; set; }
        public Boolean PrpmJamendIssueControl { get; set; }
        public Boolean PrAutoMultiSpareIssue { get; set; }
        public Boolean SlShipmentPriceControl { get; set; }
        public Boolean ArMultiSettle { get; set; }
        public Boolean PupoDefMultiship { get; set; }
        public Boolean PupoDefReorder { get; set; }
        public Boolean SlsoDefReorder { get; set; }
        public Boolean VochByVdate { get; set; }
        public Boolean PupoTaxTerms { get; set; }
        public String SampleAcct { get; set; }
        public Boolean CtlFgRtnTotQty { get; set; }
        public Boolean AllowMultiWc { get; set; }
        public Boolean PoaIgnoreMinQty { get; set; }
        public Boolean GrnMatCost { get; set; }
        public Boolean GrnLotNoImport { get; set; }
        public Boolean IssueMaterialsByRouting { get; set; }
        public Boolean ConsumeMatInLastRouting { get; set; }
        public String DefAqlLvlCritical { get; set; }
        public String DefInspLvlSp { get; set; }
        public String DefAqlLvlCriticalSp { get; set; }
        public String DefAqlLvlMajSp { get; set; }
        public String DefAqlLvlMinSp { get; set; }
        public Boolean WcAutoMatReturn { get; set; }
        public Boolean ArInvMultiPayTerms { get; set; }
        public Decimal IcAdjCodeAPcent { get; set; }
        public Decimal IcAdjCodeBPcent { get; set; }
        public Decimal IcAdjCodeCPcent { get; set; }
        public Boolean TailorIncludeJob { get; set; }
        public Boolean JoMultiSource { get; set; }
        public Boolean ShowShipmentInfoInPacking { get; set; }
        public Boolean MrpWithReorderPt { get; set; }
        public Boolean AllowFollowListWithoutMi { get; set; }
        public Boolean PrMultiFollowList { get; set; }
        public Boolean SqietkMatBalSubtractCommit { get; set; }
        public Decimal SoLineAutoIncBy { get; set; }
        public Decimal PoLineAutoIncBy { get; set; }
        public Boolean PuOverRcptByLine { get; set; }
        public Boolean PuLmeCost { get; set; }
        public Boolean SoaUpdatePendingShipment { get; set; }
        public Decimal PrMatIssueOnAvailPercent { get; set; }
        public Decimal JobHourlyRate { get; set; }
        public Boolean ItemCustomProdCodeRequired { get; set; }
        public Boolean IcimAutogenLotIssue { get; set; }
        public Boolean IcimAutogenSerialIssue { get; set; }
        public Boolean ShipmentInfoFromFirstOrder { get; set; }
        public Boolean MrpExcludeLeadtime { get; set; }
        public Boolean ItemPrelotSopo { get; set; }
        public Boolean SlsoCtrlBtmCeil { get; set; }
        public Boolean WcOverAcceptedLot { get; set; }
        public Boolean SlsoAutoResv { get; set; }
        public Decimal PercentA { get; set; }
        public Decimal PercentB { get; set; }
        public Decimal PercentC { get; set; }
        public String EntryPostedRequirdBeforePrint { get; set; }
    }
}