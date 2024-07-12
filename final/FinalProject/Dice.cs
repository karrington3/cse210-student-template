using System.Collections;

public class Dice {

    Random rng;

    public Dice() {
        rng = new Random();
    }

    public int DiceManager(string hitType) {
        switch(hitType)
        {
            case "D20":
                return rollD20();
            case "D12":
                return rollD12();
            case "D10":
                return rollD10();
            case "D8":
                return rollD8();
            case "D6":
                return rollD6();
            default:
                return 0;
        }
    }

    public int rollD20() {
        return rng.Next(1,20);
    }

    public int rollD12() {
        return rng.Next(1,12);
    }

    public int rollD10() {
        return rng.Next(1,10);
    }

    public int rollD8() {
        return rng.Next(1,8);
    }

    public int rollD6() {
        return rng.Next(1,6);
    }
}