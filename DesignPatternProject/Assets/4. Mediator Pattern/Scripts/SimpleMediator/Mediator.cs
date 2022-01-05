using System;
using System.Collections;
using UnityEngine;

namespace Assets._4._Mediator_Pattern.Scripts.SimpleMediator
{
    public abstract class Mediator
    {
        public abstract void SendMessage(Colleague theColleague, string message);
    }

    public class ConcreateColleague1 : Colleague
    {
        public ConcreateColleague1(Mediator theMediator) : base(theMediator)
        {
        }
        /// <summary>
        /// 執行動作
        /// </summary>
        public void Action()
        {
            m_Mediator.SendMessage(this, "Colleague1發出通知");
        }
        /// <summary>
        /// Mediator通知請求
        /// </summary>
        public override void Request(string message)
        {
            Debug.Log("ConcreateColleague1.Request:" + message);
        }
    }

    public class ConcreateColleague2 : Colleague
    {
        public ConcreateColleague2(Mediator theMediator) : base(theMediator)
        {
        }
        /// <summary>
        /// 執行動作
        /// </summary>
        public void Action()
        {
            m_Mediator.SendMessage(this, "Colleague1發出通知");
        }
        /// <summary>
        /// Mediator通知請求
        /// </summary>
        public override void Request(string message)
        {
            Debug.Log("ConcreateColleague2.Request:" + message);
        }
    }
}