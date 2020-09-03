using QFSW.QC;
using UnityEngine;
public class QuantumCommands
{
    [Command(aliasOverride: "log")]
    [Command(aliasOverride: "print")]
    [CommandDescription("Logs a message to the console")]
    public static void Log(string message)
    {
        Debug.Log(message);
    }
}
