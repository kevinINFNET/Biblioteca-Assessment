public class Biblioteca
{
private List<ItemBiblioteca> itens;
public Biblioteca()
{
  itens = new List<ItemBiblioteca>();
}
public void AdicionarItem(ItemBiblioteca item)
{
 itens.Add(item);
}
public void RemoverItem(ItemBiblioteca item)
{
 itens.Remove(item);
}
public void ExibirItens()
{
  Console.WriteLine("Itens na Biblioteca:");
   foreach (var item in itens)
{
   item.ExibirInformacoes();
  }
}
 public void RealizarEmprestimo(ItemBiblioteca item)
{
  if (item is IEmprestavel)
{
  ((IEmprestavel)item).Emprestar();
}
  else
{
 Console.WriteLine("Este item não pode ser emprestado.");
}
}
public void RealizarDevolucao(ItemBiblioteca item)
    {
 if (item is IEmprestavel)
        {
((IEmprestavel)item).Devolver();
 }
 else
{
  Console.WriteLine("Este item não pode ser devolvido.");
  }
 }
}