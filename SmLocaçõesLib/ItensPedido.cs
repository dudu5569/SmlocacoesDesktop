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

        }

    }
}
