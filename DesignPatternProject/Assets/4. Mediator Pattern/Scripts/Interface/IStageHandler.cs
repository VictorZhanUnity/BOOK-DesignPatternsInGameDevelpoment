using System.Collections;
using UnityEngine;

namespace Assets._4._Mediator_Pattern.Scripts
{
    public class IStageHandler
    {
        public virtual IStageHandler CheckStage() { return new IStageHandler(); }

        public virtual void Initialize() { }
        public virtual void Release() { }
        public virtual void Update() { }
    }
}