package com.witmotion.examples.project;

import core.model.result.ResponseResult;
import modular.cloud.login.LoginApiHelper;
import modular.cloud.login.Param.LoginParam;
import modular.cloud.v1EquipProjectApi.Entity.EquipProjectResult;
import modular.cloud.v1EquipProjectApi.EquipProjectApiHelper;
import modular.cloud.v1EquipProjectApi.Param.EquipProjectParam;

/**
 * 删除设备项目
 *
 * @Author maoqiang
 * @Date 2022/12/15 15:10
 */
public class DeleteProject {

    public static void main(String[] args) {
        // 登录
        login();
        // 删除设备项目
        deleteEquipmentProject();
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
     * 删除设备项目
     *
     * @Author maoqiang
     * @Date 2022/12/8 10:50
     */
    public static void deleteEquipmentProject(){
        EquipProjectParam equipProjectParam = new EquipProjectParam();
        equipProjectParam.setId(1603286364692156418L); // 您的设备项目id
        ResponseResult<EquipProjectResult> result = EquipProjectApiHelper.delete(equipProjectParam);
        if(result.isSuccess()){
            System.out.println("\n删除设备项目成功！");
        }else{
            System.out.println(result.getMessage());
        }
    }
}
