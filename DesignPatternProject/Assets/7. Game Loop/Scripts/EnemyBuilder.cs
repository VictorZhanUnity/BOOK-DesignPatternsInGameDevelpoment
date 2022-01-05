using System.Collections;
using UnityEngine;

namespace Assets._7._Game_Loop.Scripts
{
    public class EnemyBuilder:ICharacterBuilder
    {
        private BuildParam m_BuildParam = new BuildParam();
        //加入AI
        public override void AddAI()
        {
            // Enemy有儲存關卡系統，知道目前是哪個關卡
            EnemyAI theAI = new EnemyAI(m_BuildParam.NewCharacter, m_BuildParam.AttAckPosition);
            m_BuildParam.NewCharacter.SetAI(theAI);
        }
    }

    public class BuildParam
    {
        public Character NewCharacter
        {
            get { return new Character(); }
        }
        public Vector3 AttAckPosition
        {
            get { return Vector3.zero; }
        }
    }

    public class Character
    {
        public void SetAI(EnemyAI enemyAI) { }
    }
}