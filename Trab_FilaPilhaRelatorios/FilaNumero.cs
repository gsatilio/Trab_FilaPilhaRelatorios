using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trab_FilaPilhaRelatorios
{
    internal class FilaNumero
    {
        Numero? inicio;
        Numero? fim;

        public FilaNumero()
        {
            this.inicio = null;
            this.fim = null;
        }
        public void push(Numero aux)
        {
            if (vazia())
            {
                this.inicio = this.fim = aux;
            }
            else
            {
                this.fim.setProximo(aux);
                this.fim = aux;
            }
        }
        internal bool vazia()
        {
            return inicio == null && fim == null;
        }
        public int pop()
        {
            int valor = 0;
            if (!vazia())
            {
                if (fim == inicio) // se cabeca = cauda entao so tem 1 elemento na fila
                {
                    valor = this.inicio.getNumero();
                    inicio = fim = null;
                }
                else
                {
                    valor = this.inicio.getNumero();
                    this.inicio = this.inicio.getProximo();
                }
            }
            return valor;
        }
        public int getContador()
        {
            int contador = 0;
            Numero aux = inicio;
            if (!vazia())
            {
                do
                {
                    contador++;
                    aux = aux.getProximo();
                } while (aux != null);
            }
            return contador;
        }
        public int getValores(int posicao)
        {
            Numero aux = inicio;
            int valor = 0, contador = 0;
            if (!vazia())
            {
                valor = aux.getNumero();
                do
                {
                    contador++;
                    aux = aux.getProximo();
                    if (aux != null && posicao > 0)
                    {
                        valor = aux.getNumero();
                    }
                } while (aux != null && contador < posicao);
            }
            return valor;
        }
        public string print()
        {
            Numero aux = inicio;
            string texto = "";
            if (!vazia())
            {
                texto = "Inicio da Fila => ";
                do
                {
                    texto += $"{aux.ToString()} ";
                    aux = aux.getProximo();
                } while (aux != null);
                texto += "<= Fim da Fila";
            }
            return texto;
        }
    }
}
