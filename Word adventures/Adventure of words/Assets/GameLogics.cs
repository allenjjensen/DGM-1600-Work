using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLogics : MonoBehaviour
{

    public Text textObject;

    public enum States { start, cellWall, cellDoor, baredwindow, bed, hallL, hallR, deadScreen, deadHall, hallFree, outside };
    public States myState;
    public bool rock = false;
    public bool spring = false;
    public bool blanket = false;
    public bool cellDoor = false;



    // Use this for initialization
    void Start()
    {
        myState = States.start;
    }

    // Update is called once per frame
    void Update()
    {
        if (myState == States.start)
        {
            State_start();
        }
        else if (myState == States.baredwindow)
        {
            State_baredwindow();
        }
        else if (myState == States.bed) { State_bed(); }

        else if (myState == States.cellDoor) { State_cellDoor(); }


        else if (myState == States.hallL) { State_hallL(); }

        else if (myState == States.hallR) { State_hallR(); }

        else if (myState == States.deadScreen) { State_deadScreen(); }

        else if (myState == States.deadHall) { State_deadHall(); }

        else if (myState == States.hallFree) { State_hallFree(); }

        else if (myState == States.outside) { State_outside(); }


    }




    void State_start()
    {
        textObject.text = "Your adventure is about to start...." +
            "\n The room is cold, damp and gray. The walls are empty rock" +
            "\n except for one barred window and a cell door. The room has one" +
            "\n bed and a single bucket that is stained and smelling" +
            "\n Press" +
            "\n W for the Window. " +
            "\n B for Bed. " +
            "\n D for Door.";
        if (Input.GetKeyDown(KeyCode.W))
        {
            myState = States.baredwindow;
        }
        else if (Input.GetKeyDown(KeyCode.B))
        { myState = States.bed; }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            myState = States.cellDoor;
        }
    }



    void State_baredwindow()
    {
        textObject.text = "its a window... there are some sharp rockes here, they might be nice to have." +
        "\n Press R to pick up a sharp rock" +
        "\n press C to go back to the cell"
        ;
        if (Input.GetKeyDown(KeyCode.C)) { myState = States.start; }
        if (Input.GetKeyDown(KeyCode.R)) { rock = true; }
        if (rock == true)
        {
            textObject.text = "The wind is cold. I need to get out of here soon." +
                "\n press C to go back to the Cell";
            if (Input.GetKeyDown(KeyCode.C)) { myState = States.start; }
        }

    }
    void State_bed()
    {
        textObject.text = "The bed is rotting and stained................." +
            "\n I guess I could take the blanket to help stay warm but im fine rightnow.........." +
            "\n press B to take the Blanket....... eww..." +
            "\n press C to go to Cell";

        if (Input.GetKeyDown(KeyCode.C)) { myState = States.start; }
        if (Input.GetKeyDown(KeyCode.B)) { blanket = true; }
        if (blanket == true) {
            textObject.text = "the bed still stinks..." +
                   "\n press C to go to Cell";
            if (Input.GetKeyDown(KeyCode.C)) { myState = States.start; }
        }


        if (rock == true)
        {
            textObject.text = " Im not sleeping on it anyway... might as well rip it up to see if I can find anyting" +
"\n press R to Rip it to shreds!" +
"\n press C to go back to the Cell";
            if (Input.GetKeyDown(KeyCode.C)) { myState = States.start; }
            if (Input.GetKeyDown(KeyCode.R)) { spring = true; }
        }
        if (spring == true)
        {
            textObject.text = "Freaking nasty... I found a Spring though" +
"\n press C to go back to Cell";
            if (Input.GetKeyDown(KeyCode.C)) { myState = States.start; }


        }
    }

    void State_cellDoor() {
        textObject.text = "The door is locked... Hope I can find a way out." +
            "\n press C to go back to the cell";

        if (Input.GetKeyDown(KeyCode.C)) { myState = States.start; }
        if (spring == true) {
            textObject.text = "I could use the spring to pick the lock" +
"\n Press P to Pick the lock" +
"\n press C to go back to the Cell";
            if (Input.GetKeyDown(KeyCode.P)) { cellDoor = true; }
            if (Input.GetKeyDown(KeyCode.C)) { myState = States.start; }
        }
        if (cellDoor == true) {
            textObject.text = "The door is unlocked. There are no guards that I can see" +
"\n do I go Left or Right?";
            if (Input.GetKeyDown(KeyCode.L)) { myState = States.hallL; }
            if (Input.GetKeyDown(KeyCode.R)) { myState = States.hallR; }
        }
    }

    void State_hallL() {
        textObject.text = " The hall is ligned with cell doors, all of them stinking, most of them empty." +
            "\n Your at the end of the hall Left or Right?";
        if (Input.GetKeyDown(KeyCode.R)) { myState = States.hallFree; }

        if (Input.GetKeyDown(KeyCode.L)) {
            myState = States.deadHall;
        }
    }


    void State_deadHall() {
        textObject.text = "crumboling walls fall on you..." +
                   "\n The prizoners next to your cell tunneld out through the thick back wall to the wall that fell on you... bad timing," +
                   "\n They are happy to find the spring off of your dead body though... Good job for making their day!" +
                   "\n Next?";
        if (Input.GetKeyDown(KeyCode.N)) { myState = States.deadScreen; }
    }

    void State_hallFree() {
        textObject.text = "You have just found your way out!" +
            "\n now lets hope we can find a way home..." +
            "\n Next?";            
        if (Input.GetKeyDown(KeyCode.N)) { myState = States.outside; }
    }
        
    

    void State_hallR() {
        textObject.text = " Walking down the hall you take any way that is unlocked and unguarded. " +
            "\n after hours of walking around you find youself stuck in a " +
            "\n dungen with a gient python and a young boy fighting." +
            "\n One of the boys wild casts of magic strikes you and you are turnd into a sausage " +
            "\n You have died... " +
            "\n but the boy killed the snake when it was bussy eating you! so... thats a pluss." +
            "\n press N for next"; 

       if (Input.GetKeyDown(KeyCode.N)) {
            myState = States.deadScreen;
               
            }


        }

   void State_deadScreen() {
            textObject.text = "You have died!" +
                    "\n Press C to start again or you can give up...";
            if (Input.GetKeyDown(KeyCode.C)) { cellDoor = false; spring = false; rock = false; blanket = false; myState = States.deadScreen;
            myState = States.start; }
        }

    void State_outside() {
        textObject.text = "Its so nice to be out of that dark dank dungen" +
"\n but its still cold outside... Now you need to get off this island";
    }











}



