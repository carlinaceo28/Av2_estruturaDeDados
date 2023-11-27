using System;
class ArvoreNodes
{
    public int data;
    public ArvoreNodes esquerdo, direito;

    public ArvoreNodes(int item)
    {
        data = item;
        esquerdo = direito = null;
    }
}