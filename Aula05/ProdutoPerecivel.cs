namespace Aula05;

public class ProdutoPerecivel : Produto {
    public DateTime vencimento {get;set;}

    public ProdutoPerecivel(string codigo, int quantMin, int quantEstoque, decimal val, DateTime dataVen)
        : base(codigo,quantMin,quantEstoque,val) //Puxa os dados do pai por meio de sobrecarga
    {
        vencimento = dataVen;
    }
    public override void calcularEstoque()
    {
        if (vencimento < DateTime.Now.Date){
            aComprar = qtdMinima;
            valorComprar = aComprar * valor;
        } else{
            base.calcularEstoque();
        }
    }
}