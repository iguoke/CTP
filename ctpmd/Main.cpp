#include <stdio.h>
#include <pthread.h>
#include "Main.h"
#include "MdAccount.h"
#include<iostream>
using namespace std;
MdSpi mdspi;
MdApi mdapi;
//TdSpi tdspi;
//TdApi tdapi;
void* threadMd(void*);
void  Md_OnFrontConnected(ObejctSender* obejctSender,ObejctSender* obejctSender1,ObejctSender* obejctSender2)
{
	cout<<"连接行情前置成功！"<<endl;
	mdapi.ReqUserLogin("","","");
}

void  Md_OnRspUserLogin(ObejctSender* obejctSender,ObejctSender* obejctSender1,ObejctSender* obejctSender2)
{	
	cout<<"登陆行情账号成功"<<endl;
	mdapi.SubscribeMarketData("p1501");
	mdapi.SubscribeMarketData("ag1412");
	mdapi.SubscribeMarketData("au1412");
}	
void  OnTick(ObejctSender* obejctSender,ObejctSender* obejctSender1,ObejctSender* obejctSender2)							
{
	CThostFtdcDepthMarketDataField * tick=(CThostFtdcDepthMarketDataField *)obejctSender;
	cout<<tick->LastPrice<<endl;
}
//////////////////////////////////////////////////////////////////////////
/*void  Td_OnFrontConnected(ObejctSender* obejctSender,ObejctSender* obejctSender1,ObejctSender* obejctSender2)
{
	tdapi.ReqUserLogin("66666","105300027","222888");
//tdapi.ReqUserLogin("1032","202800042","891026");//永安模拟
}
void Td_OnRspUserLogin(ObejctSender* obejctSender,ObejctSender* obejctSender1,ObejctSender* obejctSender2)
{
	//CThostFtdcRspUserLoginField *lo=(CThostFtdcRsupUserLoginField*)obejctSender;
	cout<<"登陆交易账号功:"<<endl;	
	tdapi.ReqSettlementInfoConfirm();
	tdapi.ReqQryInstrument("");	
}

void Td_OnRspSettlementInfoConfirm(ObejctSender* obejctSender,ObejctSender* obejctSender1,ObejctSender* obejctSender2)
{
	cout<<"确认结算单成功"<<endl;				
    tdapi.ReqQryInstrument("");								
}

*/
//////////////////////////////////////////////
void* threadMd(void* arg)
{
	mdspi.Event_OnFrontConnected+=Md_OnFrontConnected;
	mdspi.Event_OnRspUserLogin += Md_OnRspUserLogin;
	mdspi.Event_OnRtnDepthMarketData+=OnTick;
	//mdapi.MdConnect(&mdspi,"tcp://ctpfz1-front1.citicsf.com:51213");
	mdapi.MdConnect(&mdspi,"tcp://115.238.108.184:41213");
	mdapi.Join();
	//pthread_exit(0);
}
int main()
{
	cout<<"开始了...."<<endl;
	pthread_t tid1;		
	pthread_create(&tid1, NULL, threadMd, NULL);
	//tdspi.Event_OnFrontConnected+=Td_OnFrontConnected;
	//tdspi.Event_OnRspUserLogin += Td_OnRspUserLogin;
	//tdapi.TdConnect(&tdspi,"tcp://115.238.53.139:51205");//永安模拟
	//tdapi.TdConnect(&tdspi,"tcp://ctpfz1-front2.citicsf.com:51205");//中信模拟
	//tdapi.TdConnect(&tdspi,"tcp://115.238.108.184:41213");
	//tdapi.Join();
	while(1);
	return 0;
}
