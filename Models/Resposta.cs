namespace Models;

public class Resposta
{
    public int Numero { get; set; }
    public List<int> Divisores { get; set; } = new List<int>();
    public List<int> DivisoresPrimos { get; set; } = new List<int>();
}