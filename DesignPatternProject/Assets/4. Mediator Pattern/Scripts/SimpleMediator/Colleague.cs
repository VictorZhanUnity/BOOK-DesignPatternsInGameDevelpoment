using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets._4._Mediator_Pattern.Scripts.SimpleMediator
{
    public abstract class Colleague
    {
        /// <summary>
        /// 透過Mediator對外部溝通
        /// </summary>
        protected Mediator m_Mediator = null;
        public Colleague (Mediator theMediator)
        {
            m_Mediator = theMediator;
        }

        /// <summary>
        /// Mediator通知請求
        /// </summary>
        public abstract void Request(string message);
    }
}
