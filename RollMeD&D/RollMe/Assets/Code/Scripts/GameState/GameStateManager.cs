using UnityEngine;
using System.Collections;
using globals;
public class GameStateManager : MonoBehaviour {
    private NetworkAuthority myNetworkAuthority;
    private GameObject GMLaunchGUI;
    private GameObject PlayerLaunchGUI;
    private GameObject GMOverlayGUI;
    private GameObject PlayerOverlayGUI;
	// Use this for initialization
	void Start () {
        GMLaunchGUI = Resources.Load("UI/GMLaunchGUI") as GameObject;
        PlayerLaunchGUI = Resources.Load("UI/PlayerLaunchGUI") as GameObject;
        GMOverlayGUI = Resources.Load("UI/GMOverlayGUI") as GameObject;
        PlayerOverlayGUI = Resources.Load("UI/PlayerOverlayGUI") as GameObject;

       

    }
	
	


    public void MakeHost()
    {
        myNetworkAuthority = NetworkAuthority.Host;
        print("NetworkAuthority :: Host");
        Instantiate(GMLaunchGUI, Vector3.zero, Quaternion.identity);

    }

    public void MakeClient()
    {
        myNetworkAuthority = NetworkAuthority.Client;
        print("NetworkAuthority :: Client");
        Instantiate(PlayerLaunchGUI, Vector3.zero, Quaternion.identity);
    }
}
