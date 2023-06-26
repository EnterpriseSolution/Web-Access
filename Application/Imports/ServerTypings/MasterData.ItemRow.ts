namespace Matrix.MasterData {
    export interface ItemRow {
        LookupDescription?: string;
        Recnum?: number;
        ItemNo?: string;
        Description?: string;
        Suspended?: boolean;
        ItemGroup?: string;
        Charges?: string;
        Product?: boolean;
        Material?: boolean;
        Inspected?: string;
        ItemType?: string;
        StockUom?: string;
        MainLoc?: string;
        MakeBuy?: boolean;
        AllocMethod?: string;
        StdCostOk?: string;
        CostCentre?: string;
        CycleCode?: string;
        Anlys1?: string;
        Anlys2?: string;
        Anlys3?: string;
        Anlys4?: string;
        DefSpecNo?: string;
        DefSpecCount?: number;
        CreatedDate?: string;
        CreatedBy?: string;
        RevisedDate?: string;
        RevisedBy?: string;
        WithBacklog?: string;
        WithBalance?: string;
        QtyOnHand?: number;
        QtyOnSorder?: number;
        QtyOnPorder?: number;
        QtyOnJorder?: number;
        QtyOnInspect?: number;
        QtyWaitlisted?: number;
        QtyReserved?: number;
        QtyCommitted?: number;
        QtyAvailable?: number;
        QtyUnallocated?: number;
        InvtCostAvail?: number;
        InvtCostLdg?: number;
        AverageCost?: string;
        LatestCost?: number;
        StdCost?: number;
        LastCountDate?: string;
        LastDateIn?: string;
        LastDateOut?: string;
        SalesUom?: string;
        SalesLotSize?: number;
        PriceCcy?: string;
        BasePrice?: number;
        Pricea?: number;
        Priceb?: number;
        Pricec?: number;
        MinPrice?: number;
        MaxPrice?: number;
        MinOrderQty?: number;
        MaxOrderQty?: number;
        MinOrderDays?: number;
        InnerPkgType?: string;
        InnerQty?: number;
        OuterPkgType?: string;
        OuterQty?: number;
        ArticleCode?: string;
        QuotaCategory?: string;
        WeightUom?: string;
        GrossWt?: number;
        NetWt?: number;
        DimensionUom?: string;
        Flength?: number;
        Width?: number;
        Height?: number;
        ComputedVol?: number;
        DeclaredVol?: number;
        SrevisedDate?: string;
        SrevisedBy?: string;
        MpsItem?: string;
        OrderPolicy?: string;
        MinPlanordQty?: number;
        MaxPlanordQty?: number;
        StdPlanordQty?: number;
        MinPlanordPrd?: number;
        MaxPlanordPrd?: number;
        StdPlanordPrd?: number;
        ReorderPt?: number;
        ReorderQty?: number;
        MinMthlyProd?: number;
        MaxMthlyProd?: number;
        MinMthlyPur?: number;
        MaxMthlyPur?: number;
        FollowMinProd?: string;
        FollowMaxProd?: string;
        FollowMinPur?: string;
        FollowMaxPur?: string;
        AllowMixMode?: string;
        PrefVendOnly?: string;
        PrefVend1?: string;
        PrefVend2?: string;
        ProdLeadTime?: number;
        ProdLeadUnit?: string;
        PurLeadTime?: number;
        PurLeadUnit?: string;
        Planner?: string;
        MrpParmDate?: string;
        MrpParmBy?: string;
        AltDescription?: string;
        PictureFile?: string;
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
        AcctMachine?: string;
        AcctEnergy?: string;
        AcctWater?: string;
        AcctRental?: string;
        AcctLabor?: string;
        AcctInlab?: string;
        AcctInmat?: string;
        AcctMisc?: string;
        ArevisedDate?: string;
        ArevisedBy?: string;
        BrevisedDate?: string;
        BrevisedBy?: string;
        SalesLtaxCode?: string;
        PurchLtaxCode?: string;
        TrevisedDate?: string;
        TrevisedBy?: string;
        SpecsCount?: number;
        DefBomNo?: string;
        LastSnapNo?: number;
        CommisType?: string;
        ProdBranch?: string;
        OwnerBranch?: string;
        SourceBranch?: string;
        ScrapRate?: number;
        AltExtDesc?: string;
        ExtendedDesc?: string;
        PurPriceCtrl?: string;
        PurMaxDev?: number;
        WebItem?: string;
        AcctItmSubcon?: string;
        WithBinCtrl?: string;
        Consign?: string;
        ProdDevt01?: string;
        ProdDevt02?: string;
        ProdDevt03?: string;
        ProdDevt04?: string;
        ProdDevt05?: string;
        ProdDevt06?: string;
        ProdDevt07?: string;
        ProdDevt08?: string;
        ProdDevt09?: string;
        ProdDevt10?: string;
        ProdDevt11?: string;
        ProdDevt12?: string;
        ProdDevt13?: string;
        ProdDevt14?: string;
        ProdDevt15?: string;
        ProdDevt16?: string;
        ProdDevt17?: string;
        ProdDevt18?: string;
        ProdDevt19?: string;
        ProdDevt20?: string;
        ProdCheck01?: string;
        ProdCheck02?: string;
        ProdCheck03?: string;
        ProdCheck04?: string;
        ProdCheck05?: string;
        ProdCheck06?: string;
        ProdCheck07?: string;
        ProdCheck08?: string;
        ProdCheck09?: string;
        ProdCheck10?: string;
        ProdCheck11?: string;
        ProdCheck12?: string;
        ProdCheck13?: string;
        ProdCheck14?: string;
        ProdCheck15?: string;
        ProdCheck16?: string;
        ProdCheck17?: string;
        ProdCheck18?: string;
        ProdCheck19?: string;
        ProdCheck20?: string;
        LastPackLineNo?: number;
        PutaxPcent?: number;
        AcctItmSltax?: string;
        SltaxPcent?: number;
        PurUom?: string;
        PurLotSize?: number;
        PurCcy?: string;
        PurBasePrice?: number;
        QtyNetAvailable?: number;
        UseStdProdLeadTime?: string;
        DailyProdQty?: number;
        IssueLotSize?: number;
        MrpExclude?: string;
        EnableLot?: string;
        EnableSerial?: string;
        LotNoLength?: number;
        SerialNoLength?: number;
        NextLotNo?: number;
        NextSerialNo?: number;
        MaxLotSize?: number;
        LotNoPrefix?: string;
        SerialNoPrefix?: string;
        SafeStockLvl?: number;
        MainBin?: string;
        CustomProdCode?: string;
        CustomLotSize?: number;
        CustomGrUom?: string;
        CustomGrWt?: number;
        CustomNtWt?: number;
        CustomOrigin?: string;
        IsApproved?: string;
        ApprovedBy?: string;
        Preapprove?: string;
        ApprovedDate?: string;
        QtyOnTransfer?: number;
        WithResetLot?: string;
        WithResetSerial?: string;
        PrevResetLotDate?: string;
        PrevResetSerialDate?: string;
        AutogenLot?: string;
        AutogenSerial?: string;
        FabItem?: string;
        Anlys5?: string;
        Anlys6?: string;
        Anlys7?: string;
        Anlys8?: string;
        Anlys9?: string;
        Anlys10?: string;
        UserDefinedField1?: string;
        UserDefinedField2?: string;
        UserDefinedField3?: string;
        UserDefinedField4?: string;
        UserDefinedField5?: string;
        UserDefinedField6?: string;
        UserDefinedField7?: string;
        UserDefinedField8?: string;
        UserDefinedField9?: string;
        UserDefinedField10?: string;
        UserDefinedField11?: string;
        UserDefinedField12?: string;
        UserDefinedField13?: string;
        UserDefinedField14?: string;
        UserDefinedField15?: string;
        UserDefinedField16?: string;
        UserDefinedField17?: string;
        UserDefinedField18?: string;
        UserDefinedField19?: string;
        UserDefinedField20?: string;
        RohsCompliance?: boolean;
        DefMoldBomNo?: string;
        DefFormulaCode?: string;
        BoxType?: string;
        BoxLength?: number;
        BoxWidth?: number;
        BoxHeight?: number;
        BoxDUom?: string;
        Wd?: number;
        WdUom?: string;
        CsLength?: number;
        CsWidth?: number;
        UserDefinedField21?: string;
        CostWmove?: number;
        CostWcase?: number;
        CostWband?: number;
        CostBatt?: number;
        DescWmove?: string;
        DescWcase?: string;
        DescWband?: string;
        DescBatt?: string;
        PoBal?: number;
        PoMaxBal?: number;
        IncludeJob?: boolean;
        CsThickness?: number;
        CsThicknessUom?: string;
        CsProportion?: number;
        CsProportionUom?: string;
        DieCutter?: number;
        MatInspectLeadTime?: number;
        MatPrepareLeadTime?: number;
        MatInspectLeadUnit?: string;
        MatPrepareLeadUnit?: string;
        ColorCode?: string;
        CollectionCode?: string;
        StyleCode?: string;
        X?: number;
        Y?: number;
        TempDescription?: string;
        Specification?: string;
        XUom?: string;
        YUom?: string;
        ProductionUomConversionRate?: number;
        PurchaseUomConversionRate?: number;
        AutogenLotIssue?: boolean;
        AutogenSerialIssue?: boolean;
        WcCostCcy?: string;
        WcCost?: number;
        WcCostDisc?: number;
        WcCostExch?: number;
        WcFreight?: number;
        WcMargin?: number;
        CeilingPrice?: number;
        BottomRatio?: number;
        BottomPrice?: number;
        DrawingNo?: string;
        MaterialType?: string;
        ItemGroupRecnum?: number;
        ItemGroupDescription?: string;
        ItemGroupSuspended?: string;
        ItemGroupProduct?: string;
        ItemGroupMaterial?: string;
        ItemGroupInspected?: string;
        ItemGroupCostCentre?: string;
        ItemGroupItemType?: string;
        ItemGroupAllocMethod?: string;
        ItemGroupProdBranch?: string;
        ItemGroupAcctItmAsset?: string;
        ItemGroupAcctItmWip?: string;
        ItemGroupAcctItmConsum?: string;
        ItemGroupAcctItmScrap?: string;
        ItemGroupAcctItmPvar?: string;
        ItemGroupAcctItmReval?: string;
        ItemGroupAcctItmVaria?: string;
        ItemGroupAcctItmSales?: string;
        ItemGroupAcctItmSlret?: string;
        ItemGroupAcctItmSldisc?: string;
        ItemGroupAcctItmCogs?: string;
        ItemGroupAcctItmPurch?: string;
        ItemGroupAcctItmPuret?: string;
        ItemGroupAcctItmPudisc?: string;
        ItemGroupAcctItmPutax?: string;
        ItemGroupAcctMachine?: string;
        ItemGroupAcctEnergy?: string;
        ItemGroupAcctWater?: string;
        ItemGroupAcctRental?: string;
        ItemGroupAcctLabor?: string;
        ItemGroupAcctInlab?: string;
        ItemGroupAcctInmat?: string;
        ItemGroupAcctMisc?: string;
        ItemGroupArevisedDate?: string;
        ItemGroupArevisedBy?: string;
        ItemGroupBrevisedDate?: string;
        ItemGroupBrevisedBy?: string;
        ItemGroupMakeOrBuy?: string;
        ItemGroupTypicalUom?: string;
        ItemGroupCycleCode?: string;
        ItemGroupSalesLtaxCode?: string;
        ItemGroupPurchLtaxCode?: string;
        ItemGroupInnerPkgType?: string;
        ItemGroupInnerQty?: number;
        ItemGroupOuterPkgType?: string;
        ItemGroupOuterQty?: number;
        ItemGroupAnlys1?: string;
        ItemGroupAnlys2?: string;
        ItemGroupAnlys3?: string;
        ItemGroupAnlys4?: string;
        ItemGroupItemCount?: number;
        ItemGroupCreatedDate?: string;
        ItemGroupCreatedBy?: string;
        ItemGroupRevisedDate?: string;
        ItemGroupRevisedBy?: string;
        ItemGroupTrevisedDate?: string;
        ItemGroupTrevisedBy?: string;
        ItemGroupCommisType?: string;
        ItemGroupOwnerBranch?: string;
        ItemGroupSourceBranch?: string;
        ItemGroupScrapRate?: number;
        ItemGroupPurPriceCtrl?: string;
        ItemGroupPurMaxDev?: number;
        ItemGroupAcctItmSubcon?: string;
        ItemGroupConsolidate?: string;
        ItemGroupPutaxPcent?: number;
        ItemGroupAcctItmSltax?: string;
        ItemGroupSltaxPcent?: number;
        ItemGroupEnableLot?: string;
        ItemGroupEnableSerial?: string;
        ItemGroupLotNoLength?: number;
        ItemGroupSerialNoLength?: number;
        ItemGroupNextLotNo?: number;
        ItemGroupNextSerialNo?: number;
        ItemGroupMaxLotSize?: number;
        ItemGroupLotNoPrefix?: string;
        ItemGroupSerialNoPrefix?: string;
        ItemGroupDevtCat01?: string;
        ItemGroupDevtCat02?: string;
        ItemGroupDevtCat03?: string;
        ItemGroupDevtCat04?: string;
        ItemGroupDevtCat05?: string;
        ItemGroupDevtCat06?: string;
        ItemGroupDevtCat07?: string;
        ItemGroupDevtCat08?: string;
        ItemGroupDevtCat09?: string;
        ItemGroupDevtCat10?: string;
        ItemGroupDevtCat11?: string;
        ItemGroupDevtCat12?: string;
        ItemGroupDevtCat13?: string;
        ItemGroupDevtCat14?: string;
        ItemGroupDevtCat15?: string;
        ItemGroupDevtCat16?: string;
        ItemGroupDevtCat17?: string;
        ItemGroupDevtCat18?: string;
        ItemGroupDevtCat19?: string;
        ItemGroupDevtCat20?: string;
        ItemGroupMainLoc?: string;
        ItemGroupMainBin?: string;
        ItemGroupWithResetLot?: string;
        ItemGroupWithResetSerial?: string;
        ItemGroupPrevResetLotDate?: string;
        ItemGroupPrevResetSerialDate?: string;
        ItemGroupBomRohsControl?: boolean;
        ItemGroupAnlys5?: string;
        ItemGroupAnlys6?: string;
        ItemGroupAnlys7?: string;
        ItemGroupAnlys8?: string;
        ItemGroupAnlys9?: string;
        ItemGroupAnlys10?: string;
        ItemGroupAutogenLot?: boolean;
        ItemGroupAutogenSerial?: boolean;
        ItemGroupNoScrapInMatIssue?: boolean;
        ItemGroupAutogenLotIssue?: boolean;
        ItemGroupAutogenSerialIssue?: boolean;
    }

    export namespace ItemRow {
        export const idProperty = 'ItemNo';
        export const nameProperty = 'ItemNo';
        export const localTextPrefix = 'MasterData.Item';
        export const lookupKey = 'MasterData.ItemRow';

        export function getLookup(): Q.Lookup<ItemRow> {
            return Q.getLookup<ItemRow>('MasterData.ItemRow');
        }

        export namespace Fields {
            export declare const LookupDescription: string;
            export declare const Recnum: string;
            export declare const ItemNo: string;
            export declare const Description: string;
            export declare const Suspended: string;
            export declare const ItemGroup: string;
            export declare const Charges: string;
            export declare const Product: string;
            export declare const Material: string;
            export declare const Inspected: string;
            export declare const ItemType: string;
            export declare const StockUom: string;
            export declare const MainLoc: string;
            export declare const MakeBuy: string;
            export declare const AllocMethod: string;
            export declare const StdCostOk: string;
            export declare const CostCentre: string;
            export declare const CycleCode: string;
            export declare const Anlys1: string;
            export declare const Anlys2: string;
            export declare const Anlys3: string;
            export declare const Anlys4: string;
            export declare const DefSpecNo: string;
            export declare const DefSpecCount: string;
            export declare const CreatedDate: string;
            export declare const CreatedBy: string;
            export declare const RevisedDate: string;
            export declare const RevisedBy: string;
            export declare const WithBacklog: string;
            export declare const WithBalance: string;
            export declare const QtyOnHand: string;
            export declare const QtyOnSorder: string;
            export declare const QtyOnPorder: string;
            export declare const QtyOnJorder: string;
            export declare const QtyOnInspect: string;
            export declare const QtyWaitlisted: string;
            export declare const QtyReserved: string;
            export declare const QtyCommitted: string;
            export declare const QtyAvailable: string;
            export declare const QtyUnallocated: string;
            export declare const InvtCostAvail: string;
            export declare const InvtCostLdg: string;
            export declare const AverageCost: string;
            export declare const LatestCost: string;
            export declare const StdCost: string;
            export declare const LastCountDate: string;
            export declare const LastDateIn: string;
            export declare const LastDateOut: string;
            export declare const SalesUom: string;
            export declare const SalesLotSize: string;
            export declare const PriceCcy: string;
            export declare const BasePrice: string;
            export declare const Pricea: string;
            export declare const Priceb: string;
            export declare const Pricec: string;
            export declare const MinPrice: string;
            export declare const MaxPrice: string;
            export declare const MinOrderQty: string;
            export declare const MaxOrderQty: string;
            export declare const MinOrderDays: string;
            export declare const InnerPkgType: string;
            export declare const InnerQty: string;
            export declare const OuterPkgType: string;
            export declare const OuterQty: string;
            export declare const ArticleCode: string;
            export declare const QuotaCategory: string;
            export declare const WeightUom: string;
            export declare const GrossWt: string;
            export declare const NetWt: string;
            export declare const DimensionUom: string;
            export declare const Flength: string;
            export declare const Width: string;
            export declare const Height: string;
            export declare const ComputedVol: string;
            export declare const DeclaredVol: string;
            export declare const SrevisedDate: string;
            export declare const SrevisedBy: string;
            export declare const MpsItem: string;
            export declare const OrderPolicy: string;
            export declare const MinPlanordQty: string;
            export declare const MaxPlanordQty: string;
            export declare const StdPlanordQty: string;
            export declare const MinPlanordPrd: string;
            export declare const MaxPlanordPrd: string;
            export declare const StdPlanordPrd: string;
            export declare const ReorderPt: string;
            export declare const ReorderQty: string;
            export declare const MinMthlyProd: string;
            export declare const MaxMthlyProd: string;
            export declare const MinMthlyPur: string;
            export declare const MaxMthlyPur: string;
            export declare const FollowMinProd: string;
            export declare const FollowMaxProd: string;
            export declare const FollowMinPur: string;
            export declare const FollowMaxPur: string;
            export declare const AllowMixMode: string;
            export declare const PrefVendOnly: string;
            export declare const PrefVend1: string;
            export declare const PrefVend2: string;
            export declare const ProdLeadTime: string;
            export declare const ProdLeadUnit: string;
            export declare const PurLeadTime: string;
            export declare const PurLeadUnit: string;
            export declare const Planner: string;
            export declare const MrpParmDate: string;
            export declare const MrpParmBy: string;
            export declare const AltDescription: string;
            export declare const PictureFile: string;
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
            export declare const AcctMachine: string;
            export declare const AcctEnergy: string;
            export declare const AcctWater: string;
            export declare const AcctRental: string;
            export declare const AcctLabor: string;
            export declare const AcctInlab: string;
            export declare const AcctInmat: string;
            export declare const AcctMisc: string;
            export declare const ArevisedDate: string;
            export declare const ArevisedBy: string;
            export declare const BrevisedDate: string;
            export declare const BrevisedBy: string;
            export declare const SalesLtaxCode: string;
            export declare const PurchLtaxCode: string;
            export declare const TrevisedDate: string;
            export declare const TrevisedBy: string;
            export declare const SpecsCount: string;
            export declare const DefBomNo: string;
            export declare const LastSnapNo: string;
            export declare const CommisType: string;
            export declare const ProdBranch: string;
            export declare const OwnerBranch: string;
            export declare const SourceBranch: string;
            export declare const ScrapRate: string;
            export declare const AltExtDesc: string;
            export declare const ExtendedDesc: string;
            export declare const PurPriceCtrl: string;
            export declare const PurMaxDev: string;
            export declare const WebItem: string;
            export declare const AcctItmSubcon: string;
            export declare const WithBinCtrl: string;
            export declare const Consign: string;
            export declare const ProdDevt01: string;
            export declare const ProdDevt02: string;
            export declare const ProdDevt03: string;
            export declare const ProdDevt04: string;
            export declare const ProdDevt05: string;
            export declare const ProdDevt06: string;
            export declare const ProdDevt07: string;
            export declare const ProdDevt08: string;
            export declare const ProdDevt09: string;
            export declare const ProdDevt10: string;
            export declare const ProdDevt11: string;
            export declare const ProdDevt12: string;
            export declare const ProdDevt13: string;
            export declare const ProdDevt14: string;
            export declare const ProdDevt15: string;
            export declare const ProdDevt16: string;
            export declare const ProdDevt17: string;
            export declare const ProdDevt18: string;
            export declare const ProdDevt19: string;
            export declare const ProdDevt20: string;
            export declare const ProdCheck01: string;
            export declare const ProdCheck02: string;
            export declare const ProdCheck03: string;
            export declare const ProdCheck04: string;
            export declare const ProdCheck05: string;
            export declare const ProdCheck06: string;
            export declare const ProdCheck07: string;
            export declare const ProdCheck08: string;
            export declare const ProdCheck09: string;
            export declare const ProdCheck10: string;
            export declare const ProdCheck11: string;
            export declare const ProdCheck12: string;
            export declare const ProdCheck13: string;
            export declare const ProdCheck14: string;
            export declare const ProdCheck15: string;
            export declare const ProdCheck16: string;
            export declare const ProdCheck17: string;
            export declare const ProdCheck18: string;
            export declare const ProdCheck19: string;
            export declare const ProdCheck20: string;
            export declare const LastPackLineNo: string;
            export declare const PutaxPcent: string;
            export declare const AcctItmSltax: string;
            export declare const SltaxPcent: string;
            export declare const PurUom: string;
            export declare const PurLotSize: string;
            export declare const PurCcy: string;
            export declare const PurBasePrice: string;
            export declare const QtyNetAvailable: string;
            export declare const UseStdProdLeadTime: string;
            export declare const DailyProdQty: string;
            export declare const IssueLotSize: string;
            export declare const MrpExclude: string;
            export declare const EnableLot: string;
            export declare const EnableSerial: string;
            export declare const LotNoLength: string;
            export declare const SerialNoLength: string;
            export declare const NextLotNo: string;
            export declare const NextSerialNo: string;
            export declare const MaxLotSize: string;
            export declare const LotNoPrefix: string;
            export declare const SerialNoPrefix: string;
            export declare const SafeStockLvl: string;
            export declare const MainBin: string;
            export declare const CustomProdCode: string;
            export declare const CustomLotSize: string;
            export declare const CustomGrUom: string;
            export declare const CustomGrWt: string;
            export declare const CustomNtWt: string;
            export declare const CustomOrigin: string;
            export declare const IsApproved: string;
            export declare const ApprovedBy: string;
            export declare const Preapprove: string;
            export declare const ApprovedDate: string;
            export declare const QtyOnTransfer: string;
            export declare const WithResetLot: string;
            export declare const WithResetSerial: string;
            export declare const PrevResetLotDate: string;
            export declare const PrevResetSerialDate: string;
            export declare const AutogenLot: string;
            export declare const AutogenSerial: string;
            export declare const FabItem: string;
            export declare const Anlys5: string;
            export declare const Anlys6: string;
            export declare const Anlys7: string;
            export declare const Anlys8: string;
            export declare const Anlys9: string;
            export declare const Anlys10: string;
            export declare const UserDefinedField1: string;
            export declare const UserDefinedField2: string;
            export declare const UserDefinedField3: string;
            export declare const UserDefinedField4: string;
            export declare const UserDefinedField5: string;
            export declare const UserDefinedField6: string;
            export declare const UserDefinedField7: string;
            export declare const UserDefinedField8: string;
            export declare const UserDefinedField9: string;
            export declare const UserDefinedField10: string;
            export declare const UserDefinedField11: string;
            export declare const UserDefinedField12: string;
            export declare const UserDefinedField13: string;
            export declare const UserDefinedField14: string;
            export declare const UserDefinedField15: string;
            export declare const UserDefinedField16: string;
            export declare const UserDefinedField17: string;
            export declare const UserDefinedField18: string;
            export declare const UserDefinedField19: string;
            export declare const UserDefinedField20: string;
            export declare const RohsCompliance: string;
            export declare const DefMoldBomNo: string;
            export declare const DefFormulaCode: string;
            export declare const BoxType: string;
            export declare const BoxLength: string;
            export declare const BoxWidth: string;
            export declare const BoxHeight: string;
            export declare const BoxDUom: string;
            export declare const Wd: string;
            export declare const WdUom: string;
            export declare const CsLength: string;
            export declare const CsWidth: string;
            export declare const UserDefinedField21: string;
            export declare const CostWmove: string;
            export declare const CostWcase: string;
            export declare const CostWband: string;
            export declare const CostBatt: string;
            export declare const DescWmove: string;
            export declare const DescWcase: string;
            export declare const DescWband: string;
            export declare const DescBatt: string;
            export declare const PoBal: string;
            export declare const PoMaxBal: string;
            export declare const IncludeJob: string;
            export declare const CsThickness: string;
            export declare const CsThicknessUom: string;
            export declare const CsProportion: string;
            export declare const CsProportionUom: string;
            export declare const DieCutter: string;
            export declare const MatInspectLeadTime: string;
            export declare const MatPrepareLeadTime: string;
            export declare const MatInspectLeadUnit: string;
            export declare const MatPrepareLeadUnit: string;
            export declare const ColorCode: string;
            export declare const CollectionCode: string;
            export declare const StyleCode: string;
            export declare const X: string;
            export declare const Y: string;
            export declare const TempDescription: string;
            export declare const Specification: string;
            export declare const XUom: string;
            export declare const YUom: string;
            export declare const ProductionUomConversionRate: string;
            export declare const PurchaseUomConversionRate: string;
            export declare const AutogenLotIssue: string;
            export declare const AutogenSerialIssue: string;
            export declare const WcCostCcy: string;
            export declare const WcCost: string;
            export declare const WcCostDisc: string;
            export declare const WcCostExch: string;
            export declare const WcFreight: string;
            export declare const WcMargin: string;
            export declare const CeilingPrice: string;
            export declare const BottomRatio: string;
            export declare const BottomPrice: string;
            export declare const DrawingNo: string;
            export declare const MaterialType: string;
            export declare const ItemGroupRecnum: string;
            export declare const ItemGroupDescription: string;
            export declare const ItemGroupSuspended: string;
            export declare const ItemGroupProduct: string;
            export declare const ItemGroupMaterial: string;
            export declare const ItemGroupInspected: string;
            export declare const ItemGroupCostCentre: string;
            export declare const ItemGroupItemType: string;
            export declare const ItemGroupAllocMethod: string;
            export declare const ItemGroupProdBranch: string;
            export declare const ItemGroupAcctItmAsset: string;
            export declare const ItemGroupAcctItmWip: string;
            export declare const ItemGroupAcctItmConsum: string;
            export declare const ItemGroupAcctItmScrap: string;
            export declare const ItemGroupAcctItmPvar: string;
            export declare const ItemGroupAcctItmReval: string;
            export declare const ItemGroupAcctItmVaria: string;
            export declare const ItemGroupAcctItmSales: string;
            export declare const ItemGroupAcctItmSlret: string;
            export declare const ItemGroupAcctItmSldisc: string;
            export declare const ItemGroupAcctItmCogs: string;
            export declare const ItemGroupAcctItmPurch: string;
            export declare const ItemGroupAcctItmPuret: string;
            export declare const ItemGroupAcctItmPudisc: string;
            export declare const ItemGroupAcctItmPutax: string;
            export declare const ItemGroupAcctMachine: string;
            export declare const ItemGroupAcctEnergy: string;
            export declare const ItemGroupAcctWater: string;
            export declare const ItemGroupAcctRental: string;
            export declare const ItemGroupAcctLabor: string;
            export declare const ItemGroupAcctInlab: string;
            export declare const ItemGroupAcctInmat: string;
            export declare const ItemGroupAcctMisc: string;
            export declare const ItemGroupArevisedDate: string;
            export declare const ItemGroupArevisedBy: string;
            export declare const ItemGroupBrevisedDate: string;
            export declare const ItemGroupBrevisedBy: string;
            export declare const ItemGroupMakeOrBuy: string;
            export declare const ItemGroupTypicalUom: string;
            export declare const ItemGroupCycleCode: string;
            export declare const ItemGroupSalesLtaxCode: string;
            export declare const ItemGroupPurchLtaxCode: string;
            export declare const ItemGroupInnerPkgType: string;
            export declare const ItemGroupInnerQty: string;
            export declare const ItemGroupOuterPkgType: string;
            export declare const ItemGroupOuterQty: string;
            export declare const ItemGroupAnlys1: string;
            export declare const ItemGroupAnlys2: string;
            export declare const ItemGroupAnlys3: string;
            export declare const ItemGroupAnlys4: string;
            export declare const ItemGroupItemCount: string;
            export declare const ItemGroupCreatedDate: string;
            export declare const ItemGroupCreatedBy: string;
            export declare const ItemGroupRevisedDate: string;
            export declare const ItemGroupRevisedBy: string;
            export declare const ItemGroupTrevisedDate: string;
            export declare const ItemGroupTrevisedBy: string;
            export declare const ItemGroupCommisType: string;
            export declare const ItemGroupOwnerBranch: string;
            export declare const ItemGroupSourceBranch: string;
            export declare const ItemGroupScrapRate: string;
            export declare const ItemGroupPurPriceCtrl: string;
            export declare const ItemGroupPurMaxDev: string;
            export declare const ItemGroupAcctItmSubcon: string;
            export declare const ItemGroupConsolidate: string;
            export declare const ItemGroupPutaxPcent: string;
            export declare const ItemGroupAcctItmSltax: string;
            export declare const ItemGroupSltaxPcent: string;
            export declare const ItemGroupEnableLot: string;
            export declare const ItemGroupEnableSerial: string;
            export declare const ItemGroupLotNoLength: string;
            export declare const ItemGroupSerialNoLength: string;
            export declare const ItemGroupNextLotNo: string;
            export declare const ItemGroupNextSerialNo: string;
            export declare const ItemGroupMaxLotSize: string;
            export declare const ItemGroupLotNoPrefix: string;
            export declare const ItemGroupSerialNoPrefix: string;
            export declare const ItemGroupDevtCat01: string;
            export declare const ItemGroupDevtCat02: string;
            export declare const ItemGroupDevtCat03: string;
            export declare const ItemGroupDevtCat04: string;
            export declare const ItemGroupDevtCat05: string;
            export declare const ItemGroupDevtCat06: string;
            export declare const ItemGroupDevtCat07: string;
            export declare const ItemGroupDevtCat08: string;
            export declare const ItemGroupDevtCat09: string;
            export declare const ItemGroupDevtCat10: string;
            export declare const ItemGroupDevtCat11: string;
            export declare const ItemGroupDevtCat12: string;
            export declare const ItemGroupDevtCat13: string;
            export declare const ItemGroupDevtCat14: string;
            export declare const ItemGroupDevtCat15: string;
            export declare const ItemGroupDevtCat16: string;
            export declare const ItemGroupDevtCat17: string;
            export declare const ItemGroupDevtCat18: string;
            export declare const ItemGroupDevtCat19: string;
            export declare const ItemGroupDevtCat20: string;
            export declare const ItemGroupMainLoc: string;
            export declare const ItemGroupMainBin: string;
            export declare const ItemGroupWithResetLot: string;
            export declare const ItemGroupWithResetSerial: string;
            export declare const ItemGroupPrevResetLotDate: string;
            export declare const ItemGroupPrevResetSerialDate: string;
            export declare const ItemGroupBomRohsControl: string;
            export declare const ItemGroupAnlys5: string;
            export declare const ItemGroupAnlys6: string;
            export declare const ItemGroupAnlys7: string;
            export declare const ItemGroupAnlys8: string;
            export declare const ItemGroupAnlys9: string;
            export declare const ItemGroupAnlys10: string;
            export declare const ItemGroupAutogenLot: string;
            export declare const ItemGroupAutogenSerial: string;
            export declare const ItemGroupNoScrapInMatIssue: string;
            export declare const ItemGroupAutogenLotIssue: string;
            export declare const ItemGroupAutogenSerialIssue: string;
        }

        [
            'LookupDescription', 
            'Recnum', 
            'ItemNo', 
            'Description', 
            'Suspended', 
            'ItemGroup', 
            'Charges', 
            'Product', 
            'Material', 
            'Inspected', 
            'ItemType', 
            'StockUom', 
            'MainLoc', 
            'MakeBuy', 
            'AllocMethod', 
            'StdCostOk', 
            'CostCentre', 
            'CycleCode', 
            'Anlys1', 
            'Anlys2', 
            'Anlys3', 
            'Anlys4', 
            'DefSpecNo', 
            'DefSpecCount', 
            'CreatedDate', 
            'CreatedBy', 
            'RevisedDate', 
            'RevisedBy', 
            'WithBacklog', 
            'WithBalance', 
            'QtyOnHand', 
            'QtyOnSorder', 
            'QtyOnPorder', 
            'QtyOnJorder', 
            'QtyOnInspect', 
            'QtyWaitlisted', 
            'QtyReserved', 
            'QtyCommitted', 
            'QtyAvailable', 
            'QtyUnallocated', 
            'InvtCostAvail', 
            'InvtCostLdg', 
            'AverageCost', 
            'LatestCost', 
            'StdCost', 
            'LastCountDate', 
            'LastDateIn', 
            'LastDateOut', 
            'SalesUom', 
            'SalesLotSize', 
            'PriceCcy', 
            'BasePrice', 
            'Pricea', 
            'Priceb', 
            'Pricec', 
            'MinPrice', 
            'MaxPrice', 
            'MinOrderQty', 
            'MaxOrderQty', 
            'MinOrderDays', 
            'InnerPkgType', 
            'InnerQty', 
            'OuterPkgType', 
            'OuterQty', 
            'ArticleCode', 
            'QuotaCategory', 
            'WeightUom', 
            'GrossWt', 
            'NetWt', 
            'DimensionUom', 
            'Flength', 
            'Width', 
            'Height', 
            'ComputedVol', 
            'DeclaredVol', 
            'SrevisedDate', 
            'SrevisedBy', 
            'MpsItem', 
            'OrderPolicy', 
            'MinPlanordQty', 
            'MaxPlanordQty', 
            'StdPlanordQty', 
            'MinPlanordPrd', 
            'MaxPlanordPrd', 
            'StdPlanordPrd', 
            'ReorderPt', 
            'ReorderQty', 
            'MinMthlyProd', 
            'MaxMthlyProd', 
            'MinMthlyPur', 
            'MaxMthlyPur', 
            'FollowMinProd', 
            'FollowMaxProd', 
            'FollowMinPur', 
            'FollowMaxPur', 
            'AllowMixMode', 
            'PrefVendOnly', 
            'PrefVend1', 
            'PrefVend2', 
            'ProdLeadTime', 
            'ProdLeadUnit', 
            'PurLeadTime', 
            'PurLeadUnit', 
            'Planner', 
            'MrpParmDate', 
            'MrpParmBy', 
            'AltDescription', 
            'PictureFile', 
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
            'AcctMachine', 
            'AcctEnergy', 
            'AcctWater', 
            'AcctRental', 
            'AcctLabor', 
            'AcctInlab', 
            'AcctInmat', 
            'AcctMisc', 
            'ArevisedDate', 
            'ArevisedBy', 
            'BrevisedDate', 
            'BrevisedBy', 
            'SalesLtaxCode', 
            'PurchLtaxCode', 
            'TrevisedDate', 
            'TrevisedBy', 
            'SpecsCount', 
            'DefBomNo', 
            'LastSnapNo', 
            'CommisType', 
            'ProdBranch', 
            'OwnerBranch', 
            'SourceBranch', 
            'ScrapRate', 
            'AltExtDesc', 
            'ExtendedDesc', 
            'PurPriceCtrl', 
            'PurMaxDev', 
            'WebItem', 
            'AcctItmSubcon', 
            'WithBinCtrl', 
            'Consign', 
            'ProdDevt01', 
            'ProdDevt02', 
            'ProdDevt03', 
            'ProdDevt04', 
            'ProdDevt05', 
            'ProdDevt06', 
            'ProdDevt07', 
            'ProdDevt08', 
            'ProdDevt09', 
            'ProdDevt10', 
            'ProdDevt11', 
            'ProdDevt12', 
            'ProdDevt13', 
            'ProdDevt14', 
            'ProdDevt15', 
            'ProdDevt16', 
            'ProdDevt17', 
            'ProdDevt18', 
            'ProdDevt19', 
            'ProdDevt20', 
            'ProdCheck01', 
            'ProdCheck02', 
            'ProdCheck03', 
            'ProdCheck04', 
            'ProdCheck05', 
            'ProdCheck06', 
            'ProdCheck07', 
            'ProdCheck08', 
            'ProdCheck09', 
            'ProdCheck10', 
            'ProdCheck11', 
            'ProdCheck12', 
            'ProdCheck13', 
            'ProdCheck14', 
            'ProdCheck15', 
            'ProdCheck16', 
            'ProdCheck17', 
            'ProdCheck18', 
            'ProdCheck19', 
            'ProdCheck20', 
            'LastPackLineNo', 
            'PutaxPcent', 
            'AcctItmSltax', 
            'SltaxPcent', 
            'PurUom', 
            'PurLotSize', 
            'PurCcy', 
            'PurBasePrice', 
            'QtyNetAvailable', 
            'UseStdProdLeadTime', 
            'DailyProdQty', 
            'IssueLotSize', 
            'MrpExclude', 
            'EnableLot', 
            'EnableSerial', 
            'LotNoLength', 
            'SerialNoLength', 
            'NextLotNo', 
            'NextSerialNo', 
            'MaxLotSize', 
            'LotNoPrefix', 
            'SerialNoPrefix', 
            'SafeStockLvl', 
            'MainBin', 
            'CustomProdCode', 
            'CustomLotSize', 
            'CustomGrUom', 
            'CustomGrWt', 
            'CustomNtWt', 
            'CustomOrigin', 
            'IsApproved', 
            'ApprovedBy', 
            'Preapprove', 
            'ApprovedDate', 
            'QtyOnTransfer', 
            'WithResetLot', 
            'WithResetSerial', 
            'PrevResetLotDate', 
            'PrevResetSerialDate', 
            'AutogenLot', 
            'AutogenSerial', 
            'FabItem', 
            'Anlys5', 
            'Anlys6', 
            'Anlys7', 
            'Anlys8', 
            'Anlys9', 
            'Anlys10', 
            'UserDefinedField1', 
            'UserDefinedField2', 
            'UserDefinedField3', 
            'UserDefinedField4', 
            'UserDefinedField5', 
            'UserDefinedField6', 
            'UserDefinedField7', 
            'UserDefinedField8', 
            'UserDefinedField9', 
            'UserDefinedField10', 
            'UserDefinedField11', 
            'UserDefinedField12', 
            'UserDefinedField13', 
            'UserDefinedField14', 
            'UserDefinedField15', 
            'UserDefinedField16', 
            'UserDefinedField17', 
            'UserDefinedField18', 
            'UserDefinedField19', 
            'UserDefinedField20', 
            'RohsCompliance', 
            'DefMoldBomNo', 
            'DefFormulaCode', 
            'BoxType', 
            'BoxLength', 
            'BoxWidth', 
            'BoxHeight', 
            'BoxDUom', 
            'Wd', 
            'WdUom', 
            'CsLength', 
            'CsWidth', 
            'UserDefinedField21', 
            'CostWmove', 
            'CostWcase', 
            'CostWband', 
            'CostBatt', 
            'DescWmove', 
            'DescWcase', 
            'DescWband', 
            'DescBatt', 
            'PoBal', 
            'PoMaxBal', 
            'IncludeJob', 
            'CsThickness', 
            'CsThicknessUom', 
            'CsProportion', 
            'CsProportionUom', 
            'DieCutter', 
            'MatInspectLeadTime', 
            'MatPrepareLeadTime', 
            'MatInspectLeadUnit', 
            'MatPrepareLeadUnit', 
            'ColorCode', 
            'CollectionCode', 
            'StyleCode', 
            'X', 
            'Y', 
            'TempDescription', 
            'Specification', 
            'XUom', 
            'YUom', 
            'ProductionUomConversionRate', 
            'PurchaseUomConversionRate', 
            'AutogenLotIssue', 
            'AutogenSerialIssue', 
            'WcCostCcy', 
            'WcCost', 
            'WcCostDisc', 
            'WcCostExch', 
            'WcFreight', 
            'WcMargin', 
            'CeilingPrice', 
            'BottomRatio', 
            'BottomPrice', 
            'DrawingNo', 
            'MaterialType', 
            'ItemGroupRecnum', 
            'ItemGroupDescription', 
            'ItemGroupSuspended', 
            'ItemGroupProduct', 
            'ItemGroupMaterial', 
            'ItemGroupInspected', 
            'ItemGroupCostCentre', 
            'ItemGroupItemType', 
            'ItemGroupAllocMethod', 
            'ItemGroupProdBranch', 
            'ItemGroupAcctItmAsset', 
            'ItemGroupAcctItmWip', 
            'ItemGroupAcctItmConsum', 
            'ItemGroupAcctItmScrap', 
            'ItemGroupAcctItmPvar', 
            'ItemGroupAcctItmReval', 
            'ItemGroupAcctItmVaria', 
            'ItemGroupAcctItmSales', 
            'ItemGroupAcctItmSlret', 
            'ItemGroupAcctItmSldisc', 
            'ItemGroupAcctItmCogs', 
            'ItemGroupAcctItmPurch', 
            'ItemGroupAcctItmPuret', 
            'ItemGroupAcctItmPudisc', 
            'ItemGroupAcctItmPutax', 
            'ItemGroupAcctMachine', 
            'ItemGroupAcctEnergy', 
            'ItemGroupAcctWater', 
            'ItemGroupAcctRental', 
            'ItemGroupAcctLabor', 
            'ItemGroupAcctInlab', 
            'ItemGroupAcctInmat', 
            'ItemGroupAcctMisc', 
            'ItemGroupArevisedDate', 
            'ItemGroupArevisedBy', 
            'ItemGroupBrevisedDate', 
            'ItemGroupBrevisedBy', 
            'ItemGroupMakeOrBuy', 
            'ItemGroupTypicalUom', 
            'ItemGroupCycleCode', 
            'ItemGroupSalesLtaxCode', 
            'ItemGroupPurchLtaxCode', 
            'ItemGroupInnerPkgType', 
            'ItemGroupInnerQty', 
            'ItemGroupOuterPkgType', 
            'ItemGroupOuterQty', 
            'ItemGroupAnlys1', 
            'ItemGroupAnlys2', 
            'ItemGroupAnlys3', 
            'ItemGroupAnlys4', 
            'ItemGroupItemCount', 
            'ItemGroupCreatedDate', 
            'ItemGroupCreatedBy', 
            'ItemGroupRevisedDate', 
            'ItemGroupRevisedBy', 
            'ItemGroupTrevisedDate', 
            'ItemGroupTrevisedBy', 
            'ItemGroupCommisType', 
            'ItemGroupOwnerBranch', 
            'ItemGroupSourceBranch', 
            'ItemGroupScrapRate', 
            'ItemGroupPurPriceCtrl', 
            'ItemGroupPurMaxDev', 
            'ItemGroupAcctItmSubcon', 
            'ItemGroupConsolidate', 
            'ItemGroupPutaxPcent', 
            'ItemGroupAcctItmSltax', 
            'ItemGroupSltaxPcent', 
            'ItemGroupEnableLot', 
            'ItemGroupEnableSerial', 
            'ItemGroupLotNoLength', 
            'ItemGroupSerialNoLength', 
            'ItemGroupNextLotNo', 
            'ItemGroupNextSerialNo', 
            'ItemGroupMaxLotSize', 
            'ItemGroupLotNoPrefix', 
            'ItemGroupSerialNoPrefix', 
            'ItemGroupDevtCat01', 
            'ItemGroupDevtCat02', 
            'ItemGroupDevtCat03', 
            'ItemGroupDevtCat04', 
            'ItemGroupDevtCat05', 
            'ItemGroupDevtCat06', 
            'ItemGroupDevtCat07', 
            'ItemGroupDevtCat08', 
            'ItemGroupDevtCat09', 
            'ItemGroupDevtCat10', 
            'ItemGroupDevtCat11', 
            'ItemGroupDevtCat12', 
            'ItemGroupDevtCat13', 
            'ItemGroupDevtCat14', 
            'ItemGroupDevtCat15', 
            'ItemGroupDevtCat16', 
            'ItemGroupDevtCat17', 
            'ItemGroupDevtCat18', 
            'ItemGroupDevtCat19', 
            'ItemGroupDevtCat20', 
            'ItemGroupMainLoc', 
            'ItemGroupMainBin', 
            'ItemGroupWithResetLot', 
            'ItemGroupWithResetSerial', 
            'ItemGroupPrevResetLotDate', 
            'ItemGroupPrevResetSerialDate', 
            'ItemGroupBomRohsControl', 
            'ItemGroupAnlys5', 
            'ItemGroupAnlys6', 
            'ItemGroupAnlys7', 
            'ItemGroupAnlys8', 
            'ItemGroupAnlys9', 
            'ItemGroupAnlys10', 
            'ItemGroupAutogenLot', 
            'ItemGroupAutogenSerial', 
            'ItemGroupNoScrapInMatIssue', 
            'ItemGroupAutogenLotIssue', 
            'ItemGroupAutogenSerialIssue'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

