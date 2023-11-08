using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopManager : MonoBehaviour
{
    public int currentShopIndex ;
   public GameObject[] Shop;
    

   public ItemBlueprint[] item;
   public Button buyButton; 


    void Start()
    {
        foreach(ItemBlueprint item in item)
        {
            if(item.price == 0)
               item. isUnlocked = true;
               else
               item.isUnlocked = PlayerPrefs.GetInt(item.name,0) ==0 ? false: true;
        }
        currentShopIndex = PlayerPrefs.GetInt("SelectedItem",0);
        foreach(GameObject item in Shop)
            item.SetActive(false);

        Shop[currentShopIndex].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
         UpdateUI();
    }

    public void ChangeNext()
    {
        Shop[currentShopIndex].SetActive(false);

        currentShopIndex++;
        if (currentShopIndex==Shop.Length)
            currentShopIndex=0;
        Shop[currentShopIndex].SetActive(true);
         ItemBlueprint i = item[currentShopIndex];
         if(!i.isUnlocked)
             return;

        PlayerPrefs.SetInt("SelectedItem", currentShopIndex);
    }

    public void ChangePrevious()
    {
        Shop[currentShopIndex].SetActive(false);

        currentShopIndex--;
        if (currentShopIndex == -1)
            currentShopIndex = Shop.Length -1;
        Shop[currentShopIndex].SetActive(true);
        ItemBlueprint i = item[currentShopIndex];
         if(!i.isUnlocked)
             return;

        PlayerPrefs.SetInt("SelectedItem", currentShopIndex);
    }

    public void UnlockItem()
    {
        ItemBlueprint i = item[currentShopIndex];

        PlayerPrefs.SetInt(i.name,1);
        PlayerPrefs.SetInt("Selecteditem", currentShopIndex);
        i.isUnlocked = true;
        PlayerPrefs.SetInt("NumberOfCoins",PlayerPrefs.GetInt("NumberOfCoins",0) - i.price);
    }

    private void UpdateUI()
    {
        ItemBlueprint i = item[currentShopIndex];
        if (i.isUnlocked)
        {
            buyButton.gameObject.SetActive(false);
        }
        else
        {
             buyButton.gameObject.SetActive(true);
             buyButton.GetComponentInChildren<TextMeshProUGUI>().text = "Buy-"+ i.price;
             if (i.price< PlayerPrefs.GetInt("NumberOfCoins",0))
             {
                buyButton.interactable = true;
             }
             else
             {
                buyButton.interactable = false;
             }
        }

    }
}
