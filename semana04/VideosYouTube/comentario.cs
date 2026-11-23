public class Comentario
{
    public string Nome { get; set; }
    public string Texto { get; set; }

    public Comentario(string nome, string texto)
    {
        Nome = nome;
        Texto = texto;
    }
}