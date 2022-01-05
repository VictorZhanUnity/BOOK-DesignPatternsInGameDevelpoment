using System;
using System.Collections;
using UnityEngine;

namespace Assets._2._Facade_Pattern.Scripts
{
    public class GameEventSystem
    {
        private PBaseDefenseGame pBaseDefenseGame;

        public GameEventSystem(PBaseDefenseGame pBaseDefenseGame)
        {
            this.pBaseDefenseGame = pBaseDefenseGame;
        }

        public void Init()
        {
            Debug.Log("GameEventSystem.Init()");
        }

        public void Update()
        {
        }
    }
}