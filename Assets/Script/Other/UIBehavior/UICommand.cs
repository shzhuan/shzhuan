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
    public const string SHAN_TRAVEL = "Shan.Travel";
    public const string SHAN_SHOP = "Shan.Shop";

}
