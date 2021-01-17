using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    public enum Act
    {
        ExceptionAction,

        WordWasAdded,
        WordWasFound,
        WordWasRemoved,
        WordWasNotAdded,
        WordWasNotFounded,
        WordWasNotFound,
        WordWasChanged,
        WordWasNotChanged,

        TranslateWasAdded,
        TranslateWasFound,
        TranslateWasRemoved,
        TranslateWasNotAdded,
        TranslateWasNotFound,
        TranslateWasNotRemoved,
        TranslationsWereFound,
        TranslationsWereNotFound,
        //TranslationWasChanged,
        //TranslationWasNotChanged,

        DictionaryWasCreated,
        DictionaryWasFounded,
        DictionaryWasRemoved,
        DictionaryWasNotCreated,
        DictionaryWasNotFounded,
        DictionaryWasNotRemoved,
        DictionatyWasSetByCurrentDict,
        DictionatyWasNotBeSettedByCurrentDict,

        CreateDictionary,
        AddNewWord,
        AddNewTranslation,
        ChangeWord,
        ChangeTranslation,
        RemoveWord,
        RemoveTranslation,
        SearchTranslations,

        SmthWentWrong,
        Done,
    }
}
