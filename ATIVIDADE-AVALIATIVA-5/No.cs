using System.Globalization;
using System.Runtime.CompilerServices;

public class No
{
    private int id;
    private string nome;
    private No? proximo;

    public No(int id, string nome)
    {
        this.id = id;
        this.nome = nome;
        this.proximo = null;
    }

    public int getChave()
    {
        return id;
    }

    public void setProximo(No? proximo)
    {
        this.proximo = proximo;
    }

    public No? getProximo()
    {
        return proximo;
    }

    public string getNome()
    {
        return nome;
    }

}
