#include "Globals.h"
#include "threadpool.h"
Q_TYPE(string) outstring;
static pthread_rwlock_t rwlock;//读写锁对象
int i=0;
void showqueue(string e) 
{
  if (0==strcmp("",e.addr))
  {
   printf("%s",e.str);
  }
  else
  {
    FILE *fp;
    if((fp=fopen(e.addr,"a+"))!=NULL)
    {
     fputs(e.str,fp);
    }
    fclose(fp);
  }
}
void Print(Q_TYPE(string) *str,const char *addr,const char *fmt,...)
{
  pthread_rwlock_wrlock(&rwlock);
 int i=0;
 va_list argp;
 va_start(argp,fmt);
 time_t lt; 
 lt=time(NULL);
 struct tm *timer=localtime(&lt);
 string newstr;
 char buf[strlen(addr)];
 memmove(buf,addr,strlen(addr));
 newstr.addr=buf;
 char buffer[256]={0};
 char bufstring[2048]={0};
sprintf(buffer,"%d.%d.%d (%d) %d:%d:%d-> ",1900+timer->tm_year,timer->tm_mon+1,timer->tm_mday,timer->tm_wday,timer->tm_hour,timer->tm_min,timer->tm_sec);
strcat(bufstring,buffer);
 for(i=0;fmt[i]!='\0';i++) 
 {
  if(fmt[i]=='%')
   {
    i++;
    switch(fmt[i]) 
    {
    case '\0':
      printf("Invalid format, you ended with %%.");
      break;
    case 'd':
     sprintf(buffer,"%d",va_arg(argp,int));  
     strcat(bufstring,buffer);
      break;
    case 's': 
      strcat(bufstring,va_arg(argp,char*));
      break;
    case 'f':
     sprintf(buffer,"%.2f",va_arg(argp,double));
     strcat(bufstring,buffer);
     break;
    default :
      printf("Invalid format.");
      break;
    }
  }
  else 
  {
   sprintf(buffer,"%c",fmt[i]);
   strcat(bufstring,buffer);
   }
  }
   strcat(bufstring,"\n");
   newstr.str=bufstring;
  //pthread_rwlock_wrlock(&rwlock);
  PushQueue((*str),string,newstr);
  //pthread_rwlock_unlock(&rwlock);
  va_end(argp);
  pthread_rwlock_unlock(&rwlock);
}
void OnFrontConnected(void (*fun)())
{
  (*fun)();
}
void CTPOnFrontConnected()
{
  //Print();
}
void *writeA(void *arg)
{
 while(true)
 {
   Q_TYPE(string) * queue=(Q_TYPE(string) *) arg;
   Print(queue,"A.txt","writeA->i=%d",i++);
 }
}
void *writeB(void *arg)
{
 while(true)
 {
   Q_TYPE(string) * queue=(Q_TYPE(string) *) arg;
   Print(queue,"B.txt","writeB->i=%d",i++);
 }
}
void *writeC(void *arg)
{
 while(true)
 {
   Q_TYPE(string) * queue=(Q_TYPE(string) *) arg;
   Print(queue,"","writeC->i=%d",i++);
 }
}
void *read(void *arg)
{
 Q_TYPE(string) * queue=(Q_TYPE(string) *) arg;
 while(true)
 {
  if(queue->front!=queue->rear)
  {
    pthread_rwlock_rdlock(&rwlock); 
   showqueue(PopQueue((*queue))); 
    pthread_rwlock_unlock(&rwlock); 
  }
 }
}
int main()
{
 pthread_rwlock_init(&rwlock,NULL); 
  CreateQueue(outstring,string );
  threadpool_t *thp = threadpool_create(5,100,20);
  printf("pool inited");
	/*int *num = (int *)malloc(sizeof(int)*20);
	for (int i=0;i<10;i++)
	{
		num[i]=i;
		printf("add task %d\n",i);
		threadpool_add(thp,process,(void*)&num[i]);
	}*/	
 //for (int j=0;j<5;j++)
 {
  threadpool_add(thp,read,(void*)&outstring);
  threadpool_add(thp,writeC,(void*)&outstring);
  threadpool_add(thp,writeB,(void*)&outstring);
  threadpool_add(thp,writeA,(void*)&outstring);
 } 
  threadpool_add(thp,read,(void*)&outstring);
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
