package com.witmotion.examples.equipment.recordData;

import core.model.param.PageParam;
import core.model.result.PageResult;
import core.model.result.ResponseResult;
import modular.cloud.login.LoginApiHelper;
import modular.cloud.login.Param.LoginParam;
import modular.cloud.v1EquipAlarmApi.Entity.EquipAlarmResult;
import modular.cloud.v1EquipAlarmApi.EquipAlarmHelper;
import modular.cloud.v1EquipAlarmApi.Param.EquipAlarmParam;

import java.util.List;

/**
 * 查询历史报警记录示例
 *
 * @Author maoqiang
 * @Date 2022/12/15 8:52
 */

public class QueryAlarmData {

    public static void main(String[] args) {
        // 登录
        login();
        // 列表查询历史报警记录
        equipmentAlarmList();
        // 分页查询历史报警记录
        equipmentAlarmPage();
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
     * 列表查询历史报警记录
     *
     * @Author maoqiang
     * @Date 2022/12/8 10:50
     */
    public static void equipmentAlarmList(){
        ResponseResult<List<EquipAlarmResult>> result = EquipAlarmHelper.list(new EquipAlarmParam());
        if(result.isSuccess()){
            if(result.getData().size() == 0){
                System.out.println("\n查询成功，无历史报警记录！");
                return;
            }
            System.out.println("\n列表查询历史报警成功！");
            System.out.println("列表第一行报警记录如下：");
            System.out.println("报警设备：" + result.getData().get(0).getEquipment());
            System.out.println("报警摘要：" + result.getData().get(0).getSummary());
            System.out.println("报警信息：" + result.getData().get(0).getContent());
            System.out.println("报警状态：" + result.getData().get(0).getStatus());
            System.out.println("查看人：" + result.getData().get(0).getLookUser());
            System.out.println("查看时间：" + result.getData().get(0).getLookTime());
            System.out.println("创建时间：" + result.getData().get(0).getCreateTime());
        }else{
            System.out.println(result.getMessage());
        }
    }

    /**
     * 分页查询历史报警记录
     *
     * @Author maoqiang
     * @Date 2022/12/8 10:50
     */
    public static void equipmentAlarmPage(){
        PageParam pageParam = new PageParam();
        // 设置页大小(范围 1 - 100000)
        pageParam.setPageSize(100);
        ResponseResult<PageResult<EquipAlarmResult>> result = EquipAlarmHelper.page(pageParam,new EquipAlarmParam());
        if(result.isSuccess()){
            if(result.getData().getRows().size() == 0){
                System.out.println("\n查询成功，无历史报警记录！！");
                return;
            }
            System.out.println("\n分页查询历史报警成功！");
            System.out.println("分页第一行报警记录如下：");
            System.out.println("报警设备：" + result.getData().getRows().get(0).getEquipment());
            System.out.println("报警摘要：" + result.getData().getRows().get(0).getSummary());
            System.out.println("报警信息：" + result.getData().getRows().get(0).getContent());
            System.out.println("报警状态：" + result.getData().getRows().get(0).getStatus());
            System.out.println("查看人：" + result.getData().getRows().get(0).getLookUser());
            System.out.println("查看时间：" + result.getData().getRows().get(0).getLookTime());
            System.out.println("创建时间：" + result.getData().getRows().get(0).getCreateTime());
        }else{
            System.out.println(result.getMessage());
        }
    }
}
