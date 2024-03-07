namespace ScreenSound.Modelos;

internal class AvaliacaoComSobrescrita
{
    public AvaliacaoComSobrescrita(int nota)
    {
        Nota = nota;
    }

    public int Nota { get; }

    public static AvaliacaoComSobrescrita Parse(string texto)
    {
        int nota = int.Parse(texto);
        return new AvaliacaoComSobrescrita(nota);
    }

    public override bool Equals(object? obj)
    {
        if (obj == null) return false;
        if (obj is not AvaliacaoComSobrescrita other) return false;
        return Nota.Equals(other.Nota);
    }

    public override int GetHashCode()
    {
        return Nota.GetHashCode();
    }

    public override string ToString()
    {
        return Nota.ToString();
    }
}
