public interface IEmprestavel
{
void Emprestar();
void Devolver();
bool VerificarDisponibilidade();
DateTime ObterPrazoDeDevolucao();
}
