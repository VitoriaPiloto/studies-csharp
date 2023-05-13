namespace Aula06;

class Program{
    static void Main(string[] args)
    {
        //Produto[] produtos = new Produto[10];
        List<Produto> lista = new List<Produto>(); //() define capacity
        string continua = "S";
        //int totalProdutos =0;
        Produto p;
        do
        {
            string codigo = Console.ReadLine();
            int qtdEstoque = Convert.ToInt32(Console.ReadLine());
            int qtdMinima = Convert.ToInt32(Console.ReadLine());
            decimal valor = Convert.ToDecimal(Console.ReadLine());
            bool perecivel = Convert.ToBoolean(Console.ReadLine());
            DateTime dataVencimento;
            if (perecivel)
            {
                dataVencimento = Convert.ToDateTime(Console.ReadLine());
                ProdutoPerecivel pp = new ProdutoPerecivel(codigo, qtdMinima, qtdEstoque, valor, dataVencimento);
                //produtos[totalProdutos] = pp;
                p = pp;
            }
            else
            {
                ProdutoNaoPerecivel pnp = new ProdutoNaoPerecivel(codigo, qtdMinima, qtdEstoque, valor);
                //produtos[totalProdutos] = pnp;
                p = pnp;
            }

            lista.Add(p);

            //totalProdutos++;

            /*
             --- LISTA RESIZE AUTOMATICO ----
            if (totalProdutos > produtos.Length)
            {
                //ref = ponteiro
                Array.Resize(ref produtos, produtos.Length + 10);
            }
            */

            Console.WriteLine("Deseja continuar? S/N");
            continua = Console.ReadLine();
        } while (continua == 'S');

        foreach (Produto produto in lista)
        {
            produto.calcularEstoque();
            if (produto is ProdutoPerecivel)
            {
                //CASTING
                System.Console.WriteLine((produto as ProdutoPerecivel).vencimento); // CASO NÃO CONSIGA RETORNA NULL
                //CASTING EM C
                // System.Console.WriteLine(((ProdutoPerecivel)produto).vencimento); // CASO NÃO CONSIGA RETORNA EXCEPTION
            }
        }

        }
    }
}