using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

[Serializable]
public class PlayerData
{
    public Player player { get; set; }
    public Equipments equipments { get; set; }
    public Item[] items { get; set; }
}

[Serializable]
public class Player
{
    public string name { get; set; }
    public int level { get; set; }
    public int exp { get; set; }
    public int max_exp { get; set; }
}

[Serializable]
public class Equipment
{
    public string item_id { get; set; }
    public int level { get; set; }
}

[Serializable]
public class Equipments
{
    public Equipment head { get; set; }
    public Equipment upper_body { get; set; }
    public Equipment lower_body { get; set; }
}

[Serializable]
public class Item
{
    public string id { get; set; }
    public string name { get; set; }
    public string description { get; set; }
}

public class HTTPJSonRequest : MonoBehaviour
{

    // Use this for initialization
    IEnumerator Start()
    {
        // username|password
        // InwZa007||password

        // Create request
        UnityWebRequest request = UnityWebRequest.Get("http://192.168.10.4/api/player_data");

        // Send
        request.SendWebRequest();

        // Wait request
        yield return request;

        PlayerData playerData = JsonUtility.FromJson<PlayerData>(request.downloadHandler.text);
    }
}
