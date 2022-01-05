using System;
using System.Collections;
using UnityEngine;

namespace Assets._7._Game_Loop.Scripts
{
    public class BattleState : ISceneState
    {
        public BattleState(SceneStateController controller) : base(controller)
        {
            this.StateName = "BattleState";
        }

        /// <summary>
        /// 呼叫遊戲主程式進行初始化
        /// </summary>
        public override void StateBegin()
        {
            Debug.Log("BattleState.StateBegin");
            PBaseDefenseGame.Instance.Initialize();
        }

        /// <summary>
        /// 呼叫遊戲主程式進行資源釋放Destory
        /// </summary>
        public override void StateEnd()
        {
            Debug.Log("BattleState.StateEnd");
            PBaseDefenseGame.Instance.Release();
        }

        /// <summary>
        /// MonoBehaviour.Update()
        /// </summary>
        public override void StateUpdate()
        {
            InputProcess();

            //遊戲邏輯
            PBaseDefenseGame.Instance.Update();

            //當遊戲主程式的GameOver時，即轉換到主選單場景MainMenuState
            if (PBaseDefenseGame.Instance.ThisGameIsOver())
            {
                this.m_Controller.SetState(
                    new MainMenuState(m_Controller), "MainMenuScene");
            }
        }

        private void InputProcess()
        {
            //判斷玩家輸入
            if (Input.GetKeyDown(KeyCode.F))
            {
                PBaseDefenseGame.Instance.ToGameOver();
            }
        }
    }
}