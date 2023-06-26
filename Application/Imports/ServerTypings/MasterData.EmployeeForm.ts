namespace Matrix.MasterData {
    export class EmployeeForm extends Serenity.PrefixedContext {
        static formKey = 'MasterData.Employee';

    }

    export interface EmployeeForm {
        EmployeeNo: Serenity.StringEditor;
        Suspended: Serenity.StringEditor;
        ChineseName: Serenity.StringEditor;
        EnglishName: Serenity.StringEditor;
        PinyinName: Serenity.StringEditor;
        Id: Serenity.StringEditor;
        Birthday: Serenity.DateEditor;
        Gender: Serenity.StringEditor;
        Marital: Serenity.StringEditor;
        Nationality: Serenity.StringEditor;
        Province: Serenity.StringEditor;
        City: Serenity.StringEditor;
        Homephone: Serenity.StringEditor;
        Mobile: Serenity.StringEditor;
        Email: Serenity.StringEditor;
        BusinessPhone: Serenity.StringEditor;
        BusinessEmail: Serenity.StringEditor;
        Portrait: Serenity.StringEditor;
        HireType: Serenity.StringEditor;
        HireDate: Serenity.DateEditor;
        HireValid: Serenity.DateEditor;
        HireSociety: Serenity.DateEditor;
        HireSource: Serenity.StringEditor;
        Department: Serenity.StringEditor;
        ShiftNo: Serenity.StringEditor;
        ContractType: Serenity.StringEditor;
        ContractStartDate: Serenity.DateEditor;
        ContractEndDate: Serenity.DateEditor;
        ContractNumber: Serenity.StringEditor;
        ContractLocation: Serenity.StringEditor;
        Disablity: Serenity.StringEditor;
        DisablityDescription: Serenity.StringEditor;
        Height: Serenity.StringEditor;
        Weight: Serenity.StringEditor;
        EyeRight: Serenity.StringEditor;
        EyeLeft: Serenity.StringEditor;
        EyeColor: Serenity.StringEditor;
        ShoeSize: Serenity.StringEditor;
        ClothSize: Serenity.StringEditor;
        BloodType: Serenity.StringEditor;
        QuitDate: Serenity.DateEditor;
        QuitNoticeDate: Serenity.DateEditor;
        QuitLeaveDate: Serenity.DateEditor;
        QuitType: Serenity.StringEditor;
        QuitReason: Serenity.StringEditor;
        BadgeNo: Serenity.StringEditor;
        Formula: Serenity.StringEditor;
        WorkCentre: Serenity.StringEditor;
    }

    [['EmployeeNo', () => Serenity.StringEditor]
   , ['Suspended', () => Serenity.StringEditor]
   , ['ChineseName', () => Serenity.StringEditor]
   , ['EnglishName', () => Serenity.StringEditor]
   , ['PinyinName', () => Serenity.StringEditor]
   , ['Id', () => Serenity.StringEditor]
   , ['Birthday', () => Serenity.DateEditor]
   , ['Gender', () => Serenity.StringEditor]
   , ['Marital', () => Serenity.StringEditor]
   , ['Nationality', () => Serenity.StringEditor]
   , ['Province', () => Serenity.StringEditor]
   , ['City', () => Serenity.StringEditor]
   , ['Homephone', () => Serenity.StringEditor]
   , ['Mobile', () => Serenity.StringEditor]
   , ['Email', () => Serenity.StringEditor]
   , ['BusinessPhone', () => Serenity.StringEditor]
   , ['BusinessEmail', () => Serenity.StringEditor]
   , ['Portrait', () => Serenity.StringEditor]
   , ['HireType', () => Serenity.StringEditor]
   , ['HireDate', () => Serenity.DateEditor]
   , ['HireValid', () => Serenity.DateEditor]
   , ['HireSociety', () => Serenity.DateEditor]
   , ['HireSource', () => Serenity.StringEditor]
   , ['Department', () => Serenity.StringEditor]
   , ['ShiftNo', () => Serenity.StringEditor]
   , ['ContractType', () => Serenity.StringEditor]
   , ['ContractStartDate', () => Serenity.DateEditor]
   , ['ContractEndDate', () => Serenity.DateEditor]
   , ['ContractNumber', () => Serenity.StringEditor]
   , ['ContractLocation', () => Serenity.StringEditor]
   , ['Disablity', () => Serenity.StringEditor]
   , ['DisablityDescription', () => Serenity.StringEditor]
   , ['Height', () => Serenity.StringEditor]
   , ['Weight', () => Serenity.StringEditor]
   , ['EyeRight', () => Serenity.StringEditor]
   , ['EyeLeft', () => Serenity.StringEditor]
   , ['EyeColor', () => Serenity.StringEditor]
   , ['ShoeSize', () => Serenity.StringEditor]
   , ['ClothSize', () => Serenity.StringEditor]
   , ['BloodType', () => Serenity.StringEditor]
   , ['QuitDate', () => Serenity.DateEditor]
   , ['QuitNoticeDate', () => Serenity.DateEditor]
   , ['QuitLeaveDate', () => Serenity.DateEditor]
   , ['QuitType', () => Serenity.StringEditor]
   , ['QuitReason', () => Serenity.StringEditor]
   , ['BadgeNo', () => Serenity.StringEditor]
   , ['Formula', () => Serenity.StringEditor]
   , ['WorkCentre', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(EmployeeForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

