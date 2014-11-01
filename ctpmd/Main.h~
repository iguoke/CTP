#pragma once
//#ifndef _MAIN _MAIN_H
#include <vector>
#include <list>
#include <stdlib.h>
using namespace std;
//空触发者类
class ObejctSender{};
typedef void ( *EventHandler)(ObejctSender* obejctSender,ObejctSender* obejctSender1,ObejctSender* obejctSender2);
//事件结构体
typedef struct _tagMEMBERFUN 
{
	private:	
		list<EventHandler> funcList;
	public:
		//注册事件
    	void operator += (EventHandler userfunc)
		{
			funcList.push_back(userfunc);
		}
		void operator -= (EventHandler userfunc)
		{									
			//此处使用反向迭代器
			list<EventHandler>::reverse_iterator rite=funcList.rbegin();
			for(;rite!=funcList.rend();++rite)									 {
				if((*rite) == userfunc)														{
						list<EventHandler>::iterator ite=rite.base();
						ite--;																  funcList.erase(ite);													break;
						}														}																}
		void Trigger(ObejctSender* obejctSender=0,ObejctSender* obejctSender1=0,ObejctSender* obejctSender2=0)
		{																		list<EventHandler>::iterator ite=funcList.begin();
			for(;ite!=funcList.end();++ite)											{
				(*ite)( obejctSender, obejctSender1, obejctSender2);
		 	  }
		}
} HunterEvent,*LPHunterEvent;
