using System;

class Scripture {

  private Reference _reference;
  private List<Word> _words;
  private List<int> _hidden;



  public Scripture(string scripture, Reference reference){
    this._reference = reference;
    string[] words = scripture.Split(" ");
    List<Word> totalWords = new List<Word>();
    foreach (string word in words){
        Word w = new Word(word);
        totalWords.Add(w);
    }
    this._words = totalWords;
    List<int> hidden = new List<int>(){-1};
    this._hidden = hidden;
  }

  public void DisplayScripture(){
    string reference = this._reference.GetReference();
    List<string> words = new List<string>();
    foreach (Word w in this._words){
        words.Add(w.GetWord());
    }
    string scripture = String.Join(" ", words);
    Console.WriteLine($"{reference}: \"{scripture}\"");
  }

  public void HideRandomWord(){
    int listSize = this._words.Count;
    Random r = new Random();
    int rInt = r.Next(0, listSize);
    while(this._hidden.Contains(rInt)){
        rInt = r.Next(0, listSize);
    }
    Word w = this._words[rInt];
    if (!(w.IsHidden())){
        w.HideWord();
        this._hidden.Add(rInt);
        this._words[rInt] = w;
    }
    }

    public bool AllHidden(){
        bool allHidden = true;
        foreach (Word w in this._words) {
            if (!(w.IsHidden())){
                allHidden = w.IsHidden();
                break;
            }
        }
        return allHidden;
    }
}
