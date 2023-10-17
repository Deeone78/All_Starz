using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class UI_Shop : MonoBehaviour
{
    public Transform container;
    private Transform shopItemTemplate;
    private void Awake()
    {
        container = transform.Find("container");
        shopItemTemplate = container.Find("shopItemTemplate");
        shopItemTemplate.gameObject.SetActive(false);
    }

    private void CreateItemButton(Sprite itemSprite , string itemnName, int itemCost, int positionIndex)
    {
        Transform shopItemTransform = Instantiate(shopItemTemplate, container);
        RectTransform shopItemRectTransform = shopItemTransform.GetComponent<RectTransform>();
        float shopItemHeight = 30f;
        shopItemRectTransform.anchoredPosition = new Vector2(0, -shopItemHeight * positionIndex );
        shopItemTransform.Find("itemName").GetComponent<TextMeshProuUGUI>().SetText(itemName);
        shopItemTransform.Find("costText").GetComponent<TextMeshProuUGUI>().SetText(itemCost.ToString());
    }


}
