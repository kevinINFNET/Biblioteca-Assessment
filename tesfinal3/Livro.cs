public class Livro : ItemBiblioteca, IEmprestavel
{
public override void Emprestar()
{
  Console.WriteLine($"Livro \"{Titulo}\" emprestado.");
}
 public override void Devolver()
{
 Console.WriteLine($"Livro \"{Titulo}\" devolvido.");
}
public override void ExibirInformacoes()
{
  Console.WriteLine($"Livro: {Titulo}, Autor: {Autor}, Ano: {AnoPublicacao}");
}
 public bool VerificarDisponibilidade()
{
return true; 
 }
 public DateTime ObterPrazoDeDevolucao()
{
   return DateTime.Today.AddDays(15); 
 }
}