public class Reference
{
    private List<string> scripture;

    private string scriptureReference;
    private string fileaddress;

    public Reference(string scriptureReference,string fileaddress){
        fileaddress ="scripture.txt";
        scriptureReference = scriptureReference;
    }

    public void printscripture(){
        Console.WriteLine(scriptureReference);
    }
}