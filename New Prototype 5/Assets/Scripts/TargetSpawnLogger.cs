using UnityEngine;
using System.Diagnostics;

public class TargetSpawnLogger : MonoBehaviour
{
    void Awake()
    {
        UnityEngine.Debug.Log($"[TargetSpawnLogger] Target instantiated at {Time.time} seconds - Name: {gameObject.name}");

        // Print call stack to see where Instantiate was called from
        StackTrace stackTrace = new StackTrace(true);
        string stackInfo = "Instantiation call stack:\n";

        // Skip the first few frames related to this Awake method
        for (int i = 1; i < stackTrace.FrameCount; i++)
        {
            var frame = stackTrace.GetFrame(i);
            stackInfo += $"at {frame.GetMethod()} in {frame.GetFileName()}:line {frame.GetFileLineNumber()}\n";
        }

        UnityEngine.Debug.Log(stackInfo);
    }
}
