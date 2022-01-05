using System.Collections;
using UnityEngine;

namespace Assets._3._Singleton_Pattern.Scripts
{
    public class SoldierClickScript : MonoBehaviour
    {
        private static PBaseDefenseGame m_PBDGame;

        public static void SetPBDGame(PBaseDefenseGame pBaseDefenseGame)
        {
            m_PBDGame = pBaseDefenseGame;
        }

        public void OnClick()
        {
            m_PBDGame.ShowSoliderInfo();
        }
    }
}