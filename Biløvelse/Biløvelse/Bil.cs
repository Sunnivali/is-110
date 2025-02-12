public class Bil {
    // instansvariabler
    private string merke;
    private string modell;
    private string år;

    // Kunne og berre skreve den under, 
    // uten å skrive privat string osv.
    // public string Merke {set; get;}

    // konstruktør
    public Bil(){

    }
    // set/get metoder til Merke
    public void SetMerke(string bilMerke){
        merke = bilMerke;
    }

    // set/get metoder til Modell
    public void SetModell(string bilModell){
        modell = bilModell;
    }

    public void SetÅr(string bilÅr){
        år = bilÅr;
    }

    public string GetMerke(){
        return merke;
    }

    public string GetModell(){
        return modell;
    }

    public string GetÅr(){
        return år;
    }
}
