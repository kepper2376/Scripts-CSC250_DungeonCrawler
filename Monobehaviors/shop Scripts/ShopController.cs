using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShopController : MonoBehaviour
{
    public TextMeshPro playerTMP, itemTMP;

    // Start is called before the first frame update
    void Start()
    {
        this.updatePlayerTMP();
        this.itemTMP.text = "" + ItemsSingleton.cherryItemCost;
    }

    private void updatePlayerTMP()
    {
        this.playerTMP.text = "Pellets: " + MySingleton.currentPellets + "(HP: " + MySingleton.thePlayer.getHP() + ")"; ;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Alpha1))
        {
            //charge the player for the item
            if(MySingleton.currentPellets >= ItemsSingleton.cherryItemCost)
            {
                MySingleton.currentPellets -= ItemsSingleton.cherryItemCost;
                MySingleton.thePlayer.addHP(5);
                this.updatePlayerTMP();
            }
        }

    }
}