package com.witmotion.examples.label;

import core.model.result.ResponseResult;
import modular.cloud.login.LoginApiHelper;
import modular.cloud.login.Param.LoginParam;
import modular.cloud.v1EquipLabelApi.Entity.EquipLabelResult;
import modular.cloud.v1EquipLabelApi.EquipLabelApiHelper;
import modular.cloud.v1EquipLabelApi.Param.EquipLabelParam;


/**
 * 编辑设备标签
 *
 * @Author maoqiang
 * @Date 2022/12/15 14:29
 */
public class EditLabel {

    public static void main(String[] args) {
        // 登录
        login();
        // 编辑设备标签
        editEquipmentLabel();
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
     * 编辑设备标签
     *
     * @Author maoqiang
     * @Date 2022/12/8 10:50
     */
    public static void editEquipmentLabel(){
        EquipLabelParam equipLabelParam = new EquipLabelParam();
        equipLabelParam.setId(1603278067591286786L);    // 您的设备标签id
        equipLabelParam.setLabel("更改之后的标签名称"); // 您更改的标签名称
        ResponseResult<EquipLabelResult> result = EquipLabelApiHelper.edit(equipLabelParam);
        if(result.isSuccess()){
            System.out.println("\n编辑设备标签成功！");
        }else{
            System.out.println(result.getMessage());
        }
    }
}
