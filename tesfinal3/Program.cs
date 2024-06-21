
class Program
{
static void Main(string[] args)
 {
  Livro livro1 = new Livro { Titulo = "A viagem de chihiro ", Autor = "Hayao Miyazaki", AnoPublicacao = 2001 };
  Revista revista1 = new Revista { Titulo = "Studio Ghibli", AnoPublicacao = 2001 };

Biblioteca biblioteca = new Biblioteca();
 biblioteca.AdicionarItem(livro1);
 biblioteca.AdicionarItem(revista1);
 biblioteca.ExibirItens();
 biblioteca.RealizarEmprestimo(livro1);
 biblioteca.RealizarDevolucao(livro1);
 }
}
