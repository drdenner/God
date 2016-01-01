using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace God.Npcs
{
	public class Herbalist : Citizen
	{
		// Inspector Variables
		public int foodNr = 0;
		public int maxFood = 5;
		public float workSpeed = 1;
		public enum State
		{
			idle,
			moving,
			atHome,
			atWork
		}
		;
		public State state;



		// Other Variables
		bool working = false;

		void Update ()
		{
			if (isReady ()) {
			
			
				state = setState ();
				if (state == State.atHome) {
					atHome ();
				} else if (state == State.atWork) {
					atWork ();
				} 


			} 
		}


		State setState ()
		{

			if (isMoving ()) {
				return State.moving;
			} else if (currentLocation == home) {
				return State.atHome;
			} else if (currentLocation == work) {
				return State.atWork;
			} else {
				return State.idle;
			}
		}

	

		bool isReady ()
		{
			work = getClosestFoodToGather ("Berries");
			if (work != null) {
				return true;
			} else {
				return false;
			}
		}

		// Idle
		void idle ()
		{
		
		}

		// At Home
		void atHome ()
		{
			if (foodNr > 0) {
				removeFood ();
			}

			if (isDaytime ()) {
				moveTo (work);
			} else {

			}

		}

		// At Work
		void atWork ()
		{
			if (!working) {
				StartCoroutine (addFood ());
				working = true;
			}

		}

		IEnumerator addFood ()
		{
			for (int i=1; i <= maxFood; i++) {
				God.Enviroment.Food food work.GetComponent<God.Enviroment.Food> ().removeFood (1);
				foodNr++;
				yield return new WaitForSeconds (workSpeed);
			}
			working = false;
			moveTo (home);
		}

		void removeFood ()
		{
			home.GetComponent<God.Buildings.HerbalistHut> ().addFood (foodNr);
			foodNr = 0;
		}



	}
}