using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class UI_Shop : MonoBehaviour
{
    public Transform container;
    private Transform shopItemTemplate;
    public Button Item;
    private void Awake()
    {
        container = transform.Find("container");
        shopItemTemplate = container.Find("shopItemTemplate");
        shopItemTemplate.gameObject.SetActive(false);
    }

    private void Start()
    {
        foreach (ItemData x in FindObjectsOfType<ItemData>())
        {
            /*if (x.cost > money)
            {
                x.GetComponent<Button>().interactable = false;
            }*/
            CreateItemButton(x.sprite, x.name,x.cost,x.index);
        }
    }
    private void CreateItemButton(  Sprite itemSprite , string itemName, int itemCost, int positionIndex)
    {
        Transform shopItemTransform = Instantiate(shopItemTemplate, container);
        RectTransform shopItemRectTransform = shopItemTransform.GetComponent<RectTransform>();
        float shopItemHeight = 30f;
        shopItemRectTransform.anchoredPosition = new Vector2(0, -shopItemHeight * positionIndex );
        shopItemTransform.Find("itemName").GetComponent<TextMeshProUGUI>().SetText(itemName);
        shopItemTransform.Find("costText").GetComponent<TextMeshProUGUI>().SetText(itemCost.ToString());

        shopItemTransform.Find("itemImage").GetComponent<Image>().sprite = itemSprite;

        shopItemTransform.GetComponent<Button>().onClick.AddListener(delegate {Purchase(itemCost);});

    }

    public void Purchase(int price)
    {

    }

    /* button, onClick  ->  Puchase() 
     *  money - cost
     *  
     *  in Start()
     *  if (x.cost > money)
        {
                x.GetComponent<Button>().interactable = false;
     *  }
     *  
     *  static money;
     *  
     *  money += score;
     */
}
