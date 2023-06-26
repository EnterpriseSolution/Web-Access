namespace Matrix.Basic {
    export class CompanySettingForm extends Serenity.PrefixedContext {
        static formKey = 'BasicInformation.CompanySetting';

    }

    export interface CompanySettingForm {
        SlInit: Serenity.StringEditor;
        SlsoMultiship: Serenity.StringEditor;
        SlsoResv: Serenity.StringEditor;
        SlsoAssortment: Serenity.StringEditor;
        SlsoDeposits: Serenity.StringEditor;
        SlsoMeasures: Serenity.StringEditor;
        SlsoPtax: Serenity.StringEditor;
        SlsoAtax: Serenity.StringEditor;
        SlsoGtax: Serenity.StringEditor;
        SlsoLineDisc: Serenity.StringEditor;
        SlsoAutoPo: Serenity.StringEditor;
        SlsoAutoJob: Serenity.StringEditor;
        SlsoExtInst: Serenity.StringEditor;
        SlsoExtDesc: Serenity.StringEditor;
        SlsoFixedUom: Serenity.StringEditor;
        SlsoReqSman: Serenity.StringEditor;
        SlsoSman: Serenity.StringEditor;
        SlsoText1: Serenity.StringEditor;
        SlsoText2: Serenity.StringEditor;
        SlsoText3: Serenity.StringEditor;
        SlsoText4: Serenity.StringEditor;
        SlsoDueLead: Serenity.DecimalEditor;
        SlsoSchLead: Serenity.DecimalEditor;
        SlsoAddrCode: Serenity.StringEditor;
        SlsoAddrType: Serenity.StringEditor;
        SlsoQuoteDays: Serenity.DecimalEditor;
        SlshCutDays: Serenity.DecimalEditor;
        SlsoShipVia: Serenity.StringEditor;
        SlsoShipTerms: Serenity.StringEditor;
        SlRevisedDate: Serenity.DateEditor;
        SlRevisedBy: Serenity.StringEditor;
        PuInit: Serenity.StringEditor;
        PupoMultiship: Serenity.StringEditor;
        PupoDeposits: Serenity.StringEditor;
        PupoMeasures: Serenity.StringEditor;
        PupoPtax: Serenity.StringEditor;
        PupoAtax: Serenity.StringEditor;
        PupoGtax: Serenity.StringEditor;
        PupoLineDisc: Serenity.StringEditor;
        PupoExtInst: Serenity.StringEditor;
        PupoExtDesc: Serenity.StringEditor;
        PupoFixedUom: Serenity.StringEditor;
        PupoText1: Serenity.StringEditor;
        PupoText2: Serenity.StringEditor;
        PupoText3: Serenity.StringEditor;
        PupoText4: Serenity.StringEditor;
        PupoCutDays: Serenity.DecimalEditor;
        PupoReorder: Serenity.StringEditor;
        PupoReqBuyer: Serenity.StringEditor;
        PupoBuyer: Serenity.StringEditor;
        PupoShipVia: Serenity.StringEditor;
        PupoShipTerms: Serenity.StringEditor;
        PuRevisedDate: Serenity.DateEditor;
        PuRevisedBy: Serenity.StringEditor;
        ProdInit: Serenity.StringEditor;
        ProdEcnReq: Serenity.StringEditor;
        ProdByprod: Serenity.StringEditor;
        ProdScrapRate: Serenity.DecimalEditor;
        ProdPictDesc1: Serenity.StringEditor;
        ProdPictDesc2: Serenity.StringEditor;
        ProdPictDesc3: Serenity.StringEditor;
        ProdPictDesc4: Serenity.StringEditor;
        ProdWeightUom: Serenity.StringEditor;
        ProdDimenUom: Serenity.StringEditor;
        ProdFixedWtum: Serenity.StringEditor;
        ProdFixedDmum: Serenity.StringEditor;
        ProdStdLsize: Serenity.DecimalEditor;
        ProdMinLsize: Serenity.DecimalEditor;
        ProdMaxLsize: Serenity.DecimalEditor;
        ProdStdOutput: Serenity.DecimalEditor;
        PrRevisedDate: Serenity.DateEditor;
        PrRevisedBy: Serenity.StringEditor;
        ShopReqJcat: Serenity.StringEditor;
        ShopWksCover: Serenity.DecimalEditor;
        ShopPlanner: Serenity.StringEditor;
        ShopDefPlnr: Serenity.StringEditor;
        ShopMpsHorz: Serenity.DecimalEditor;
        ShopPurLtime: Serenity.DecimalEditor;
        ShopPurLunit: Serenity.StringEditor;
        ShopJobCat: Serenity.StringEditor;
        ShopMrpHorz: Serenity.DecimalEditor;
        ShRevisedDate: Serenity.DateEditor;
        ShRevisedBy: Serenity.StringEditor;
        MrpCount: Serenity.DecimalEditor;
        MrpRefNo: Serenity.StringEditor;
        MrpRunDate: Serenity.DateEditor;
        MrpHorzDate: Serenity.DateEditor;
        IcInit: Serenity.StringEditor;
        IcReceipts: Serenity.StringEditor;
        IcIssuance: Serenity.StringEditor;
        IcTransfer: Serenity.StringEditor;
        IcAdjustment: Serenity.StringEditor;
        IcRevisedDate: Serenity.DateEditor;
        IcRevisedBy: Serenity.StringEditor;
        PrJobSched: Serenity.StringEditor;
        PrByProd: Serenity.StringEditor;
        PrJobBatches: Serenity.StringEditor;
        LastResvNo: Serenity.DecimalEditor;
        NoMrpFence: Serenity.StringEditor;
        MvtRmIssue: Serenity.StringEditor;
        MvtSpIssue: Serenity.StringEditor;
        MvtFgReturn: Serenity.StringEditor;
        MvtRmReturn: Serenity.StringEditor;
        MvtSlShipment: Serenity.StringEditor;
        MvtSlReturn: Serenity.StringEditor;
        MvtPuReceipt: Serenity.StringEditor;
        MvtPuInspect: Serenity.StringEditor;
        MvtPuReturn: Serenity.StringEditor;
        GlInit: Serenity.StringEditor;
        GlHdrTxt: Serenity.StringEditor;
        GlDtlTxt: Serenity.StringEditor;
        GlRefEntry: Serenity.StringEditor;
        GlRefLabel: Serenity.StringEditor;
        GlLrefEntry: Serenity.StringEditor;
        GlLrefLabel: Serenity.StringEditor;
        GlExchComp: Serenity.StringEditor;
        GlRevisedBy: Serenity.StringEditor;
        GlRevisedDate: Serenity.DateEditor;
        VochArInvo: Serenity.StringEditor;
        VochArMemo: Serenity.StringEditor;
        VochArAdj: Serenity.StringEditor;
        VochArPay: Serenity.StringEditor;
        VochArAlloc: Serenity.StringEditor;
        VochArInvocan: Serenity.StringEditor;
        VochArPaycan: Serenity.StringEditor;
        VochApInvo: Serenity.StringEditor;
        VochApMemo: Serenity.StringEditor;
        VochApAdj: Serenity.StringEditor;
        VochApPay: Serenity.StringEditor;
        VochApAlloc: Serenity.StringEditor;
        VochApInvocan: Serenity.StringEditor;
        VochApPaycan: Serenity.StringEditor;
        VochIcIssue: Serenity.StringEditor;
        VochIcRcpt: Serenity.StringEditor;
        VochIcAdj: Serenity.StringEditor;
        VochPrIssue: Serenity.StringEditor;
        VochPrReturn: Serenity.StringEditor;
        VochPrProd: Serenity.StringEditor;
        VochPrSubcon: Serenity.StringEditor;
        VochPayroll: Serenity.StringEditor;
        VochCommission: Serenity.StringEditor;
        VochFaAcquire: Serenity.StringEditor;
        VochFaDeprec: Serenity.StringEditor;
        VochFaMaint: Serenity.StringEditor;
        VochFaDispo: Serenity.StringEditor;
        ArBcountInvo: Serenity.DecimalEditor;
        ArBcountMemo: Serenity.DecimalEditor;
        ArBcountAdj: Serenity.DecimalEditor;
        ArBcountPay: Serenity.DecimalEditor;
        ArBcountAlloc: Serenity.DecimalEditor;
        ApBcountInvo: Serenity.DecimalEditor;
        ApBcountMemo: Serenity.DecimalEditor;
        ApBcountAdj: Serenity.DecimalEditor;
        ApBcountPay: Serenity.DecimalEditor;
        ApBcountAlloc: Serenity.DecimalEditor;
        CostInit: Serenity.StringEditor;
        CostBasis: Serenity.StringEditor;
        CostRmPrMul: Serenity.DecimalEditor;
        CostLbPrMul: Serenity.DecimalEditor;
        CostOvPrMul: Serenity.DecimalEditor;
        CostRmSlMul: Serenity.DecimalEditor;
        CostLbSlMul: Serenity.DecimalEditor;
        CostOvSlMul: Serenity.DecimalEditor;
        CostRevisedBy: Serenity.StringEditor;
        CostRevDate: Serenity.DateEditor;
        PrCostVerify: Serenity.StringEditor;
        PrCostEdit: Serenity.StringEditor;
        CommisType: Serenity.StringEditor;
        SlsoCustItem: Serenity.StringEditor;
        SlsoPkgType: Serenity.StringEditor;
        IcAutoShip: Serenity.StringEditor;
        IcAutoSlret: Serenity.StringEditor;
        IcAutoGrn: Serenity.StringEditor;
        IcAutoQc: Serenity.StringEditor;
        IcAutoPuret: Serenity.StringEditor;
        IcAutoWorkc: Serenity.StringEditor;
        ApOvrideRate: Serenity.StringEditor;
        SlsoSchEntry: Serenity.StringEditor;
        PupoSchEntry: Serenity.StringEditor;
        SlsoContact: Serenity.StringEditor;
        SlsoOrdrPack: Serenity.StringEditor;
        MaxUsers: Serenity.DecimalEditor;
        MmuKey: Serenity.StringEditor;
        AcctAnlys1: Serenity.StringEditor;
        AcctAnlys2: Serenity.StringEditor;
        AcctAnlys3: Serenity.StringEditor;
        AcctAnlys4: Serenity.StringEditor;
        VochAnlys1: Serenity.StringEditor;
        VochAnlys2: Serenity.StringEditor;
        VochAnlys3: Serenity.StringEditor;
        VochAnlys4: Serenity.StringEditor;
        VochAnlys5: Serenity.StringEditor;
        VochAnlys6: Serenity.StringEditor;
        ItemAnlys1: Serenity.StringEditor;
        ItemAnlys2: Serenity.StringEditor;
        ItemAnlys3: Serenity.StringEditor;
        ItemAnlys4: Serenity.StringEditor;
        CustAnlys1: Serenity.StringEditor;
        CustAnlys2: Serenity.StringEditor;
        CustAnlys3: Serenity.StringEditor;
        CustAnlys4: Serenity.StringEditor;
        VendAnlys1: Serenity.StringEditor;
        VendAnlys2: Serenity.StringEditor;
        VendAnlys3: Serenity.StringEditor;
        VendAnlys4: Serenity.StringEditor;
        SaleAnlys1: Serenity.StringEditor;
        SaleAnlys2: Serenity.StringEditor;
        SaleAnlys3: Serenity.StringEditor;
        SaleAnlys4: Serenity.StringEditor;
        SaleAnlys5: Serenity.StringEditor;
        SaleAnlys6: Serenity.StringEditor;
        PurcAnlys1: Serenity.StringEditor;
        PurcAnlys2: Serenity.StringEditor;
        PurcAnlys3: Serenity.StringEditor;
        PurcAnlys4: Serenity.StringEditor;
        PurcAnlys5: Serenity.StringEditor;
        PurcAnlys6: Serenity.StringEditor;
        MvmtAnlys1: Serenity.StringEditor;
        MvmtAnlys2: Serenity.StringEditor;
        MvmtAnlys3: Serenity.StringEditor;
        MvmtAnlys4: Serenity.StringEditor;
        MvmtAnlys5: Serenity.StringEditor;
        MvmtAnlys6: Serenity.StringEditor;
        NrevisedDate: Serenity.DateEditor;
        NrevisedBy: Serenity.StringEditor;
        ShipWtUom: Serenity.StringEditor;
        ShipDimUom: Serenity.StringEditor;
        ItemPacking: Serenity.StringEditor;
        NoOvhdAcctg: Serenity.StringEditor;
        NoVariaAcctg: Serenity.StringEditor;
        NoFgAcctg: Serenity.StringEditor;
        FgCostLimit: Serenity.StringEditor;
        AllowDescChg: Serenity.StringEditor;
        NoLaborAcctg: Serenity.StringEditor;
        NoSubconAcctg: Serenity.StringEditor;
        ReorderIsNew: Serenity.StringEditor;
        DefInspStd: Serenity.StringEditor;
        DefInspLvl: Serenity.StringEditor;
        DefAqlLvlMaj: Serenity.StringEditor;
        DefAqlLvlMin: Serenity.StringEditor;
        ReturnEmail: Serenity.StringEditor;
        SmtpServer: Serenity.StringEditor;
        WebSetting1: Serenity.StringEditor;
        WebSetting2: Serenity.StringEditor;
        WebSetting3: Serenity.StringEditor;
        WebSetting4: Serenity.StringEditor;
        PupoPriceCtrl: Serenity.StringEditor;
        JordAnlys1: Serenity.StringEditor;
        JordAnlys2: Serenity.StringEditor;
        JordAnlys3: Serenity.StringEditor;
        JordAnlys4: Serenity.StringEditor;
        JordAnlys5: Serenity.StringEditor;
        JordAnlys6: Serenity.StringEditor;
        ProdPosEntry: Serenity.StringEditor;
        GlarText1: Serenity.StringEditor;
        GlarText2: Serenity.StringEditor;
        GlarText3: Serenity.StringEditor;
        GlarText4: Serenity.StringEditor;
        PrJobClose: Serenity.StringEditor;
        SlsoUnfullPackResponse: Serenity.StringEditor;
        SlsoDefMultiShip: Serenity.StringEditor;
        SlsoDefAutoPo: Serenity.StringEditor;
        SlsoDefAutoJo: Serenity.StringEditor;
        SlpaExtDesc: Serenity.StringEditor;
        PupoDueLead: Serenity.DecimalEditor;
        PupoSchLead: Serenity.DecimalEditor;
        PrMultiIssue: Serenity.StringEditor;
        ProdSepRoute: Serenity.StringEditor;
        ProdHideWcSubcon: Serenity.StringEditor;
        CopyTextFromSo: Serenity.StringEditor;
        PrpmText1: Serenity.StringEditor;
        PrpmText2: Serenity.StringEditor;
        PrpmText3: Serenity.StringEditor;
        PrpmText4: Serenity.StringEditor;
        PrpmExtInst: Serenity.StringEditor;
        BomVerLen: Serenity.IntegerEditor;
        ProdPoPrice: Serenity.StringEditor;
        SaleAnlys7: Serenity.StringEditor;
        SaleAnlys8: Serenity.StringEditor;
        PurcAnlys7: Serenity.StringEditor;
        PurcAnlys8: Serenity.StringEditor;
        MvmtAnlys7: Serenity.StringEditor;
        MvmtAnlys8: Serenity.StringEditor;
        VochAnlys7: Serenity.StringEditor;
        VochAnlys8: Serenity.StringEditor;
        JordAnlys7: Serenity.StringEditor;
        JordAnlys8: Serenity.StringEditor;
        ArAnlys1: Serenity.StringEditor;
        ArAnlys2: Serenity.StringEditor;
        ArAnlys3: Serenity.StringEditor;
        ArAnlys4: Serenity.StringEditor;
        ArAnlys5: Serenity.StringEditor;
        ArAnlys6: Serenity.StringEditor;
        ArAnlys7: Serenity.StringEditor;
        ArAnlys8: Serenity.StringEditor;
        ApAnlys1: Serenity.StringEditor;
        ApAnlys2: Serenity.StringEditor;
        ApAnlys3: Serenity.StringEditor;
        ApAnlys4: Serenity.StringEditor;
        ApAnlys5: Serenity.StringEditor;
        ApAnlys6: Serenity.StringEditor;
        ApAnlys7: Serenity.StringEditor;
        ApAnlys8: Serenity.StringEditor;
        SlAddInfo: Serenity.StringEditor;
        PuAddInfo: Serenity.StringEditor;
        PrAddInfo: Serenity.StringEditor;
        IcAddInfo: Serenity.StringEditor;
        ChkMatIss: Serenity.StringEditor;
        IcDefStdCost: Serenity.StringEditor;
        CheckCustpo: Serenity.StringEditor;
        CtlFgRtn: Serenity.StringEditor;
        VochArRefund: Serenity.StringEditor;
        VochApRefund: Serenity.StringEditor;
        SlsoDn: Serenity.StringEditor;
        AutoIncBy: Serenity.DecimalEditor;
        QuoGenMultiSo: Serenity.StringEditor;
        PuReceiveAll: Serenity.StringEditor;
        PrpmItemMasterScrap: Serenity.StringEditor;
        IcDisableCommit: Serenity.StringEditor;
        ProdDefMatRemarks: Serenity.StringEditor;
        SlsoUpdateQtyFromSch: Serenity.StringEditor;
        PupoUpdateQtyFromSch: Serenity.StringEditor;
        SlsoDefaultBasePrice: Serenity.StringEditor;
        SlsoDiscountByCustomer: Serenity.StringEditor;
        PrpmMaxQtyInStorage: Serenity.StringEditor;
        IcDefCostType: Serenity.StringEditor;
        ProdBomCreateItem: Serenity.StringEditor;
        PupoRtvLoc: Serenity.StringEditor;
        PrpmUseAllMatLastWc: Serenity.StringEditor;
        IcNoDefCharge: Serenity.StringEditor;
        ProdDefPhantomBom: Serenity.StringEditor;
        SlsoNeedCmApproval: Serenity.StringEditor;
        PupoNeedVmApproval: Serenity.StringEditor;
        ProdNeedBomApproval: Serenity.StringEditor;
        ProdNeedImApproval: Serenity.StringEditor;
        PrpmNeedScrapReason: Serenity.StringEditor;
        PrpmMustBackflush: Serenity.StringEditor;
        PupoAutoOrderLink: Serenity.StringEditor;
        PrpmAutoOrderLink: Serenity.StringEditor;
        PrpeAllowChgJob: Serenity.StringEditor;
        VochPrInspect: Serenity.StringEditor;
        VochPrRework: Serenity.StringEditor;
        ProdNeedPlanRlseApproval: Serenity.StringEditor;
        PrpmIncludeScrapInMmi: Serenity.StringEditor;
        ProdScrapLoc: Serenity.StringEditor;
        MvtPrScrap: Serenity.StringEditor;
        SlNeedClApproval: Serenity.StringEditor;
        WarnOnMatConsum: Serenity.StringEditor;
        IcimAutogenLot: Serenity.StringEditor;
        IcimAutogenSerial: Serenity.StringEditor;
        ItemAnlys5: Serenity.StringEditor;
        ItemAnlys6: Serenity.StringEditor;
        ItemAnlys7: Serenity.StringEditor;
        ItemAnlys8: Serenity.StringEditor;
        ItemAnlys9: Serenity.StringEditor;
        ItemAnlys10: Serenity.StringEditor;
        CustAnlys5: Serenity.StringEditor;
        CustAnlys6: Serenity.StringEditor;
        CustAnlys7: Serenity.StringEditor;
        CustAnlys8: Serenity.StringEditor;
        CustAnlys9: Serenity.StringEditor;
        CustAnlys10: Serenity.StringEditor;
        VendAnlys5: Serenity.StringEditor;
        VendAnlys6: Serenity.StringEditor;
        VendAnlys7: Serenity.StringEditor;
        VendAnlys8: Serenity.StringEditor;
        VendAnlys9: Serenity.StringEditor;
        VendAnlys10: Serenity.StringEditor;
        AcctAnlys5: Serenity.StringEditor;
        AcctAnlys6: Serenity.StringEditor;
        AcctAnlys7: Serenity.StringEditor;
        AcctAnlys8: Serenity.StringEditor;
        AcctAnlys9: Serenity.StringEditor;
        AcctAnlys10: Serenity.StringEditor;
        SaleAnlys9: Serenity.StringEditor;
        SaleAnlys10: Serenity.StringEditor;
        SaleAnlys11: Serenity.StringEditor;
        SaleAnlys12: Serenity.StringEditor;
        SaleAnlys13: Serenity.StringEditor;
        SaleAnlys14: Serenity.StringEditor;
        SaleAnlys15: Serenity.StringEditor;
        SaleAnlys16: Serenity.StringEditor;
        SaleAnlys17: Serenity.StringEditor;
        SaleAnlys18: Serenity.StringEditor;
        SaleAnlys19: Serenity.StringEditor;
        SaleAnlys20: Serenity.StringEditor;
        PurcAnlys9: Serenity.StringEditor;
        PurcAnlys10: Serenity.StringEditor;
        PurcAnlys11: Serenity.StringEditor;
        PurcAnlys12: Serenity.StringEditor;
        PurcAnlys13: Serenity.StringEditor;
        PurcAnlys14: Serenity.StringEditor;
        PurcAnlys15: Serenity.StringEditor;
        PurcAnlys16: Serenity.StringEditor;
        PurcAnlys17: Serenity.StringEditor;
        PurcAnlys18: Serenity.StringEditor;
        PurcAnlys19: Serenity.StringEditor;
        PurcAnlys20: Serenity.StringEditor;
        MvmtAnlys9: Serenity.StringEditor;
        MvmtAnlys10: Serenity.StringEditor;
        MvmtAnlys11: Serenity.StringEditor;
        MvmtAnlys12: Serenity.StringEditor;
        MvmtAnlys13: Serenity.StringEditor;
        MvmtAnlys14: Serenity.StringEditor;
        MvmtAnlys15: Serenity.StringEditor;
        MvmtAnlys16: Serenity.StringEditor;
        MvmtAnlys17: Serenity.StringEditor;
        MvmtAnlys18: Serenity.StringEditor;
        MvmtAnlys19: Serenity.StringEditor;
        MvmtAnlys20: Serenity.StringEditor;
        VochAnlys9: Serenity.StringEditor;
        VochAnlys10: Serenity.StringEditor;
        VochAnlys11: Serenity.StringEditor;
        VochAnlys12: Serenity.StringEditor;
        VochAnlys13: Serenity.StringEditor;
        VochAnlys14: Serenity.StringEditor;
        VochAnlys15: Serenity.StringEditor;
        VochAnlys16: Serenity.StringEditor;
        VochAnlys17: Serenity.StringEditor;
        VochAnlys18: Serenity.StringEditor;
        VochAnlys19: Serenity.StringEditor;
        VochAnlys20: Serenity.StringEditor;
        JordAnlys9: Serenity.StringEditor;
        JordAnlys10: Serenity.StringEditor;
        JordAnlys11: Serenity.StringEditor;
        JordAnlys12: Serenity.StringEditor;
        JordAnlys13: Serenity.StringEditor;
        JordAnlys14: Serenity.StringEditor;
        JordAnlys15: Serenity.StringEditor;
        JordAnlys16: Serenity.StringEditor;
        JordAnlys17: Serenity.StringEditor;
        JordAnlys18: Serenity.StringEditor;
        JordAnlys19: Serenity.StringEditor;
        JordAnlys20: Serenity.StringEditor;
        ArAnlys9: Serenity.StringEditor;
        ArAnlys10: Serenity.StringEditor;
        ArAnlys11: Serenity.StringEditor;
        ArAnlys12: Serenity.StringEditor;
        ArAnlys13: Serenity.StringEditor;
        ArAnlys14: Serenity.StringEditor;
        ArAnlys15: Serenity.StringEditor;
        ArAnlys16: Serenity.StringEditor;
        ArAnlys17: Serenity.StringEditor;
        ArAnlys18: Serenity.StringEditor;
        ArAnlys19: Serenity.StringEditor;
        ArAnlys20: Serenity.StringEditor;
        ApAnlys9: Serenity.StringEditor;
        ApAnlys10: Serenity.StringEditor;
        ApAnlys11: Serenity.StringEditor;
        ApAnlys12: Serenity.StringEditor;
        ApAnlys13: Serenity.StringEditor;
        ApAnlys14: Serenity.StringEditor;
        ApAnlys15: Serenity.StringEditor;
        ApAnlys16: Serenity.StringEditor;
        ApAnlys17: Serenity.StringEditor;
        ApAnlys18: Serenity.StringEditor;
        ApAnlys19: Serenity.StringEditor;
        ApAnlys20: Serenity.StringEditor;
        PrpeMoldAuditTrail: Serenity.BooleanEditor;
        IcimIssueByAvailableQty: Serenity.BooleanEditor;
        PrpmJamendIssueControl: Serenity.BooleanEditor;
        PrAutoMultiSpareIssue: Serenity.BooleanEditor;
        SlShipmentPriceControl: Serenity.BooleanEditor;
        ArMultiSettle: Serenity.BooleanEditor;
        PupoDefMultiship: Serenity.BooleanEditor;
        PupoDefReorder: Serenity.BooleanEditor;
        SlsoDefReorder: Serenity.BooleanEditor;
        VochByVdate: Serenity.BooleanEditor;
        PupoTaxTerms: Serenity.BooleanEditor;
        SampleAcct: Serenity.StringEditor;
        CtlFgRtnTotQty: Serenity.BooleanEditor;
        AllowMultiWc: Serenity.BooleanEditor;
        PoaIgnoreMinQty: Serenity.BooleanEditor;
        GrnMatCost: Serenity.BooleanEditor;
        GrnLotNoImport: Serenity.BooleanEditor;
        IssueMaterialsByRouting: Serenity.BooleanEditor;
        ConsumeMatInLastRouting: Serenity.BooleanEditor;
        DefAqlLvlCritical: Serenity.StringEditor;
        DefInspLvlSp: Serenity.StringEditor;
        DefAqlLvlCriticalSp: Serenity.StringEditor;
        DefAqlLvlMajSp: Serenity.StringEditor;
        DefAqlLvlMinSp: Serenity.StringEditor;
        WcAutoMatReturn: Serenity.BooleanEditor;
        ArInvMultiPayTerms: Serenity.BooleanEditor;
        IcAdjCodeAPcent: Serenity.DecimalEditor;
        IcAdjCodeBPcent: Serenity.DecimalEditor;
        IcAdjCodeCPcent: Serenity.DecimalEditor;
        TailorIncludeJob: Serenity.BooleanEditor;
        JoMultiSource: Serenity.BooleanEditor;
        ShowShipmentInfoInPacking: Serenity.BooleanEditor;
        MrpWithReorderPt: Serenity.BooleanEditor;
        AllowFollowListWithoutMi: Serenity.BooleanEditor;
        PrMultiFollowList: Serenity.BooleanEditor;
        SqietkMatBalSubtractCommit: Serenity.BooleanEditor;
        SoLineAutoIncBy: Serenity.DecimalEditor;
        PoLineAutoIncBy: Serenity.DecimalEditor;
        PuOverRcptByLine: Serenity.BooleanEditor;
        PuLmeCost: Serenity.BooleanEditor;
        SoaUpdatePendingShipment: Serenity.BooleanEditor;
        PrMatIssueOnAvailPercent: Serenity.DecimalEditor;
        JobHourlyRate: Serenity.DecimalEditor;
        ItemCustomProdCodeRequired: Serenity.BooleanEditor;
        IcimAutogenLotIssue: Serenity.BooleanEditor;
        IcimAutogenSerialIssue: Serenity.BooleanEditor;
        ShipmentInfoFromFirstOrder: Serenity.BooleanEditor;
        MrpExcludeLeadtime: Serenity.BooleanEditor;
        ItemPrelotSopo: Serenity.BooleanEditor;
        SlsoCtrlBtmCeil: Serenity.BooleanEditor;
        WcOverAcceptedLot: Serenity.BooleanEditor;
        SlsoAutoResv: Serenity.BooleanEditor;
        PercentA: Serenity.DecimalEditor;
        PercentB: Serenity.DecimalEditor;
        PercentC: Serenity.DecimalEditor;
        EntryPostedRequirdBeforePrint: Serenity.StringEditor;
    }

    [['SlInit', () => Serenity.StringEditor]
   , ['SlsoMultiship', () => Serenity.StringEditor]
   , ['SlsoResv', () => Serenity.StringEditor]
   , ['SlsoAssortment', () => Serenity.StringEditor]
   , ['SlsoDeposits', () => Serenity.StringEditor]
   , ['SlsoMeasures', () => Serenity.StringEditor]
   , ['SlsoPtax', () => Serenity.StringEditor]
   , ['SlsoAtax', () => Serenity.StringEditor]
   , ['SlsoGtax', () => Serenity.StringEditor]
   , ['SlsoLineDisc', () => Serenity.StringEditor]
   , ['SlsoAutoPo', () => Serenity.StringEditor]
   , ['SlsoAutoJob', () => Serenity.StringEditor]
   , ['SlsoExtInst', () => Serenity.StringEditor]
   , ['SlsoExtDesc', () => Serenity.StringEditor]
   , ['SlsoFixedUom', () => Serenity.StringEditor]
   , ['SlsoReqSman', () => Serenity.StringEditor]
   , ['SlsoSman', () => Serenity.StringEditor]
   , ['SlsoText1', () => Serenity.StringEditor]
   , ['SlsoText2', () => Serenity.StringEditor]
   , ['SlsoText3', () => Serenity.StringEditor]
   , ['SlsoText4', () => Serenity.StringEditor]
   , ['SlsoDueLead', () => Serenity.DecimalEditor]
   , ['SlsoSchLead', () => Serenity.DecimalEditor]
   , ['SlsoAddrCode', () => Serenity.StringEditor]
   , ['SlsoAddrType', () => Serenity.StringEditor]
   , ['SlsoQuoteDays', () => Serenity.DecimalEditor]
   , ['SlshCutDays', () => Serenity.DecimalEditor]
   , ['SlsoShipVia', () => Serenity.StringEditor]
   , ['SlsoShipTerms', () => Serenity.StringEditor]
   , ['SlRevisedDate', () => Serenity.DateEditor]
   , ['SlRevisedBy', () => Serenity.StringEditor]
   , ['PuInit', () => Serenity.StringEditor]
   , ['PupoMultiship', () => Serenity.StringEditor]
   , ['PupoDeposits', () => Serenity.StringEditor]
   , ['PupoMeasures', () => Serenity.StringEditor]
   , ['PupoPtax', () => Serenity.StringEditor]
   , ['PupoAtax', () => Serenity.StringEditor]
   , ['PupoGtax', () => Serenity.StringEditor]
   , ['PupoLineDisc', () => Serenity.StringEditor]
   , ['PupoExtInst', () => Serenity.StringEditor]
   , ['PupoExtDesc', () => Serenity.StringEditor]
   , ['PupoFixedUom', () => Serenity.StringEditor]
   , ['PupoText1', () => Serenity.StringEditor]
   , ['PupoText2', () => Serenity.StringEditor]
   , ['PupoText3', () => Serenity.StringEditor]
   , ['PupoText4', () => Serenity.StringEditor]
   , ['PupoCutDays', () => Serenity.DecimalEditor]
   , ['PupoReorder', () => Serenity.StringEditor]
   , ['PupoReqBuyer', () => Serenity.StringEditor]
   , ['PupoBuyer', () => Serenity.StringEditor]
   , ['PupoShipVia', () => Serenity.StringEditor]
   , ['PupoShipTerms', () => Serenity.StringEditor]
   , ['PuRevisedDate', () => Serenity.DateEditor]
   , ['PuRevisedBy', () => Serenity.StringEditor]
   , ['ProdInit', () => Serenity.StringEditor]
   , ['ProdEcnReq', () => Serenity.StringEditor]
   , ['ProdByprod', () => Serenity.StringEditor]
   , ['ProdScrapRate', () => Serenity.DecimalEditor]
   , ['ProdPictDesc1', () => Serenity.StringEditor]
   , ['ProdPictDesc2', () => Serenity.StringEditor]
   , ['ProdPictDesc3', () => Serenity.StringEditor]
   , ['ProdPictDesc4', () => Serenity.StringEditor]
   , ['ProdWeightUom', () => Serenity.StringEditor]
   , ['ProdDimenUom', () => Serenity.StringEditor]
   , ['ProdFixedWtum', () => Serenity.StringEditor]
   , ['ProdFixedDmum', () => Serenity.StringEditor]
   , ['ProdStdLsize', () => Serenity.DecimalEditor]
   , ['ProdMinLsize', () => Serenity.DecimalEditor]
   , ['ProdMaxLsize', () => Serenity.DecimalEditor]
   , ['ProdStdOutput', () => Serenity.DecimalEditor]
   , ['PrRevisedDate', () => Serenity.DateEditor]
   , ['PrRevisedBy', () => Serenity.StringEditor]
   , ['ShopReqJcat', () => Serenity.StringEditor]
   , ['ShopWksCover', () => Serenity.DecimalEditor]
   , ['ShopPlanner', () => Serenity.StringEditor]
   , ['ShopDefPlnr', () => Serenity.StringEditor]
   , ['ShopMpsHorz', () => Serenity.DecimalEditor]
   , ['ShopPurLtime', () => Serenity.DecimalEditor]
   , ['ShopPurLunit', () => Serenity.StringEditor]
   , ['ShopJobCat', () => Serenity.StringEditor]
   , ['ShopMrpHorz', () => Serenity.DecimalEditor]
   , ['ShRevisedDate', () => Serenity.DateEditor]
   , ['ShRevisedBy', () => Serenity.StringEditor]
   , ['MrpCount', () => Serenity.DecimalEditor]
   , ['MrpRefNo', () => Serenity.StringEditor]
   , ['MrpRunDate', () => Serenity.DateEditor]
   , ['MrpHorzDate', () => Serenity.DateEditor]
   , ['IcInit', () => Serenity.StringEditor]
   , ['IcReceipts', () => Serenity.StringEditor]
   , ['IcIssuance', () => Serenity.StringEditor]
   , ['IcTransfer', () => Serenity.StringEditor]
   , ['IcAdjustment', () => Serenity.StringEditor]
   , ['IcRevisedDate', () => Serenity.DateEditor]
   , ['IcRevisedBy', () => Serenity.StringEditor]
   , ['PrJobSched', () => Serenity.StringEditor]
   , ['PrByProd', () => Serenity.StringEditor]
   , ['PrJobBatches', () => Serenity.StringEditor]
   , ['LastResvNo', () => Serenity.DecimalEditor]
   , ['NoMrpFence', () => Serenity.StringEditor]
   , ['MvtRmIssue', () => Serenity.StringEditor]
   , ['MvtSpIssue', () => Serenity.StringEditor]
   , ['MvtFgReturn', () => Serenity.StringEditor]
   , ['MvtRmReturn', () => Serenity.StringEditor]
   , ['MvtSlShipment', () => Serenity.StringEditor]
   , ['MvtSlReturn', () => Serenity.StringEditor]
   , ['MvtPuReceipt', () => Serenity.StringEditor]
   , ['MvtPuInspect', () => Serenity.StringEditor]
   , ['MvtPuReturn', () => Serenity.StringEditor]
   , ['GlInit', () => Serenity.StringEditor]
   , ['GlHdrTxt', () => Serenity.StringEditor]
   , ['GlDtlTxt', () => Serenity.StringEditor]
   , ['GlRefEntry', () => Serenity.StringEditor]
   , ['GlRefLabel', () => Serenity.StringEditor]
   , ['GlLrefEntry', () => Serenity.StringEditor]
   , ['GlLrefLabel', () => Serenity.StringEditor]
   , ['GlExchComp', () => Serenity.StringEditor]
   , ['GlRevisedBy', () => Serenity.StringEditor]
   , ['GlRevisedDate', () => Serenity.DateEditor]
   , ['VochArInvo', () => Serenity.StringEditor]
   , ['VochArMemo', () => Serenity.StringEditor]
   , ['VochArAdj', () => Serenity.StringEditor]
   , ['VochArPay', () => Serenity.StringEditor]
   , ['VochArAlloc', () => Serenity.StringEditor]
   , ['VochArInvocan', () => Serenity.StringEditor]
   , ['VochArPaycan', () => Serenity.StringEditor]
   , ['VochApInvo', () => Serenity.StringEditor]
   , ['VochApMemo', () => Serenity.StringEditor]
   , ['VochApAdj', () => Serenity.StringEditor]
   , ['VochApPay', () => Serenity.StringEditor]
   , ['VochApAlloc', () => Serenity.StringEditor]
   , ['VochApInvocan', () => Serenity.StringEditor]
   , ['VochApPaycan', () => Serenity.StringEditor]
   , ['VochIcIssue', () => Serenity.StringEditor]
   , ['VochIcRcpt', () => Serenity.StringEditor]
   , ['VochIcAdj', () => Serenity.StringEditor]
   , ['VochPrIssue', () => Serenity.StringEditor]
   , ['VochPrReturn', () => Serenity.StringEditor]
   , ['VochPrProd', () => Serenity.StringEditor]
   , ['VochPrSubcon', () => Serenity.StringEditor]
   , ['VochPayroll', () => Serenity.StringEditor]
   , ['VochCommission', () => Serenity.StringEditor]
   , ['VochFaAcquire', () => Serenity.StringEditor]
   , ['VochFaDeprec', () => Serenity.StringEditor]
   , ['VochFaMaint', () => Serenity.StringEditor]
   , ['VochFaDispo', () => Serenity.StringEditor]
   , ['ArBcountInvo', () => Serenity.DecimalEditor]
   , ['ArBcountMemo', () => Serenity.DecimalEditor]
   , ['ArBcountAdj', () => Serenity.DecimalEditor]
   , ['ArBcountPay', () => Serenity.DecimalEditor]
   , ['ArBcountAlloc', () => Serenity.DecimalEditor]
   , ['ApBcountInvo', () => Serenity.DecimalEditor]
   , ['ApBcountMemo', () => Serenity.DecimalEditor]
   , ['ApBcountAdj', () => Serenity.DecimalEditor]
   , ['ApBcountPay', () => Serenity.DecimalEditor]
   , ['ApBcountAlloc', () => Serenity.DecimalEditor]
   , ['CostInit', () => Serenity.StringEditor]
   , ['CostBasis', () => Serenity.StringEditor]
   , ['CostRmPrMul', () => Serenity.DecimalEditor]
   , ['CostLbPrMul', () => Serenity.DecimalEditor]
   , ['CostOvPrMul', () => Serenity.DecimalEditor]
   , ['CostRmSlMul', () => Serenity.DecimalEditor]
   , ['CostLbSlMul', () => Serenity.DecimalEditor]
   , ['CostOvSlMul', () => Serenity.DecimalEditor]
   , ['CostRevisedBy', () => Serenity.StringEditor]
   , ['CostRevDate', () => Serenity.DateEditor]
   , ['PrCostVerify', () => Serenity.StringEditor]
   , ['PrCostEdit', () => Serenity.StringEditor]
   , ['CommisType', () => Serenity.StringEditor]
   , ['SlsoCustItem', () => Serenity.StringEditor]
   , ['SlsoPkgType', () => Serenity.StringEditor]
   , ['IcAutoShip', () => Serenity.StringEditor]
   , ['IcAutoSlret', () => Serenity.StringEditor]
   , ['IcAutoGrn', () => Serenity.StringEditor]
   , ['IcAutoQc', () => Serenity.StringEditor]
   , ['IcAutoPuret', () => Serenity.StringEditor]
   , ['IcAutoWorkc', () => Serenity.StringEditor]
   , ['ApOvrideRate', () => Serenity.StringEditor]
   , ['SlsoSchEntry', () => Serenity.StringEditor]
   , ['PupoSchEntry', () => Serenity.StringEditor]
   , ['SlsoContact', () => Serenity.StringEditor]
   , ['SlsoOrdrPack', () => Serenity.StringEditor]
   , ['MaxUsers', () => Serenity.DecimalEditor]
   , ['MmuKey', () => Serenity.StringEditor]
   , ['AcctAnlys1', () => Serenity.StringEditor]
   , ['AcctAnlys2', () => Serenity.StringEditor]
   , ['AcctAnlys3', () => Serenity.StringEditor]
   , ['AcctAnlys4', () => Serenity.StringEditor]
   , ['VochAnlys1', () => Serenity.StringEditor]
   , ['VochAnlys2', () => Serenity.StringEditor]
   , ['VochAnlys3', () => Serenity.StringEditor]
   , ['VochAnlys4', () => Serenity.StringEditor]
   , ['VochAnlys5', () => Serenity.StringEditor]
   , ['VochAnlys6', () => Serenity.StringEditor]
   , ['ItemAnlys1', () => Serenity.StringEditor]
   , ['ItemAnlys2', () => Serenity.StringEditor]
   , ['ItemAnlys3', () => Serenity.StringEditor]
   , ['ItemAnlys4', () => Serenity.StringEditor]
   , ['CustAnlys1', () => Serenity.StringEditor]
   , ['CustAnlys2', () => Serenity.StringEditor]
   , ['CustAnlys3', () => Serenity.StringEditor]
   , ['CustAnlys4', () => Serenity.StringEditor]
   , ['VendAnlys1', () => Serenity.StringEditor]
   , ['VendAnlys2', () => Serenity.StringEditor]
   , ['VendAnlys3', () => Serenity.StringEditor]
   , ['VendAnlys4', () => Serenity.StringEditor]
   , ['SaleAnlys1', () => Serenity.StringEditor]
   , ['SaleAnlys2', () => Serenity.StringEditor]
   , ['SaleAnlys3', () => Serenity.StringEditor]
   , ['SaleAnlys4', () => Serenity.StringEditor]
   , ['SaleAnlys5', () => Serenity.StringEditor]
   , ['SaleAnlys6', () => Serenity.StringEditor]
   , ['PurcAnlys1', () => Serenity.StringEditor]
   , ['PurcAnlys2', () => Serenity.StringEditor]
   , ['PurcAnlys3', () => Serenity.StringEditor]
   , ['PurcAnlys4', () => Serenity.StringEditor]
   , ['PurcAnlys5', () => Serenity.StringEditor]
   , ['PurcAnlys6', () => Serenity.StringEditor]
   , ['MvmtAnlys1', () => Serenity.StringEditor]
   , ['MvmtAnlys2', () => Serenity.StringEditor]
   , ['MvmtAnlys3', () => Serenity.StringEditor]
   , ['MvmtAnlys4', () => Serenity.StringEditor]
   , ['MvmtAnlys5', () => Serenity.StringEditor]
   , ['MvmtAnlys6', () => Serenity.StringEditor]
   , ['NrevisedDate', () => Serenity.DateEditor]
   , ['NrevisedBy', () => Serenity.StringEditor]
   , ['ShipWtUom', () => Serenity.StringEditor]
   , ['ShipDimUom', () => Serenity.StringEditor]
   , ['ItemPacking', () => Serenity.StringEditor]
   , ['NoOvhdAcctg', () => Serenity.StringEditor]
   , ['NoVariaAcctg', () => Serenity.StringEditor]
   , ['NoFgAcctg', () => Serenity.StringEditor]
   , ['FgCostLimit', () => Serenity.StringEditor]
   , ['AllowDescChg', () => Serenity.StringEditor]
   , ['NoLaborAcctg', () => Serenity.StringEditor]
   , ['NoSubconAcctg', () => Serenity.StringEditor]
   , ['ReorderIsNew', () => Serenity.StringEditor]
   , ['DefInspStd', () => Serenity.StringEditor]
   , ['DefInspLvl', () => Serenity.StringEditor]
   , ['DefAqlLvlMaj', () => Serenity.StringEditor]
   , ['DefAqlLvlMin', () => Serenity.StringEditor]
   , ['ReturnEmail', () => Serenity.StringEditor]
   , ['SmtpServer', () => Serenity.StringEditor]
   , ['WebSetting1', () => Serenity.StringEditor]
   , ['WebSetting2', () => Serenity.StringEditor]
   , ['WebSetting3', () => Serenity.StringEditor]
   , ['WebSetting4', () => Serenity.StringEditor]
   , ['PupoPriceCtrl', () => Serenity.StringEditor]
   , ['JordAnlys1', () => Serenity.StringEditor]
   , ['JordAnlys2', () => Serenity.StringEditor]
   , ['JordAnlys3', () => Serenity.StringEditor]
   , ['JordAnlys4', () => Serenity.StringEditor]
   , ['JordAnlys5', () => Serenity.StringEditor]
   , ['JordAnlys6', () => Serenity.StringEditor]
   , ['ProdPosEntry', () => Serenity.StringEditor]
   , ['GlarText1', () => Serenity.StringEditor]
   , ['GlarText2', () => Serenity.StringEditor]
   , ['GlarText3', () => Serenity.StringEditor]
   , ['GlarText4', () => Serenity.StringEditor]
   , ['PrJobClose', () => Serenity.StringEditor]
   , ['SlsoUnfullPackResponse', () => Serenity.StringEditor]
   , ['SlsoDefMultiShip', () => Serenity.StringEditor]
   , ['SlsoDefAutoPo', () => Serenity.StringEditor]
   , ['SlsoDefAutoJo', () => Serenity.StringEditor]
   , ['SlpaExtDesc', () => Serenity.StringEditor]
   , ['PupoDueLead', () => Serenity.DecimalEditor]
   , ['PupoSchLead', () => Serenity.DecimalEditor]
   , ['PrMultiIssue', () => Serenity.StringEditor]
   , ['ProdSepRoute', () => Serenity.StringEditor]
   , ['ProdHideWcSubcon', () => Serenity.StringEditor]
   , ['CopyTextFromSo', () => Serenity.StringEditor]
   , ['PrpmText1', () => Serenity.StringEditor]
   , ['PrpmText2', () => Serenity.StringEditor]
   , ['PrpmText3', () => Serenity.StringEditor]
   , ['PrpmText4', () => Serenity.StringEditor]
   , ['PrpmExtInst', () => Serenity.StringEditor]
   , ['BomVerLen', () => Serenity.IntegerEditor]
   , ['ProdPoPrice', () => Serenity.StringEditor]
   , ['SaleAnlys7', () => Serenity.StringEditor]
   , ['SaleAnlys8', () => Serenity.StringEditor]
   , ['PurcAnlys7', () => Serenity.StringEditor]
   , ['PurcAnlys8', () => Serenity.StringEditor]
   , ['MvmtAnlys7', () => Serenity.StringEditor]
   , ['MvmtAnlys8', () => Serenity.StringEditor]
   , ['VochAnlys7', () => Serenity.StringEditor]
   , ['VochAnlys8', () => Serenity.StringEditor]
   , ['JordAnlys7', () => Serenity.StringEditor]
   , ['JordAnlys8', () => Serenity.StringEditor]
   , ['ArAnlys1', () => Serenity.StringEditor]
   , ['ArAnlys2', () => Serenity.StringEditor]
   , ['ArAnlys3', () => Serenity.StringEditor]
   , ['ArAnlys4', () => Serenity.StringEditor]
   , ['ArAnlys5', () => Serenity.StringEditor]
   , ['ArAnlys6', () => Serenity.StringEditor]
   , ['ArAnlys7', () => Serenity.StringEditor]
   , ['ArAnlys8', () => Serenity.StringEditor]
   , ['ApAnlys1', () => Serenity.StringEditor]
   , ['ApAnlys2', () => Serenity.StringEditor]
   , ['ApAnlys3', () => Serenity.StringEditor]
   , ['ApAnlys4', () => Serenity.StringEditor]
   , ['ApAnlys5', () => Serenity.StringEditor]
   , ['ApAnlys6', () => Serenity.StringEditor]
   , ['ApAnlys7', () => Serenity.StringEditor]
   , ['ApAnlys8', () => Serenity.StringEditor]
   , ['SlAddInfo', () => Serenity.StringEditor]
   , ['PuAddInfo', () => Serenity.StringEditor]
   , ['PrAddInfo', () => Serenity.StringEditor]
   , ['IcAddInfo', () => Serenity.StringEditor]
   , ['ChkMatIss', () => Serenity.StringEditor]
   , ['IcDefStdCost', () => Serenity.StringEditor]
   , ['CheckCustpo', () => Serenity.StringEditor]
   , ['CtlFgRtn', () => Serenity.StringEditor]
   , ['VochArRefund', () => Serenity.StringEditor]
   , ['VochApRefund', () => Serenity.StringEditor]
   , ['SlsoDn', () => Serenity.StringEditor]
   , ['AutoIncBy', () => Serenity.DecimalEditor]
   , ['QuoGenMultiSo', () => Serenity.StringEditor]
   , ['PuReceiveAll', () => Serenity.StringEditor]
   , ['PrpmItemMasterScrap', () => Serenity.StringEditor]
   , ['IcDisableCommit', () => Serenity.StringEditor]
   , ['ProdDefMatRemarks', () => Serenity.StringEditor]
   , ['SlsoUpdateQtyFromSch', () => Serenity.StringEditor]
   , ['PupoUpdateQtyFromSch', () => Serenity.StringEditor]
   , ['SlsoDefaultBasePrice', () => Serenity.StringEditor]
   , ['SlsoDiscountByCustomer', () => Serenity.StringEditor]
   , ['PrpmMaxQtyInStorage', () => Serenity.StringEditor]
   , ['IcDefCostType', () => Serenity.StringEditor]
   , ['ProdBomCreateItem', () => Serenity.StringEditor]
   , ['PupoRtvLoc', () => Serenity.StringEditor]
   , ['PrpmUseAllMatLastWc', () => Serenity.StringEditor]
   , ['IcNoDefCharge', () => Serenity.StringEditor]
   , ['ProdDefPhantomBom', () => Serenity.StringEditor]
   , ['SlsoNeedCmApproval', () => Serenity.StringEditor]
   , ['PupoNeedVmApproval', () => Serenity.StringEditor]
   , ['ProdNeedBomApproval', () => Serenity.StringEditor]
   , ['ProdNeedImApproval', () => Serenity.StringEditor]
   , ['PrpmNeedScrapReason', () => Serenity.StringEditor]
   , ['PrpmMustBackflush', () => Serenity.StringEditor]
   , ['PupoAutoOrderLink', () => Serenity.StringEditor]
   , ['PrpmAutoOrderLink', () => Serenity.StringEditor]
   , ['PrpeAllowChgJob', () => Serenity.StringEditor]
   , ['VochPrInspect', () => Serenity.StringEditor]
   , ['VochPrRework', () => Serenity.StringEditor]
   , ['ProdNeedPlanRlseApproval', () => Serenity.StringEditor]
   , ['PrpmIncludeScrapInMmi', () => Serenity.StringEditor]
   , ['ProdScrapLoc', () => Serenity.StringEditor]
   , ['MvtPrScrap', () => Serenity.StringEditor]
   , ['SlNeedClApproval', () => Serenity.StringEditor]
   , ['WarnOnMatConsum', () => Serenity.StringEditor]
   , ['IcimAutogenLot', () => Serenity.StringEditor]
   , ['IcimAutogenSerial', () => Serenity.StringEditor]
   , ['ItemAnlys5', () => Serenity.StringEditor]
   , ['ItemAnlys6', () => Serenity.StringEditor]
   , ['ItemAnlys7', () => Serenity.StringEditor]
   , ['ItemAnlys8', () => Serenity.StringEditor]
   , ['ItemAnlys9', () => Serenity.StringEditor]
   , ['ItemAnlys10', () => Serenity.StringEditor]
   , ['CustAnlys5', () => Serenity.StringEditor]
   , ['CustAnlys6', () => Serenity.StringEditor]
   , ['CustAnlys7', () => Serenity.StringEditor]
   , ['CustAnlys8', () => Serenity.StringEditor]
   , ['CustAnlys9', () => Serenity.StringEditor]
   , ['CustAnlys10', () => Serenity.StringEditor]
   , ['VendAnlys5', () => Serenity.StringEditor]
   , ['VendAnlys6', () => Serenity.StringEditor]
   , ['VendAnlys7', () => Serenity.StringEditor]
   , ['VendAnlys8', () => Serenity.StringEditor]
   , ['VendAnlys9', () => Serenity.StringEditor]
   , ['VendAnlys10', () => Serenity.StringEditor]
   , ['AcctAnlys5', () => Serenity.StringEditor]
   , ['AcctAnlys6', () => Serenity.StringEditor]
   , ['AcctAnlys7', () => Serenity.StringEditor]
   , ['AcctAnlys8', () => Serenity.StringEditor]
   , ['AcctAnlys9', () => Serenity.StringEditor]
   , ['AcctAnlys10', () => Serenity.StringEditor]
   , ['SaleAnlys9', () => Serenity.StringEditor]
   , ['SaleAnlys10', () => Serenity.StringEditor]
   , ['SaleAnlys11', () => Serenity.StringEditor]
   , ['SaleAnlys12', () => Serenity.StringEditor]
   , ['SaleAnlys13', () => Serenity.StringEditor]
   , ['SaleAnlys14', () => Serenity.StringEditor]
   , ['SaleAnlys15', () => Serenity.StringEditor]
   , ['SaleAnlys16', () => Serenity.StringEditor]
   , ['SaleAnlys17', () => Serenity.StringEditor]
   , ['SaleAnlys18', () => Serenity.StringEditor]
   , ['SaleAnlys19', () => Serenity.StringEditor]
   , ['SaleAnlys20', () => Serenity.StringEditor]
   , ['PurcAnlys9', () => Serenity.StringEditor]
   , ['PurcAnlys10', () => Serenity.StringEditor]
   , ['PurcAnlys11', () => Serenity.StringEditor]
   , ['PurcAnlys12', () => Serenity.StringEditor]
   , ['PurcAnlys13', () => Serenity.StringEditor]
   , ['PurcAnlys14', () => Serenity.StringEditor]
   , ['PurcAnlys15', () => Serenity.StringEditor]
   , ['PurcAnlys16', () => Serenity.StringEditor]
   , ['PurcAnlys17', () => Serenity.StringEditor]
   , ['PurcAnlys18', () => Serenity.StringEditor]
   , ['PurcAnlys19', () => Serenity.StringEditor]
   , ['PurcAnlys20', () => Serenity.StringEditor]
   , ['MvmtAnlys9', () => Serenity.StringEditor]
   , ['MvmtAnlys10', () => Serenity.StringEditor]
   , ['MvmtAnlys11', () => Serenity.StringEditor]
   , ['MvmtAnlys12', () => Serenity.StringEditor]
   , ['MvmtAnlys13', () => Serenity.StringEditor]
   , ['MvmtAnlys14', () => Serenity.StringEditor]
   , ['MvmtAnlys15', () => Serenity.StringEditor]
   , ['MvmtAnlys16', () => Serenity.StringEditor]
   , ['MvmtAnlys17', () => Serenity.StringEditor]
   , ['MvmtAnlys18', () => Serenity.StringEditor]
   , ['MvmtAnlys19', () => Serenity.StringEditor]
   , ['MvmtAnlys20', () => Serenity.StringEditor]
   , ['VochAnlys9', () => Serenity.StringEditor]
   , ['VochAnlys10', () => Serenity.StringEditor]
   , ['VochAnlys11', () => Serenity.StringEditor]
   , ['VochAnlys12', () => Serenity.StringEditor]
   , ['VochAnlys13', () => Serenity.StringEditor]
   , ['VochAnlys14', () => Serenity.StringEditor]
   , ['VochAnlys15', () => Serenity.StringEditor]
   , ['VochAnlys16', () => Serenity.StringEditor]
   , ['VochAnlys17', () => Serenity.StringEditor]
   , ['VochAnlys18', () => Serenity.StringEditor]
   , ['VochAnlys19', () => Serenity.StringEditor]
   , ['VochAnlys20', () => Serenity.StringEditor]
   , ['JordAnlys9', () => Serenity.StringEditor]
   , ['JordAnlys10', () => Serenity.StringEditor]
   , ['JordAnlys11', () => Serenity.StringEditor]
   , ['JordAnlys12', () => Serenity.StringEditor]
   , ['JordAnlys13', () => Serenity.StringEditor]
   , ['JordAnlys14', () => Serenity.StringEditor]
   , ['JordAnlys15', () => Serenity.StringEditor]
   , ['JordAnlys16', () => Serenity.StringEditor]
   , ['JordAnlys17', () => Serenity.StringEditor]
   , ['JordAnlys18', () => Serenity.StringEditor]
   , ['JordAnlys19', () => Serenity.StringEditor]
   , ['JordAnlys20', () => Serenity.StringEditor]
   , ['ArAnlys9', () => Serenity.StringEditor]
   , ['ArAnlys10', () => Serenity.StringEditor]
   , ['ArAnlys11', () => Serenity.StringEditor]
   , ['ArAnlys12', () => Serenity.StringEditor]
   , ['ArAnlys13', () => Serenity.StringEditor]
   , ['ArAnlys14', () => Serenity.StringEditor]
   , ['ArAnlys15', () => Serenity.StringEditor]
   , ['ArAnlys16', () => Serenity.StringEditor]
   , ['ArAnlys17', () => Serenity.StringEditor]
   , ['ArAnlys18', () => Serenity.StringEditor]
   , ['ArAnlys19', () => Serenity.StringEditor]
   , ['ArAnlys20', () => Serenity.StringEditor]
   , ['ApAnlys9', () => Serenity.StringEditor]
   , ['ApAnlys10', () => Serenity.StringEditor]
   , ['ApAnlys11', () => Serenity.StringEditor]
   , ['ApAnlys12', () => Serenity.StringEditor]
   , ['ApAnlys13', () => Serenity.StringEditor]
   , ['ApAnlys14', () => Serenity.StringEditor]
   , ['ApAnlys15', () => Serenity.StringEditor]
   , ['ApAnlys16', () => Serenity.StringEditor]
   , ['ApAnlys17', () => Serenity.StringEditor]
   , ['ApAnlys18', () => Serenity.StringEditor]
   , ['ApAnlys19', () => Serenity.StringEditor]
   , ['ApAnlys20', () => Serenity.StringEditor]
   , ['PrpeMoldAuditTrail', () => Serenity.BooleanEditor]
   , ['IcimIssueByAvailableQty', () => Serenity.BooleanEditor]
   , ['PrpmJamendIssueControl', () => Serenity.BooleanEditor]
   , ['PrAutoMultiSpareIssue', () => Serenity.BooleanEditor]
   , ['SlShipmentPriceControl', () => Serenity.BooleanEditor]
   , ['ArMultiSettle', () => Serenity.BooleanEditor]
   , ['PupoDefMultiship', () => Serenity.BooleanEditor]
   , ['PupoDefReorder', () => Serenity.BooleanEditor]
   , ['SlsoDefReorder', () => Serenity.BooleanEditor]
   , ['VochByVdate', () => Serenity.BooleanEditor]
   , ['PupoTaxTerms', () => Serenity.BooleanEditor]
   , ['SampleAcct', () => Serenity.StringEditor]
   , ['CtlFgRtnTotQty', () => Serenity.BooleanEditor]
   , ['AllowMultiWc', () => Serenity.BooleanEditor]
   , ['PoaIgnoreMinQty', () => Serenity.BooleanEditor]
   , ['GrnMatCost', () => Serenity.BooleanEditor]
   , ['GrnLotNoImport', () => Serenity.BooleanEditor]
   , ['IssueMaterialsByRouting', () => Serenity.BooleanEditor]
   , ['ConsumeMatInLastRouting', () => Serenity.BooleanEditor]
   , ['DefAqlLvlCritical', () => Serenity.StringEditor]
   , ['DefInspLvlSp', () => Serenity.StringEditor]
   , ['DefAqlLvlCriticalSp', () => Serenity.StringEditor]
   , ['DefAqlLvlMajSp', () => Serenity.StringEditor]
   , ['DefAqlLvlMinSp', () => Serenity.StringEditor]
   , ['WcAutoMatReturn', () => Serenity.BooleanEditor]
   , ['ArInvMultiPayTerms', () => Serenity.BooleanEditor]
   , ['IcAdjCodeAPcent', () => Serenity.DecimalEditor]
   , ['IcAdjCodeBPcent', () => Serenity.DecimalEditor]
   , ['IcAdjCodeCPcent', () => Serenity.DecimalEditor]
   , ['TailorIncludeJob', () => Serenity.BooleanEditor]
   , ['JoMultiSource', () => Serenity.BooleanEditor]
   , ['ShowShipmentInfoInPacking', () => Serenity.BooleanEditor]
   , ['MrpWithReorderPt', () => Serenity.BooleanEditor]
   , ['AllowFollowListWithoutMi', () => Serenity.BooleanEditor]
   , ['PrMultiFollowList', () => Serenity.BooleanEditor]
   , ['SqietkMatBalSubtractCommit', () => Serenity.BooleanEditor]
   , ['SoLineAutoIncBy', () => Serenity.DecimalEditor]
   , ['PoLineAutoIncBy', () => Serenity.DecimalEditor]
   , ['PuOverRcptByLine', () => Serenity.BooleanEditor]
   , ['PuLmeCost', () => Serenity.BooleanEditor]
   , ['SoaUpdatePendingShipment', () => Serenity.BooleanEditor]
   , ['PrMatIssueOnAvailPercent', () => Serenity.DecimalEditor]
   , ['JobHourlyRate', () => Serenity.DecimalEditor]
   , ['ItemCustomProdCodeRequired', () => Serenity.BooleanEditor]
   , ['IcimAutogenLotIssue', () => Serenity.BooleanEditor]
   , ['IcimAutogenSerialIssue', () => Serenity.BooleanEditor]
   , ['ShipmentInfoFromFirstOrder', () => Serenity.BooleanEditor]
   , ['MrpExcludeLeadtime', () => Serenity.BooleanEditor]
   , ['ItemPrelotSopo', () => Serenity.BooleanEditor]
   , ['SlsoCtrlBtmCeil', () => Serenity.BooleanEditor]
   , ['WcOverAcceptedLot', () => Serenity.BooleanEditor]
   , ['SlsoAutoResv', () => Serenity.BooleanEditor]
   , ['PercentA', () => Serenity.DecimalEditor]
   , ['PercentB', () => Serenity.DecimalEditor]
   , ['PercentC', () => Serenity.DecimalEditor]
   , ['EntryPostedRequirdBeforePrint', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(CompanySettingForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

