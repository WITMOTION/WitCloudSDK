package com.witmotion.examples.equipment;

import core.model.result.ResponseResult;
import modular.cloud.login.LoginApiHelper;
import modular.cloud.login.Param.LoginParam;
import modular.cloud.v1EquipmentApi.Entity.EquipmentResult;
import modular.cloud.v1EquipmentApi.EquipmentApiHelper;
import modular.cloud.v1EquipmentApi.Param.EquipmentParam;

/**
 * 查询设备详细信息示例
 *
 * @Author maoqiang
 * @Date 2022/12/14 19:34
 */
public class QueryDetail {

    public static void main(String[] args) {
        // 登录
        login();
        // 查询设备详情
        equipmentDetail();
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
     * 查询设备详情
     *
     * @Author maoqiang
     * @Date 2022/12/8 10:50
     */
    public static void equipmentDetail(){
        EquipmentParam equipmentParam = new EquipmentParam();
        equipmentParam.setId(1551489042042724353L); // 您的设备id
        ResponseResult<EquipmentResult> result = EquipmentApiHelper.detail(equipmentParam);
        if(result.isSuccess()){
            System.out.println("\n查询设备详情成功！");
            System.out.println("设备详情结果如下：");
            System.out.println("在线状态：" + result.getData().getOnlineStatus());
            System.out.println("最后在线时间：" + result.getData().getLastOnlineTime());
            System.out.println("设备号：" + result.getData().getNo());
            System.out.println("设备类型：" + result.getData().getType());
            System.out.println("数据存储数量：" + result.getData().getCurrentDataStorage());
            System.out.println("设备标签：" + result.getData().getLabels());
            System.out.println("设备项目：" + result.getData().getProjectId());
            System.out.println("设备状态：" + result.getData().getStatus());
        }else{
            System.out.println(result.getMessage());
        }
    }
}
