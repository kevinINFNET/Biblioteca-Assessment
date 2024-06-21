public abstract class ItemBiblioteca
{
 public string Titulo { get; set; }
 public string Autor { get; set; }
 public int AnoPublicacao { get; set; }

 public abstract void Emprestar();
 public abstract void Devolver();
 public abstract void ExibirInformacoes();
}