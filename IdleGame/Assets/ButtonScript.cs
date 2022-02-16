using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonScript : MonoBehaviour
{
    GMScript GM;
    public int cost;
    public float costScale;
    public float spsGain;
    int quantity = 0;


    // Start is called before the first frame update
    void Start()
    {
        GM = GameObject.Find("GameManager").GetComponent<GMScript>();
        if(cost > 0)
        {
            gameObject.transform.GetChild(1).gameObject.GetComponent<TextMeshProUGUI>().text = quantity.ToString();
            gameObject.transform.GetChild(2).gameObject.GetComponent<TextMeshProUGUI>().text = "Cost:" + cost.ToString();
        }
    }

    public void clickForPoints()
    {
        GM.score += 1;
    }

    public void purchaseUpgrade()
    {
        if(GM.score >= cost)
        {
            GM.score -= cost;
            GM.SPS += spsGain;

            quantity++;
            cost = Mathf.CeilToInt(cost * costScale);

            gameObject.transform.GetChild(1).gameObject.GetComponent<TextMeshProUGUI>().text = quantity.ToString();
            gameObject.transform.GetChild(2).gameObject.GetComponent<TextMeshProUGUI>().text = "Cost:" + cost.ToString();
        }
    }
}
