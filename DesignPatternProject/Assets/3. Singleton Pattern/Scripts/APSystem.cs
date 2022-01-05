using System;
using System.Collections;
using UnityEngine;

namespace Assets._3._Singleton_Pattern.Scripts
{
    public class APSystem : IGameSystem
    {
        public APSystem(PBaseDefenseGame PBDGame) : base(PBDGame)
        {
        }
    }
}