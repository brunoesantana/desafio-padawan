namespace Services.Interfaces;

public interface IDesafioServices
{
    List<int> AcharDivisores(int numero);
    List<int> AcharDivisoresPrimos(List<int> divisores);
    bool NumeroPrimo(int numero);
}