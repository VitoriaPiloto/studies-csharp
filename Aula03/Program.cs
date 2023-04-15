namespace Aula3{

    class Programa{
        static void Main(string[] args){
            string escolha;
            System.Console.WriteLine("Escolha o programa que deseja executar: ");
            System.Console.WriteLine("CADASTRO CLIENTES        |   [clientes]");
            System.Console.WriteLine("CADASTRO PRODUTOS        |   [produtos]");
            System.Console.WriteLine("CADASTRO CONTA CORRENTE  |   [conta]");
            escolha = System.Console.ReadLine();

            switch(escolha){
                case "clientes":
                    Cliente cliente = new Cliente(50);
                    System.Console.WriteLine("-----Cliente 1----");
                    cliente.atribuiNome();
                    cliente.atribuiCpf();
                    cliente.imprimeDados();
                    verificaCredito(cliente);
                    // Cliente 2 - Recebe dados diretamente do construtor
                    Cliente cliente2 = new Cliente("Claudia", "272-08", 0);
                    cliente2.imprimeDados();
                    verificaCredito(cliente2);
                    break;

                case "produtos":
                    string continua="sim";
                    int qtdProdutos=1;
                    do{                        
                        System.Console.WriteLine("---- Produto " + qtdProdutos + "----");
                        Produto p = new Produto();
                        /*
                        System.Console.WriteLine("ID: " + p.Id);
                        System.Console.WriteLine("Nome: " + p.Nome);
                        System.Console.WriteLine("Valor: "+ p.Valor);
                        */

                        System.Console.WriteLine("Inisra o nome do produto: ");
                        string nome = System.Console.ReadLine();
                        p.Nome= nome;

                        System.Console.WriteLine("Insira o código do produto: ");
                        int cod = int.Parse(System.Console.ReadLine());
                        p.Id = cod;

                        System.Console.WriteLine("Insira a quantidade em estoque: ");
                        int qtdE = int.Parse(System.Console.ReadLine());
                        p.QtdEstoque = qtdE;
                        
                        System.Console.WriteLine("Insira a quantidade minima em estoque necessária: ");
                        int qtdM = int.Parse(System.Console.ReadLine());
                        p.QtdMinima = qtdM;

                        System.Console.WriteLine("Insira o valor unitário do produto: ");
                        double valor = double.Parse(System.Console.ReadLine());
                        p.Valor = valor;

                        qtdProdutos++;

                        //Exibição do produto
                        System.Console.WriteLine("--------");
                        System.Console.WriteLine("Nome: " + p.Nome + "| ID: " + p.Id);
                        System.Console.WriteLine("Quantidade em estoque: " + p.QtdEstoque);
                        p.verificaEstoque(qtdM,qtdE);


                        System.Console.WriteLine("Deseja continuar? [sim/nao]");
                        continua = System.Console.ReadLine();
                    }  while(continua == "sim");
                    System.Console.WriteLine("A quantidade de produtos cadastrados foi: " + qtdProdutos);
                    break;

                case "conta":
                    ContaCorrente c1 = new ContaCorrente("0001");
                    c1.depositar(100);

                    ContaCorrente c2 = new ContaCorrente("0002");
                    c2.depositar(500);
                    c1.transferir(c2, 50);

                    System.Console.WriteLine("Saldo Conta 1: " + c1._saldo);
                    System.Console.WriteLine("Saldo Conta 2: " + c2._saldo);
                    break;
            }
            
        }

        static void verificaCredito(Cliente cliente){
            if(cliente.temCredito()){
                System.Console.WriteLine("Tem credito!!");
            } else {
                System.Console.WriteLine("Não tem credito!!");
            }
        }
    }

    public class Cliente{
        string nome;
        string cpf;
        decimal credito;

        public void atribuiNome(){
            System.Console.WriteLine("Insira o nome: ");
            nome = System.Console.ReadLine();
        }

        public void atribuiCpf(){
            System.Console.WriteLine("Insira o cpf: ");
            cpf = System.Console.ReadLine();
        }

        public void imprimeDados(){
            System.Console.WriteLine("------------");
            System.Console.WriteLine("Nome: "+nome);
            System.Console.WriteLine("CPF: "+cpf);
        }

        //Construtores 

        public Cliente(decimal c) //Construtor --- atalho ctor ---
        {
            credito=c;
        }

        public Cliente(string n, string cp, decimal cr) //Construtor --- atalho ctor ---
        {
            nome=n;
            cpf=cp;
            credito=cr;
        }

        public bool temCredito(){
            return credito > 0;
        }

        public void aumentaCredito(decimal c){
            credito=c;
        }

    }

    public class Produto{
        /*
            Segundo um dos padrões, o nome das variáveis privadas devem ter um underline na frente
            Exemplo: _id, _qtdMin, _qtdEstoque, ...
        */
        int id ; 
        int qtdMin;
        int qtdEstoque;
        string nome;
        public double valor;

        /*
            Atalho para construir os gets e sets direto: propfull
        */

        // OBS: variável publica é com letra maiuscula
        public double Valor {
            get{
                return valor;
            } 
            set{
                valor = value;
            }
        }
        //assim gera os métodos automáticos por baixo dos panos (syntax sugar) <3

        public int Id{
            get{
                return id;
            }
            set{
                id = value;
            }
        }

        public int QtdMinima { get; set; }

        public int QtdEstoque{
            get{
                return qtdEstoque;
            }
            set{
                //O value referencia o que chega ao valor que chega a variavel
                qtdEstoque = value;
            }
        }

        public string Nome{
            get{
                return nome;
            }
            set{
                nome = value;
            }
        }

        //Construtor
        public Produto(int i, int qe, string n, double v){
            nome=n;
            id=i;
            qtdEstoque=qe;
            Valor=v;
        }

        public Produto(){

        }

        public void verificaEstoque(int qtdMin, int qtdEstoque){
            if(qtdEstoque < qtdMin){
                double pagar = calculaCompra(qtdMin,qtdEstoque,valor);
                System.Console.WriteLine("É necessário pagar: " + pagar);
            } else {
                System.Console.WriteLine("Não é necessário preencher o estoque");
            }
        }

        private double calculaCompra(int qtdMin, int qtdEstoque, double valorUnitario){
            int comprar = qtdMin - qtdEstoque;
            System.Console.WriteLine("É necessário comprar: " + comprar);
            double pagar = comprar * valorUnitario;
            return pagar;
        }
    }

    public class ContaCorrente{
        string _numero {get; set;}
        public double _saldo;

        public ContaCorrente(string numero){
            _numero = numero;
            _saldo = 0;
        }

        public void depositar(double valor){
            //_saldo = _saldo + valor;
            _saldo += valor;
        }

        public void transferir(ContaCorrente contaDestino, double valor){
            if (_saldo - valor > 0){
                contaDestino.depositar(valor);
                //saldo = saldo - valor;
                _saldo -= valor;
            }
        }
    }
}