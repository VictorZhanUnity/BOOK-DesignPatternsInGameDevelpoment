using System;
using System.Collections;
using UnityEngine;

namespace Assets._2._Facade_Pattern.Scripts
{
    public class CampSystem
    {
        private PBaseDefenseGame pBaseDefenseGame;

        public CampSystem(PBaseDefenseGame pBaseDefenseGame)
        {
            this.pBaseDefenseGame = pBaseDefenseGame;
        }

        public void Init()
        {
            Debug.Log("CampSystem.Init()");
        }

        public void Update()
        {
        }
    }
}