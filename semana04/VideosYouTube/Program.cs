using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

       
        Video video1 = new Video("Aprendendo C#", "isaac", 600);
        video1.Comentarios.Add(new Comentario("Maria", "Ótima aula!"));
        video1.Comentarios.Add(new Comentario("Pedro", "Muito bom."));
        video1.Comentarios.Add(new Comentario("Ana", "Me ajudou bastante."));
        videos.Add(video1);

        
        Video video2 = new Video("POO em C#", "carlinhos", 750);
        video2.Comentarios.Add(new Comentario("Lucas", "Excelente conteúdo."));
        video2.Comentarios.Add(new Comentario("Julia", "Aprendi muito."));
        video2.Comentarios.Add(new Comentario("Paulo", "Obrigado pela explicação."));
        videos.Add(video2);

       
        Video video3 = new Video("Classes e Objetos", "Fer", 500);
        video3.Comentarios.Add(new Comentario("Ricardo", "Bem explicado."));
        video3.Comentarios.Add(new Comentario("Carla", "Gostei bastante."));
        video3.Comentarios.Add(new Comentario("Bruno", "Muito útil."));
        videos.Add(video3);

       
        foreach (Video video in videos)
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Título: {video.Titulo}");
            Console.WriteLine($"Autor: {video.Autor}");
            Console.WriteLine($"Duração: {video.Duracao} segundos");
            Console.WriteLine($"Comentários: {video.ObterNumeroComentarios()}");

            Console.WriteLine("\nLista de Comentários:");

            foreach (Comentario comentario in video.Comentarios)
            {
                Console.WriteLine($"{comentario.Nome}: {comentario.Texto}");
            }

            Console.WriteLine();
        }
    }
}