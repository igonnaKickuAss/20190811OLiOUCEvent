namespace OLiOYouxiCore.OSystem.OLiOUEvents
{
    using OLiOYouxiCore.OSystem.OLiOUEvents.UEventsBase;

    /// <summary>
    /// UnityEvents触发器
    /// 1.可以注册， 若有相同键则覆盖(Register)
    /// 2.可以调用(Invoke)
    /// </summary>
    static internal class UEventsStringTriggers
    {
        #region -- Void Register --
        static internal void Register(string key, OLiOEvent e)
        {
            if (UEventsStringDictionary.Instance.dic_StringOLiOEvent.ContainsKey(key))
                UEventsStringDictionary.Instance.dic_StringOLiOEvent[key] = e;
            else
                UEventsStringDictionary.Instance.dic_StringOLiOEvent.Add(key, e);
        }

        static internal void Register<T>(string key, OLiOEvent<T> e)
        {
            if (UEventsStringDictionary<T>.Instance.dic_StringOLiOEventT.ContainsKey(key))
                UEventsStringDictionary<T>.Instance.dic_StringOLiOEventT[key] = e;
            else
                UEventsStringDictionary<T>.Instance.dic_StringOLiOEventT.Add(key, e);
        }

        static internal void Register<T, Y>(string key, OLiOEvent<T, Y> e)
        {
            if (UEventsStringDictionary<T, Y>.Instance.dic_StringOLiOEventTY.ContainsKey(key))
                UEventsStringDictionary<T, Y>.Instance.dic_StringOLiOEventTY[key] = e;
            else
                UEventsStringDictionary<T, Y>.Instance.dic_StringOLiOEventTY.Add(key, e);
        }

        static internal void Register<T, Y, U>(string key, OLiOEvent<T, Y, U> e)
        {
            if (UEventsStringDictionary<T, Y, U>.Instance.dic_StringOLiOEventTYU.ContainsKey(key))
                UEventsStringDictionary<T, Y, U>.Instance.dic_StringOLiOEventTYU[key] = e;
            else
                UEventsStringDictionary<T, Y, U>.Instance.dic_StringOLiOEventTYU.Add(key, e);
        }

        static internal void Register<T, Y, U, I>(string key, OLiOEvent<T, Y, U, I> e)
        {
            if (UEventsStringDictionary<T, Y, U, I>.Instance.dic_StringOLiOEventTYUI.ContainsKey(key))
                UEventsStringDictionary<T, Y, U, I>.Instance.dic_StringOLiOEventTYUI[key] = e;
            else
                UEventsStringDictionary<T, Y, U, I>.Instance.dic_StringOLiOEventTYUI.Add(key, e);
        }

        #endregion

        #region -- Void Invoke --
        static internal void Invoke(string key)
        {
            if (UEventsStringDictionary.Instance.dic_StringOLiOEvent.ContainsKey(key))
                UEventsStringDictionary.Instance.dic_StringOLiOEvent[key].Invoke();
        }

        static internal void Invoke<T>(string key, T dataa)
        {
            if (UEventsStringDictionary<T>.Instance.dic_StringOLiOEventT.ContainsKey(key))
                UEventsStringDictionary<T>.Instance.dic_StringOLiOEventT[key].Invoke(dataa);
        }

        static internal void Invoke<T, Y>(string key, T dataa, Y datab)
        {
            if (UEventsStringDictionary<T, Y>.Instance.dic_StringOLiOEventTY.ContainsKey(key))
                UEventsStringDictionary<T, Y>.Instance.dic_StringOLiOEventTY[key].Invoke(dataa, datab);
        }

        static internal void Invoke<T, Y, U>(string key, T dataa, Y datab, U datac)
        {
            if (UEventsStringDictionary<T, Y, U>.Instance.dic_StringOLiOEventTYU.ContainsKey(key))
                UEventsStringDictionary<T, Y, U>.Instance.dic_StringOLiOEventTYU[key].Invoke(dataa, datab, datac);
        }

        static internal void Invoke<T, Y, U, I>(string key, T dataa, Y datab, U datac, I datad)
        {
            if (UEventsStringDictionary<T, Y, U, I>.Instance.dic_StringOLiOEventTYUI.ContainsKey(key))
                UEventsStringDictionary<T, Y, U, I>.Instance.dic_StringOLiOEventTYUI[key].Invoke(dataa, datab, datac, datad);
        }

        #endregion
    }
}
