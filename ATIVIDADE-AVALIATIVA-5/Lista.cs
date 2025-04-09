public class Lista
{
    private No? primeiro;
    private No? ultimo;

    public Lista()
    {
        this.primeiro = null;
        this.ultimo = null;
    }

    public bool vazia()
    {
        return this.primeiro == null;
    }

    public void limpar() {
        this.primeiro = this.ultimo = null;
    }

    public void inserir(int id, string nome)
    {
        No novo = new No(id);
        if (this.vazia())
        {
            this.primeiro = novo;
        }
        else
        {
            this.ultimo?.setProximo(novo);
        }
        this.ultimo = novo;
    }

    public bool remover(int id)
    {
        No? aux = this.primeiro;
        No? anterior = null;

        while (aux != null && aux.getChave() != id)
        {
            anterior = aux;
            aux = aux.getProximo();
        }

        if (aux == null)
        {
            return false;
        }

        if (anterior == null)
        {
            this.primeiro = aux.getProximo();
        }
        else
        {
            anterior.setProximo(aux.getProximo());
        }
        aux.setProximo(null);

        if (aux == this.ultimo)
        {
            this.ultimo = anterior;
        }
        return true;
    }

    public void imprimir()
    {
        string valores = "";
        No? aux = this.primeiro;

        while (aux != null)
        {
            valores += aux.getChave() + ", ";
            aux = aux.getProximo();
        }

        Console.WriteLine("[ {0} ]",
            valores.Length > 0 ?
            valores.Substring(0, valores.Length - 2) :
            valores
        );
    }

    public string procurarNome(int id)
    {
        No? aux = this.primeiro;
        while (aux != null)
        {
            if (aux.getChave() == id)
            {
                return aux.getNome();
            }
            aux = aux.getProximo();
        }
        return "";
    }


    public int procurar(int id) {
        No? aux = this.primeiro;
        int indice = 0;
        while (aux != null) {
            if (aux.getChave() == id) {
                return indice;
            }
            indice++;
            aux = aux.getProximo();
        }
        return -1;
    }

}