using System;
using System.Collections;
using UnityEngine;

namespace Assets._2._Facade_Pattern.Scripts
{
    public class StageSystem
    {
        private PBaseDefenseGame pBaseDefenseGame;

        public StageSystem(PBaseDefenseGame pBaseDefenseGame)
        {
            this.pBaseDefenseGame = pBaseDefenseGame;
        }

        public void Init()
        {
            Debug.Log("StageSystem.Init()");
        }

        public void Update()
        {
        }
    }
}