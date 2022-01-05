using System.Collections;
using UnityEngine;

namespace Assets._7._Game_Loop.Scripts
{
    public class EnemyKilledObserverStageScore: IGameEventObserver
    {
        private StageSystem m_StageSystem;


        public EnemyKilledObserverStageScore(StageSystem stageSystem)
        {
            m_StageSystem = stageSystem;
        }
    }
}