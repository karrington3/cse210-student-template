using System.Dynamic;

public class Entry {

    private string _response;
    private string _prompt;
    private string _date;

    public Entry() {
        this._date = DateTime.Now.ToString();
    }

    public Entry(string resp, string prompt) {
        this._date = DateTime.Now.ToString();
        this._response = resp;
        this._prompt = prompt;
    }

    //this Constructor should only be used by Journal.cs
    public Entry(string date, string prompt, string resp) {
        this._date = date;
        this._prompt = prompt;
        this._response = resp;
    }

    public void DisplayEntry() {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}\nResponse: {_response}\n");
    }

    public string GetResponse() {
        return _response;
    }

    public void SetResponse(string Response) {
        this._response = Response;
    }

    public string GetDate() {
        return _date;
    }

    public string GetPrompt() {
        return _prompt;
    }

    public string GeneratePrompt(List<string> prompt) {
        Random rng = new Random();
        int chosenPrompt = rng.Next(0, prompt.Count);
        this._prompt = prompt[chosenPrompt];
        Console.WriteLine(prompt[chosenPrompt]);
        return prompt[chosenPrompt];
    }

}