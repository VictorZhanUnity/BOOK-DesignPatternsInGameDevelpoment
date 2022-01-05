using System.Collections;
using UnityEngine;

namespace Assets._7._Game_Loop.Scripts
{
    public class SoldierOnClick: MonoBehaviour
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