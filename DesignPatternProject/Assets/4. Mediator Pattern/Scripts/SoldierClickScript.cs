using System.Collections;
using UnityEngine;

namespace Assets._4._Mediator_Pattern.Scripts
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