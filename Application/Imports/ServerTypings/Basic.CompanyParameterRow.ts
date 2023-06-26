namespace Matrix.Basic {
    export interface CompanyParameterRow {
        Recnum?: number;
        CompanyName?: string;
        Address?: string;
        Address2?: string;
        Address3?: string;
        Address4?: string;
        PostCode?: string;
        TelNo?: string;
        FaxNo?: string;
        Email?: string;
        TaxAcctNo?: string;
        BusRegNo?: string;
        DrevisedDate?: string;
        DrevisedBy?: string;
        BranchNo?: string;
        BaseCurrency?: string;
        NoOfPeriods?: number;
        CurrentPeriod?: string;
        OpenPrdFrom?: string;
        OpenPrdTo?: string;
        AllowEntries?: string;
        AcctRetEarn?: string;
        AcctCurEarn?: string;
        AcctEndBs?: string;
        LocReceiving?: string;
        LocShipment?: string;
        LocPos?: string;
        LocMaterial?: string;
        LocProduce?: string;
        IcRevaluation?: string;
        FgStdCosting?: string;
        AllocMethod?: string;
        CostingMethod?: string;
        AllowLotOpt?: string;
        PmntFundCode?: string;
        RcptFundCode?: string;
        SalesPayTerms?: string;
        PurchPayTerms?: string;
        ItemGroup?: string;
        CustomerGroup?: string;
        VendorGroup?: string;
        SlCgtaxCode?: string;
        SlCltaxCode?: string;
        SlVgtaxCode?: string;
        SlVltaxCode?: string;
        SlItaxCode?: string;
        PuCgtaxCode?: string;
        PuCltaxCode?: string;
        PuVgtaxCode?: string;
        PuVltaxCode?: string;
        PuItaxCode?: string;
        WithTaxation?: string;
        ProcSalesGtax?: string;
        ProcSalesLtax?: string;
        ProcPurchGtax?: string;
        ProcPurchLtax?: string;
        TrevisedDate?: string;
        TrevisedBy?: string;
        RevisedDate?: string;
        RevisedBy?: string;
        AltName?: string;
        AltAddress?: string;
        AltAddress2?: string;
        AltAddress3?: string;
        AltAddress4?: string;
        MainBranPath?: string;
        MainBranCount?: number;
        OnlineBranUpd?: string;
        WithCostCtr?: string;
        WithDept?: string;
        WithBinCtrl?: string;
        WithInspection?: string;
        AcctItmAsset?: string;
        AcctItmWip?: string;
        AcctItmConsum?: string;
        AcctItmScrap?: string;
        AcctItmPvar?: string;
        AcctItmReval?: string;
        AcctItmVaria?: string;
        AcctItmSales?: string;
        AcctItmSlret?: string;
        AcctItmSldisc?: string;
        AcctItmCogs?: string;
        AcctItmPurch?: string;
        AcctItmPuret?: string;
        AcctItmPudisc?: string;
        AcctItmPutax?: string;
        AcctMvtIssue?: string;
        AcctMvtRcpt?: string;
        AcctMvtAdj?: string;
        AcctSlsMisc?: string;
        AcctSlsMscret?: string;
        AcctSlsTrdisc?: string;
        AcctSlsLntax?: string;
        AcctSlsGrtax?: string;
        AcctPurMisc?: string;
        AcctPurMscret?: string;
        AcctPurTrdisc?: string;
        AcctPurGrtax?: string;
        AcctArCash?: string;
        AcctArCust?: string;
        AcctArDisc?: string;
        AcctArAdj?: string;
        AcctArForex?: string;
        AcctApCash?: string;
        AcctApVend?: string;
        AcctApDisc?: string;
        AcctApAdj?: string;
        AcctApForex?: string;
        AcctApVaria?: string;
        AcctMachine?: string;
        AcctEnergy?: string;
        AcctWater?: string;
        AcctRental?: string;
        AcctLabor?: string;
        AcctInlab?: string;
        AcctInmat?: string;
        AcctMisc?: string;
        AcctSuspAr?: string;
        AcctSuspAp?: string;
        AcctSuspIc?: string;
        AcctSuspPr?: string;
        AcctSuspFa?: string;
        AcctSuspSub?: string;
        AcctSuspIncom?: string;
        AcctSuspExpen?: string;
        ArevisedDate?: string;
        ArevisedBy?: string;
        BrevisedDate?: string;
        BrevisedBy?: string;
        DeptProd?: string;
        DeptSales?: string;
        DeptPurch?: string;
        NoOfShift?: number;
        Shift1Hrs?: number;
        Shift2Hrs?: number;
        Shift3Hrs?: number;
        Shift1Start?: string;
        Shift2Start?: string;
        Shift3Start?: string;
        FirstWeekDay?: number;
        CanReceive1?: string;
        CanReceive2?: string;
        CanReceive3?: string;
        CanReceive4?: string;
        CanReceive5?: string;
        CanReceive6?: string;
        CanReceive7?: string;
        CanShip1?: string;
        CanShip2?: string;
        CanShip3?: string;
        CanShip4?: string;
        CanShip5?: string;
        CanShip6?: string;
        CanShip7?: string;
        IsHoliday1?: string;
        IsHoliday2?: string;
        IsHoliday3?: string;
        IsHoliday4?: string;
        IsHoliday5?: string;
        IsHoliday6?: string;
        IsHoliday7?: string;
        HalfDay1?: string;
        HalfDay2?: string;
        HalfDay3?: string;
        HalfDay4?: string;
        HalfDay5?: string;
        HalfDay6?: string;
        HalfDay7?: string;
        CrevisedDate?: string;
        CrevisedBy?: string;
        LogNoShip?: number;
        LogNoDlry?: number;
        LogNoMvmt?: number;
        LogNoArOpen?: number;
        LogNoApOpen?: number;
        LogNoLedg?: number;
        InvtCostAvail?: number;
        InvtCostLdg?: number;
        OnSalesCount?: number;
        OnPurchCount?: number;
        OnJobCount?: number;
        ArInvoAmtBal?: number;
        ArOpenAmtBal?: number;
        ArNetAmtBal?: number;
        ApInvoAmtBal?: number;
        ApOpenAmtBal?: number;
        ApNetAmtBal?: number;
        VerifySettings?: boolean;
        LogoBmp?: string;
        XconnectOn?: string;
        UloadPath?: string;
        UloadBatchNo?: number;
        DloadPath?: string;
        DloadBatchNo?: number;
        DloadRecnum?: number;
        DloadCommand?: string;
        UloadCommand?: string;
        CompanyCode?: string;
        WithBtob?: string;
        WithIms?: string;
        LineNoEntry?: string;
        AcctItmSubcon?: string;
        WithAccpac?: string;
        AccpacIgrp?: string;
        SaleAnlysInt?: string;
        PurcAnlysInt?: string;
        ProdAnlysInt?: string;
        MvmtAnlysInt?: string;
        AnlysCat1?: string;
        AnlysCat2?: string;
        AnlysCat3?: string;
        AnlysCat4?: string;
        AnlysInt?: string;
        ItmNoGridLen?: number;
        BomNoGridLen?: number;
        EnableLot?: string;
        EnableSerial?: string;
        LotNoLength?: number;
        SerialNoLength?: number;
        NextLotNo?: number;
        NextSerialNo?: number;
        MaxLotSize?: number;
        LotNoPrefix?: string;
        SerialNoPrefix?: string;
        WithLot?: string;
        ItmNoLen?: number;
        RecordLock?: string;
        UserLog?: string;
        ScalePrice?: number;
        NegStock?: string;
        WithSqlAttm?: string;
        WithResetLot?: string;
        WithResetSerial?: string;
        PrevResetLotDate?: string;
        PrevResetSerialDate?: string;
        AnlysCat5?: string;
        AnlysCat6?: string;
        AnlysCat7?: string;
        AnlysCat8?: string;
        AnlysCat9?: string;
        AnlysCat10?: string;
        CostSheetTabDescription1?: string;
        CostSheetTabDescription2?: string;
        CostSheetTabDescription3?: string;
        CostSheetTabDescription4?: string;
        CostSheetTabDescription5?: string;
        CostSheetTabDescription6?: string;
        CostSheetTabDescription7?: string;
        AcctArTemp?: string;
        AcctApTemp?: string;
        PlanOrdDefLastPoPrice?: boolean;
        PortalUrl?: string;
        KayueNextPoNo?: number;
        LotNoUdfLabel01?: string;
        LotNoUdfLabel02?: string;
        LotNoUdfLabel03?: string;
        LotNoUdfLabel04?: string;
        LotNoUdfLabel05?: string;
        BscPoOverBudgetPassword?: string;
        AcctArDeposit?: string;
        AcctApDeposit?: string;
        WithServerAttm?: string;
        FtpHost?: string;
        FtpUserId?: string;
        FtpPassword?: string;
        FtpNamePattern?: string;
        ImplementUomUppercase?: string;
        IntegratedEmailWithMsssageBox?: string;
        Cfg?: string;
    }

    export namespace CompanyParameterRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'CompanyName';
        export const localTextPrefix = 'BasicInformation.CompanyParameter';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const CompanyName: string;
            export declare const Address: string;
            export declare const Address2: string;
            export declare const Address3: string;
            export declare const Address4: string;
            export declare const PostCode: string;
            export declare const TelNo: string;
            export declare const FaxNo: string;
            export declare const Email: string;
            export declare const TaxAcctNo: string;
            export declare const BusRegNo: string;
            export declare const DrevisedDate: string;
            export declare const DrevisedBy: string;
            export declare const BranchNo: string;
            export declare const BaseCurrency: string;
            export declare const NoOfPeriods: string;
            export declare const CurrentPeriod: string;
            export declare const OpenPrdFrom: string;
            export declare const OpenPrdTo: string;
            export declare const AllowEntries: string;
            export declare const AcctRetEarn: string;
            export declare const AcctCurEarn: string;
            export declare const AcctEndBs: string;
            export declare const LocReceiving: string;
            export declare const LocShipment: string;
            export declare const LocPos: string;
            export declare const LocMaterial: string;
            export declare const LocProduce: string;
            export declare const IcRevaluation: string;
            export declare const FgStdCosting: string;
            export declare const AllocMethod: string;
            export declare const CostingMethod: string;
            export declare const AllowLotOpt: string;
            export declare const PmntFundCode: string;
            export declare const RcptFundCode: string;
            export declare const SalesPayTerms: string;
            export declare const PurchPayTerms: string;
            export declare const ItemGroup: string;
            export declare const CustomerGroup: string;
            export declare const VendorGroup: string;
            export declare const SlCgtaxCode: string;
            export declare const SlCltaxCode: string;
            export declare const SlVgtaxCode: string;
            export declare const SlVltaxCode: string;
            export declare const SlItaxCode: string;
            export declare const PuCgtaxCode: string;
            export declare const PuCltaxCode: string;
            export declare const PuVgtaxCode: string;
            export declare const PuVltaxCode: string;
            export declare const PuItaxCode: string;
            export declare const WithTaxation: string;
            export declare const ProcSalesGtax: string;
            export declare const ProcSalesLtax: string;
            export declare const ProcPurchGtax: string;
            export declare const ProcPurchLtax: string;
            export declare const TrevisedDate: string;
            export declare const TrevisedBy: string;
            export declare const RevisedDate: string;
            export declare const RevisedBy: string;
            export declare const AltName: string;
            export declare const AltAddress: string;
            export declare const AltAddress2: string;
            export declare const AltAddress3: string;
            export declare const AltAddress4: string;
            export declare const MainBranPath: string;
            export declare const MainBranCount: string;
            export declare const OnlineBranUpd: string;
            export declare const WithCostCtr: string;
            export declare const WithDept: string;
            export declare const WithBinCtrl: string;
            export declare const WithInspection: string;
            export declare const AcctItmAsset: string;
            export declare const AcctItmWip: string;
            export declare const AcctItmConsum: string;
            export declare const AcctItmScrap: string;
            export declare const AcctItmPvar: string;
            export declare const AcctItmReval: string;
            export declare const AcctItmVaria: string;
            export declare const AcctItmSales: string;
            export declare const AcctItmSlret: string;
            export declare const AcctItmSldisc: string;
            export declare const AcctItmCogs: string;
            export declare const AcctItmPurch: string;
            export declare const AcctItmPuret: string;
            export declare const AcctItmPudisc: string;
            export declare const AcctItmPutax: string;
            export declare const AcctMvtIssue: string;
            export declare const AcctMvtRcpt: string;
            export declare const AcctMvtAdj: string;
            export declare const AcctSlsMisc: string;
            export declare const AcctSlsMscret: string;
            export declare const AcctSlsTrdisc: string;
            export declare const AcctSlsLntax: string;
            export declare const AcctSlsGrtax: string;
            export declare const AcctPurMisc: string;
            export declare const AcctPurMscret: string;
            export declare const AcctPurTrdisc: string;
            export declare const AcctPurGrtax: string;
            export declare const AcctArCash: string;
            export declare const AcctArCust: string;
            export declare const AcctArDisc: string;
            export declare const AcctArAdj: string;
            export declare const AcctArForex: string;
            export declare const AcctApCash: string;
            export declare const AcctApVend: string;
            export declare const AcctApDisc: string;
            export declare const AcctApAdj: string;
            export declare const AcctApForex: string;
            export declare const AcctApVaria: string;
            export declare const AcctMachine: string;
            export declare const AcctEnergy: string;
            export declare const AcctWater: string;
            export declare const AcctRental: string;
            export declare const AcctLabor: string;
            export declare const AcctInlab: string;
            export declare const AcctInmat: string;
            export declare const AcctMisc: string;
            export declare const AcctSuspAr: string;
            export declare const AcctSuspAp: string;
            export declare const AcctSuspIc: string;
            export declare const AcctSuspPr: string;
            export declare const AcctSuspFa: string;
            export declare const AcctSuspSub: string;
            export declare const AcctSuspIncom: string;
            export declare const AcctSuspExpen: string;
            export declare const ArevisedDate: string;
            export declare const ArevisedBy: string;
            export declare const BrevisedDate: string;
            export declare const BrevisedBy: string;
            export declare const DeptProd: string;
            export declare const DeptSales: string;
            export declare const DeptPurch: string;
            export declare const NoOfShift: string;
            export declare const Shift1Hrs: string;
            export declare const Shift2Hrs: string;
            export declare const Shift3Hrs: string;
            export declare const Shift1Start: string;
            export declare const Shift2Start: string;
            export declare const Shift3Start: string;
            export declare const FirstWeekDay: string;
            export declare const CanReceive1: string;
            export declare const CanReceive2: string;
            export declare const CanReceive3: string;
            export declare const CanReceive4: string;
            export declare const CanReceive5: string;
            export declare const CanReceive6: string;
            export declare const CanReceive7: string;
            export declare const CanShip1: string;
            export declare const CanShip2: string;
            export declare const CanShip3: string;
            export declare const CanShip4: string;
            export declare const CanShip5: string;
            export declare const CanShip6: string;
            export declare const CanShip7: string;
            export declare const IsHoliday1: string;
            export declare const IsHoliday2: string;
            export declare const IsHoliday3: string;
            export declare const IsHoliday4: string;
            export declare const IsHoliday5: string;
            export declare const IsHoliday6: string;
            export declare const IsHoliday7: string;
            export declare const HalfDay1: string;
            export declare const HalfDay2: string;
            export declare const HalfDay3: string;
            export declare const HalfDay4: string;
            export declare const HalfDay5: string;
            export declare const HalfDay6: string;
            export declare const HalfDay7: string;
            export declare const CrevisedDate: string;
            export declare const CrevisedBy: string;
            export declare const LogNoShip: string;
            export declare const LogNoDlry: string;
            export declare const LogNoMvmt: string;
            export declare const LogNoArOpen: string;
            export declare const LogNoApOpen: string;
            export declare const LogNoLedg: string;
            export declare const InvtCostAvail: string;
            export declare const InvtCostLdg: string;
            export declare const OnSalesCount: string;
            export declare const OnPurchCount: string;
            export declare const OnJobCount: string;
            export declare const ArInvoAmtBal: string;
            export declare const ArOpenAmtBal: string;
            export declare const ArNetAmtBal: string;
            export declare const ApInvoAmtBal: string;
            export declare const ApOpenAmtBal: string;
            export declare const ApNetAmtBal: string;
            export declare const VerifySettings: string;
            export declare const LogoBmp: string;
            export declare const XconnectOn: string;
            export declare const UloadPath: string;
            export declare const UloadBatchNo: string;
            export declare const DloadPath: string;
            export declare const DloadBatchNo: string;
            export declare const DloadRecnum: string;
            export declare const DloadCommand: string;
            export declare const UloadCommand: string;
            export declare const CompanyCode: string;
            export declare const WithBtob: string;
            export declare const WithIms: string;
            export declare const LineNoEntry: string;
            export declare const AcctItmSubcon: string;
            export declare const WithAccpac: string;
            export declare const AccpacIgrp: string;
            export declare const SaleAnlysInt: string;
            export declare const PurcAnlysInt: string;
            export declare const ProdAnlysInt: string;
            export declare const MvmtAnlysInt: string;
            export declare const AnlysCat1: string;
            export declare const AnlysCat2: string;
            export declare const AnlysCat3: string;
            export declare const AnlysCat4: string;
            export declare const AnlysInt: string;
            export declare const ItmNoGridLen: string;
            export declare const BomNoGridLen: string;
            export declare const EnableLot: string;
            export declare const EnableSerial: string;
            export declare const LotNoLength: string;
            export declare const SerialNoLength: string;
            export declare const NextLotNo: string;
            export declare const NextSerialNo: string;
            export declare const MaxLotSize: string;
            export declare const LotNoPrefix: string;
            export declare const SerialNoPrefix: string;
            export declare const WithLot: string;
            export declare const ItmNoLen: string;
            export declare const RecordLock: string;
            export declare const UserLog: string;
            export declare const ScalePrice: string;
            export declare const NegStock: string;
            export declare const WithSqlAttm: string;
            export declare const WithResetLot: string;
            export declare const WithResetSerial: string;
            export declare const PrevResetLotDate: string;
            export declare const PrevResetSerialDate: string;
            export declare const AnlysCat5: string;
            export declare const AnlysCat6: string;
            export declare const AnlysCat7: string;
            export declare const AnlysCat8: string;
            export declare const AnlysCat9: string;
            export declare const AnlysCat10: string;
            export declare const CostSheetTabDescription1: string;
            export declare const CostSheetTabDescription2: string;
            export declare const CostSheetTabDescription3: string;
            export declare const CostSheetTabDescription4: string;
            export declare const CostSheetTabDescription5: string;
            export declare const CostSheetTabDescription6: string;
            export declare const CostSheetTabDescription7: string;
            export declare const AcctArTemp: string;
            export declare const AcctApTemp: string;
            export declare const PlanOrdDefLastPoPrice: string;
            export declare const PortalUrl: string;
            export declare const KayueNextPoNo: string;
            export declare const LotNoUdfLabel01: string;
            export declare const LotNoUdfLabel02: string;
            export declare const LotNoUdfLabel03: string;
            export declare const LotNoUdfLabel04: string;
            export declare const LotNoUdfLabel05: string;
            export declare const BscPoOverBudgetPassword: string;
            export declare const AcctArDeposit: string;
            export declare const AcctApDeposit: string;
            export declare const WithServerAttm: string;
            export declare const FtpHost: string;
            export declare const FtpUserId: string;
            export declare const FtpPassword: string;
            export declare const FtpNamePattern: string;
            export declare const ImplementUomUppercase: string;
            export declare const IntegratedEmailWithMsssageBox: string;
            export declare const Cfg: string;
        }

        [
            'Recnum', 
            'CompanyName', 
            'Address', 
            'Address2', 
            'Address3', 
            'Address4', 
            'PostCode', 
            'TelNo', 
            'FaxNo', 
            'Email', 
            'TaxAcctNo', 
            'BusRegNo', 
            'DrevisedDate', 
            'DrevisedBy', 
            'BranchNo', 
            'BaseCurrency', 
            'NoOfPeriods', 
            'CurrentPeriod', 
            'OpenPrdFrom', 
            'OpenPrdTo', 
            'AllowEntries', 
            'AcctRetEarn', 
            'AcctCurEarn', 
            'AcctEndBs', 
            'LocReceiving', 
            'LocShipment', 
            'LocPos', 
            'LocMaterial', 
            'LocProduce', 
            'IcRevaluation', 
            'FgStdCosting', 
            'AllocMethod', 
            'CostingMethod', 
            'AllowLotOpt', 
            'PmntFundCode', 
            'RcptFundCode', 
            'SalesPayTerms', 
            'PurchPayTerms', 
            'ItemGroup', 
            'CustomerGroup', 
            'VendorGroup', 
            'SlCgtaxCode', 
            'SlCltaxCode', 
            'SlVgtaxCode', 
            'SlVltaxCode', 
            'SlItaxCode', 
            'PuCgtaxCode', 
            'PuCltaxCode', 
            'PuVgtaxCode', 
            'PuVltaxCode', 
            'PuItaxCode', 
            'WithTaxation', 
            'ProcSalesGtax', 
            'ProcSalesLtax', 
            'ProcPurchGtax', 
            'ProcPurchLtax', 
            'TrevisedDate', 
            'TrevisedBy', 
            'RevisedDate', 
            'RevisedBy', 
            'AltName', 
            'AltAddress', 
            'AltAddress2', 
            'AltAddress3', 
            'AltAddress4', 
            'MainBranPath', 
            'MainBranCount', 
            'OnlineBranUpd', 
            'WithCostCtr', 
            'WithDept', 
            'WithBinCtrl', 
            'WithInspection', 
            'AcctItmAsset', 
            'AcctItmWip', 
            'AcctItmConsum', 
            'AcctItmScrap', 
            'AcctItmPvar', 
            'AcctItmReval', 
            'AcctItmVaria', 
            'AcctItmSales', 
            'AcctItmSlret', 
            'AcctItmSldisc', 
            'AcctItmCogs', 
            'AcctItmPurch', 
            'AcctItmPuret', 
            'AcctItmPudisc', 
            'AcctItmPutax', 
            'AcctMvtIssue', 
            'AcctMvtRcpt', 
            'AcctMvtAdj', 
            'AcctSlsMisc', 
            'AcctSlsMscret', 
            'AcctSlsTrdisc', 
            'AcctSlsLntax', 
            'AcctSlsGrtax', 
            'AcctPurMisc', 
            'AcctPurMscret', 
            'AcctPurTrdisc', 
            'AcctPurGrtax', 
            'AcctArCash', 
            'AcctArCust', 
            'AcctArDisc', 
            'AcctArAdj', 
            'AcctArForex', 
            'AcctApCash', 
            'AcctApVend', 
            'AcctApDisc', 
            'AcctApAdj', 
            'AcctApForex', 
            'AcctApVaria', 
            'AcctMachine', 
            'AcctEnergy', 
            'AcctWater', 
            'AcctRental', 
            'AcctLabor', 
            'AcctInlab', 
            'AcctInmat', 
            'AcctMisc', 
            'AcctSuspAr', 
            'AcctSuspAp', 
            'AcctSuspIc', 
            'AcctSuspPr', 
            'AcctSuspFa', 
            'AcctSuspSub', 
            'AcctSuspIncom', 
            'AcctSuspExpen', 
            'ArevisedDate', 
            'ArevisedBy', 
            'BrevisedDate', 
            'BrevisedBy', 
            'DeptProd', 
            'DeptSales', 
            'DeptPurch', 
            'NoOfShift', 
            'Shift1Hrs', 
            'Shift2Hrs', 
            'Shift3Hrs', 
            'Shift1Start', 
            'Shift2Start', 
            'Shift3Start', 
            'FirstWeekDay', 
            'CanReceive1', 
            'CanReceive2', 
            'CanReceive3', 
            'CanReceive4', 
            'CanReceive5', 
            'CanReceive6', 
            'CanReceive7', 
            'CanShip1', 
            'CanShip2', 
            'CanShip3', 
            'CanShip4', 
            'CanShip5', 
            'CanShip6', 
            'CanShip7', 
            'IsHoliday1', 
            'IsHoliday2', 
            'IsHoliday3', 
            'IsHoliday4', 
            'IsHoliday5', 
            'IsHoliday6', 
            'IsHoliday7', 
            'HalfDay1', 
            'HalfDay2', 
            'HalfDay3', 
            'HalfDay4', 
            'HalfDay5', 
            'HalfDay6', 
            'HalfDay7', 
            'CrevisedDate', 
            'CrevisedBy', 
            'LogNoShip', 
            'LogNoDlry', 
            'LogNoMvmt', 
            'LogNoArOpen', 
            'LogNoApOpen', 
            'LogNoLedg', 
            'InvtCostAvail', 
            'InvtCostLdg', 
            'OnSalesCount', 
            'OnPurchCount', 
            'OnJobCount', 
            'ArInvoAmtBal', 
            'ArOpenAmtBal', 
            'ArNetAmtBal', 
            'ApInvoAmtBal', 
            'ApOpenAmtBal', 
            'ApNetAmtBal', 
            'VerifySettings', 
            'LogoBmp', 
            'XconnectOn', 
            'UloadPath', 
            'UloadBatchNo', 
            'DloadPath', 
            'DloadBatchNo', 
            'DloadRecnum', 
            'DloadCommand', 
            'UloadCommand', 
            'CompanyCode', 
            'WithBtob', 
            'WithIms', 
            'LineNoEntry', 
            'AcctItmSubcon', 
            'WithAccpac', 
            'AccpacIgrp', 
            'SaleAnlysInt', 
            'PurcAnlysInt', 
            'ProdAnlysInt', 
            'MvmtAnlysInt', 
            'AnlysCat1', 
            'AnlysCat2', 
            'AnlysCat3', 
            'AnlysCat4', 
            'AnlysInt', 
            'ItmNoGridLen', 
            'BomNoGridLen', 
            'EnableLot', 
            'EnableSerial', 
            'LotNoLength', 
            'SerialNoLength', 
            'NextLotNo', 
            'NextSerialNo', 
            'MaxLotSize', 
            'LotNoPrefix', 
            'SerialNoPrefix', 
            'WithLot', 
            'ItmNoLen', 
            'RecordLock', 
            'UserLog', 
            'ScalePrice', 
            'NegStock', 
            'WithSqlAttm', 
            'WithResetLot', 
            'WithResetSerial', 
            'PrevResetLotDate', 
            'PrevResetSerialDate', 
            'AnlysCat5', 
            'AnlysCat6', 
            'AnlysCat7', 
            'AnlysCat8', 
            'AnlysCat9', 
            'AnlysCat10', 
            'CostSheetTabDescription1', 
            'CostSheetTabDescription2', 
            'CostSheetTabDescription3', 
            'CostSheetTabDescription4', 
            'CostSheetTabDescription5', 
            'CostSheetTabDescription6', 
            'CostSheetTabDescription7', 
            'AcctArTemp', 
            'AcctApTemp', 
            'PlanOrdDefLastPoPrice', 
            'PortalUrl', 
            'KayueNextPoNo', 
            'LotNoUdfLabel01', 
            'LotNoUdfLabel02', 
            'LotNoUdfLabel03', 
            'LotNoUdfLabel04', 
            'LotNoUdfLabel05', 
            'BscPoOverBudgetPassword', 
            'AcctArDeposit', 
            'AcctApDeposit', 
            'WithServerAttm', 
            'FtpHost', 
            'FtpUserId', 
            'FtpPassword', 
            'FtpNamePattern', 
            'ImplementUomUppercase', 
            'IntegratedEmailWithMsssageBox', 
            'Cfg'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

