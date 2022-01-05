using System;
using System.Collections;
using UnityEngine;

namespace Assets._2._Facade_Pattern.Scripts
{
    public class AchievementSystem
    {
        private PBaseDefenseGame pBaseDefenseGame;

        public AchievementSystem(PBaseDefenseGame pBaseDefenseGame)
        {
            this.pBaseDefenseGame = pBaseDefenseGame;
        }

        public void Init()
        {
            Debug.Log("AchievementSystem.Init()");
        }

        public void Update()
        {
        }
    }
}