namespace Matrix.Production {
    export class JobOrderForm extends Serenity.PrefixedContext {
        static formKey = 'Production.JobOrder';

    }

    export interface JobOrderForm {
        JobNo: Serenity.StringEditor;
        Posted: Serenity.StringEditor;
        Closed: Serenity.StringEditor;
        Issued: Serenity.StringEditor;
        Finished: Serenity.StringEditor;
        AssemblyType: Serenity.StringEditor;
        SourceSubjob: Serenity.StringEditor;
        SourceSales: Serenity.StringEditor;
        SourceAssort: Serenity.StringEditor;
        SourceRefNo: Serenity.StringEditor;
        SourceLineNo: Serenity.DecimalEditor;
        SourcePartNo: Serenity.DecimalEditor;
        IssueDate: Serenity.DateEditor;
        DueDate: Serenity.DateEditor;
        StartDate: Serenity.DateEditor;
        ItemNo: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        Uom: Serenity.StringEditor;
        TotalQty: Serenity.DecimalEditor;
        SpecNo: Serenity.StringEditor;
        BomNo: Serenity.StringEditor;
        StdOutput: Serenity.DecimalEditor;
        ProdLotSize: Serenity.DecimalEditor;
        NoOfLots: Serenity.DecimalEditor;
        BatchedLots: Serenity.DecimalEditor;
        HrsPerLot: Serenity.DecimalEditor;
        HrsPerLotCpd: Serenity.DecimalEditor;
        BranchNo: Serenity.StringEditor;
        AssemblyLine: Serenity.StringEditor;
        JobCategory: Serenity.StringEditor;
        JobPriority: Serenity.DecimalEditor;
        HeaderVerified: Serenity.StringEditor;
        ByprodVerified: Serenity.StringEditor;
        BatchVerified: Serenity.StringEditor;
        BomVerified: Serenity.StringEditor;
        RoutingVerifed: Serenity.StringEditor;
        MatschVerified: Serenity.StringEditor;
        WrkschVerified: Serenity.StringEditor;
        CostVerified: Serenity.StringEditor;
        ByprCostShare: Serenity.DecimalEditor;
        TicketNeeded: Serenity.StringEditor;
        TicketClosed: Serenity.StringEditor;
        CreatedDate: Serenity.DateEditor;
        CreatedBy: Serenity.StringEditor;
        RevisedDate: Serenity.DateEditor;
        RevisedBy: Serenity.StringEditor;
        PostedDate: Serenity.DateEditor;
        PostedBy: Serenity.StringEditor;
        LastLineNo: Serenity.DecimalEditor;
        LastByprodNo: Serenity.DecimalEditor;
        BatchCount: Serenity.DecimalEditor;
        LastLogNo: Serenity.DecimalEditor;
        LockType: Serenity.StringEditor;
        LockRefNo: Serenity.StringEditor;
        FgLoc: Serenity.StringEditor;
        RmLoc: Serenity.StringEditor;
        CostMaterial: Serenity.DecimalEditor;
        CostLabor: Serenity.DecimalEditor;
        CostSubcon: Serenity.DecimalEditor;
        CostMachine: Serenity.DecimalEditor;
        CostEnergy: Serenity.DecimalEditor;
        CostWater: Serenity.DecimalEditor;
        CostRental: Serenity.DecimalEditor;
        CostInlab: Serenity.DecimalEditor;
        CostInmat: Serenity.DecimalEditor;
        CostMisc: Serenity.DecimalEditor;
        CostOverhead: Serenity.DecimalEditor;
        CostEstimate: Serenity.DecimalEditor;
        CostFinished: Serenity.DecimalEditor;
        CostScrapped: Serenity.DecimalEditor;
        CostCharged: Serenity.DecimalEditor;
        CoacRmConsu: Serenity.DecimalEditor;
        CoacRmScrap: Serenity.DecimalEditor;
        CoacMaterial: Serenity.DecimalEditor;
        CoacLabor: Serenity.DecimalEditor;
        CoacSubcon: Serenity.DecimalEditor;
        CoacMachine: Serenity.DecimalEditor;
        CoacEnergy: Serenity.DecimalEditor;
        CoacWater: Serenity.DecimalEditor;
        CoacRental: Serenity.DecimalEditor;
        CoacInlab: Serenity.DecimalEditor;
        CoacInmat: Serenity.DecimalEditor;
        CoacMisc: Serenity.DecimalEditor;
        CoacOverhead: Serenity.DecimalEditor;
        CostActual: Serenity.DecimalEditor;
        CostVariance: Serenity.DecimalEditor;
        CostWip: Serenity.DecimalEditor;
        AcctWip: Serenity.StringEditor;
        AcctPvar: Serenity.StringEditor;
        AcctProdCost: Serenity.StringEditor;
        CanEdit: Serenity.StringEditor;
        LastSubNo: Serenity.DecimalEditor;
        SubjobVerified: Serenity.StringEditor;
        LotsIssued: Serenity.DecimalEditor;
        LotsFinished: Serenity.DecimalEditor;
        OwnerBranch: Serenity.StringEditor;
        SourceBranch: Serenity.StringEditor;
        FinishedType: Serenity.StringEditor;
        FinishedDate: Serenity.DateEditor;
        Specifications: Serenity.StringEditor;
        QtyNeeded: Serenity.DecimalEditor;
        ScrapRate: Serenity.DecimalEditor;
        ScrapQty: Serenity.DecimalEditor;
        QtyAdjusted: Serenity.DecimalEditor;
        NetWt: Serenity.DecimalEditor;
        NetWtUom: Serenity.StringEditor;
        Anlys1: Serenity.StringEditor;
        Anlys2: Serenity.StringEditor;
        BlowThru: Serenity.StringEditor;
        Comments1: Serenity.StringEditor;
        Comments2: Serenity.StringEditor;
        Comments3: Serenity.StringEditor;
        Comments4: Serenity.StringEditor;
        LastTextNo: Serenity.DecimalEditor;
        BomRevision: Serenity.StringEditor;
        Anlys7: Serenity.StringEditor;
        Anlys8: Serenity.StringEditor;
        LastLinkNo: Serenity.DecimalEditor;
        Flag: Serenity.StringEditor;
        HoldBy: Serenity.StringEditor;
        IncludeScrapRate: Serenity.StringEditor;
        UseItemMasterScrap: Serenity.StringEditor;
        WcBackflush: Serenity.StringEditor;
        Reorder: Serenity.StringEditor;
        CostRework: Serenity.DecimalEditor;
        MoldJob: Serenity.StringEditor;
        MoldDesc: Serenity.StringEditor;
        Anlys9: Serenity.StringEditor;
        Anlys10: Serenity.StringEditor;
        Anlys11: Serenity.StringEditor;
        Anlys12: Serenity.StringEditor;
        Anlys13: Serenity.StringEditor;
        Anlys14: Serenity.StringEditor;
        ProjectNo: Serenity.StringEditor;
        SourceMrpNo: Serenity.StringEditor;
    }

