namespace OLiOYouxi.OSystem.OLiOUEvents
{
    using OLiOYouxi.OSystem.OLiOUEvents.UEventsBase;

    /// <summary>
    /// UnityEvents管理
    /// 1.PutIn(写入字典)
    /// 2.LookUp(查询字典并且执行该结果)
    /// </summary>
    public class UEventsManager
    {
        #region -- Private Data --
        private string defaultKey = string.Empty;

        #endregion

        #region -- 单例 --
        static private UEventsManager _UEventsManager = null;
        /// <summary>
        /// 这是单例
        /// </summary>
        static public UEventsManager Instance
        {
            get
            {
                if (_UEventsManager == null)
                {
                    _UEventsManager = new UEventsManager();
                    return _UEventsManager;
                }
                return _UEventsManager;
            }
        }
        #endregion

        #region -- 初始化 --
        private UEventsManager()
        {
            InitData();
        }

        private void InitData()
        {
            //TODO..
            defaultKey = "奥利奥";
        }

        #endregion

        #region -- PutInVoid APIMethods --
        /// <summary>
        /// UEvent数据写入无返回值字典
        /// </summary>
        /// <param name="void">UEvent</param>
        public void PutUEventInVoidDic(VoidEvent @void)
        {
            @void.PutInDic();
        }

        /// <summary>
        /// UEvent数据写入无返回值字典
        /// </summary>
        /// <param name="void">UEvent</param>
        /// <param name="key">键</param>
        public void PutUEventInVoidDic(VoidEvent @void, string key)
        {
            @void.PutInDic(key);
        }

        /// <summary>
        /// UEvent数据写入无返回值字典
        /// </summary>
        /// <param name="void">UEvent</param>
        /// <param name="key">返回键</param>
        public void PutUEventInVoidDic(VoidEvent @void, out string key)
        {
            @void.PutInDic(out key);
        }

        /// <summary>
        /// UEvent数据写入无返回值字典
        /// </summary>
        /// <param name="string">UEvent</param>
        public void PutUEventInVoidDic(StringEvent @string)
        {
            @string.PutInDic();
        }

        /// <summary>
        /// UEvent数据写入无返回值字典
        /// </summary>
        /// <param name="string">UEvent</param>
        /// <param name="key">返回键</param>
        public void PutUEventInVoidDic(StringEvent @string, out string key)
        {
            @string.PutInDic(out key);
        }

        /// <summary>
        /// UEvent数据写入无返回值字典
        /// </summary>
        /// <param name="string">UEvent</param>
        /// <param name="key">键</param>
        public void PutUEventInVoidDic(StringEvent @string, string key)
        {
            @string.PutInDic(key);
        }

        /// <summary>
        /// UEvent数据写入无返回值字典
        /// </summary>
        /// <param name="bool">UEvent</param>
        public void PutUEventInVoidDic(BoolEvent @bool)
        {
            @bool.PutInDic();
        }

        /// <summary>
        /// UEvent数据写入无返回值字典
        /// </summary>
        /// <param name="bool">UEvent</param>
        /// <param name="key">返回键</param>
        public void PutUEventInVoidDic(BoolEvent @bool, out string key)
        {
            @bool.PutInDic(out key);
        }

        /// <summary>
        /// UEvent数据写入无返回值字典
        /// </summary>
        /// <param name="bool">UEvent</param>
        /// <param name="key">键</param>
        public void PutUEventInVoidDic(BoolEvent @bool, string key)
        {
            @bool.PutInDic(key);
        }

        /// <summary>
        /// UEvent数据写入无返回值字典
        /// </summary>
        /// <param name="float">UEvent</param>
        public void PutUEventInVoidDic(FloatEvent @float)
        {
            @float.PutInDic();
        }

        /// <summary>
        /// UEvent数据写入无返回值字典
        /// </summary>
        /// <param name="float">UEvent</param>
        /// <param name="key">返回键</param>
        public void PutUEventInVoidDic(FloatEvent @float, out string key)
        {
            @float.PutInDic(out key);
        }

        /// <summary>
        /// UEvent数据写入无返回值字典
        /// </summary>
        /// <param name="float">UEvent</param>
        /// <param name="key">键</param>
        public void PutUEventInVoidDic(FloatEvent @float, string key)
        {
            @float.PutInDic(key);
        }

        /// <summary>
        /// UEvent数据写入无返回值字典
        /// </summary>
        /// <param name="int">UEvent</param>
        public void PutUEventInVoidDic(IntEvent @int)
        {
            @int.PutInDic();
        }

        /// <summary>
        /// UEvent数据写入无返回值字典
        /// </summary>
        /// <param name="int">UEvent</param>
        /// <param name="key">返回键</param>
        public void PutUEventInVoidDic(IntEvent @int, out string key)
        {
            @int.PutInDic(out key);
        }

