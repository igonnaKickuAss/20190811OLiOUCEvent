namespace OLiOYouxiCore.OSystem.OLiOCEvents
{
    /// <summary>
    /// CustomEvents触发器。
    /// 1.可以注册(Register, RegisterObject)
    /// 2.可以调用(Invoke, InvokeObject)
    /// </summary>
    static internal class CEventsStringTriggers
    {
        #region -- Void Register --
        static internal void Register(string key, CEvents.VoidEvent0 e)
        {
            if (CEventsStringDictionary.Instance.dic_StringVoidEvent0.ContainsKey(key))
                CEventsStringDictionary.Instance.dic_StringVoidEvent0[key] += e;
            else
                CEventsStringDictionary.Instance.dic_StringVoidEvent0.Add(key, e);
        }
        
        static internal void Register<T>(string key, CEvents.VoidEvent1<T> e)
        {
            if (CEventsStringDictionary<T>.Instance.dic_StringVoidEvent1.ContainsKey(key))
                CEventsStringDictionary<T>.Instance.dic_StringVoidEvent1[key] += e;
            else
                CEventsStringDictionary<T>.Instance.dic_StringVoidEvent1.Add(key, e);
        }
        
        static internal void Register<T, Y>(string key, CEvents.VoidEvent2<T, Y> e)
        {
            if (CEventsStringDictionary<T, Y>.Instance.dic_StringVoidEvent2.ContainsKey(key))
                CEventsStringDictionary<T, Y>.Instance.dic_StringVoidEvent2[key] += e;
            else
                CEventsStringDictionary<T, Y>.Instance.dic_StringVoidEvent2.Add(key, e);
        }
        
        static internal void Register<T, Y, U>(string key, CEvents.VoidEvent3<T, Y, U> e)
        {
            if (CEventsStringDictionary<T, Y, U>.Instance.dic_StringVoidEvent3.ContainsKey(key))
                CEventsStringDictionary<T, Y, U>.Instance.dic_StringVoidEvent3[key] += e;
            else
                CEventsStringDictionary<T, Y, U>.Instance.dic_StringVoidEvent3.Add(key, e);
        }

        #endregion

        #region -- Void Invoke --
        static internal void Invoke(string key)
        {
            if (CEventsStringDictionary.Instance.dic_StringVoidEvent0.ContainsKey(key))
                CEventsStringDictionary.Instance.dic_StringVoidEvent0[key].Invoke();
        }
        
        static internal void Invoke<T>(string key, T dataa)
        {
            if (CEventsStringDictionary<T>.Instance.dic_StringVoidEvent1.ContainsKey(key))
                CEventsStringDictionary<T>.Instance.dic_StringVoidEvent1[key].Invoke(dataa);
        }
        
        static internal void Invoke<T, Y>(string key, T dataa, Y datab)
        {
            if (CEventsStringDictionary<T, Y>.Instance.dic_StringVoidEvent2.ContainsKey(key))
                CEventsStringDictionary<T, Y>.Instance.dic_StringVoidEvent2[key].Invoke(dataa, datab);
        }
        
        static internal void Invoke<T, Y, U>(string key, T dataa, Y datab, U datac)
        {
            if (CEventsStringDictionary<T, Y, U>.Instance.dic_StringVoidEvent3.ContainsKey(key))
                CEventsStringDictionary<T, Y, U>.Instance.dic_StringVoidEvent3[key].Invoke(dataa, datab, datac);
        }

        #endregion

        #region -- Object Register --
        static internal void RegisterObject(string key, CEvents.ObjectEvent0 e)
        {
            if (CEventsStringDictionary.Instance.dic_StringObjectEvent0.ContainsKey(key))
                CEventsStringDictionary.Instance.dic_StringObjectEvent0[key] += e;
            else
                CEventsStringDictionary.Instance.dic_StringObjectEvent0.Add(key, e);
        }

        static internal void RegisterObject<T>(string key, CEvents.ObjectEvent1<T> e)
        {
            if (CEventsStringDictionary<T>.Instance.dic_StringObjectEvent1.ContainsKey(key))
                CEventsStringDictionary<T>.Instance.dic_StringObjectEvent1[key] += e;
            else
                CEventsStringDictionary<T>.Instance.dic_StringObjectEvent1.Add(key, e);
        }

        static internal void RegisterObject<T, Y>(string key, CEvents.ObjectEvent2<T, Y> e)
        {
            if (CEventsStringDictionary<T, Y>.Instance.dic_StringObjectEvent2.ContainsKey(key))
                CEventsStringDictionary<T, Y>.Instance.dic_StringObjectEvent2[key] += e;
            else
                CEventsStringDictionary<T, Y>.Instance.dic_StringObjectEvent2.Add(key, e);
        }

        static internal void RegisterObject<T, Y, U>(string key, CEvents.ObjectEvent3<T, Y, U> e)
        {
            if (CEventsStringDictionary<T, Y, U>.Instance.dic_StringObjectEvent3.ContainsKey(key))
                CEventsStringDictionary<T, Y, U>.Instance.dic_StringObjectEvent3[key] += e;
            else
                CEventsStringDictionary<T, Y, U>.Instance.dic_StringObjectEvent3.Add(key, e);
        }

        #endregion

        #region -- Object Invoke --
        static internal object InvokeObject(string key)
        {
            return CEventsStringDictionary.Instance.dic_StringObjectEvent0.ContainsKey(key) ? CEventsStringDictionary.Instance.dic_StringObjectEvent0[key].Invoke() : null;
        }

        static internal object InvokeObject<T>(string key, T dataa)
        {
            return CEventsStringDictionary<T>.Instance.dic_StringObjectEvent1.ContainsKey(key) ? CEventsStringDictionary<T>.Instance.dic_StringObjectEvent1[key].Invoke(dataa) : null;
        }

        static internal object InvokeObject<T, Y>(string key, T dataa, Y datab)
        {
            return CEventsStringDictionary<T, Y>.Instance.dic_StringObjectEvent2.ContainsKey(key) ? CEventsStringDictionary<T, Y>.Instance.dic_StringObjectEvent2[key].Invoke(dataa, datab) : null;
        }

        static internal object InvokeObject<T, Y, U>(string key, T dataa, Y datab, U datac)
        {
            return CEventsStringDictionary<T, Y, U>.Instance.dic_StringObjectEvent3.ContainsKey(key) ? CEventsStringDictionary<T, Y, U>.Instance.dic_StringObjectEvent3[key].Invoke(dataa, datab, datac) : null;
        }

        #endregion
    }
}
