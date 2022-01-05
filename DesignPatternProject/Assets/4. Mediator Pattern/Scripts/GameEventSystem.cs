using System;
using System.Collections;
using UnityEngine;

namespace Assets._4._Mediator_Pattern.Scripts
{
    public class GameEventSystem : IGameSystem
    {
        public GameEventSystem(PBaseDefenseGame PBDGame) : base(PBDGame)
        {
        }

        internal void RegisterObserver(ENUM_GameEvent eNUM_GameEvent, IGameEventObserver observer)
        {
            throw new NotImplementedException();
        }

        internal void NotifySubject(ENUM_GameEvent eNUM_GameEvent, object param)
        {
            throw new NotImplementedException();
        }
    }
}