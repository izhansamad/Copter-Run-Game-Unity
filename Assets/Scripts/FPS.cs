using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FPS : MonoBehaviour
{
    public int avgFrameRate;
    public Text display_Text;
    private void Start()
    {
        Application.targetFrameRate = 300;
    }
    public void Update()
    {
        float current = 0;
        current = (int)(1f / Time.unscaledDeltaTime);
        avgFrameRate = (int)current;
        display_Text.text = avgFrameRate.ToString();
    }
}
