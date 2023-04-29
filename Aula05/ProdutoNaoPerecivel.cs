namespace Aula05;

public class ProdutoNaoPerecivel : Produto{

    public ProdutoNaoPerecivel(string codigo, int quantMin, int quantEstoque, decimal val)
        :base(codigo,quantMin,quantEstoque,val)
    {
    }
}