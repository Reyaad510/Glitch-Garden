using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarDisplay : MonoBehaviour
{
    [SerializeField] int stars = 100;
    Text starText;


    // Start is called before the first frame update
    void Start()
    {
        starText = GetComponent<Text>();
        UpdateDisplay();
    }


    private void UpdateDisplay()
    {
        starText.text = stars.ToString();
    }

    public bool HaveEnoughStars(int amount)
    {
        // When we pass in amt do we have more stars than amt? If so then return True
        return stars >= amount;
    }

    public void AddStars(int amount)
    {
        stars += amount;
        UpdateDisplay();
    }

    public void SpendStars(int amount)
    {
        if(stars >= amount)
        {
            stars -= amount;
            UpdateDisplay();
        }
    }

}
