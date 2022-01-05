using System.Collections;
using UnityEngine;

namespace Assets.State_Pattern.Scripts
{
    public class ISceneState
    {
        //狀態名稱
        private string m_StateName = "ISceneState";
        public string StateName
        {
            get { return m_StateName; }
            set { m_StateName = value; }
        }

        //控制者
        protected SceneStateController m_Controller = null;

        //建構者
        public ISceneState(SceneStateController controller)
        {
            m_Controller = controller;
        }

        //開始
        public virtual void StateBegin() { }
        //結束
        public virtual void StateEnd() { }
        /// <summary>
        /// MonoBehaviour.Update()
        /// </summary>
        public virtual void StateUpdate() { }
        
        public override string ToString()
        {
            return $"[I_SceneState: StateName={StateName}";
        }
    }
}