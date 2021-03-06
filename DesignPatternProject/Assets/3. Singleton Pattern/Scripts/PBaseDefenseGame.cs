using System;
using System.Collections;
using UnityEngine;

namespace Assets._3._Singleton_Pattern.Scripts
{
    /// <summary>
    /// 遊戲主程式 Facade介面
    /// 當需要增減子系統時，只需更改此類別內容即可
    /// </summary>
    public class PBaseDefenseGame
    {
        public void ShowGameMsg(string msg)
        {
            Debug.Log(msg);
        }

        //遊戲子系統
        private GameEventSystem m_GameEventSystem = null;       //遊戲事件系統
        private CampSystem m_CampSystem = null;                 //兵營系統
        private StageSystem m_StageSystem = null;               //關卡系統
        private CharacterSystem m_CharacterSystem = null;       //角色管理系統
        private APSystem m_APSystem = null;                     //行動力系統
        private AchievementSystem m_AchievementSystem = null;   //成就系統

        private bool m_bGameOver;

        /// <summary>
        /// 遊戲子系統進行初始化
        /// </summary>
        public void Initinal()
        {
            m_bGameOver = false;
            m_GameEventSystem = new GameEventSystem(this);
            m_CampSystem = new CampSystem(this);
            m_StageSystem = new StageSystem(this);
            m_CharacterSystem = new CharacterSystem(this);
            m_APSystem = new APSystem(this);
            m_AchievementSystem = new AchievementSystem(this);

            //將子系統注入給其它類別使用
            EnemyAI.SetStageSystem(m_StageSystem);
            SoldierClickScript.SetPBDGame(this);
        }


        internal void ToGameOver()
        {
            this.m_bGameOver = true;
        }

        public void Release()
        {
        }

        /// <summary>
        /// MonoBehaviour.Update()
        /// </summary>
        public void Update()
        {
            m_GameEventSystem.Update();
            m_CampSystem.Update();
            m_StageSystem.Update();
            m_CharacterSystem.Update();
            m_APSystem.Update();
            m_AchievementSystem.Update();
        }

        public bool ThisGameIsOver()
        {
            return m_bGameOver;
        }
        /// <summary>
        /// 目前敵入數量
        /// </summary>
        public int GetEnemyCount()
        {
            if (m_CharacterSystem != null)
            {
                return m_CharacterSystem.GetEnemyCount();
            }
            return 0;
        }

        /// <summary>
        /// 取得各單位的數量
        /// </summary>
        public int GetUnitCount(ENUM_Solider enumSolider)
        {
            return 0;
        }
        /// <summary>
        /// 取得各敵入的數量
        /// </summary>
        public int GetEnemyCount(ENUM_Enemy enumEnemy)
        {
            return 0;
        }

        internal void ShowSoliderInfo()
        {
            Debug.Log("ShowSoliderInfo");
        }
    }

    public enum ENUM_Solider
    {

    }
    public enum ENUM_Enemy
    {

    }
}