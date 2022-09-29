using System.Data;

internal class NewBaseType
{
    public DataTable Pesquisar(int tema)
    {
        Comentario comentario = new Comentario();
        comentario.Tem_id = tema;
        return comentario.Pesquisar();
    }
}

class ComentarioController : NewBaseType
{
    public void Incluir(int tema, string descricao, string login)
 {
 Comentario comentario = new Comentario();
 comentario.Tem_id = tema;
 comentario.Com_descricao = descricao;
 comentario.Usu_login = login;
 }
}