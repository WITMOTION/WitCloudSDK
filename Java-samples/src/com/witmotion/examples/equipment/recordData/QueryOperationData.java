package com.witmotion.examples.equipment.recordData;

import core.model.param.PageParam;
import core.model.result.PageResult;
import core.model.result.ResponseResult;
import modular.cloud.login.LoginApiHelper;
import modular.cloud.login.Param.LoginParam;
import modular.cloud.v1EquipOperationApi.Entity.EquipOperationResult;
import modular.cloud.v1EquipOperationApi.EquipOperationApiHelper;
import modular.cloud.v1EquipOperationApi.Param.EquipOperationParam;

/**
 * 查询历史操作记录示例
 *
 * @Author maoqiang
 * @Date 2022/12/15 9:02
 */
public class QueryOperationData {

    public static void main(String[] args) {
        // 登录
        login();
        // 分页查询设备历史操作记录
        equipmentOperationList();
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
     * 分页查询设备历史操作记录
     *
     * @Author maoqiang
     * @Date 2022/12/8 10:50
     */
    public static void equipmentOperationList(){
        PageParam pageParam = new PageParam();
        // 设置页大小(范围 1 - 100000)
        pageParam.setPageSize(100);
        ResponseResult<PageResult<EquipOperationResult>> result = EquipOperationApiHelper.page(pageParam,new EquipOperationParam());
        if(result.isSuccess()){
            if(result.getData().getRows().size() == 0){
                System.out.println("\n查询成功，无历史操作记录！");
                return;
            }
            System.out.println("\n查询设备历史操作成功！");
            System.out.println("分页第一行操作记录如下：");
            System.out.println("操作类型：" + result.getData().getRows().get(0).getType());
            System.out.println("操作名称：" + result.getData().getRows().get(0).getName());
            System.out.println("设备编号：" + result.getData().getRows().get(0).getEquipmentNo());
            System.out.println("被操作的设备：" + result.getData().getRows().get(0).getEquipmentId());
            System.out.println("到达时间：" + result.getData().getRows().get(0).getArrivalTime());
            System.out.println("状态：" + result.getData().getRows().get(0).getStatus());
            System.out.println("下发的命令：" + result.getData().getRows().get(0).getCommand());
        }else{
            System.out.println(result.getMessage());
        }
    }
}
