using Android.Gms.Common.Logging;
using BionicApp;
using BionicApp.Data;
using Google.Android.Material.Snackbar;
using Java.Security;
using MudBlazor;
using Ossur.Bionics.Common.Models.Peripherals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Snackbar = MudBlazor.Snackbar;

namespace BionicAppTestRunner.BionicApp
{
    public class Add_Device
    {
        [Fact]
        public void OnDeviceDisconnect()
        {
            try
            {
                object deviceModel = null;
                logger.Info("The selected device disconnected:{0}", deviceModel.SerialName);
                deviceModel.IsProcessing = false;
                deviceModel.BleIcon = "/images/bluetooth.png";
                deviceModel.Peripheral.Dispose();
                Snackbar.Clear();
                Snackbar.Add("Device disconnected", Severity.Info);
                UpdateUI();
            }
            catch (Exception ex)
            {
                Logger.Error("Exception while disconnecting device:" + deviceModel.SerialName, ex);
            }
        }

        [Fact]
        public void OnAddDevicesClick()
        {
            logger.Info("Add device button clicked in my devices page");
            carouselNavAdapter.SelectedIndex = 1;

            //var request = new Plugin.LocalNotification.NotificationRequest
            //{
            //    NotificationId = 1000,
            //    Title = "Subscribe for me",
            //    Subtitle = "Hello Friends",
            //    Description = "Stay Tuned",
            //    BadgeNumber = 42,
            //    Schedule = new Plugin.LocalNotification.NotificationRequestSchedule
            //    {
            //        NotifyTime = DateTime.Now.AddSeconds(5),
            //        NotifyRepeatInterval = TimeSpan.FromDays(1)
            //    }
            //};
            //Plugin.LocalNotification.LocalNotificationCenter.Current.Show(request);

        }


    }
}


