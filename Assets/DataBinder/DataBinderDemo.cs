using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using SimpleJSON;
using TMPro;

public class DataBinderDemo : MonoBehaviour
{
    [SerializeField]
    private DataBinder m_dataBinder;                            //Element that registers data and binds it to all connected dataBinder components

    [SerializeField]
    private DataBinderList m_dataList;                          //Element that generates and controls a list of dataBinder prefabs

    private const string PATH_TO_JSON_FILE = "/JSONData/";      //Path (relative to the streaming assets path) pointing to the JSON files

    private void Start()
    {
        TryChangeData("Nasdaq.json");
    }

    /// <summary>
    /// Reads from the JSON file requested and if the JSON data exists, change the data
    /// </summary>
    /// <param name="JSONFile"></param>
    public void TryChangeData(string JSONFile)
    {
        JSONNode json = FileReader.ReadJSONFromFile(Application.streamingAssetsPath + PATH_TO_JSON_FILE + JSONFile);
        if (json != null)
        {
            Debug.Log(json["securities"].ToString());
            StartCoroutine(ChangeData(json));
        }
    }

    /// <summary>
    /// Function that registers data to the dataBinder and dataBinder list, and the generates the list of prefabs accordingly and binds the data to the data binder 
    /// Both the dataBinder and the dataBinder list use the same json data in this example but target different nodes within 
    /// </summary>
    /// <param name="json">JSON data to pass to the dataBinder elements</param>
    /// <returns></returns>
    private IEnumerator ChangeData(JSONNode json)
    {
        //Generates a list of dataBinders based on the json provided
        m_dataList.GenerateList(json);

        //Registers the json data provided to the dataBinder
        m_dataBinder.RegisterData(json);

        //Plays the update animation for the dataBinder and waits for half of the animation before yielding
        yield return StartCoroutine(AnimationDispatcher.TriggerAnimation(m_dataBinder.GetComponent<Animator>(), "Update", 0.5f));

        //Bind the new data to all databinder components tied to the dataBinder
        m_dataBinder.BindData(); 
    }
}
