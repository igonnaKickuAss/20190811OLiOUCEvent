namespace OLiOYouxi.OSystem.OLiOUEvents.UEventsBase
{
    using System;
    using UnityEngine;
    using UnityEngine.Events;

    #region -- Abstract --
    public class OLiOEvent : UnityEvent { }

    public class OLiOEvent<T> : UnityEvent<T> { }
    
    public class OLiOEvent<T, Y> : UnityEvent<T, Y> { }
    
    public class OLiOEvent<T, Y, U> : UnityEvent<T, Y, U> { }
    
    public class OLiOEvent<T, Y, U, I> : UnityEvent<T, Y, U, I> { }

    #endregion
    
    [Serializable]
    public class VoidEvent : OLiOEvent { }
    
    [Serializable]
    public class StringEvent : OLiOEvent<string> { }

    [Serializable]
    public class BoolEvent : OLiOEvent<bool> { }

    [Serializable]
    public class FloatEvent : OLiOEvent<float> { }

    [Serializable]
    public class IntEvent : OLiOEvent<int> { }

    [Serializable]
    public class ObjectEvent : OLiOEvent<object> { }

    [Serializable]
    public class TransformEvent : OLiOEvent<Transform> { }

    [Serializable]
    public class TransformTransformEvent : OLiOEvent<Transform, Transform> { }


}
