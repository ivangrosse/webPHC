/// <reference path="../Common/Helpers/LanguageList.ts" />

namespace RodeoBigSalesManagement.ScriptInitialization {
    Q.Config.responsiveDialogs = true;
    Q.Config.rootNamespaces.push('RodeoBigSalesManagement');
    Serenity.EntityDialog.defaultLanguageList = LanguageList.getValue;
}