        /// <summary>
        /// UEvent数据写入无返回值字典
        /// </summary>
        /// <param name="int">UEvent</param>
        /// <param name="key">键</param>
        public void PutUEventInVoidDic(IntEvent @int, string key)
        {
            @int.PutInDic(key);
        }

        /// <summary>
        /// UEvent数据写入无返回值字典
        /// </summary>
        /// <param name="object">UEvent</param>
        public void PutUEventInVoidDic(ObjectEvent @object)
        {
            @object.PutInDic();
        }

        /// <summary>
        /// UEvent数据写入无返回值字典
        /// </summary>
        /// <param name="object">UEvent</param>
        /// <param name="key">返回键</param>
        public void PutUEventInVoidDic(ObjectEvent @object, out string key)
        {
            @object.PutInDic(out key);
        }

        /// <summary>
        /// UEvent数据写入无返回值字典
        /// </summary>
        /// <param name="object">UEvent</param>
        /// <param name="key">键</param>
        public void PutUEventInVoidDic(ObjectEvent @object, string key)
        {
            @object.PutInDic(key);
        }

        /// <summary>
        /// UEvent数据写入无返回值字典
        /// </summary>
        /// <param name="transform">UEvent</param>
        public void PutUEventInVoidDic(TransformEvent @transform)
        {
            @transform.PutInDic();
        }

        /// <summary>
        /// UEvent数据写入无返回值字典
        /// </summary>
        /// <param name="transform">UEvent</param>
        /// <param name="key">返回键</param>
        public void PutUEventInVoidDic(TransformEvent @transform, out string key)
        {
            @transform.PutInDic(out key);
        }

        /// <summary>
        /// UEvent数据写入无返回值字典
        /// </summary>
        /// <param name="transform">UEvent</param>
        /// <param name="key">键</param>
        public void PutUEventInVoidDic(TransformEvent @transform, string key)
        {
            @transform.PutInDic(key);
        }

        /// <summary>
        /// UEvent数据写入无返回值字典
        /// </summary>
        /// <param name="transformtransform">UEvent</param>
        public void PutUEventInVoidDic(TransformTransformEvent @transformtransform)
        {
            @transformtransform.PutInDic();
        }
        
        /// <summary>
        /// UEvent数据写入无返回值字典
        /// </summary>
        /// <param name="transformtransform">UEvent</param>
        /// <param name="key">返回键</param>
        public void PutUEventInVoidDic(TransformTransformEvent @transformtransform, out string key)
        {
            @transformtransform.PutInDic(out key);
        }
        
        /// <summary>
        /// UEvent数据写入无返回值字典
        /// </summary>
        /// <param name="transformtransform">UEvent</param>
        /// <param name="key">键</param>
        public void PutUEventInVoidDic(TransformTransformEvent @transformtransform, string key)
        {
            @transformtransform.PutInDic(key);
        }

        /// <summary>
        /// UEvent数据写入无返回值字典
        /// </summary>
        /// <param name="event">UEvent</param>
        public void PutUEventInVoidDic(OLiOEvent @event)
        {
            string key = string.Format("{0}{1}", defaultKey, nameof(OLiOEvent), KeyForXY(UnityEngine.Random.Range(1, 20), UnityEngine.Random.Range(1, 99)));
            PutUEventInVoidDic(@event, key);
        }
        
        /// <summary>
        /// UEvent数据写入无返回值字典
        /// </summary>
        /// <param name="event">UEvent</param>
        /// <param name="key">返回键</param>
        public void PutUEventInVoidDic(OLiOEvent @event, out string key)
        {
            key = string.Format("{0}{1}", defaultKey, nameof(OLiOEvent), KeyForXY(UnityEngine.Random.Range(1, 20), UnityEngine.Random.Range(1, 99)));
            @event.PutInDic(key);
        }

        /// <summary>
        /// UEvent数据写入无返回值字典
        /// </summary>
        /// <param name="event">UEvent</param>
        /// <param name="key">键</param>
        public void PutUEventInVoidDic(OLiOEvent @event, string key)
        {
            @event.PutInDic(key);
        }
        
        /// <summary>
        /// UEvent数据写入无返回值字典
        /// </summary>
        /// <typeparam name="T">无返回值委托的参数T</typeparam>
        /// <param name="eventT">UEvent</param>
        public void PutUEventInVoidDic<T>(OLiOEvent<T> @eventT)
        {
            string key = string.Format("{0}{1}", defaultKey, nameof(OLiOEvent<T>), KeyForXY(UnityEngine.Random.Range(1, 20), UnityEngine.Random.Range(1, 99)));
            PutUEventInVoidDic(@eventT, key);
        }

