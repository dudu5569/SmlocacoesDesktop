using SmLocaçõesLib;

public class Produtos
{
    public int ID { get; set; }
    public Categorias Id_Categoria { get; set; }  
    public string? Nome_Produto { get; set; }
    public string? Imagem { get; set; }
    public Decimal? Valor { get; set; }
    public string? Unidade_Venda { get; set; }
    public string? Descricao { get; set; }
    public string? Destaque { get; set; }


    // Construtor
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

    // Método para inserir um produto no banco
    public void InserirProduto()
    {
        using (var cmd = Banco.Abrir())
        {
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_inserir_produtos";

            cmd.Parameters.AddWithValue("@spid_categoria", Id_Categoria);
            cmd.Parameters.AddWithValue("@spnome", Nome_Produto ?? "Produto Sem Nome");
            cmd.Parameters.AddWithValue("@spimagem", Imagem ?? "imagem_default.png");
            cmd.Parameters.AddWithValue("@spvalor_unit", Valor ?? 0.00m);
            cmd.Parameters.AddWithValue("@spunidade_venda", Unidade_Venda ?? "Unidade");
            cmd.Parameters.AddWithValue("@spdescricao", Descricao ?? "Sem descrição");
            cmd.Parameters.AddWithValue("@spdestaque", Destaque ?? "Nao");

            using (var dr = cmd.ExecuteReader())
            {
                if (dr.Read()) ID = dr.GetInt32(0);
            }
        }
    }

    public static List<Produtos> ObterListaProdutos(string? nome)
    {
        List<Produtos> lista = new List<Produtos>();
        var cmd = Banco.Abrir();
        cmd.CommandType = System.Data.CommandType.Text;

        if (nome == "")
        {
            cmd.CommandText = "SELECT * FROM produtos ORDER BY nome_produto LIMIT 20";
        }
        else
        {
            cmd.CommandText = $"SELECT * FROM produtos WHERE nome_produto LIKE '%{nome}%' ORDER BY nome_produto";
        }

        var dr = cmd.ExecuteReader();

        // Obter os índices das colunas
        int indexCategoria = dr.GetOrdinal("id_categoria");
        int indexNomeProduto = dr.GetOrdinal("nome_produto");
        int indexImagem = dr.GetOrdinal("imagem");
        int indexValor = dr.GetOrdinal("valor");
        int indexUnidadeVenda = dr.GetOrdinal("unidade_venda");
        int indexDescricao = dr.GetOrdinal("descricao");
        int indexDestaque = dr.GetOrdinal("destaque");

        while (dr.Read())
        {

            // Acessando as colunas de forma robusta
            lista.Add(new Produtos(
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
}
