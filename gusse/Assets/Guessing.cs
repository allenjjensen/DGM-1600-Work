using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guessing : MonoBehaviour
{
    private int max = 100;
    private int min = 1;
    private int guess;

    public int counter;


	// Use this for initialization
	void Start () 
	{

        guess = Random.Range(min, max);

		print ("welcome to number guesser");
		print ("pick a number in your head");
		print (" The highest number you can pick is " + max);
		print ("The loowest number you can pick is " + min);

		print ("is the number higher or lower then " + guess);
		print (" up arrow for higher, down for lower, enter for equal");
		max = max + 1;
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			min = guess; 
			guess = (max + min) / 2;
            counter--;
			print ("is the number higher or lower then " + guess);


		}
		if (Input.GetKeyDown (KeyCode.DownArrow)) 
		{
			max = guess;
			guess = (max + min) / 2;
            counter--;
			print ("is the number higher or lower then " + guess);

		}
		if (Input.GetKeyDown(KeyCode.Return))
		{
			print (" HA! noob... I win.");
		}

        {  if (counter == 0)
                
                print("you win.... noob");    
       
        }

            

	}
}
