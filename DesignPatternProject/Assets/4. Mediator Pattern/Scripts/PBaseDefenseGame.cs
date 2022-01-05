using System;
using System.Collections;
using UnityEngine;

namespace Assets._4._Mediator_Pattern.Scripts
{
    /// <summary>
    /// 遊戲主程式 Facade介面 - 做為Mediator，子系統彼此間溝通 (韓總機概念)
    /// 當需要增減子系統時，只需更改此類別內容即可
    /// </summary>
    public class PBaseDefenseGame
    {
        private static PBaseDefenseGame instance;
        public PBaseDefenseGame Instance
        {
            get
            {
                if (instance == null) instance = new PBaseDefenseGame();
                return instance;
            }
        }
        /// <summary>
        /// 建構函式設為private，確保此物件只會有單一個
        /// </summary>
        private PBaseDefenseGame() { }



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

        //遊戲介面
        private CampInfoUI m_CampInfoUI = null;                 //兵營資訊

        internal void ChangeToMainMenu()
        {
            throw new NotImplementedException();
        }

        internal void GamePause()
        {
            throw new NotImplementedException();
        }

        private SoliderInfoUI m_SoliderInfoUI = null;           //Solider資訊
        private GameStateInfoUI m_GameStateInfoUI = null;       //遊戲資訊
        private GamePauseUI m_GamePauseUI = null;               //遊戲暫停


        private bool m_bGameOver;


        internal void ShowNowStageLv(int m_NowStageLv)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 遊戲子系統進行初始化
        /// </summary>
        public void Initinal()
        {
            m_bGameOver = false;

            //遊戲子系統
            m_GameEventSystem = new GameEventSystem(this);
            m_CampSystem = new CampSystem(this);
            m_StageSystem = new StageSystem(this);
            m_CharacterSystem = new CharacterSystem(this);
            m_APSystem = new APSystem(this);
            m_AchievementSystem = new AchievementSystem(this);

            //遊戲介面
            m_CampInfoUI = new CampInfoUI(this);
            m_SoliderInfoUI = new SoliderInfoUI(this);
            m_GameStateInfoUI = new GameStateInfoUI(this);
            m_GamePauseUI = new GamePauseUI(this);

            //將子系統注入給其它類別使用
            //若用Mediator模式，就不用此種相依性注入的方法，一切都透過Mediator來互相呼叫
            EnemyAI.SetStageSystem(m_StageSystem);

            SoldierClickScript.SetPBDGame(this);
        }

        internal void ShowHeart(int m_NowHeart)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 升級Solider
        /// </summary>
        public void UpgradeSolider()
        {
            m_CharacterSystem?.UpgradeSolider();
        }

        /// <summary>
        /// 增加Solider
        /// </summary>
        public void AddSolider(ISolider solider)
        {
            m_CharacterSystem?.AddSolider(solider);
        }
        /// <summary>
        /// 移除Solider
        /// </summary>
        public void RemoveSolider(ISolider solider)
        {
            m_CharacterSystem?.RemoveSolider(solider);
        }
        /// <summary>
        /// 增加Enemy
        /// </summary>
        public void AddEnemy(IEnemy enemy)
        {
            m_CharacterSystem?.AddEnemy(enemy);
        }
        /// <summary>
        /// 移除Enemy
        /// </summary>
        public void RemoveEnemy(IEnemy enemy)
        {
            m_CharacterSystem?.RemoveEnemy(enemy);
        }

        /// <summary>
        /// 顯示兵營資訊
        /// </summary>
        public void ShowCampInfo(ICamp camp)
        {
            m_CampInfoUI?.ShowInfo(camp);
            m_SoliderInfoUI.Hide();
        }
        /// <summary>
        /// 顯示Solider資訊
        /// </summary>
        public void ShowSoliderInfo(ISolider solider)
        {
            m_SoliderInfoUI.ShowInfo(solider);
            m_CampInfoUI.Hide();
        }

        /// <summary>
        /// 註冊遊戲事件
        /// </summary>
        public void RegisterGameEvent(ENUM_GameEvent eNUM_GameEvent, IGameEventObserver observer)
        {
            m_GameEventSystem.RegisterObserver(eNUM_GameEvent, observer);
        }

        /// <summary>
        /// 通知遊戲事件
        /// </summary>
        public void NotifyGameEvent(ENUM_GameEvent eNUM_GameEvent, System.Object param)
        {
            m_GameEventSystem.NotifySubject(eNUM_GameEvent, param);
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
        Null
    }
    public enum ENUM_Enemy
    {
        Null
    }

    public enum ENUM_GameEvent
    {
        EnemyKilled,
        NewStage
    }
}