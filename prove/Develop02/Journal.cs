public class Journal {
    public List<Entry> entries;

    public Journal() {
        this.entries = new List<Entry>();
    }

    public Journal(Entry usrEntry) {
        this.entries = new List<Entry>();
        entries.Add(usrEntry);
    }

    public void AddEntry(Entry usrEntry) {
        entries.Add(usrEntry);
    }

    public void SaveJournal(string name) {
        using (StreamWriter outFile = new StreamWriter(name)) {
            
            foreach (Entry e in entries) {
                outFile.WriteLine($"{e.GetDate()}|{e.GetPrompt()}|{e.GetResponse()}");
            }

        }
    }

    public void LoadJournal(string fileName) {

        Console.WriteLine("Journal...");

    

    string[] lines = System.IO.File.ReadAllLines($"{fileName}");

        foreach (string line in lines) {
            string[] parts = line.Split("|");

            Entry newEntry = new Entry(parts[0], parts[1], parts[2]);
            entries.Add(newEntry);
        }

        Console.WriteLine("Complete!");
    }

    public void DisplayJournal() {
        foreach (Entry ent in entries) {
            ent.DisplayEntry();
        }
    }


}