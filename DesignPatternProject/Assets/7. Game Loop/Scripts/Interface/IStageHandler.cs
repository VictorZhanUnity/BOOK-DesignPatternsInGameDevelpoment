using System.Collections;
using UnityEngine;

namespace Assets._7._Game_Loop.Scripts
{
    public class IStageHandler
    {
        public virtual IStageHandler CheckStage() { return new IStageHandler(); }

        public virtual void Initialize() { }
        public virtual void Release() { }
        public virtual void Update() { }
    }
}