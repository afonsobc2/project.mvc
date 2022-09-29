public partial class frmVisualizarComentario : Form
{
 public int TemaId;
 public string? TemaDescricao;
    private readonly object? dataGridViewComentario;

    private void Pesquisar()
    {
        ComentarioController cController = new ComentarioController();
        NewMethod(cController);
    }

    private void NewMethod(ComentarioController cController)
    {
        NewMethod1(cController);

        void NewMethod1(ComentarioController cController)
        {
            NewMethod2();
        }
    }

    private void NewMethod2()
    {
        throw new NotImplementedException();
    }

    private void

        FrmVisualizarComentario_Load(
        object sender, EventArgs e)
 {
 Pesquisar();
 }
 private void ButtonIncluirComentario_Click(object sender,
EventArgs e)
    {
        frmIncluirComentario frm = new frmIncluirComentario();
        frm.TemaId = TemaId;
        string? temaDescricao = TemaDescricao;
        frm.TemaDescricao = GetTemaDescricao(temaDescricao);
        frm.Show();
    }

    private static string? GetTemaDescricao(string? temaDescricao)
    {
        return temaDescricao;
    }
}