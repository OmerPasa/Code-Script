using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;

public class SpawnArea : MonoBehaviour
{
    public GameObject bug;
    public int xPos;
    public int yPos;
    public int enemyCount;

    void Start ()
    {
        StartCoroutine(EnemyDrop());
    }
    IEnumerator EnemyDrop()
   {
       while (enemyCount < 8)
       {
           xPos = (int)Random.Range(-1f,1f);
           yPos = (int)Random.Range(8f,-7f);
           Instantiate(bug,new Vector3(xPos,yPos,-0.1f),Quaternion.identity);
           yield return new WaitForSeconds(0.1f);
           enemyCount += 1;
    

       }
   }

}
