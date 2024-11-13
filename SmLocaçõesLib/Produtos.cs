using SmLocaçõesLib;

public class Produtos
{
    public int ID { get; set; }
    public Categorias? Id_Categoria { get; set; }  
    public string? Nome_Produto { get; set; }
    public string? Imagem { get; set; }
    public Decimal? Valor { get; set; }
    public string? Unidade_Venda { get; set; }
    public string? Descricao { get; set; }
    public string? Destaque { get; set; }


    public Produtos(Categorias categoria, string? nome_Produto, string? imagem, decimal? valor, string? unidade_Venda, string? descricao, string? destaque)
    {
        Id_Categoria = categoria;
        Nome_Produto = nome_Produto;
        Imagem = imagem;
        Valor = valor;
        Unidade_Venda = unidade_Venda;
        Descricao = descricao;
        Destaque = destaque;
    }

    public Produtos(int iD, Categorias id_Categoria, string? nome_Produto, string? imagem, decimal? valor, string? unidade_Venda, string? descricao, string? destaque)
    {
        ID = iD;
        Id_Categoria = id_Categoria;
        Nome_Produto = nome_Produto;
        Imagem = imagem;
        Valor = valor;
        Unidade_Venda = unidade_Venda;
        Descricao = descricao;
        Destaque = destaque;
    }

    public Produtos(int id, string? nome_Produto, string? imagem, decimal? valor, string? unidade_Venda, string? descricao, string? destaque)
    {
        ID = id;
        Nome_Produto = nome_Produto;
        Imagem = imagem;
        Valor = valor;
        Unidade_Venda = unidade_Venda;
        Descricao = descricao;
        Destaque = destaque;
    }


    // Método para inserir um produto no banco
    public void InserirProduto()
    {
        using (var cmd = Banco.Abrir())
        {
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_inserir_produtos";

            cmd.Parameters.AddWithValue("@spid_categoria", Id_Categoria.Id);
            cmd.Parameters.AddWithValue("@spnome", Nome_Produto ?? "Produto Sem Nome");
            cmd.Parameters.AddWithValue("@spimagem", Imagem ?? "imagem_default.png");
            cmd.Parameters.AddWithValue("@spvalor_unit", Valor ?? 0.00m);
            cmd.Parameters.AddWithValue("@spunidade_venda", Unidade_Venda ?? "Unidade");
            cmd.Parameters.AddWithValue("@spdescricao", Descricao ?? "Sem descrição");
            cmd.Parameters.AddWithValue("@spdestaque", Destaque ?? "Nao");

            using (var dr = cmd.ExecuteReader())
            {
                if (dr.Read()){
                    ID = dr.GetInt32(0);
                    cmd.Connection.Close();
                }
            }
        }

    }

    public static List<Produtos> ObterListaProdutos(string? nome)
    {
        List<Produtos> lista = new();
        var cmd = Banco.Abrir();
        cmd.CommandType = System.Data.CommandType.Text;



        if (nome == "")
        {
            cmd.CommandText = "SELECT * FROM produtos ORDER BY nome_produto";
        }
        else
        {
            cmd.CommandText = $"SELECT * FROM produtos WHERE nome_produto LIKE '%{nome}%' ORDER BY nome_produto";
        }

        var dr = cmd.ExecuteReader();

        // Obter os índices das colunas
        int indexId = dr.GetOrdinal("id");
        int indexCategoria = dr.GetOrdinal("id_categoria");
        int indexNomeProduto = dr.GetOrdinal("nome_produto");
        int indexImagem = dr.GetOrdinal("imagem");
        int indexValor = dr.GetOrdinal("valor");
        int indexUnidadeVenda = dr.GetOrdinal("unidade_venda");
        int indexDescricao = dr.GetOrdinal("descricao");
        int indexDestaque = dr.GetOrdinal("destaque");

        while (dr.Read())
        {
            lista.Add(new Produtos(
                dr.GetInt32(indexId),
                Categorias.ObterPorId(dr.GetInt32(indexCategoria)),   
                dr.GetString(indexNomeProduto),                         
                dr.GetString(indexImagem),                              
                dr.GetDecimal(indexValor),                              
                dr.GetString(indexUnidadeVenda),                                     
                dr.GetString(indexDescricao),                           
                dr.GetString(indexDestaque)                             
            ));
        }

        cmd.Connection.Close();
        return lista;
    }

    public void AtualizaProdutos()
    {
        var cmd = Banco.Abrir();
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        cmd.CommandText = "sp_update_produtos";
        cmd.Parameters.AddWithValue("spid", ID);
        cmd.Parameters.AddWithValue("spnome", Nome_Produto);
        cmd.Parameters.AddWithValue("spimagem", Imagem);
        cmd.Parameters.AddWithValue("spvalor", Valor);
        cmd.Parameters.AddWithValue("spunidade_venda", Unidade_Venda);
        cmd.Parameters.AddWithValue("spdescricao", Descricao);
        cmd.Parameters.AddWithValue("spdestaque", Destaque);
        cmd.ExecuteNonQuery();
        cmd.Connection.Close();

    }
}
