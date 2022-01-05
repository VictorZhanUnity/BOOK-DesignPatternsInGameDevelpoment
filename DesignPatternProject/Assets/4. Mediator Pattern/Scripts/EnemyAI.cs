using System.Collections;
using UnityEngine;

namespace Assets._4._Mediator_Pattern.Scripts
{
    public class EnemyAI:ICharacterAI
    {
        private static StageSystem m_StageSystem = null;

        public EnemyAI(Character newCharacter, Vector3 attackPosition)
        {
        }



        /// <summary>
        /// 將關卡系統直接注入給EnemyAI使用
        /// </summary>
        public static void SetStageSystem(StageSystem stageSystem)
        {
            m_StageSystem = stageSystem;
        }

        /// <summary>
        /// 是否可以攻擊Heart
        /// </summary>
        public override bool CanAttackHeart()
        {
            //通知少一個Heart
            m_StageSystem.LoseHeart();
            return true;
        }
    }
}