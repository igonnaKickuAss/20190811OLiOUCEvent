namespace OLiOYouxi.OSystem.OLiOCEvents
{
    using System.Collections.Generic;

    /// <summary>
    /// 给定无参字典
    /// </summary>
    internal class CEventsStringDictionary
    {
        #region -- String Dictionary --
        internal Dictionary<string, CEvents.VoidEvent0> dic_StringVoidEvent0 = null;
        internal Dictionary<string, CEvents.ObjectEvent0> dic_StringObjectEvent0 = null;

        #endregion

        #region -- 单例 --
        static private CEventsStringDictionary _CEventsStringDictionary = null;

        /// <summary>
        /// 这是单例
        /// </summary>
        static internal CEventsStringDictionary Instance
        {
            get
            {
                if (_CEventsStringDictionary == null)
                {
                    _CEventsStringDictionary = new CEventsStringDictionary();
                    return _CEventsStringDictionary;
                }
                return _CEventsStringDictionary;
            }
        }

        #endregion

        #region -- 初始化 --
        private CEventsStringDictionary()
        {
            InitData();
        }

        private void InitData()
        {
            dic_StringVoidEvent0 = new Dictionary<string, CEvents.VoidEvent0>();

            dic_StringObjectEvent0 = new Dictionary<string, CEvents.ObjectEvent0>();
        }


        #endregion
    }

    /// <summary>
    /// 给定单参字典
    /// </summary>
    internal class CEventsStringDictionary<T>
    {
        #region -- String Dictionary --
        internal Dictionary<string, CEvents.VoidEvent1<T>> dic_StringVoidEvent1 = null;
        internal Dictionary<string, CEvents.ObjectEvent1<T>> dic_StringObjectEvent1 = null;

        #endregion

        #region -- ShotC --
        static private CEventsStringDictionary<T> _CEventsStringDictionary = null;

        /// <summary>
        /// 这是单例
        /// </summary>
        static internal CEventsStringDictionary<T> Instance
        {
            get
            {
                if (_CEventsStringDictionary == null)
                {
                    _CEventsStringDictionary = new CEventsStringDictionary<T>();
                    return _CEventsStringDictionary;
                }
                return _CEventsStringDictionary;
            }
        }

        #endregion

        #region -- 初始化 --
        private CEventsStringDictionary()
        {
            InitData();
        }

        private void InitData()
        {
            dic_StringVoidEvent1 = new Dictionary<string, CEvents.VoidEvent1<T>>();

            dic_StringObjectEvent1 = new Dictionary<string, CEvents.ObjectEvent1<T>>();
        }


        #endregion
    }

    /// <summary>
    /// 给定双参字典
    /// </summary>
    internal class CEventsStringDictionary<T, Y>
    {
        #region -- String Dictionary --
        internal Dictionary<string, CEvents.VoidEvent2<T, Y>> dic_StringVoidEvent2 = null;
        internal Dictionary<string, CEvents.ObjectEvent2<T, Y>> dic_StringObjectEvent2 = null;

        #endregion

        #region -- ShotC --
        static private CEventsStringDictionary<T, Y> _CEventsStringDictionary = null;

        /// <summary>
        /// 这是单例
        /// </summary>
        static internal CEventsStringDictionary<T, Y> Instance
        {
            get
            {
                if (_CEventsStringDictionary == null)
                {
                    _CEventsStringDictionary = new CEventsStringDictionary<T, Y>();
                    return _CEventsStringDictionary;
                }
                return _CEventsStringDictionary;
            }
        }

        #endregion

        #region -- 初始化 --
        private CEventsStringDictionary()
        {
            InitData();
        }

        private void InitData()
        {
            dic_StringVoidEvent2 = new Dictionary<string, CEvents.VoidEvent2<T, Y>>();

            dic_StringObjectEvent2 = new Dictionary<string, CEvents.ObjectEvent2<T, Y>>();
        }


        #endregion
    }

    /// <summary>
    /// 给定三参字典
    /// </summary>
    internal class CEventsStringDictionary<T, Y, U>
    {
        #region -- String Dictionary --
        internal Dictionary<string, CEvents.VoidEvent3<T, Y, U>> dic_StringVoidEvent3 = null;
        internal Dictionary<string, CEvents.ObjectEvent3<T, Y, U>> dic_StringObjectEvent3 = null;

        #endregion

        #region -- ShotC --
        static private CEventsStringDictionary<T, Y, U> _CEventsStringDictionary = null;

        /// <summary>
        /// 这是单例
        /// </summary>
        static internal CEventsStringDictionary<T, Y, U> Instance
        {
            get
            {
                if (_CEventsStringDictionary == null)
                {
                    _CEventsStringDictionary = new CEventsStringDictionary<T, Y, U>();
                    return _CEventsStringDictionary;
                }
                return _CEventsStringDictionary;
            }
        }

        #endregion

        #region -- 初始化 --
        private CEventsStringDictionary()
        {
            InitData();
        }

        private void InitData()
        {
            dic_StringVoidEvent3 = new Dictionary<string, CEvents.VoidEvent3<T, Y, U>>();

            dic_StringObjectEvent3 = new Dictionary<string, CEvents.ObjectEvent3<T, Y, U>>();
        }


        #endregion
    }
}
