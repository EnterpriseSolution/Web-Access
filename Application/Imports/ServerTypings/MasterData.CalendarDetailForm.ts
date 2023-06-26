namespace Matrix.MasterData {
    export class CalendarDetailForm extends Serenity.PrefixedContext {
        static formKey = 'MasterData.CalendarDetail';

    }

    export interface CalendarDetailForm {
        TranMonth: Serenity.StringEditor;
        TranDate: Serenity.DateEditor;
        TranDay: Serenity.StringEditor;
        DayNum: Serenity.DecimalEditor;
        IsHoliday: Serenity.StringEditor;
        HalfDayOnly: Serenity.StringEditor;
        FirstShift: Serenity.StringEditor;
        SecondShift: Serenity.StringEditor;
        ThirdShift: Serenity.StringEditor;
        CanReceive: Serenity.StringEditor;
        CanShip: Serenity.StringEditor;
        DayName: Serenity.StringEditor;
        LastEntryNo: Serenity.DecimalEditor;
        CreatedDate: Serenity.DateEditor;
        CreatedBy: Serenity.StringEditor;
        RevisedDate: Serenity.DateEditor;
        RevisedBy: Serenity.StringEditor;
        OwnerBranch: Serenity.StringEditor;
        SourceBranch: Serenity.StringEditor;
    }

    [['TranMonth', () => Serenity.StringEditor]
   , ['TranDate', () => Serenity.DateEditor]
   , ['TranDay', () => Serenity.StringEditor]
   , ['DayNum', () => Serenity.DecimalEditor]
   , ['IsHoliday', () => Serenity.StringEditor]
   , ['HalfDayOnly', () => Serenity.StringEditor]
   , ['FirstShift', () => Serenity.StringEditor]
   , ['SecondShift', () => Serenity.StringEditor]
   , ['ThirdShift', () => Serenity.StringEditor]
   , ['CanReceive', () => Serenity.StringEditor]
   , ['CanShip', () => Serenity.StringEditor]
   , ['DayName', () => Serenity.StringEditor]
   , ['LastEntryNo', () => Serenity.DecimalEditor]
   , ['CreatedDate', () => Serenity.DateEditor]
   , ['CreatedBy', () => Serenity.StringEditor]
   , ['RevisedDate', () => Serenity.DateEditor]
   , ['RevisedBy', () => Serenity.StringEditor]
   , ['OwnerBranch', () => Serenity.StringEditor]
   , ['SourceBranch', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(CalendarDetailForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

