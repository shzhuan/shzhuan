using UnityEngine;
using System;

[Serializable]
public class UIAnimation {

    public enum AnimationType {
        Once,
        Loop
    }

    public Animation target;
    public AnimationType executeType;
    public string animationName;
    public float speed;

    public UIAnimation() {
        executeType = AnimationType.Once;
        speed = 1f;
    }

}
