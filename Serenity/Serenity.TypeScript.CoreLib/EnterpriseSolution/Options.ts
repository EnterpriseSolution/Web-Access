namespace App {

    export interface IOptionsItem {
        text: string;
        value: number;
    }

    export enum ProcessUnitType {
        Undefine = 0,
        Curede = 1,
        Secondary = 2
    }

    export enum IsShutdownOption {
        Undefine = 0,
        Normal = 1,
        Shutdown = 2
    }

    export enum OrderType {
        Loading = 1,
        Discharge = 2
    }

    export enum ShipmentOperationType {
        Anchorage = 1,
        WharfNomination = 2,
        Berthing = 3,
        Sailing = 4,
        WharfChangeSailing = 5,
        WharfChangeBerthing = 6
    }

    export enum TaskType {
        Feed = 1,
        Rundown = 2,
        Loading = 3,
        Discharge = 4,
        Transfer = 5,
        Draining = 6,
        Mixing = 7,
        Settling = 8,
        Refinery = 9,
    }

    export enum FeedSubType {
        CrudeUnitFeed = 1,
        SecondaryUnitFeed = 2,
        HotFeed = 3,
    }

    export enum RundownSubType {
        CrudeUnitRundown = 101,
        CrudeUnitHotRundown = 102,
        SecondaryUnitRundown = 103,
        SecondaryUnitHotRundown = 104,
        OffGradeRundown = 105,
        RecirculationRundown = 106,
        RecirculationMasterRundown = 107,
    }

    export enum LoadingSubType {
        Loading = 201,
        BunkerLoading = 202,
    }

    export enum DischargeSubType {
        Discharge = 301,
    }

    export enum FeedSpikeType {
        CrudeSpike = 2,
        IndCrudeSpike = 3,
        SlopSpike = 4,
        RecirculationSpike = 5,
        RoundownSpike = 6
    }

    export enum FeedTankType {
        Undefine = 0,
        MainTank = 1,
        CrudeSpike = 2,
        IndCrudeSpike = 3,
        SlopSpike = 4,
        RecirculationSpike = 5,
        RoundownSpike = 6
    }


    export enum StopConditionType {
        Undefine = 0,
        AbsoluteTime = 1,
        TillLow = 2,
        TillHigh = 3,
        SourceLevelTo = 4,
        DestinationLevelTo = 5,
        SourceVolumeTo = 6,
        DestinationVolumeTo = 7,
        XferQuantity = 8,
        ElapsedHours = 9,
        RelatedRDTankLevel = 10,
        BalanceQuantity = 11,
    }

    export enum ConditionType {
        Undefine = 0,
        AbsoluteTime = 1,
        TillLow = 2,
        TillHigh = 3,
        TillLevel = 4,
        TillVolume = 5,
        QtyMass = 6,
        QtyVolume = 7,
        BalanceQuantity = 8,
    }


    export enum TaskStatusOption {
        None = 0,
        UnDefined = 1,
        Defined = 2,
        Pending = 3,
        Active = 4,
        Interrupted = 5,
        Finished = 6,
        Completed = 7,
        Closed = 8
    }

    export enum CCStatusOption {
        Undefined = 0,
        OnSpec = 1,
        OffSpec = 2,
        Pending = 3,
        NotFound = 4
    }

    export enum ActivityStatusOption {
        Defined = 1,
        Selected = 2,
        Nominated = 3,
        Pending = 4,
        Active = 5,
        Intereupted = 6,
        Finished = 7,
        Cancelled = 8
    }

    export enum RefineryTransferSourceDestinationType {
        Tank = 1,
        Sink = 2
    }

    export enum ActivityType {
        /// <summary>
        /// Falg : CF
        /// </summary>
        CrudeUnitFeed = 1,
        /// <summary>
        /// Falg : SF
        /// </summary>
        SecondaryUnitFeed = 2,
        /// <summary>
        /// Falg : RD
        /// </summary>
        Rundown = 3,
        /// <summary>
        /// Falg : OF
        /// </summary>
        OffGradeRundown = 4,
        /// <summary>
        /// Falg : RC
        /// </summary>
        RecirculationRundown = 5,
        /// <summary>
        /// Falg : LB
        /// </summary>
        ILBLoading = 6,
        /// <summary>
        /// Falg : LS
        /// </summary>
        STLoading = 7,
        /// <summary>
        /// Falg : GB
        /// </summary>
        ILBLPGLoading = 8,
        /// <summary>
        /// Falg : GS
        /// </summary>
        STLPGLoading = 9,
        /// <summary>
        /// Falg : BL
        /// </summary>
        BunkerLoading = 10,
        /// <summary>
        /// Falg : BX
        /// </summary>
        BunkerTransfer = 11,
        /// <summary>
        /// Falg : DI
        /// </summary>
        Discharge = 12,
        /// <summary>
        /// Falg : XB
        /// </summary>
        ILBTransfer = 13,
        /// <summary>
        /// Falg : XT
        /// </summary>
        STTransfer = 14,
        /// <summary>
        /// Falg : CB
        /// </summary>
        ILBLineClearing = 15,
        /// <summary>
        /// Falg : CS
        /// </summary>
        STLineClearing = 16,
        /// <summary>
        /// Falg : XG
        /// </summary>
        GravityTransfer = 17,
        /// <summary>
        /// Falg : XM
        /// </summary>
        CirculationMixing = 18,
        /// <summary>
        /// Falg : XX
        /// </summary>
        RefineryTransfer = 19,
        /// <summary>
        /// Falg : XS
        /// </summary>
        SlopsTransfer = 20,
        /// <summary>
        /// Falg : CD
        /// </summary>
        CrudeDraining = 21,
        /// <summary>
        /// Falg : SD
        /// </summary>
        SlopsDraining = 22,
        /// <summary>
        /// Falg : PS
        /// </summary>
        ProductDraining = 23,
        /// <summary>
        /// Falg : MM
        /// </summary>
        Mixing = 24,
        /// <summary>
        /// Falg : SS
        /// </summary>
        Settling = 25,
        /// <summary>
        /// Falg : AI
        /// </summary>
        AdditiveInjection = 26

    }

    export enum AmendedOption {
        No = 0,
        Yes = 1,
    }

    export enum YesNoOption {
        No = 0,
        Yes = 1,
    }

    export enum UOMOption {
        Undefine = 0,
        Litre = 1,
        M3 = 2,
        MT = 3,
        /// <summary>
        /// Order.UOM
        /// </summary>
        BBLS = 4,
        /// <summary>
        /// Level's UOM (mm)
        /// </summary>
        MM = 5,
        //-------------Activity_Additive.UOM
        PPM = 10,
        MgL = 11,
        MgM3 = 12,
        MlM3 = 13,
        PercentV = 14,

        //-------------LAB_TBRecipe.UOM
        //%VOL
        PercentVOL = 20,
        //%W
        PercentW = 21,
        //%MT
        PercentMT = 22,
    }

    export enum OperationModeDestinationType {
        Undefine = 0,
        SD = 1,
        Tank = 2,
        ProcessUnit = 3
    }
    export enum TickFlagOption {
        None = 0,
        Activation = 1,
        Stop = 2,
        Deletion = 3,
        SwingRequest = 4
    }
    export enum OpFlagOption {
        None = 0,
        RequestActivation = 1,
        Activation = 2,
        RequestStop = 3,
        Stop = 4,
        RequestSwitchOver = 5,
        RequestDeletion = 6,
        Deletion = 7
    }
    export enum EquipmentType {
        None = 0,
        Line = 1,
        Pump = 2,
        Sink = 3,
        Spade = 4,
        Tank = 5,
        Unit = 6,
        Valve = 7,
        Wharf = 8,
        BlendController = 9,
        AutoSampler = 10,
        DigitalSwitch = 11,
        CustodyMeter = 12,
        FlowController = 13,
        HandController = 14,
        AdditiveVessel = 15,
        Boom = 16,
        Microfilter = 17,
        BunkerMeter = 18,
        Mixer = 21,
        Other = 99
    }

    export enum PathType {
        DischargeHeader = 1,
        Discharge = 2,
        SuctionPath = 3,
        Pump = 4,
        Boom = 5,
        AdditiveInjection = 6,
        LPGSpikingSuction = 7,
        Microfilter = 8,
        MiniFlowReturn = 9,
        VaporReturn = 10,
        LineClearing = 11,
        Precanned = 12,

        LPGSpikingDischargeHeader = 13,
        LPGSpikingDischarge = 14,
        LPGSpikingPump = 15,
        LPGSpikingReturn = 16,

        CrudeSpikingSuctionOne = 17,
        CrudeSpikingDischargeHeaderOne = 18,
        CrudeSpikingDischargeOne = 19,
        CrudeSpikingPumpOne = 20,

        CrudeSpikingSuctionTwo = 21,
        CrudeSpikingDischargeHeaderTwo = 22,
        CrudeSpikingDischargeTwo = 23,
        CrudeSpikingPumpTwo = 24,

        IndCrudeSpikingSuction = 25,
        IndCrudeSpikingDischargeHeader = 26,
        IndCrudeSpikingDischarge = 27,
        IndCrudeSpikingPump = 28,

        SlopSpikingSuction = 29,
        SlopSpikingDischargeHeader = 30,
        SlopSpikingDischarge = 31,
        SlopSpikingPump = 32,

        RecirculationSpikingSuction = 33,
        RecirculationSpikingDischargeHeader = 34,
        RecirculationSpikingDischarge = 35,
        RecirculationSpikingPump = 36,

        RundownSpikingSuction = 103,
        RundownSpikingDischargeHeader = 104,
        RundownSpikingDischarge = 105,
        RundownSpikingPump = 106
    }

    export enum PathSelectRuleType {
        None = 0,
        Restriction = 1,
        PrioritizationSequence = 2,
        LineSegment = 3
    }

    export enum PathSelectRuleNOOption {
        None = 0,
        ExcludeLine = 1,
        LineService = 2,
        ExcludeLineType = 3,
        IncludeLineType = 4,
        IncludeLine = 5,

        MinLineClearingVolume = 101,
        MinCountOfLineSegments = 102,
        CustodayMeterAvailable = 103,
        AutoSamplerAvailable = 104,

        MinCountOfPumps = 201,
        MinPowerConsumption = 202,
        MaxFlowrateRange = 203,
        MinTotalRunningHours = 204,
    }

    export enum PathSelectionModeOption {
        Available = 1,
        Possible = 2,
        Feasible = 3
    }

    export enum PreferredPathOption {
        None = 0,
        LastUsed = 1,
        MostUsed = 2,
    }
    export enum PathSelectionStepNo {
        DischargeHeader = PathType.DischargeHeader,
        Discharge = PathType.Discharge,
        SuctionPath = PathType.SuctionPath,
        Pump = PathType.Pump,
        Boom = PathType.Boom,
        AdditiveInjection = PathType.AdditiveInjection,
        LPGSpiking = PathType.LPGSpikingSuction,
        Microfilter = PathType.Microfilter,
        MiniFlowReturn = PathType.MiniFlowReturn,
        VaporReturn = PathType.VaporReturn,
        LineClearing = PathType.LineClearing,


        DeterminaRestrictionAndPriority = 101,
        FullPath = 102,

        CrudeSpikingOne = PathType.CrudeSpikingSuctionOne,
        CrudeSpikingTwo = PathType.CrudeSpikingSuctionTwo,
        IndCrudeSpiking = PathType.IndCrudeSpikingSuction,
        SlopSpiking = PathType.SlopSpikingSuction,
        RecirculationSpiking = PathType.RecirculationSpikingSuction,
        RundownSpiking = PathType.RundownSpikingSuction,
        Precanned = PathType.Precanned
    }

    export class Format {
        static ONUMBER: string = "onumber";
        static ODATE: string = "odate";
    }
    export class FormatValue {
        static ONUMBER: string = "#,###.000";
    }
    export class DateTimeFormat {
        static DateTimeSecond: string;//dd/MM/yyyy HH:mm:ss
        static DateTimeMinute: string;
        static DateTimeHour: string;
        static DateTimeDay: string;//dd/MM/yyyy
        static TimeSecondPart: string;//HH:mm:ss
        static ShortDay: string;
        static ShortHour: string;
        static ShortMinute: string;
        static TimeMinutePart: string;//HH:mm
    }
    export class ParamKey {
        static ID: string = "id";
        static ActivityId: string = "activityid";
        static TaskId: string = "taskid";
        static OPERATION: string = "operation";
        static PAGECHANGE: string = "pagechage";
    }
    export class Operation {
        static ADD = "add";
        static UPDATE = "update";
        static DELETE = "delete";
        static COPY = "copy";
    }
    export class MasterDataType {
        static ProductPool: string = "ProductPool";
        static ProductGroup: string = "ProductGroup";
        static Product: string = "Product";
        static ProductProperty: string = "ProductProperty";
        static ProductPropertyData: string = "ProductPropertyData";
        static BlendProProductPropertyDataMapping: string = "BlendProProductPropertyDataMapping";
        static Crude: string = "Crude";
        static CrudeProductMapping: string = "CrudeProductMapping";
        static Additive: string = "Additive";
        static ProductAdditiveMapping: string = "ProductAdditiveMapping";
        static AdditiveVessel: string = "AdditiveVessel";
        static AutoSampler: string = "AutoSampler";
        static BlendController: string = "BlendController";
        static Boom: string = "Boom";
        static DigitalSwitch: string = "DigitalSwitch";
        static HandController: string = "HandController";
        static Line: string = "Line";
        static Meter: string = "Meter";
        static Microfilter: string = "Microfilter";
        static PumpHouse: string = "PumpHouse";
        static Pump: string = "Pump";
        static PumpMeterMapping: string = "PumpMeterMapping";
        static RatioController: string = "RatioController";
        static ProcessUnit: string = "ProcessUnit";
        static ProcessUnitProductPoolMapping: string = "ProcessUnitProductPoolMapping";
        static RundownStream: string = "RundownStream";
        static RundownStreamProductPoolMapping: string = "RundownStreamProductPoolMapping";
        static RundownCut: string = "RundownCut";
        static RundownCutProductGroupMapping: string = "RundownCutProductGroupMapping";
        static Ship: string = "Ship";
        static Sink: string = "Sink";
        static Spade: string = "Spade";
        static Tank: string = "Tank";
        static Valve: string = "Valve";
        static Wharf: string = "Wharf";
        static Mixer: string = "Mixer";
        static TankArm: string = "TankArm";
        static TankMixerActivation: string = "TankMixerActivation";
        static ProductCompatibility: string = "ProductCompatibility";
        static CustodyMeter: string = "CustodyMeter";
        static PipelineProductVT: string = "PipelineProductVT";
        static PipelineProductMapping: string = "PipelineProductMapping";
        static CustodyMeterVT: string = "CustodyMeterVT";
        static CustodyMeterVTMapping: string = "CustodyMeterVTMapping";
        static FlowController: string = "FlowController";
    }

    export enum SwingPatternOption {
        Original = 1,
        SWPattern1 = 2,
        SWPattern2 = 3,
        SWPattern3 = 4,
    }
    export enum ActionSourceOption {
        Next = 1,
        Save = 2,
        Terminat = 3
    }
    export enum TaskSubType {
        CrudeUnitFeed = 1,
        SecondaryUnitFeed = 2,
        HotFeed = 3,

        CrudeUnitRundown = 101,
        CrudeUnitHotRundown = 102,
        SecondaryUnitRundown = 103,
        SecondaryUnitHotRundown = 104,
        OffGradeRundown = 105,
        RecirculationRundown = 106,
        RecirculationMasterRundown = 107,

        Loading = 201,
        BunkerLoading = 202,

        Discharge = 301,

        Transfer = 401,
        CirculationMixing = 402,

        CrudeDraining = 501,
        ProductDraining = 502,

        Mixing = 601,

        Settling = 701,

        Refinery = 801,
    }
    export enum SecurityMessageType {
        Alarm = 1,
        Notification = 2
    }
    export enum MessageObjectType {
        Task = 1,
        Activity = 2,
        Tank = 3,
        Order = 4
    }

    export enum AlarmObjectType {
        Task = MessageObjectType.Task,
        Activity = MessageObjectType.Activity,
        Tank = MessageObjectType.Tank,
    }

    export enum NotificationObjectType {
        Task = MessageObjectType.Task,
        Activity = MessageObjectType.Activity,
        Order = MessageObjectType.Order
    }

    export enum MessageSourceType {
        TankHighScan = 1001,
        TankMonitoring = 1002,
        System = 1003,

        //sub task type
        CrudeUnitFeed = TaskSubType.CrudeUnitFeed,
        SecondaryUnitFeed = TaskSubType.SecondaryUnitFeed,
        HotFeed = TaskSubType.HotFeed,

        CrudeUnitRundown = TaskSubType.CrudeUnitRundown,
        CrudeUnitHotRundown = TaskSubType.CrudeUnitHotRundown,
        SecondaryUnitRundown = TaskSubType.SecondaryUnitRundown,
        SecondaryUnitHotRundown = TaskSubType.SecondaryUnitHotRundown,
        OffGradeRundown = TaskSubType.OffGradeRundown,
        RecirculationRundown = TaskSubType.RecirculationRundown,
        RecirculationMasterRundown = TaskSubType.RecirculationMasterRundown,

        Loading = TaskSubType.Loading,
        BunkerLoading = TaskSubType.BunkerLoading,

        Discharge = TaskSubType.Discharge,

        Transfer = TaskSubType.Transfer,

        CrudeDraining = TaskSubType.CrudeDraining,
        ProductDraining = TaskSubType.ProductDraining,

        Mixing = TaskSubType.Mixing,

        Settling = TaskSubType.Settling,

        Refinery = TaskSubType.Refinery
    }

    export enum AlarmSourceType {
        TankHighScan = MessageSourceType.TankHighScan,
        TankMonitoring = MessageSourceType.TankMonitoring,
        System = MessageSourceType.System,

        //sub task type
        CrudeUnitFeed = MessageSourceType.CrudeUnitFeed,
        SecondaryUnitFeed = MessageSourceType.SecondaryUnitFeed,
        HotFeed = MessageSourceType.HotFeed,

        CrudeUnitRundown = MessageSourceType.CrudeUnitRundown,
        CrudeUnitHotRundown = MessageSourceType.CrudeUnitHotRundown,
        SecondaryUnitRundown = MessageSourceType.SecondaryUnitRundown,
        SecondaryUnitHotRundown = MessageSourceType.SecondaryUnitHotRundown,
        OffGradeRundown = MessageSourceType.OffGradeRundown,
        RecirculationRundown = MessageSourceType.RecirculationRundown,
        RecirculationMasterRundown = MessageSourceType.RecirculationMasterRundown,

        Loading = MessageSourceType.Loading,
        BunkerLoading = MessageSourceType.BunkerLoading,

        Discharge = MessageSourceType.Discharge,

        Transfer = MessageSourceType.Transfer,

        CrudeDraining = MessageSourceType.CrudeDraining,
        ProductDraining = MessageSourceType.ProductDraining,

        Mixing = MessageSourceType.Mixing,

        Settling = MessageSourceType.Settling,

        Refinery = MessageSourceType.Refinery,
    }

    export enum NotificationSourceType {

        //sub task type
        CrudeUnitFeed = MessageSourceType.CrudeUnitFeed,
        SecondaryUnitFeed = MessageSourceType.SecondaryUnitFeed,
        HotFeed = MessageSourceType.HotFeed,

        CrudeUnitRundown = MessageSourceType.CrudeUnitRundown,
        CrudeUnitHotRundown = MessageSourceType.CrudeUnitHotRundown,
        SecondaryUnitRundown = MessageSourceType.SecondaryUnitRundown,
        SecondaryUnitHotRundown = MessageSourceType.SecondaryUnitHotRundown,
        OffGradeRundown = MessageSourceType.OffGradeRundown,
        RecirculationRundown = MessageSourceType.RecirculationRundown,
        RecirculationMasterRundown = MessageSourceType.RecirculationMasterRundown,

        Loading = MessageSourceType.Loading,
        BunkerLoading = MessageSourceType.BunkerLoading,

        Discharge = MessageSourceType.Discharge,

        Transfer = MessageSourceType.Transfer,

        CrudeDraining = MessageSourceType.CrudeDraining,
        ProductDraining = MessageSourceType.ProductDraining,

        Mixing = MessageSourceType.Mixing,

        Settling = MessageSourceType.Settling,

        Refinery = MessageSourceType.Refinery,
    }

    export enum SecurityAlarmStatus {
        None = 0,
        NotYetAck = 1,
        Acked = 2
    }

    export enum ScanStatusOption {
        On = 1,
        Off = 2
    }

    export enum AdditiveInjectionMode {
        Auto = 0,
        Manual = 1,
    }

    export enum ValveOperationType {
        Undefine = 0,
        MCS = 1,
        MCR = 2,
        MCF = 3,
        BV = 4,
        HV = 5
    }

    export enum MappingType {
        Undefined = 0,
        AdditiveVessel = 1,
        AutoSampler = 2,
        BlendController = 3,
        Boom = 4,
        CustodyMeter = 5,
        NDI = 6,
        FlowController = 7,
        HandController = 8,
        Line = 9,
        Microfilter = 10,
        Mixer = 11,
        ProcessUnit = 12,
        Pump = 13,
        RatioController = 14,
        Sink = 15,
        Spade = 16,
        Tank = 17,
        Valve = 18,
        Wharf = 19,
        DrainingStart = 20,
        DrainingStop = 21,
        TankTemperature = 22,
        PumpAmpere = 23,
        CommunicationError = 24,
        SMReset = 25,
        WharfTrip = 26,
        NSW = 27,
        PumpNSW = 28,
        CustodyMeterNSW = 29,
        DigitalSwitchNDI = 30,
        DigitalSwitchNSW = 31,
        //AdditiveVesselGSV = 32,
        PumpTemperature = 33,


        DailyTankStock = 50,
        HighScanTankStock = 51,
        TankPressure = 52,
        OtherInstrument = 999,
    }
    export enum TSS {
        USE = 1,
        BACKUP = 2,
        INCOMING = 3,
        RELEASED = 4
    }

    export enum ActivityPagingType {
        None = 0,
        Previous = 1,
        Next = 2
    }

    export class FRMessageConstants {
        public static TASK_PEND_SUCCEEDED: string = "MSG_6_6_2254";
        public static TASK_COMPLETE_SUCCEEDED: string = "MSG_6_6_2255";
        public static CHANGE_SPECIFIED_STOP_COND_SUCCEEDED: string = "MSG_6_6_2256";

        public static ACTIVITY_START_REQUEST_SUCCEEDED: string = "MSG_6_6_2259";
        public static ACTIVITY_FINISH_REQUEST_SUCCEEDED: string = "MSG_6_6_2260";
        public static RATIO_CHANGE_SUCCEEDED: string = "MSG_6_6_2261";

        public static PATH_CANCEL_SUCCEEDED: string = "MSG_6_6_2262";
        public static PATH_RELEASE_SUCCEEDED: string = "MSG_6_6_2263";
        public static PATH_CONFIRM_SUCCEEDED: string = "MSG_6_6_2264";
        public static PATH_NOMINATE_SUCCEEDED: string = "MSG_6_6_2265";

        public static ACTIVITY_CANCEL_SUCCEEDED: string = "MSG_6_6_2266";
        public static SPIKING_TANK_ADDITION_SUCCEEDED: string = "MSG_6_6_2267";
        public static SPIKING_TANK_DELETION_SUCCEEDED: string = "MSG_6_6_2268";
        public static SPIKING_TANK_RELEASE_SUCCEEDED: string = "MSG_6_6_2269";
        public static SPIKING_TANK_SWING_START_SUCCEEDED: string = "MSG_6_6_2270";
        public static PUMP_ADDITION_SUCCEEDED: string = "MSG_6_6_2271";
        public static PUMP_DELETION_SUCCEEDED: string = "MSG_6_6_2272";
    }
}