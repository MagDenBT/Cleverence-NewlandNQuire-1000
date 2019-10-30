using System;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;
using Cleverence.Barcoding.Remote;
using Com.Example.Bridgelib;
using NewlandJavaLibs;
using static Com.Example.Bridgelib.StandartUsbService;

namespace Cleverence.Barcoding.Integration.Plugin
{
    public class CustomScanner : RemoteBarcodeScannerBase, ICleverenceHandler
    {
        public WrapperUsbService UsbService;
        public readonly MyHandler mHandler;
        private readonly MyBroadcastReceiver mUsbReceiver;
        private readonly MyServiceConnection UsbConnection;
        private readonly char[] ToTrim = { '\r' };
        private bool IsTurned;
     

        public CustomScanner(Context context)
            : base(context)
        {
            UsbConnection = new MyServiceConnection(this);
            mUsbReceiver = new MyBroadcastReceiver();
            mHandler = new MyHandler(this);
            IsTurned = false;
            SetFilters();  // Start listening notifications from UsbService
            StartService(typeof(WrapperUsbService), UsbConnection, null);
        }


        public override bool IsTurnedOn
        {
            get
            {
                return IsTurned;
            }
        }
       
        public override void TurnOn()
        {
            IsTurned = true;
        }

        public override void TurnOff()
        {
            IsTurned = false;
        }

        public override void BackupSymbologySettings()
        {
            base.BackupSymbologySettings();
        }

        public override void RestoreSymbologySettings()
        {
            base.RestoreSymbologySettings();
        }

        public override void DisableBarcodeType(BarcodeType type)
        {
            base.DisableBarcodeType(type);
        }

        public override void EnableBarcodeType(BarcodeType type, bool enableOnlyThis)
        {
            base.EnableBarcodeType(type, enableOnlyThis);
        }

        public override void EnableDefaultBarcodeTypes()
        {
            base.EnableDefaultBarcodeTypes();
        }

        public override bool ShowScanButton => base.ShowScanButton;

        public override bool IsQRCodeEnabled
        {
            get => base.IsQRCodeEnabled;
            set => base.IsQRCodeEnabled = value;
        }

        protected override void OnGlobalKeyDown(View.KeyEventArgs e)
        {
            base.OnGlobalKeyDown(e);
        }

        protected override void OnGlobalKeyPress(View.KeyEventArgs e)
        {
            base.OnGlobalKeyPress(e);
        }

        protected override void OnGlobalKeyUp(View.KeyEventArgs e)
        {
            base.OnGlobalKeyUp(e);
        }

        protected override void OnGlobalTouchEvent(View.TouchEventArgs e)
        {
            base.OnGlobalTouchEvent(e);
        }


        protected override void Dispose(bool disposing)
        {
            StopService();
            base.Dispose(disposing);
        }

        public void OnScanData(string text)
        {
            OnScan(text);
        }


        public override bool IsSettingsAvailable
        {
            get
            {
                return false;
            }
        }

        public override void ShowSettings()
        {

        }

        #region Custom methods
        private void StartService(Type service, MyServiceConnection serviceConnection, Bundle extras)
        {
            
            if (!WrapperUsbService.ServiceConnected)
            {
                Intent startService = new Intent(this.context, service);
                if (extras != null && !extras.IsEmpty)
                {
                    var keys = extras.KeySet();

                    foreach (string key in keys)
                    {
                        string extra = extras.GetString(key);
                        startService.PutExtra(key, extra);
                    }
                }
                context.StartService(startService);

            }
            Intent bindingIntent = new Intent(this.context, service);
            context.BindService(bindingIntent, serviceConnection, Bind.AutoCreate);   
        }

        private void StopService()
        {
            UsbService.SetHandler(null);
            context.UnregisterReceiver(mUsbReceiver);
            context.UnbindService(UsbConnection);
        }
        private void SetFilters()
        {
            IntentFilter filter = new IntentFilter();
            filter.AddAction(WrapperUsbService.ActionUsbPermissionGranted);
            filter.AddAction(WrapperUsbService.ActionNoUsb);
            filter.AddAction(WrapperUsbService.ActionUsbDisconnected);
            filter.AddAction(WrapperUsbService.ActionUsbNotSupported);
            filter.AddAction(WrapperUsbService.ActionUsbPermissionNotGranted);
            context.RegisterReceiver(mUsbReceiver, filter);
        }

        public void OnScanedData(string p0)
        {
            if (IsTurned && p0.Length != 0)
            {
                if (p0.Contains("\r"))
                    OnScan(p0.TrimEnd(ToTrim));
                else
                    OnScan(p0);
            }
        }

        public void SomeChanged(string p0)
        {
            string d = p0;
        }


        #endregion Custom methods


        #region Custom classes




        private class MyBroadcastReceiver : BroadcastReceiver
        {

            public override void OnReceive(Context context, Intent intent)
            {
                switch (intent.Action)
                {
                    case WrapperUsbService.ActionUsbPermissionGranted: // USB PERMISSION GRANTED
                        Toast.MakeText(context, "USB-сканер кич ю", ToastLength.Short).Show();
                        break;
                    case WrapperUsbService.ActionUsbPermissionNotGranted: // USB PERMISSION NOT GRANTED
                        Toast.MakeText(context, "Нет доступа к USB-сканеру, перезагрузите прайсчекер", ToastLength.Long).Show();
                        break;
                    case WrapperUsbService.ActionNoUsb: // NO USB CONNECTED
                        Toast.MakeText(context, "Нет соединения с USB-сканером", ToastLength.Long).Show();
                        break;
                    case WrapperUsbService.ActionUsbDisconnected: // USB DISCONNECTED
                        Toast.MakeText(context, "USB-сканер отключен", ToastLength.Short).Show();
                        break;
                    case WrapperUsbService.ActionUsbNotSupported: // USB NOT SUPPORTED
                        Toast.MakeText(context, "USB-сканер не поддерживается.Звони Юсуфу", ToastLength.Long).Show();
                        break;
                }
            }
        };


        class MyServiceConnection : Java.Lang.Object, IServiceConnection
        {


            private readonly CustomScanner scanner;
            public MyServiceConnection() { }
            public MyServiceConnection(CustomScanner scanner)

            {

                this.scanner = scanner;
            }

            public virtual void OnServiceConnected(ComponentName arg0, IBinder arg1)
            {
                UsbBinder usbBinder = (WrapperUsbService.UsbBinder)arg1;
                scanner.UsbService = (WrapperUsbService)usbBinder.Service;
                scanner.UsbService.SetHandler(scanner.mHandler);
            }


            public virtual void OnServiceDisconnected(ComponentName arg0)
            {
                {
                    scanner.UsbService = null;
                }
            }

        }
        #endregion Custom classes

    }
}