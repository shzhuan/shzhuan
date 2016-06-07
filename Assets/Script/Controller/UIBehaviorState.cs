using UnityEngine;
using System;

namespace BehaviourMachine {
    public class UIBehaviorState : StateBehaviour {

        public string bgmName = "";
        public bool loop = false;
        public UIActiveState[] activeObject;
        public UIActiveState[] inactiveObject;
        public UIAnimation[] animationObject;

        void OnEnable() {
            PlaySound();
            StateOnEnableAwake();
        }

        void OnDisable() {
            StateOnEnableEnd();
        }

        void PlaySound() {
            if (bgmName != "") {
                SoundManager.Instance.PlayMusic(bgmName, loop);
            }
        }

        void StateOnEnableAwake() {
            for (int i = 0; i < activeObject.Length; i++) {
                if (activeObject[i].target != null &&
                    activeObject[i].executeType == UIActiveState.ExecuteTimeType.Awake && 
                    activeObject[i].time == 0) {
                    activeObject[i].target.SetActive(true);
                }
            }
            for (int i = 0; i < inactiveObject.Length; i++) {
                if (inactiveObject[i].target != null && 
                    inactiveObject[i].executeType == UIActiveState.ExecuteTimeType.Awake && 
                    inactiveObject[i].time == 0) {
                    inactiveObject[i].target.SetActive(false);
                }
            }
        }

        void StateOnEnableEnd() {
            for (int i = 0; i < activeObject.Length; i++) {
                if (activeObject[i].target != null &&
                    activeObject[i].executeType == UIActiveState.ExecuteTimeType.End &&
                    activeObject[i].time == 0) {
                    activeObject[i].target.SetActive(true);
                }
            }
            for (int i = 0; i < inactiveObject.Length; i++) {
                if (inactiveObject[i].target != null &&
                    inactiveObject[i].executeType == UIActiveState.ExecuteTimeType.End &&
                    inactiveObject[i].time == 0) {
                    inactiveObject[i].target.SetActive(false);
                }
            }
        }

        void PlayUIAnimation() {
            for (int i = 0; i < animationObject.Length; i++) {
                if (animationObject[i].target != null) {
                    switch (animationObject[i].executeType) {
                        case UIAnimation.AnimationType.Once:
                            animationObject[i].target.wrapMode = WrapMode.Once;
                            break;
                        case UIAnimation.AnimationType.Loop:
                            animationObject[i].target.wrapMode = WrapMode.Loop;
                            break;
                    }
                    foreach (AnimationState state in animationObject[i].target) {
                        if (state.name == animationObject[i].animationName) {
                            state.speed = animationObject[i].speed;
                            animationObject[i].target.Play(state.name);
                        }
                    }
                }
            }
        }

    }
}
