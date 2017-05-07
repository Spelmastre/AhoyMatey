using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MyNetworkManager : NetworkManager {
    
    public void MyStartHost()
    {
        //string timeStamp = System.DateTime.Now.ToString();
        Debug.Log(Time.timeSinceLevelLoad + " Network Host Starting");
        StartHost();        
    }

	public override void OnStartHost()
    {
        Debug.Log(Time.timeSinceLevelLoad + " Host Started");
    }

    public override void OnStartClient(NetworkClient client)
    {
        Debug.Log(Time.timeSinceLevelLoad + " Client Start Requested");
        InvokeRepeating("PrintDot", 0f, 1f);
    }

    public override void OnClientConnect(NetworkConnection conn)
    {
        Debug.Log(Time.timeSinceLevelLoad + " Cilent is connected to IP: " + conn.address);
        CancelInvoke();
    }

    void PrintDot()
    {
        Debug.Log(".");
    }
}
