using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject star; //This references the starShip game obj
    public SpriteMover sm; //This references the Sprite Movement Component
    public bool isActive = true; //Indicates whether the starShip GameObject is active.

    // Start is called before the first frame update
    void Start()
    {
        isActive = star.activeSelf; // The bool value is equal to the initial value of the object's active status
        sm = star.GetComponent<SpriteMover>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit(); //Out of Engine
        }
        /* When the player presses Q
         * We check to see if the object is active
         * by checking the value of the boolean
         * that we are using to identify
         * the active state of the star ship.
         */ 
        if (Input.GetKeyDown(KeyCode.Q) && isActive)
        {
            star.SetActive(false);
            isActive = false;
        }
        else if (Input.GetKeyDown(KeyCode.Q) && !isActive)
        {
            star.SetActive(true);
            isActive = true;
        }
        if (Input.GetKeyDown(KeyCode.P)) //On the down press of an input, Do{};
        {
            sm.enabled = !sm.enabled; //Toggle the enabled property of the component.
        }
    }
}
