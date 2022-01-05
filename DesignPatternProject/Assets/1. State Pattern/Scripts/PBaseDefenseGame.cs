using System;
using System.Collections;
using UnityEngine;

namespace Assets.State_Pattern.Scripts
{
    public class PBaseDefenseGame
    {
        private static PBaseDefenseGame instance;
        public static PBaseDefenseGame Instance
        {
            get
            {
                if (instance == null) instance = new PBaseDefenseGame();
                return instance;
            }
        }
        private bool m_IsGameOver;

        public void Initinal()
        {
            m_IsGameOver = false;
        }

        public void Release()
        {
        }

        /// <summary>
        /// MonoBehaviour.Update()
        /// </summary>
        public void Update()
        {
        }

        public bool ThisGameIsOver()
        {
            return m_IsGameOver;
        }

        internal void ToGameOver()
        {
            m_IsGameOver = true;
        }
    }
}