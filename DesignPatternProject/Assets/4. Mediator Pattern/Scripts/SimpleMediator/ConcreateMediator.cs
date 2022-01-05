using System.Collections;
using UnityEngine;

namespace Assets._4._Mediator_Pattern.Scripts.SimpleMediator
{
    public class ConcreateMediator : Mediator
    {
        private ConcreateColleague1 m_Colleague1 = null;
        private ConcreateColleague2 m_Colleague2 = null;


        public void SetColleague1(ConcreateColleague1 theColleague)
        {
            m_Colleague1 = theColleague;
        }
        public void SetColleague2(ConcreateColleague2 theColleague)
        {
            m_Colleague2 = theColleague;
        }

        /// <summary>
        /// 收到由Colleague通知請求
        /// </summary>
        public override void SendMessage(Colleague theColleague, string message)
        {
            if (theColleague == m_Colleague1) m_Colleague2.Request(message);
            if (theColleague == m_Colleague2) m_Colleague1.Request(message);
        }

    }
}