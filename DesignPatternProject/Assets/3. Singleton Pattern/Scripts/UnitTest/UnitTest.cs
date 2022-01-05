using System.Collections;
using UnityEngine;

namespace Assets._3._Singleton_Pattern.Scripts
{
    public class UnitTest : MonoBehaviour
    {

        private void Start()
        {
            Singleton.Instance.Name = "Hello";
            Singleton.Instance.Name = "World";
            Debug.Log(Singleton.Instance.Name);

            //Singleton singleton = new Singleton();
        }
    }
}