using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermoThis
{
    class Acessar
    {
        string senha = "abc123";

        public bool Login(string senha)
        {
            return this.senha == senha; 
            // poderíamos alterar o valor das variáveis, para que não fosse preciso utilizar o this
            // a referência dentro do método é sempre ao parâmetro recebido
            // o this faz com que o método olhe para  classe, e não para o parâmetro de entrada
        }
    }
}
