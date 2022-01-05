using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.State_Pattern.Scripts
{
    public class SceneStateController
    {
        private ISceneState m_State;
        private bool m_bRunBegin = false;

        public SceneStateController() { }

        /// <summary>
        /// 設定狀態
        /// </summary>
        public void SetState(ISceneState state, string LoadSceneName)
        {
            m_bRunBegin = false;
            LoadScene(LoadSceneName);
            //結束上一個State
            m_State?.StateEnd();
            //設定新的State
            m_State = state;
        }

        /// <summary>
        /// 載入場景
        /// </summary>
        private void LoadScene(string loadSceneName)
        {
            if (loadSceneName == null || loadSceneName.Length == 0)
            {
                return;
            }
            SceneManager.LoadScene(loadSceneName);
        }

        /// <summary>
        /// 更新
        /// </summary>
        public void StateUpdate()
        {
            //是否還在載入
#pragma warning disable CS0618 // 類型或成員已經過時
            if (Application.isLoadingLevel)
#pragma warning restore CS0618 // 類型或成員已經過時
            {
                return;
            }

            //通知新的State開始
            if(m_State != null && m_bRunBegin == false)
            {
                m_State.StateBegin();
                m_bRunBegin = true;
            }

            m_State?.StateUpdate();
        }
    }
}