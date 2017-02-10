using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CESCO.IoT.ControllerClient
{
    public class DataAccess
    {
         public HeartbeatEntity GetDeviceInfomation(string deviceID)
        {
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(Properties.Settings.Default.StorageConnectionString);
            CloudTableClient tableClient = storageAccount.CreateCloudTableClient();

            CloudTable heartbeatTable = tableClient.GetTableReference("heartbeat");

            TableOperation searchOp = TableOperation.Retrieve<HeartbeatEntity>(deviceID.Substring(5), deviceID);
            TableResult result =  heartbeatTable.Execute(searchOp);

            HeartbeatEntity resultboj = (HeartbeatEntity)result.Result;
            return resultboj;
        }


    }
}
