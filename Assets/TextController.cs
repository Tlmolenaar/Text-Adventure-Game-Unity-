using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {room, gum_0, gum_1, paper_0, paper_1, hall_0, hall_1, room_gum, room_paper, room_all, sleep};
	private States myState;

	// Use this for initialization
	void Start () {
			myState = States.room;
		}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		
		if(myState == States.room){
			state_room();
		}else if (myState == States.gum_0){
			state_gum_0();
		}else if (myState == States.gum_1){
			state_gum_1();
		}else if (myState == States.paper_0){
			state_paper_0();
		}else if (myState == States.paper_1){
			state_paper_1();
		}else if (myState == States.hall_0){
			state_hall_0();
		}else if (myState == States.hall_1){
			state_hall_1();
		}else if (myState == States.room_gum){
			state_room_gum();
		}else if (myState == States.room_paper){
			state_room_paper();
		}else if (myState == States.room_all){
			state_room_all();
		}else if (myState == States.sleep){
			state_sleep();
		}
		
	}
	
	void state_room (){
		
			text.text = "Your alarm didn't go off this morning!! How will you " +
						"get to work in time? Once you get out of bed two things " +
						"come to your attention. There's a pack of gum on your desk " +
						"and a small piece of paper lying on the floor.\n\n" +
						"Press G to look at the gum, P to look at the paper " + 
						"or H to go to the hall.";
						
			if (Input.GetKeyDown(KeyCode.G)){
				myState = States.gum_0;
			}else if (Input.GetKeyDown(KeyCode.P)){
				myState = States.paper_0;
			}else if (Input.GetKeyDown(KeyCode.H)){
				myState = States.hall_0;
			}
	}
	
	void state_gum_0 (){
			text.text = "There is only one piece left in the pack. If you take it " + 
						"your colleagues don't need to know how much you drank last night.\n\n" +
						"Press T to take the gum or press R to return";
			if (Input.GetKeyDown(KeyCode.T)){
				myState = States.room_gum;
			}else if (Input.GetKeyDown(KeyCode.R)){
				myState = States.room;
			}
	}
	
	void state_gum_1 (){
			text.text = "There is only one piece left in the pack. If you take it " + 
						"your colleagues don't need to know how much you drank last night.\n\n" +
						"Press T to take the gum or press R to return";
		if (Input.GetKeyDown(KeyCode.T)){
			myState = States.room_all;
		}else if (Input.GetKeyDown(KeyCode.R)){
			myState = States.room_paper;
		}
	}
	
	void state_paper_0 (){
			text.text = "It's a piece of paper you must have dropped when you went to " +
						"bed last night. It lists a phone number and a name: Doris." +
						"What have you been up to last night?\n\n" +  
						"Press T to take the piece of Paper, press R to return";
			if (Input.GetKeyDown(KeyCode.T)){
				myState = States.room_paper;
			}else if (Input.GetKeyDown(KeyCode.R)){
				myState = States.room;
			}
	}
	
	void state_paper_1 (){
			text.text = "It's a piece of paper you must have dropped when you went to " +
						"bed last night. It lists a phone number and a name: Doris." +
						"What have you been up to last night?\n\n" +  
						"Press T to take the piece of Paper, press R to return";;
		if (Input.GetKeyDown(KeyCode.T)){
			myState = States.room_all;
		}else if (Input.GetKeyDown(KeyCode.R)){
			myState = States.room_gum;
		}
	}
	
	void state_hall_0 (){
			text.text = "Aren't you forgetting something?! You are already late, so no" +
						"time to faff around\n\n" + 
						"Press R to go back to your room.";
			 if (Input.GetKeyDown(KeyCode.R)){
				myState = States.room;
			}
	}
	
	void state_hall_1 (){
			text.text = "HALL, R";
			if (Input.GetKeyDown(KeyCode.R)){
				myState = States.room_all;
			}
	}
	
	void state_room_gum (){
			text.text = "You're standing in your room, chewing your gum." +
						"The minty freshness wakes you up a little.\n\n" +
						"Press P to look at the paper or press H to go to the Hall";
			if (Input.GetKeyDown(KeyCode.H)){
				myState = States.hall_0;
			}else if (Input.GetKeyDown(KeyCode.P)){
				myState = States.paper_1;
			}
	}
	
	void state_room_paper (){
			text.text = "Who is Doris and why do you have her number? " +
						"You decide to save the number in your phone so you can ask " +
						"her what happened later. The thought of last night leaves a nasty " +
						"taste in your mouth. Fortunately there is gum on the desk.\n\n" +
						" Press G to look at gum or press H to go to the hall.";
			if (Input.GetKeyDown(KeyCode.H)){
				myState = States.hall_0;
			}else if (Input.GetKeyDown(KeyCode.G)){
				myState = States.gum_1;
			}
	}
	
	void state_room_all (){
			text.text = "There is nothing else you need in your room. Time to leave the house!\n\n" +
						"Press H to go to the hall or press S to go back to sleep";
		if (Input.GetKeyDown(KeyCode.H)){
			myState = States.hall_1;
		}else if (Input.GetKeyDown(KeyCode.S)){
			myState = States.sleep;
		}
	
	}
	
	void state_sleep (){
		text.text = "Now is not the time to sleep! YOU ARE LATE FOR WORK!!!\n\n" +
					"Press R to get back on your feet";
		
		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.room_all;
		}
		
	}
}
