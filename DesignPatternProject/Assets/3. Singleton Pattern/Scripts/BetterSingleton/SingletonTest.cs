using System.Collections;
using UnityEngine;

namespace Assets._3._Singleton_Pattern.Scripts.BetterSingleton
{
    public class SingletonTest : MonoBehaviour
    {
        private void Start()
        {
            ClassWithCounter pObj1 = new ClassWithCounter();
            pObj1.Operator();

            ClassWithCounter pObj2 = new ClassWithCounter();
            pObj2.Operator();

            pObj1.Operator();
        }
    }
}