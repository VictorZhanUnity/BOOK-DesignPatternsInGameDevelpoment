using System;
using System.Collections;
using UnityEngine;

namespace Assets._4._Mediator_Pattern.Scripts
{
    public class CampSystem:IGameSystem
    {
        //行動力系統
        private APSystem m_ApSystem;
        //角色管理系統
        private CharacterSystem m_CharacterSystem;

        public CampSystem(PBaseDefenseGame PBDGame) : base(PBDGame)
        {
        }

        /// <summary>
        /// 訓練戰士
        /// </summary>
        public void TrainSolider(int soliderID)
        {
            //向APSystem詢問是否有足夠的行動力可以生產
            if(m_ApSystem.CheckTrainSolider(soliderID) == false)
            {
                return;
            }

            //有足夠的行動力，才執行訓練戰士功能
            ISolider newSolider = CreateSolider(soliderID);
            if (newSolider == null) return;

            //再通知APSystem扣除所需要的行動力
            m_ApSystem.DescAP(10);

            //將產生的戰士交由角色管理系統進行管理
            m_CharacterSystem.AddSolider(newSolider);
        }

        /// <summary>
        /// 執行訓練戰士
        /// </summary>
        private ISolider CreateSolider(int soliderID)
        {
            throw new NotImplementedException();
        }

        public void ShowCaptiveCamp()
        {
            m_PBDGame.ShowGameMsg("獲得俘兵營");
        }

        
    }
}