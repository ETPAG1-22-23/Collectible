using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible_Ramassable : MonoBehaviour
{
    private int NombreDePick = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PickUpPotion(Collider2D collision)
    {
        if (NombreDePick == 1)
        {
            if (collision.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.E))
            {
                collision.gameObject.GetComponentInChildren<Health>().pv += 10;
                Destroy(gameObject);
                Debug.Log("BEHHHHHHHHHHHH");
                NombreDePick--;
            }
        }
    }
    void OnTriggerStay2D(Collider2D collision)
    {
        PickUpPotion(collision);
    }
}
