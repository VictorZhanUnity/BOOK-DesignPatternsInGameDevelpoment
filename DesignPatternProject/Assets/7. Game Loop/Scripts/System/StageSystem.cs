using System;
using System.Collections;
using UnityEngine;

namespace Assets._7._Game_Loop.Scripts
{
    public class StageSystem:IGameSystem
    {
        private IStageHandler m_NowStageData = new IStageHandler();
        private int m_NowStageLv;
        private int m_NowHeart;

        public StageSystem(PBaseDefenseGame PBDGame) : base(PBDGame)
        {
            Initiallize();
        }

        public override void Initiallize()
        {
            //註冊遊戲事件
            m_PBDGame.RegisterGameEvent(ENUM_GameEvent.EnemyKilled, new EnemyKilledObserverStageScore(this));
        }

        public override void Update()
        {
            //更新目前的關卡
            m_NowStageData.Update();

            //如果目前敵人數量為0，切換下一個關卡
            if(m_PBDGame.GetEnemyCount() == 0)
            {
                //取得下一個關卡資訊
                IStageHandler newStageData = m_NowStageData.CheckStage();

                //是否為新的關卡
                if(m_NowStageData != newStageData)
                {
                    m_NowStageData = newStageData;
                    NotifyNewStage();
                }
            }
        }

        /// <summary>
        /// 通知Mediator目前已更換為新關卡
        /// </summary>
        private void NotifyNewStage()
        {
            m_PBDGame.ShowGameMsg("新的關卡");
            m_NowStageLv++;

            //顯示關卡等級
            m_PBDGame.ShowNowStageLv(m_NowStageLv);

            //通知Solider進行升級
            m_PBDGame.UpgradeSolider();

            //事件
            m_PBDGame.NotifyGameEvent(ENUM_GameEvent.NewStage, null);
        }
        
        /// <summary>
        /// 通知關卡更新
        /// </summary>
        public void LoseHeart()
        {
            m_NowHeart--;
            m_PBDGame.ShowHeart(m_NowHeart);
        }
    }
}