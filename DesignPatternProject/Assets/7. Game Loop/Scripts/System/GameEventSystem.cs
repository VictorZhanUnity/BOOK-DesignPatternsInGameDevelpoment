using System;
using System.Collections;
using UnityEngine;

namespace Assets._7._Game_Loop.Scripts
{
    public class GameEventSystem : IGameSystem
    {
        public GameEventSystem(PBaseDefenseGame PBDGame) : base(PBDGame)
        {
        }

        internal void RegisterObserver(ENUM_GameEvent eNUM_GameEvent, IGameEventObserver observer)
        {
        }

        internal void NotifySubject(ENUM_GameEvent eNUM_GameEvent, object param)
        {
        }
    }
}