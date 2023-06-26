namespace Matrix.MasterData {
    export class ItemForm extends Serenity.PrefixedContext {
        static formKey = 'MasterData.Item';

    }

    export interface ItemForm {
        ItemNo: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        ItemGroup: Serenity.StringEditor;
        StockUom: Serenity.StringEditor;
        Suspended: Serenity.BooleanEditor;
        Product: Serenity.BooleanEditor;
        Material: Serenity.BooleanEditor;
        MakeBuy: Serenity.BooleanEditor;
        ItemType: Serenity.StringEditor;
        AllocMethod: Serenity.StringEditor;
        MainLoc: Serenity.StringEditor;
        MainBin: Serenity.StringEditor;
        CycleCode: Serenity.StringEditor;
        DefBomNo: Serenity.StringEditor;
        DefSpecNo: Serenity.StringEditor;
        ScrapRate: Serenity.DecimalEditor;
        AverageCost: Serenity.StringEditor;
        LatestCost: Serenity.DecimalEditor;
        StdCost: Serenity.DecimalEditor;
        AltDescription: Serenity.StringEditor;
        AltExtDesc: Serenity.StringEditor;
        PrefVendOnly: Serenity.StringEditor;
        PrefVend1: Serenity.StringEditor;
        PrefVend2: Serenity.StringEditor;
        Charges: Serenity.StringEditor;
        Inspected: Serenity.StringEditor;
        SalesUom: Serenity.StringEditor;
        StdCostOk: Serenity.StringEditor;
        CostCentre: Serenity.StringEditor;
        DefSpecCount: Serenity.DecimalEditor;
        WithBacklog: Serenity.StringEditor;
        WithBalance: Serenity.StringEditor;
        QtyOnHand: Serenity.DecimalEditor;
        QtyOnSorder: Serenity.DecimalEditor;
        QtyOnPorder: Serenity.DecimalEditor;
        QtyOnJorder: Serenity.DecimalEditor;
        QtyOnInspect: Serenity.DecimalEditor;
        QtyWaitlisted: Serenity.DecimalEditor;
        QtyReserved: Serenity.DecimalEditor;
        QtyCommitted: Serenity.DecimalEditor;
        QtyAvailable: Serenity.DecimalEditor;
        QtyUnallocated: Serenity.DecimalEditor;
        InvtCostAvail: Serenity.DecimalEditor;
        InvtCostLdg: Serenity.DecimalEditor;
        PriceCcy: Serenity.StringEditor;
        BasePrice: Serenity.DecimalEditor;
        Pricea: Serenity.DecimalEditor;
        Priceb: Serenity.DecimalEditor;
        Pricec: Serenity.DecimalEditor;
        MinPrice: Serenity.DecimalEditor;
        MaxPrice: Serenity.DecimalEditor;
        LastCountDate: Serenity.DateEditor;
        LastDateIn: Serenity.DateEditor;
        LastDateOut: Serenity.DateEditor;
        SalesLotSize: Serenity.DecimalEditor;
        MinOrderQty: Serenity.DecimalEditor;
        MaxOrderQty: Serenity.DecimalEditor;
        MinOrderDays: Serenity.DecimalEditor;
        InnerPkgType: Serenity.StringEditor;
        InnerQty: Serenity.DecimalEditor;
        OuterPkgType: Serenity.StringEditor;
        OuterQty: Serenity.DecimalEditor;
        ArticleCode: Serenity.StringEditor;
        QuotaCategory: Serenity.StringEditor;
        WeightUom: Serenity.StringEditor;
        GrossWt: Serenity.DecimalEditor;
        NetWt: Serenity.DecimalEditor;
        DimensionUom: Serenity.StringEditor;
        Flength: Serenity.DecimalEditor;
        Width: Serenity.DecimalEditor;
        Height: Serenity.DecimalEditor;
        ComputedVol: Serenity.DecimalEditor;
        DeclaredVol: Serenity.DecimalEditor;
        MpsItem: Serenity.StringEditor;
        OrderPolicy: Serenity.StringEditor;
        MinPlanordQty: Serenity.DecimalEditor;
        MaxPlanordQty: Serenity.DecimalEditor;
        StdPlanordQty: Serenity.DecimalEditor;
        MinPlanordPrd: Serenity.DecimalEditor;
        MaxPlanordPrd: Serenity.DecimalEditor;
        StdPlanordPrd: Serenity.DecimalEditor;
        ReorderPt: Serenity.DecimalEditor;
        ReorderQty: Serenity.DecimalEditor;
        MinMthlyProd: Serenity.DecimalEditor;
        MaxMthlyProd: Serenity.DecimalEditor;
        MinMthlyPur: Serenity.DecimalEditor;
        MaxMthlyPur: Serenity.DecimalEditor;
        FollowMinProd: Serenity.StringEditor;
        FollowMaxProd: Serenity.StringEditor;
        FollowMinPur: Serenity.StringEditor;
        FollowMaxPur: Serenity.StringEditor;
        AllowMixMode: Serenity.StringEditor;
        ProdLeadTime: Serenity.DecimalEditor;
        ProdLeadUnit: Serenity.StringEditor;
        PurLeadTime: Serenity.DecimalEditor;
        PurLeadUnit: Serenity.StringEditor;
        Planner: Serenity.StringEditor;
        MrpParmDate: Serenity.DateEditor;
        MrpParmBy: Serenity.StringEditor;
        PictureFile: Serenity.StringEditor;
        SalesLtaxCode: Serenity.StringEditor;
        PurchLtaxCode: Serenity.StringEditor;
        TrevisedDate: Serenity.DateEditor;
        TrevisedBy: Serenity.StringEditor;
        SpecsCount: Serenity.DecimalEditor;
        LastSnapNo: Serenity.DecimalEditor;
        CommisType: Serenity.StringEditor;
        ProdBranch: Serenity.StringEditor;
        ExtendedDesc: Serenity.StringEditor;
        PurPriceCtrl: Serenity.StringEditor;
        PurMaxDev: Serenity.DecimalEditor;
        WebItem: Serenity.StringEditor;
        AcctItmSubcon: Serenity.StringEditor;
        WithBinCtrl: Serenity.StringEditor;
        Consign: Serenity.StringEditor;
        LastPackLineNo: Serenity.DecimalEditor;
        PutaxPcent: Serenity.DecimalEditor;
        AcctItmSltax: Serenity.StringEditor;
        SltaxPcent: Serenity.DecimalEditor;
        PurUom: Serenity.StringEditor;
        PurLotSize: Serenity.DecimalEditor;
        PurCcy: Serenity.StringEditor;
        PurBasePrice: Serenity.DecimalEditor;
        QtyNetAvailable: Serenity.DecimalEditor;
        UseStdProdLeadTime: Serenity.StringEditor;
        DailyProdQty: Serenity.DecimalEditor;
        IssueLotSize: Serenity.DecimalEditor;
        MrpExclude: Serenity.StringEditor;
        EnableLot: Serenity.StringEditor;
        EnableSerial: Serenity.StringEditor;
        LotNoLength: Serenity.DecimalEditor;
        SerialNoLength: Serenity.DecimalEditor;
        NextLotNo: Serenity.DecimalEditor;
        NextSerialNo: Serenity.DecimalEditor;
        MaxLotSize: Serenity.DecimalEditor;
        LotNoPrefix: Serenity.StringEditor;
        SerialNoPrefix: Serenity.StringEditor;
        SafeStockLvl: Serenity.DecimalEditor;
        CustomProdCode: Serenity.StringEditor;
        CustomLotSize: Serenity.DecimalEditor;
        CustomGrUom: Serenity.StringEditor;
        CustomGrWt: Serenity.DecimalEditor;
        CustomNtWt: Serenity.DecimalEditor;
        CustomOrigin: Serenity.StringEditor;
        QtyOnTransfer: Serenity.DecimalEditor;
        WithResetLot: Serenity.StringEditor;
        WithResetSerial: Serenity.StringEditor;
        PrevResetLotDate: Serenity.DateEditor;
        PrevResetSerialDate: Serenity.DateEditor;
        AutogenLot: Serenity.StringEditor;
        AutogenSerial: Serenity.StringEditor;
        FabItem: Serenity.StringEditor;
        Anlys1: Serenity.StringEditor;
        Anlys2: Serenity.StringEditor;
        Anlys3: Serenity.StringEditor;
        Anlys4: Serenity.StringEditor;
        Anlys5: Serenity.StringEditor;
        Anlys6: Serenity.StringEditor;
        Anlys7: Serenity.StringEditor;
        Anlys8: Serenity.StringEditor;
        Anlys9: Serenity.StringEditor;
        Anlys10: Serenity.StringEditor;
        RohsCompliance: Serenity.BooleanEditor;
        DefMoldBomNo: Serenity.StringEditor;
        DefFormulaCode: Serenity.StringEditor;
        BoxType: Serenity.StringEditor;
        BoxLength: Serenity.DecimalEditor;
        BoxWidth: Serenity.DecimalEditor;
        BoxHeight: Serenity.DecimalEditor;
        BoxDUom: Serenity.StringEditor;
        Wd: Serenity.DecimalEditor;
        WdUom: Serenity.StringEditor;
        CsLength: Serenity.DecimalEditor;
        CsWidth: Serenity.DecimalEditor;
        UserDefinedField21: Serenity.StringEditor;
        CostWmove: Serenity.DecimalEditor;
        CostWcase: Serenity.DecimalEditor;
        CostWband: Serenity.DecimalEditor;
        CostBatt: Serenity.DecimalEditor;
        DescWmove: Serenity.StringEditor;
        DescWcase: Serenity.StringEditor;
        DescWband: Serenity.StringEditor;
        DescBatt: Serenity.StringEditor;
        PoBal: Serenity.DecimalEditor;
        PoMaxBal: Serenity.DecimalEditor;
        IncludeJob: Serenity.BooleanEditor;
        CsThickness: Serenity.DecimalEditor;
        CsThicknessUom: Serenity.StringEditor;
        CsProportion: Serenity.DecimalEditor;
        CsProportionUom: Serenity.StringEditor;
        DieCutter: Serenity.DecimalEditor;
        MatInspectLeadTime: Serenity.DecimalEditor;
        MatPrepareLeadTime: Serenity.DecimalEditor;
        MatInspectLeadUnit: Serenity.StringEditor;
        MatPrepareLeadUnit: Serenity.StringEditor;
        ColorCode: Serenity.StringEditor;
        CollectionCode: Serenity.StringEditor;
        StyleCode: Serenity.StringEditor;
        X: Serenity.DecimalEditor;
        Y: Serenity.DecimalEditor;
        TempDescription: Serenity.StringEditor;
        Specification: Serenity.StringEditor;
        XUom: Serenity.StringEditor;
        YUom: Serenity.StringEditor;
        ProductionUomConversionRate: Serenity.DecimalEditor;
        PurchaseUomConversionRate: Serenity.DecimalEditor;
        AutogenLotIssue: Serenity.BooleanEditor;
        AutogenSerialIssue: Serenity.BooleanEditor;
        WcCostCcy: Serenity.StringEditor;
        WcCost: Serenity.DecimalEditor;
        WcCostDisc: Serenity.DecimalEditor;
        WcCostExch: Serenity.DecimalEditor;
        WcFreight: Serenity.DecimalEditor;
        WcMargin: Serenity.DecimalEditor;
        CeilingPrice: Serenity.DecimalEditor;
        BottomRatio: Serenity.DecimalEditor;
        BottomPrice: Serenity.DecimalEditor;
        DrawingNo: Serenity.StringEditor;
        MaterialType: Serenity.StringEditor;
        AcctItmAsset: Serenity.StringEditor;
        AcctItmWip: Serenity.StringEditor;
        AcctItmConsum: Serenity.StringEditor;
        AcctItmScrap: Serenity.StringEditor;
        AcctItmPvar: Serenity.StringEditor;
        AcctItmReval: Serenity.StringEditor;
        AcctItmVaria: Serenity.StringEditor;
        AcctItmSales: Serenity.StringEditor;
        AcctItmSlret: Serenity.StringEditor;
        AcctItmSldisc: Serenity.StringEditor;
        AcctItmCogs: Serenity.StringEditor;
        AcctItmPurch: Serenity.StringEditor;
        AcctItmPuret: Serenity.StringEditor;
        AcctItmPudisc: Serenity.StringEditor;
        AcctItmPutax: Serenity.StringEditor;
        AcctMachine: Serenity.StringEditor;
        AcctEnergy: Serenity.StringEditor;
        AcctWater: Serenity.StringEditor;
        AcctRental: Serenity.StringEditor;
        AcctLabor: Serenity.StringEditor;
        AcctInlab: Serenity.StringEditor;
        AcctInmat: Serenity.StringEditor;
        AcctMisc: Serenity.StringEditor;
    }

    [['ItemNo', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['ItemGroup', () => Serenity.StringEditor]
   , ['StockUom', () => Serenity.StringEditor]
   , ['Suspended', () => Serenity.BooleanEditor]
   , ['Product', () => Serenity.BooleanEditor]
   , ['Material', () => Serenity.BooleanEditor]
   , ['MakeBuy', () => Serenity.BooleanEditor]
   , ['ItemType', () => Serenity.StringEditor]
   , ['AllocMethod', () => Serenity.StringEditor]
   , ['MainLoc', () => Serenity.StringEditor]
   , ['MainBin', () => Serenity.StringEditor]
   , ['CycleCode', () => Serenity.StringEditor]
   , ['DefBomNo', () => Serenity.StringEditor]
   , ['DefSpecNo', () => Serenity.StringEditor]
   , ['ScrapRate', () => Serenity.DecimalEditor]
   , ['AverageCost', () => Serenity.StringEditor]
   , ['LatestCost', () => Serenity.DecimalEditor]
   , ['StdCost', () => Serenity.DecimalEditor]
   , ['AltDescription', () => Serenity.StringEditor]
   , ['AltExtDesc', () => Serenity.StringEditor]
   , ['PrefVendOnly', () => Serenity.StringEditor]
   , ['PrefVend1', () => Serenity.StringEditor]
   , ['PrefVend2', () => Serenity.StringEditor]
   , ['Charges', () => Serenity.StringEditor]
   , ['Inspected', () => Serenity.StringEditor]
   , ['SalesUom', () => Serenity.StringEditor]
   , ['StdCostOk', () => Serenity.StringEditor]
   , ['CostCentre', () => Serenity.StringEditor]
   , ['DefSpecCount', () => Serenity.DecimalEditor]
   , ['WithBacklog', () => Serenity.StringEditor]
   , ['WithBalance', () => Serenity.StringEditor]
   , ['QtyOnHand', () => Serenity.DecimalEditor]
   , ['QtyOnSorder', () => Serenity.DecimalEditor]
   , ['QtyOnPorder', () => Serenity.DecimalEditor]
   , ['QtyOnJorder', () => Serenity.DecimalEditor]
   , ['QtyOnInspect', () => Serenity.DecimalEditor]
   , ['QtyWaitlisted', () => Serenity.DecimalEditor]
   , ['QtyReserved', () => Serenity.DecimalEditor]
   , ['QtyCommitted', () => Serenity.DecimalEditor]
   , ['QtyAvailable', () => Serenity.DecimalEditor]
   , ['QtyUnallocated', () => Serenity.DecimalEditor]
   , ['InvtCostAvail', () => Serenity.DecimalEditor]
   , ['InvtCostLdg', () => Serenity.DecimalEditor]
   , ['PriceCcy', () => Serenity.StringEditor]
   , ['BasePrice', () => Serenity.DecimalEditor]
   , ['Pricea', () => Serenity.DecimalEditor]
   , ['Priceb', () => Serenity.DecimalEditor]
   , ['Pricec', () => Serenity.DecimalEditor]
   , ['MinPrice', () => Serenity.DecimalEditor]
   , ['MaxPrice', () => Serenity.DecimalEditor]
   , ['LastCountDate', () => Serenity.DateEditor]
   , ['LastDateIn', () => Serenity.DateEditor]
   , ['LastDateOut', () => Serenity.DateEditor]
   , ['SalesLotSize', () => Serenity.DecimalEditor]
   , ['MinOrderQty', () => Serenity.DecimalEditor]
   , ['MaxOrderQty', () => Serenity.DecimalEditor]
   , ['MinOrderDays', () => Serenity.DecimalEditor]
   , ['InnerPkgType', () => Serenity.StringEditor]
   , ['InnerQty', () => Serenity.DecimalEditor]
   , ['OuterPkgType', () => Serenity.StringEditor]
   , ['OuterQty', () => Serenity.DecimalEditor]
   , ['ArticleCode', () => Serenity.StringEditor]
   , ['QuotaCategory', () => Serenity.StringEditor]
   , ['WeightUom', () => Serenity.StringEditor]
   , ['GrossWt', () => Serenity.DecimalEditor]
   , ['NetWt', () => Serenity.DecimalEditor]
   , ['DimensionUom', () => Serenity.StringEditor]
   , ['Flength', () => Serenity.DecimalEditor]
   , ['Width', () => Serenity.DecimalEditor]
   , ['Height', () => Serenity.DecimalEditor]
   , ['ComputedVol', () => Serenity.DecimalEditor]
   , ['DeclaredVol', () => Serenity.DecimalEditor]
   , ['MpsItem', () => Serenity.StringEditor]
   , ['OrderPolicy', () => Serenity.StringEditor]
   , ['MinPlanordQty', () => Serenity.DecimalEditor]
   , ['MaxPlanordQty', () => Serenity.DecimalEditor]
   , ['StdPlanordQty', () => Serenity.DecimalEditor]
   , ['MinPlanordPrd', () => Serenity.DecimalEditor]
   , ['MaxPlanordPrd', () => Serenity.DecimalEditor]
   , ['StdPlanordPrd', () => Serenity.DecimalEditor]
   , ['ReorderPt', () => Serenity.DecimalEditor]
   , ['ReorderQty', () => Serenity.DecimalEditor]
   , ['MinMthlyProd', () => Serenity.DecimalEditor]
   , ['MaxMthlyProd', () => Serenity.DecimalEditor]
   , ['MinMthlyPur', () => Serenity.DecimalEditor]
   , ['MaxMthlyPur', () => Serenity.DecimalEditor]
   , ['FollowMinProd', () => Serenity.StringEditor]
   , ['FollowMaxProd', () => Serenity.StringEditor]
   , ['FollowMinPur', () => Serenity.StringEditor]
   , ['FollowMaxPur', () => Serenity.StringEditor]
   , ['AllowMixMode', () => Serenity.StringEditor]
   , ['ProdLeadTime', () => Serenity.DecimalEditor]
   , ['ProdLeadUnit', () => Serenity.StringEditor]
   , ['PurLeadTime', () => Serenity.DecimalEditor]
   , ['PurLeadUnit', () => Serenity.StringEditor]
   , ['Planner', () => Serenity.StringEditor]
   , ['MrpParmDate', () => Serenity.DateEditor]
   , ['MrpParmBy', () => Serenity.StringEditor]
   , ['PictureFile', () => Serenity.StringEditor]
   , ['SalesLtaxCode', () => Serenity.StringEditor]
   , ['PurchLtaxCode', () => Serenity.StringEditor]
   , ['TrevisedDate', () => Serenity.DateEditor]
   , ['TrevisedBy', () => Serenity.StringEditor]
   , ['SpecsCount', () => Serenity.DecimalEditor]
   , ['LastSnapNo', () => Serenity.DecimalEditor]
   , ['CommisType', () => Serenity.StringEditor]
   , ['ProdBranch', () => Serenity.StringEditor]
   , ['ExtendedDesc', () => Serenity.StringEditor]
   , ['PurPriceCtrl', () => Serenity.StringEditor]
   , ['PurMaxDev', () => Serenity.DecimalEditor]
   , ['WebItem', () => Serenity.StringEditor]
   , ['AcctItmSubcon', () => Serenity.StringEditor]
   , ['WithBinCtrl', () => Serenity.StringEditor]
   , ['Consign', () => Serenity.StringEditor]
   , ['LastPackLineNo', () => Serenity.DecimalEditor]
   , ['PutaxPcent', () => Serenity.DecimalEditor]
   , ['AcctItmSltax', () => Serenity.StringEditor]
   , ['SltaxPcent', () => Serenity.DecimalEditor]
   , ['PurUom', () => Serenity.StringEditor]
   , ['PurLotSize', () => Serenity.DecimalEditor]
   , ['PurCcy', () => Serenity.StringEditor]
   , ['PurBasePrice', () => Serenity.DecimalEditor]
   , ['QtyNetAvailable', () => Serenity.DecimalEditor]
   , ['UseStdProdLeadTime', () => Serenity.StringEditor]
   , ['DailyProdQty', () => Serenity.DecimalEditor]
   , ['IssueLotSize', () => Serenity.DecimalEditor]
   , ['MrpExclude', () => Serenity.StringEditor]
   , ['EnableLot', () => Serenity.StringEditor]
   , ['EnableSerial', () => Serenity.StringEditor]
   , ['LotNoLength', () => Serenity.DecimalEditor]
   , ['SerialNoLength', () => Serenity.DecimalEditor]
   , ['NextLotNo', () => Serenity.DecimalEditor]
   , ['NextSerialNo', () => Serenity.DecimalEditor]
   , ['MaxLotSize', () => Serenity.DecimalEditor]
   , ['LotNoPrefix', () => Serenity.StringEditor]
   , ['SerialNoPrefix', () => Serenity.StringEditor]
   , ['SafeStockLvl', () => Serenity.DecimalEditor]
   , ['CustomProdCode', () => Serenity.StringEditor]
   , ['CustomLotSize', () => Serenity.DecimalEditor]
   , ['CustomGrUom', () => Serenity.StringEditor]
   , ['CustomGrWt', () => Serenity.DecimalEditor]
   , ['CustomNtWt', () => Serenity.DecimalEditor]
   , ['CustomOrigin', () => Serenity.StringEditor]
   , ['QtyOnTransfer', () => Serenity.DecimalEditor]
   , ['WithResetLot', () => Serenity.StringEditor]
   , ['WithResetSerial', () => Serenity.StringEditor]
   , ['PrevResetLotDate', () => Serenity.DateEditor]
   , ['PrevResetSerialDate', () => Serenity.DateEditor]
   , ['AutogenLot', () => Serenity.StringEditor]
   , ['AutogenSerial', () => Serenity.StringEditor]
   , ['FabItem', () => Serenity.StringEditor]
   , ['Anlys1', () => Serenity.StringEditor]
   , ['Anlys2', () => Serenity.StringEditor]
   , ['Anlys3', () => Serenity.StringEditor]
   , ['Anlys4', () => Serenity.StringEditor]
   , ['Anlys5', () => Serenity.StringEditor]
   , ['Anlys6', () => Serenity.StringEditor]
   , ['Anlys7', () => Serenity.StringEditor]
   , ['Anlys8', () => Serenity.StringEditor]
   , ['Anlys9', () => Serenity.StringEditor]
   , ['Anlys10', () => Serenity.StringEditor]
   , ['RohsCompliance', () => Serenity.BooleanEditor]
   , ['DefMoldBomNo', () => Serenity.StringEditor]
   , ['DefFormulaCode', () => Serenity.StringEditor]
   , ['BoxType', () => Serenity.StringEditor]
   , ['BoxLength', () => Serenity.DecimalEditor]
   , ['BoxWidth', () => Serenity.DecimalEditor]
   , ['BoxHeight', () => Serenity.DecimalEditor]
   , ['BoxDUom', () => Serenity.StringEditor]
   , ['Wd', () => Serenity.DecimalEditor]
   , ['WdUom', () => Serenity.StringEditor]
   , ['CsLength', () => Serenity.DecimalEditor]
   , ['CsWidth', () => Serenity.DecimalEditor]
   , ['UserDefinedField21', () => Serenity.StringEditor]
   , ['CostWmove', () => Serenity.DecimalEditor]
   , ['CostWcase', () => Serenity.DecimalEditor]
   , ['CostWband', () => Serenity.DecimalEditor]
   , ['CostBatt', () => Serenity.DecimalEditor]
   , ['DescWmove', () => Serenity.StringEditor]
   , ['DescWcase', () => Serenity.StringEditor]
   , ['DescWband', () => Serenity.StringEditor]
   , ['DescBatt', () => Serenity.StringEditor]
   , ['PoBal', () => Serenity.DecimalEditor]
   , ['PoMaxBal', () => Serenity.DecimalEditor]
   , ['IncludeJob', () => Serenity.BooleanEditor]
   , ['CsThickness', () => Serenity.DecimalEditor]
   , ['CsThicknessUom', () => Serenity.StringEditor]
   , ['CsProportion', () => Serenity.DecimalEditor]
   , ['CsProportionUom', () => Serenity.StringEditor]
   , ['DieCutter', () => Serenity.DecimalEditor]
   , ['MatInspectLeadTime', () => Serenity.DecimalEditor]
   , ['MatPrepareLeadTime', () => Serenity.DecimalEditor]
   , ['MatInspectLeadUnit', () => Serenity.StringEditor]
   , ['MatPrepareLeadUnit', () => Serenity.StringEditor]
   , ['ColorCode', () => Serenity.StringEditor]
   , ['CollectionCode', () => Serenity.StringEditor]
   , ['StyleCode', () => Serenity.StringEditor]
   , ['X', () => Serenity.DecimalEditor]
   , ['Y', () => Serenity.DecimalEditor]
   , ['TempDescription', () => Serenity.StringEditor]
   , ['Specification', () => Serenity.StringEditor]
   , ['XUom', () => Serenity.StringEditor]
   , ['YUom', () => Serenity.StringEditor]
   , ['ProductionUomConversionRate', () => Serenity.DecimalEditor]
   , ['PurchaseUomConversionRate', () => Serenity.DecimalEditor]
   , ['AutogenLotIssue', () => Serenity.BooleanEditor]
   , ['AutogenSerialIssue', () => Serenity.BooleanEditor]
   , ['WcCostCcy', () => Serenity.StringEditor]
   , ['WcCost', () => Serenity.DecimalEditor]
   , ['WcCostDisc', () => Serenity.DecimalEditor]
   , ['WcCostExch', () => Serenity.DecimalEditor]
   , ['WcFreight', () => Serenity.DecimalEditor]
   , ['WcMargin', () => Serenity.DecimalEditor]
   , ['CeilingPrice', () => Serenity.DecimalEditor]
   , ['BottomRatio', () => Serenity.DecimalEditor]
   , ['BottomPrice', () => Serenity.DecimalEditor]
   , ['DrawingNo', () => Serenity.StringEditor]
   , ['MaterialType', () => Serenity.StringEditor]
   , ['AcctItmAsset', () => Serenity.StringEditor]
   , ['AcctItmWip', () => Serenity.StringEditor]
   , ['AcctItmConsum', () => Serenity.StringEditor]
   , ['AcctItmScrap', () => Serenity.StringEditor]
   , ['AcctItmPvar', () => Serenity.StringEditor]
   , ['AcctItmReval', () => Serenity.StringEditor]
   , ['AcctItmVaria', () => Serenity.StringEditor]
   , ['AcctItmSales', () => Serenity.StringEditor]
   , ['AcctItmSlret', () => Serenity.StringEditor]
   , ['AcctItmSldisc', () => Serenity.StringEditor]
   , ['AcctItmCogs', () => Serenity.StringEditor]
   , ['AcctItmPurch', () => Serenity.StringEditor]
   , ['AcctItmPuret', () => Serenity.StringEditor]
   , ['AcctItmPudisc', () => Serenity.StringEditor]
   , ['AcctItmPutax', () => Serenity.StringEditor]
   , ['AcctMachine', () => Serenity.StringEditor]
   , ['AcctEnergy', () => Serenity.StringEditor]
   , ['AcctWater', () => Serenity.StringEditor]
   , ['AcctRental', () => Serenity.StringEditor]
   , ['AcctLabor', () => Serenity.StringEditor]
   , ['AcctInlab', () => Serenity.StringEditor]
   , ['AcctInmat', () => Serenity.StringEditor]
   , ['AcctMisc', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(ItemForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

