package com.witmotion.examples.project;

import core.model.result.ResponseResult;
import modular.cloud.login.LoginApiHelper;
import modular.cloud.login.Param.LoginParam;
import modular.cloud.v1EquipProjectApi.Entity.EquipProjectResult;
import modular.cloud.v1EquipProjectApi.EquipProjectApiHelper;
import modular.cloud.v1EquipProjectApi.Param.EquipProjectParam;

/**
 * 编辑设备项目
 *
 * @Author maoqiang
 * @Date 2022/12/15 14:50
 */
public class EditProject {

    public static void main(String[] args) {
        // 登录
        login();
        // 编辑设备项目
        editEquipmentProject();
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
     * 编辑设备项目
     *
     * @Author maoqiang
     * @Date 2022/12/8 10:50
     */
    public static void editEquipmentProject(){
        EquipProjectParam equipProjectParam = new EquipProjectParam();
        equipProjectParam.setId(1602593100074848258L); // 您的设备项目id
        equipProjectParam.setName("编辑设备项目");      // 更改的设备项目名称
        ResponseResult<EquipProjectResult> result = EquipProjectApiHelper.edit(equipProjectParam);
        if(result.isSuccess()){
            System.out.println("\n编辑设备项目成功！");
        }else{
            System.out.println(result.getMessage());
        }
    }
}
