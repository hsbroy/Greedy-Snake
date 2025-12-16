using UnityEngine;

public class GameAudio : MonoBehaviour
{
    public AudioSource audioPlayer; // 背景音樂播放器

    // 把吃到食物的音效與背景音樂的播放器分開是因為這樣才能分開調整兩種音效的音量大小
    public AudioSource eatSource; // 吃到食物的音效播放器 
    public AudioClip eatClip;  // 吃到食物的音效片段

    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    public void ReplayBackGroundMusic()
    {
        audioPlayer.Play();
    }

    public void PlayEatSound()
    {
        audioPlayer.PlayOneShot(eatClip);
    }

    public void EatSound()
    {
        eatSource.Play();
    }
}
