using Org.BouncyCastle.Crypto.Digests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmLocaçõesLib
{
    public class ItensPedido
    {
        public int ID { get; set; }
        public Pedidos Id_pedido { get; set; }

        public Produtos Id_produtos { get; set; }

        public decimal? valor_total { get; set; }

        public int? Quantidade{ get; set; }

        public ItensPedido() { }
        public ItensPedido(Pedidos id_pedido, Produtos id_produtos, decimal? valor_total, int? quantidade)
        {
            Id_pedido = id_pedido;
            Id_produtos = id_produtos;
            this.valor_total = valor_total;
            Quantidade = quantidade;
        }

        public ItensPedido(int iD, Pedidos id_pedido, Produtos id_produtos, decimal? valor_total, int? quantidade)
        {
            ID = iD;
            Id_pedido = id_pedido;
            Id_produtos = id_produtos;
            this.valor_total = valor_total;
            Quantidade = quantidade;
        }

        public ItensPedido(int iD, Produtos id_produtos)
        {
            ID = iD;    
            Id_produtos = id_produtos;
        }

        public ItensPedido(Pedidos id_pedido)
        {
            Id_pedido = id_pedido;
        }

        public void InserirItemPedido()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_inserir_items_locacoes";
            cmd.Parameters.AddWithValue("spid_locacao", Id_pedido.Id);
            cmd.Parameters.AddWithValue("spid_produto", Id_produtos.ID);
            cmd.Parameters.AddWithValue("spvalor_unit", valor_total);
            cmd.Parameters.AddWithValue("spquantidade", Quantidade);
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            var dr = cmd.ExecuteReader();
            if (dr.Read()) ID = dr.GetInt32(0);
        }
        
        public static List<ItensPedido> ObterListaItensPedido(int id)
        {
            List<ItensPedido> lista = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            if (id != 0)
            {
                cmd.CommandText = $"SELECT * FROM ITENS_LOCACOES WHERE ID_LOCACAO = {id}";

            }
            else
            {
                cmd.CommandText = $"SELECT * FROM ITENS_LOCACOES WHERE ID_LOCACAO = {id}";

            }

            var dr = cmd.ExecuteReader();
            int indexId = dr.GetOrdinal("id");
            int indexId_pedido = dr.GetOrdinal("id_locacao");
            int indexId_produto = dr.GetOrdinal("id_produto");
            int indexId_valor_unit = dr.GetOrdinal("valor_unit");
            int indexId_quantidade = dr.GetOrdinal("quantidade");


            while (dr.Read())
            {
                lista.Add(new ItensPedido(
                    dr.GetInt32(indexId),
                    Pedidos.ObterIdPedido(dr.GetInt32(indexId_pedido)),
                    Produtos.ObterIdProduto(dr.GetInt32(indexId_produto)),
                    dr.GetDecimal(indexId_valor_unit),
                    dr.GetInt32(indexId_quantidade)
                    ));
            }
            return lista;

        }

    }
}
