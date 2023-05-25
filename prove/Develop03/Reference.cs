using System;

class Reference
{

    private string _book;
    private int _chapter;
    private int _verseStart;
    private int _verseEnd;

    public Reference(string book, int chapter, int verseStart)
    {
        this._book = book;
        this._chapter = chapter;
        this._verseStart = verseStart;
    }

    public Reference(string book, int chapter, int verseStart, int verseEnd)
    {
        this._book = book;
        this._chapter = chapter;
        this._verseStart = verseStart;
        this._verseEnd = verseEnd;
    }

    public string GetReference(){
        string myReference = $"{this._book} {this._chapter}: {this._verseStart}";
        if (this._verseEnd != 0)
        {
            myReference = $"{myReference}-{this._verseEnd}";
        }
        return myReference;
    }
}