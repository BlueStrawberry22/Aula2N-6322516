using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2Nº6322516
{
    internal class Filme
    {
        //declaração dos atributos
        string titulo;
        string sinopse;
        string genero;
        int classificacao;

        //getters e setters
        public void SetTitulo(string titulo)
        {
            this.titulo = titulo;
        }
        public string GetTitulo()
        {
            return this.titulo;
        }
        public void SetSinopse(string sinopse)
        {
            this.sinopse = sinopse;
        }
        public string GetSinopse()
        {
            return this.sinopse;
        }
        public void SetGenero(string genero)
        {
            this.genero = genero;
        }
        public string GetGenero()
        {
            return this.genero;
        }
        public void SetClassificacao(int classificacao)
        {
            this.classificacao = classificacao;
        }
        public int GetClassificacao()
        {
            return this.classificacao;
        }
    }
}
