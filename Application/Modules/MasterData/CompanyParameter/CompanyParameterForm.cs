#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  CompanyParameterForm.cs
// Date: 2018/04/03 20:51

#endregion

using Matrix.Modules.Common.Enum;

namespace Matrix.Basic.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Basic.CompanyParameter")]
    [BasedOnRow(typeof(Entities.CompanyParameterRow))]
    public class CompanyParameterForm
    {
        #region Company Address

        [Tab(TabName.CompanyAddress)]
        public String CompanyName { get; set; }

        public String Address { get; set; }
        public String Address2 { get; set; }
        public String Address3 { get; set; }
        public String Address4 { get; set; }
        public String PostCode { get; set; }
        public String TelNo { get; set; }
        public String FaxNo { get; set; }
        public String Email { get; set; }
        public String TaxAcctNo { get; set; }
        public String BusRegNo { get; set; }

        [Category(CategoryName.AlternateInformation)]
        public String AltName { get; set; }

        public String AltAddress { get; set; }
        public String AltAddress2 { get; set; }
        public String AltAddress3 { get; set; }
        public String AltAddress4 { get; set; }

        [Tab(TabName.GlobalControls)]
        public bool VerifySettings { get; set; }

        public String BranchNo { get; set; }

        public Decimal NoOfPeriods { get; set; }
        //public DateTime DrevisedDate { get; set; }
        //public String DrevisedBy { get; set; }


        public String CurrentPeriod { get; set; }

        [DisplayName("Open Period From")]
        public String OpenPrdFrom { get; set; }

        [DisplayName("Open Period To")]
        public String OpenPrdTo { get; set; }

        public String BaseCurrency { get; set; }

        [DisplayName("Allocation Method")]
        public String AllocMethod { get; set; }

        [DisplayName("Item No. Length")]
        public Decimal ItmNoLen { get; set; }

        [DisplayName("Item No Grid Length")]
        public Decimal ItmNoGridLen { get; set; }

        [DisplayName("Bom No. Grid Length")]
        public Decimal BomNoGridLen { get; set; }

        [Category(CategoryName.ControlChecklist)]
        public String AllowEntries { get; set; }

        public String LineNoEntry { get; set; }

        [DisplayName("Inspection Required")]
        public String WithInspection { get; set; }

        [DisplayName("Implement Required")]
        public String WithDept { get; set; }

        [DisplayName("Implement Cost Centres")]
        public String WithCostCtr { get; set; }

        [DisplayName("Implement ACCPAC")]
        public String WithAccpac { get; set; }

        [DisplayName("Implement ACCPAC by Item Group")]
        public String AccpacIgrp { get; set; }

        [DisplayName("Implement Bin Control")]
        public String WithBinCtrl { get; set; }

        [DisplayName("Implement Lot")]
        public String WithLot { get; set; }

        [DisplayName("Attachment Save into Database")]
        //public String WithServerAttm { get; set; }
        public String WithSqlAttm { get; set; }


        #endregion

        #region Common Defaults

        [Tab(TabName.CommonDefaults)]
        [Category(CategoryName.InventoryLocations)]
        public String AcctRetEarn { get; set; }
        public String AcctCurEarn { get; set; }

        [Category(CategoryName.GeneralClassifications)]
        public String AcctEndBs { get; set; }
        public String LocReceiving { get; set; }
        public String LocShipment { get; set; }

        [Category(CategoryName.ClientTransactions)]
        public String LocPos { get; set; }
        public String LocMaterial { get; set; }
        public String LocProduce { get; set; }
        public String IcRevaluation { get; set; }
        public String FgStdCosting { get; set; }

        [Category(CategoryName.DepartmentCodes)]
        public String CostingMethod { get; set; }
        public String AllowLotOpt { get; set; }
        public String PmntFundCode { get; set; }
        public String RcptFundCode { get; set; }
        public String SalesPayTerms { get; set; }
        public String PurchPayTerms { get; set; }
        public String ItemGroup { get; set; }
        public String CustomerGroup { get; set; }
        public String VendorGroup { get; set; }

        #endregion
        
        #region Sales
            
        [Tab(TabName.Sales)]
        [Category(CategoryName.SalesOrderFeatures)]
        //public String SlInit { get; set; }
        [DisplayName("Support Multiple Shipments")]
        public String SlsoMultiship { get; set; }
        [DisplayName("Support Inventory Reservation")]
        public String SlsoResv { get; set; }
        [DisplayName("Process Congifurable Assortments")]
        public String SlsoAssortment { get; set; }
        [DisplayName("Process Deposits")]
        public String SlsoDeposits { get; set; }
        [DisplayName("Include Measures and Packing")]
        public String SlsoMeasures { get; set; }

        //public String SlsoPtax { get; set; }
        //public String SlsoAtax { get; set; }
        //public String SlsoGtax { get; set; }
        //public String SlsoLineDisc { get; set; }
        [DisplayName("Support Auto-PO Generation")]
        public String SlsoAutoPo { get; set; }
        [DisplayName("Support Auto-Job Order Generation")]
        public String SlsoAutoJob { get; set; }
        [DisplayName("Support Additional Comments")]
        public String SlsoExtInst { get; set; }
        [DisplayName("Support Extended Description")]
        public String SlsoExtDesc { get; set; }

        //public String SlsoFixedUom { get; set; }
        [DisplayName("Require Salesman Entry")]
        public String SlsoReqSman { get; set; }
        //public String SlsoSman { get; set; }

        [Category(CategoryName.PreSetTextTypes)]
        [DisplayName("1")]
        public String SlsoText1 { get; set; }
        [DisplayName("2")]
        public String SlsoText2 { get; set; }
        [DisplayName("3")]
        public String SlsoText3 { get; set; }
        [DisplayName("4")]
        public String SlsoText4 { get; set; }

        [Category(CategoryName.LeadTimeDefaults)]
        [DisplayName("Due Date")]
        public Decimal SlsoDueLead { get; set; }
        [DisplayName("Sched Date")]
        public Decimal SlsoSchLead { get; set; }
        [DisplayName("Quotation Validity")]
        public Decimal SlsoQuoteDays { get; set; }

        [Category(CategoryName.Misc)]
        [DisplayName("Shipment Cut-off Days")]
        public Decimal SlshCutDays { get; set; }
        [DisplayName("Default Address Code")]
        public String SlsoAddrCode { get; set; }
        [DisplayName("Shipment Address Type")]
        public String SlsoAddrType { get; set; }
        [DisplayName("Shipment Via")]
        public String SlsoShipVia { get; set; }
        [DisplayName("Shipment Terms")]
        public String SlsoShipTerms { get; set; }
        //public DateTime SlRevisedDate { get; set; }
        //public String SlRevisedBy { get; set; }

        #endregion CompanySettingRow

        #region Purchasing
            
        [Tab(TabName.Purchasing)]
        [Category(CategoryName.PurchaseOrderFeatures)]
        //public String PuInit { get; set; }
        [DisplayName("Support Multiple Shipments")]
        public String PupoMultiship { get; set; }
        [DisplayName("Support Deposit")]
        public String PupoDeposits { get; set; }
        [DisplayName("Include Weights and Measures")]
        public String PupoMeasures { get; set; }
        [DisplayName("Required Buyer Entry")]
        public String PupoReqBuyer { get; set; }
        [DisplayName("Support Line Discounts")]
        public String PupoLineDisc { get; set; }
        [DisplayName("Reorder=New Order")]
        public String PupoReorder { get; set; }

       
        [Category(CategoryName.PreSetTextTypes)]
        [DisplayName("1")]
        public String PupoText1 { get; set; }
        [DisplayName("2")]
        public String PupoText2 { get; set; }
        [DisplayName("3")]
        public String PupoText3 { get; set; }
        [DisplayName("4")]
        public String PupoText4 { get; set; }

        [Category(CategoryName.Misc)]
        [DisplayName("Receiving Cut-off Days")]
        public Decimal PupoCutDays { get; set; }
        [DisplayName("Default Buyer")]
        public String PupoBuyer { get; set; }
        [DisplayName("Default Ship Via")]
        public String PupoShipVia { get; set; }
        [DisplayName("Default Shipment Terms")]
        public String PupoShipTerms { get; set; }

        #endregion
        
        #region Engineering
            
        [Tab(TabName.Engineering)]
        [Category(CategoryName.Control)]
        //public String ProdInit { get; set; }
        [DisplayName("ECN Required")]
        public String ProdEcnReq { get; set; }
        [DisplayName("Support By-Products")]
        public String ProdByprod { get; set; }

        [Category(CategoryName.PictureDescriptions)]
        [DisplayName("1")]
        public String ProdPictDesc1 { get; set; }
        [DisplayName("2")]
        public String ProdPictDesc2 { get; set; }
        [DisplayName("3")]
        public String ProdPictDesc3 { get; set; }
        [DisplayName("4")]
        public String ProdPictDesc4 { get; set; }
      
        //public String ProdFixedWtum { get; set; }
        //public String ProdFixedDmum { get; set; }

        [Category(CategoryName.UnitofMeasure)]
        [DisplayName("Weight")]
        public String ProdWeightUom { get; set; }
        [DisplayName("Dimension")]
        public String ProdDimenUom { get; set; }

        [Category(CategoryName.UsefulDefaults)]
        [DisplayName("Scrap Rate")]
        public Decimal ProdScrapRate { get; set; }
        [DisplayName("Std Lot Size")]
        public Decimal ProdStdLsize { get; set; }
        [DisplayName("Min Lot Size")]
        public Decimal ProdMinLsize { get; set; }
        [DisplayName("Max Lot Size")]
        public Decimal ProdMaxLsize { get; set; }
        [DisplayName("Std Output")]
        public Decimal ProdStdOutput { get; set; }

        #endregion

        #region Production
            
       
        [Tab(TabName.Production)]
        [Category(CategoryName.UsefulDefaults)]
        [DisplayName("Weeks of Coverage")]
        public Decimal ShopWksCover { get; set; }
        [DisplayName("MPS Horizon(Months)")]
        public DateTime MrpHorzDate { get; set; }

        //public String ShopReqJcat { get; set; }
        [DisplayName("Planner")]
        public String ShopPlanner { get; set; }

        [Category(CategoryName.ProductionMaterialControl)]
        [DisplayName("Require Job Category")]
        public String ShopJobCat { get; set; }


        [Category(CategoryName.PreSetTextTypes)]
        public String PrpmText1 { get; set; }
        public String PrpmText2 { get; set; }
        public String PrpmText3 { get; set; }
        public String PrpmText4 { get; set; }

        //public String ShopDefPlnr { get; set; }
        //public Decimal ShopMpsHorz { get; set; }
        //public Decimal ShopPurLtime { get; set; }
        //public String ShopPurLunit { get; set; }
        //public Decimal ShopMrpHorz { get; set; }
        //public DateTime ShRevisedDate { get; set; }
        //public String ShRevisedBy { get; set; }
        [Tab(TabName.JobCosting)]
        public Decimal MrpCount { get; set; }
        public String MrpRefNo { get; set; }
        public DateTime MrpRunDate { get; set; }

        #endregion

        #region Inventory
        
        [Tab(TabName.Inventory)]
        //public String IcInit { get; set; }
        [Category(CategoryName.DefaultMovementTypes)]
        [DisplayName("Receipts")]
        public String IcReceipts { get; set; }
        [DisplayName("Issuance")]
        public String IcIssuance { get; set; }
        [DisplayName("Transfer")]
        public String IcTransfer { get; set; }
        [DisplayName("Adjustment")]
        public String IcAdjustment { get; set; }

        //public DateTime IcRevisedDate { get; set; }
        //public String IcRevisedBy { get; set; }

        //public String PrJobSched { get; set; }
        //public String PrByProd { get; set; }
        //public String PrJobBatches { get; set; }
        //public Decimal LastResvNo { get; set; }
        //public String NoMrpFence { get; set; }
        //public String MvtRmIssue { get; set; }
        //public String MvtSpIssue { get; set; }
        //public String MvtFgReturn { get; set; }
        //public String MvtRmReturn { get; set; }
        [Category(CategoryName.InterModuleControls)]
        [DisplayName("Auto-post Issuances for Shipment")]
        public String MvtSlShipment { get; set; }
        [DisplayName("Auto-post Receipts for Sales Returns")]
        public String MvtSlReturn { get; set; }
        [DisplayName("Auto-ost Purchase Receipts")]
        public String MvtPuReceipt { get; set; }
        [DisplayName("Auto-post Purchase Inpsection")]
        public String MvtPuInspect { get; set; }
        [DisplayName("Auto-post Purchase Returns")]
        public String MvtPuReturn { get; set; }

        #endregion

        #region Finance
        
        [Tab(TabName.Finance)]
        [Category(CategoryName.Control)]
        public String VochArInvo { get; set; }
        public String VochArMemo { get; set; }
        public String VochArAdj { get; set; }
        public String VochArPay { get; set; }

        //public String GlInit { get; set; }
        [Category(CategoryName.PreSetTextTypes)]
        [DisplayName("1")]
        public String GlHdrTxt { get; set; }
        [DisplayName("2")]
        public String GlRefEntry { get; set; }
        [DisplayName("3")]
        public String GlDtlTxt { get; set; }
        [DisplayName("4")]
        public String GlLrefEntry { get; set; }

        [Category(CategoryName.Misc)]
        [DisplayName("Reference Label")]
        public String GlRefLabel { get; set; }
        [DisplayName("Line Ref Label")]
        public String GlLrefLabel { get; set; }

        #endregion

        //public String SlCgtaxCode { get; set; }

        //public String SlCltaxCode { get; set; }
        //public String SlVgtaxCode { get; set; }
        //public String SlVltaxCode { get; set; }
        //public String SlItaxCode { get; set; }
        //public String PuCgtaxCode { get; set; }
        //public String PuCltaxCode { get; set; }
        //public String PuVgtaxCode { get; set; }
        //public String PuVltaxCode { get; set; }
        //public String PuItaxCode { get; set; }
        //public String WithTaxation { get; set; }
        //public String ProcSalesGtax { get; set; }
        //public String ProcSalesLtax { get; set; }
        //public String ProcPurchGtax { get; set; }

        //public String ProcPurchLtax { get; set; }
        ////public DateTime TrevisedDate { get; set; }
        ////public String TrevisedBy { get; set; }
        ////public DateTime RevisedDate { get; set; }
        ////public String RevisedBy { get; set; }

        ////public String MainBranPath { get; set; }
        ////public Decimal MainBranCount { get; set; }
        //public String OnlineBranUpd { get; set; }


        //[Tab(TabName.Ledger)]
        //public String AcctItmAsset { get; set; }

        //public String AcctItmWip { get; set; }
        //public String AcctItmConsum { get; set; }
        //public String AcctItmScrap { get; set; }
        //public String AcctItmPvar { get; set; }
        //public String AcctItmReval { get; set; }
        //public String AcctItmVaria { get; set; }
        //public String AcctItmSales { get; set; }
        //public String AcctItmSlret { get; set; }
        //public String AcctItmSldisc { get; set; }
        //public String AcctItmCogs { get; set; }
        //public String AcctItmPurch { get; set; }
        //public String AcctItmPuret { get; set; }
        //public String AcctItmPudisc { get; set; }
        //public String AcctItmPutax { get; set; }
        //public String AcctMvtIssue { get; set; }
        //public String AcctMvtRcpt { get; set; }
        //public String AcctMvtAdj { get; set; }
        //public String AcctSlsMisc { get; set; }
        //public String AcctSlsMscret { get; set; }
        //public String AcctSlsTrdisc { get; set; }
        //public String AcctSlsLntax { get; set; }
        //public String AcctSlsGrtax { get; set; }
        //public String AcctPurMisc { get; set; }
        //public String AcctPurMscret { get; set; }
        //public String AcctPurTrdisc { get; set; }
        //public String AcctPurGrtax { get; set; }
        //public String AcctArCash { get; set; }
        //public String AcctArCust { get; set; }
        //public String AcctArDisc { get; set; }
        //public String AcctArAdj { get; set; }
        //public String AcctArForex { get; set; }
        //public String AcctApCash { get; set; }
        //public String AcctApVend { get; set; }
        //public String AcctApDisc { get; set; }
        //public String AcctApAdj { get; set; }
        //public String AcctApForex { get; set; }
        //public String AcctApVaria { get; set; }
        //public String AcctMachine { get; set; }
        //public String AcctEnergy { get; set; }
        //public String AcctWater { get; set; }
        //public String AcctRental { get; set; }
        //public String AcctLabor { get; set; }
        //public String AcctInlab { get; set; }
        //public String AcctInmat { get; set; }
        //public String AcctMisc { get; set; }
        //public String AcctSuspAr { get; set; }
        //public String AcctSuspAp { get; set; }
        //public String AcctSuspIc { get; set; }
        //public String AcctSuspPr { get; set; }
        //public String AcctSuspFa { get; set; }
        //public String AcctSuspSub { get; set; }
        //public String AcctSuspIncom { get; set; }

        //public String AcctSuspExpen { get; set; }

        ////public DateTime ArevisedDate { get; set; }
        ////public String ArevisedBy { get; set; }
        ////public DateTime BrevisedDate { get; set; }
        ////public String BrevisedBy { get; set; }
        //[Tab(TabName.Pricing)]
        //public String DeptProd { get; set; }

        //public String DeptSales { get; set; }
        //public String DeptPurch { get; set; }
        //public Decimal NoOfShift { get; set; }
        //public Decimal Shift1Hrs { get; set; }
        //public Decimal Shift2Hrs { get; set; }
        //public Decimal Shift3Hrs { get; set; }
        //public String Shift1Start { get; set; }
        //public String Shift2Start { get; set; }
        //public String Shift3Start { get; set; }
        //public Decimal FirstWeekDay { get; set; }
        //public String CanReceive1 { get; set; }
        //public String CanReceive2 { get; set; }
        //public String CanReceive3 { get; set; }
        //public String CanReceive4 { get; set; }
        //public String CanReceive5 { get; set; }
        //public String CanReceive6 { get; set; }
        //public String CanReceive7 { get; set; }

        //[Tab(TabName.ProductionControl)]
        //public String CanShip1 { get; set; }

        //public String CanShip2 { get; set; }
        //public String CanShip3 { get; set; }
        //public String CanShip4 { get; set; }
        //public String CanShip5 { get; set; }
        //public String CanShip6 { get; set; }
        //public String CanShip7 { get; set; }
        //public String IsHoliday1 { get; set; }
        //public String IsHoliday2 { get; set; }
        //public String IsHoliday3 { get; set; }
        //public String IsHoliday4 { get; set; }
        //public String IsHoliday5 { get; set; }
        //public String IsHoliday6 { get; set; }
        //public String IsHoliday7 { get; set; }
        //public String HalfDay1 { get; set; }
        //public String HalfDay2 { get; set; }
        //public String HalfDay3 { get; set; }
        //public String HalfDay4 { get; set; }
        //public String HalfDay5 { get; set; }
        //public String HalfDay6 { get; set; }
        //public String HalfDay7 { get; set; }
        //public DateTime CrevisedDate { get; set; }
        //public String CrevisedBy { get; set; }
        //public Decimal LogNoShip { get; set; }
        //public Decimal LogNoDlry { get; set; }
        //public Decimal LogNoMvmt { get; set; }
        //public Decimal LogNoArOpen { get; set; }
        //public Decimal LogNoApOpen { get; set; }
        //public Decimal LogNoLedg { get; set; }
        //public Decimal InvtCostAvail { get; set; }
        //public Decimal InvtCostLdg { get; set; }
        //public Decimal OnSalesCount { get; set; }
        //public Decimal OnPurchCount { get; set; }
        //public Decimal OnJobCount { get; set; }
        //public Decimal ArInvoAmtBal { get; set; }
        //public Decimal ArOpenAmtBal { get; set; }
        //public Decimal ArNetAmtBal { get; set; }
        //public Decimal ApInvoAmtBal { get; set; }
        //public Decimal ApOpenAmtBal { get; set; }
        //public Decimal ApNetAmtBal { get; set; }
        //public String LogoBmp { get; set; }
        //public String XconnectOn { get; set; }
        //public String UloadPath { get; set; }
        //public Decimal UloadBatchNo { get; set; }
        //public String DloadPath { get; set; }
        //public Decimal DloadBatchNo { get; set; }
        //public Decimal DloadRecnum { get; set; }
        //public String DloadCommand { get; set; }
        //public String UloadCommand { get; set; }
        //public String CompanyCode { get; set; }
        //public String WithBtob { get; set; }
        //public String WithIms { get; set; }
        //public String AcctItmSubcon { get; set; }
        //public String SaleAnlysInt { get; set; }
        //public String PurcAnlysInt { get; set; }
        //public String ProdAnlysInt { get; set; }
        //public String MvmtAnlysInt { get; set; }
        //public String AnlysCat1 { get; set; }
        //public String AnlysCat2 { get; set; }
        //public String AnlysCat3 { get; set; }
        //public String AnlysCat4 { get; set; }
        //public String AnlysInt { get; set; }

        //public String EnableLot { get; set; }
        //public String EnableSerial { get; set; }
        //public Decimal LotNoLength { get; set; }
        //public Decimal SerialNoLength { get; set; }
        //public Decimal NextLotNo { get; set; }
        //public Decimal NextSerialNo { get; set; }
        //public Decimal MaxLotSize { get; set; }
        //public String LotNoPrefix { get; set; }
        //public String SerialNoPrefix { get; set; }
        //public String RecordLock { get; set; }
        //public String UserLog { get; set; }
        //public Decimal ScalePrice { get; set; }
        //public String NegStock { get; set; }

        //public String WithResetLot { get; set; }
        //public String WithResetSerial { get; set; }
        //public DateTime PrevResetLotDate { get; set; }
        //public DateTime PrevResetSerialDate { get; set; }
        //public String AnlysCat5 { get; set; }
        //public String AnlysCat6 { get; set; }
        //public String AnlysCat7 { get; set; }
        //public String AnlysCat8 { get; set; }
        //public String AnlysCat9 { get; set; }
        //public String AnlysCat10 { get; set; }
        //public String CostSheetTabDescription1 { get; set; }
        //public String CostSheetTabDescription2 { get; set; }
        //public String CostSheetTabDescription3 { get; set; }
        //public String CostSheetTabDescription4 { get; set; }
        //public String CostSheetTabDescription5 { get; set; }
        //public String CostSheetTabDescription6 { get; set; }
        //public String CostSheetTabDescription7 { get; set; }
        //public String AcctArTemp { get; set; }
        //public String AcctApTemp { get; set; }
        //public Boolean PlanOrdDefLastPoPrice { get; set; }
        //public String PortalUrl { get; set; }
        //public Decimal KayueNextPoNo { get; set; }
        //public String LotNoUdfLabel01 { get; set; }
        //public String LotNoUdfLabel02 { get; set; }
        //public String LotNoUdfLabel03 { get; set; }
        //public String LotNoUdfLabel04 { get; set; }
        //public String LotNoUdfLabel05 { get; set; }
        //public String BscPoOverBudgetPassword { get; set; }
        //public String AcctArDeposit { get; set; }
        //public String AcctApDeposit { get; set; }
        //public String FtpHost { get; set; }
        //public String FtpUserId { get; set; }
        //public String FtpPassword { get; set; }
        //public String FtpNamePattern { get; set; }
        //public String ImplementUomUppercase { get; set; }
        //public String IntegratedEmailWithMsssageBox { get; set; }
        //public String Cfg { get; set; }

        //public String GlExchComp { get; set; }
        //public String GlRevisedBy { get; set; }
        //public DateTime GlRevisedDate { get; set; }

        //public DateTime PrRevisedDate { get; set; }
        //public String PrRevisedBy { get; set; }

        //public String PupoPtax { get; set; }
        //public String PupoAtax { get; set; }
        //public String PupoGtax { get; set; }
        //public String PupoExtInst { get; set; }
        //public String PupoExtDesc { get; set; }
        //public String PupoFixedUom { get; set; }
        //public DateTime PuRevisedDate { get; set; }
        //public String PuRevisedBy { get; set; }

        //public String VochArAlloc { get; set; }
        //public String VochArInvocan { get; set; }
        //public String VochArPaycan { get; set; }
        //public String VochApInvo { get; set; }
        //public String VochApMemo { get; set; }
        //public String VochApAdj { get; set; }
        //public String VochApPay { get; set; }
        //public String VochApAlloc { get; set; }
        //public String VochApInvocan { get; set; }
        //public String VochApPaycan { get; set; }
        //public String VochIcIssue { get; set; }
        //public String VochIcRcpt { get; set; }
        //public String VochIcAdj { get; set; }
        //public String VochPrIssue { get; set; }
        //public String VochPrReturn { get; set; }
        //public String VochPrProd { get; set; }
        //public String VochPrSubcon { get; set; }
        //public String VochPayroll { get; set; }
        //public String VochCommission { get; set; }
        //public String VochFaAcquire { get; set; }
        //public String VochFaDeprec { get; set; }
        //public String VochFaMaint { get; set; }
        //public String VochFaDispo { get; set; }

        //public Decimal ArBcountInvo { get; set; }
        //public Decimal ArBcountMemo { get; set; }
        //public Decimal ArBcountAdj { get; set; }
        //public Decimal ArBcountPay { get; set; }
        //public Decimal ArBcountAlloc { get; set; }
        //public Decimal ApBcountInvo { get; set; }
        //public Decimal ApBcountMemo { get; set; }
        //public Decimal ApBcountAdj { get; set; }
        //public Decimal ApBcountPay { get; set; }
        //public Decimal ApBcountAlloc { get; set; }

        //public String CostInit { get; set; }
        //public String CostBasis { get; set; }
        //public Decimal CostRmPrMul { get; set; }
        //public Decimal CostLbPrMul { get; set; }
        //public Decimal CostOvPrMul { get; set; }
        //public Decimal CostRmSlMul { get; set; }
        //public Decimal CostLbSlMul { get; set; }
        //public Decimal CostOvSlMul { get; set; }
        //public String CostRevisedBy { get; set; }
        //public DateTime CostRevDate { get; set; }
        //public String PrCostVerify { get; set; }
        //public String PrCostEdit { get; set; }

        //public String CommisType { get; set; }
        //public String SlsoCustItem { get; set; }
        //public String SlsoPkgType { get; set; }
        //public String IcAutoShip { get; set; }
        //public String IcAutoSlret { get; set; }
        //public String IcAutoGrn { get; set; }
        //public String IcAutoQc { get; set; }
        //public String IcAutoPuret { get; set; }
        //public String IcAutoWorkc { get; set; }
        //public String ApOvrideRate { get; set; }
        //public String SlsoSchEntry { get; set; }
        //public String PupoSchEntry { get; set; }
        //public String SlsoContact { get; set; }
        //public String SlsoOrdrPack { get; set; }
        //public Decimal MaxUsers { get; set; }
        //public String MmuKey { get; set; }

        //public String AcctAnlys1 { get; set; }
        //public String AcctAnlys2 { get; set; }
        //public String AcctAnlys3 { get; set; }
        //public String AcctAnlys4 { get; set; }
        //public String VochAnlys1 { get; set; }
        //public String VochAnlys2 { get; set; }
        //public String VochAnlys3 { get; set; }
        //public String VochAnlys4 { get; set; }
        //public String VochAnlys5 { get; set; }
        //public String VochAnlys6 { get; set; }
        //public String ItemAnlys1 { get; set; }
        //public String ItemAnlys2 { get; set; }
        //public String ItemAnlys3 { get; set; }
        //public String ItemAnlys4 { get; set; }
        //public String CustAnlys1 { get; set; }
        //public String CustAnlys2 { get; set; }
        //public String CustAnlys3 { get; set; }
        //public String CustAnlys4 { get; set; }
        //public String VendAnlys1 { get; set; }
        //public String VendAnlys2 { get; set; }
        //public String VendAnlys3 { get; set; }
        //public String VendAnlys4 { get; set; }
        //public String SaleAnlys1 { get; set; }
        //public String SaleAnlys2 { get; set; }
        //public String SaleAnlys3 { get; set; }
        //public String SaleAnlys4 { get; set; }
        //public String SaleAnlys5 { get; set; }
        //public String SaleAnlys6 { get; set; }
        //public String PurcAnlys1 { get; set; }
        //public String PurcAnlys2 { get; set; }
        //public String PurcAnlys3 { get; set; }
        //public String PurcAnlys4 { get; set; }
        //public String PurcAnlys5 { get; set; }
        //public String PurcAnlys6 { get; set; }
        //public String MvmtAnlys1 { get; set; }
        //public String MvmtAnlys2 { get; set; }
        //public String MvmtAnlys3 { get; set; }
        //public String MvmtAnlys4 { get; set; }
        //public String MvmtAnlys5 { get; set; }
        //public String MvmtAnlys6 { get; set; }
        //public DateTime NrevisedDate { get; set; }
        //public String NrevisedBy { get; set; }
        //public String ShipWtUom { get; set; }
        //public String ShipDimUom { get; set; }
        //public String ItemPacking { get; set; }
        //public String NoOvhdAcctg { get; set; }
        //public String NoVariaAcctg { get; set; }
        //public String NoFgAcctg { get; set; }
        //public String FgCostLimit { get; set; }
        //public String AllowDescChg { get; set; }
        //public String NoLaborAcctg { get; set; }
        //public String NoSubconAcctg { get; set; }
        //public String ReorderIsNew { get; set; }
        //public String DefInspStd { get; set; }
        //public String DefInspLvl { get; set; }
        //public String DefAqlLvlMaj { get; set; }
        //public String DefAqlLvlMin { get; set; }
        //public String ReturnEmail { get; set; }
        //public String SmtpServer { get; set; }
        //public String WebSetting1 { get; set; }
        //public String WebSetting2 { get; set; }
        //public String WebSetting3 { get; set; }
        //public String WebSetting4 { get; set; }
        //public String PupoPriceCtrl { get; set; }
        //public String JordAnlys1 { get; set; }
        //public String JordAnlys2 { get; set; }
        //public String JordAnlys3 { get; set; }
        //public String JordAnlys4 { get; set; }
        //public String JordAnlys5 { get; set; }
        //public String JordAnlys6 { get; set; }
        //public String ProdPosEntry { get; set; }
        //public String GlarText1 { get; set; }
        //public String GlarText2 { get; set; }
        //public String GlarText3 { get; set; }
        //public String GlarText4 { get; set; }
        //public String PrJobClose { get; set; }
        //public String SlsoUnfullPackResponse { get; set; }
        //public String SlsoDefMultiShip { get; set; }
        //public String SlsoDefAutoPo { get; set; }
        //public String SlsoDefAutoJo { get; set; }
        //public String SlpaExtDesc { get; set; }
        //public Decimal PupoDueLead { get; set; }
        //public Decimal PupoSchLead { get; set; }
        //public String PrMultiIssue { get; set; }
        //public String ProdSepRoute { get; set; }
        //public String ProdHideWcSubcon { get; set; }
        //public String CopyTextFromSo { get; set; }
       
        //public String PrpmExtInst { get; set; }
        //public Int32 BomVerLen { get; set; }
        //public String ProdPoPrice { get; set; }
        //public String SaleAnlys7 { get; set; }
        //public String SaleAnlys8 { get; set; }
        //public String PurcAnlys7 { get; set; }
        //public String PurcAnlys8 { get; set; }
        //public String MvmtAnlys7 { get; set; }
        //public String MvmtAnlys8 { get; set; }
        //public String VochAnlys7 { get; set; }
        //public String VochAnlys8 { get; set; }
        //public String JordAnlys7 { get; set; }
        //public String JordAnlys8 { get; set; }
        //public String ArAnlys1 { get; set; }
        //public String ArAnlys2 { get; set; }
        //public String ArAnlys3 { get; set; }
        //public String ArAnlys4 { get; set; }
        //public String ArAnlys5 { get; set; }
        //public String ArAnlys6 { get; set; }
        //public String ArAnlys7 { get; set; }
        //public String ArAnlys8 { get; set; }
        //public String ApAnlys1 { get; set; }
        //public String ApAnlys2 { get; set; }
        //public String ApAnlys3 { get; set; }
        //public String ApAnlys4 { get; set; }
        //public String ApAnlys5 { get; set; }
        //public String ApAnlys6 { get; set; }
        //public String ApAnlys7 { get; set; }
        //public String ApAnlys8 { get; set; }
        //public String SlAddInfo { get; set; }
        //public String PuAddInfo { get; set; }
        //public String PrAddInfo { get; set; }
        //public String IcAddInfo { get; set; }
        //public String ChkMatIss { get; set; }
        //public String IcDefStdCost { get; set; }
        //public String CheckCustpo { get; set; }
        //public String CtlFgRtn { get; set; }
        //public String VochArRefund { get; set; }
        //public String VochApRefund { get; set; }
        //public String SlsoDn { get; set; }
        //public Decimal AutoIncBy { get; set; }
        //public String QuoGenMultiSo { get; set; }
        //public String PuReceiveAll { get; set; }
        //public String PrpmItemMasterScrap { get; set; }
        //public String IcDisableCommit { get; set; }
        //public String ProdDefMatRemarks { get; set; }
        //public String SlsoUpdateQtyFromSch { get; set; }
        //public String PupoUpdateQtyFromSch { get; set; }
        //public String SlsoDefaultBasePrice { get; set; }
        //public String SlsoDiscountByCustomer { get; set; }
        //public String PrpmMaxQtyInStorage { get; set; }
        //public String IcDefCostType { get; set; }
        //public String ProdBomCreateItem { get; set; }
        //public String PupoRtvLoc { get; set; }
        //public String PrpmUseAllMatLastWc { get; set; }
        //public String IcNoDefCharge { get; set; }
        //public String ProdDefPhantomBom { get; set; }
        //public String SlsoNeedCmApproval { get; set; }
        //public String PupoNeedVmApproval { get; set; }
        //public String ProdNeedBomApproval { get; set; }
        //public String ProdNeedImApproval { get; set; }
        //public String PrpmNeedScrapReason { get; set; }
        //public String PrpmMustBackflush { get; set; }
        //public String PupoAutoOrderLink { get; set; }
        //public String PrpmAutoOrderLink { get; set; }
        //public String PrpeAllowChgJob { get; set; }
        //public String VochPrInspect { get; set; }
        //public String VochPrRework { get; set; }
        //public String ProdNeedPlanRlseApproval { get; set; }
        //public String PrpmIncludeScrapInMmi { get; set; }
        //public String ProdScrapLoc { get; set; }
        //public String MvtPrScrap { get; set; }
        //public String SlNeedClApproval { get; set; }
        //public String WarnOnMatConsum { get; set; }
        //public String IcimAutogenLot { get; set; }
        //public String IcimAutogenSerial { get; set; }

        //public String ItemAnlys5 { get; set; }
        //public String ItemAnlys6 { get; set; }
        //public String ItemAnlys7 { get; set; }
        //public String ItemAnlys8 { get; set; }
        //public String ItemAnlys9 { get; set; }
        //public String ItemAnlys10 { get; set; }
        //public String CustAnlys5 { get; set; }
        //public String CustAnlys6 { get; set; }
        //public String CustAnlys7 { get; set; }
        //public String CustAnlys8 { get; set; }
        //public String CustAnlys9 { get; set; }
        //public String CustAnlys10 { get; set; }
        //public String VendAnlys5 { get; set; }
        //public String VendAnlys6 { get; set; }
        //public String VendAnlys7 { get; set; }
        //public String VendAnlys8 { get; set; }
        //public String VendAnlys9 { get; set; }
        //public String VendAnlys10 { get; set; }
        //public String AcctAnlys5 { get; set; }
        //public String AcctAnlys6 { get; set; }
        //public String AcctAnlys7 { get; set; }
        //public String AcctAnlys8 { get; set; }
        //public String AcctAnlys9 { get; set; }
        //public String AcctAnlys10 { get; set; }
        //public String SaleAnlys9 { get; set; }
        //public String SaleAnlys10 { get; set; }
        //public String SaleAnlys11 { get; set; }
        //public String SaleAnlys12 { get; set; }
        //public String SaleAnlys13 { get; set; }
        //public String SaleAnlys14 { get; set; }
        //public String SaleAnlys15 { get; set; }
        //public String SaleAnlys16 { get; set; }
        //public String SaleAnlys17 { get; set; }
        //public String SaleAnlys18 { get; set; }
        //public String SaleAnlys19 { get; set; }
        //public String SaleAnlys20 { get; set; }
        //public String PurcAnlys9 { get; set; }
        //public String PurcAnlys10 { get; set; }
        //public String PurcAnlys11 { get; set; }
        //public String PurcAnlys12 { get; set; }
        //public String PurcAnlys13 { get; set; }
        //public String PurcAnlys14 { get; set; }
        //public String PurcAnlys15 { get; set; }
        //public String PurcAnlys16 { get; set; }
        //public String PurcAnlys17 { get; set; }
        //public String PurcAnlys18 { get; set; }
        //public String PurcAnlys19 { get; set; }
        //public String PurcAnlys20 { get; set; }
        //public String MvmtAnlys9 { get; set; }
        //public String MvmtAnlys10 { get; set; }
        //public String MvmtAnlys11 { get; set; }
        //public String MvmtAnlys12 { get; set; }
        //public String MvmtAnlys13 { get; set; }
        //public String MvmtAnlys14 { get; set; }
        //public String MvmtAnlys15 { get; set; }
        //public String MvmtAnlys16 { get; set; }
        //public String MvmtAnlys17 { get; set; }
        //public String MvmtAnlys18 { get; set; }
        //public String MvmtAnlys19 { get; set; }
        //public String MvmtAnlys20 { get; set; }
        //public String VochAnlys9 { get; set; }
        //public String VochAnlys10 { get; set; }
        //public String VochAnlys11 { get; set; }
        //public String VochAnlys12 { get; set; }
        //public String VochAnlys13 { get; set; }
        //public String VochAnlys14 { get; set; }
        //public String VochAnlys15 { get; set; }
        //public String VochAnlys16 { get; set; }
        //public String VochAnlys17 { get; set; }
        //public String VochAnlys18 { get; set; }
        //public String VochAnlys19 { get; set; }
        //public String VochAnlys20 { get; set; }
        //public String JordAnlys9 { get; set; }
        //public String JordAnlys10 { get; set; }
        //public String JordAnlys11 { get; set; }
        //public String JordAnlys12 { get; set; }
        //public String JordAnlys13 { get; set; }
        //public String JordAnlys14 { get; set; }
        //public String JordAnlys15 { get; set; }
        //public String JordAnlys16 { get; set; }
        //public String JordAnlys17 { get; set; }
        //public String JordAnlys18 { get; set; }
        //public String JordAnlys19 { get; set; }
        //public String JordAnlys20 { get; set; }
        //public String ArAnlys9 { get; set; }
        //public String ArAnlys10 { get; set; }
        //public String ArAnlys11 { get; set; }
        //public String ArAnlys12 { get; set; }
        //public String ArAnlys13 { get; set; }
        //public String ArAnlys14 { get; set; }
        //public String ArAnlys15 { get; set; }
        //public String ArAnlys16 { get; set; }
        //public String ArAnlys17 { get; set; }
        //public String ArAnlys18 { get; set; }
        //public String ArAnlys19 { get; set; }
        //public String ArAnlys20 { get; set; }
        //public String ApAnlys9 { get; set; }
        //public String ApAnlys10 { get; set; }
        //public String ApAnlys11 { get; set; }
        //public String ApAnlys12 { get; set; }
        //public String ApAnlys13 { get; set; }
        //public String ApAnlys14 { get; set; }
        //public String ApAnlys15 { get; set; }
        //public String ApAnlys16 { get; set; }
        //public String ApAnlys17 { get; set; }
        //public String ApAnlys18 { get; set; }
        //public String ApAnlys19 { get; set; }
        //public String ApAnlys20 { get; set; }

        //public Boolean PrpeMoldAuditTrail { get; set; }
        //public Boolean IcimIssueByAvailableQty { get; set; }
        //public Boolean PrpmJamendIssueControl { get; set; }
        //public Boolean PrAutoMultiSpareIssue { get; set; }
        //public Boolean SlShipmentPriceControl { get; set; }
        //public Boolean ArMultiSettle { get; set; }
        //public Boolean PupoDefMultiship { get; set; }
        //public Boolean PupoDefReorder { get; set; }
        //public Boolean SlsoDefReorder { get; set; }
        //public Boolean VochByVdate { get; set; }
        //public Boolean PupoTaxTerms { get; set; }
        //public String SampleAcct { get; set; }
        //public Boolean CtlFgRtnTotQty { get; set; }
        //public Boolean AllowMultiWc { get; set; }
        //public Boolean PoaIgnoreMinQty { get; set; }
        //public Boolean GrnMatCost { get; set; }
        //public Boolean GrnLotNoImport { get; set; }
        //public Boolean IssueMaterialsByRouting { get; set; }
        //public Boolean ConsumeMatInLastRouting { get; set; }
        //public String DefAqlLvlCritical { get; set; }
        //public String DefInspLvlSp { get; set; }
        //public String DefAqlLvlCriticalSp { get; set; }
        //public String DefAqlLvlMajSp { get; set; }
        //public String DefAqlLvlMinSp { get; set; }
        //public Boolean WcAutoMatReturn { get; set; }
        //public Boolean ArInvMultiPayTerms { get; set; }
        //public Decimal IcAdjCodeAPcent { get; set; }
        //public Decimal IcAdjCodeBPcent { get; set; }
        //public Decimal IcAdjCodeCPcent { get; set; }
        //public Boolean TailorIncludeJob { get; set; }
        //public Boolean JoMultiSource { get; set; }
        //public Boolean ShowShipmentInfoInPacking { get; set; }
        //public Boolean MrpWithReorderPt { get; set; }
        //public Boolean AllowFollowListWithoutMi { get; set; }
        //public Boolean PrMultiFollowList { get; set; }
        //public Boolean SqietkMatBalSubtractCommit { get; set; }
        //public Decimal SoLineAutoIncBy { get; set; }
        //public Decimal PoLineAutoIncBy { get; set; }
        //public Boolean PuOverRcptByLine { get; set; }
        //public Boolean PuLmeCost { get; set; }
        //public Boolean SoaUpdatePendingShipment { get; set; }
        //public Decimal PrMatIssueOnAvailPercent { get; set; }
        //public Decimal JobHourlyRate { get; set; }
        //public Boolean ItemCustomProdCodeRequired { get; set; }
        //public Boolean IcimAutogenLotIssue { get; set; }
        //public Boolean IcimAutogenSerialIssue { get; set; }
        //public Boolean ShipmentInfoFromFirstOrder { get; set; }
        //public Boolean MrpExcludeLeadtime { get; set; }
        //public Boolean ItemPrelotSopo { get; set; }
        //public Boolean SlsoCtrlBtmCeil { get; set; }
        //public Boolean WcOverAcceptedLot { get; set; }
        //public Boolean SlsoAutoResv { get; set; }
        //public Decimal PercentA { get; set; }
        //public Decimal PercentB { get; set; }
        //public Decimal PercentC { get; set; }
        //public String EntryPostedRequirdBeforePrint { get; set; }
    }
}