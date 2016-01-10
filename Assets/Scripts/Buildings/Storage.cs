using UnityEngine;
using System.Collections;  

  
namespace God.Buildings
{
    public class Storage : Building
    {
        public int maxCapacity = 100;
        public int capacity = 0;


        public int getCapacity()
        {
            return capacity;
        }

        public int getMaxCapacity()
        {
            return maxCapacity;
        }

        


    }
}