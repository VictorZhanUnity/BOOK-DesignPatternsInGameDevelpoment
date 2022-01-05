using System.Collections;
using UnityEngine;

namespace Assets._4._Mediator_Pattern.Scripts
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