using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2Nº6322516
{
    internal class Entrada
    {
        double valor;
        string poltrona;
        int ano;
        int mes;
        int dia;
        string hora;

        public void SetValor(double valor)
        {
            this.valor = valor;
        }
        public double GetValor()
        {
            return this.valor;
        }
        public void SetPoltrona(string poltrona)
        {
            this.poltrona = poltrona;
        }
        public string GetPoltrona()
        {
            return this.poltrona;
        }
        public void SetAno(int ano)
        {
            this.ano = ano;
        }
        public int GetAno()
        {
            return this.ano;
        }
        public void SetMes(int mes)
        {
            this.mes = mes;
        }
        public int GetMes()
        {
            return this.mes;
        }
        public void SetDia(int dia)
        {
            this.dia = dia;
        }
        public int GetDia()
        {
            return this.dia;
        }
        public void SetHora(string hora)
        {
            this.hora = hora;
        }
        public string GetHora()
        {
            return this.hora;
        }
    }
}
