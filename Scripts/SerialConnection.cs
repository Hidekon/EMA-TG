using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class SerialConnection : MonoBehaviour
{
    SerialPort data_stream = new SerialPort("COM3", 115200);
    public string receivedstring;
    public GameObject test_data;



    void Start()
    {
        data_stream.Open();    
    }

    // Update is called once per frame
    void Update()
    {
        receivedstring = data_stream.ReadLine();

        string[] datas = receivedstring.Split(',');

        Debug.Log(datas);
    }
}
