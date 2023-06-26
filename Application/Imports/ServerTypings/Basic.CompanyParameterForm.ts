namespace Matrix.Basic {
    export class CompanyParameterForm extends Serenity.PrefixedContext {
        static formKey = 'Basic.CompanyParameter';

    }

    export interface CompanyParameterForm {
        CompanyName: Serenity.StringEditor;
        Address: Serenity.StringEditor;
        Address2: Serenity.StringEditor;
        Address3: Serenity.StringEditor;
        Address4: Serenity.StringEditor;
        PostCode: Serenity.StringEditor;
        TelNo: Serenity.StringEditor;
        FaxNo: Serenity.StringEditor;
        Email: Serenity.StringEditor;
        TaxAcctNo: Serenity.StringEditor;
        BusRegNo: Serenity.StringEditor;
        AltName: Serenity.StringEditor;
        AltAddress: Serenity.StringEditor;
        AltAddress2: Serenity.StringEditor;
        AltAddress3: Serenity.StringEditor;
        AltAddress4: Serenity.StringEditor;
        VerifySettings: Serenity.BooleanEditor;
        BranchNo: Serenity.StringEditor;
        NoOfPeriods: Serenity.DecimalEditor;
        CurrentPeriod: Serenity.StringEditor;
        OpenPrdFrom: Serenity.StringEditor;
        OpenPrdTo: Serenity.StringEditor;
        BaseCurrency: Serenity.StringEditor;
        AllocMethod: Serenity.StringEditor;
        ItmNoLen: Serenity.DecimalEditor;
        ItmNoGridLen: Serenity.DecimalEditor;
        BomNoGridLen: Serenity.DecimalEditor;
        AllowEntries: Serenity.StringEditor;
        LineNoEntry: Serenity.StringEditor;
        WithInspection: Serenity.StringEditor;
        WithDept: Serenity.StringEditor;
        WithCostCtr: Serenity.StringEditor;
        WithAccpac: Serenity.StringEditor;
        AccpacIgrp: Serenity.StringEditor;
        WithBinCtrl: Serenity.StringEditor;
        WithLot: Serenity.StringEditor;
        WithSqlAttm: Serenity.StringEditor;
        AcctRetEarn: Serenity.StringEditor;
        AcctCurEarn: Serenity.StringEditor;
        AcctEndBs: Serenity.StringEditor;
        LocReceiving: Serenity.StringEditor;
        LocShipment: Serenity.StringEditor;
        LocPos: Serenity.StringEditor;
        LocMaterial: Serenity.StringEditor;
        LocProduce: Serenity.StringEditor;
        IcRevaluation: Serenity.StringEditor;
        FgStdCosting: Serenity.StringEditor;
        CostingMethod: Serenity.StringEditor;
        AllowLotOpt: Serenity.StringEditor;
        PmntFundCode: Serenity.StringEditor;
        RcptFundCode: Serenity.StringEditor;
        SalesPayTerms: Serenity.StringEditor;
        PurchPayTerms: Serenity.StringEditor;
        ItemGroup: Serenity.StringEditor;
        CustomerGroup: Serenity.StringEditor;
        VendorGroup: Serenity.StringEditor;
        SlsoMultiship: Serenity.StringEditor;
        SlsoResv: Serenity.StringEditor;
        SlsoAssortment: Serenity.StringEditor;
        SlsoDeposits: Serenity.StringEditor;
        SlsoMeasures: Serenity.StringEditor;
        SlsoAutoPo: Serenity.StringEditor;
        SlsoAutoJob: Serenity.StringEditor;
        SlsoExtInst: Serenity.StringEditor;
        SlsoExtDesc: Serenity.StringEditor;
        SlsoReqSman: Serenity.StringEditor;
        SlsoText1: Serenity.StringEditor;
        SlsoText2: Serenity.StringEditor;
        SlsoText3: Serenity.StringEditor;
        SlsoText4: Serenity.StringEditor;
        SlsoDueLead: Serenity.DecimalEditor;
        SlsoSchLead: Serenity.DecimalEditor;
        SlsoQuoteDays: Serenity.DecimalEditor;
        SlshCutDays: Serenity.DecimalEditor;
        SlsoAddrCode: Serenity.StringEditor;
        SlsoAddrType: Serenity.StringEditor;
        SlsoShipVia: Serenity.StringEditor;
        SlsoShipTerms: Serenity.StringEditor;
        PupoMultiship: Serenity.StringEditor;
        PupoDeposits: Serenity.StringEditor;
        PupoMeasures: Serenity.StringEditor;
        PupoReqBuyer: Serenity.StringEditor;
        PupoLineDisc: Serenity.StringEditor;
        PupoReorder: Serenity.StringEditor;
        PupoText1: Serenity.StringEditor;
        PupoText2: Serenity.StringEditor;
        PupoText3: Serenity.StringEditor;
        PupoText4: Serenity.StringEditor;
        PupoCutDays: Serenity.DecimalEditor;
        PupoBuyer: Serenity.StringEditor;
        PupoShipVia: Serenity.StringEditor;
        PupoShipTerms: Serenity.StringEditor;
        ProdEcnReq: Serenity.StringEditor;
        ProdByprod: Serenity.StringEditor;
        ProdPictDesc1: Serenity.StringEditor;
        ProdPictDesc2: Serenity.StringEditor;
        ProdPictDesc3: Serenity.StringEditor;
        ProdPictDesc4: Serenity.StringEditor;
        ProdWeightUom: Serenity.StringEditor;
        ProdDimenUom: Serenity.StringEditor;
        ProdScrapRate: Serenity.DecimalEditor;
        ProdStdLsize: Serenity.DecimalEditor;
        ProdMinLsize: Serenity.DecimalEditor;
        ProdMaxLsize: Serenity.DecimalEditor;
        ProdStdOutput: Serenity.DecimalEditor;
        ShopWksCover: Serenity.DecimalEditor;
        MrpHorzDate: Serenity.DateEditor;
        ShopPlanner: Serenity.StringEditor;
        ShopJobCat: Serenity.StringEditor;
        PrpmText1: Serenity.StringEditor;
        PrpmText2: Serenity.StringEditor;
        PrpmText3: Serenity.StringEditor;
        PrpmText4: Serenity.StringEditor;
        MrpCount: Serenity.DecimalEditor;
        MrpRefNo: Serenity.StringEditor;
        MrpRunDate: Serenity.DateEditor;
        IcReceipts: Serenity.StringEditor;
        IcIssuance: Serenity.StringEditor;
        IcTransfer: Serenity.StringEditor;
        IcAdjustment: Serenity.StringEditor;
        MvtSlShipment: Serenity.StringEditor;
        MvtSlReturn: Serenity.StringEditor;
        MvtPuReceipt: Serenity.StringEditor;
        MvtPuInspect: Serenity.StringEditor;
        MvtPuReturn: Serenity.StringEditor;
        VochArInvo: Serenity.StringEditor;
        VochArMemo: Serenity.StringEditor;
        VochArAdj: Serenity.StringEditor;
        VochArPay: Serenity.StringEditor;
        GlHdrTxt: Serenity.StringEditor;
        GlRefEntry: Serenity.StringEditor;
        GlDtlTxt: Serenity.StringEditor;
        GlLrefEntry: Serenity.StringEditor;
        GlRefLabel: Serenity.StringEditor;
        GlLrefLabel: Serenity.StringEditor;
    }

    [['CompanyName', () => Serenity.StringEditor]
   , ['Address', () => Serenity.StringEditor]
   , ['Address2', () => Serenity.StringEditor]
   , ['Address3', () => Serenity.StringEditor]
   , ['Address4', () => Serenity.StringEditor]
   , ['PostCode', () => Serenity.StringEditor]
   , ['TelNo', () => Serenity.StringEditor]
   , ['FaxNo', () => Serenity.StringEditor]
   , ['Email', () => Serenity.StringEditor]
   , ['TaxAcctNo', () => Serenity.StringEditor]
   , ['BusRegNo', () => Serenity.StringEditor]
   , ['AltName', () => Serenity.StringEditor]
   , ['AltAddress', () => Serenity.StringEditor]
   , ['AltAddress2', () => Serenity.StringEditor]
   , ['AltAddress3', () => Serenity.StringEditor]
   , ['AltAddress4', () => Serenity.StringEditor]
   , ['VerifySettings', () => Serenity.BooleanEditor]
   , ['BranchNo', () => Serenity.StringEditor]
   , ['NoOfPeriods', () => Serenity.DecimalEditor]
   , ['CurrentPeriod', () => Serenity.StringEditor]
   , ['OpenPrdFrom', () => Serenity.StringEditor]
   , ['OpenPrdTo', () => Serenity.StringEditor]
   , ['BaseCurrency', () => Serenity.StringEditor]
   , ['AllocMethod', () => Serenity.StringEditor]
   , ['ItmNoLen', () => Serenity.DecimalEditor]
   , ['ItmNoGridLen', () => Serenity.DecimalEditor]
   , ['BomNoGridLen', () => Serenity.DecimalEditor]
   , ['AllowEntries', () => Serenity.StringEditor]
   , ['LineNoEntry', () => Serenity.StringEditor]
   , ['WithInspection', () => Serenity.StringEditor]
   , ['WithDept', () => Serenity.StringEditor]
   , ['WithCostCtr', () => Serenity.StringEditor]
   , ['WithAccpac', () => Serenity.StringEditor]
   , ['AccpacIgrp', () => Serenity.StringEditor]
   , ['WithBinCtrl', () => Serenity.StringEditor]
   , ['WithLot', () => Serenity.StringEditor]
   , ['WithSqlAttm', () => Serenity.StringEditor]
   , ['AcctRetEarn', () => Serenity.StringEditor]
   , ['AcctCurEarn', () => Serenity.StringEditor]
   , ['AcctEndBs', () => Serenity.StringEditor]
   , ['LocReceiving', () => Serenity.StringEditor]
   , ['LocShipment', () => Serenity.StringEditor]
   , ['LocPos', () => Serenity.StringEditor]
   , ['LocMaterial', () => Serenity.StringEditor]
   , ['LocProduce', () => Serenity.StringEditor]
   , ['IcRevaluation', () => Serenity.StringEditor]
   , ['FgStdCosting', () => Serenity.StringEditor]
   , ['CostingMethod', () => Serenity.StringEditor]
   , ['AllowLotOpt', () => Serenity.StringEditor]
   , ['PmntFundCode', () => Serenity.StringEditor]
   , ['RcptFundCode', () => Serenity.StringEditor]
   , ['SalesPayTerms', () => Serenity.StringEditor]
   , ['PurchPayTerms', () => Serenity.StringEditor]
   , ['ItemGroup', () => Serenity.StringEditor]
   , ['CustomerGroup', () => Serenity.StringEditor]
   , ['VendorGroup', () => Serenity.StringEditor]
   , ['SlsoMultiship', () => Serenity.StringEditor]
   , ['SlsoResv', () => Serenity.StringEditor]
   , ['SlsoAssortment', () => Serenity.StringEditor]
   , ['SlsoDeposits', () => Serenity.StringEditor]
   , ['SlsoMeasures', () => Serenity.StringEditor]
   , ['SlsoAutoPo', () => Serenity.StringEditor]
   , ['SlsoAutoJob', () => Serenity.StringEditor]
   , ['SlsoExtInst', () => Serenity.StringEditor]
   , ['SlsoExtDesc', () => Serenity.StringEditor]
   , ['SlsoReqSman', () => Serenity.StringEditor]
   , ['SlsoText1', () => Serenity.StringEditor]
   , ['SlsoText2', () => Serenity.StringEditor]
   , ['SlsoText3', () => Serenity.StringEditor]
   , ['SlsoText4', () => Serenity.StringEditor]
   , ['SlsoDueLead', () => Serenity.DecimalEditor]
   , ['SlsoSchLead', () => Serenity.DecimalEditor]
   , ['SlsoQuoteDays', () => Serenity.DecimalEditor]
   , ['SlshCutDays', () => Serenity.DecimalEditor]
   , ['SlsoAddrCode', () => Serenity.StringEditor]
   , ['SlsoAddrType', () => Serenity.StringEditor]
   , ['SlsoShipVia', () => Serenity.StringEditor]
   , ['SlsoShipTerms', () => Serenity.StringEditor]
   , ['PupoMultiship', () => Serenity.StringEditor]
   , ['PupoDeposits', () => Serenity.StringEditor]
   , ['PupoMeasures', () => Serenity.StringEditor]
   , ['PupoReqBuyer', () => Serenity.StringEditor]
   , ['PupoLineDisc', () => Serenity.StringEditor]
   , ['PupoReorder', () => Serenity.StringEditor]
   , ['PupoText1', () => Serenity.StringEditor]
   , ['PupoText2', () => Serenity.StringEditor]
   , ['PupoText3', () => Serenity.StringEditor]
   , ['PupoText4', () => Serenity.StringEditor]
   , ['PupoCutDays', () => Serenity.DecimalEditor]
   , ['PupoBuyer', () => Serenity.StringEditor]
   , ['PupoShipVia', () => Serenity.StringEditor]
   , ['PupoShipTerms', () => Serenity.StringEditor]
   , ['ProdEcnReq', () => Serenity.StringEditor]
   , ['ProdByprod', () => Serenity.StringEditor]
   , ['ProdPictDesc1', () => Serenity.StringEditor]
   , ['ProdPictDesc2', () => Serenity.StringEditor]
   , ['ProdPictDesc3', () => Serenity.StringEditor]
   , ['ProdPictDesc4', () => Serenity.StringEditor]
   , ['ProdWeightUom', () => Serenity.StringEditor]
   , ['ProdDimenUom', () => Serenity.StringEditor]
   , ['ProdScrapRate', () => Serenity.DecimalEditor]
   , ['ProdStdLsize', () => Serenity.DecimalEditor]
   , ['ProdMinLsize', () => Serenity.DecimalEditor]
   , ['ProdMaxLsize', () => Serenity.DecimalEditor]
   , ['ProdStdOutput', () => Serenity.DecimalEditor]
   , ['ShopWksCover', () => Serenity.DecimalEditor]
   , ['MrpHorzDate', () => Serenity.DateEditor]
   , ['ShopPlanner', () => Serenity.StringEditor]
   , ['ShopJobCat', () => Serenity.StringEditor]
   , ['PrpmText1', () => Serenity.StringEditor]
   , ['PrpmText2', () => Serenity.StringEditor]
   , ['PrpmText3', () => Serenity.StringEditor]
   , ['PrpmText4', () => Serenity.StringEditor]
   , ['MrpCount', () => Serenity.DecimalEditor]
   , ['MrpRefNo', () => Serenity.StringEditor]
   , ['MrpRunDate', () => Serenity.DateEditor]
   , ['IcReceipts', () => Serenity.StringEditor]
   , ['IcIssuance', () => Serenity.StringEditor]
   , ['IcTransfer', () => Serenity.StringEditor]
   , ['IcAdjustment', () => Serenity.StringEditor]
   , ['MvtSlShipment', () => Serenity.StringEditor]
   , ['MvtSlReturn', () => Serenity.StringEditor]
   , ['MvtPuReceipt', () => Serenity.StringEditor]
   , ['MvtPuInspect', () => Serenity.StringEditor]
   , ['MvtPuReturn', () => Serenity.StringEditor]
   , ['VochArInvo', () => Serenity.StringEditor]
   , ['VochArMemo', () => Serenity.StringEditor]
   , ['VochArAdj', () => Serenity.StringEditor]
   , ['VochArPay', () => Serenity.StringEditor]
   , ['GlHdrTxt', () => Serenity.StringEditor]
   , ['GlRefEntry', () => Serenity.StringEditor]
   , ['GlDtlTxt', () => Serenity.StringEditor]
   , ['GlLrefEntry', () => Serenity.StringEditor]
   , ['GlRefLabel', () => Serenity.StringEditor]
   , ['GlLrefLabel', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(CompanyParameterForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

