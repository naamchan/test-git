using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class PersonalInfo
{
    public string first_name;
    public int age;
    public Company company;
    public ProgrammingLanguage[] programming_languages;
}

[Serializable]
public class ProgrammingLanguage
{
    public string name;
    public int level;
}

[Serializable]
public class Company
{
    public string name;
    public string position;
}

public class SimpleJson : MonoBehaviour
{
    [SerializeField]
    private string jsonString; //{"first_name": "Thara","company": {"name": "True Axion","position": "Senior programmer"},"age": 30,"programming_languages": [{"name": "C","level": 3},{"name": "C++","level": 4},{"name": "C#","level": 5}]}

    void Start()
    {
        // Deserialize
        PersonalInfo personalInfo = JsonUtility.FromJson<PersonalInfo>(jsonString);

        Debug.Log("Age :" + personalInfo.age);
    }
}
