using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPR___JOAOFRANCISCO
{
    internal class Jogo //Jogo é a classe
    {
        //ATRIBUTOS
        String titulo;
        int ano;
        String genero;
        int maxJogadores;
        int metacritic;

        //CONSTRUTORES
        public Jogo(String titulo, int ano, String genero,
                    int maxJogadores, int metacritic)
        {
            this.titulo = titulo;
            this.ano = ano;
            this.genero = genero;
            this.maxJogadores = maxJogadores;
            this.metacritic = metacritic;
        }

        public Jogo(String titulo, int ano, String genero,
                    int maxJogadores)
        {
            this.titulo = titulo;
            this.ano = ano;
            this.genero = genero;
            this.maxJogadores = maxJogadores;
        }

        //METODOS DE ACESSO
        //GETTER - RETORNA VALOR DO ATRIBUTO
        public String getTitulo()
        {
            return this.titulo;
        }

        //SETTER - MODIFICA VALOR DO ATRIBUTO
        public void setTitulo(String titulo) //Passar título como parametro
        {
            if (titulo != "")
                this.titulo = titulo;
        }

        public int getAno()
        {
            return this.ano;
        }

        public int getGenero()
        {
            return this.genero;
        }

        public int getMaxJogadores()
        {
            return this.maxJogadores;
        }

        public int getMetaCritic()
        {
            return this.metacritic;
        }

    }
}