using UnityEngine;
using System.Collections;

namespace God.Npcs
{
    public class Transporter : Citizen
    {
        // Inspector Variables
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
        
        void Update()
        {
            if (isReady())
            {
                state = setState();
                if (state == State.atHome)
                {
                    atHome();
                } else if (state == State.atWork)
                {
                    atWork();
                }
                
                
            }
        }
        
        State setState()
        {
            if (isMoving())
            {
                return State.moving;
            } else if (currentLocation == home)
            {
                return State.atHome;
            } else if (currentLocation == work)
            {
                return State.atWork;
            } else
            {
                return State.idle;
            }
        }
        
        bool isReady()
        {
            setWork();
            if (work != null)
            {
                return true;
            } else
            {
                return false;
            }
            
        } 
        
        void setWork()
        {
            
            
        }
        
        
        // Idle
        void idle()
        {
            
        }
        
        // At Home
        void atHome()
        {
            
            
        }
        
        // At Work
        void atWork()
        {
        }
    }
}