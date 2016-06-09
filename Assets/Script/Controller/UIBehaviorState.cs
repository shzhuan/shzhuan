using UnityEngine;
using System;

namespace BehaviourMachine {
    public class UIBehaviorState : InternalActionState {

        public string bgmName = "";
        public bool loop = false;
        public UIActiveState[] activeObject;
        public UIActiveState[] inactiveObject;
        public UIAnimation[] animationObject;

        float m_animationTime = 0;

        public UIBehaviorState() {
            this.onEnable += PlaySound;
            this.onEnable += StateOnEnableAwake;
            this.onDisable += StateOnEnableEnd;
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
            PlayUIAnimation();
            SendEvent();
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
            m_animationTime = 0;
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
                            if (state.time > m_animationTime) {
                                m_animationTime = state.time;
                            }
                            state.speed = animationObject[i].speed;
                            animationObject[i].target.Play(state.name);
                            break;
                        }
                    }
                }
            }
        }

        void SendEvent() {
            GDGeek.TaskWait tw = new GDGeek.TaskWait(m_animationTime);
            GDGeek.TaskManager.PushBack(tw, delegate () {
                //Debug.Log(blackboard.GetStringVar("CurrentCommand"));
                //var currentCmd = blackboard.GetStringVar("CurrentCommand").Value;
                //if (!string.IsNullOrEmpty(currentCmd)) {
                    //SendEvent(currentCmd);
                //}
            });
            GDGeek.TaskManager.Run(tw);
        }

    }
}
