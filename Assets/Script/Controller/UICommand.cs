using UnityEngine;
using System.Collections;

public class UICommand {
    static UICommand instance;
    public static UICommand Instance
    {
        get { return instance; }
    }

    void Awake() {
        if (instance == null)
            instance = this;
    }

    public const string BACK = "BACK";
    public const string TEST1 = "Test1";
    public const string TEST2 = "Test2";

}
