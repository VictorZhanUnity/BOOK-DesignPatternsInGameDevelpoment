using System;
using System.Collections;
using UnityEngine;

namespace Assets._4._Mediator_Pattern.Scripts
{
    public class CampInfoUI : MonoBehaviour
    {
        //兵營系統
        private CampSystem m_CampSystem;
        private PBaseDefenseGame pBaseDefenseGame;

        public CampInfoUI(PBaseDefenseGame pBaseDefenseGame)
        {
            this.pBaseDefenseGame = pBaseDefenseGame;
        }

        /// <summary>
        /// 訓練戰士
        /// </summary>
        public void TrainSolider(int soliderID)
        {
            m_CampSystem.TrainSolider(soliderID);
        }

        internal void ShowInfo(ICamp camp)
        {
            throw new NotImplementedException();
        }

        internal void Hide()
        {
            throw new NotImplementedException();
        }
    }
}