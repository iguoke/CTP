#include "threadpool.h"
#include "Queue.h"
#include "Globals.h"
//#include "Io.h"
//#include "Globals.h"
//gcc -w threadpool.cc -o thread -lpthread
//gcc src.c -std=c99 -o src
//g++ -w -o test test.c  threadpool.c -lpthread
static pthread_rwlock_t rwlock;//读写锁对象
 int i=0;
void showqueue(string e) 
{
  if (0==strcmp("",e.addr))
  {
   printf("%s",e.str);

  }
}
void *writeA(void *arg)
{
 while(true)
 {
   pthread_rwlock_wrlock(&rwlock);
   Q_TYPE(string) * queue=(Q_TYPE(string) *) arg;
   //printf("this is press write: i=%d\n",i);
   Print(queue,"","AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAwriteA->i=%d",i++);

  //printf("aaa\n");
 //exit(0);
   pthread_rwlock_unlock(&rwlock); 
 }
 
}
void *writeB(void *arg)
{
 while(true)
 {
   pthread_rwlock_wrlock(&rwlock);
   Q_TYPE(string) * queue=(Q_TYPE(string) *) arg;
   //printf("this is press write: i=%d\n",i);
   Print(queue,"","writeBBBBBBBBBBBBBBBBBBBB->i=%d",i++);

   pthread_rwlock_unlock(&rwlock); 
 }
 
}
void *writeC(void *arg)
{
 while(true)
 {
   pthread_rwlock_wrlock(&rwlock);
   Q_TYPE(string) * queue=(Q_TYPE(string) *) arg;
   //printf("this is press write: i=%d\n",i);
   Print(queue,"","CCCCCCCwriteC->i=%d",i++);

   pthread_rwlock_unlock(&rwlock); 
 }
 
}
void *read(void *arg)
{
 Q_TYPE(string) * queue=(Q_TYPE(string) *) arg;
 while(true)
 {
  while(queue->length>0)
  {
    pthread_rwlock_rdlock(&rwlock);
    printf("%s",PopQueue((*queue))); 
    pthread_rwlock_unlock(&rwlock); 
  }
 }
}
int main()
{
  Q_TYPE(string) outstring;
  CreateQueue(outstring,string );
  threadpool_t *thp = threadpool_create(3,100,20);
  printf("pool inited");
	/*int *num = (int *)malloc(sizeof(int)*20);
	for (int i=0;i<10;i++)
	{
		num[i]=i;
		printf("add task %d\n",i);
		threadpool_add(thp,process,(void*)&num[i]);
	}*/	
  threadpool_add(thp,read,(void*)&outstring);
 for (int j=0;j<10;j++)
 {
//  threadpool_add(thp,read,(void*)&outstring);
  threadpool_add(thp,writeC,(void*)&outstring);
  sleep(10);
  threadpool_add(thp,writeB,(void*)&outstring);
  sleep(10);
  threadpool_add(thp,writeA,(void*)&outstring);
  sleep(10);
 } 
 sleep(10);
  threadpool_destroy(thp);
  
  //Print(outstring,"","%s","hello\n");
  //Print(outstring,"","%c",'A'); 
  //PushQueue(outstring,string,"hello");
  //PushQueue(outstring,string,"wang xue hong\n");
  //double mm=2358; 
  //Print(&outstring,"","std:%f",mm);
  //Print("log.txt","std:%d %s %f",3,"hello word!",mm);
  //printf("string %s",PopQueue(outstring));
  //TraverseQueue(outstring,string,showqueue);
  DestroyQueue(outstring); 
   return 0;
}
/*void *process(void *arg)
{
	printf("thread 0x%x working on task %d\n ",pthread_self(),*(int *)arg);
	sleep(1);
	printf("task %d is end\n",*(int *)arg);
	return NULL;
}*/
