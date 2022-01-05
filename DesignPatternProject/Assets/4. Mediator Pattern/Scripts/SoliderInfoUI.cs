using System;
using System.Collections;
using UnityEngine;

namespace Assets._4._Mediator_Pattern.Scripts
{
    public class SoliderInfoUI : MonoBehaviour
    {
        private PBaseDefenseGame pBaseDefenseGame;

        public SoliderInfoUI(PBaseDefenseGame pBaseDefenseGame)
        {
            this.pBaseDefenseGame = pBaseDefenseGame;
        }

        internal void Hide()
        {
            throw new NotImplementedException();
        }

        internal void ShowInfo(ISolider solider)
        {
            throw new NotImplementedException();
        }
    }
}