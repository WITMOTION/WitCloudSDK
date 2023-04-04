package com.witmotion.examples.equipment.nowData;

import core.constant.ServerConstant;
import core.model.result.ResponseResult;
import modular.cloud.login.LoginApiHelper;
import modular.cloud.login.Param.LoginParam;
import modular.cloud.v1NowDataApi.Entity.NowDataSocketResult;
import modular.cloud.v1NowDataApi.NowDataApiHelper;
import modular.cloud.v1NowDataApi.NowDataApiService;
import modular.cloud.v1NowDataApi.Param.NowDataSocketMessage;
import modular.cloud.v1NowDataApi.Param.NowDataSocketParam;

import java.util.ArrayList;
import java.util.List;

/**
 * 查询设备实时数据
 *
 * @Author maoqiang
 * @Date 2022/12/15 10:49
 */
public class QueryNowData {

    public static void main(String[] args) {
        // 登录
        login();
        // 获取设备实时数据
        queryNowData();
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
     * 获取设备实时数据
     *
     * @Author maoqiang
     * @Date 2022/12/8 10:50
     */
    public static void queryNowData(){
        NowDataSocketParam newDataParam = new NowDataSocketParam();
        List<String> deviceNoList = new ArrayList<String>();
        deviceNoList.add("WT5400000117"); // 您的设备编号
        newDataParam.setEquipmentNoList(deviceNoList);

        NowDataSocketMessage nowDataMessage = new NowDataSocketMessage();
        nowDataMessage.setToken(ServerConstant.getToken());
        nowDataMessage.setMethod("needNowData"); // 请求获取实时数据
        nowDataMessage.setParam(newDataParam);

        // 获取实时数据
        NowDataApiHelper.requestNowData(nowDataMessage,nowDataApiService);
    }

    /**
     * 实现接收数据接口
     *
     * @Author maoqiang
     * @Date 2022/12/15 14:09
     */
    private static NowDataApiService nowDataApiService = new NowDataApiService(){
        /**
         * 接收设备实时数据
         *
         * @Author maoqiang
         * @Date 2022/12/15 10:49
         */
        @Override
        public void deviceData(NowDataSocketResult nowDataSocketResult) {
            System.out.println("设备实时数据：" + nowDataSocketResult.getData());
        }

        /**
         * 接收实时报警数据
         *
         * @Author maoqiang
         * @Date 2022/12/15 10:50
         */
        @Override
        public void alarmData(NowDataSocketResult nowDataSocketResult) {
            System.out.println("实时报警数据：" + nowDataSocketResult.getData());
        }
    };
}
