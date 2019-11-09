using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadinhoClass
{
    public class EstoqueRepository : BaseRepository<Estoque>
    {
        public String RealizarRecebimento(Estoque estoque, int quantidade)
        {
            int qtdeEstoqueMinimo;
            string sql;
            qtdeEstoqueMinimo = estoque.QtdeEstoqueAtual + quantidade - 3;
            if (qtdeEstoqueMinimo < 1)
            {
                sql = "UPDATE Estoque SET QtdeEstoqueAtual=QtdeEstoqueAtual+{0}, QtdeEstoqueMinimo=1 where id = {1}";
            }
            else
            {
                sql = "UPDATE Estoque SET QtdeEstoqueAtual=QtdeEstoqueAtual+{0}, QtdeEstoqueMinimo=QtdeEstoqueAtual-3 where id = {1}";
            }
            _contexto.Database.ExecuteSqlCommand(sql, quantidade, estoque.Id);
            return "";
        }
        public String RealizarBaixa(Estoque estoque, int quantidade)
        {
            if (estoque.QtdeEstoqueAtual > quantidade)
            {
                int qtdeEstoqueMinimo;
                qtdeEstoqueMinimo = estoque.QtdeEstoqueAtual - quantidade - 3;
                if (qtdeEstoqueMinimo < 1)
                {
                    qtdeEstoqueMinimo = 1;
                }

                string sql = "UPDATE Estoque SET QtdeEstoqueAtual=QtdeEstoqueAtual-{0}, QtdeEstoqueMinimo={1} where id = {2}";
                _contexto.Database.ExecuteSqlCommand(sql, quantidade, qtdeEstoqueMinimo, estoque.Id);
                return "";
            }
            else
            {
                return $"Não tem Estoque Suficiente! Saldo {estoque.QtdeEstoqueAtual}UN";
            }

        }
    }
}
