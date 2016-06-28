using UnityEngine;
using System.Collections;
using UnityEngine.Networking;


public class MyNetworkManager : MonoBehaviour {
    public bool isAtStartup = true;
    private GameStateManager myGameStateManager;
    NetworkClient myClient;
	// Update is called once per frame
    void Start()
    {
        myGameStateManager = GameObject.FindGameObjectWithTag("GameStateManager").GetComponent(typeof(GameStateManager)) as GameStateManager;
    }
	void Update () {

        if (isAtStartup)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                HostGame();
                
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                JoinGame();
            }

        }

	}

    void OnGUI()
    {
        if (isAtStartup)
        {
            GUI.Label(new Rect(2, 10, 150, 100), "Press A to Host");
            GUI.Label(new Rect(2, 30, 150, 100), "Press S to Join");
        }
    }

    public void HostGame()
    {
        NetworkServer.Listen(4444);
        isAtStartup = false;

        myClient = ClientScene.ConnectLocalServer();
        myClient.RegisterHandler(MsgType.Connect, OnConnected);
        myGameStateManager.MakeHost();
    }

    public void JoinGame()
    {
        myClient = new NetworkClient();
        myClient.RegisterHandler(MsgType.Connect, OnConnected);
        myClient.Connect(GlobalDefs.LocalIP, 4444);
        isAtStartup = false;
        myGameStateManager.MakeClient();

    }

    public void OnConnected(NetworkMessage netMsg)
    {
        print("Connected to server");
    }
}
