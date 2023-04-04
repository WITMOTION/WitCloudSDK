package com.witmotion.examples.equipment;

import core.model.result.ResponseResult;
import modular.cloud.login.LoginApiHelper;
import modular.cloud.login.Param.LoginParam;
import modular.cloud.v1EquipmentApi.Entity.EquipmentResult;
import modular.cloud.v1EquipmentApi.EquipmentApiHelper;
import modular.cloud.v1EquipmentApi.Param.EquipmentParam;


/**
 * 编辑设备信息示例
 *
 * @Author maoqiang
 * @Date 2022/12/14 19:34
 */
public class EditEquipment {

    public static void main(String[] args) {
        // 登录
        login();
        // 编辑设备信息
        editEquipment();
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
     * 编辑设备信息
     *
     * @Author maoqiang
     * @Date 2022/12/8 10:50
     */
    public static void editEquipment(){
        EquipmentParam equipmentParam = new EquipmentParam();
        equipmentParam.setId(1551489042042724353L); // 设备id
        equipmentParam.setName("WIFI温湿度传感器");  // 设备名称
        equipmentParam.setLabels("设备标签");        // 设备标签
        equipmentParam.setLabels("设备项目");        // 设备项目
        equipmentParam.setRemark("备注信息");        // 备注信息
        equipmentParam.setAddress("所在地址");       // 所在地址
        equipmentParam.setOnlineTimeout(30);        // 在线超时时间
        ResponseResult<EquipmentResult> result = EquipmentApiHelper.edit(equipmentParam);
        if(result.isSuccess()){
            System.out.println("\n编辑设备信息成功！");
        }else{
            System.out.println(result.getMessage());
        }
    }
}
