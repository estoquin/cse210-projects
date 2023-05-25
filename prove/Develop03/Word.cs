using System;

class Word {


    private string _word;
    private bool _hidden;


    public Word(string word) {
        this._word = word;
        this._hidden = false;
    }

    public void HideWord(){
        if (this._hidden == false) {
            Console.WriteLine("(Hidding Word)");
            int wordLength = this._word.Length;
            string hiddedWord = "";
            for (int i=0; i<wordLength; i++){
                hiddedWord = $"{hiddedWord}_";
            }
            this._hidden = true;
            this._word = hiddedWord;
        }
    }

    public bool IsHidden(){
        return this._hidden;
    }

    public string GetWord(){
        return this._word;
    }
}