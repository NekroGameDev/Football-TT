using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    [SerializeField] public GameObject _buttonBuy;
    [SerializeField] public GameObject _buttonPlay;

    public Shop scriptShop;

    public string nameItem;
    public int priceItem;

    private void FixedUpdate()
    {
        if (isBuy == true)
        {
            _buttonBuy.SetActive(false);
            _buttonPlay.SetActive(true);
        }
    }


    public Text TextItem;

    public bool isBuy;

    public void BuyItem()
    {

        if ( isBuy == false)
        {
             scriptShop.nameItem = nameItem;
             scriptShop.priceItem = priceItem;
             scriptShop.BuyItem();
        }

        if(isBuy == true)
        {
            _buttonBuy.SetActive(false);
            _buttonPlay.SetActive(true);
        }
    }
}
