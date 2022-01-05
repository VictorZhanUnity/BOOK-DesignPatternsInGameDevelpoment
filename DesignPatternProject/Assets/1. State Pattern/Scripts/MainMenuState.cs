using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.State_Pattern.Scripts
{
    /// <summary>
    /// 開頭動畫 、 主選單狀態
    /// </summary>
    public class MainMenuState : ISceneState
    {
        public MainMenuState(SceneStateController controller) : base(controller)
        {
            this.StateName = "MainMenuState";
        }

        /// <summary>
        /// State開始時執行 (初始化)
        /// </summary>
        public override void StateBegin()
        {
            Debug.Log("MainMenuState.StateBegin");
            Button tmpBtn = GameObject.Find("StartGameBtn").GetComponent<Button>();
            tmpBtn?.onClick.AddListener(
                () => OnStartGameBtnClick(tmpBtn)
                ) ;
        }

        /// <summary>
        /// 點擊按鈕後開始遊戲，進入戰鬥場景 BattleScene
        /// </summary>
        private void OnStartGameBtnClick(Button theButton)
        {
            Debug.Log($"OnStartGameBtnClick: {theButton.gameObject.name}");
            m_Controller.SetState(
                new BattleState(m_Controller), "BattleScene");
        }
    }
}