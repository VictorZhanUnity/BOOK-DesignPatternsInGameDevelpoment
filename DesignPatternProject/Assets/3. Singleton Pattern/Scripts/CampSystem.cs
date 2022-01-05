using System;
using System.Collections;
using UnityEngine;

namespace Assets._3._Singleton_Pattern.Scripts
{
    public class CampSystem:IGameSystem
    {
        public CampSystem(PBaseDefenseGame PBDGame) : base(PBDGame)
        {
        }

    }
}