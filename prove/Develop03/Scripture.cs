using System;

class Scripture {

  private Reference _reference;
  private List<Word> _words;



  public Scripture(string scripture, Reference reference){
    this._reference = reference;
    string[] words = scripture.Split(" ");
    List<Word> totalWords = new List<Word>();
    foreach (string word in words){
        Word w = new Word(word);
        totalWords.Add(w);
    }
    this._words = totalWords;
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
    Word w = this._words[rInt];
    if (!(w.IsHidden())){
        w.HideWord();
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
