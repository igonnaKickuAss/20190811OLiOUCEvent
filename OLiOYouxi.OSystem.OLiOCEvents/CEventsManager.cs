namespace OLiOYouxiCore.OSystem.OLiOCEvents
{
    using UnityEngine;
    using System;

    /// <summary>
    /// CustomEvents管理
    /// 1.PutIn(写入字典)
    /// 2.LookUp(查询字典并且执行该结果)
    /// </summary>
    public class CEventsManager
    {
        #region -- Private Data --
        private string defaultKey = string.Empty;

        #endregion

        #region -- 单例 --
        static private CEventsManager _CEventsManager = null;
        /// <summary>
        /// 这是单例
        /// </summary>
        static public CEventsManager Instance
        {
            get
            {
                if (_CEventsManager == null)
                {
                    _CEventsManager = new CEventsManager();
                    return _CEventsManager;
                }
                return _CEventsManager;
            }
        }
        #endregion

        #region -- 初始化 --
        private CEventsManager()
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
        /// CEvent数据写入无返回值字典
        /// </summary>
        public void PutCEventInVoidDic()
        {
            PutCEventInVoidDic(defaultKey, () =>
            {
                Debug.Log(string.Format(
                    "<color=green>{0}</color>：已经调用(这是一个无参无返回值函数)。",
                    defaultKey
                    ));
            });
        }

        /// <summary>
        /// CEvent数据写入无返回值字典
        /// </summary>
        /// <param name="key">键</param>
        /// <param name="ve0A">无参无返回值委托</param>
        public void PutCEventInVoidDic(string key, Action ve0A)
        {
            CEvents.VoidEvent0 @void = new CEvents.VoidEvent0(ve0A);
            CEventsStringTriggers.Register(key, @void);
        }

        /// <summary>
        /// CEvent数据写入无返回值字典
        /// </summary>
        /// <typeparam name="T">无返回值委托的参数T</typeparam>
        /// <param name="key">键</param>
        /// <param name="ve1A">无返回值委托</param>
        public void PutCEventInVoidDic<T>(string key, Action<T> ve1A)
        {
            CEvents.VoidEvent1<T> @void = new CEvents.VoidEvent1<T>(ve1A);
            CEventsStringTriggers.Register<T>(key, @void);
        }

        /// <summary>
        /// CEvent数据写入无返回值字典
        /// </summary>
        /// <typeparam name="T">无返回值委托的参数T</typeparam>
        /// <typeparam name="Y">无返回值委托的参数Y</typeparam>
        /// <param name="key">键</param>
        /// <param name="ve2A">无返回值委托</param>
        public void PutCEventInVoidDic<T, Y>(string key, Action<T, Y> ve2A)
        {
            CEvents.VoidEvent2<T, Y> @void = new CEvents.VoidEvent2<T, Y>(ve2A);
            CEventsStringTriggers.Register<T, Y>(key, @void);
        }

        /// <summary>
        /// CEvent数据写入无返回值字典
        /// </summary>
        /// <typeparam name="T">无返回值委托的参数T</typeparam>
        /// <typeparam name="Y">无返回值委托的参数Y</typeparam>
        /// <typeparam name="U">无返回值委托的参数U</typeparam>
        /// <param name="key">键</param>
        /// <param name="ve3A">无返回值委托</param>
        public void PutCEventInVoidDic<T, Y, U>(string key, Action<T, Y, U> ve3A)
        {
            CEvents.VoidEvent3<T, Y, U> @void = new CEvents.VoidEvent3<T, Y, U>(ve3A);
            CEventsStringTriggers.Register<T, Y, U>(key, @void);
        }
        
        #endregion

        #region -- LookUpVoid APIMethods --
        /// <summary>
        /// CEvent数据在无返回值字典中查询
        /// </summary>
        public void LookUpCEventToVoidDic()
        {
            LookUpCEventToVoidDic(defaultKey);
        }

        /// <summary>
        /// CEvent数据在无返回值字典中查询
        /// </summary>
        /// <param name="key">键</param>
        public void LookUpCEventToVoidDic(string key)
        {
            CEventsStringTriggers.Invoke(key);
        }

        /// <summary>
        /// CEvent数据在无返回值字典中查询
        /// </summary>
        /// <typeparam name="T">无返回值委托的参数一类型</typeparam>
        /// <param name="key">键</param>
        /// <param name="obj0">无返回值委托的参数一</param>
        public void LookUpCEventToVoidDic<T>(string key, T obj0)
        {
            CEventsStringTriggers.Invoke<T>(key, obj0);
        }

        /// <summary>
        /// CEvent数据在无返回值字典中查询
        /// </summary>
        /// <typeparam name="T">无返回值委托的参数一类型</typeparam>
        /// <typeparam name="Y">无返回值委托的参数二类型</typeparam>
        /// <param name="key">键</param>
        /// <param name="obj0">无返回值委托的参数一</param>
        /// <param name="obj1">无返回值委托的参数二</param>
        public void LookUpCEventToVoidDic<T, Y>(string key, T obj0, Y obj1)
        {
            CEventsStringTriggers.Invoke<T, Y>(key, obj0, obj1);
        }

        /// <summary>
        /// CEvent数据在无返回值字典中查询
        /// </summary>
        /// <typeparam name="T">无返回值委托的参数一类型</typeparam>
        /// <typeparam name="Y">无返回值委托的参数二类型</typeparam>
        /// <typeparam name="U">无返回值委托的参数三类型</typeparam>
        /// <param name="key">键</param>
        /// <param name="obj0">无返回值委托的参数一</param>
        /// <param name="obj1">无返回值委托的参数二</param>
        /// <param name="obj2">无返回值委托的参数三</param>
        public void LookUpCEventToVoidDic<T, Y, U>(string key, T obj0, Y obj1, U obj2)
        {
            CEventsStringTriggers.Invoke<T, Y, U>(key, obj0, obj1, obj2);
        }

        #endregion

        #region -- PutInObject APIMethods --
        /// <summary>
        /// CEvent数据写入有返回值字典
        /// </summary>
        public void PutCEventInObjectDic()
        {
            PutCEventInObjectDic(defaultKey, () =>
            {
                Debug.Log(string.Format(
                    "<color=green>{0}</color>：已经调用(这是一个无参有返回值函数)。",
                    defaultKey
                    ));
                return null;
            });
        }

        /// <summary>
        /// CEvent数据写入有返回值字典
        /// </summary>
        /// <param name="key">键</param>
        /// <param name="oe0F">无参有返回值委托</param>
        public void PutCEventInObjectDic(string key, Func<object> oe0F)
        {
            CEvents.ObjectEvent0 @object = new CEvents.ObjectEvent0(oe0F);
            CEventsStringTriggers.RegisterObject(key, @object);
        }

        /// <summary>
        /// CEvent数据写入有返回值字典
        /// </summary>
        /// <typeparam name="T">有返回值委托的参数T</typeparam>
        /// <param name="key">键</param>
        /// <param name="oe1F">有返回值委托</param>
        public void PutCEventInObjectDic<T>(string key, Func<T, object> oe1F)
        {
            CEvents.ObjectEvent1<T> @object = new CEvents.ObjectEvent1<T>(oe1F);
            CEventsStringTriggers.RegisterObject<T>(key, @object);
        }

        /// <summary>
        /// CEvent数据写入有返回值字典
        /// </summary>
        /// <typeparam name="T">有返回值委托的参数T</typeparam>
        /// <typeparam name="Y">有返回值委托的参数Y</typeparam>
        /// <param name="key">键</param>
        /// <param name="oe2F">有返回值委托</param>
        public void PutCEventInObjectDic<T, Y>(string key, Func<T, Y, object> oe2F)
        {
            CEvents.ObjectEvent2<T, Y> @object = new CEvents.ObjectEvent2<T, Y>(oe2F);
            CEventsStringTriggers.RegisterObject<T, Y>(key, @object);
        }

        /// <summary>
        /// CEvent数据写入有返回值字典
        /// </summary>
        /// <typeparam name="T">有返回值委托的参数T</typeparam>
        /// <typeparam name="Y">有返回值委托的参数Y</typeparam>
        /// <typeparam name="U">有返回值委托的参数U</typeparam>
        /// <param name="key">键</param>
        /// <param name="oe3F">有返回值委托</param>
        public void PutCEventInObjectDic<T, Y, U>(string key, Func<T, Y, U, object> oe3F)
        {
            CEvents.ObjectEvent3<T, Y, U> @object = new CEvents.ObjectEvent3<T, Y, U>(oe3F);
            CEventsStringTriggers.RegisterObject<T, Y, U>(key, @object);
        }

        #endregion

        #region -- LookUpObject APIMethods --
        /// <summary>
        /// CEvent数据在有返回值字典中查询
        /// </summary>
        /// <returns>object</returns>
        public object LookUpCEventToObjectDic()
        {
            return LookUpCEventToObjectDic(defaultKey);
        }

        /// <summary>
        /// CEvent数据在有返回值字典中查询
        /// </summary>
        /// <param name="key">键</param>
        /// <returns>object</returns>
        public object LookUpCEventToObjectDic(string key)
        {
            return CEventsStringTriggers.InvokeObject(key);
        }

        /// <summary>
        /// CEvent数据在有返回值字典中查询
        /// </summary>
        /// <typeparam name="T">有返回值委托的参数一类型</typeparam>
        /// <param name="key">键</param>
        /// <param name="obj0">有返回值委托的参数一</param>
        /// <returns>object</returns>
        public object LookUpCEventToObjectDic<T>(string key, T obj0)
        {
            return CEventsStringTriggers.InvokeObject<T>(key, obj0);
        }

        /// <summary>
        /// CEvent数据在有返回值字典中查询
        /// </summary>
        /// <typeparam name="T">有返回值委托的参数一类型</typeparam>
        /// <typeparam name="Y">有返回值委托的参数二类型</typeparam>
        /// <param name="key">键</param>
        /// <param name="obj0">有返回值委托的参数一</param>
        /// <param name="obj1">有返回值委托的参数二</param>
        /// <returns>object</returns>
        public object LookUpCEventToObjectDic<T, Y>(string key, T obj0, Y obj1)
        {
            return CEventsStringTriggers.InvokeObject<T, Y>(key, obj0, obj1);
        }

        /// <summary>
        /// CEvent数据在有返回值字典中查询
        /// </summary>
        /// <typeparam name="T">有返回值委托的参数一类型</typeparam>
        /// <typeparam name="Y">有返回值委托的参数二类型</typeparam>
        /// <typeparam name="U">有返回值委托的参数三类型</typeparam>
        /// <param name="key">键</param>
        /// <param name="obj0">有返回值委托的参数一</param>
        /// <param name="obj1">有返回值委托的参数二</param>
        /// <param name="obj2">有返回值委托的参数三</param>
        /// <returns>object</returns>
        public object LookUpCEventToObjectDic<T, Y, U>(string key, T obj0, Y obj1, U obj2)
        {
            return CEventsStringTriggers.InvokeObject<T, Y, U>(key, obj0, obj1, obj2);
        }


        #endregion
    }
}
