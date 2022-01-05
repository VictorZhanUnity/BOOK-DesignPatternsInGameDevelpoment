using System;
using System.Collections;
using UnityEngine;

namespace Assets._7._Game_Loop.Scripts
{
    public class CampInfoUI:IUserInterface
    {
        //兵營系統
        private CampSystem m_CampSystem;

        public CampInfoUI(PBaseDefenseGame PBDGame) : base(PBDGame)
        {
            this.m_PBDGame = PBDGame;
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

        public override void Hide()
        {
            throw new NotImplementedException();
        }

    }
}