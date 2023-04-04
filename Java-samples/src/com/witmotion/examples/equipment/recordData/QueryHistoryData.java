package com.witmotion.examples.equipment.recordData;

import core.model.param.PageParam;
import core.model.result.PageResult;
import core.model.result.ResponseResult;
import modular.cloud.login.LoginApiHelper;
import modular.cloud.login.Param.LoginParam;
import modular.cloud.v1EquipRecordApi.EquipRecordApiHelper;
import modular.cloud.v1EquipRecordApi.Param.EquipRecordParam;

import java.util.List;
import java.util.Map;

/**
 * 查看设备历史数据示例
 *
 * @Author maoqiang
 * @Date 2022/12/14 19:37
 */
public class QueryHistoryData {

    public static void main(String[] args) {
        // 登录
        login();
        // 获取所有历史数据
        equipmentRecordList();
        // 分页获取历史数据
        equipmentRecordPage();
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
     * 列表查询设备历史数据
     *
     * @Author maoqiang
     * @Date 2022/12/8 10:50
     */
    public static void equipmentRecordList(){
        EquipRecordParam equipRecordParam = new EquipRecordParam();
        // 您的设备id
        equipRecordParam.setEquipmentId(1551489042042724353L);
        ResponseResult<List<Map<String, String>>> result = EquipRecordApiHelper.clientList(equipRecordParam);
        if(result.isSuccess()){
            if(result.getData().size() == 0){
                System.out.println("\n查询成功，无设备历史数据！");
                return;
            }
            System.out.println("\n查询设备历史数据成功！");
            System.out.println("列表第一行历史数据结果 data=>：" + result.getData().get(0));
        }else{
            System.out.println(result.getMessage());
        }
    }

    /**
     * 分页查询设备历史数据
     *
     * @Author maoqiang
     * @Date 2022/12/8 10:50
     */
    public static void equipmentRecordPage(){
        EquipRecordParam equipRecordParam = new EquipRecordParam();
        // 您的设备id
        equipRecordParam.setEquipmentId(1551489042042724353L);
        PageParam pageParam = new PageParam();
        // 设置页大小(范围 1 - 100000)
        pageParam.setPageSize(100);
        ResponseResult<PageResult<Map<String,String>>> result = EquipRecordApiHelper.clientPage(pageParam, equipRecordParam);
        if(result.isSuccess()){
            if(result.getData().getRows().size() == 0){
                System.out.println("\n查询成功，无设备历史数据！");
                return;
            }
            System.out.println("\n查询设备历史数据成功！");
            System.out.println("分页第一行历史数据结果 data=>：" + result.getData().getRows().get(0));
        }else{
            System.out.println(result.getMessage());
        }
    }
}
