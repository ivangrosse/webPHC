/// <reference path="../Common/Helpers/LanguageList.ts" />

namespace MusicShop.ScriptInitialization {
    Q.Config.responsiveDialogs = true;
    Q.Config.rootNamespaces.push('MusicShop');
    Serenity.EntityDialog.defaultLanguageList = LanguageList.getValue;
}