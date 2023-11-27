using System;
class ArvoreBinaria
{
    private ArvoreNodes raiz;

    // Arvore começa com Null e iremos criar os metodos de inserir e remover nós a longo da classe
    public ArvoreBinaria()
    {
        raiz = null;
    }
    
    // Método para inserir um novo nó na árvore
    public void inserir(int key)
    {
        raiz = InsertRec(raiz, key);
    }

    private ArvoreNodes InsertRec(ArvoreNodes raiz, int key)
    {
        if (raiz == null)
        {
            raiz = new ArvoreNodes(key);
            return raiz;
        }

        if (key < raiz.data)
        {
            raiz.esquerdo = InsertRec(raiz.esquerdo, key);
        }
        else if (key > raiz.data)
        {
            raiz.direito = InsertRec(raiz.direito, key);
        }

        return raiz;
    }

    // Método para remover um nó da árvore
    public void Remove(int chave)
    {
        raiz = RemoveRec(raiz, chave);
    }

    private ArvoreNodes RemoveRec(ArvoreNodes raiz, int chave)
    {
        if (raiz == null)
        {
            return raiz;
        }

        if (chave < raiz.data)
        {
            raiz.esquerdo = RemoveRec(raiz.esquerdo, chave);
        }
        else if (chave > raiz.data)
        {
            raiz.direito = RemoveRec(raiz.direito, chave);
        }
        else
        {
            // Nó com apenas um filho ou sem filho
            if (raiz.esquerdo == null)
            {
                return raiz.direito;
            }
            else if (raiz.direito == null)
            {
                return raiz.esquerdo;
            }

            // Nó com dois filhos: obter o sucessor in-order (menor nó na subárvore direita)
            raiz.data = MinValor(raiz.direito);

            // Remover o sucessor in-order
            raiz.direito = RemoveRec(raiz.direito, raiz.data);
        }

        return raiz;
    }

    // Funçao p/ criar o Valor Minimo
    private int MinValor(ArvoreNodes raiz)
    {
        int minValor = raiz.data;
        while (raiz.esquerdo != null)
        {
            minValor = raiz.esquerdo.data;
            raiz = raiz.esquerdo;
        }
        return minValor;
    }

    // Método para imprimir a árvore em ordem
    public void InOrderTraversal()
    {
        InOrderTraversal(raiz);
    }

    private void InOrderTraversal(ArvoreNodes raiz)
    {
        if (raiz != null)
        {
            InOrderTraversal(raiz.esquerdo);
            Console.Write(raiz.data + " ");
            InOrderTraversal(raiz.direito);
        }
    }
}