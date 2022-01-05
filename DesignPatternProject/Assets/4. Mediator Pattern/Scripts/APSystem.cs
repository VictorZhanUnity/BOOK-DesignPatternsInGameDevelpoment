using System;
using System.Collections;
using UnityEngine;

namespace Assets._4._Mediator_Pattern.Scripts
{
    public class APSystem : IGameSystem
    {
        /// <summary>
        /// 遊戲狀態頁面
        /// </summary>
        private GameStateInfoUI m_StateInfoUI;
        private int m_AP;

        public APSystem(PBaseDefenseGame PBDGame) : base(PBDGame)
        {
        }

        /// <summary>
        /// 是否可以訓練戰士
        /// </summary>
        public bool CheckTrainSolider(int soliderID)
        {
            return true;
        }

        /// <summary>
        /// 扣除AP值
        /// </summary>
        public void DescAP(int value)
        {
            m_AP -= value;
            m_StateInfoUI.UpdateUI();
        }
        public int GetAP()
        {
            return m_AP;
        }
    }
}