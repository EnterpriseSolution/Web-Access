namespace Matrix.Basic {
    export interface CompanySettingRow {
        Recnum?: number;
        SlInit?: string;
        SlsoMultiship?: string;
        SlsoResv?: string;
        SlsoAssortment?: string;
        SlsoDeposits?: string;
        SlsoMeasures?: string;
        SlsoPtax?: string;
        SlsoAtax?: string;
        SlsoGtax?: string;
        SlsoLineDisc?: string;
        SlsoAutoPo?: string;
        SlsoAutoJob?: string;
        SlsoExtInst?: string;
        SlsoExtDesc?: string;
        SlsoFixedUom?: string;
        SlsoReqSman?: string;
        SlsoSman?: string;
        SlsoText1?: string;
        SlsoText2?: string;
        SlsoText3?: string;
        SlsoText4?: string;
        SlsoDueLead?: number;
        SlsoSchLead?: number;
        SlsoAddrCode?: string;
        SlsoAddrType?: string;
        SlsoQuoteDays?: number;
        SlshCutDays?: number;
        SlsoShipVia?: string;
        SlsoShipTerms?: string;
        SlRevisedDate?: string;
        SlRevisedBy?: string;
        PuInit?: string;
        PupoMultiship?: string;
        PupoDeposits?: string;
        PupoMeasures?: string;
        PupoPtax?: string;
        PupoAtax?: string;
        PupoGtax?: string;
        PupoLineDisc?: string;
        PupoExtInst?: string;
        PupoExtDesc?: string;
        PupoFixedUom?: string;
        PupoText1?: string;
        PupoText2?: string;
        PupoText3?: string;
        PupoText4?: string;
        PupoCutDays?: number;
        PupoReorder?: string;
        PupoReqBuyer?: string;
        PupoBuyer?: string;
        PupoShipVia?: string;
        PupoShipTerms?: string;
        PuRevisedDate?: string;
        PuRevisedBy?: string;
        ProdInit?: string;
        ProdEcnReq?: string;
        ProdByprod?: string;
        ProdScrapRate?: number;
        ProdPictDesc1?: string;
        ProdPictDesc2?: string;
        ProdPictDesc3?: string;
        ProdPictDesc4?: string;
        ProdWeightUom?: string;
        ProdDimenUom?: string;
        ProdFixedWtum?: string;
        ProdFixedDmum?: string;
        ProdStdLsize?: number;
        ProdMinLsize?: number;
        ProdMaxLsize?: number;
        ProdStdOutput?: number;
        PrRevisedDate?: string;
        PrRevisedBy?: string;
        ShopReqJcat?: string;
        ShopWksCover?: number;
        ShopPlanner?: string;
        ShopDefPlnr?: string;
        ShopMpsHorz?: number;
        ShopPurLtime?: number;
        ShopPurLunit?: string;
        ShopJobCat?: string;
        ShopMrpHorz?: number;
        ShRevisedDate?: string;
        ShRevisedBy?: string;
        MrpCount?: number;
        MrpRefNo?: string;
        MrpRunDate?: string;
        MrpHorzDate?: string;
        IcInit?: string;
        IcReceipts?: string;
        IcIssuance?: string;
        IcTransfer?: string;
        IcAdjustment?: string;
        IcRevisedDate?: string;
        IcRevisedBy?: string;
        PrJobSched?: string;
        PrByProd?: string;
        PrJobBatches?: string;
        LastResvNo?: number;
        NoMrpFence?: string;
        MvtRmIssue?: string;
        MvtSpIssue?: string;
        MvtFgReturn?: string;
        MvtRmReturn?: string;
        MvtSlShipment?: string;
        MvtSlReturn?: string;
        MvtPuReceipt?: string;
        MvtPuInspect?: string;
        MvtPuReturn?: string;
        GlInit?: string;
        GlHdrTxt?: string;
        GlDtlTxt?: string;
        GlRefEntry?: string;
        GlRefLabel?: string;
        GlLrefEntry?: string;
        GlLrefLabel?: string;
        GlExchComp?: string;
        GlRevisedBy?: string;
        GlRevisedDate?: string;
        VochArInvo?: string;
        VochArMemo?: string;
        VochArAdj?: string;
        VochArPay?: string;
        VochArAlloc?: string;
        VochArInvocan?: string;
        VochArPaycan?: string;
        VochApInvo?: string;
        VochApMemo?: string;
        VochApAdj?: string;
        VochApPay?: string;
        VochApAlloc?: string;
        VochApInvocan?: string;
        VochApPaycan?: string;
        VochIcIssue?: string;
        VochIcRcpt?: string;
        VochIcAdj?: string;
        VochPrIssue?: string;
        VochPrReturn?: string;
        VochPrProd?: string;
        VochPrSubcon?: string;
        VochPayroll?: string;
        VochCommission?: string;
        VochFaAcquire?: string;
        VochFaDeprec?: string;
        VochFaMaint?: string;
        VochFaDispo?: string;
        ArBcountInvo?: number;
        ArBcountMemo?: number;
        ArBcountAdj?: number;
        ArBcountPay?: number;
        ArBcountAlloc?: number;
        ApBcountInvo?: number;
        ApBcountMemo?: number;
        ApBcountAdj?: number;
        ApBcountPay?: number;
        ApBcountAlloc?: number;
        CostInit?: string;
        CostBasis?: string;
        CostRmPrMul?: number;
        CostLbPrMul?: number;
        CostOvPrMul?: number;
        CostRmSlMul?: number;
        CostLbSlMul?: number;
        CostOvSlMul?: number;
        CostRevisedBy?: string;
        CostRevDate?: string;
        PrCostVerify?: string;
        PrCostEdit?: string;
        CommisType?: string;
        SlsoCustItem?: string;
        SlsoPkgType?: string;
        IcAutoShip?: string;
        IcAutoSlret?: string;
        IcAutoGrn?: string;
        IcAutoQc?: string;
        IcAutoPuret?: string;
        IcAutoWorkc?: string;
        ApOvrideRate?: string;
        SlsoSchEntry?: string;
        PupoSchEntry?: string;
        SlsoContact?: string;
        SlsoOrdrPack?: string;
        MaxUsers?: number;
        MmuKey?: string;
        AcctAnlys1?: string;
        AcctAnlys2?: string;
        AcctAnlys3?: string;
        AcctAnlys4?: string;
        VochAnlys1?: string;
        VochAnlys2?: string;
        VochAnlys3?: string;
        VochAnlys4?: string;
        VochAnlys5?: string;
        VochAnlys6?: string;
        ItemAnlys1?: string;
        ItemAnlys2?: string;
        ItemAnlys3?: string;
        ItemAnlys4?: string;
        CustAnlys1?: string;
        CustAnlys2?: string;
        CustAnlys3?: string;
        CustAnlys4?: string;
        VendAnlys1?: string;
        VendAnlys2?: string;
        VendAnlys3?: string;
        VendAnlys4?: string;
        SaleAnlys1?: string;
        SaleAnlys2?: string;
        SaleAnlys3?: string;
        SaleAnlys4?: string;
        SaleAnlys5?: string;
        SaleAnlys6?: string;
        PurcAnlys1?: string;
        PurcAnlys2?: string;
        PurcAnlys3?: string;
        PurcAnlys4?: string;
        PurcAnlys5?: string;
        PurcAnlys6?: string;
        MvmtAnlys1?: string;
        MvmtAnlys2?: string;
        MvmtAnlys3?: string;
        MvmtAnlys4?: string;
        MvmtAnlys5?: string;
        MvmtAnlys6?: string;
        NrevisedDate?: string;
        NrevisedBy?: string;
        ShipWtUom?: string;
        ShipDimUom?: string;
        ItemPacking?: string;
        NoOvhdAcctg?: string;
        NoVariaAcctg?: string;
        NoFgAcctg?: string;
        FgCostLimit?: string;
        AllowDescChg?: string;
        NoLaborAcctg?: string;
        NoSubconAcctg?: string;
        ReorderIsNew?: string;
        DefInspStd?: string;
        DefInspLvl?: string;
        DefAqlLvlMaj?: string;
        DefAqlLvlMin?: string;
        ReturnEmail?: string;
        SmtpServer?: string;
        WebSetting1?: string;
        WebSetting2?: string;
        WebSetting3?: string;
        WebSetting4?: string;
        PupoPriceCtrl?: string;
        JordAnlys1?: string;
        JordAnlys2?: string;
        JordAnlys3?: string;
        JordAnlys4?: string;
        JordAnlys5?: string;
        JordAnlys6?: string;
        ProdPosEntry?: string;
        GlarText1?: string;
        GlarText2?: string;
        GlarText3?: string;
        GlarText4?: string;
        PrJobClose?: string;
        SlsoUnfullPackResponse?: string;
        SlsoDefMultiShip?: string;
        SlsoDefAutoPo?: string;
        SlsoDefAutoJo?: string;
        SlpaExtDesc?: string;
        PupoDueLead?: number;
        PupoSchLead?: number;
        PrMultiIssue?: string;
        ProdSepRoute?: string;
        ProdHideWcSubcon?: string;
        CopyTextFromSo?: string;
        PrpmText1?: string;
        PrpmText2?: string;
        PrpmText3?: string;
        PrpmText4?: string;
        PrpmExtInst?: string;
        BomVerLen?: number;
        ProdPoPrice?: string;
        SaleAnlys7?: string;
        SaleAnlys8?: string;
        PurcAnlys7?: string;
        PurcAnlys8?: string;
        MvmtAnlys7?: string;
        MvmtAnlys8?: string;
        VochAnlys7?: string;
        VochAnlys8?: string;
        JordAnlys7?: string;
        JordAnlys8?: string;
        ArAnlys1?: string;
        ArAnlys2?: string;
        ArAnlys3?: string;
        ArAnlys4?: string;
        ArAnlys5?: string;
        ArAnlys6?: string;
        ArAnlys7?: string;
        ArAnlys8?: string;
        ApAnlys1?: string;
        ApAnlys2?: string;
        ApAnlys3?: string;
        ApAnlys4?: string;
        ApAnlys5?: string;
        ApAnlys6?: string;
        ApAnlys7?: string;
        ApAnlys8?: string;
        SlAddInfo?: string;
        PuAddInfo?: string;
        PrAddInfo?: string;
        IcAddInfo?: string;
        ChkMatIss?: string;
        IcDefStdCost?: string;
        CheckCustpo?: string;
        CtlFgRtn?: string;
        VochArRefund?: string;
        VochApRefund?: string;
        SlsoDn?: string;
        AutoIncBy?: number;
        QuoGenMultiSo?: string;
        PuReceiveAll?: string;
        PrpmItemMasterScrap?: string;
        IcDisableCommit?: string;
        ProdDefMatRemarks?: string;
        SlsoUpdateQtyFromSch?: string;
        PupoUpdateQtyFromSch?: string;
        SlsoDefaultBasePrice?: string;
        SlsoDiscountByCustomer?: string;
        PrpmMaxQtyInStorage?: string;
        IcDefCostType?: string;
        ProdBomCreateItem?: string;
        PupoRtvLoc?: string;
        PrpmUseAllMatLastWc?: string;
        IcNoDefCharge?: string;
        ProdDefPhantomBom?: string;
        SlsoNeedCmApproval?: string;
        PupoNeedVmApproval?: string;
        ProdNeedBomApproval?: string;
        ProdNeedImApproval?: string;
        PrpmNeedScrapReason?: string;
        PrpmMustBackflush?: string;
        PupoAutoOrderLink?: string;
        PrpmAutoOrderLink?: string;
        PrpeAllowChgJob?: string;
        VochPrInspect?: string;
        VochPrRework?: string;
        ProdNeedPlanRlseApproval?: string;
        PrpmIncludeScrapInMmi?: string;
        ProdScrapLoc?: string;
        MvtPrScrap?: string;
        SlNeedClApproval?: string;
        WarnOnMatConsum?: string;
        IcimAutogenLot?: string;
        IcimAutogenSerial?: string;
        ItemAnlys5?: string;
        ItemAnlys6?: string;
        ItemAnlys7?: string;
        ItemAnlys8?: string;
        ItemAnlys9?: string;
        ItemAnlys10?: string;
        CustAnlys5?: string;
        CustAnlys6?: string;
        CustAnlys7?: string;
        CustAnlys8?: string;
        CustAnlys9?: string;
        CustAnlys10?: string;
        VendAnlys5?: string;
        VendAnlys6?: string;
        VendAnlys7?: string;
        VendAnlys8?: string;
        VendAnlys9?: string;
        VendAnlys10?: string;
        AcctAnlys5?: string;
        AcctAnlys6?: string;
        AcctAnlys7?: string;
        AcctAnlys8?: string;
        AcctAnlys9?: string;
        AcctAnlys10?: string;
        SaleAnlys9?: string;
        SaleAnlys10?: string;
        SaleAnlys11?: string;
        SaleAnlys12?: string;
        SaleAnlys13?: string;
        SaleAnlys14?: string;
        SaleAnlys15?: string;
        SaleAnlys16?: string;
        SaleAnlys17?: string;
        SaleAnlys18?: string;
        SaleAnlys19?: string;
        SaleAnlys20?: string;
        PurcAnlys9?: string;
        PurcAnlys10?: string;
        PurcAnlys11?: string;
        PurcAnlys12?: string;
        PurcAnlys13?: string;
        PurcAnlys14?: string;
        PurcAnlys15?: string;
        PurcAnlys16?: string;
        PurcAnlys17?: string;
        PurcAnlys18?: string;
        PurcAnlys19?: string;
        PurcAnlys20?: string;
        MvmtAnlys9?: string;
        MvmtAnlys10?: string;
        MvmtAnlys11?: string;
        MvmtAnlys12?: string;
        MvmtAnlys13?: string;
        MvmtAnlys14?: string;
        MvmtAnlys15?: string;
        MvmtAnlys16?: string;
        MvmtAnlys17?: string;
        MvmtAnlys18?: string;
        MvmtAnlys19?: string;
        MvmtAnlys20?: string;
        VochAnlys9?: string;
        VochAnlys10?: string;
        VochAnlys11?: string;
        VochAnlys12?: string;
        VochAnlys13?: string;
        VochAnlys14?: string;
        VochAnlys15?: string;
        VochAnlys16?: string;
        VochAnlys17?: string;
        VochAnlys18?: string;
        VochAnlys19?: string;
        VochAnlys20?: string;
        JordAnlys9?: string;
        JordAnlys10?: string;
        JordAnlys11?: string;
        JordAnlys12?: string;
        JordAnlys13?: string;
        JordAnlys14?: string;
        JordAnlys15?: string;
        JordAnlys16?: string;
        JordAnlys17?: string;
        JordAnlys18?: string;
        JordAnlys19?: string;
        JordAnlys20?: string;
        ArAnlys9?: string;
        ArAnlys10?: string;
        ArAnlys11?: string;
        ArAnlys12?: string;
        ArAnlys13?: string;
        ArAnlys14?: string;
        ArAnlys15?: string;
        ArAnlys16?: string;
        ArAnlys17?: string;
        ArAnlys18?: string;
        ArAnlys19?: string;
        ArAnlys20?: string;
        ApAnlys9?: string;
        ApAnlys10?: string;
        ApAnlys11?: string;
        ApAnlys12?: string;
        ApAnlys13?: string;
        ApAnlys14?: string;
        ApAnlys15?: string;
        ApAnlys16?: string;
        ApAnlys17?: string;
        ApAnlys18?: string;
        ApAnlys19?: string;
        ApAnlys20?: string;
        PrpeMoldAuditTrail?: boolean;
        IcimIssueByAvailableQty?: boolean;
        PrpmJamendIssueControl?: boolean;
        PrAutoMultiSpareIssue?: boolean;
        SlShipmentPriceControl?: boolean;
        ArMultiSettle?: boolean;
        PupoDefMultiship?: boolean;
        PupoDefReorder?: boolean;
        SlsoDefReorder?: boolean;
        VochByVdate?: boolean;
        PupoTaxTerms?: boolean;
        SampleAcct?: string;
        CtlFgRtnTotQty?: boolean;
        AllowMultiWc?: boolean;
        PoaIgnoreMinQty?: boolean;
        GrnMatCost?: boolean;
        GrnLotNoImport?: boolean;
        IssueMaterialsByRouting?: boolean;
        ConsumeMatInLastRouting?: boolean;
        DefAqlLvlCritical?: string;
        DefInspLvlSp?: string;
        DefAqlLvlCriticalSp?: string;
        DefAqlLvlMajSp?: string;
        DefAqlLvlMinSp?: string;
        WcAutoMatReturn?: boolean;
        ArInvMultiPayTerms?: boolean;
        IcAdjCodeAPcent?: number;
        IcAdjCodeBPcent?: number;
        IcAdjCodeCPcent?: number;
        TailorIncludeJob?: boolean;
        JoMultiSource?: boolean;
        ShowShipmentInfoInPacking?: boolean;
        MrpWithReorderPt?: boolean;
        AllowFollowListWithoutMi?: boolean;
        PrMultiFollowList?: boolean;
        SqietkMatBalSubtractCommit?: boolean;
        SoLineAutoIncBy?: number;
        PoLineAutoIncBy?: number;
        PuOverRcptByLine?: boolean;
        PuLmeCost?: boolean;
        SoaUpdatePendingShipment?: boolean;
        PrMatIssueOnAvailPercent?: number;
        JobHourlyRate?: number;
        ItemCustomProdCodeRequired?: boolean;
        IcimAutogenLotIssue?: boolean;
        IcimAutogenSerialIssue?: boolean;
        ShipmentInfoFromFirstOrder?: boolean;
        MrpExcludeLeadtime?: boolean;
        ItemPrelotSopo?: boolean;
        SlsoCtrlBtmCeil?: boolean;
        WcOverAcceptedLot?: boolean;
        SlsoAutoResv?: boolean;
        PercentA?: number;
        PercentB?: number;
        PercentC?: number;
        EntryPostedRequirdBeforePrint?: string;
    }

    export namespace CompanySettingRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'SlInit';
        export const localTextPrefix = 'BasicInformation.CompanySetting';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const SlInit: string;
            export declare const SlsoMultiship: string;
            export declare const SlsoResv: string;
            export declare const SlsoAssortment: string;
            export declare const SlsoDeposits: string;
            export declare const SlsoMeasures: string;
            export declare const SlsoPtax: string;
            export declare const SlsoAtax: string;
            export declare const SlsoGtax: string;
            export declare const SlsoLineDisc: string;
            export declare const SlsoAutoPo: string;
            export declare const SlsoAutoJob: string;
            export declare const SlsoExtInst: string;
            export declare const SlsoExtDesc: string;
            export declare const SlsoFixedUom: string;
            export declare const SlsoReqSman: string;
            export declare const SlsoSman: string;
            export declare const SlsoText1: string;
            export declare const SlsoText2: string;
            export declare const SlsoText3: string;
            export declare const SlsoText4: string;
            export declare const SlsoDueLead: string;
            export declare const SlsoSchLead: string;
            export declare const SlsoAddrCode: string;
            export declare const SlsoAddrType: string;
            export declare const SlsoQuoteDays: string;
            export declare const SlshCutDays: string;
            export declare const SlsoShipVia: string;
            export declare const SlsoShipTerms: string;
            export declare const SlRevisedDate: string;
            export declare const SlRevisedBy: string;
            export declare const PuInit: string;
            export declare const PupoMultiship: string;
            export declare const PupoDeposits: string;
            export declare const PupoMeasures: string;
            export declare const PupoPtax: string;
            export declare const PupoAtax: string;
            export declare const PupoGtax: string;
            export declare const PupoLineDisc: string;
            export declare const PupoExtInst: string;
            export declare const PupoExtDesc: string;
            export declare const PupoFixedUom: string;
            export declare const PupoText1: string;
            export declare const PupoText2: string;
            export declare const PupoText3: string;
            export declare const PupoText4: string;
            export declare const PupoCutDays: string;
            export declare const PupoReorder: string;
            export declare const PupoReqBuyer: string;
            export declare const PupoBuyer: string;
            export declare const PupoShipVia: string;
            export declare const PupoShipTerms: string;
            export declare const PuRevisedDate: string;
            export declare const PuRevisedBy: string;
            export declare const ProdInit: string;
            export declare const ProdEcnReq: string;
            export declare const ProdByprod: string;
            export declare const ProdScrapRate: string;
            export declare const ProdPictDesc1: string;
            export declare const ProdPictDesc2: string;
            export declare const ProdPictDesc3: string;
            export declare const ProdPictDesc4: string;
            export declare const ProdWeightUom: string;
            export declare const ProdDimenUom: string;
            export declare const ProdFixedWtum: string;
            export declare const ProdFixedDmum: string;
            export declare const ProdStdLsize: string;
            export declare const ProdMinLsize: string;
            export declare const ProdMaxLsize: string;
            export declare const ProdStdOutput: string;
            export declare const PrRevisedDate: string;
            export declare const PrRevisedBy: string;
            export declare const ShopReqJcat: string;
            export declare const ShopWksCover: string;
            export declare const ShopPlanner: string;
            export declare const ShopDefPlnr: string;
            export declare const ShopMpsHorz: string;
            export declare const ShopPurLtime: string;
            export declare const ShopPurLunit: string;
            export declare const ShopJobCat: string;
            export declare const ShopMrpHorz: string;
            export declare const ShRevisedDate: string;
            export declare const ShRevisedBy: string;
            export declare const MrpCount: string;
            export declare const MrpRefNo: string;
            export declare const MrpRunDate: string;
            export declare const MrpHorzDate: string;
            export declare const IcInit: string;
            export declare const IcReceipts: string;
            export declare const IcIssuance: string;
            export declare const IcTransfer: string;
            export declare const IcAdjustment: string;
            export declare const IcRevisedDate: string;
            export declare const IcRevisedBy: string;
            export declare const PrJobSched: string;
            export declare const PrByProd: string;
            export declare const PrJobBatches: string;
            export declare const LastResvNo: string;
            export declare const NoMrpFence: string;
            export declare const MvtRmIssue: string;
            export declare const MvtSpIssue: string;
            export declare const MvtFgReturn: string;
            export declare const MvtRmReturn: string;
            export declare const MvtSlShipment: string;
            export declare const MvtSlReturn: string;
            export declare const MvtPuReceipt: string;
            export declare const MvtPuInspect: string;
            export declare const MvtPuReturn: string;
            export declare const GlInit: string;
            export declare const GlHdrTxt: string;
            export declare const GlDtlTxt: string;
            export declare const GlRefEntry: string;
            export declare const GlRefLabel: string;
            export declare const GlLrefEntry: string;
            export declare const GlLrefLabel: string;
            export declare const GlExchComp: string;
            export declare const GlRevisedBy: string;
            export declare const GlRevisedDate: string;
            export declare const VochArInvo: string;
            export declare const VochArMemo: string;
            export declare const VochArAdj: string;
            export declare const VochArPay: string;
            export declare const VochArAlloc: string;
            export declare const VochArInvocan: string;
            export declare const VochArPaycan: string;
            export declare const VochApInvo: string;
            export declare const VochApMemo: string;
            export declare const VochApAdj: string;
            export declare const VochApPay: string;
            export declare const VochApAlloc: string;
            export declare const VochApInvocan: string;
            export declare const VochApPaycan: string;
            export declare const VochIcIssue: string;
            export declare const VochIcRcpt: string;
            export declare const VochIcAdj: string;
            export declare const VochPrIssue: string;
            export declare const VochPrReturn: string;
            export declare const VochPrProd: string;
            export declare const VochPrSubcon: string;
            export declare const VochPayroll: string;
            export declare const VochCommission: string;
            export declare const VochFaAcquire: string;
            export declare const VochFaDeprec: string;
            export declare const VochFaMaint: string;
            export declare const VochFaDispo: string;
            export declare const ArBcountInvo: string;
            export declare const ArBcountMemo: string;
            export declare const ArBcountAdj: string;
            export declare const ArBcountPay: string;
            export declare const ArBcountAlloc: string;
            export declare const ApBcountInvo: string;
            export declare const ApBcountMemo: string;
            export declare const ApBcountAdj: string;
            export declare const ApBcountPay: string;
            export declare const ApBcountAlloc: string;
            export declare const CostInit: string;
            export declare const CostBasis: string;
            export declare const CostRmPrMul: string;
            export declare const CostLbPrMul: string;
            export declare const CostOvPrMul: string;
            export declare const CostRmSlMul: string;
            export declare const CostLbSlMul: string;
            export declare const CostOvSlMul: string;
            export declare const CostRevisedBy: string;
            export declare const CostRevDate: string;
            export declare const PrCostVerify: string;
            export declare const PrCostEdit: string;
            export declare const CommisType: string;
            export declare const SlsoCustItem: string;
            export declare const SlsoPkgType: string;
            export declare const IcAutoShip: string;
            export declare const IcAutoSlret: string;
            export declare const IcAutoGrn: string;
            export declare const IcAutoQc: string;
            export declare const IcAutoPuret: string;
            export declare const IcAutoWorkc: string;
            export declare const ApOvrideRate: string;
            export declare const SlsoSchEntry: string;
            export declare const PupoSchEntry: string;
            export declare const SlsoContact: string;
            export declare const SlsoOrdrPack: string;
            export declare const MaxUsers: string;
            export declare const MmuKey: string;
            export declare const AcctAnlys1: string;
            export declare const AcctAnlys2: string;
            export declare const AcctAnlys3: string;
            export declare const AcctAnlys4: string;
            export declare const VochAnlys1: string;
            export declare const VochAnlys2: string;
            export declare const VochAnlys3: string;
            export declare const VochAnlys4: string;
            export declare const VochAnlys5: string;
            export declare const VochAnlys6: string;
            export declare const ItemAnlys1: string;
            export declare const ItemAnlys2: string;
            export declare const ItemAnlys3: string;
            export declare const ItemAnlys4: string;
            export declare const CustAnlys1: string;
            export declare const CustAnlys2: string;
            export declare const CustAnlys3: string;
            export declare const CustAnlys4: string;
            export declare const VendAnlys1: string;
            export declare const VendAnlys2: string;
            export declare const VendAnlys3: string;
            export declare const VendAnlys4: string;
            export declare const SaleAnlys1: string;
            export declare const SaleAnlys2: string;
            export declare const SaleAnlys3: string;
            export declare const SaleAnlys4: string;
            export declare const SaleAnlys5: string;
            export declare const SaleAnlys6: string;
            export declare const PurcAnlys1: string;
            export declare const PurcAnlys2: string;
            export declare const PurcAnlys3: string;
            export declare const PurcAnlys4: string;
            export declare const PurcAnlys5: string;
            export declare const PurcAnlys6: string;
            export declare const MvmtAnlys1: string;
            export declare const MvmtAnlys2: string;
            export declare const MvmtAnlys3: string;
            export declare const MvmtAnlys4: string;
            export declare const MvmtAnlys5: string;
            export declare const MvmtAnlys6: string;
            export declare const NrevisedDate: string;
            export declare const NrevisedBy: string;
            export declare const ShipWtUom: string;
            export declare const ShipDimUom: string;
            export declare const ItemPacking: string;
            export declare const NoOvhdAcctg: string;
            export declare const NoVariaAcctg: string;
            export declare const NoFgAcctg: string;
            export declare const FgCostLimit: string;
            export declare const AllowDescChg: string;
            export declare const NoLaborAcctg: string;
            export declare const NoSubconAcctg: string;
            export declare const ReorderIsNew: string;
            export declare const DefInspStd: string;
            export declare const DefInspLvl: string;
            export declare const DefAqlLvlMaj: string;
            export declare const DefAqlLvlMin: string;
            export declare const ReturnEmail: string;
            export declare const SmtpServer: string;
            export declare const WebSetting1: string;
            export declare const WebSetting2: string;
            export declare const WebSetting3: string;
            export declare const WebSetting4: string;
            export declare const PupoPriceCtrl: string;
            export declare const JordAnlys1: string;
            export declare const JordAnlys2: string;
            export declare const JordAnlys3: string;
            export declare const JordAnlys4: string;
            export declare const JordAnlys5: string;
            export declare const JordAnlys6: string;
            export declare const ProdPosEntry: string;
            export declare const GlarText1: string;
            export declare const GlarText2: string;
            export declare const GlarText3: string;
            export declare const GlarText4: string;
            export declare const PrJobClose: string;
            export declare const SlsoUnfullPackResponse: string;
            export declare const SlsoDefMultiShip: string;
            export declare const SlsoDefAutoPo: string;
            export declare const SlsoDefAutoJo: string;
            export declare const SlpaExtDesc: string;
            export declare const PupoDueLead: string;
            export declare const PupoSchLead: string;
            export declare const PrMultiIssue: string;
            export declare const ProdSepRoute: string;
            export declare const ProdHideWcSubcon: string;
            export declare const CopyTextFromSo: string;
            export declare const PrpmText1: string;
            export declare const PrpmText2: string;
            export declare const PrpmText3: string;
            export declare const PrpmText4: string;
            export declare const PrpmExtInst: string;
            export declare const BomVerLen: string;
            export declare const ProdPoPrice: string;
            export declare const SaleAnlys7: string;
            export declare const SaleAnlys8: string;
            export declare const PurcAnlys7: string;
            export declare const PurcAnlys8: string;
            export declare const MvmtAnlys7: string;
            export declare const MvmtAnlys8: string;
            export declare const VochAnlys7: string;
            export declare const VochAnlys8: string;
            export declare const JordAnlys7: string;
            export declare const JordAnlys8: string;
            export declare const ArAnlys1: string;
            export declare const ArAnlys2: string;
            export declare const ArAnlys3: string;
            export declare const ArAnlys4: string;
            export declare const ArAnlys5: string;
            export declare const ArAnlys6: string;
            export declare const ArAnlys7: string;
            export declare const ArAnlys8: string;
            export declare const ApAnlys1: string;
            export declare const ApAnlys2: string;
            export declare const ApAnlys3: string;
            export declare const ApAnlys4: string;
            export declare const ApAnlys5: string;
            export declare const ApAnlys6: string;
            export declare const ApAnlys7: string;
            export declare const ApAnlys8: string;
            export declare const SlAddInfo: string;
            export declare const PuAddInfo: string;
            export declare const PrAddInfo: string;
            export declare const IcAddInfo: string;
            export declare const ChkMatIss: string;
            export declare const IcDefStdCost: string;
            export declare const CheckCustpo: string;
            export declare const CtlFgRtn: string;
            export declare const VochArRefund: string;
            export declare const VochApRefund: string;
            export declare const SlsoDn: string;
            export declare const AutoIncBy: string;
            export declare const QuoGenMultiSo: string;
            export declare const PuReceiveAll: string;
            export declare const PrpmItemMasterScrap: string;
            export declare const IcDisableCommit: string;
            export declare const ProdDefMatRemarks: string;
            export declare const SlsoUpdateQtyFromSch: string;
            export declare const PupoUpdateQtyFromSch: string;
            export declare const SlsoDefaultBasePrice: string;
            export declare const SlsoDiscountByCustomer: string;
            export declare const PrpmMaxQtyInStorage: string;
            export declare const IcDefCostType: string;
            export declare const ProdBomCreateItem: string;
            export declare const PupoRtvLoc: string;
            export declare const PrpmUseAllMatLastWc: string;
            export declare const IcNoDefCharge: string;
            export declare const ProdDefPhantomBom: string;
            export declare const SlsoNeedCmApproval: string;
            export declare const PupoNeedVmApproval: string;
            export declare const ProdNeedBomApproval: string;
            export declare const ProdNeedImApproval: string;
            export declare const PrpmNeedScrapReason: string;
            export declare const PrpmMustBackflush: string;
            export declare const PupoAutoOrderLink: string;
            export declare const PrpmAutoOrderLink: string;
            export declare const PrpeAllowChgJob: string;
            export declare const VochPrInspect: string;
            export declare const VochPrRework: string;
            export declare const ProdNeedPlanRlseApproval: string;
            export declare const PrpmIncludeScrapInMmi: string;
            export declare const ProdScrapLoc: string;
            export declare const MvtPrScrap: string;
            export declare const SlNeedClApproval: string;
            export declare const WarnOnMatConsum: string;
            export declare const IcimAutogenLot: string;
            export declare const IcimAutogenSerial: string;
            export declare const ItemAnlys5: string;
            export declare const ItemAnlys6: string;
            export declare const ItemAnlys7: string;
            export declare const ItemAnlys8: string;
            export declare const ItemAnlys9: string;
            export declare const ItemAnlys10: string;
            export declare const CustAnlys5: string;
            export declare const CustAnlys6: string;
            export declare const CustAnlys7: string;
            export declare const CustAnlys8: string;
            export declare const CustAnlys9: string;
            export declare const CustAnlys10: string;
            export declare const VendAnlys5: string;
            export declare const VendAnlys6: string;
            export declare const VendAnlys7: string;
            export declare const VendAnlys8: string;
            export declare const VendAnlys9: string;
            export declare const VendAnlys10: string;
            export declare const AcctAnlys5: string;
            export declare const AcctAnlys6: string;
            export declare const AcctAnlys7: string;
            export declare const AcctAnlys8: string;
            export declare const AcctAnlys9: string;
            export declare const AcctAnlys10: string;
            export declare const SaleAnlys9: string;
            export declare const SaleAnlys10: string;
            export declare const SaleAnlys11: string;
            export declare const SaleAnlys12: string;
            export declare const SaleAnlys13: string;
            export declare const SaleAnlys14: string;
            export declare const SaleAnlys15: string;
            export declare const SaleAnlys16: string;
            export declare const SaleAnlys17: string;
            export declare const SaleAnlys18: string;
            export declare const SaleAnlys19: string;
            export declare const SaleAnlys20: string;
            export declare const PurcAnlys9: string;
            export declare const PurcAnlys10: string;
            export declare const PurcAnlys11: string;
            export declare const PurcAnlys12: string;
            export declare const PurcAnlys13: string;
            export declare const PurcAnlys14: string;
            export declare const PurcAnlys15: string;
            export declare const PurcAnlys16: string;
            export declare const PurcAnlys17: string;
            export declare const PurcAnlys18: string;
            export declare const PurcAnlys19: string;
            export declare const PurcAnlys20: string;
            export declare const MvmtAnlys9: string;
            export declare const MvmtAnlys10: string;
            export declare const MvmtAnlys11: string;
            export declare const MvmtAnlys12: string;
            export declare const MvmtAnlys13: string;
            export declare const MvmtAnlys14: string;
            export declare const MvmtAnlys15: string;
            export declare const MvmtAnlys16: string;
            export declare const MvmtAnlys17: string;
            export declare const MvmtAnlys18: string;
            export declare const MvmtAnlys19: string;
            export declare const MvmtAnlys20: string;
            export declare const VochAnlys9: string;
            export declare const VochAnlys10: string;
            export declare const VochAnlys11: string;
            export declare const VochAnlys12: string;
            export declare const VochAnlys13: string;
            export declare const VochAnlys14: string;
            export declare const VochAnlys15: string;
            export declare const VochAnlys16: string;
            export declare const VochAnlys17: string;
            export declare const VochAnlys18: string;
            export declare const VochAnlys19: string;
            export declare const VochAnlys20: string;
            export declare const JordAnlys9: string;
            export declare const JordAnlys10: string;
            export declare const JordAnlys11: string;
            export declare const JordAnlys12: string;
            export declare const JordAnlys13: string;
            export declare const JordAnlys14: string;
            export declare const JordAnlys15: string;
            export declare const JordAnlys16: string;
            export declare const JordAnlys17: string;
            export declare const JordAnlys18: string;
            export declare const JordAnlys19: string;
            export declare const JordAnlys20: string;
            export declare const ArAnlys9: string;
            export declare const ArAnlys10: string;
            export declare const ArAnlys11: string;
            export declare const ArAnlys12: string;
            export declare const ArAnlys13: string;
            export declare const ArAnlys14: string;
            export declare const ArAnlys15: string;
            export declare const ArAnlys16: string;
            export declare const ArAnlys17: string;
            export declare const ArAnlys18: string;
            export declare const ArAnlys19: string;
            export declare const ArAnlys20: string;
            export declare const ApAnlys9: string;
            export declare const ApAnlys10: string;
            export declare const ApAnlys11: string;
            export declare const ApAnlys12: string;
            export declare const ApAnlys13: string;
            export declare const ApAnlys14: string;
            export declare const ApAnlys15: string;
            export declare const ApAnlys16: string;
            export declare const ApAnlys17: string;
            export declare const ApAnlys18: string;
            export declare const ApAnlys19: string;
            export declare const ApAnlys20: string;
            export declare const PrpeMoldAuditTrail: string;
            export declare const IcimIssueByAvailableQty: string;
            export declare const PrpmJamendIssueControl: string;
            export declare const PrAutoMultiSpareIssue: string;
            export declare const SlShipmentPriceControl: string;
            export declare const ArMultiSettle: string;
            export declare const PupoDefMultiship: string;
            export declare const PupoDefReorder: string;
            export declare const SlsoDefReorder: string;
            export declare const VochByVdate: string;
            export declare const PupoTaxTerms: string;
            export declare const SampleAcct: string;
            export declare const CtlFgRtnTotQty: string;
            export declare const AllowMultiWc: string;
            export declare const PoaIgnoreMinQty: string;
            export declare const GrnMatCost: string;
            export declare const GrnLotNoImport: string;
            export declare const IssueMaterialsByRouting: string;
            export declare const ConsumeMatInLastRouting: string;
            export declare const DefAqlLvlCritical: string;
            export declare const DefInspLvlSp: string;
            export declare const DefAqlLvlCriticalSp: string;
            export declare const DefAqlLvlMajSp: string;
            export declare const DefAqlLvlMinSp: string;
            export declare const WcAutoMatReturn: string;
            export declare const ArInvMultiPayTerms: string;
            export declare const IcAdjCodeAPcent: string;
            export declare const IcAdjCodeBPcent: string;
            export declare const IcAdjCodeCPcent: string;
            export declare const TailorIncludeJob: string;
            export declare const JoMultiSource: string;
            export declare const ShowShipmentInfoInPacking: string;
            export declare const MrpWithReorderPt: string;
            export declare const AllowFollowListWithoutMi: string;
            export declare const PrMultiFollowList: string;
            export declare const SqietkMatBalSubtractCommit: string;
            export declare const SoLineAutoIncBy: string;
            export declare const PoLineAutoIncBy: string;
            export declare const PuOverRcptByLine: string;
            export declare const PuLmeCost: string;
            export declare const SoaUpdatePendingShipment: string;
            export declare const PrMatIssueOnAvailPercent: string;
            export declare const JobHourlyRate: string;
            export declare const ItemCustomProdCodeRequired: string;
            export declare const IcimAutogenLotIssue: string;
            export declare const IcimAutogenSerialIssue: string;
            export declare const ShipmentInfoFromFirstOrder: string;
            export declare const MrpExcludeLeadtime: string;
            export declare const ItemPrelotSopo: string;
            export declare const SlsoCtrlBtmCeil: string;
            export declare const WcOverAcceptedLot: string;
            export declare const SlsoAutoResv: string;
            export declare const PercentA: string;
            export declare const PercentB: string;
            export declare const PercentC: string;
            export declare const EntryPostedRequirdBeforePrint: string;
        }

        [
            'Recnum', 
            'SlInit', 
            'SlsoMultiship', 
            'SlsoResv', 
            'SlsoAssortment', 
            'SlsoDeposits', 
            'SlsoMeasures', 
            'SlsoPtax', 
            'SlsoAtax', 
            'SlsoGtax', 
            'SlsoLineDisc', 
            'SlsoAutoPo', 
            'SlsoAutoJob', 
            'SlsoExtInst', 
            'SlsoExtDesc', 
            'SlsoFixedUom', 
            'SlsoReqSman', 
            'SlsoSman', 
            'SlsoText1', 
            'SlsoText2', 
            'SlsoText3', 
            'SlsoText4', 
            'SlsoDueLead', 
            'SlsoSchLead', 
            'SlsoAddrCode', 
            'SlsoAddrType', 
            'SlsoQuoteDays', 
            'SlshCutDays', 
            'SlsoShipVia', 
            'SlsoShipTerms', 
            'SlRevisedDate', 
            'SlRevisedBy', 
            'PuInit', 
            'PupoMultiship', 
            'PupoDeposits', 
            'PupoMeasures', 
            'PupoPtax', 
            'PupoAtax', 
            'PupoGtax', 
            'PupoLineDisc', 
            'PupoExtInst', 
            'PupoExtDesc', 
            'PupoFixedUom', 
            'PupoText1', 
            'PupoText2', 
            'PupoText3', 
            'PupoText4', 
            'PupoCutDays', 
            'PupoReorder', 
            'PupoReqBuyer', 
            'PupoBuyer', 
            'PupoShipVia', 
            'PupoShipTerms', 
            'PuRevisedDate', 
            'PuRevisedBy', 
            'ProdInit', 
            'ProdEcnReq', 
            'ProdByprod', 
            'ProdScrapRate', 
            'ProdPictDesc1', 
            'ProdPictDesc2', 
            'ProdPictDesc3', 
            'ProdPictDesc4', 
            'ProdWeightUom', 
            'ProdDimenUom', 
            'ProdFixedWtum', 
            'ProdFixedDmum', 
            'ProdStdLsize', 
            'ProdMinLsize', 
            'ProdMaxLsize', 
            'ProdStdOutput', 
            'PrRevisedDate', 
            'PrRevisedBy', 
            'ShopReqJcat', 
            'ShopWksCover', 
            'ShopPlanner', 
            'ShopDefPlnr', 
            'ShopMpsHorz', 
            'ShopPurLtime', 
            'ShopPurLunit', 
            'ShopJobCat', 
            'ShopMrpHorz', 
            'ShRevisedDate', 
            'ShRevisedBy', 
            'MrpCount', 
            'MrpRefNo', 
            'MrpRunDate', 
            'MrpHorzDate', 
            'IcInit', 
            'IcReceipts', 
            'IcIssuance', 
            'IcTransfer', 
            'IcAdjustment', 
            'IcRevisedDate', 
            'IcRevisedBy', 
            'PrJobSched', 
            'PrByProd', 
            'PrJobBatches', 
            'LastResvNo', 
            'NoMrpFence', 
            'MvtRmIssue', 
            'MvtSpIssue', 
            'MvtFgReturn', 
            'MvtRmReturn', 
            'MvtSlShipment', 
            'MvtSlReturn', 
            'MvtPuReceipt', 
            'MvtPuInspect', 
            'MvtPuReturn', 
            'GlInit', 
            'GlHdrTxt', 
            'GlDtlTxt', 
            'GlRefEntry', 
            'GlRefLabel', 
            'GlLrefEntry', 
            'GlLrefLabel', 
            'GlExchComp', 
            'GlRevisedBy', 
            'GlRevisedDate', 
            'VochArInvo', 
            'VochArMemo', 
            'VochArAdj', 
            'VochArPay', 
            'VochArAlloc', 
            'VochArInvocan', 
            'VochArPaycan', 
            'VochApInvo', 
            'VochApMemo', 
            'VochApAdj', 
            'VochApPay', 
            'VochApAlloc', 
            'VochApInvocan', 
            'VochApPaycan', 
            'VochIcIssue', 
            'VochIcRcpt', 
            'VochIcAdj', 
            'VochPrIssue', 
            'VochPrReturn', 
            'VochPrProd', 
            'VochPrSubcon', 
            'VochPayroll', 
            'VochCommission', 
            'VochFaAcquire', 
            'VochFaDeprec', 
            'VochFaMaint', 
            'VochFaDispo', 
            'ArBcountInvo', 
            'ArBcountMemo', 
            'ArBcountAdj', 
            'ArBcountPay', 
            'ArBcountAlloc', 
            'ApBcountInvo', 
            'ApBcountMemo', 
            'ApBcountAdj', 
            'ApBcountPay', 
            'ApBcountAlloc', 
            'CostInit', 
            'CostBasis', 
            'CostRmPrMul', 
            'CostLbPrMul', 
            'CostOvPrMul', 
            'CostRmSlMul', 
            'CostLbSlMul', 
            'CostOvSlMul', 
            'CostRevisedBy', 
            'CostRevDate', 
            'PrCostVerify', 
            'PrCostEdit', 
            'CommisType', 
            'SlsoCustItem', 
            'SlsoPkgType', 
            'IcAutoShip', 
            'IcAutoSlret', 
            'IcAutoGrn', 
            'IcAutoQc', 
            'IcAutoPuret', 
            'IcAutoWorkc', 
            'ApOvrideRate', 
            'SlsoSchEntry', 
            'PupoSchEntry', 
            'SlsoContact', 
            'SlsoOrdrPack', 
            'MaxUsers', 
            'MmuKey', 
            'AcctAnlys1', 
            'AcctAnlys2', 
            'AcctAnlys3', 
            'AcctAnlys4', 
            'VochAnlys1', 
            'VochAnlys2', 
            'VochAnlys3', 
            'VochAnlys4', 
            'VochAnlys5', 
            'VochAnlys6', 
            'ItemAnlys1', 
            'ItemAnlys2', 
            'ItemAnlys3', 
            'ItemAnlys4', 
            'CustAnlys1', 
            'CustAnlys2', 
            'CustAnlys3', 
            'CustAnlys4', 
            'VendAnlys1', 
            'VendAnlys2', 
            'VendAnlys3', 
            'VendAnlys4', 
            'SaleAnlys1', 
            'SaleAnlys2', 
            'SaleAnlys3', 
            'SaleAnlys4', 
            'SaleAnlys5', 
            'SaleAnlys6', 
            'PurcAnlys1', 
            'PurcAnlys2', 
            'PurcAnlys3', 
            'PurcAnlys4', 
            'PurcAnlys5', 
            'PurcAnlys6', 
            'MvmtAnlys1', 
            'MvmtAnlys2', 
            'MvmtAnlys3', 
            'MvmtAnlys4', 
            'MvmtAnlys5', 
            'MvmtAnlys6', 
            'NrevisedDate', 
            'NrevisedBy', 
            'ShipWtUom', 
            'ShipDimUom', 
            'ItemPacking', 
            'NoOvhdAcctg', 
            'NoVariaAcctg', 
            'NoFgAcctg', 
            'FgCostLimit', 
            'AllowDescChg', 
            'NoLaborAcctg', 
            'NoSubconAcctg', 
            'ReorderIsNew', 
            'DefInspStd', 
            'DefInspLvl', 
            'DefAqlLvlMaj', 
            'DefAqlLvlMin', 
            'ReturnEmail', 
            'SmtpServer', 
            'WebSetting1', 
            'WebSetting2', 
            'WebSetting3', 
            'WebSetting4', 
            'PupoPriceCtrl', 
            'JordAnlys1', 
            'JordAnlys2', 
            'JordAnlys3', 
            'JordAnlys4', 
            'JordAnlys5', 
            'JordAnlys6', 
            'ProdPosEntry', 
            'GlarText1', 
            'GlarText2', 
            'GlarText3', 
            'GlarText4', 
            'PrJobClose', 
            'SlsoUnfullPackResponse', 
            'SlsoDefMultiShip', 
            'SlsoDefAutoPo', 
            'SlsoDefAutoJo', 
            'SlpaExtDesc', 
            'PupoDueLead', 
            'PupoSchLead', 
            'PrMultiIssue', 
            'ProdSepRoute', 
            'ProdHideWcSubcon', 
            'CopyTextFromSo', 
            'PrpmText1', 
            'PrpmText2', 
            'PrpmText3', 
            'PrpmText4', 
            'PrpmExtInst', 
            'BomVerLen', 
            'ProdPoPrice', 
            'SaleAnlys7', 
            'SaleAnlys8', 
            'PurcAnlys7', 
            'PurcAnlys8', 
            'MvmtAnlys7', 
            'MvmtAnlys8', 
            'VochAnlys7', 
            'VochAnlys8', 
            'JordAnlys7', 
            'JordAnlys8', 
            'ArAnlys1', 
            'ArAnlys2', 
            'ArAnlys3', 
            'ArAnlys4', 
            'ArAnlys5', 
            'ArAnlys6', 
            'ArAnlys7', 
            'ArAnlys8', 
            'ApAnlys1', 
            'ApAnlys2', 
            'ApAnlys3', 
            'ApAnlys4', 
            'ApAnlys5', 
            'ApAnlys6', 
            'ApAnlys7', 
            'ApAnlys8', 
            'SlAddInfo', 
            'PuAddInfo', 
            'PrAddInfo', 
            'IcAddInfo', 
            'ChkMatIss', 
            'IcDefStdCost', 
            'CheckCustpo', 
            'CtlFgRtn', 
            'VochArRefund', 
            'VochApRefund', 
            'SlsoDn', 
            'AutoIncBy', 
            'QuoGenMultiSo', 
            'PuReceiveAll', 
            'PrpmItemMasterScrap', 
            'IcDisableCommit', 
            'ProdDefMatRemarks', 
            'SlsoUpdateQtyFromSch', 
            'PupoUpdateQtyFromSch', 
            'SlsoDefaultBasePrice', 
            'SlsoDiscountByCustomer', 
            'PrpmMaxQtyInStorage', 
            'IcDefCostType', 
            'ProdBomCreateItem', 
            'PupoRtvLoc', 
            'PrpmUseAllMatLastWc', 
            'IcNoDefCharge', 
            'ProdDefPhantomBom', 
            'SlsoNeedCmApproval', 
            'PupoNeedVmApproval', 
            'ProdNeedBomApproval', 
            'ProdNeedImApproval', 
            'PrpmNeedScrapReason', 
            'PrpmMustBackflush', 
            'PupoAutoOrderLink', 
            'PrpmAutoOrderLink', 
            'PrpeAllowChgJob', 
            'VochPrInspect', 
            'VochPrRework', 
            'ProdNeedPlanRlseApproval', 
            'PrpmIncludeScrapInMmi', 
            'ProdScrapLoc', 
            'MvtPrScrap', 
            'SlNeedClApproval', 
            'WarnOnMatConsum', 
            'IcimAutogenLot', 
            'IcimAutogenSerial', 
            'ItemAnlys5', 
            'ItemAnlys6', 
            'ItemAnlys7', 
            'ItemAnlys8', 
            'ItemAnlys9', 
            'ItemAnlys10', 
            'CustAnlys5', 
            'CustAnlys6', 
            'CustAnlys7', 
            'CustAnlys8', 
            'CustAnlys9', 
            'CustAnlys10', 
            'VendAnlys5', 
            'VendAnlys6', 
            'VendAnlys7', 
            'VendAnlys8', 
            'VendAnlys9', 
            'VendAnlys10', 
            'AcctAnlys5', 
            'AcctAnlys6', 
            'AcctAnlys7', 
            'AcctAnlys8', 
            'AcctAnlys9', 
            'AcctAnlys10', 
            'SaleAnlys9', 
            'SaleAnlys10', 
            'SaleAnlys11', 
            'SaleAnlys12', 
            'SaleAnlys13', 
            'SaleAnlys14', 
            'SaleAnlys15', 
            'SaleAnlys16', 
            'SaleAnlys17', 
            'SaleAnlys18', 
            'SaleAnlys19', 
            'SaleAnlys20', 
            'PurcAnlys9', 
            'PurcAnlys10', 
            'PurcAnlys11', 
            'PurcAnlys12', 
            'PurcAnlys13', 
            'PurcAnlys14', 
            'PurcAnlys15', 
            'PurcAnlys16', 
            'PurcAnlys17', 
            'PurcAnlys18', 
            'PurcAnlys19', 
            'PurcAnlys20', 
            'MvmtAnlys9', 
            'MvmtAnlys10', 
            'MvmtAnlys11', 
            'MvmtAnlys12', 
            'MvmtAnlys13', 
            'MvmtAnlys14', 
            'MvmtAnlys15', 
            'MvmtAnlys16', 
            'MvmtAnlys17', 
            'MvmtAnlys18', 
            'MvmtAnlys19', 
            'MvmtAnlys20', 
            'VochAnlys9', 
            'VochAnlys10', 
            'VochAnlys11', 
            'VochAnlys12', 
            'VochAnlys13', 
            'VochAnlys14', 
            'VochAnlys15', 
            'VochAnlys16', 
            'VochAnlys17', 
            'VochAnlys18', 
            'VochAnlys19', 
            'VochAnlys20', 
            'JordAnlys9', 
            'JordAnlys10', 
            'JordAnlys11', 
            'JordAnlys12', 
            'JordAnlys13', 
            'JordAnlys14', 
            'JordAnlys15', 
            'JordAnlys16', 
            'JordAnlys17', 
            'JordAnlys18', 
            'JordAnlys19', 
            'JordAnlys20', 
            'ArAnlys9', 
            'ArAnlys10', 
            'ArAnlys11', 
            'ArAnlys12', 
            'ArAnlys13', 
            'ArAnlys14', 
            'ArAnlys15', 
            'ArAnlys16', 
            'ArAnlys17', 
            'ArAnlys18', 
            'ArAnlys19', 
            'ArAnlys20', 
            'ApAnlys9', 
            'ApAnlys10', 
            'ApAnlys11', 
            'ApAnlys12', 
            'ApAnlys13', 
            'ApAnlys14', 
            'ApAnlys15', 
            'ApAnlys16', 
            'ApAnlys17', 
            'ApAnlys18', 
            'ApAnlys19', 
            'ApAnlys20', 
            'PrpeMoldAuditTrail', 
            'IcimIssueByAvailableQty', 
            'PrpmJamendIssueControl', 
            'PrAutoMultiSpareIssue', 
            'SlShipmentPriceControl', 
            'ArMultiSettle', 
            'PupoDefMultiship', 
            'PupoDefReorder', 
            'SlsoDefReorder', 
            'VochByVdate', 
            'PupoTaxTerms', 
            'SampleAcct', 
            'CtlFgRtnTotQty', 
            'AllowMultiWc', 
            'PoaIgnoreMinQty', 
            'GrnMatCost', 
            'GrnLotNoImport', 
            'IssueMaterialsByRouting', 
            'ConsumeMatInLastRouting', 
            'DefAqlLvlCritical', 
            'DefInspLvlSp', 
            'DefAqlLvlCriticalSp', 
            'DefAqlLvlMajSp', 
            'DefAqlLvlMinSp', 
            'WcAutoMatReturn', 
            'ArInvMultiPayTerms', 
            'IcAdjCodeAPcent', 
            'IcAdjCodeBPcent', 
            'IcAdjCodeCPcent', 
            'TailorIncludeJob', 
            'JoMultiSource', 
            'ShowShipmentInfoInPacking', 
            'MrpWithReorderPt', 
            'AllowFollowListWithoutMi', 
            'PrMultiFollowList', 
            'SqietkMatBalSubtractCommit', 
            'SoLineAutoIncBy', 
            'PoLineAutoIncBy', 
            'PuOverRcptByLine', 
            'PuLmeCost', 
            'SoaUpdatePendingShipment', 
            'PrMatIssueOnAvailPercent', 
            'JobHourlyRate', 
            'ItemCustomProdCodeRequired', 
            'IcimAutogenLotIssue', 
            'IcimAutogenSerialIssue', 
            'ShipmentInfoFromFirstOrder', 
            'MrpExcludeLeadtime', 
            'ItemPrelotSopo', 
            'SlsoCtrlBtmCeil', 
            'WcOverAcceptedLot', 
            'SlsoAutoResv', 
            'PercentA', 
            'PercentB', 
            'PercentC', 
            'EntryPostedRequirdBeforePrint'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

