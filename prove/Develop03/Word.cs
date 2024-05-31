public class Word {
    private string word;
    private bool hide;

    public Word (string w) {
        this.word = w;
        this.hide = false;
    }

    public string GetWord() {
        return word;
    }

    public void HideWord() {
        hide = true;
    }

    public void DisplayWord() {
        Console.WriteLine(word);
    }

    public bool GetHide() {
        return hide;
    }
}