using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public int currentShopIndex ;
   public GameObject[] Shop;
    void Start()
    {
        currentShopIndex = PlayerPrefs.GetInt("SelectedItem",0);
        foreach(GameObject item in Shop)
            item.SetActive(false);

        Shop[currentShopIndex].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
