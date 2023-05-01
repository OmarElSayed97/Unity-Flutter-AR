using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppManager : MonoBehaviour
{
    public static AppManager Instance { get; private set; }
    ModelLoader modelWrapper;

    private void Awake()
    {
        // If there is an instance, and it's not me, delete myself.

        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }

        modelWrapper = GameObject.FindAnyObjectByType<ModelLoader>();
        if (modelWrapper)
            Debug.Log("Model Wrapper Initialized Successfully");
        else
            Debug.Log("Model Wrapper Did Not Initialize Successfully");
    }


    public void LoadObject(string url)
    {
        modelWrapper.DownloadFile(url);
    }

}

