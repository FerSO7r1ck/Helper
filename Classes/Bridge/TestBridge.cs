using UnityEngine;
using System.Collections;
using System.Collections.Generic;
#if ENABLE_WINMD_SUPPORT
using IL2CPPToDotNetBridge;
#endif
public class TestBridge : MonoBehaviour
{
    void Awake()
    {
#if ENABLE_WINMD_SUPPORT
        BridgeBootstrapper.SetIL2CPPBridge(new IL2CPPBridge());
#endif
    }

    void Start()
    {
#if ENABLE_WINMD_SUPPORT
        var dotnetBridge = BridgeBootstrapper.GetDotNetBridge();
        dotnetBridge.MyFunction1();
        dotnetBridge.MyFunction2("Hello from il2cpp");
#endif
    }
}
