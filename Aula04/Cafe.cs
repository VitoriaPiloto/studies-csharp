namespace Aula04;

public class Cafe : Bebida{
    public string Grao {get;set;}
    public override string Preparar()
    {
        return "cafeteira";
    }
}