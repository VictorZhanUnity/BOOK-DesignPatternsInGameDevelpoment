using System.Collections;
using UnityEngine;

namespace Assets.State_Pattern.Scripts
{
    public class StateTest : MonoBehaviour
    {
        private void Start()
        {
            UnitTest();
        }

        private void UnitTest()
        {
            Context theContext = new Context();
            theContext.SetState(new ConcreteStateA(theContext));

            theContext.Request(5);
            theContext.Request(15);
            theContext.Request(25);
            theContext.Request(35);
        }
    }
}