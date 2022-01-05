using System;
using System.Collections;
using UnityEngine;

namespace Assets._7._Game_Loop.Scripts
{
    public class AchievementSystem:IGameSystem
    {
        public AchievementSystem(PBaseDefenseGame PBDGame) : base(PBDGame)
        {
            Initiallize();
        }

    }
}