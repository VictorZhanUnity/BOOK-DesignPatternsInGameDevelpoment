using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets._7._Game_Loop.Scripts
{
    public class GameStateInfoUI:IUserInterface
    {
        private APSystem m_APSystem;

        public Text m_SoliderCountText, m_EnemyCountText;

        public GameStateInfoUI(PBaseDefenseGame PBDGame) : base(PBDGame)
        {
            this.m_PBDGame = PBDGame;
        }

        public override void Update()
        {
            base.Update();
            //雙方數量
            //m_SoliderCountText.text = $"我方單位數: {m_PBDGame.GetUnitCount(ENUM_Solider.Null)}";
            //m_EnemyCountText.text = $"敵方單位數: {m_PBDGame.GetEnemyCount(ENUM_Enemy.Null)}";
        }


        /// <summary>
        /// 繼續
        /// </summary>
        private void OnContinueBtnClick()
        {
            Time.timeScale = 1;
            //換回開始State
            m_PBDGame.ChangeToMainMenu();
        }

        private void OnPauseBtnClick()
        {
            m_PBDGame.GamePause();
        }

        /// <summary>
        /// 更新介面
        /// </summary>
        public void UpdateUI()
        {
            int nowAP = m_APSystem.GetAP();
        }
    }
}