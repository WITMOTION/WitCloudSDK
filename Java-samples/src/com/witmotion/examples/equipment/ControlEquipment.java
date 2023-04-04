package com.witmotion.examples.equipment;

import core.model.result.ResponseResult;
import modular.cloud.login.LoginApiHelper;
import modular.cloud.login.Param.LoginParam;
import modular.cloud.v1EquipmentApi.Entity.EquipmentResult;
import modular.cloud.v1EquipmentApi.EquipmentApiHelper;
import modular.cloud.v1EquipmentApi.Param.SendDataParam;

/**
 * 控制设备示例
 *
 * @Author maoqiang
 * @Date 2022/12/14 19:35
 */
public class ControlEquipment {

    public static void main(String[] args) {
        // 登录
        login();
        // 控制设备
        controlEquipment();
    }


    /**
     * 登录
     *
     * @Author maoqiang
     * @Date 2022/12/8 10:48
     */
    public static void login(){
        LoginParam loginParam = new LoginParam();
        loginParam.setAppId("wt5554c899a8074170a1adbeee2c5b02a9"); // 您的api账号
        loginParam.setAppSecret("5e86eab6t5tc");                   // 您的api密码
        ResponseResult<String> result = LoginApiHelper.login(loginParam);
        if(result.isSuccess()){
            System.out.println("登录成功！");
            System.out.println("登录身份 data=>：" + result.getData());
        }else{
            System.out.println(result.getMessage());
        }
    }

    /**
     * 发送命令控制设备
     *
     * @Author maoqiang
     * @Date 2022/12/8 10:50
     */
    public static void controlEquipment(){
        SendDataParam sendDataParam = new SendDataParam();
        sendDataParam.setEquipmentId(1551489042042724353L); // 您的设备id
        sendDataParam.setCmd("FF AA 01 01 00");             // 您需要发送的命令
        sendDataParam.setHex(false);                        // 是否为16进制
        sendDataParam.setName("加计校准");                   // 操作名称
        ResponseResult<EquipmentResult> result = EquipmentApiHelper.sendData(sendDataParam);
        if(result.isSuccess()){
            System.out.println("\n发送命令成功！");
        }else{
            System.out.println(result.getMessage());
        }
    }
}
