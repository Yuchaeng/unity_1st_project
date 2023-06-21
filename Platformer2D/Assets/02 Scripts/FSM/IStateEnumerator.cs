using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface IStateEnumerator<T>
    where T : System.Enum
{
    public enum Step
    {
        None,
        Start,
        Casting,
        DoAction,
        WaitUntilActionFinished,
        Finish
    }

    Step current { get; }
    T MoveNext();
    void Reset();
}
