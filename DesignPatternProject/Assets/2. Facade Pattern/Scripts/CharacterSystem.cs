using System;
using System.Collections;
using UnityEngine;

namespace Assets._2._Facade_Pattern.Scripts
{
    public class CharacterSystem
    {
        private PBaseDefenseGame pBaseDefenseGame;

        public CharacterSystem(PBaseDefenseGame pBaseDefenseGame)
        {
            this.pBaseDefenseGame = pBaseDefenseGame;
        }

        public void Init()
        {
            Debug.Log("CharacterSystem.Init()");
        }

        public void Update()
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