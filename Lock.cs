using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Lock : MonoBehaviour
//int num = random.Next(180); 
          //private static Random _random = new Random();
                                               //private void button1_Click(object sender, EventArgs e){
                                              //for (int i = 0; i < 4; i++){} 
          //number.ToString("D2") + "\r\n"    //System.Random rand = new System.Random();
                                             //int number = rand.Next(180);
                                            //Items.Add(number.ToString("D2"));
                                            //suggested ---   //System.Random rand = new System.Random(); for (int i = 0; i < 4; i++) { int number = rand.Next(180); comboBox1.Items.Add(number.ToString("D2")); }
          //private static IEnumerable<int> GetSequence(int size, int max){//return Enumerable.Range(_random.Next(max-(size-1)), size);}
              // 180   5-90   4-70  3-500  2-30  1-10
{
    float speed = 65.0f;
    float difficult = 0.0f;
    bool novice;
    bool appretience;
    bool adept;
    bool expert;
    bool master;
    
    // Start is called before the first frame update
    void Start()
    {
        var _random = new System.Random();  
            
           for (int i = 0; i < 70; i++)                      
           {  
                
               var difficult = _random.Next(0, 180);
               if (difficult >= 0)
               {
                   Console.WriteLine(difficult);
               }
           }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * speed *Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.forward * speed *Time.deltaTime);
        }
        

         
    
    }
}
