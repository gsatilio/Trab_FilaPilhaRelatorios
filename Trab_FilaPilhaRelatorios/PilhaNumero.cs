using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Trab_FilaPilhaRelatorios
{
    internal class PilhaNumero
    {
        Numero topo;

        public PilhaNumero()
        {
            topo = null;
        }
        public void push(Numero aux)
        {
            if (vazia() == true)
            {
                topo = aux;
            }
            else
            {
                aux.setAnterior(topo);
                topo = aux;
            }
        }
        public int pop()
        {
            int valor = 0;
            if (!vazia())
            {
                valor = topo.getNumero();
                topo = topo.getAnterior();
            }
            return valor;
        }
        public int getContador()
        {
            int contador = 0;
            Numero aux = topo;
            if (!vazia())
            {
                do
                {
                    contador++;
                    aux = aux.getAnterior();
                } while (aux != null);
            }
            return contador;
        }
        bool vazia()
        {
            if (topo == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string print()
        {
            Numero aux = topo;
            string texto = "";
            if (!vazia())
            {
                texto = "Topo da Pilha";
                do
                {
                    texto += $"\n{aux.ToString()} ";
                    aux = aux.getAnterior();
                } while (aux != null);
            }
            return texto;
        }
        public int getValores(int posicao)
        {
            Numero aux = topo;
            int valor = 0, contador = 0;
            if (!vazia())
            {
                valor = aux.getNumero();
                do
                {
                    contador++;
                    aux = aux.getAnterior();
                    if (aux != null && posicao > 0 )
                    {
                        valor = aux.getNumero();
                    }
                } while (aux != null && contador < posicao);
            }
            return valor;
        }
    }
}
