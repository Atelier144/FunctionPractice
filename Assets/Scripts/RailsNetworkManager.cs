using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class RailsNetworkManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickButtonSend()
    {
        StartCoroutine(SendData());
    }

    public void OnClickButtonReceive()
    {
        StartCoroutine(ReceiveData());
    }

    public void OnClickButtonSendAndReceive()
    {
        StartCoroutine(SendAndReceiveData());
    }

    IEnumerator SendData()
    {
        WWWForm form = new WWWForm();
        form.AddField("name", "FROM UNITY");
        UnityWebRequest request = UnityWebRequest.Post("http://localhost:3000/send", form);

        yield return request.SendWebRequest();

        if (request.isNetworkError)
        {
            Debug.Log("ERROR:" + request.error);
        }
        else
        {
            if (request.responseCode == 204)
            {
                Debug.Log("せいこう!");
            }
            else
            {
                Debug.Log("しっぱい...:" + request.responseCode);
            }
        }
    }

    IEnumerator ReceiveData()
    {
        UnityWebRequest request = UnityWebRequest.Get("http://localhost:3000/receive");

        yield return request.SendWebRequest();

        if (request.isNetworkError)
        {
            Debug.Log("ERROR:" + request.error);
        }
        else
        {
            if (request.responseCode == 200)
            {
                Debug.Log("せいこう!");
                Debug.Log(request.downloadHandler.text);
            }
            else
            {
                Debug.Log("しっぱい...:" + request.responseCode);
            }
        }
    }

    IEnumerator SendAndReceiveData()
    {
        WWWForm form = new WWWForm();
        form.AddField("name", "From Unity");
        UnityWebRequest request = UnityWebRequest.Post("http://localhost:3000/send_and_receive", form);

        yield return request.SendWebRequest();
        if (request.isNetworkError)
        {
            Debug.Log("ERROR:" + request.error);
        }
        else
        {
            if (request.responseCode == 200)
            {
                Debug.Log("せいこう!");
                Debug.Log(request.downloadHandler.text);
            }
            else
            {
                Debug.Log("しっぱい...:" + request.responseCode);
            }
        }

    }
}
