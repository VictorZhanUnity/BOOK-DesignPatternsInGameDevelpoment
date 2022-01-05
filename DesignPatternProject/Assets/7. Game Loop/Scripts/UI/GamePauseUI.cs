using System.Collections;
using UnityEngine;

namespace Assets._7._Game_Loop.Scripts
{
    public class GamePauseUI : IUserInterface
    {
        public GamePauseUI(PBaseDefenseGame PBDGame) : base(PBDGame)
        {
            m_PBDGame = PBDGame;
        }
    }
}