package com.witmotion.examples.equipment;

import core.model.result.ResponseResult;
import modular.cloud.login.LoginApiHelper;
import modular.cloud.login.Param.LoginParam;
import modular.cloud.v1EquipmentApi.Entity.EquipmentResult;
import modular.cloud.v1EquipmentApi.EquipmentApiHelper;
import modular.cloud.v1EquipmentApi.Param.EquipmentParam;

import java.util.List;

/**
 * 查询设备列表示例
 *
 * @Author maoqiang
 * @Date 2022/12/14 19:32
 */
public class QueryList {

    public static void main(String[] args) {
        // 登录
        login();
        // 获取设备列表
        equipmentList();
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
     * 列表查询设备列表
     *
     * @Author maoqiang
     * @Date 2022/12/8 10:50
     */
    public static void equipmentList(){
        ResponseResult<List<EquipmentResult>> result = EquipmentApiHelper.list(new EquipmentParam());
        if(result.isSuccess()){
            if(result.getData().size() == 0){
                System.out.println("\n查询成功，无设备绑定！");
                return;
            }
            System.out.println("\n查询设备列表成功！");
            System.out.println("设备列表第一个设备信息如下：");
            System.out.println("在线状态：" + result.getData().get(0).getOnlineStatus());
            System.out.println("最后在线时间：" + result.getData().get(0).getLastOnlineTime());
            System.out.println("设备号：" + result.getData().get(0).getNo());
            System.out.println("设备类型：" + result.getData().get(0).getType());
            System.out.println("数据存储数量：" + result.getData().get(0).getCurrentDataStorage());
            System.out.println("设备标签：" + result.getData().get(0).getLabels());
            System.out.println("设备项目：" + result.getData().get(0).getProjectId());
            System.out.println("设备状态：" + result.getData().get(0).getStatus());
        }else{
            System.out.println(result.getMessage());
        }
    }

}
