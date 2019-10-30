using System;
using System.Collections.Generic;
using Android.App;
using Android.Runtime;
using Java.Interop;
using static Android.Manifest;
using static Java.Util.Jar.Attributes;

namespace Com.Magde.Newlandbridge.Bridgelibrary {
    
	// Metadata.xml XPath class reference: path="/api/package[@name='com.magde.newlandbridge.bridgelibrary']/class[@name='StandartUsbService']"
	[global::Android.Runtime.Register ("com/magde/newlandbridge/bridgelibrary/StandartUsbService", DoNotGenerateAcw=true)]
    [Service(Exported = true, Name = "magdenbt.com.driver.newlandnls_nquire1000")]
    public partial class StandartUsbService : global::Android.App.Service {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.magde.newlandbridge.bridgelibrary']/class[@name='StandartUsbService']/field[@name='ACTION_CDC_DRIVER_NOT_WORKING']"
		[Register ("ACTION_CDC_DRIVER_NOT_WORKING")]
		public const string ActionCdcDriverNotWorking = (string) "com.felhr.connectivityservices.ACTION_CDC_DRIVER_NOT_WORKING";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.magde.newlandbridge.bridgelibrary']/class[@name='StandartUsbService']/field[@name='ACTION_NO_USB']"
		[Register ("ACTION_NO_USB")]
		public const string ActionNoUsb = (string) "com.felhr.usbservice.NO_USB";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.magde.newlandbridge.bridgelibrary']/class[@name='StandartUsbService']/field[@name='ACTION_USB_ATTACHED']"
		[Register ("ACTION_USB_ATTACHED")]
		public const string ActionUsbAttached = (string) "android.hardware.usb.action.USB_DEVICE_ATTACHED";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.magde.newlandbridge.bridgelibrary']/class[@name='StandartUsbService']/field[@name='ACTION_USB_DETACHED']"
		[Register ("ACTION_USB_DETACHED")]
		public const string ActionUsbDetached = (string) "android.hardware.usb.action.USB_DEVICE_DETACHED";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.magde.newlandbridge.bridgelibrary']/class[@name='StandartUsbService']/field[@name='ACTION_USB_DEVICE_NOT_WORKING']"
		[Register ("ACTION_USB_DEVICE_NOT_WORKING")]
		public const string ActionUsbDeviceNotWorking = (string) "com.felhr.connectivityservices.ACTION_USB_DEVICE_NOT_WORKING";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.magde.newlandbridge.bridgelibrary']/class[@name='StandartUsbService']/field[@name='ACTION_USB_DISCONNECTED']"
		[Register ("ACTION_USB_DISCONNECTED")]
		public const string ActionUsbDisconnected = (string) "com.felhr.usbservice.USB_DISCONNECTED";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.magde.newlandbridge.bridgelibrary']/class[@name='StandartUsbService']/field[@name='ACTION_USB_NOT_SUPPORTED']"
		[Register ("ACTION_USB_NOT_SUPPORTED")]
		public const string ActionUsbNotSupported = (string) "com.felhr.usbservice.USB_NOT_SUPPORTED";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.magde.newlandbridge.bridgelibrary']/class[@name='StandartUsbService']/field[@name='ACTION_USB_PERMISSION_GRANTED']"
		[Register ("ACTION_USB_PERMISSION_GRANTED")]
		public const string ActionUsbPermissionGranted = (string) "com.felhr.usbservice.USB_PERMISSION_GRANTED";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.magde.newlandbridge.bridgelibrary']/class[@name='StandartUsbService']/field[@name='ACTION_USB_PERMISSION_NOT_GRANTED']"
		[Register ("ACTION_USB_PERMISSION_NOT_GRANTED")]
		public const string ActionUsbPermissionNotGranted = (string) "com.felhr.usbservice.USB_PERMISSION_NOT_GRANTED";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.magde.newlandbridge.bridgelibrary']/class[@name='StandartUsbService']/field[@name='ACTION_USB_READY']"
		[Register ("ACTION_USB_READY")]
		public const string ActionUsbReady = (string) "com.felhr.connectivityservices.USB_READY";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.magde.newlandbridge.bridgelibrary']/class[@name='StandartUsbService']/field[@name='CTS_CHANGE']"
		[Register ("CTS_CHANGE")]
		public const int CtsChange = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.magde.newlandbridge.bridgelibrary']/class[@name='StandartUsbService']/field[@name='DSR_CHANGE']"
		[Register ("DSR_CHANGE")]
		public const int DsrChange = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.magde.newlandbridge.bridgelibrary']/class[@name='StandartUsbService']/field[@name='MESSAGE_FROM_SERIAL_PORT']"
		[Register ("MESSAGE_FROM_SERIAL_PORT")]
		public const int MessageFromSerialPort = (int) 0;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.magde.newlandbridge.bridgelibrary']/class[@name='StandartUsbService']/field[@name='SERVICE_CONNECTED']"
		[Register ("SERVICE_CONNECTED")]
		public static bool ServiceConnected {
			get {
				const string __id = "SERVICE_CONNECTED.Z";

				var __v = _members.StaticFields.GetBooleanValue (__id);
				return __v;
			}
			set {
				const string __id = "SERVICE_CONNECTED.Z";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.magde.newlandbridge.bridgelibrary']/class[@name='StandartUsbService']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "UsbService";
		// Metadata.xml XPath class reference: path="/api/package[@name='com.magde.newlandbridge.bridgelibrary']/class[@name='StandartUsbService.ConnectionThread']"
		[global::Android.Runtime.Register ("com/magde/newlandbridge/bridgelibrary/StandartUsbService$ConnectionThread", DoNotGenerateAcw=true)]
		protected internal partial class ConnectionThread : global::Java.Lang.Thread {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/magde/newlandbridge/bridgelibrary/StandartUsbService$ConnectionThread", typeof (ConnectionThread));
			internal static new IntPtr class_ref {
				get {
					return _members.JniPeerType.PeerReference.Handle;
				}
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			protected ConnectionThread (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.magde.newlandbridge.bridgelibrary']/class[@name='StandartUsbService.ConnectionThread']/constructor[@name='StandartUsbService.ConnectionThread' and count(parameter)=1 and parameter[1][@type='com.magde.newlandbridge.bridgelibrary.StandartUsbService']]"
			[Register (".ctor", "(Lcom/magde/newlandbridge/bridgelibrary/StandartUsbService;)V", "")]
			protected unsafe ConnectionThread (global::Com.Magde.Newlandbridge.Bridgelibrary.StandartUsbService __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				string __id = "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((__self == null) ? IntPtr.Zero : ((global::Java.Lang.Object) __self).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.magde.newlandbridge.bridgelibrary']/class[@name='StandartUsbService.UsbBinder']"
		[global::Android.Runtime.Register ("com/magde/newlandbridge/bridgelibrary/StandartUsbService$UsbBinder", DoNotGenerateAcw=true)]
		public partial class UsbBinder : global::Android.OS.Binder {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/magde/newlandbridge/bridgelibrary/StandartUsbService$UsbBinder", typeof (UsbBinder));
			internal static new IntPtr class_ref {
				get {
					return _members.JniPeerType.PeerReference.Handle;
				}
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			protected UsbBinder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.magde.newlandbridge.bridgelibrary']/class[@name='StandartUsbService.UsbBinder']/constructor[@name='StandartUsbService.UsbBinder' and count(parameter)=1 and parameter[1][@type='com.magde.newlandbridge.bridgelibrary.StandartUsbService']]"
			[Register (".ctor", "(Lcom/magde/newlandbridge/bridgelibrary/StandartUsbService;)V", "")]
			public unsafe UsbBinder (global::Com.Magde.Newlandbridge.Bridgelibrary.StandartUsbService __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				string __id = "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((__self == null) ? IntPtr.Zero : ((global::Java.Lang.Object) __self).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_getService;
#pragma warning disable 0169
			static Delegate GetGetServiceHandler ()
			{
				if (cb_getService == null)
					cb_getService = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetService);
				return cb_getService;
			}

			static IntPtr n_GetService (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Magde.Newlandbridge.Bridgelibrary.StandartUsbService.UsbBinder __this = global::Java.Lang.Object.GetObject<global::Com.Magde.Newlandbridge.Bridgelibrary.StandartUsbService.UsbBinder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Service);
			}
#pragma warning restore 0169

			public virtual unsafe global::Com.Magde.Newlandbridge.Bridgelibrary.StandartUsbService Service {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.magde.newlandbridge.bridgelibrary']/class[@name='StandartUsbService.UsbBinder']/method[@name='getService' and count(parameter)=0]"
				[Register ("getService", "()Lcom/magde/newlandbridge/bridgelibrary/StandartUsbService;", "GetGetServiceHandler")]
				get {
					const string __id = "getService.()Lcom/magde/newlandbridge/bridgelibrary/StandartUsbService;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Magde.Newlandbridge.Bridgelibrary.StandartUsbService> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/magde/newlandbridge/bridgelibrary/StandartUsbService", typeof (StandartUsbService));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected StandartUsbService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.magde.newlandbridge.bridgelibrary']/class[@name='StandartUsbService']/constructor[@name='StandartUsbService' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe StandartUsbService ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onBind_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetOnBind_Landroid_content_Intent_Handler ()
		{
			if (cb_onBind_Landroid_content_Intent_ == null)
				cb_onBind_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnBind_Landroid_content_Intent_);
			return cb_onBind_Landroid_content_Intent_;
		}

		static IntPtr n_OnBind_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_intent)
		{
			global::Com.Magde.Newlandbridge.Bridgelibrary.StandartUsbService __this = global::Java.Lang.Object.GetObject<global::Com.Magde.Newlandbridge.Bridgelibrary.StandartUsbService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent intent = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_intent, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnBind (intent));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.magde.newlandbridge.bridgelibrary']/class[@name='StandartUsbService']/method[@name='onBind' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;", "GetOnBind_Landroid_content_Intent_Handler")]
		public override unsafe global::Android.OS.IBinder OnBind (global::Android.Content.Intent intent)
		{
			const string __id = "onBind.(Landroid/content/Intent;)Landroid/os/IBinder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setHandler_Landroid_os_Handler_;
#pragma warning disable 0169
		static Delegate GetSetHandler_Landroid_os_Handler_Handler ()
		{
			if (cb_setHandler_Landroid_os_Handler_ == null)
				cb_setHandler_Landroid_os_Handler_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHandler_Landroid_os_Handler_);
			return cb_setHandler_Landroid_os_Handler_;
		}

		static void n_SetHandler_Landroid_os_Handler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mHandler)
		{
			global::Com.Magde.Newlandbridge.Bridgelibrary.StandartUsbService __this = global::Java.Lang.Object.GetObject<global::Com.Magde.Newlandbridge.Bridgelibrary.StandartUsbService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Handler mHandler = global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (native_mHandler, JniHandleOwnership.DoNotTransfer);
			__this.SetHandler (mHandler);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.magde.newlandbridge.bridgelibrary']/class[@name='StandartUsbService']/method[@name='setHandler' and count(parameter)=1 and parameter[1][@type='android.os.Handler']]"
		[Register ("setHandler", "(Landroid/os/Handler;)V", "GetSetHandler_Landroid_os_Handler_Handler")]
		public virtual unsafe void SetHandler (global::Android.OS.Handler mHandler)
		{
			const string __id = "setHandler.(Landroid/os/Handler;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mHandler).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_write_arrayB;
#pragma warning disable 0169
		static Delegate GetWrite_arrayBHandler ()
		{
			if (cb_write_arrayB == null)
				cb_write_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Write_arrayB);
			return cb_write_arrayB;
		}

		static void n_Write_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_data)
		{
			global::Com.Magde.Newlandbridge.Bridgelibrary.StandartUsbService __this = global::Java.Lang.Object.GetObject<global::Com.Magde.Newlandbridge.Bridgelibrary.StandartUsbService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] data = (byte[]) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Write (data);
			if (data != null)
				JNIEnv.CopyArray (data, native_data);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.magde.newlandbridge.bridgelibrary']/class[@name='StandartUsbService']/method[@name='write' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("write", "([B)V", "GetWrite_arrayBHandler")]
		public virtual unsafe void Write (byte[] data)
		{
			const string __id = "write.([B)V";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_data);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

	}
}
