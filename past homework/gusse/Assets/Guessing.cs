using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Guessing : MonoBehaviour
{

    public Text textbox; 

    public int max;
    public int min;
    private int guess;

    public int counter;
    

	// Use this for initialization
	void Start () 
	{

        guess = Random.Range(min, max);


        textbox.text = "Welcome to number guesser"
            + "\nPick a number in your head"
            + "\nThe highest number you can pick is " + max
            + "\nThe loowest number you can pick is " + min
            + "\n"
            + "\nis the number higher or lower then " + guess
            + "\n up arrow for higher, down for lower, enter for equal";





		max = max + 1;
	}
	
	// Update is called once per frame
	void Update () 
	{

        if (counter == -1) {

            if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow)) {
                print("you win");

                textbox.text=("you win");
            }
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            guess = (max + min) / 2;
            counter--;
            print("is the number higher or lower then " + guess);

            textbox.text=("is the number higher or lower then " + guess);

        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            guess = (max + min) / 2;
            counter--;
            print("is the number higher or lower then " + guess);

            textbox.text= ("is the number higher or lower then " + guess);
        }
		if (Input.GetKeyDown(KeyCode.Return))
		{
			print (" HA! noob... I win.");

            textbox.text=(" HA! noob... I win.");
        }

          if (counter == 0)
        {

            counter--;
        }
       
                
        

            

	}
}
