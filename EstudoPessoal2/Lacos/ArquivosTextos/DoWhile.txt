// Exercício: Continuar perguntando até o usuário digitar "sair"

using System ;

class dowhile
{
    static void Main(string[] args)
    {
        string texto; // essa variável será o que o usuário digitar

        do
        {
            Console.WriteLine("Digite algo, para encerrar, digite 'sair");
            texto = Console.ReadLine() ;
        } while(texto != "sair") ; // Condição para que o programa continue

        Console.WriteLine("Fim") ;
    }
}

