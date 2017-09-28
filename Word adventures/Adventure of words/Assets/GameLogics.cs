using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLogics : MonoBehaviour
{

    public Text textObject;

    public enum States { start, cellWall, cellDoor, baredwindow, bed, hallL, hallR, deadScreen, deadHall, hallFree, outsideTop,outsiBot, tunnel,
    yourTunnel};
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

        else if (myState == States.cellWall) { State_cellWall(); }

        else if (myState == States.hallL) { State_hallL(); }

        else if (myState == States.hallR) { State_hallR(); }

        else if (myState == States.deadScreen) { State_deadScreen(); }

        else if (myState == States.deadHall) { State_deadHall(); }

        else if (myState == States.hallFree) { State_hallFree(); }

        else if (myState == States.outsideTop) { State_outside(); }

        else if (myState == States. outsiBot) { State_outsiBot(); }
 
        else if (myState == States.tunnel) { State_tunnel(); }

        else if (myState == States.yourTunnel) { State_yourTunnel(); }
    }




    void State_start()
    {
        textObject.text = "your adventure is about to start...." +
            "\n the room is cold, damp and gray. the walls are empty rock" +
            "\n except for one barred window and a cell door. the room has one" +
            "\n bed and a single bucket that is stained and smelly" +
            "\n Press" +
            "\n W for Window. " +
            "\n B for Bed. " +
            "\n D for Door." +
            "\n A for wAll";
            
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
        else if (Input.GetKeyDown(KeyCode.A)) { myState = States.cellWall; }
    }



    void State_baredwindow()
    {
        textObject.text = "its a window... there are some sharp rockes here, they might be nice to have." +
        "\n press R to pick up a sharp rock" +
        "\n press C to go back to the cell"
        ;
        if (Input.GetKeyDown(KeyCode.C)) { myState = States.start; }
        if (Input.GetKeyDown(KeyCode.R)) { rock = true; }
        if (rock == true)
        {
            textObject.text = "the wind is cold. you need to get out of here soon." +
                "\n press C to go back to the Cell";
            if (Input.GetKeyDown(KeyCode.C)) { myState = States.start; }
        }

    }
    void State_bed()
    {
        textObject.text = "The bed is rotting and stained..." +
            "\n I guess you could take the blanket to help stay warm but it's nasty and you look fine rightnow.........." +
            "\n press B to take the Blanket... eww..." +
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
            textObject.text = " you're not sleeping on it anyway... might as well rip it up to see if you can find anyting" +
"\n press R to Rip it to shreds!" +
"\n press C to go back to the Cell";
            if (Input.GetKeyDown(KeyCode.C)) { myState = States.start; }
            if (Input.GetKeyDown(KeyCode.R)) { spring = true; }
        }
        if (spring == true)
        {
            textObject.text = "freaking nasty... but you found a Spring though, good find" +
"\n press C to go back to Cell";
            if (Input.GetKeyDown(KeyCode.C)) { myState = States.start; }


        }
    }
    void State_cellWall() {
        textObject.text = "the wall is made of bricks and crumbeling morder. one of the bricks is half" +
"\n dug already." +
"\n press C to go back to Cell";
        if (Input.GetKeyDown(KeyCode.C)) { myState = States.start; }
        if (rock == true) {
            textObject.text = "Use the rock to start Digging?" +
                "\n press D to start digging" +
                "\n press C to go back to Cell";
            if (Input.GetKeyDown(KeyCode.C)) { myState = States.start; }
            if (Input.GetKeyDown(KeyCode.D)) { myState = States.tunnel; }
        }
    }

    void State_tunnel() { textObject.text = "you found a half made tunnel!" +
            "\n there are two people in this tunnel. it looks like the prizoners from the cell next to you." +
            "\n after several minuts of talking with them the wall you came in colapses." +
            "\n ' looks like you are stuck with us now. our wall did the same thing.'" +
            "\n 'just to let you know it gets cold at nights and its only been getting colder I hope you" +
            "\n brought something to stay warm with." +
            "\n Press N Next?";
        if (Input.GetKeyDown(KeyCode.N)) { myState = States.yourTunnel; }
    }

    void State_yourTunnel() {
        textObject.text = "after several days of trying to dig yourself out and eating bugs and mice" +
            "\n and maybe one or two of your friends" +
"\n you and your new friendssss.... bones... finaly dig to a wall that leads to a hall." +
"\n with a last push all three of you fall through the wall... onto a prizoner who made it out of his cell...." +
"\n oops." +
"\n a spring of all things was found on his body... wonder what that's for." +
"\n looks like their are two options go Right, down a hall where guards might be, or Forword to a big rusted door" +
"\n R F";
        spring = true;
        if (Input.GetKeyDown(KeyCode.F)) { myState = States.outsideTop; }
        if (Input.GetKeyDown(KeyCode.R)) { myState = States.hallR; }
    }


    void State_cellDoor() {
        textObject.text = "the door is locked... hope you can find a way out." +
            "\n press C to go back to the Cell";

        if (Input.GetKeyDown(KeyCode.C)) { myState = States.start; }
        if (spring == true) {
            textObject.text = "you could use the spring to Pick the lock" +
"\n Press P to Pick the lock" +
"\n press C to go back to the Cell";
            if (Input.GetKeyDown(KeyCode.P)) { cellDoor = true; }
            if (Input.GetKeyDown(KeyCode.C)) { myState = States.start; }
        }
        if (cellDoor == true) {
            textObject.text = "The door is unlocked. there are no guards that can be seen" +
"\n do you go Left or Right?" +
"\n L or R?";
            if (Input.GetKeyDown(KeyCode.L)) { myState = States.hallL; }
            if (Input.GetKeyDown(KeyCode.R)) { myState = States.hallR; }
        }
    }

    void State_hallL() {
        textObject.text = " hhe hall is lined with cell doors, all of them stinking, most of them empty." +
            "\n Your at the end of the hall Left or Right?";
        if (Input.GetKeyDown(KeyCode.R)) { myState = States.hallFree; }

        if (Input.GetKeyDown(KeyCode.L)) {
            myState = States.deadHall;
        }
    }


    void State_deadHall() {
        textObject.text = "crumboling walls fall on you..." +
                   "\n the prizoners next to your cell tunneld out through the thick back wall to the wall that fell on you... bad timing," +
                   "\n they are happy to find the spring off of your dead body though... good job for making their day!" +
                   "\n Next?";
        if (Input.GetKeyDown(KeyCode.N)) { myState = States.deadScreen; }
    }

    void State_hallFree() {
        textObject.text = "you have just found your way out!" +
            "\n now lets hope we can find a way home..." +
            "\n Next?";            
        if (Input.GetKeyDown(KeyCode.N)) { myState = States.outsideTop; }
    }
        
    

    void State_hallR() {
        textObject.text = " walking down the hall you take any way that is unlocked and unguarded. " +
            "\n after hours of walking around you find youself stuck in a " +
            "\n dungen with a gient python and a young boy fighting." +
            "\n One of the boys wild casts of magic strikes you and you are turnd into a sausage " +
            "\n You have died... " +
            "\n but the boy killed the snake when it was bussy eating you! so... thats a pluss." +
            "\n press N for Next"; 

        if ( blanket == true ) {
            textObject.text = "walking down the hall you take any way that is unlocked and unguarded. " +
            "\n after hours of walking around you find youself stuck in a " +
            "\n dungen with a gient python and a young boy fighting." +
            "\n One of the boys wild casts of magic strikes your blanket turning it into sausages." +
            "\n the python starts to eat the sausage as you run away." +
            "\n light and a cold wind we are freeeeeee " +
            "\n you win... for now, " +
            "\n Next?";
         if (Input.GetKeyDown(KeyCode.N)) { myState = States.outsiBot; }
        }

 }


        
    void State_outsiBot() {
        textObject.text = "you have walked outside into a green forest... you can hear some odd human vocals coming " +
            "\n in the wind. you need to get out of here fast. THEY can probably smell the sausages";
    }

   void State_deadScreen() {
            textObject.text = "you have died!" +
                    "\n Press C to start again or you can give up...";
            if (Input.GetKeyDown(KeyCode.C)) { cellDoor = false; spring = false; rock = false; blanket = false; myState = States.deadScreen;
            myState = States.start; }
        }

    void State_outside() {
        textObject.text = "its so nice to be out of that dark dank dungeon" +
"\n but its still cold outside... now you need to get off this island" +
"\n you win... for now";
    }











}



