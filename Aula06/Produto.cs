namespace Aula06;

public class Produto : IProduto
{

    public string cod {get;protected set;}
    public int qtdMinima {get;protected set;}
    public int qtdEstoque {get;protected set;}
    public int aComprar {get; protected set;}
    public decimal valorComprar {get; protected set;}
    public decimal valor {get;protected set;}

    public Produto(string codigo, int quantMin, int quantEstoque, decimal val){
        cod=codigo;
        qtdMinima=quantMin;
        qtdEstoque=quantEstoque;
        valor=val;
    }
    
    public Produto(){

    }

    public virtual void calcularEstoque(){
        if (qtdMinima>qtdEstoque){
            aComprar = qtdMinima - qtdEstoque;
            valorComprar= aComprar * valor;
        }
    }

}