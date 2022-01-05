using System;
using System.Collections;
using UnityEngine;

namespace Assets._3._Singleton_Pattern.Scripts
{
    public class AchievementSystem:IGameSystem
    {
        public AchievementSystem(PBaseDefenseGame PBDGame) : base(PBDGame)
        {
            Initiallize();
        }

    }
}