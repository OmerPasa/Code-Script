using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;

public class SpawnArea : MonoBehaviour
{
    private bool collusionhappened;
    public GameObject Trutle;
    public Transform EnemySpawner;
    int xPos;
    int yPos;
    [SerializeField]
    private int Maxcount;
    [SerializeField]
     private int Count;
     
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("triggered!!!!");
    if(other.gameObject.tag == "Player")
    {
        if (collusionhappened)
        {
            return;   
        }else
        {
        xPos = (int)transform.position.x;
        yPos = (int)transform.position.y;
        StartCoroutine(EnemyDrop());
        collusionhappened = true;      
        }
          
    }
    }
    IEnumerator EnemyDrop()
   {
       for (Count = 0; Count < Maxcount; Count++)
       {
           Instantiate(Trutle,new Vector3(xPos,yPos,0f),Quaternion.identity);
           yield return new WaitForSeconds(0.1f);
       }
       /*
       if (Count == Maxcount)
        {
            yield return null;
        }else
        {
            Instantiate(Trutle,new Vector3(xPos,yPos,0f),Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
        }

        */
    }
}
