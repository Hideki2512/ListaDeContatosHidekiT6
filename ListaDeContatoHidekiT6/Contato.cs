using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeContatoHidekiT6
{
    internal class Contato
    {
        // Declaração de variáveis
        private string nome;
        private string sobrenome;
        private string telefone;

        // Propriedades. São os métodos "get" e "set"
        // get = leitura.
        // set = definição
        // é possível ser somente leitura, ou somente definição...
        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }

        public string Sobrenome
        {
            get
            {
                return sobrenome;
            }
            set
            {
                sobrenome = value;
            }
        }

        public string Telefone
        {
            get
            {
                return telefone;
            }
            set
            {
                if (value.Length == 13)
                {
                    telefone = value;
                }
                else
                {
                    telefone = "(00) 00000-0000";
                }
            }
        }

        // Construtor da classe
        public Contato()
        {
            Nome = "Robert";
            Sobrenome = "Whobert";
            Telefone = "(11) 99999-8888";
        }

        // Sobrecarga do método construtor Contato.
        public Contato(string nome, string sobrenome, string telefone)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Telefone = telefone;
        }

        // ToString() pertence a classe object.
        // Todas as classes são filhas de object.
        // "override" sobrescreve o método da classe pai (polimorfismo).
        public override string ToString()
        {
            // inicializa a variável como vazia.
            string saida = string.Empty;
            saida += String.Format("{0} {1}", Nome, Sobrenome);
            saida += String.Format("({0}) {1}-{2}",
                Telefone.Substring(0, 2),
                Telefone.Substring(3,5),
                Telefone.Substring(7,4));

            return saida;
        }
    }
}
