namespace ap2_crud_medicos.Domain.Entities
{
  public abstract class Pessoa
  {
    public int Id { get; set; }
    public string Nome { get; set; }
    public string CPF { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }
  }
}
