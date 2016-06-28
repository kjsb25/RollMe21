using UnityEngine;
using UnityEngine.Networking;
public class GUISelection : MonoBehaviour
{
    public GameObject GMGui, PlayerGui, PlayerCube, TestCube;
    void Start()
    {
        while (!Network.isClient)
        {

        }
        if (Network.isClient)
        {
            print("I am also a server");
            Instantiate(GMGui, new Vector3(0, 0, 0), Quaternion.identity);
        }
        else
        {
            Instantiate(TestCube, Vector3.zero, Quaternion.identity);
            Instantiate(PlayerGui, new Vector3(0, 0, 0), Quaternion.identity);
            Instantiate(PlayerCube, new Vector3(0, 0, 0), Quaternion.identity);
        }

        Destroy(this.gameObject);
        
        
    }
    

}