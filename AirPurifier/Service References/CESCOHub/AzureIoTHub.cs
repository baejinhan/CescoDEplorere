using System;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.Devices.Client;
using CESCO.IoT.DeviceManagement;
using System.Collections.Generic;

static class AzureIoTHub
{
    //
    // Note: this connection string is specific to the device "CESCO01". To configure other devices,
    // see information on iothub-explorer at http://aka.ms/iothubgetstartedVSCS
    //
    const string deviceConnectionString = "";
    static List<DeviceEntity> devices = null;
    static AzureIoTHub()
    {

    }

    //연결 문자열 찾기
    public static string GetDeviceConnectionString(string deviceID)
    {
        CESCO.IoT.DeviceManagement.DeviceManager manager = new CESCO.IoT.DeviceManagement.DeviceManager();
        var connstring = manager.GetDevice(deviceID).Result.ConnectionString;
        return connstring;
    }

    public static async Task SendDeviceToCloudMessageAsync(string deviceID, string mesage)
    {
        var deviceClient = DeviceClient.CreateFromConnectionString(AzureIoTHub.GetDeviceConnectionString(deviceID), TransportType.Amqp);
        var str = mesage;
        var message = new Message(Encoding.ASCII.GetBytes(str));

        await deviceClient.SendEventAsync(message);
    }

    public static async Task<string> ReceiveCloudToDeviceMessageAsync()
    {
        var deviceClient = DeviceClient.CreateFromConnectionString(deviceConnectionString, TransportType.Amqp);
        try
        {
            while (true)
            {
                var receivedMessage = await deviceClient.ReceiveAsync();

                if (receivedMessage != null)
                {
                    var messageData = Encoding.ASCII.GetString(receivedMessage.GetBytes());
                    await deviceClient.CompleteAsync(receivedMessage);
                    Console.WriteLine(messageData);
                }

                await Task.Delay(TimeSpan.FromSeconds(1));
            }
        }
        finally
        {
        }
    }

}
