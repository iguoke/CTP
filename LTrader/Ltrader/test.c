#include "Globals.h"
//gcc src.c -std=c99 -o src
//g++ test.c Globals.c Queue.c threadpool.c CtpMd.c -lpthread -o t
int i=0;
StringQ stringq;
CtpMdApi ctpmdapi;
void *writeA(void *arg)
{
 while(true)
 {
    StringQ * queue=( StringQ *) arg;
   Print(queue,"A.txt","writeA->i=%d",i++);
 }
}
void *writeB(void *arg)
{
 while(true)
 {
    StringQ * queue=( StringQ *) arg;
   Print(queue,"B.log","writeB->i=%d",i++);
 }
}
void *writeC(void *arg)
{
 while(true)
 {
   StringQ * queue=(StringQ *) arg;
   Print(queue,"","writeC->i=%d",i++);
 }
}
void *read(void *arg)
{
 StringQ * queue=(StringQ *) arg;
 while(true)
 {
  if(queue->front!=queue->rear)
  {
    pthread_rwlock_rdlock(&(*queue).rwlock); 
    showqueue(popStringQ(queue)); 
    pthread_rwlock_unlock(&(*queue).rwlock); 
  }
 }
}
//g++ -g -o t test.c Globals.c Queue.c threadpool.c CtpMd.c -lthostmduserapi -lpthread  
int main()
{

 /* createStringQ(&stringq);
  threadpool_t *thp = threadpool_create(5,100,20);
 for (int j=0;j<5;j++)
 {
  threadpool_add(thp,writeC,(void*)&stringq);
  threadpool_add(thp,writeB,(void*)&stringq);
  threadpool_add(thp,writeA,(void*)&stringq);
 } 
  threadpool_add(thp,read,(void*)&stringq);
  sleep(10);
  threadpool_destroy(thp);
  destroyStringQ(&stringq);*/
  CreateApi(&ctpmdapi,CtpMdCreateApi);
  //Connect(&ctpmdapi,"tcp://115.238.53.139:51213",CtpMdConnect);//"tcp://ctpfz1-front1.citicsf.com:51213"
  Connect(&ctpmdapi,"tcp://115.238.108.184:41213",CtpMdConnect);
  sleep(2);
  Login(&ctpmdapi,"","","",CtpMdLogin);
  sleep(3);
  SubMarketData(&ctpmdapi,"ag1506");
  sleep(3);
  //ctpmdapi->api->Join(); 
  return 0;
}
