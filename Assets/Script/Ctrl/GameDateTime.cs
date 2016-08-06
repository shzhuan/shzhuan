using UnityEngine;
using System.Collections;
using System;

public class GameDateTime : MonoBehaviour {

    public DateTime now = DateTime.Now;

    public void SetDayNum(DateTime date) {
        int day = now.Subtract(date).Days;
    }

    public void SaveDate() {
        PlayerPrefs.SetString("Key", now.ToBinary().ToString());
        string defult = new DateTime(2000, 1, 1, 16, 32, 0, DateTimeKind.Local).ToBinary().ToString();
        string dateTimeString = PlayerPrefs.GetString("Key", defult);
        //DateTime time = System.DateTime.FromBinary(System.Convert.ToInt64(datetimeString));
    }

}
