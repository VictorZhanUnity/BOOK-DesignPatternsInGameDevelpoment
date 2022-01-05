using System;
using System.Collections;
using UnityEngine;

namespace Assets._2._Facade_Pattern.Scripts
{
    public class APSystem
    {
        private PBaseDefenseGame pBaseDefenseGame;

        public APSystem(PBaseDefenseGame pBaseDefenseGame)
        {
            this.pBaseDefenseGame = pBaseDefenseGame;
        }

        public void Init()
        {
            Debug.Log("APSystem.Init()");
        }

        public void Update()
        {
        }
    }
}