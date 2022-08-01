
using UnityEngine;
#if ENABLE_WINMD_SUPPORT
using IL2CPPToDotNetBridge;


class IL2CPPBridge : IIL2CPPBridge
{
    public void MyFunction3()
    {
        Debug.Log("Inside MyFunction3");
    }

    public void MyFunction4(int arg)
    {
        Debug.Log("Inside MyFunction4: " + arg);
    }
}
#endif

