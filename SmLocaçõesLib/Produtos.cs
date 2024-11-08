using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SmLocaçõesLib
{
    public class Produtos
    {

        public int ID { get; set; }
        
        Categorias Categoria { get; set; }
        public string? Nome_Produto { get; set; }
        public string? Imagem { get; set; }

        public Decimal? Valor { get; set; }
        public string? Unidade_Venda { get; set; }
        public DateTime? Data_cadastro { get; set; }
        public string? Descricao { get; set;}
        public string? Destaque { get; set; }

        public Produtos() { }
        public Produtos(Categorias categoria, string? nome_Produto, string? imagem, decimal? valor, string? unidade_Venda, DateTime? data_cadastro, string? descricao, string? destaque)
        {
            Categoria = categoria;
            Nome_Produto = nome_Produto;
            Imagem = imagem;
            Valor = valor;
            Unidade_Venda = unidade_Venda;
            Data_cadastro = data_cadastro;
            Descricao = descricao;
            Destaque = destaque;
        }

        public static byte[] ImagemParaArray(string caminhoImagem)
        {
            byte[] imagemBytes;
            using (FileStream fs = new FileStream(caminhoImagem, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader br = new BinaryReader(fs))
                {
                    imagemBytes = br.ReadBytes((int)fs.Length);
                }
            }
            return imagemBytes;
        }

        public void InserirProduto(string caminhoImagem)
        {
            using (var cmd = Banco.Abrir())
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "sp_inserir_produtos";

                byte[] imagembytes = ImagemParaArray(caminhoImagem);

                cmd.Parameters.AddWithValue("@spid_categoria", Categoria.Id);
                cmd.Parameters.AddWithValue("@spnome", Nome_Produto ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@spimagem", imagembytes);
                cmd.Parameters.AddWithValue("@spvalor_unit", Valor ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@spunidade_venda", Unidade_Venda ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@spdata_cad", Data_cadastro ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@spdescricao", Descricao ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@spdestaque", Destaque ?? (object)DBNull.Value);
                using (var dr = cmd.ExecuteReader())
                {
                    if (dr.Read()) ID = dr.GetInt32(0);
                } 
            }
        }

        
    }
}
