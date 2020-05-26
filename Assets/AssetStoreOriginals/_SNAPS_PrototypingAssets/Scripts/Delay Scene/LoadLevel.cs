using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiodeEscena : MonoBehaviour
{
    [SerializeField]
    private float DelayB = 23f;
    [SerializeField]
    private string SceneName;
    private float TimeElapsed;

    private void Update()
    {
        TimeElapsed += Time.deltaTime;

        if (TimeElapsed > DelayB)
        {
            SceneManager.LoadScene(SceneName);
        }
    }
}
