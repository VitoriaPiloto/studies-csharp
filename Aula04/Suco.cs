namespace Aula04;
public class Suco:Bebida{
    public string fruta {get;set;}
    public override string Preparar()
    {
        return "suqueira";
    }
}