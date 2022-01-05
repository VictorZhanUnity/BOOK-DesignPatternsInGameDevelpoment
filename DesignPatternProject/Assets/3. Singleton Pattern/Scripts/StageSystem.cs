using System;
using System.Collections;
using UnityEngine;

namespace Assets._3._Singleton_Pattern.Scripts
{
    public class StageSystem:IGameSystem
    {
        public StageSystem(PBaseDefenseGame PBDGame) : base(PBDGame)
        {
        }

        internal void LoseHeart()
        {
            throw new NotImplementedException();
        }
    }
}