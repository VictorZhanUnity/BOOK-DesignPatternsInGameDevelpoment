using System;
using System.Collections;
using UnityEngine;

namespace Assets._4._Mediator_Pattern.Scripts
{
    public class CharacterSystem:IGameSystem
    {
        public CharacterSystem(PBaseDefenseGame PBDGame) : base(PBDGame)
        {
        }

        internal int GetEnemyCount()
        {
            throw new NotImplementedException();
        }

        internal int GetUnitCount(ENUM_Solider enumSolider)
        {
            throw new NotImplementedException();
        }

        internal int GetUnitCount(ENUM_Enemy enumEnemy)
        {
            throw new NotImplementedException();
        }

        public void AddSolider(ISolider newSolider)
        {
        }

        internal void UpgradeSolider()
        {
            throw new NotImplementedException();
        }

        internal void RemoveSolider(ISolider solider)
        {
            throw new NotImplementedException();
        }

        internal void AddEnemy(IEnemy enemy)
        {
            throw new NotImplementedException();
        }

        internal void RemoveEnemy(IEnemy enemy)
        {
            throw new NotImplementedException();
        }
    }
}