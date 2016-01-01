using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace God.Buildings
{
	public class Storage : Building
	{
		public int maxCapacity = 100;
		public int capacity = 0;
		Dictionary<string, int> storage = new Dictionary<string, int> ();

		void Update ()
		{

		}

		public void test ()
		{
			print ("test");

		}

		public void addObject (string objectToAdd, int numberToAdd)
		{
			if (capacity <= maxCapacity) {
				if (storage.ContainsKey (objectToAdd)) {
					storage [objectToAdd] = storage [objectToAdd] + numberToAdd;
				} else {
					storage [objectToAdd] = numberToAdd;
				}
				updateCapacity (numberToAdd);
			} 
		}

		public void removeObject (string objectToRemove, int numberToRemove)
		{
			if (storage [objectToRemove] <= numberToRemove) {
				storage [objectToRemove] = storage [objectToRemove] - numberToRemove;

			} 
		}

		void updateCapacity (int numberToAdd)
		{
			capacity = capacity + numberToAdd;
		}

	}
}