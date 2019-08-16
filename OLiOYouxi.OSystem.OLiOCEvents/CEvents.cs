namespace OLiOYouxiCore.OSystem.OLiOCEvents
{
    /// <summary>
    /// 给定委托事件
    /// </summary>
    internal class CEvents
    {
        #region -- Void Events --
        internal delegate void VoidEvent0();
        internal delegate void VoidEvent1<T>(T a);
        internal delegate void VoidEvent2<T, Y>(T a, Y b);
        internal delegate void VoidEvent3<T, Y, U>(T a, Y b, U c);

        #endregion

        #region -- Object Events --
        internal delegate object ObjectEvent0();
        internal delegate object ObjectEvent1<T>(T a);
        internal delegate object ObjectEvent2<T, Y>(T a, Y b);
        internal delegate object ObjectEvent3<T, Y, U>(T a, Y b, U c);

        #endregion

        #region -- 单例 --
        static private CEvents _CEvents = null;

        /// <summary>
        /// 这是单例
        /// </summary>
        static internal CEvents Instance
        {
            get
            {
                if (_CEvents == null)
                {
                    _CEvents = new CEvents();
                    return _CEvents;
                }
                return _CEvents;
            }
        }

        #endregion

        #region -- 初始化 --
        private CEvents()
        {
            InitData();
        }

        private void InitData()
        {
            //TODO..
        }

        #endregion
    }


}
