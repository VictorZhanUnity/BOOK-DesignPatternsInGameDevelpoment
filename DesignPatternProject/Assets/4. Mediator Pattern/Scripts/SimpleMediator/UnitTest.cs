using System.Collections;
using UnityEngine;

namespace Assets._4._Mediator_Pattern.Scripts.SimpleMediator
{
    public class UnitTest : MonoBehaviour
    {
        void Start()
        {
            //產生仲介者Mediator
            ConcreateMediator pMediator = new ConcreateMediator();

            //產生兩個Colleague
            ConcreateColleague1 concreateColleague1 = new ConcreateColleague1(pMediator);
            ConcreateColleague2 concreateColleague2 = new ConcreateColleague2(pMediator);

            //將兩個Colleague設定給仲介者Mediator
            pMediator.SetColleague1(concreateColleague1);
            pMediator.SetColleague2(concreateColleague2);

            //兩個Colleague開始執行
            concreateColleague1.Action();
            concreateColleague2.Action();
        }
    }
}