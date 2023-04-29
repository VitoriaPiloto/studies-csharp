namespace Aula05;

class Program{
    static void Main(string[] args)
    {
        string codigo = Console.ReadLine();
        int qtdEstoque = Convert.ToInt32(Console.ReadLine());
        int qtdMinima = Convert.ToInt32(Console.ReadLine());
        decimal valor = Convert.ToDecimal(Console.ReadLine());
        bool perecivel = Convert.ToBoolean(Console.ReadLine());
        DateTime dataVencimento;
        if (perecivel){
            dataVencimento = Convert.ToDateTime(Console.ReadLine());
            ProdutoPerecivel pp = new ProdutoPerecivel(codigo,qtdMinima,qtdEstoque,valor,dataVencimento);
            pp.calcularEstoque();
        } else { 
            ProdutoNaoPerecivel pnp = new ProdutoNaoPerecivel(codigo,qtdMinima,qtdEstoque,valor);
            pnp.calcularEstoque();
        }
    }
}