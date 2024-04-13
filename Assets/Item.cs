using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item 
{
    public int valor;
    public string descricao;
    public string tipo;

    public Item(int valor, string descricao, string tipo)
    {
        this.valor = valor;
        this.descricao = descricao;
        this.tipo = tipo;
    }
}
