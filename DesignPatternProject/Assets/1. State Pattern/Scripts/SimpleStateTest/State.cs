using System.Collections;
using UnityEngine;

namespace Assets.State_Pattern.Scripts
{
    /// <summary>
    /// State狀態介面類別
    /// </summary>
    public abstract class State 
    {
        protected Context m_Context = null;
        public State(Context theContext)
        {
            m_Context = theContext;
        }

        public abstract void Hanlde(int Value);
    }

    /// <summary>
    /// 狀態擁有者
    /// </summary>
    public class Context
    {
        State m_State = null;

        public void Request(int value)
        {
            m_State.Hanlde(value);
        }

        public void SetState(State theState)
        {
            Debug.Log("Context.SetState: " + theState);
            m_State = theState;
        }

    }

    /// <summary>
    /// 具體狀態類別 - A
    /// </summary>
    public class ConcreteStateA : State
    {
        public ConcreteStateA(Context theContext) : base(theContext){}
        public override void Hanlde(int Value)
        {
            Debug.Log("ConcreteStateA.Hanlde");
            if (Value > 10)
            {
                m_Context.SetState(new ConcreteStateB(m_Context));
            }
        }
    }
    /// <summary>
    /// 具體狀態類別 - B
    /// </summary>
    public class ConcreteStateB : State
    {
        public ConcreteStateB(Context theContext) : base(theContext){}
        public override void Hanlde(int Value)
        {
            Debug.Log("ConcreteStateB.Hanlde");
            if (Value > 20)
            {
                m_Context.SetState(new ConcreteStateC(m_Context));
            }
        }
    }
    /// <summary>
    /// 具體狀態類別 - C
    /// </summary>
    public class ConcreteStateC : State
    {
        public ConcreteStateC(Context theContext) : base(theContext){}
        public override void Hanlde(int Value)
        {
            Debug.Log("ConcreteStateC.Hanlde");
            if (Value > 30)
            {
                m_Context.SetState(new ConcreteStateA(m_Context));
            }
        }
    }
}