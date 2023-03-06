using Services.Interfaces;

namespace Services.Services;

public class DesafioServices : IDesafioServices
{
    public List<int> AcharDivisores(int numero)
    {
        var divisores = new List<int>();

        if (numero == 0)
        {
            return divisores;
        }

        if (numero < 0)
        {
            numero *= -1;
        }

        for (int i = 1; i <= (numero / 2) + 1; i++)
        {
            if (numero % i == 0)
            {
                divisores.Add(i);
            }
        }
        
        if(numero > 2)
        {
            divisores.Add(numero);
        }
        
        return divisores;
    }

    public List<int> AcharDivisoresPrimos(List<int> divisores)
    {
        var divisoresPrimos = new List<int>();
        foreach (var numero in divisores)
        {
            if (NumeroPrimo(numero))
            {
                divisoresPrimos.Add(numero);
            }
        }
        return divisoresPrimos;
    }

    public bool NumeroPrimo(int numero)
    {
        if (numero == 1)
        {
            return false;
        }
        for (int i = 2; i <= (numero / 2); i++)
        {
            if (numero % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}