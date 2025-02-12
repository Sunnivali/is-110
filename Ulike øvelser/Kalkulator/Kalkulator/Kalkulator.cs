//  her brukte vi automatiske egenskaper

public class Kalkulator {
    public double Nummer1 {set; get;}

    public double Nummer2 {set; get;}

    public double Resultat {set; get;}

    public Kalkulator (){

    }

    public double CalcAddition(double nummer1, double nummer2){
        Nummer1 = nummer1;
        Nummer2 = nummer2;
        Resultat = Nummer1 + Nummer2;
        return Resultat;
    }
}