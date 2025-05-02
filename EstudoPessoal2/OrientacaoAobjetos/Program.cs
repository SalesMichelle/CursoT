// Questão 1 Trybe    

    using System;
    using System.Collections.Generic;
    
// - Etapa 1: Crie uma classe base Pessoa

    public class Pessoa
    {
        public string Nome{get; set;}
        public string Email{get; set;}
        public Pessoa(string nome, string email)  // Construtor: garante que um objeto seja inicializado corretamente no momento da sua criação.
        {
            Nome = nome;
            Email = email;
        }

        // Seria melhor abstract ou virtual?
        public virtual void ExibirInfo()         // Permite que outras classes que herdam de Pessoa possam sobrescrever o método ExibirInfo().
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Email: {Email}");
        }
    }

// Etapa 2 e 3: Crie uma classe Usuario que herda de Pessoa (obs: usar override para sobrescrever) e encapsular

    public class Usuario : Pessoa
    {
        public string UserName{get; set;}
        private string senha{get; set;}
        public Usuario(string nome, string email, string userName, string senhaInicial) : base (nome, email) // Chamamos a base porque ela está herdando esses parâmetros da classe Pessoa
        {
            UserName = userName;
            senha = senhaInicial;     
        }

        public override void ExibirInfo() // Serve para sobrescrever o comportamento original (ou implementá-lo, no caso de abstract).
        {
            base.ExibirInfo();                           // Qual a função dessa linha?
            Console.WriteLine($"Username: {UserName}"); // Qual a função dessa linha?
        }
        public void SetSenha(string novaSenha)
        {
            senha = novaSenha;
        }
            // public bool VerificarSenha(string tentativa)
            // {
            //   return senha == tentativa;                  // Como funciona esse return nessa parte?
            //}
    }

    // Etapa 4: Crie a classe Administrador, que herda de Usuario
            // Atributo adicional:
                // NivelDeAcesso (int)
            //Reescreva ExibirInfo() para incluir o nível de acesso.

        public class Administrador : Usuario
        {
            public int NiveldeAcesso{get ; set;}
            
            public Administrador(string nome, string email, string userName, string senhaInicial, int nivelDeAcesso)
            : base(nome, email, userName, senhaInicial)
            {
                NiveldeAcesso = nivelDeAcesso;          
            }

            public override void ExibirInfo()   // aproveita o método da classe Usuario, e adiciona apenas o que é exclusivo do Administrador, sem repetir tudo.
            {
                base.ExibirInfo();
                Console.WriteLine($"Nível de Acesso: {NiveldeAcesso}");
            }
        }

    // Etapa 5: No Main() - Inicializar o programa de fato
        // Crie uma lista de usuários (List<Usuario>) contendo objetos Usuario e Administrador.
        //Percorra a lista e chame ExibirInfo() para cada um — explore o polimorfismo.

        class Program
        {
            static void Main()
            {
                List<Usuario> usuariosnaLista = new List<Usuario>(); // Essa é nossa lista de usuários

                Usuario u1 = new Usuario("Michelle", "michelle.santos@mottu.com.br", "Michelle.Santos", "Mi123"); // Usuário comum
                usuariosnaLista.Add(u1); // Adicionando esse usuário na lista

                Administrador amdin1 = new Administrador("Luan", "Luan.Oliveira@mottu.com.br", "Luan.Oliveira" , "Luan123", 3); // Usuário plus
                usuariosnaLista.Add(amdin1);

                // Percorre todos os objetos na lista usuariosnalista. 
                // Para cada usuario, o método ExibirInfo() é chamado. Isso exibe as informações de cada usuário. 
                foreach (var usuario in usuariosnaLista)
                {
                    usuario.ExibirInfo();
                    Console.WriteLine("----------------------");
                }
            }
        }