    [['JobNo', () => Serenity.StringEditor]
   , ['Posted', () => Serenity.StringEditor]
   , ['Closed', () => Serenity.StringEditor]
   , ['Issued', () => Serenity.StringEditor]
   , ['Finished', () => Serenity.StringEditor]
   , ['AssemblyType', () => Serenity.StringEditor]
   , ['SourceSubjob', () => Serenity.StringEditor]
   , ['SourceSales', () => Serenity.StringEditor]
   , ['SourceAssort', () => Serenity.StringEditor]
   , ['SourceRefNo', () => Serenity.StringEditor]
   , ['SourceLineNo', () => Serenity.DecimalEditor]
   , ['SourcePartNo', () => Serenity.DecimalEditor]
   , ['IssueDate', () => Serenity.DateEditor]
   , ['DueDate', () => Serenity.DateEditor]
   , ['StartDate', () => Serenity.DateEditor]
   , ['ItemNo', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['Uom', () => Serenity.StringEditor]
   , ['TotalQty', () => Serenity.DecimalEditor]
   , ['SpecNo', () => Serenity.StringEditor]
   , ['BomNo', () => Serenity.StringEditor]
   , ['StdOutput', () => Serenity.DecimalEditor]
   , ['ProdLotSize', () => Serenity.DecimalEditor]
   , ['NoOfLots', () => Serenity.DecimalEditor]
   , ['BatchedLots', () => Serenity.DecimalEditor]
   , ['HrsPerLot', () => Serenity.DecimalEditor]
   , ['HrsPerLotCpd', () => Serenity.DecimalEditor]
   , ['BranchNo', () => Serenity.StringEditor]
   , ['AssemblyLine', () => Serenity.StringEditor]
   , ['JobCategory', () => Serenity.StringEditor]
   , ['JobPriority', () => Serenity.DecimalEditor]
   , ['HeaderVerified', () => Serenity.StringEditor]
   , ['ByprodVerified', () => Serenity.StringEditor]
   , ['BatchVerified', () => Serenity.StringEditor]
   , ['BomVerified', () => Serenity.StringEditor]
   , ['RoutingVerifed', () => Serenity.StringEditor]
   , ['MatschVerified', () => Serenity.StringEditor]
   , ['WrkschVerified', () => Serenity.StringEditor]
   , ['CostVerified', () => Serenity.StringEditor]
   , ['ByprCostShare', () => Serenity.DecimalEditor]
   , ['TicketNeeded', () => Serenity.StringEditor]
   , ['TicketClosed', () => Serenity.StringEditor]
   , ['CreatedDate', () => Serenity.DateEditor]
   , ['CreatedBy', () => Serenity.StringEditor]
   , ['RevisedDate', () => Serenity.DateEditor]
   , ['RevisedBy', () => Serenity.StringEditor]
   , ['PostedDate', () => Serenity.DateEditor]
   , ['PostedBy', () => Serenity.StringEditor]
   , ['LastLineNo', () => Serenity.DecimalEditor]
   , ['LastByprodNo', () => Serenity.DecimalEditor]
   , ['BatchCount', () => Serenity.DecimalEditor]
   , ['LastLogNo', () => Serenity.DecimalEditor]
   , ['LockType', () => Serenity.StringEditor]
   , ['LockRefNo', () => Serenity.StringEditor]
   , ['FgLoc', () => Serenity.StringEditor]
   , ['RmLoc', () => Serenity.StringEditor]
   , ['CostMaterial', () => Serenity.DecimalEditor]
   , ['CostLabor', () => Serenity.DecimalEditor]
   , ['CostSubcon', () => Serenity.DecimalEditor]
   , ['CostMachine', () => Serenity.DecimalEditor]
   , ['CostEnergy', () => Serenity.DecimalEditor]
   , ['CostWater', () => Serenity.DecimalEditor]
   , ['CostRental', () => Serenity.DecimalEditor]
   , ['CostInlab', () => Serenity.DecimalEditor]
   , ['CostInmat', () => Serenity.DecimalEditor]
   , ['CostMisc', () => Serenity.DecimalEditor]
   , ['CostOverhead', () => Serenity.DecimalEditor]
   , ['CostEstimate', () => Serenity.DecimalEditor]
   , ['CostFinished', () => Serenity.DecimalEditor]
   , ['CostScrapped', () => Serenity.DecimalEditor]
   , ['CostCharged', () => Serenity.DecimalEditor]
   , ['CoacRmConsu', () => Serenity.DecimalEditor]
   , ['CoacRmScrap', () => Serenity.DecimalEditor]
   , ['CoacMaterial', () => Serenity.DecimalEditor]
   , ['CoacLabor', () => Serenity.DecimalEditor]
   , ['CoacSubcon', () => Serenity.DecimalEditor]
   , ['CoacMachine', () => Serenity.DecimalEditor]
   , ['CoacEnergy', () => Serenity.DecimalEditor]
   , ['CoacWater', () => Serenity.DecimalEditor]
   , ['CoacRental', () => Serenity.DecimalEditor]
   , ['CoacInlab', () => Serenity.DecimalEditor]
   , ['CoacInmat', () => Serenity.DecimalEditor]
   , ['CoacMisc', () => Serenity.DecimalEditor]
   , ['CoacOverhead', () => Serenity.DecimalEditor]
   , ['CostActual', () => Serenity.DecimalEditor]
   , ['CostVariance', () => Serenity.DecimalEditor]
   , ['CostWip', () => Serenity.DecimalEditor]
   , ['AcctWip', () => Serenity.StringEditor]
   , ['AcctPvar', () => Serenity.StringEditor]
   , ['AcctProdCost', () => Serenity.StringEditor]
   , ['CanEdit', () => Serenity.StringEditor]
   , ['LastSubNo', () => Serenity.DecimalEditor]
   , ['SubjobVerified', () => Serenity.StringEditor]
   , ['LotsIssued', () => Serenity.DecimalEditor]
   , ['LotsFinished', () => Serenity.DecimalEditor]
   , ['OwnerBranch', () => Serenity.StringEditor]
   , ['SourceBranch', () => Serenity.StringEditor]
   , ['FinishedType', () => Serenity.StringEditor]
   , ['FinishedDate', () => Serenity.DateEditor]
   , ['Specifications', () => Serenity.StringEditor]
   , ['QtyNeeded', () => Serenity.DecimalEditor]
   , ['ScrapRate', () => Serenity.DecimalEditor]
   , ['ScrapQty', () => Serenity.DecimalEditor]
   , ['QtyAdjusted', () => Serenity.DecimalEditor]
   , ['NetWt', () => Serenity.DecimalEditor]
   , ['NetWtUom', () => Serenity.StringEditor]
   , ['Anlys1', () => Serenity.StringEditor]
   , ['Anlys2', () => Serenity.StringEditor]
   , ['BlowThru', () => Serenity.StringEditor]
   , ['Comments1', () => Serenity.StringEditor]
   , ['Comments2', () => Serenity.StringEditor]
   , ['Comments3', () => Serenity.StringEditor]
   , ['Comments4', () => Serenity.StringEditor]
   , ['LastTextNo', () => Serenity.DecimalEditor]
   , ['BomRevision', () => Serenity.StringEditor]
   , ['Anlys7', () => Serenity.StringEditor]
   , ['Anlys8', () => Serenity.StringEditor]
   , ['LastLinkNo', () => Serenity.DecimalEditor]
   , ['Flag', () => Serenity.StringEditor]
   , ['HoldBy', () => Serenity.StringEditor]
   , ['IncludeScrapRate', () => Serenity.StringEditor]
   , ['UseItemMasterScrap', () => Serenity.StringEditor]
   , ['WcBackflush', () => Serenity.StringEditor]
   , ['Reorder', () => Serenity.StringEditor]
   , ['CostRework', () => Serenity.DecimalEditor]
   , ['MoldJob', () => Serenity.StringEditor]
   , ['MoldDesc', () => Serenity.StringEditor]
   , ['Anlys9', () => Serenity.StringEditor]
   , ['Anlys10', () => Serenity.StringEditor]
   , ['Anlys11', () => Serenity.StringEditor]
   , ['Anlys12', () => Serenity.StringEditor]
   , ['Anlys13', () => Serenity.StringEditor]
   , ['Anlys14', () => Serenity.StringEditor]
   , ['ProjectNo', () => Serenity.StringEditor]
   , ['SourceMrpNo', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(JobOrderForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