        /// <summary>
        /// UEvent数据写入无返回值字典
        /// </summary>
        /// <param name="event">UEvent</param>
        /// <param name="key">返回键</param>
        public void PutUEventInVoidDic<T>(OLiOEvent<T> @event, out string key)
        {
            key = string.Format("{0}{1}", defaultKey, nameof(OLiOEvent<T>), KeyForXY(UnityEngine.Random.Range(1, 20), UnityEngine.Random.Range(1, 99)));
            @event.PutInDic(key);
        }

        /// <summary>
        /// UEvent数据写入无返回值字典
        /// </summary>
        /// <typeparam name="T">无返回值委托的参数T</typeparam>
        /// <param name="event">UEvent</param>
        /// <param name="key">键</param>
        public void PutUEventInVoidDic<T>(OLiOEvent<T> @event, string key)
        {
            @event.PutInDic<T>(key);
        }

        /// <summary>
        /// UEvent数据写入无返回值字典
        /// </summary>
        /// <typeparam name="T">无返回值委托的参数T</typeparam>
        /// <typeparam name="Y">无返回值委托的参数Y</typeparam>
        /// <param name="eventTY">UEvent</param>
        public void PutUEventInVoidDic<T, Y>(OLiOEvent<T, Y> @eventTY)
        {
            string key = string.Format("{0}{1}", defaultKey, nameof(OLiOEvent<T, Y>), KeyForXY(UnityEngine.Random.Range(1, 20), UnityEngine.Random.Range(1, 99)));
            PutUEventInVoidDic(@eventTY, key);
        }

        /// <summary>
        /// UEvent数据写入无返回值字典
        /// </summary>
        /// <param name="event">UEvent</param>
        /// <param name="key">返回键</param>
        public void PutUEventInVoidDic<T, Y>(OLiOEvent<T, Y> @event, out string key)
        {
            key = string.Format("{0}{1}", defaultKey, nameof(OLiOEvent<T, Y>), KeyForXY(UnityEngine.Random.Range(1, 20), UnityEngine.Random.Range(1, 99)));
            @event.PutInDic(key);
        }

        /// <summary>
        /// UEvent数据写入无返回值字典
        /// </summary>
        /// <typeparam name="T">无返回值委托的参数T</typeparam>
        /// <typeparam name="Y">无返回值委托的参数Y</typeparam>
        /// <param name="eventTY">UEvent</param>
        /// <param name="key">键</param>
        public void PutUEventInVoidDic<T, Y>(OLiOEvent<T, Y> @eventTY, string key)
        {
            @eventTY.PutInDic<T, Y>(key);
        }

        /// <summary>
        /// UEvent数据写入无返回值字典
        /// </summary>
        /// <typeparam name="T">无返回值委托的参数T</typeparam>
        /// <typeparam name="Y">无返回值委托的参数Y</typeparam>
        /// <typeparam name="U">无返回值委托的参数U</typeparam>
        /// <param name="eventTYU">UEvent</param>
        public void PutUEventInVoidDic<T, Y, U>(OLiOEvent<T, Y, U> @eventTYU)
        {
            string key = string.Format("{0}{1}", defaultKey, nameof(OLiOEvent<T, Y, U>), KeyForXY(UnityEngine.Random.Range(1, 20), UnityEngine.Random.Range(1, 99)));
            PutUEventInVoidDic(@eventTYU, key);
        }

        /// <summary>
        /// UEvent数据写入无返回值字典
        /// </summary>
        /// <param name="event">UEvent</param>
        /// <param name="key">返回键</param>
        public void PutUEventInVoidDic<T, Y, U>(OLiOEvent<T, Y, U> @event, out string key)
        {
            key = string.Format("{0}{1}", defaultKey, nameof(OLiOEvent<T, Y, U>), KeyForXY(UnityEngine.Random.Range(1, 20), UnityEngine.Random.Range(1, 99)));
            @event.PutInDic(key);
        }

        /// <summary>
        /// UEvent数据写入无返回值字典
        /// </summary>
        /// <typeparam name="T">无返回值委托的参数T</typeparam>
        /// <typeparam name="Y">无返回值委托的参数Y</typeparam>
        /// <typeparam name="U">无返回值委托的参数U</typeparam>
        /// <param name="eventTYU">UEvent</param>
        /// <param name="key">键</param>
        public void PutUEventInVoidDic<T, Y, U>(OLiOEvent<T, Y, U> @eventTYU, string key)
        {
            @eventTYU.PutInDic<T, Y, U>(key);
        }

        /// <summary>
        /// UEvent数据写入无返回值字典
        /// </summary>
        /// <typeparam name="T">无返回值委托的参数T</typeparam>
        /// <typeparam name="Y">无返回值委托的参数Y</typeparam>
        /// <typeparam name="U">无返回值委托的参数U</typeparam>
        /// <typeparam name="I">无返回值委托的参数I</typeparam>
        /// <param name="eventTYUI">UEvent</param>
        public void PutUEventInVoidDic<T, Y, U, I>(OLiOEvent<T, Y, U, I> @eventTYUI)
        {
            string key = string.Format("{0}{1}", defaultKey, nameof(OLiOEvent<T, Y, U, I>), KeyForXY(UnityEngine.Random.Range(1, 20), UnityEngine.Random.Range(1, 99)));
            PutUEventInVoidDic(@eventTYUI, key);
        }

