using Android.Content;
using Cleverence.Barcoding.Remote;

namespace Cleverence.Barcoding.Integration.Plugin
{
    public class CustomMobileComputer : RemoteBarcodeDeviceBase
    {
        protected Context context;

        public CustomMobileComputer(Context context)
        {
            this.context = context;
        }
        public override int BatteryLifePercent => base.BatteryLifePercent;

        public override string GetDeviceName()
        {
            return base.GetDeviceName();
        }

        public virtual CustomScanner Scanner
        {
            get { return Scanner; }
        }

        public void TurnOnScanner()
        {
            if (this.Scanner != null)
                this.Scanner.TurnOn();
        }

        public void TurnOffScanner()
        {
            if (this.Scanner != null)
                this.Scanner.TurnOff();
        }
 
        public virtual bool IsConnected
        {
            get
            {
                return true;
            }
        }

        public virtual bool IsPriceChecker
        {
            get
            {
                return false;
            }
        }

        public virtual bool IsAndroid
        {
            get
            {
                return true;
            }
        }

        public override bool HasNumericKeyboard
        {
            get
            {
                return false;
            }
        }

        /// <summary>
        /// Для совместимости (в Win-клиенте и CE есть такое свойство).
        /// </summary>
        public bool NoKeyboard
        {
            get
            {
                return !HasKeyboard;
            }
        }

        /// <summary>
        /// Имеет ли терминал физические кнопки стрелок вверх, вниз, влево, вправо
        /// </summary>
        public override bool HasArrows
        {
            get
            {
                return false;
            }
        }

        public override bool ForceHideActionBar
        {
            get
            {
                return false;
            }
        }


        public override bool HasKeyboard
        {
            get
            {
                return false;
            }
        }

        public override void Wakeup()
        {
            base.Wakeup();
        }
    }
}