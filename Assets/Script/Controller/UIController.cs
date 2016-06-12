using UnityEngine;
using System.Collections.Generic;
using BehaviourMachine;

public class UIController : MonoBehaviour {

    static UIController instance;
    public static UIController Instance
    {
        get { return instance; }
    }

    public StateMachine stateMachine;

    public bool IsBack { get; set; }

    List<StackCommand> m_commandStack = new List<StackCommand>();

    void Awake() {
        if (instance == null) {
            instance = this;
        }
    }

    public void Command(string command, bool addStack = true) {
        if (string.IsNullOrEmpty(command)) {
            Debug.LogWarning("Command not valid!");
            return;
        }
        var blackboard = this.GetComponent<Blackboard>();
        switch (command) {
            case UICommand.BACK:
                IsBack = true;
                //再移除栈顶元素
                if (m_commandStack.Count > 0) {
                    m_commandStack.RemoveAt(m_commandStack.Count - 1);
                }
                //先清除不需要弹栈的
                if (m_commandStack.Count > 0) {
                    while (m_commandStack[m_commandStack.Count - 1].nostack) {
                        m_commandStack.RemoveAt(m_commandStack.Count - 1);
                        if (m_commandStack.Count <= 0) {
                            break;
                        }
                    }
                }
                if (m_commandStack.Count > 0) {
                    var cmd = m_commandStack[m_commandStack.Count - 1];
                    blackboard.SendEvent(cmd.command);
                    stateMachine.blackboard.GetStringVar("CurrentCommand").Value = cmd.command;
                } else {
                    blackboard.SendEvent(UICommand.BACK);
                    stateMachine.blackboard.GetStringVar("CurrentCommand").Value = command;
                }
                break;
            default:
                IsBack = false;
                blackboard.SendEvent(command);
                stateMachine.blackboard.GetStringVar("CurrentCommand").Value = command;
                StackCommand stackCmd = new StackCommand();
                stackCmd.command = command;
                stackCmd.nostack = !addStack;
                if (!CommandContains(stackCmd)) {
                    m_commandStack.Add(stackCmd);
                }
                break;
        }
    }

    bool CommandContains(StackCommand command) {
        foreach (StackCommand cmd in m_commandStack) {
            if (cmd.command.Equals(command.command)) {
                return true;
            }
        }
        return false;
    }

    //void SendEvent(string command) {
        //var currentState = stateMachine.enabledState;
        //while ((currentState as ParentBehaviour) != null) {
            //currentState = (currentState as ParentBehaviour).enabledState;
        //}
        //currentState.SendEvent(command);
    //}

    public class StackCommand {
        public string command;
        public bool nostack;
    }

}
