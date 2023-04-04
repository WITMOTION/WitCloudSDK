package com.witmotion.examples.label;

import core.model.result.ResponseResult;
import modular.cloud.login.LoginApiHelper;
import modular.cloud.login.Param.LoginParam;
import modular.cloud.v1EquipLabelApi.Entity.EquipLabelResult;
import modular.cloud.v1EquipLabelApi.EquipLabelApiHelper;
import modular.cloud.v1EquipLabelApi.Param.EquipLabelParam;

import java.util.List;

/**
 * 查询设备标签列表
 *
 * @Author maoqiang
 * @Date 2022/12/15 14:29
 */
public class LabelList {

    public static void main(String[] args) {
        // 登录
        login();
        // 查询设备标签列表
        equipmentLabelList();
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
     * 查询设备标签列表
     *
     * @Author maoqiang
     * @Date 2022/12/8 10:50
     */
    public static void equipmentLabelList(){
        EquipLabelParam equipLabelParam = new EquipLabelParam();
        ResponseResult<List<EquipLabelResult>> result = EquipLabelApiHelper.list(equipLabelParam);
        if(result.isSuccess()){
            if(result.getData().size() == 0){
                System.out.println("\n查询成功，无设备标签！");
                return;
            }
            System.out.println("\n查询设备标签列表成功！");
            System.out.println("列表第一行设备标签如下：");
            System.out.println("标签名称：" + result.getData().get(0).getLabel());
            System.out.println("拥有者：" + result.getData().get(0).getOwnerUser());
            System.out.println("创建时间：" + result.getData().get(0).getCreateTime());
            System.out.println("更新时间：" + result.getData().get(0).getUpdateTime());
            System.out.println("创建用户：" + result.getData().get(0).getCreateUser());
            System.out.println("更新用户：" + result.getData().get(0).getUpdateUser());
        }else{
            System.out.println(result.getMessage());
        }
    }
}
