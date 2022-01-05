﻿using System.Collections;
using UnityEngine;

namespace Assets._4._Mediator_Pattern.Scripts
{
    public abstract class IGameSystem
    {
        protected PBaseDefenseGame m_PBDGame = null;

        public IGameSystem(PBaseDefenseGame PBDGame)
        {
            m_PBDGame = PBDGame;
        }

        public virtual void Initiallize() { }
        public virtual void Release() { }
        public virtual void Update() { }
    }
}