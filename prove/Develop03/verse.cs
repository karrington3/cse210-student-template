public class Verse {
    Random rand = new Random();
    private List<Word> _scripture;
    private string _scripwords;

    public Verse() {
        _scripture = new List<Word>();

        GetScripture();

        string[] words = _scripwords.Split(" ");

        foreach (string word in words) {
            _scripture.Add(new Word(word));
            
        }
    }
    
    public string GetScripture(){
        using (StreamReader sr = new StreamReader("scripture.txt"))
        {
            string scripture = "";
            int lineNumber = GetRandom();
            for (int i = 1; i < lineNumber; i++)
            {
                scripture = sr.ReadLine();
            }
            _scripwords = scripture;
            return scripture;
        } 
    }

    public int GetRandom() {
        int rng = rand.Next(1, 35);
        return rng;
    }

    public void DisplayScripture() {
        foreach (Word word in _scripture) {
            Console.Write(word.GetWord()+' ');
        }
        Console.WriteLine(' ');
    
    }
    public void BlankRandomWords(int wordsToBlank)
        {
            int blankedWords = 0;
            while (blankedWords < wordsToBlank)
            {
                int index = rand.Next(_scripture.Count);
                if (!_scripture[index].GetHide())
                {
                    _scripture[index].HideWord();
                    blankedWords++;
                }
            }
        }




}