        /// <summary>
        /// UEvent数据写入无返回值字典
        /// </summary>
        /// <param name="event">UEvent</param>
        /// <param name="key">返回键</param>
        public void PutUEventInVoidDic<T, Y, U, I>(OLiOEvent<T, Y, U, I> @event, out string key)
        {
            key = string.Format("{0}{1}", defaultKey, nameof(OLiOEvent<T, Y, U, I>), KeyForXY(UnityEngine.Random.Range(1, 20), UnityEngine.Random.Range(1, 99)));
            @event.PutInDic(key);
        }

        /// <summary>
        /// UEvent数据写入无返回值字典
        /// </summary>
        /// <typeparam name="T">无返回值委托的参数T</typeparam>
        /// <typeparam name="Y">无返回值委托的参数Y</typeparam>
        /// <typeparam name="U">无返回值委托的参数U</typeparam>
        /// <typeparam name="I">无返回值委托的参数I</typeparam>
        /// <param name="eventTYUI">UEvent</param>
        /// <param name="key">键</param>
        public void PutUEventInVoidDic<T, Y, U, I>(OLiOEvent<T, Y, U, I> @eventTYUI, string key)
        {
            @eventTYUI.PutInDic<T, Y, U, I>(key);
        }

        #endregion

        #region -- LookUpVoid APIMethods --
        /// <summary>
        /// UEvent数据在无返回值字典中查询
        /// </summary>
        /// <param name="key">键</param>
        public void LookUpUEventToVoidDic(string key)
        {
            UEventsStringTriggers.Invoke(key);
        }

        /// <summary>
        /// UEvent数据在无返回值字典中查询
        /// </summary>
        /// <typeparam name="T">无返回值委托的参数一类型</typeparam>
        /// <param name="key">键</param>
        /// <param name="dataa">无返回值委托的参数一</param>
        public void LookUpUEventToVoidDic<T>(string key, T dataa)
        {
            UEventsStringTriggers.Invoke<T>(key, dataa);
        }

        /// <summary>
        /// UEvent数据在无返回值字典中查询
        /// </summary>
        /// <typeparam name="T">无返回值委托的参数一类型</typeparam>
        /// <typeparam name="Y">无返回值委托的参数二类型</typeparam>
        /// <param name="key">键</param>
        /// <param name="dataa">无返回值委托的参数一</param>
        /// <param name="datab">无返回值委托的参数二</param>
        public void LookUpUEventToVoidDic<T, Y>(string key, T dataa, Y datab)
        {
            UEventsStringTriggers.Invoke<T, Y>(key, dataa, datab);
        }

        /// <summary>
        /// UEvent数据在无返回值字典中查询
        /// </summary>
        /// <typeparam name="T">无返回值委托的参数一类型</typeparam>
        /// <typeparam name="Y">无返回值委托的参数二类型</typeparam>
        /// <typeparam name="U">无返回值委托的参数三类型</typeparam>
        /// <param name="key">键</param>
        /// <param name="dataa">无返回值委托的参数一</param>
        /// <param name="datab">无返回值委托的参数二</param>
        /// <param name="datac">无返回值委托的参数三</param>
        public void LookUpUEventToVoidDic<T, Y, U>(string key, T dataa, Y datab, U datac)
        {
            UEventsStringTriggers.Invoke<T, Y, U>(key, dataa, datab, datac);
        }

        /// <summary>
        /// UEvent数据在无返回值字典中查询
        /// </summary>
        /// <typeparam name="T">无返回值委托的参数一类型</typeparam>
        /// <typeparam name="Y">无返回值委托的参数二类型</typeparam>
        /// <typeparam name="U">无返回值委托的参数三类型</typeparam>
        /// <typeparam name="I">无返回值委托的参数四类型</typeparam>
        /// <param name="key">键</param>
        /// <param name="dataa">无返回值委托的参数一</param>
        /// <param name="datab">无返回值委托的参数二</param>
        /// <param name="datac">无返回值委托的参数三</param>
        /// <param name="datad">无返回值委托的参数四</param>
        public void LookUpUEventToVoidDic<T, Y, U, I>(string key, T dataa, Y datab, U datac, I datad)
        {
            UEventsStringTriggers.Invoke<T, Y, U, I>(key, dataa, datab, datac, datad);
        }

        #endregion

        #region -- Helper --
        static private int KeyForXY(int x, int y)
        {
            return y * 1000 + x;
        }

        #endregion
    }
}
