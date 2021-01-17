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
        TranslationWasChanged,
        TranslationWasNotChanged,

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
        ChangeTranslate,

        ShowMenu,
    }


        /*WasAdded,
        WasFounded,
        WasRemoved,
        WasNotAdded,
        WasNotFounded,
        WasNotRemoved,*/

    /*
     public enum ActionMenu1
    {
        createNewDict,
        openDict
    }

    public enum ActionMenu2
    {
        addNewWord,
        findWord,
        removeWord
    }

    public enum ActionMenu3
    {
        addTranslate,
        removeTranslate
    }*/
}
