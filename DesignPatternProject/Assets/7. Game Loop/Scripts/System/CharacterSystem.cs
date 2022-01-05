using System;
using System.Collections;
using UnityEngine;

namespace Assets._7._Game_Loop.Scripts
{
    public class CharacterSystem:IGameSystem
    {
        public CharacterSystem(PBaseDefenseGame PBDGame) : base(PBDGame)
        {
        }

        internal int GetEnemyCount()
        {
            return 0;
        }

        internal int GetUnitCount(ENUM_Solider enumSolider)
        {
            return 0;
        }

        internal int GetUnitCount(ENUM_Enemy enumEnemy)
        {
            return 0;
        }

        public void AddSolider(ISolider newSolider)
        {
        }

        internal void UpgradeSolider()
        {
        }

        internal void RemoveSolider(ISolider solider)
        {
        }

        internal void AddEnemy(IEnemy enemy)
        {
        }

        internal void RemoveEnemy(IEnemy enemy)
        {
        }
    }
}