using UnityEngine;

/// <summary>
/// Sends a message to the serial port whenever this method is called.
/// Cooldown, port readiness, and error checking are handled in SerialPortManagerFlexible.SendSafe().
/// </summary>
public class SendToSerialOnWhenever : MonoBehaviour
{
    private SerialPortManager spManager; // Get access to the serialport defined in the SerialPortManager
    public string messageToSerial = ""; // What message to send to the serialPort



    /// <summary>
    /// Call this method SendToSerial() whenever you want to send the message
    /// </summary>
    public void SendToSerial()
    {
        spManager.SendSafe(messageToSerial);
    }


    // Start is called before the first frame update
    void Start()
    {
        spManager = SerialPortManager.instance;  // Obtain the serial port from the manager                                              

        if (spManager == null)
        {
            Debug.LogError("SerialPortManager not found!");
            enabled = false;
            return;
        }
    }










}
