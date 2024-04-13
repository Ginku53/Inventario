using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mercado : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Item maca = new Item(20, "Uma fruta vermelha altamente nutritivo.", "Fruta") ;
        Item espada = new Item(50, "Espada longa para batalhas.", "Arma");
        Item escudo = new Item(50, "Escudo de uma mão.", "Armadura");
        Item pocaoCura = new Item(30, "poção para vitalidade.", "Consumível");
        Item pocaoMana = new Item(30, "poção para mana.", "Consumível");
        Item anelBronze = new Item(40, "Anel protetor de bronze.", "Acessório");

        Inventario inventario = new Inventario();
        inventario.itens = new Item[20];
        inventario.itens[5] = maca;
        inventario.itens[0] = espada;
        inventario.itens[1] = escudo;
        inventario.itens[2] = pocaoCura;
        inventario.itens[3] = pocaoMana;
        inventario.itens[4] = anelBronze;
        
        
        
       

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
