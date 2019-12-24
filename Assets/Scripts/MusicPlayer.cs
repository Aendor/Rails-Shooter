using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    void Awake()
    {
        int numMusicPlayer = FindObjectsOfType<MusicPlayer>().Length;
        // if more than one music player in sceen
        // destroy me
        if (numMusicPlayer > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

}
