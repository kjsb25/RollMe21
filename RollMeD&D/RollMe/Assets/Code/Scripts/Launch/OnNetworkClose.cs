using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
public class OnNetworkClose : NetworkBehaviour{

    // Use this for initialization
    bool setClient = false;
  void Update()
    {
        if (!setClient) {
            if (isClient)
            {
                print("client status established");
                setClient = true;
                
            }
            return;
        }
        if (!isClient)
        {
            Destroy(this.gameObject);
        }
    }
}
