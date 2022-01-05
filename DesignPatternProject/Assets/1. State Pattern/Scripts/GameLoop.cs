using System;
using System.Collections;
using UnityEngine;

namespace Assets.State_Pattern.Scripts
{
    /// <summary>
    /// 遊戲主迴圈
    /// </summary>
    public class GameLoop : MonoBehaviour
    {
        /// <summary>
        /// 場景控制器
        /// </summary>
        private SceneStateController m_SceneStateController = new SceneStateController();

        private void Awake()
        {
            //轉換場景時不會刪除此物件
            GameObject.DontDestroyOnLoad(this.gameObject);

            //亂數種子
            UnityEngine.Random.InitState((int)DateTime.Now.Ticks);
        }

        private void Start()
        {
            //設定起始的場景
            m_SceneStateController.SetState(new StartState(m_SceneStateController), "");
        }

        private void Update()
        {
            m_SceneStateController.StateUpdate();
        }
    }
}