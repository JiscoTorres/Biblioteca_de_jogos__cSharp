using LPR___JOAOFRANCISCO.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPR___JOAOFRANCISCO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Jogo> listaDeJogos = new List<Jogo>();
            Console.ForegroundColor = ConsoleColor.Magenta;

            while (true)
            {

                Console.WriteLine("=========BIBLIOTECA DE JOGOS=========");

                Console.WriteLine("1 - Adicionar Jogo");
                Console.WriteLine("2 - Listar Jogos");
                Console.WriteLine("3 - Editar Jogo");
                Console.WriteLine("4 - Remover Jogo");
                Console.Write("Opcao: ");

                bool resultado;
                String opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        resultado = AdicionarJogo(listaDeJogos);
                        if (resultado == true)
                        {
                            Console.WriteLine("Cadastrado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Erro no cadastro.");
                        }
                        break;

                    case "2":
                        resultado = ListarJogos(listaDeJogos);
                        if (resultado == true)
                        {
                            Console.WriteLine("Listado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Erro na listagem.");
                        }
                        break;

                    default:
                        Console.WriteLine("Opção Inválida!");
                        break;
                }

                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadLine();
                Console.Clear();
            }
        }

        public static bool AdicionarJogo(List<Jogo> listaDejogos)
        {
            Console.Clear();

            Console.Write("Titulo: ");
            String titulo = Console.ReadLine();

            Console.Write("Ano: ");
            int ano = Convert.ToInt32(Console.ReadLine());

            
            Console.Write("Gênero do jogo: ");
            String genero = Console.ReadLine();

            Console.Write("Máximo de jogadores: ");
            int maxJogadores = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nota no MetaCritic: ");
            int metacritic = Convert.ToInt32(Console.ReadLine());


            if (titulo == "") return false;

            if (ano < 1950) return false;

            if (maxJogadores > 100) return false;

            if (metacritic > 10 || metacritic < 0) return false;

            Jogo novoJogo = new Jogo(titulo, ano, genero, maxJogadores, metacritic);

            listaDejogos.Add(novoJogo);
            Console.Beep();

            return true;
        }

        public static bool ListarJogos(List<Jogo> listaJogos)
        {
            foreach (Jogo jogo in listaJogos)
            {
                Console.Write("Titulo: ");
                Console.WriteLine(jogo.getTitulo());

                Console.Write("Ano: ");
                Console.WriteLine(jogo.getAno());

                Console.Write("Gênero: ");
                Console.WriteLine(jogo.getGenero());

                Console.Write("Número máximo de jogadores: ");
                Console.WriteLine(jogo.getMaxJogadores());

                Console.Write("Nota no MetaCritic: ");
                Console.WriteLine(jogo.getMetaCritic());

                Console.WriteLine("==========");
                Console.WriteLine("");
            }

            return true;
        }


            public static bool EditarJogos(List<Jogo> listaJogos)
            {
                Console.Clear();
                Console.Write("Informe o jogo para ser editado: ");
                String InformarTitulo = Console.ReadLine();
                
              foreach (Jogo jogo in listaJogos)
                {
                
                if(InformarTitulo == jogo.getTitulo())
                {
                    Console.Clear();
                    Console.Write("EDIT - TÍTULO: ");
                    String TITULOEDITADO = Console.ReadLine();
                    jogo.titulo = TITULOEDITADO;

                    Console.Write("EDIT - ANO DE LANÇAMENTO: ");
                    int ANOEDITADO = Convert.ToInt32(Console.ReadLine());
                    jogo.ano = ANOEDITADO;

                    Console.Write("EDIT - GENERO DO JOGO: ");
                    String GENEROEDITADO = Console.ReadLine();
                    jogo.setgenero = GENEROEDITADO;

                    Console.Write("EDIT - NÚMERO MÁXIMO DE JOGADORES: ");
                    int MAXIMOJOGADORESEDITADO = Convert.ToInt32(Console.ReadLine());
                    jogo.setmaxJogadores = MAXIMOJOGADORESEDITADO;

                    Console.Write("EDIT - NOTA NO METACRITIC: ");
                    int METACRITICEDITADO = Convert.ToInt32(Console.ReadLine());
                    jogo.setmetacritic = METACRITICEDITADO;
                }
            }

            return true;

         }


        public static bool DeletarJogo(List<Jogo> listaDeJogos)
        {
                    Console.Clear();
                    Console.Write("Digite o título do jogo a ser deletado: ");
                    String jogoDeletar = Console.ReadLine();

            foreach (Jogo jogo in listaDeJogos)
            {
                    if (jogo.getTitulo() == jogoDeletar)
                    {
                    listaDeJogos.Remove(jogo);
                    Console.Clear();
                    break;
                    }
            }
            return true;
        }
    }
}