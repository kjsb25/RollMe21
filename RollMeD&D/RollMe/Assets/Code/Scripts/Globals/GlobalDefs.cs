using UnityEngine;
using System.Collections;

public static class GlobalDefs
{
    public const string LocalIP = "192.168.1.86";

}

namespace globals
{
    enum NetworkAuthority
    {
        Server, Host, Client
    }
}