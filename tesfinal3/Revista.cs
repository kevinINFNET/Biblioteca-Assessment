public class Revista : ItemBiblioteca, IEmprestavel
{
public override void Emprestar()
{
Console.WriteLine($"Revista \"{Titulo}\" emprestada.");
}
 public override void Devolver()
{
Console.WriteLine($"Revista \"{Titulo}\" devolvida.");
}
public override void ExibirInformacoes()
{
 Console.WriteLine($"Revista: {Titulo}, Ano: {AnoPublicacao}");
}
public bool VerificarDisponibilidade()
{
 return true; 
}
 public DateTime ObterPrazoDeDevolucao()
{
 return DateTime.Today.AddDays(7); 
 }
}
