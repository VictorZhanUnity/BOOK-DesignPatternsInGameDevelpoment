using System.Collections;
using UnityEngine;

namespace Assets._3._Singleton_Pattern.Scripts
{
    public class Singleton
    {
        public string Name { get; set; }

        private static Singleton _instance;
        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    Debug.Log("產生Singleton");
                    _instance = new Singleton();
                }
                return _instance;
            }
        }
        private Singleton()
        {
        }
    }
}