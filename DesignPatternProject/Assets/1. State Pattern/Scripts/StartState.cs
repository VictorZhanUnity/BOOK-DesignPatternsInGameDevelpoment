using System;
using System.Collections;
using UnityEngine;

namespace Assets.State_Pattern.Scripts
{
    /// <summary>
    /// 整個遊戲中最一開始的StartState (StartScene)
    /// 負責預先載入所需要的資源與初始化
    /// Loading畫面
    /// </summary>
    public class StartState : ISceneState
    {
        public StartState(SceneStateController controller) : base(controller)
        {
            this.StateName = "StartState";
        }

        /// <summary>
        /// State開始時執行 (初始化)
        /// </summary>
        public override void StateBegin()
        {
            Debug.Log("StartState.StateBegin");
            //可在此進行遊戲資料載入及初始化…等
        }

        /// <summary>
        /// MonoBehaviour.Update()
        /// </summary>
        public override void StateUpdate()
        {
            //載入資源完畢與初始化之後，才進入MainMenustate, 主選單場景 (MainMenuScene)
            if (IsResourceLoadingComplete())
            {
                this.m_Controller.SetState(
                    new MainMenuState(m_Controller), "MainMenuScene");
            }
        }

        private bool IsResourceLoadingComplete()
        {
            return true;
        }
    }
}