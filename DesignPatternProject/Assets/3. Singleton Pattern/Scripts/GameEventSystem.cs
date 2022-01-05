using System;
using System.Collections;
using UnityEngine;

namespace Assets._3._Singleton_Pattern.Scripts
{
    public class GameEventSystem : IGameSystem
    {
        public GameEventSystem(PBaseDefenseGame PBDGame) : base(PBDGame)
        {
        }
    }
}