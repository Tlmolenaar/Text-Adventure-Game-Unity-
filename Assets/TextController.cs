using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {room, gum_0, paper_0, hall_0, hall_1, room_gum, room_paper, room_all};
	private States myState;

	// Use this for initialization
	void Start () {
		myState = States.room;
			if(myState == States.room){
				state_room();
			}else if (myState == States.gum_0){
				state_gum_0();
			}else if (myState == States.paper_0){
				state_paper_0();
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
			}
		
		}
	
	// Update is called once per frame
	void Update () {
		print (myState);
	}
	
	void state_room (){
		
			text.text = "G, P, H";
	}
	
	void state_gum_0 (){
			text.text = "T, R"
	}
	
	void state_paper_0 (){
			text.text = "T, R"
	}
	
	void state_hall_0 (){
			text.text = "R"
	}
	
	void state_hall_1 (){
			text.text = "R"
	}
	
	void state_room_gum (){
			text.text = "H, P"
	}
	
	void state_room_paper (){
			text.text = "H, G"
	}
	
	void state_room_all (){
			text.text = "H"
	}
}
