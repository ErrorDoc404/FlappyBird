using System.Collections;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(TMP_Text))]
public class FPS : MonoBehaviour
{
    private TMP_Text _fpsText;
    public float updateTextTime = 1f;

    private void Start()
    {
        _fpsText = GetComponent<TMP_Text>();
        StartCoroutine(FramesPerSecond());
    }

    private IEnumerator FramesPerSecond()
    {
        while (true)
        {
            int fps = (int)(1f / Time.deltaTime);
            DisplayFPS(fps);

            yield return new WaitForSeconds(updateTextTime);
        }
    }

    private void DisplayFPS(float fps)
    {
        _fpsText.text = $"{fps} FPS";
    }
}