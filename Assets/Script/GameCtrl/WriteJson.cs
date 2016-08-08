using UnityEngine;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

public class WriteJson : MonoBehaviour {
    public GameStatus gameStatus;
    public GameObject[] objectList;
    void Start() {
        gameStatus = new GameStatus();
        gameStatus.statusList = new refencenes[objectList.Length];
        gameStatus.gameName = "";

        for (int i = 0; i < objectList.Length; i++) {
            gameStatus.statusList[i] = new refencenes();
            gameStatus.statusList[i].id = i;
            gameStatus.statusList[i].name = objectList[i].name;
        }
    }

    public void SaveJson() {
        //string json = JsonUtility.ToJson(gameStatus);
        //string savePath = Application.dataPath + "/Resources/Test01.json";
        //File.WriteAllText(savePath, json, Encoding.UTF8);
    }

}