using System;
using System.Collections;
using UnityEngine;

namespace Assets._7._Game_Loop.Scripts
{
    /// <summary>
    /// 遊戲主迴圈生命週期的控制器，來對其它物件進行Update
    /// </summary>
    public class GameLoop : MonoBehaviour
    {
        //場景控制器
        private SceneStateController m_SceneStateController = new SceneStateController();

        private void Awake()
        {
            DontDestroyOnLoad(this.gameObject);

            UnityEngine.Random.InitState( (int)DateTime.Now.Ticks); 
        }

        void Start()
        {
            //設定起始場景
            m_SceneStateController.SetState(new StartState(m_SceneStateController), "");
        }
        
        
        void Update()
        {
            m_SceneStateController.StateUpdate();
        }
    }
}