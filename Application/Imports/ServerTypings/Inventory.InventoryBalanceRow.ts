namespace Matrix.Inventory {
    export interface InventoryBalanceRow {
        Recnum?: number;
        Loc?: string;
        ItemNo?: string;
        Loc2?: string;
        ItemNo2?: string;
        Description?: string;
        Uom?: string;
        LastDateIn?: string;
        LastDateOut?: string;
        WithBalance?: string;
        QtyOnHand?: number;
        QtyWaitlisted?: number;
        QtyReserved?: number;
        QtyCommitted?: number;
        QtyAvailable?: number;
        QtyUnallocated?: number;
        InvtCostAvail?: number;
        InvtCostLdg?: number;
        AverageCost?: string;
        LatestCost?: number;
        LastCountDate?: string;
        DefaultBinNo?: string;
        QtyOnInspect?: number;
        QtyOnTransfer?: number;
        LocRecnum?: number;
        LocDescription?: string;
        LocSuspended?: string;
        LocAddress?: string;
        LocAddress2?: string;
        LocAddress3?: string;
        LocAddress4?: string;
        LocBranchNo?: string;
        LocNoReservation?: string;
        LocNoWaitlist?: string;
        LocNoAvailable?: string;
        LocNoPlanning?: string;
        LocNoIssuance?: string;
        LocNoReceipts?: string;
        LocNoMatIssue?: string;
        LocNoFgReturn?: string;
        LocNoShipment?: string;
        LocNoGrn?: string;
        LocWithBacklog?: string;
        LocOnSorderCount?: number;
        LocOnPorderCount?: number;
        LocOnJorderCount?: number;
        LocInvtCostAvail?: number;
        LocInvtCostLdg?: number;
        LocCreatedDate?: string;
        LocCreatedBy?: string;
        LocRevisedDate?: string;
        LocRevisedBy?: string;
        LocOwnerBranch?: string;
        LocSourceBranch?: string;
        LocWithBinCtrl?: string;
        LocWithPackingBox?: boolean;
        ItemNoRecnum?: number;
        ItemNoDescription?: string;
        ItemNoSuspended?: string;
        ItemNoItemGroup?: string;
        ItemNoCharges?: string;
        ItemNoProduct?: string;
        ItemNoMaterial?: string;
        ItemNoInspected?: string;
        ItemNoItemType?: string;
        ItemNoStockUom?: string;
        ItemNoMainLoc?: string;
        ItemNoMakeBuy?: string;
        ItemNoAllocMethod?: string;
        ItemNoStdCostOk?: string;
        ItemNoCostCentre?: string;
        ItemNoCycleCode?: string;
        ItemNoAnlys1?: string;
        ItemNoAnlys2?: string;
        ItemNoAnlys3?: string;
        ItemNoAnlys4?: string;
        ItemNoDefSpecNo?: string;
        ItemNoDefSpecCount?: number;
        ItemNoCreatedDate?: string;
        ItemNoCreatedBy?: string;
        ItemNoRevisedDate?: string;
        ItemNoRevisedBy?: string;
        ItemNoWithBacklog?: string;
        ItemNoWithBalance?: string;
        ItemNoQtyOnHand?: number;
        ItemNoQtyOnSorder?: number;
        ItemNoQtyOnPorder?: number;
        ItemNoQtyOnJorder?: number;
        ItemNoQtyOnInspect?: number;
        ItemNoQtyWaitlisted?: number;
        ItemNoQtyReserved?: number;
        ItemNoQtyCommitted?: number;
        ItemNoQtyAvailable?: number;
        ItemNoQtyUnallocated?: number;
        ItemNoInvtCostAvail?: number;
        ItemNoInvtCostLdg?: number;
        ItemNoAverageCost?: string;
        ItemNoLatestCost?: number;
        ItemNoStdCost?: number;
        ItemNoLastCountDate?: string;
        ItemNoLastDateIn?: string;
        ItemNoLastDateOut?: string;
        ItemNoSalesUom?: string;
        ItemNoSalesLotSize?: number;
        ItemNoPriceCcy?: string;
        ItemNoBasePrice?: number;
        ItemNoPricea?: number;
        ItemNoPriceb?: number;
        ItemNoPricec?: number;
        ItemNoMinPrice?: number;
        ItemNoMaxPrice?: number;
        ItemNoMinOrderQty?: number;
        ItemNoMaxOrderQty?: number;
        ItemNoMinOrderDays?: number;
        ItemNoInnerPkgType?: string;
        ItemNoInnerQty?: number;
        ItemNoOuterPkgType?: string;
        ItemNoOuterQty?: number;
        ItemNoArticleCode?: string;
        ItemNoQuotaCategory?: string;
        ItemNoWeightUom?: string;
        ItemNoGrossWt?: number;
        ItemNoNetWt?: number;
        ItemNoDimensionUom?: string;
        ItemNoFlength?: number;
        ItemNoWidth?: number;
        ItemNoHeight?: number;
        ItemNoComputedVol?: number;
        ItemNoDeclaredVol?: number;
        ItemNoSrevisedDate?: string;
        ItemNoSrevisedBy?: string;
        ItemNoMpsItem?: string;
        ItemNoOrderPolicy?: string;
        ItemNoMinPlanordQty?: number;
        ItemNoMaxPlanordQty?: number;
        ItemNoStdPlanordQty?: number;
        ItemNoMinPlanordPrd?: number;
        ItemNoMaxPlanordPrd?: number;
        ItemNoStdPlanordPrd?: number;
        ItemNoReorderPt?: number;
        ItemNoReorderQty?: number;
        ItemNoMinMthlyProd?: number;
        ItemNoMaxMthlyProd?: number;
        ItemNoMinMthlyPur?: number;
        ItemNoMaxMthlyPur?: number;
        ItemNoFollowMinProd?: string;
        ItemNoFollowMaxProd?: string;
        ItemNoFollowMinPur?: string;
        ItemNoFollowMaxPur?: string;
        ItemNoAllowMixMode?: string;
        ItemNoPrefVendOnly?: string;
        ItemNoPrefVend1?: string;
        ItemNoPrefVend2?: string;
        ItemNoProdLeadTime?: number;
        ItemNoProdLeadUnit?: string;
        ItemNoPurLeadTime?: number;
        ItemNoPurLeadUnit?: string;
        ItemNoPlanner?: string;
        ItemNoMrpParmDate?: string;
        ItemNoMrpParmBy?: string;
        ItemNoAltDescription?: string;
        ItemNoPictureFile?: string;
        ItemNoAcctItmAsset?: string;
        ItemNoAcctItmWip?: string;
        ItemNoAcctItmConsum?: string;
        ItemNoAcctItmScrap?: string;
        ItemNoAcctItmPvar?: string;
        ItemNoAcctItmReval?: string;
        ItemNoAcctItmVaria?: string;
        ItemNoAcctItmSales?: string;
        ItemNoAcctItmSlret?: string;
        ItemNoAcctItmSldisc?: string;
        ItemNoAcctItmCogs?: string;
        ItemNoAcctItmPurch?: string;
        ItemNoAcctItmPuret?: string;
        ItemNoAcctItmPudisc?: string;
        ItemNoAcctItmPutax?: string;
        ItemNoAcctMachine?: string;
        ItemNoAcctEnergy?: string;
        ItemNoAcctWater?: string;
        ItemNoAcctRental?: string;
        ItemNoAcctLabor?: string;
        ItemNoAcctInlab?: string;
        ItemNoAcctInmat?: string;
        ItemNoAcctMisc?: string;
        ItemNoArevisedDate?: string;
        ItemNoArevisedBy?: string;
        ItemNoBrevisedDate?: string;
        ItemNoBrevisedBy?: string;
        ItemNoSalesLtaxCode?: string;
        ItemNoPurchLtaxCode?: string;
        ItemNoTrevisedDate?: string;
        ItemNoTrevisedBy?: string;
        ItemNoSpecsCount?: number;
        ItemNoDefBomNo?: string;
        ItemNoLastSnapNo?: number;
        ItemNoCommisType?: string;
        ItemNoProdBranch?: string;
        ItemNoOwnerBranch?: string;
        ItemNoSourceBranch?: string;
        ItemNoScrapRate?: number;
        ItemNoAltExtDesc?: string;
        ItemNoExtendedDesc?: string;
        ItemNoPurPriceCtrl?: string;
        ItemNoPurMaxDev?: number;
        ItemNoWebItem?: string;
        ItemNoAcctItmSubcon?: string;
        ItemNoWithBinCtrl?: string;
        ItemNoConsign?: string;
        ItemNoProdDevt01?: string;
        ItemNoProdDevt02?: string;
        ItemNoProdDevt03?: string;
        ItemNoProdDevt04?: string;
        ItemNoProdDevt05?: string;
        ItemNoProdDevt06?: string;
        ItemNoProdDevt07?: string;
        ItemNoProdDevt08?: string;
        ItemNoProdDevt09?: string;
        ItemNoProdDevt10?: string;
        ItemNoProdDevt11?: string;
        ItemNoProdDevt12?: string;
        ItemNoProdDevt13?: string;
        ItemNoProdDevt14?: string;
        ItemNoProdDevt15?: string;
        ItemNoProdDevt16?: string;
        ItemNoProdDevt17?: string;
        ItemNoProdDevt18?: string;
        ItemNoProdDevt19?: string;
        ItemNoProdDevt20?: string;
        ItemNoProdCheck01?: string;
        ItemNoProdCheck02?: string;
        ItemNoProdCheck03?: string;
        ItemNoProdCheck04?: string;
        ItemNoProdCheck05?: string;
        ItemNoProdCheck06?: string;
        ItemNoProdCheck07?: string;
        ItemNoProdCheck08?: string;
        ItemNoProdCheck09?: string;
        ItemNoProdCheck10?: string;
        ItemNoProdCheck11?: string;
        ItemNoProdCheck12?: string;
        ItemNoProdCheck13?: string;
        ItemNoProdCheck14?: string;
        ItemNoProdCheck15?: string;
        ItemNoProdCheck16?: string;
        ItemNoProdCheck17?: string;
        ItemNoProdCheck18?: string;
        ItemNoProdCheck19?: string;
        ItemNoProdCheck20?: string;
        ItemNoLastPackLineNo?: number;
        ItemNoPutaxPcent?: number;
        ItemNoAcctItmSltax?: string;
        ItemNoSltaxPcent?: number;
        ItemNoPurUom?: string;
        ItemNoPurLotSize?: number;
        ItemNoPurCcy?: string;
        ItemNoPurBasePrice?: number;
        ItemNoQtyNetAvailable?: number;
        ItemNoUseStdProdLeadTime?: string;
        ItemNoDailyProdQty?: number;
        ItemNoIssueLotSize?: number;
        ItemNoMrpExclude?: string;
        ItemNoEnableLot?: string;
        ItemNoEnableSerial?: string;
        ItemNoLotNoLength?: number;
        ItemNoSerialNoLength?: number;
        ItemNoNextLotNo?: number;
        ItemNoNextSerialNo?: number;
        ItemNoMaxLotSize?: number;
        ItemNoLotNoPrefix?: string;
        ItemNoSerialNoPrefix?: string;
        ItemNoSafeStockLvl?: number;
        ItemNoMainBin?: string;
        ItemNoCustomProdCode?: string;
        ItemNoCustomLotSize?: number;
        ItemNoCustomGrUom?: string;
        ItemNoCustomGrWt?: number;
        ItemNoCustomNtWt?: number;
        ItemNoCustomOrigin?: string;
        ItemNoIsApproved?: string;
        ItemNoApprovedBy?: string;
        ItemNoPreapprove?: string;
        ItemNoApprovedDate?: string;
        ItemNoQtyOnTransfer?: number;
        ItemNoWithResetLot?: string;
        ItemNoWithResetSerial?: string;
        ItemNoPrevResetLotDate?: string;
        ItemNoPrevResetSerialDate?: string;
        ItemNoAutogenLot?: string;
        ItemNoAutogenSerial?: string;
        ItemNoFabItem?: string;
        ItemNoAnlys5?: string;
        ItemNoAnlys6?: string;
        ItemNoAnlys7?: string;
        ItemNoAnlys8?: string;
        ItemNoAnlys9?: string;
        ItemNoAnlys10?: string;
        ItemNoUserDefinedField1?: string;
        ItemNoUserDefinedField2?: string;
        ItemNoUserDefinedField3?: string;
        ItemNoUserDefinedField4?: string;
        ItemNoUserDefinedField5?: string;
        ItemNoUserDefinedField6?: string;
        ItemNoUserDefinedField7?: string;
        ItemNoUserDefinedField8?: string;
        ItemNoUserDefinedField9?: string;
        ItemNoUserDefinedField10?: string;
        ItemNoUserDefinedField11?: string;
        ItemNoUserDefinedField12?: string;
        ItemNoUserDefinedField13?: string;
        ItemNoUserDefinedField14?: string;
        ItemNoUserDefinedField15?: string;
        ItemNoUserDefinedField16?: string;
        ItemNoUserDefinedField17?: string;
        ItemNoUserDefinedField18?: string;
        ItemNoUserDefinedField19?: string;
        ItemNoUserDefinedField20?: string;
        ItemNoRohsCompliance?: boolean;
        ItemNoDefMoldBomNo?: string;
        ItemNoDefFormulaCode?: string;
        ItemNoBoxType?: string;
        ItemNoBoxLength?: number;
        ItemNoBoxWidth?: number;
        ItemNoBoxHeight?: number;
        ItemNoBoxDUom?: string;
        ItemNoWd?: number;
        ItemNoWdUom?: string;
        ItemNoCsLength?: number;
        ItemNoCsWidth?: number;
        ItemNoUserDefinedField21?: string;
        ItemNoCostWmove?: number;
        ItemNoCostWcase?: number;
        ItemNoCostWband?: number;
        ItemNoCostBatt?: number;
        ItemNoDescWmove?: string;
        ItemNoDescWcase?: string;
        ItemNoDescWband?: string;
        ItemNoDescBatt?: string;
        ItemNoPoBal?: number;
        ItemNoPoMaxBal?: number;
        ItemNoIncludeJob?: boolean;
        ItemNoCsThickness?: number;
        ItemNoCsThicknessUom?: string;
        ItemNoCsProportion?: number;
        ItemNoCsProportionUom?: string;
        ItemNoDieCutter?: number;
        ItemNoMatInspectLeadTime?: number;
        ItemNoMatPrepareLeadTime?: number;
        ItemNoMatInspectLeadUnit?: string;
        ItemNoMatPrepareLeadUnit?: string;
        ItemNoColorCode?: string;
        ItemNoCollectionCode?: string;
        ItemNoStyleCode?: string;
        ItemNoX?: number;
        ItemNoY?: number;
        ItemNoTempDescription?: string;
        ItemNoSpecification?: string;
        ItemNoXUom?: string;
        ItemNoYUom?: string;
        ItemNoProductionUomConversionRate?: number;
        ItemNoPurchaseUomConversionRate?: number;
        ItemNoAutogenLotIssue?: boolean;
        ItemNoAutogenSerialIssue?: boolean;
        ItemNoWcCostCcy?: string;
        ItemNoWcCost?: number;
        ItemNoWcCostDisc?: number;
        ItemNoWcCostExch?: number;
        ItemNoWcFreight?: number;
        ItemNoWcMargin?: number;
        ItemNoCeilingPrice?: number;
        ItemNoBottomRatio?: number;
        ItemNoBottomPrice?: number;
        ItemNoDrawingNo?: string;
        ItemNoMaterialType?: string;
    }

    export namespace InventoryBalanceRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'Loc';
        export const localTextPrefix = 'Inventory.InventoryBalance';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const Loc: string;
            export declare const ItemNo: string;
            export declare const Loc2: string;
            export declare const ItemNo2: string;
            export declare const Description: string;
            export declare const Uom: string;
            export declare const LastDateIn: string;
            export declare const LastDateOut: string;
            export declare const WithBalance: string;
            export declare const QtyOnHand: string;
            export declare const QtyWaitlisted: string;
            export declare const QtyReserved: string;
            export declare const QtyCommitted: string;
            export declare const QtyAvailable: string;
            export declare const QtyUnallocated: string;
            export declare const InvtCostAvail: string;
            export declare const InvtCostLdg: string;
            export declare const AverageCost: string;
            export declare const LatestCost: string;
            export declare const LastCountDate: string;
            export declare const DefaultBinNo: string;
            export declare const QtyOnInspect: string;
            export declare const QtyOnTransfer: string;
            export declare const LocRecnum: string;
            export declare const LocDescription: string;
            export declare const LocSuspended: string;
            export declare const LocAddress: string;
            export declare const LocAddress2: string;
            export declare const LocAddress3: string;
            export declare const LocAddress4: string;
            export declare const LocBranchNo: string;
            export declare const LocNoReservation: string;
            export declare const LocNoWaitlist: string;
            export declare const LocNoAvailable: string;
            export declare const LocNoPlanning: string;
            export declare const LocNoIssuance: string;
            export declare const LocNoReceipts: string;
            export declare const LocNoMatIssue: string;
            export declare const LocNoFgReturn: string;
            export declare const LocNoShipment: string;
            export declare const LocNoGrn: string;
            export declare const LocWithBacklog: string;
            export declare const LocOnSorderCount: string;
            export declare const LocOnPorderCount: string;
            export declare const LocOnJorderCount: string;
            export declare const LocInvtCostAvail: string;
            export declare const LocInvtCostLdg: string;
            export declare const LocCreatedDate: string;
            export declare const LocCreatedBy: string;
            export declare const LocRevisedDate: string;
            export declare const LocRevisedBy: string;
            export declare const LocOwnerBranch: string;
            export declare const LocSourceBranch: string;
            export declare const LocWithBinCtrl: string;
            export declare const LocWithPackingBox: string;
            export declare const ItemNoRecnum: string;
            export declare const ItemNoDescription: string;
            export declare const ItemNoSuspended: string;
            export declare const ItemNoItemGroup: string;
            export declare const ItemNoCharges: string;
            export declare const ItemNoProduct: string;
            export declare const ItemNoMaterial: string;
            export declare const ItemNoInspected: string;
            export declare const ItemNoItemType: string;
            export declare const ItemNoStockUom: string;
            export declare const ItemNoMainLoc: string;
            export declare const ItemNoMakeBuy: string;
            export declare const ItemNoAllocMethod: string;
            export declare const ItemNoStdCostOk: string;
            export declare const ItemNoCostCentre: string;
            export declare const ItemNoCycleCode: string;
            export declare const ItemNoAnlys1: string;
            export declare const ItemNoAnlys2: string;
            export declare const ItemNoAnlys3: string;
            export declare const ItemNoAnlys4: string;
            export declare const ItemNoDefSpecNo: string;
            export declare const ItemNoDefSpecCount: string;
            export declare const ItemNoCreatedDate: string;
            export declare const ItemNoCreatedBy: string;
            export declare const ItemNoRevisedDate: string;
            export declare const ItemNoRevisedBy: string;
            export declare const ItemNoWithBacklog: string;
            export declare const ItemNoWithBalance: string;
            export declare const ItemNoQtyOnHand: string;
            export declare const ItemNoQtyOnSorder: string;
            export declare const ItemNoQtyOnPorder: string;
            export declare const ItemNoQtyOnJorder: string;
            export declare const ItemNoQtyOnInspect: string;
            export declare const ItemNoQtyWaitlisted: string;
            export declare const ItemNoQtyReserved: string;
            export declare const ItemNoQtyCommitted: string;
            export declare const ItemNoQtyAvailable: string;
            export declare const ItemNoQtyUnallocated: string;
            export declare const ItemNoInvtCostAvail: string;
            export declare const ItemNoInvtCostLdg: string;
            export declare const ItemNoAverageCost: string;
            export declare const ItemNoLatestCost: string;
            export declare const ItemNoStdCost: string;
            export declare const ItemNoLastCountDate: string;
            export declare const ItemNoLastDateIn: string;
            export declare const ItemNoLastDateOut: string;
            export declare const ItemNoSalesUom: string;
            export declare const ItemNoSalesLotSize: string;
            export declare const ItemNoPriceCcy: string;
            export declare const ItemNoBasePrice: string;
            export declare const ItemNoPricea: string;
            export declare const ItemNoPriceb: string;
            export declare const ItemNoPricec: string;
            export declare const ItemNoMinPrice: string;
            export declare const ItemNoMaxPrice: string;
            export declare const ItemNoMinOrderQty: string;
            export declare const ItemNoMaxOrderQty: string;
            export declare const ItemNoMinOrderDays: string;
            export declare const ItemNoInnerPkgType: string;
            export declare const ItemNoInnerQty: string;
            export declare const ItemNoOuterPkgType: string;
            export declare const ItemNoOuterQty: string;
            export declare const ItemNoArticleCode: string;
            export declare const ItemNoQuotaCategory: string;
            export declare const ItemNoWeightUom: string;
            export declare const ItemNoGrossWt: string;
            export declare const ItemNoNetWt: string;
            export declare const ItemNoDimensionUom: string;
            export declare const ItemNoFlength: string;
            export declare const ItemNoWidth: string;
            export declare const ItemNoHeight: string;
            export declare const ItemNoComputedVol: string;
            export declare const ItemNoDeclaredVol: string;
            export declare const ItemNoSrevisedDate: string;
            export declare const ItemNoSrevisedBy: string;
            export declare const ItemNoMpsItem: string;
            export declare const ItemNoOrderPolicy: string;
            export declare const ItemNoMinPlanordQty: string;
            export declare const ItemNoMaxPlanordQty: string;
            export declare const ItemNoStdPlanordQty: string;
            export declare const ItemNoMinPlanordPrd: string;
            export declare const ItemNoMaxPlanordPrd: string;
            export declare const ItemNoStdPlanordPrd: string;
            export declare const ItemNoReorderPt: string;
            export declare const ItemNoReorderQty: string;
            export declare const ItemNoMinMthlyProd: string;
            export declare const ItemNoMaxMthlyProd: string;
            export declare const ItemNoMinMthlyPur: string;
            export declare const ItemNoMaxMthlyPur: string;
            export declare const ItemNoFollowMinProd: string;
            export declare const ItemNoFollowMaxProd: string;
            export declare const ItemNoFollowMinPur: string;
            export declare const ItemNoFollowMaxPur: string;
            export declare const ItemNoAllowMixMode: string;
            export declare const ItemNoPrefVendOnly: string;
            export declare const ItemNoPrefVend1: string;
            export declare const ItemNoPrefVend2: string;
            export declare const ItemNoProdLeadTime: string;
            export declare const ItemNoProdLeadUnit: string;
            export declare const ItemNoPurLeadTime: string;
            export declare const ItemNoPurLeadUnit: string;
            export declare const ItemNoPlanner: string;
            export declare const ItemNoMrpParmDate: string;
            export declare const ItemNoMrpParmBy: string;
            export declare const ItemNoAltDescription: string;
            export declare const ItemNoPictureFile: string;
            export declare const ItemNoAcctItmAsset: string;
            export declare const ItemNoAcctItmWip: string;
            export declare const ItemNoAcctItmConsum: string;
            export declare const ItemNoAcctItmScrap: string;
            export declare const ItemNoAcctItmPvar: string;
            export declare const ItemNoAcctItmReval: string;
            export declare const ItemNoAcctItmVaria: string;
            export declare const ItemNoAcctItmSales: string;
            export declare const ItemNoAcctItmSlret: string;
            export declare const ItemNoAcctItmSldisc: string;
            export declare const ItemNoAcctItmCogs: string;
            export declare const ItemNoAcctItmPurch: string;
            export declare const ItemNoAcctItmPuret: string;
            export declare const ItemNoAcctItmPudisc: string;
            export declare const ItemNoAcctItmPutax: string;
            export declare const ItemNoAcctMachine: string;
            export declare const ItemNoAcctEnergy: string;
            export declare const ItemNoAcctWater: string;
            export declare const ItemNoAcctRental: string;
            export declare const ItemNoAcctLabor: string;
            export declare const ItemNoAcctInlab: string;
            export declare const ItemNoAcctInmat: string;
            export declare const ItemNoAcctMisc: string;
            export declare const ItemNoArevisedDate: string;
            export declare const ItemNoArevisedBy: string;
            export declare const ItemNoBrevisedDate: string;
            export declare const ItemNoBrevisedBy: string;
            export declare const ItemNoSalesLtaxCode: string;
            export declare const ItemNoPurchLtaxCode: string;
            export declare const ItemNoTrevisedDate: string;
            export declare const ItemNoTrevisedBy: string;
            export declare const ItemNoSpecsCount: string;
            export declare const ItemNoDefBomNo: string;
            export declare const ItemNoLastSnapNo: string;
            export declare const ItemNoCommisType: string;
            export declare const ItemNoProdBranch: string;
            export declare const ItemNoOwnerBranch: string;
            export declare const ItemNoSourceBranch: string;
            export declare const ItemNoScrapRate: string;
            export declare const ItemNoAltExtDesc: string;
            export declare const ItemNoExtendedDesc: string;
            export declare const ItemNoPurPriceCtrl: string;
            export declare const ItemNoPurMaxDev: string;
            export declare const ItemNoWebItem: string;
            export declare const ItemNoAcctItmSubcon: string;
            export declare const ItemNoWithBinCtrl: string;
            export declare const ItemNoConsign: string;
            export declare const ItemNoProdDevt01: string;
            export declare const ItemNoProdDevt02: string;
            export declare const ItemNoProdDevt03: string;
            export declare const ItemNoProdDevt04: string;
            export declare const ItemNoProdDevt05: string;
            export declare const ItemNoProdDevt06: string;
            export declare const ItemNoProdDevt07: string;
            export declare const ItemNoProdDevt08: string;
            export declare const ItemNoProdDevt09: string;
            export declare const ItemNoProdDevt10: string;
            export declare const ItemNoProdDevt11: string;
            export declare const ItemNoProdDevt12: string;
            export declare const ItemNoProdDevt13: string;
            export declare const ItemNoProdDevt14: string;
            export declare const ItemNoProdDevt15: string;
            export declare const ItemNoProdDevt16: string;
            export declare const ItemNoProdDevt17: string;
            export declare const ItemNoProdDevt18: string;
            export declare const ItemNoProdDevt19: string;
            export declare const ItemNoProdDevt20: string;
            export declare const ItemNoProdCheck01: string;
            export declare const ItemNoProdCheck02: string;
            export declare const ItemNoProdCheck03: string;
            export declare const ItemNoProdCheck04: string;
            export declare const ItemNoProdCheck05: string;
            export declare const ItemNoProdCheck06: string;
            export declare const ItemNoProdCheck07: string;
            export declare const ItemNoProdCheck08: string;
            export declare const ItemNoProdCheck09: string;
            export declare const ItemNoProdCheck10: string;
            export declare const ItemNoProdCheck11: string;
            export declare const ItemNoProdCheck12: string;
            export declare const ItemNoProdCheck13: string;
            export declare const ItemNoProdCheck14: string;
            export declare const ItemNoProdCheck15: string;
            export declare const ItemNoProdCheck16: string;
            export declare const ItemNoProdCheck17: string;
            export declare const ItemNoProdCheck18: string;
            export declare const ItemNoProdCheck19: string;
            export declare const ItemNoProdCheck20: string;
            export declare const ItemNoLastPackLineNo: string;
            export declare const ItemNoPutaxPcent: string;
            export declare const ItemNoAcctItmSltax: string;
            export declare const ItemNoSltaxPcent: string;
            export declare const ItemNoPurUom: string;
            export declare const ItemNoPurLotSize: string;
            export declare const ItemNoPurCcy: string;
            export declare const ItemNoPurBasePrice: string;
            export declare const ItemNoQtyNetAvailable: string;
            export declare const ItemNoUseStdProdLeadTime: string;
            export declare const ItemNoDailyProdQty: string;
            export declare const ItemNoIssueLotSize: string;
            export declare const ItemNoMrpExclude: string;
            export declare const ItemNoEnableLot: string;
            export declare const ItemNoEnableSerial: string;
            export declare const ItemNoLotNoLength: string;
            export declare const ItemNoSerialNoLength: string;
            export declare const ItemNoNextLotNo: string;
            export declare const ItemNoNextSerialNo: string;
            export declare const ItemNoMaxLotSize: string;
            export declare const ItemNoLotNoPrefix: string;
            export declare const ItemNoSerialNoPrefix: string;
            export declare const ItemNoSafeStockLvl: string;
            export declare const ItemNoMainBin: string;
            export declare const ItemNoCustomProdCode: string;
            export declare const ItemNoCustomLotSize: string;
            export declare const ItemNoCustomGrUom: string;
            export declare const ItemNoCustomGrWt: string;
            export declare const ItemNoCustomNtWt: string;
            export declare const ItemNoCustomOrigin: string;
            export declare const ItemNoIsApproved: string;
            export declare const ItemNoApprovedBy: string;
            export declare const ItemNoPreapprove: string;
            export declare const ItemNoApprovedDate: string;
            export declare const ItemNoQtyOnTransfer: string;
            export declare const ItemNoWithResetLot: string;
            export declare const ItemNoWithResetSerial: string;
            export declare const ItemNoPrevResetLotDate: string;
            export declare const ItemNoPrevResetSerialDate: string;
            export declare const ItemNoAutogenLot: string;
            export declare const ItemNoAutogenSerial: string;
            export declare const ItemNoFabItem: string;
            export declare const ItemNoAnlys5: string;
            export declare const ItemNoAnlys6: string;
            export declare const ItemNoAnlys7: string;
            export declare const ItemNoAnlys8: string;
            export declare const ItemNoAnlys9: string;
            export declare const ItemNoAnlys10: string;
            export declare const ItemNoUserDefinedField1: string;
            export declare const ItemNoUserDefinedField2: string;
            export declare const ItemNoUserDefinedField3: string;
            export declare const ItemNoUserDefinedField4: string;
            export declare const ItemNoUserDefinedField5: string;
            export declare const ItemNoUserDefinedField6: string;
            export declare const ItemNoUserDefinedField7: string;
            export declare const ItemNoUserDefinedField8: string;
            export declare const ItemNoUserDefinedField9: string;
            export declare const ItemNoUserDefinedField10: string;
            export declare const ItemNoUserDefinedField11: string;
            export declare const ItemNoUserDefinedField12: string;
            export declare const ItemNoUserDefinedField13: string;
            export declare const ItemNoUserDefinedField14: string;
            export declare const ItemNoUserDefinedField15: string;
            export declare const ItemNoUserDefinedField16: string;
            export declare const ItemNoUserDefinedField17: string;
            export declare const ItemNoUserDefinedField18: string;
            export declare const ItemNoUserDefinedField19: string;
            export declare const ItemNoUserDefinedField20: string;
            export declare const ItemNoRohsCompliance: string;
            export declare const ItemNoDefMoldBomNo: string;
            export declare const ItemNoDefFormulaCode: string;
            export declare const ItemNoBoxType: string;
            export declare const ItemNoBoxLength: string;
            export declare const ItemNoBoxWidth: string;
            export declare const ItemNoBoxHeight: string;
            export declare const ItemNoBoxDUom: string;
            export declare const ItemNoWd: string;
            export declare const ItemNoWdUom: string;
            export declare const ItemNoCsLength: string;
            export declare const ItemNoCsWidth: string;
            export declare const ItemNoUserDefinedField21: string;
            export declare const ItemNoCostWmove: string;
            export declare const ItemNoCostWcase: string;
            export declare const ItemNoCostWband: string;
            export declare const ItemNoCostBatt: string;
            export declare const ItemNoDescWmove: string;
            export declare const ItemNoDescWcase: string;
            export declare const ItemNoDescWband: string;
            export declare const ItemNoDescBatt: string;
            export declare const ItemNoPoBal: string;
            export declare const ItemNoPoMaxBal: string;
            export declare const ItemNoIncludeJob: string;
            export declare const ItemNoCsThickness: string;
            export declare const ItemNoCsThicknessUom: string;
            export declare const ItemNoCsProportion: string;
            export declare const ItemNoCsProportionUom: string;
            export declare const ItemNoDieCutter: string;
            export declare const ItemNoMatInspectLeadTime: string;
            export declare const ItemNoMatPrepareLeadTime: string;
            export declare const ItemNoMatInspectLeadUnit: string;
            export declare const ItemNoMatPrepareLeadUnit: string;
            export declare const ItemNoColorCode: string;
            export declare const ItemNoCollectionCode: string;
            export declare const ItemNoStyleCode: string;
            export declare const ItemNoX: string;
            export declare const ItemNoY: string;
            export declare const ItemNoTempDescription: string;
            export declare const ItemNoSpecification: string;
            export declare const ItemNoXUom: string;
            export declare const ItemNoYUom: string;
            export declare const ItemNoProductionUomConversionRate: string;
            export declare const ItemNoPurchaseUomConversionRate: string;
            export declare const ItemNoAutogenLotIssue: string;
            export declare const ItemNoAutogenSerialIssue: string;
            export declare const ItemNoWcCostCcy: string;
            export declare const ItemNoWcCost: string;
            export declare const ItemNoWcCostDisc: string;
            export declare const ItemNoWcCostExch: string;
            export declare const ItemNoWcFreight: string;
            export declare const ItemNoWcMargin: string;
            export declare const ItemNoCeilingPrice: string;
            export declare const ItemNoBottomRatio: string;
            export declare const ItemNoBottomPrice: string;
            export declare const ItemNoDrawingNo: string;
            export declare const ItemNoMaterialType: string;
        }

        [
            'Recnum', 
            'Loc', 
            'ItemNo', 
            'Loc2', 
            'ItemNo2', 
            'Description', 
            'Uom', 
            'LastDateIn', 
            'LastDateOut', 
            'WithBalance', 
            'QtyOnHand', 
            'QtyWaitlisted', 
            'QtyReserved', 
            'QtyCommitted', 
            'QtyAvailable', 
            'QtyUnallocated', 
            'InvtCostAvail', 
            'InvtCostLdg', 
            'AverageCost', 
            'LatestCost', 
            'LastCountDate', 
            'DefaultBinNo', 
            'QtyOnInspect', 
            'QtyOnTransfer', 
            'LocRecnum', 
            'LocDescription', 
            'LocSuspended', 
            'LocAddress', 
            'LocAddress2', 
            'LocAddress3', 
            'LocAddress4', 
            'LocBranchNo', 
            'LocNoReservation', 
            'LocNoWaitlist', 
            'LocNoAvailable', 
            'LocNoPlanning', 
            'LocNoIssuance', 
            'LocNoReceipts', 
            'LocNoMatIssue', 
            'LocNoFgReturn', 
            'LocNoShipment', 
            'LocNoGrn', 
            'LocWithBacklog', 
            'LocOnSorderCount', 
            'LocOnPorderCount', 
            'LocOnJorderCount', 
            'LocInvtCostAvail', 
            'LocInvtCostLdg', 
            'LocCreatedDate', 
            'LocCreatedBy', 
            'LocRevisedDate', 
            'LocRevisedBy', 
            'LocOwnerBranch', 
            'LocSourceBranch', 
            'LocWithBinCtrl', 
            'LocWithPackingBox', 
            'ItemNoRecnum', 
            'ItemNoDescription', 
            'ItemNoSuspended', 
            'ItemNoItemGroup', 
            'ItemNoCharges', 
            'ItemNoProduct', 
            'ItemNoMaterial', 
            'ItemNoInspected', 
            'ItemNoItemType', 
            'ItemNoStockUom', 
            'ItemNoMainLoc', 
            'ItemNoMakeBuy', 
            'ItemNoAllocMethod', 
            'ItemNoStdCostOk', 
            'ItemNoCostCentre', 
            'ItemNoCycleCode', 
            'ItemNoAnlys1', 
            'ItemNoAnlys2', 
            'ItemNoAnlys3', 
            'ItemNoAnlys4', 
            'ItemNoDefSpecNo', 
            'ItemNoDefSpecCount', 
            'ItemNoCreatedDate', 
            'ItemNoCreatedBy', 
            'ItemNoRevisedDate', 
            'ItemNoRevisedBy', 
            'ItemNoWithBacklog', 
            'ItemNoWithBalance', 
            'ItemNoQtyOnHand', 
            'ItemNoQtyOnSorder', 
            'ItemNoQtyOnPorder', 
            'ItemNoQtyOnJorder', 
            'ItemNoQtyOnInspect', 
            'ItemNoQtyWaitlisted', 
            'ItemNoQtyReserved', 
            'ItemNoQtyCommitted', 
            'ItemNoQtyAvailable', 
            'ItemNoQtyUnallocated', 
            'ItemNoInvtCostAvail', 
            'ItemNoInvtCostLdg', 
            'ItemNoAverageCost', 
            'ItemNoLatestCost', 
            'ItemNoStdCost', 
            'ItemNoLastCountDate', 
            'ItemNoLastDateIn', 
            'ItemNoLastDateOut', 
            'ItemNoSalesUom', 
            'ItemNoSalesLotSize', 
            'ItemNoPriceCcy', 
            'ItemNoBasePrice', 
            'ItemNoPricea', 
            'ItemNoPriceb', 
            'ItemNoPricec', 
            'ItemNoMinPrice', 
            'ItemNoMaxPrice', 
            'ItemNoMinOrderQty', 
            'ItemNoMaxOrderQty', 
            'ItemNoMinOrderDays', 
            'ItemNoInnerPkgType', 
            'ItemNoInnerQty', 
            'ItemNoOuterPkgType', 
            'ItemNoOuterQty', 
            'ItemNoArticleCode', 
            'ItemNoQuotaCategory', 
            'ItemNoWeightUom', 
            'ItemNoGrossWt', 
            'ItemNoNetWt', 
            'ItemNoDimensionUom', 
            'ItemNoFlength', 
            'ItemNoWidth', 
            'ItemNoHeight', 
            'ItemNoComputedVol', 
            'ItemNoDeclaredVol', 
            'ItemNoSrevisedDate', 
            'ItemNoSrevisedBy', 
            'ItemNoMpsItem', 
            'ItemNoOrderPolicy', 
            'ItemNoMinPlanordQty', 
            'ItemNoMaxPlanordQty', 
            'ItemNoStdPlanordQty', 
            'ItemNoMinPlanordPrd', 
            'ItemNoMaxPlanordPrd', 
            'ItemNoStdPlanordPrd', 
            'ItemNoReorderPt', 
            'ItemNoReorderQty', 
            'ItemNoMinMthlyProd', 
            'ItemNoMaxMthlyProd', 
            'ItemNoMinMthlyPur', 
            'ItemNoMaxMthlyPur', 
            'ItemNoFollowMinProd', 
            'ItemNoFollowMaxProd', 
            'ItemNoFollowMinPur', 
            'ItemNoFollowMaxPur', 
            'ItemNoAllowMixMode', 
            'ItemNoPrefVendOnly', 
            'ItemNoPrefVend1', 
            'ItemNoPrefVend2', 
            'ItemNoProdLeadTime', 
            'ItemNoProdLeadUnit', 
            'ItemNoPurLeadTime', 
            'ItemNoPurLeadUnit', 
            'ItemNoPlanner', 
            'ItemNoMrpParmDate', 
            'ItemNoMrpParmBy', 
            'ItemNoAltDescription', 
            'ItemNoPictureFile', 
            'ItemNoAcctItmAsset', 
            'ItemNoAcctItmWip', 
            'ItemNoAcctItmConsum', 
            'ItemNoAcctItmScrap', 
            'ItemNoAcctItmPvar', 
            'ItemNoAcctItmReval', 
            'ItemNoAcctItmVaria', 
            'ItemNoAcctItmSales', 
            'ItemNoAcctItmSlret', 
            'ItemNoAcctItmSldisc', 
            'ItemNoAcctItmCogs', 
            'ItemNoAcctItmPurch', 
            'ItemNoAcctItmPuret', 
            'ItemNoAcctItmPudisc', 
            'ItemNoAcctItmPutax', 
            'ItemNoAcctMachine', 
            'ItemNoAcctEnergy', 
            'ItemNoAcctWater', 
            'ItemNoAcctRental', 
            'ItemNoAcctLabor', 
            'ItemNoAcctInlab', 
            'ItemNoAcctInmat', 
            'ItemNoAcctMisc', 
            'ItemNoArevisedDate', 
            'ItemNoArevisedBy', 
            'ItemNoBrevisedDate', 
            'ItemNoBrevisedBy', 
            'ItemNoSalesLtaxCode', 
            'ItemNoPurchLtaxCode', 
            'ItemNoTrevisedDate', 
            'ItemNoTrevisedBy', 
            'ItemNoSpecsCount', 
            'ItemNoDefBomNo', 
            'ItemNoLastSnapNo', 
            'ItemNoCommisType', 
            'ItemNoProdBranch', 
            'ItemNoOwnerBranch', 
            'ItemNoSourceBranch', 
            'ItemNoScrapRate', 
            'ItemNoAltExtDesc', 
            'ItemNoExtendedDesc', 
            'ItemNoPurPriceCtrl', 
            'ItemNoPurMaxDev', 
            'ItemNoWebItem', 
            'ItemNoAcctItmSubcon', 
            'ItemNoWithBinCtrl', 
            'ItemNoConsign', 
            'ItemNoProdDevt01', 
            'ItemNoProdDevt02', 
            'ItemNoProdDevt03', 
            'ItemNoProdDevt04', 
            'ItemNoProdDevt05', 
            'ItemNoProdDevt06', 
            'ItemNoProdDevt07', 
            'ItemNoProdDevt08', 
            'ItemNoProdDevt09', 
            'ItemNoProdDevt10', 
            'ItemNoProdDevt11', 
            'ItemNoProdDevt12', 
            'ItemNoProdDevt13', 
            'ItemNoProdDevt14', 
            'ItemNoProdDevt15', 
            'ItemNoProdDevt16', 
            'ItemNoProdDevt17', 
            'ItemNoProdDevt18', 
            'ItemNoProdDevt19', 
            'ItemNoProdDevt20', 
            'ItemNoProdCheck01', 
            'ItemNoProdCheck02', 
            'ItemNoProdCheck03', 
            'ItemNoProdCheck04', 
            'ItemNoProdCheck05', 
            'ItemNoProdCheck06', 
            'ItemNoProdCheck07', 
            'ItemNoProdCheck08', 
            'ItemNoProdCheck09', 
            'ItemNoProdCheck10', 
            'ItemNoProdCheck11', 
            'ItemNoProdCheck12', 
            'ItemNoProdCheck13', 
            'ItemNoProdCheck14', 
            'ItemNoProdCheck15', 
            'ItemNoProdCheck16', 
            'ItemNoProdCheck17', 
            'ItemNoProdCheck18', 
            'ItemNoProdCheck19', 
            'ItemNoProdCheck20', 
            'ItemNoLastPackLineNo', 
            'ItemNoPutaxPcent', 
            'ItemNoAcctItmSltax', 
            'ItemNoSltaxPcent', 
            'ItemNoPurUom', 
            'ItemNoPurLotSize', 
            'ItemNoPurCcy', 
            'ItemNoPurBasePrice', 
            'ItemNoQtyNetAvailable', 
            'ItemNoUseStdProdLeadTime', 
            'ItemNoDailyProdQty', 
            'ItemNoIssueLotSize', 
            'ItemNoMrpExclude', 
            'ItemNoEnableLot', 
            'ItemNoEnableSerial', 
            'ItemNoLotNoLength', 
            'ItemNoSerialNoLength', 
            'ItemNoNextLotNo', 
            'ItemNoNextSerialNo', 
            'ItemNoMaxLotSize', 
            'ItemNoLotNoPrefix', 
            'ItemNoSerialNoPrefix', 
            'ItemNoSafeStockLvl', 
            'ItemNoMainBin', 
            'ItemNoCustomProdCode', 
            'ItemNoCustomLotSize', 
            'ItemNoCustomGrUom', 
            'ItemNoCustomGrWt', 
            'ItemNoCustomNtWt', 
            'ItemNoCustomOrigin', 
            'ItemNoIsApproved', 
            'ItemNoApprovedBy', 
            'ItemNoPreapprove', 
            'ItemNoApprovedDate', 
            'ItemNoQtyOnTransfer', 
            'ItemNoWithResetLot', 
            'ItemNoWithResetSerial', 
            'ItemNoPrevResetLotDate', 
            'ItemNoPrevResetSerialDate', 
            'ItemNoAutogenLot', 
            'ItemNoAutogenSerial', 
            'ItemNoFabItem', 
            'ItemNoAnlys5', 
            'ItemNoAnlys6', 
            'ItemNoAnlys7', 
            'ItemNoAnlys8', 
            'ItemNoAnlys9', 
            'ItemNoAnlys10', 
            'ItemNoUserDefinedField1', 
            'ItemNoUserDefinedField2', 
            'ItemNoUserDefinedField3', 
            'ItemNoUserDefinedField4', 
            'ItemNoUserDefinedField5', 
            'ItemNoUserDefinedField6', 
            'ItemNoUserDefinedField7', 
            'ItemNoUserDefinedField8', 
            'ItemNoUserDefinedField9', 
            'ItemNoUserDefinedField10', 
            'ItemNoUserDefinedField11', 
            'ItemNoUserDefinedField12', 
            'ItemNoUserDefinedField13', 
            'ItemNoUserDefinedField14', 
            'ItemNoUserDefinedField15', 
            'ItemNoUserDefinedField16', 
            'ItemNoUserDefinedField17', 
            'ItemNoUserDefinedField18', 
            'ItemNoUserDefinedField19', 
            'ItemNoUserDefinedField20', 
            'ItemNoRohsCompliance', 
            'ItemNoDefMoldBomNo', 
            'ItemNoDefFormulaCode', 
            'ItemNoBoxType', 
            'ItemNoBoxLength', 
            'ItemNoBoxWidth', 
            'ItemNoBoxHeight', 
            'ItemNoBoxDUom', 
            'ItemNoWd', 
            'ItemNoWdUom', 
            'ItemNoCsLength', 
            'ItemNoCsWidth', 
            'ItemNoUserDefinedField21', 
            'ItemNoCostWmove', 
            'ItemNoCostWcase', 
            'ItemNoCostWband', 
            'ItemNoCostBatt', 
            'ItemNoDescWmove', 
            'ItemNoDescWcase', 
            'ItemNoDescWband', 
            'ItemNoDescBatt', 
            'ItemNoPoBal', 
            'ItemNoPoMaxBal', 
            'ItemNoIncludeJob', 
            'ItemNoCsThickness', 
            'ItemNoCsThicknessUom', 
            'ItemNoCsProportion', 
            'ItemNoCsProportionUom', 
            'ItemNoDieCutter', 
            'ItemNoMatInspectLeadTime', 
            'ItemNoMatPrepareLeadTime', 
            'ItemNoMatInspectLeadUnit', 
            'ItemNoMatPrepareLeadUnit', 
            'ItemNoColorCode', 
            'ItemNoCollectionCode', 
            'ItemNoStyleCode', 
            'ItemNoX', 
            'ItemNoY', 
            'ItemNoTempDescription', 
            'ItemNoSpecification', 
            'ItemNoXUom', 
            'ItemNoYUom', 
            'ItemNoProductionUomConversionRate', 
            'ItemNoPurchaseUomConversionRate', 
            'ItemNoAutogenLotIssue', 
            'ItemNoAutogenSerialIssue', 
            'ItemNoWcCostCcy', 
            'ItemNoWcCost', 
            'ItemNoWcCostDisc', 
            'ItemNoWcCostExch', 
            'ItemNoWcFreight', 
            'ItemNoWcMargin', 
            'ItemNoCeilingPrice', 
            'ItemNoBottomRatio', 
            'ItemNoBottomPrice', 
            'ItemNoDrawingNo', 
            'ItemNoMaterialType'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

