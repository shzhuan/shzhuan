using UnityEngine;
using System.Collections;
using System;

public class GameDateTime : MonoBehaviour {

    private DateTime m_oldDateTime;

    public void SaveDate() {
        DateTime now = DateTime.Now;
        PlayerPrefs.SetString("key", now.ToBinary().ToString());
    }

    public void LoadDate() {
        string datetimeString = PlayerPrefs.GetString("key");
        m_oldDateTime = DateTime.FromBinary(System.Convert.ToInt64(datetimeString));
    }

    public void TimeDifference() {
        TimeSpan ts = DateTime.Now - m_oldDateTime;
    }

}
