using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Domain.PatternsCriacao.Singleton
{
    public class Cliente
    {
        public void ConsumirContexto()
        {
            var contexto = ContextoDB.Instancia;
            contexto.ExecutaQuery("SELECT * FROM TABELA");

            contexto = ContextoDB.Instancia;
            contexto.ExecutaQuery("INSERT INTO TABELA VALUES ('NAME')");

            contexto = ContextoDB.Instancia;
            contexto.ExecutaQuery("UPDATE NAME FROM TABELA WHERE NAME = 'JONAS'");

            contexto = ContextoDB.Instancia;
            contexto.ExecutaQuery("DELETE FROM TABELA WHERE NAME = 'JONAS'");
        }
    }
}