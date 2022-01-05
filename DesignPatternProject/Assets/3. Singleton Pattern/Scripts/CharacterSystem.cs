using System;
using System.Collections;
using UnityEngine;

namespace Assets._3._Singleton_Pattern.Scripts
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
    }
}