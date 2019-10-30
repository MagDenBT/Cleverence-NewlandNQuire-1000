package com.example.bridgelib;

import android.os.Handler;
import android.os.Message;

public class MyHandler extends Handler {

    private final ICleverenceHandler cleverenceHandler;

    public MyHandler(ICleverenceHandler cleverenceHandler) {
        this.cleverenceHandler = cleverenceHandler;
    }

    @Override
    public void handleMessage(Message msg) {
        switch (msg.what) {
            case StandartUsbService.MESSAGE_FROM_SERIAL_PORT:
                String data = (String) msg.obj;
                cleverenceHandler.OnScanedData(data);
                break;
            case StandartUsbService.CTS_CHANGE:
                cleverenceHandler.SomeChanged( "CTS_CHANGE");
                break;
            case StandartUsbService.DSR_CHANGE:
                cleverenceHandler.SomeChanged(  "DSR_CHANGE");
                break;
        }
    }
}
