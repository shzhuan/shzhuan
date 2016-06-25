using UnityEngine;
using System.Collections.Generic;

public class SoundManager : MonoBehaviour {

    static SoundManager m_instance = null;
    public static SoundManager Instance {
        get {
            if (m_instance == null) {
                var obj = new GameObject();
                DontDestroyOnLoad(obj);
                obj.name = "SoundManager";
                m_instance = obj.AddComponent<SoundManager>();
                m_instance.soundPrefab = Resources.Load<Object>("Sound/Prefab/SoundPrefab");
            }
            return m_instance;
        }
    }

    public Object soundPrefab;

    List<GameObject> soundList = new List<GameObject>();
    int nowPlayingSoundIndex = 0;
    string m_soundBGMResourcesPath = "Sound/BGM/";

    public void PlayMusic(string soundName, bool isLoop) {
        if (soundList.Count != 0) {
            if (soundList[nowPlayingSoundIndex].name != soundName) {
                soundList[nowPlayingSoundIndex].gameObject.SetActive(false);
                for (int i = 0; i < soundList.Count; ++i) {
                    if (soundList[i].name == soundName) {
                        soundList[i].gameObject.SetActive(true);
                        nowPlayingSoundIndex = i;
                        return;
                    }
                }
                CreateSound(soundName, isLoop);
            }
        } else {
            CreateSound(soundName, isLoop);
        }
    }

    void CreateSound(string soundName, bool isLoop) {
        GameObject sound = Object.Instantiate(soundPrefab) as GameObject;
        sound.transform.parent = transform;
        sound.transform.localRotation = ((GameObject)soundPrefab).transform.localRotation;
        sound.transform.localScale = ((GameObject)soundPrefab).transform.localScale;
        sound.name = soundName;
        sound.GetComponent<AudioSource>().clip = GetSoundByName(soundName);
        sound.GetComponent<AudioSource>().loop = isLoop;
        sound.GetComponent<AudioSource>().Play();
        soundList.Add(sound);
        nowPlayingSoundIndex = soundList.Count - 1;
    }

    AudioClip GetSoundByName(string soundName) {
        Debug.Log(m_soundBGMResourcesPath + soundName);
        AudioClip audioClip = Resources.Load<AudioClip>(m_soundBGMResourcesPath + soundName);
        return audioClip;
    }
    
}
