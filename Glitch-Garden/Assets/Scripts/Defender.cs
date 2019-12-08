using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] int starCost = 50;






    public void AddStars(int amount)
    {
        // Grabbing AddStars from StarDisplay so we can make animation on our trophy to update our display
        FindObjectOfType<StarDisplay>().AddStars(amount);
    }


    public int GetStarCost()
    {
        return starCost;
    }

    // Uncheck Exit time on line going Cactus Attack to Cactus Idle so will cancel idle animation to swithc to attacking animation






















}
