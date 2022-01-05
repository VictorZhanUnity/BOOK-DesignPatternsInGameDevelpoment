﻿using System.Collections;
using UnityEngine;

namespace Assets._3._Singleton_Pattern.Scripts
{
    public class ClassWithCounter 
    {
        protected static int m_ObjCounter = 0;
        protected bool m_bEnable = false;

        public ClassWithCounter()
        {
            m_ObjCounter++;
            m_bEnable = (m_ObjCounter == 1);
            if(m_bEnable == false)
            {
                Debug.LogError($"目前物件數[{m_ObjCounter}]，超過1個!!");
            }
        }

        public void Operator()
        {
            if(m_bEnable == false)
            {
                return;
            }
            Debug.Log("可以執行");
        }
    }
}