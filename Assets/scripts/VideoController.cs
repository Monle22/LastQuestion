using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    void Start()
    {

        videoPlayer.Play();
        videoPlayer.loopPointReached += OnVideoFinished;
    }

    void OnVideoFinished(VideoPlayer vp)
    {
        SceneManager.LoadScene("goodend");
    }
}
