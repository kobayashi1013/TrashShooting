using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash_Can_Judge : MonoBehaviour
{
    public GameObject[] balllPrefabs;

   private int count=0;

    private void OnTriggerEnter(Collider other)
    {

        // Check if the colliding object is tagged as "GreenBin"
        //Debug.Log("Collided with: " + other.gameObject.name);
        //BlueBin
        if (other.gameObject.CompareTag("can"))
        {
            GameManager.Instance.count= GameManager.Instance.count + 10;
        }
        else if (other.gameObject.CompareTag("plastic"))
        {
            
            GameManager.Instance.count = GameManager.Instance.count + 10;
        }
        else if (other.gameObject.CompareTag("paper"))
        {
            
            GameManager.Instance.count = GameManager.Instance.count + 20;
        }
        else if (other.gameObject.CompareTag("glass"))
        {
        
            GameManager.Instance.count = GameManager.Instance.count + 20;
        }
        else if (other.gameObject.CompareTag("metal"))
        {
            GameManager.Instance.count = GameManager.Instance.count + 30;
        }

        //RedBin
        else if (other.gameObject.CompareTag("paint"))
        {
            GameManager.Instance.count = GameManager.Instance.count - 10;
        }
        else if (other.gameObject.CompareTag("Fluorecent_Tube"))
        {

            GameManager.Instance.count = GameManager.Instance.count - 10;
        }
        else if (other.gameObject.CompareTag("Chemical_Residue"))
        {

            GameManager.Instance.count = GameManager.Instance.count - 20;
        }
        else if (other.gameObject.CompareTag("Light_Bulbs"))
        {

            GameManager.Instance.count = GameManager.Instance.count - 20;
        }
        else if (other.gameObject.CompareTag("Battery"))
        {
            GameManager.Instance.count = GameManager.Instance.count - 30;
        }

        //GreenBin
        else if (other.gameObject.CompareTag("Leftover_Fruit"))
        {
            GameManager.Instance.count = GameManager.Instance.count - 10;
        }
        else if (other.gameObject.CompareTag("Leftover_Food"))
        {

            GameManager.Instance.count = GameManager.Instance.count - 10;
        }
        else if (other.gameObject.CompareTag("Leftover_Vegetable"))
        {

            GameManager.Instance.count = GameManager.Instance.count - 20;
        }
        else if (other.gameObject.CompareTag("Leaf"))
        {

            GameManager.Instance.count = GameManager.Instance.count - 20;
        }
        else if (other.gameObject.CompareTag("Bone"))
        {
            GameManager.Instance.count = GameManager.Instance.count - 30;
        }
        
        Destroy(other.gameObject); // Destroy the trash
        Debug.Log("SCORE : " + GameManager.Instance.count);
    }

}
