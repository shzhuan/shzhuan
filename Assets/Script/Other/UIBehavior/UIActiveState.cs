using UnityEngine;
using System;

[Serializable]
public class UIActiveState {

    public enum ExecuteTimeType {
        Awake,
        End
    }

    public GameObject target;
    public ExecuteTimeType executeType;
    public float time;

    public UIActiveState() {
        executeType = ExecuteTimeType.Awake;
    }

}
