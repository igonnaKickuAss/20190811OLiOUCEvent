namespace OLiOYouxi.OSystem.OLiOUEvents
{
    using UnityEngine;
    using OLiOYouxi.OSystem.OLiOUEvents.UEventsBase;

    static internal class UEventsExtensions
    {
        #region -- Private Data --
        private const string defaultKey = "奥利奥";

        #endregion

        static internal void PutInDic(this VoidEvent @void)
        {
            PutInDic(@void, string.Format("{0}{1}", defaultKey, nameof(VoidEvent)));
        }

        static internal void PutInDic(this VoidEvent @void, out string key)
        {
            key = string.Format("{0}{1}{2}", defaultKey, nameof(VoidEvent), KeyForXY(UnityEngine.Random.Range(1, 20), UnityEngine.Random.Range(1, 99)));
            PutInDic(@void, key);
        }

        static internal void PutInDic(this VoidEvent @void, string key)
        {
            PutInDic((OLiOEvent)@void, key);
        }

        static internal void PutInDic(this StringEvent @string)
        {
            PutInDic(@string, string.Format("{0}{1}", defaultKey, nameof(StringEvent)));
        }

        static internal void PutInDic(this StringEvent @string, out string key)
        {
            key = string.Format("{0}{1}{2}", defaultKey, nameof(StringEvent), KeyForXY(UnityEngine.Random.Range(1, 20), UnityEngine.Random.Range(1, 99)));
            PutInDic(@string, key);
        }

        static internal void PutInDic(this StringEvent @string, string key)
        {
            PutInDic<string>(@string,  key);
        }

        static internal void PutInDic(this BoolEvent @bool)
        {
            PutInDic(@bool, string.Format("{0}{1}", defaultKey, nameof(BoolEvent)));
        }

        static internal void PutInDic(this BoolEvent @bool, out string key)
        {
            key = string.Format("{0}{1}{2}", defaultKey, nameof(BoolEvent), KeyForXY(UnityEngine.Random.Range(1, 20), UnityEngine.Random.Range(1, 99)));
            PutInDic(@bool, key);
        }

        static internal void PutInDic(this BoolEvent @bool, string key)
        {
            PutInDic<bool>(@bool,  key);
        }

        static internal void PutInDic(this FloatEvent @float)
        {
            PutInDic(@float, string.Format("{0}{1}", defaultKey, nameof(FloatEvent)));
        }

        static internal void PutInDic(this FloatEvent @float, out string key)
        {
            key = string.Format("{0}{1}{2}", defaultKey, nameof(FloatEvent), KeyForXY(UnityEngine.Random.Range(1, 20), UnityEngine.Random.Range(1, 99)));
            PutInDic(@float, key);
        }

        static internal void PutInDic(this FloatEvent @float, string key)
        {
            PutInDic<float>(@float,  key);
        }

        static internal void PutInDic(this IntEvent @int)
        {
            PutInDic(@int, string.Format("{0}{1}", defaultKey, nameof(IntEvent)));
        }

        static internal void PutInDic(this IntEvent @int, out string key)
        {
            key = string.Format("{0}{1}{2}", defaultKey, nameof(IntEvent), KeyForXY(UnityEngine.Random.Range(1, 20), UnityEngine.Random.Range(1, 99)));
            PutInDic(@int, key);
        }

        static internal void PutInDic(this IntEvent @int, string key)
        {
            PutInDic<int>(@int,  key);
        }

        static internal void PutInDic(this ObjectEvent @object)
        {
            PutInDic(@object, string.Format("{0}{1}", defaultKey, nameof(ObjectEvent)));
        }

        static internal void PutInDic(this ObjectEvent @object, out string key)
        {
            key = string.Format("{0}{1}{2}", defaultKey, nameof(ObjectEvent), KeyForXY(UnityEngine.Random.Range(1, 20), UnityEngine.Random.Range(1, 99)));
            PutInDic(@object, key);
        }

        static internal void PutInDic(this ObjectEvent @object, string key)
        {
            PutInDic<object>(@object,  key);
        }

        static internal void PutInDic(this TransformEvent @transform)
        {
            PutInDic(@transform, string.Format("{0}{1}", defaultKey, nameof(TransformEvent)));
        }

        static internal void PutInDic(this TransformEvent @transform, out string key)
        {
            key = string.Format("{0}{1}{2}", defaultKey, nameof(TransformEvent), KeyForXY(UnityEngine.Random.Range(1, 20), UnityEngine.Random.Range(1, 99)));
            PutInDic(@transform, key);
        }

        static internal void PutInDic(this TransformEvent @transform, string key)
        {
            PutInDic<Transform>(@transform,  key);
        }

        static internal void PutInDic(this TransformTransformEvent @transformtransform)
        {
            PutInDic(@transformtransform, string.Format("{0}{1}", defaultKey, nameof(TransformTransformEvent)));
        }

        static internal void PutInDic(this TransformTransformEvent @transformtransform, out string key)
        {
            key = string.Format("{0}{1}{2}", defaultKey, nameof(TransformTransformEvent), KeyForXY(UnityEngine.Random.Range(1, 20), UnityEngine.Random.Range(1, 99)));
            PutInDic(@transformtransform, key);
        }

        static internal void PutInDic(this TransformTransformEvent @transformtransform, string key)
        {
            PutInDic<Transform, Transform>(@transformtransform,  key);
        }

        static internal void PutInDic(this OLiOEvent @event,  string key)
        {
            UEventsStringTriggers.Register(key, @event);
        }

        static internal void PutInDic<T>(this OLiOEvent<T> @event,  string key)
        {
            UEventsStringTriggers.Register<T>(key, @event);
        }

        static internal void PutInDic<T, Y>(this OLiOEvent<T, Y> @event,  string key)
        {
            UEventsStringTriggers.Register<T, Y>(key, @event);
        }

        static internal void PutInDic<T, Y, U>(this OLiOEvent<T, Y, U> @event,  string key)
        {
            UEventsStringTriggers.Register<T, Y, U>(key, @event);
        }

        static internal void PutInDic<T, Y, U, I>(this OLiOEvent<T, Y, U, I> @event,  string key)
        {
            UEventsStringTriggers.Register<T, Y, U, I>(key, @event);
        }

        #region -- Helper --
        static private int KeyForXY(int x, int y)
        {
            return y * 1000 + x;
        }

        #endregion
    }
}
