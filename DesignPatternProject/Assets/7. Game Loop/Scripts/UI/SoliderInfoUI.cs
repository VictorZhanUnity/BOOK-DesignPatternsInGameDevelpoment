using System;
using System.Collections;
using UnityEngine;

namespace Assets._7._Game_Loop.Scripts
{
    public class SoliderInfoUI : IUserInterface
    {
        public SoliderInfoUI(PBaseDefenseGame PBDGame) : base(PBDGame)
        {
            m_PBDGame = PBDGame;
        }

        public override void Hide()
        {
            throw new NotImplementedException();
        }

        internal void ShowInfo(ISolider solider)
        {
            throw new NotImplementedException();
        }
    }
}