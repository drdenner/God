using UnityEngine;
using System.Collections;

namespace God.Enviroment
{
    public class Food : MonoBehaviour
    {

        public int foodNr = 100;
        God.Npcs.Citizen citizen;

        public enum FoodType
        {
            Berries
        }
        ;

        public FoodType foodType;



        void OnTriggerEnter(Collider other)
        {

            if (other.tag == "Citizen")
            {
                citizen = other.GetComponent<God.Npcs.Citizen>();
                citizen.setLocation(gameObject);
            }
        }

        void OnTriggerExit(Collider other)
        {
            if (other.tag == "Citizen")
            {
                citizen = other.GetComponent<God.Npcs.Citizen>();
                citizen.setLocation(null);
            }
        }

        public void removeFood(int foodNr)
        {
            this.foodNr = this.foodNr - foodNr;
        }


    }
}