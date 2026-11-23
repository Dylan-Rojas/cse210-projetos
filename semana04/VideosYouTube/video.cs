using System.Collections.Generic;

public class Video
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int Duracao { get; set; }

    public List<Comentario> Comentarios { get; set; }

    public Video(string titulo, string autor, int duracao)
    {
        Titulo = titulo;
        Autor = autor;
        Duracao = duracao;
        Comentarios = new List<Comentario>();
    }

    public int ObterNumeroComentarios()
    {
        return Comentarios.Count;
    }
}