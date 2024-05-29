public class Person{

    public string givenName ="";

    public string familyName="";


public void ShowEasternName(){
    Console.WriteLine($"{familyName}, {givenName}");
}
public void ShowWesternName()
    {
        Console.WriteLine($"{givenName} {familyName}");
    }

}
