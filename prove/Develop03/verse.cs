public class Verse {
    Random rand = new Random();
    
    public string GetScripture(){
        using (StreamReader sr = new StreamReader("scripture.txt"))
        {
            string scripture = "";
            int lineNumber = GetRandom();
            for (int i = 1; i < lineNumber; i++)
            {
                scripture = sr.ReadLine();
            }
        }
        return scripture;
    }

    public int GetRandom() {
        int rng = rand.Next(1, 35);
        return rng;
    }

}