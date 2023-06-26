﻿#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  ItemColumns.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.MasterData.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("MasterData.Item")]
    [BasedOnRow(typeof(Entities.ItemRow))]
    public class ItemColumns
    {
        //[EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        //public Decimal Recnum { get; set; }
        [EditLink]
        public String ItemNo { get; set; }
        public String Description { get; set; }
        public String ItemGroup { get; set; }
        public bool Suspended { get; set; }
        //public String ItemGroupDescription { get; set; }
        //public String Charges { get; set; }
        public bool Product { get; set; }
        public bool Material { get; set; }
        //public String Inspected { get; set; }
        public String ItemType { get; set; }
        public String StockUom { get; set; }
        //public String MainLoc { get; set; }
        //public String MakeBuy { get; set; }
        public String AllocMethod { get; set; }
        //public String StdCostOk { get; set; }
        //public String CostCentre { get; set; }
        //public String CycleCode { get; set; }
        //public String Anlys1 { get; set; }
        //public String Anlys2 { get; set; }
        //public String Anlys3 { get; set; }
        //public String Anlys4 { get; set; }
        //public String DefSpecNo { get; set; }
        //public Decimal DefSpecCount { get; set; }
        //public DateTime CreatedDate { get; set; }
        //public String CreatedBy { get; set; }
        //public DateTime RevisedDate { get; set; }
        //public String RevisedBy { get; set; }
        //public String WithBacklog { get; set; }
        //public String WithBalance { get; set; }
        //public Decimal QtyOnHand { get; set; }
        //public Decimal QtyOnSorder { get; set; }
        //public Decimal QtyOnPorder { get; set; }
        //public Decimal QtyOnJorder { get; set; }
        //public Decimal QtyOnInspect { get; set; }
        //public Decimal QtyWaitlisted { get; set; }
        //public Decimal QtyReserved { get; set; }
        //public Decimal QtyCommitted { get; set; }
        //public Decimal QtyAvailable { get; set; }
        //public Decimal QtyUnallocated { get; set; }
        //public Decimal InvtCostAvail { get; set; }
        //public Decimal InvtCostLdg { get; set; }
        [AlignRight]
        public String AverageCost { get; set; }
        [AlignRight]
        public Decimal LatestCost { get; set; }
        [AlignRight]
        public Decimal StdCost { get; set; }
       // public DateTime LastCountDate { get; set; }
        //public DateTime LastDateIn { get; set; }
        //public DateTime LastDateOut { get; set; }
        //public String SalesUom { get; set; }
        //public Decimal SalesLotSize { get; set; }
        //public String PriceCcy { get; set; }
        //public Decimal BasePrice { get; set; }
        //public Decimal Pricea { get; set; }
        //public Decimal Priceb { get; set; }
        //public Decimal Pricec { get; set; }
        //public Decimal MinPrice { get; set; }
        //public Decimal MaxPrice { get; set; }
        //public Decimal MinOrderQty { get; set; }
        //public Decimal MaxOrderQty { get; set; }
        //public Decimal MinOrderDays { get; set; }
        //public String InnerPkgType { get; set; }
        //public Decimal InnerQty { get; set; }
        //public String OuterPkgType { get; set; }
        //public Decimal OuterQty { get; set; }
        //public String ArticleCode { get; set; }
        //public String QuotaCategory { get; set; }
        //public String WeightUom { get; set; }
        //public Decimal GrossWt { get; set; }
        //public Decimal NetWt { get; set; }
        //public String DimensionUom { get; set; }
        //public Decimal Flength { get; set; }
        //public Decimal Width { get; set; }
        //public Decimal Height { get; set; }
        //public Decimal ComputedVol { get; set; }
        //public Decimal DeclaredVol { get; set; }
        //public DateTime SrevisedDate { get; set; }
        //public String SrevisedBy { get; set; }
        //public String MpsItem { get; set; }
        //public String OrderPolicy { get; set; }
        //public Decimal MinPlanordQty { get; set; }
        //public Decimal MaxPlanordQty { get; set; }
        //public Decimal StdPlanordQty { get; set; }
        //public Decimal MinPlanordPrd { get; set; }
        //public Decimal MaxPlanordPrd { get; set; }
        //public Decimal StdPlanordPrd { get; set; }
        //public Decimal ReorderPt { get; set; }
        //public Decimal ReorderQty { get; set; }
        //public Decimal MinMthlyProd { get; set; }
        //public Decimal MaxMthlyProd { get; set; }
        //public Decimal MinMthlyPur { get; set; }
        //public Decimal MaxMthlyPur { get; set; }
        //public String FollowMinProd { get; set; }
        //public String FollowMaxProd { get; set; }
        //public String FollowMinPur { get; set; }
        //public String FollowMaxPur { get; set; }
        //public String AllowMixMode { get; set; }
        //public String PrefVendOnly { get; set; }
        //public String PrefVend1 { get; set; }
        //public String PrefVend2 { get; set; }
        //public Decimal ProdLeadTime { get; set; }
        //public String ProdLeadUnit { get; set; }
        //public Decimal PurLeadTime { get; set; }
        //public String PurLeadUnit { get; set; }
        //public String Planner { get; set; }
        //public DateTime MrpParmDate { get; set; }
        //public String MrpParmBy { get; set; }
        //public String AltDescription { get; set; }
        //public String PictureFile { get; set; }
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
        //public String AcctMachine { get; set; }
        //public String AcctEnergy { get; set; }
        //public String AcctWater { get; set; }
        //public String AcctRental { get; set; }
        //public String AcctLabor { get; set; }
        //public String AcctInlab { get; set; }
        //public String AcctInmat { get; set; }
        //public String AcctMisc { get; set; }
        //public DateTime ArevisedDate { get; set; }
        //public String ArevisedBy { get; set; }
        //public DateTime BrevisedDate { get; set; }
        //public String BrevisedBy { get; set; }
        //public String SalesLtaxCode { get; set; }
        //public String PurchLtaxCode { get; set; }
        //public DateTime TrevisedDate { get; set; }
        //public String TrevisedBy { get; set; }
        //public Decimal SpecsCount { get; set; }
        //public String DefBomNo { get; set; }
        //public Decimal LastSnapNo { get; set; }
        //public String CommisType { get; set; }
        //public String ProdBranch { get; set; }
        //public String OwnerBranch { get; set; }
        //public String SourceBranch { get; set; }
        //public Decimal ScrapRate { get; set; }
        //public String AltExtDesc { get; set; }
        //public String ExtendedDesc { get; set; }
        //public String PurPriceCtrl { get; set; }
        //public Decimal PurMaxDev { get; set; }
        //public String WebItem { get; set; }
        //public String AcctItmSubcon { get; set; }
        //public String WithBinCtrl { get; set; }
        //public String Consign { get; set; }
        //public String ProdDevt01 { get; set; }
        //public String ProdDevt02 { get; set; }
        //public String ProdDevt03 { get; set; }
        //public String ProdDevt04 { get; set; }
        //public String ProdDevt05 { get; set; }
        //public String ProdDevt06 { get; set; }
        //public String ProdDevt07 { get; set; }
        //public String ProdDevt08 { get; set; }
        //public String ProdDevt09 { get; set; }
        //public String ProdDevt10 { get; set; }
        //public String ProdDevt11 { get; set; }
        //public String ProdDevt12 { get; set; }
        //public String ProdDevt13 { get; set; }
        //public String ProdDevt14 { get; set; }
        //public String ProdDevt15 { get; set; }
        //public String ProdDevt16 { get; set; }
        //public String ProdDevt17 { get; set; }
        //public String ProdDevt18 { get; set; }
        //public String ProdDevt19 { get; set; }
        //public String ProdDevt20 { get; set; }
        //public String ProdCheck01 { get; set; }
        //public String ProdCheck02 { get; set; }
        //public String ProdCheck03 { get; set; }
        //public String ProdCheck04 { get; set; }
        //public String ProdCheck05 { get; set; }
        //public String ProdCheck06 { get; set; }
        //public String ProdCheck07 { get; set; }
        //public String ProdCheck08 { get; set; }
        //public String ProdCheck09 { get; set; }
        //public String ProdCheck10 { get; set; }
        //public String ProdCheck11 { get; set; }
        //public String ProdCheck12 { get; set; }
        //public String ProdCheck13 { get; set; }
        //public String ProdCheck14 { get; set; }
        //public String ProdCheck15 { get; set; }
        //public String ProdCheck16 { get; set; }
        //public String ProdCheck17 { get; set; }
        //public String ProdCheck18 { get; set; }
        //public String ProdCheck19 { get; set; }
        //public String ProdCheck20 { get; set; }
        //public Decimal LastPackLineNo { get; set; }
        //public Decimal PutaxPcent { get; set; }
        //public String AcctItmSltax { get; set; }
        //public Decimal SltaxPcent { get; set; }
        //public String PurUom { get; set; }
        //public Decimal PurLotSize { get; set; }
        //public String PurCcy { get; set; }
        //public Decimal PurBasePrice { get; set; }
        //public Decimal QtyNetAvailable { get; set; }
        //public String UseStdProdLeadTime { get; set; }
        //public Decimal DailyProdQty { get; set; }
        //public Decimal IssueLotSize { get; set; }
        //public String MrpExclude { get; set; }
        //public String EnableLot { get; set; }
        //public String EnableSerial { get; set; }
        //public Decimal LotNoLength { get; set; }
        //public Decimal SerialNoLength { get; set; }
        //public Decimal NextLotNo { get; set; }
        //public Decimal NextSerialNo { get; set; }
        //public Decimal MaxLotSize { get; set; }
        //public String LotNoPrefix { get; set; }
        //public String SerialNoPrefix { get; set; }
        //public Decimal SafeStockLvl { get; set; }
        //public String MainBin { get; set; }
        //public String CustomProdCode { get; set; }
        //public Decimal CustomLotSize { get; set; }
        //public String CustomGrUom { get; set; }
        //public Decimal CustomGrWt { get; set; }
        //public Decimal CustomNtWt { get; set; }
        //public String CustomOrigin { get; set; }
        //public String IsApproved { get; set; }
        //public String ApprovedBy { get; set; }
        //public String Preapprove { get; set; }
        //public DateTime ApprovedDate { get; set; }
        //public Decimal QtyOnTransfer { get; set; }
        //public String WithResetLot { get; set; }
        //public String WithResetSerial { get; set; }
        //public DateTime PrevResetLotDate { get; set; }
        //public DateTime PrevResetSerialDate { get; set; }
        //public String AutogenLot { get; set; }
        //public String AutogenSerial { get; set; }
        //public String FabItem { get; set; }
        //public String Anlys5 { get; set; }
        //public String Anlys6 { get; set; }
        //public String Anlys7 { get; set; }
        //public String Anlys8 { get; set; }
        //public String Anlys9 { get; set; }
        //public String Anlys10 { get; set; }
        //public String UserDefinedField1 { get; set; }
        //public String UserDefinedField2 { get; set; }
        //public String UserDefinedField3 { get; set; }
        //public String UserDefinedField4 { get; set; }
        //public String UserDefinedField5 { get; set; }
        //public String UserDefinedField6 { get; set; }
        //public String UserDefinedField7 { get; set; }
        //public String UserDefinedField8 { get; set; }
        //public String UserDefinedField9 { get; set; }
        //public String UserDefinedField10 { get; set; }
        //public String UserDefinedField11 { get; set; }
        //public String UserDefinedField12 { get; set; }
        //public String UserDefinedField13 { get; set; }
        //public String UserDefinedField14 { get; set; }
        //public String UserDefinedField15 { get; set; }
        //public String UserDefinedField16 { get; set; }
        //public String UserDefinedField17 { get; set; }
        //public String UserDefinedField18 { get; set; }
        //public String UserDefinedField19 { get; set; }
        //public String UserDefinedField20 { get; set; }
        //public Boolean RohsCompliance { get; set; }
        //public String DefMoldBomNo { get; set; }
        //public String DefFormulaCode { get; set; }
        //public String BoxType { get; set; }
        //public Decimal BoxLength { get; set; }
        //public Decimal BoxWidth { get; set; }
        //public Decimal BoxHeight { get; set; }
        //public String BoxDUom { get; set; }
        //public Decimal Wd { get; set; }
        //public String WdUom { get; set; }
        //public Decimal CsLength { get; set; }
        //public Decimal CsWidth { get; set; }
        //public String UserDefinedField21 { get; set; }
        //public Decimal CostWmove { get; set; }
        //public Decimal CostWcase { get; set; }
        //public Decimal CostWband { get; set; }
        //public Decimal CostBatt { get; set; }
        //public String DescWmove { get; set; }
        //public String DescWcase { get; set; }
        //public String DescWband { get; set; }
        //public String DescBatt { get; set; }
        //public Decimal PoBal { get; set; }
        //public Decimal PoMaxBal { get; set; }
        //public Boolean IncludeJob { get; set; }
        //public Decimal CsThickness { get; set; }
        //public String CsThicknessUom { get; set; }
        //public Decimal CsProportion { get; set; }
        //public String CsProportionUom { get; set; }
        //public Decimal DieCutter { get; set; }
        //public Decimal MatInspectLeadTime { get; set; }
        //public Decimal MatPrepareLeadTime { get; set; }
        //public String MatInspectLeadUnit { get; set; }
        //public String MatPrepareLeadUnit { get; set; }
        //public String ColorCode { get; set; }
        //public String CollectionCode { get; set; }
        //public String StyleCode { get; set; }
        //public Decimal X { get; set; }
        //public Decimal Y { get; set; }
        //public String TempDescription { get; set; }
        //public String Specification { get; set; }
        //public String XUom { get; set; }
        //public String YUom { get; set; }
        //public Decimal ProductionUomConversionRate { get; set; }
        //public Decimal PurchaseUomConversionRate { get; set; }
        //public Boolean AutogenLotIssue { get; set; }
        //public Boolean AutogenSerialIssue { get; set; }
        //public String WcCostCcy { get; set; }
        //public Decimal WcCost { get; set; }
        //public Decimal WcCostDisc { get; set; }
        //public Decimal WcCostExch { get; set; }
        //public Decimal WcFreight { get; set; }
        //public Decimal WcMargin { get; set; }
        //public Decimal CeilingPrice { get; set; }
        //public Decimal BottomRatio { get; set; }
        //public Decimal BottomPrice { get; set; }
        //public String DrawingNo { get; set; }
        //public String MaterialType { get; set; }
    }
}