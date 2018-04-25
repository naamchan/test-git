using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class SimpleHTTPRequest : MonoBehaviour
{
    IEnumerator Start()
    {
        // Create request
        UnityWebRequest request = UnityWebRequest.Get("http://192.168.10.4/api/player_data");

        // Send
        request.SendWebRequest();

        // Wait request
        yield return request;

        Debug.Log(request.downloadHandler.text);
    }
}
