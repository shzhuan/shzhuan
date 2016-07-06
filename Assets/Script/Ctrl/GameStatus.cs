using UnityEngine;
using System;
using System.Collections;

[Serializable]
public class GameStatus {
    public string gameName;
    public string version;
    public bool isStereo;
    public bool isUseHardWare;
    public refencenes[] statusList;
}

[Serializable]
public class refencenes {
    public refencenes() {
        name = "";
        id = -1;
    }

    public string name;
    public int id;

}