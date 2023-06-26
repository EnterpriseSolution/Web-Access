/// <reference path="../Helpers/LanguageList.ts" />
/// <reference path="../Common/UserPreference/UserPreferenceStorage.ts" />

namespace Matrix.ScriptInitialization {
    Q.Config.responsiveDialogs = true;
    Q.Config.rootNamespaces.push('Matrix');
    Serenity.EntityDialog.defaultLanguageList = LanguageList.getValue;
    Serenity.DataGrid.defaultPersistanceStorage = new Common.UserPreferenceStorage();


    //type PrimitiveArray = Array<string | number | boolean>;
    //type MyNumber = number;
    ////type NgScope = ng.IScope;
    //type Callback = () => void;
}