using System;
using System.Collections;
using UnityEngine;

namespace Assets._4._Mediator_Pattern.Scripts
{
    public class AchievementSystem:IGameSystem
    {
        public AchievementSystem(PBaseDefenseGame PBDGame) : base(PBDGame)
        {
            Initiallize();
        }

    }
}