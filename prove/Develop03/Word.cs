public class Word {
    private string word;
    private bool hide;

    public Word (string w) {
        this.word = w;
        this.hide = false;
    }

    public string GetWord() {
        return returnword();
    }

    public void HideWord() {
        hide = true;
    }

    public string returnword() {
        
        return hide ? new String('_', word.Length) : word;
        
    }

    public bool GetHide() {
        return hide;
    }

//public override string ToString()
// {
//     if (isBlank)
//     {
//         string blankWord = "";
//         for (int unused = 0; unused < wordLen; unused++)
//         {
//             blankWord += "_";
//         }
//         return blankWord;
//     }
//     return this.word;

}