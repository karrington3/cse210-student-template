using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

public class Prompts {

    public List<string> prompt;

    public Prompts(string filePath) {
        var inFile = File.ReadAllLines(filePath);
        this.prompt = new List<string>(inFile);
    }

    public List<string> getPromptList() {
        return prompt;
    }

    public void displayPrompts() {
        foreach(string prom in prompt) {
            Console.WriteLine(prom);
        }
    }

}