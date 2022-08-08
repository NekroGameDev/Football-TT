using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    private Shop.DataPlayer dataPlayer = new Shop.DataPlayer();
    [HideInInspector]
    public string nameItem;
    [HideInInspector]
    public int priceItem;
    private int _zaglushka;

    public GameObject[] allItem;


    public class DataPlayer
    {

        public List<string> buyItem = new List<string>();
    }

    private void Start()
    {
        
        if (PlayerPrefs.HasKey("SaveGame"))
        {
            LoadGame();
        }
        else
        {
            SaveGame();
            LoadGame();
        }
    }

    private void SaveGame()
    {

        PlayerPrefs.SetString("SaveGame", JsonUtility.ToJson(dataPlayer));
    }

    private void LoadGame()
    {
        dataPlayer = JsonUtility.FromJson<DataPlayer>(PlayerPrefs.GetString("SaveGame"));

        for(int i = 0; i < dataPlayer.buyItem.Count; i++)
        {
            for(int y = 0; y < allItem.Length; y++)
            {
                if(allItem[y].GetComponent<Item>().nameItem == dataPlayer.buyItem[i])
                {
                    allItem[y].GetComponent<Item>().TextItem.text = "Куплено";
                    allItem[y].GetComponent<Item>().isBuy = true;
                }
            }
        }
    }

    public void BuyItem()
    {
        if(MoneyManager.Money >= priceItem)
        {
            dataPlayer.buyItem.Add(nameItem);
            MoneyManager.Money -= priceItem;

            SaveGame();
            LoadGame();
        }

        
    }
}
