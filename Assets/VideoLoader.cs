using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class VideoLoader : MonoBehaviour
{
#if UNITY_EDITOR
    [ContextMenu("GetPath")]
    private void GetPathVideo() 
    {
        string videoPath = EditorUtility.OpenFilePanel("Selecciona un video", "", "mp4");
    }
#endif
}
