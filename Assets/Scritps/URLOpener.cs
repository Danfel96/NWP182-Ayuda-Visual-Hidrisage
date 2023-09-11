using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class URLOpener : MonoBehaviour
{
    [SerializeField] string url;
    public Button Btn { get; set; }

    private void Start()
    {
        Btn = GetComponent<Button>();
        if (Btn == null || string.IsNullOrEmpty(url)) return;
        Btn.onClick.AddListener(OpenURL);
    }
    public void OpenURL() => Application.OpenURL(url);

    public void OpenURL(string url) => Application.OpenURL(url);

    //public void DialPhoneNumber(string phoneNumber) => OpenURL($"{Constants.Tel}{phoneNumber}");
}
