namespace Aula02{
   class MediaAlunos {
    static void Main(string[] args){
        string situacao;
        int qtdAlunos=0;
        decimal media=0;
        decimal somatorio=0;
        int i=0;
        Console.WriteLine("Insira a quantidade de alunos na turma: ");
        qtdAlunos = Convert.ToInt32(System.Console.ReadLine());
        while(i<qtdAlunos){
            Console.WriteLine("\nInsira o nome do aluno: ");
            string nome = System.Console.ReadLine();
            Console.WriteLine("Insira a nota 1: ");
            decimal nota1 = Convert.ToDecimal(System.Console.ReadLine());
            Console.WriteLine("Insira a nota 2: ");
            decimal nota2 = Convert.ToDecimal(System.Console.ReadLine());
            somatorio = nota1 + nota2;
            media = somatorio/2;
            if (media>=6){
                situacao = "Aprovado";
            } else {
                situacao = "Reprovado";
            }
            Console.WriteLine("Aluno: " + nome + "\nNota 1: " + nota1 + "\nNota 2: " + nota2 + "\nMedia: " + media + "\nSituação: " + situacao);
            i++;
        }
    }
   }
}