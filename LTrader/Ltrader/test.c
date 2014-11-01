#include "threadpool.h"
#include "Queue.h"
//#include "Io.h"
//#include "Globals.h"
//gcc -w threadpool.cc -o thread -lpthread
//gcc src.c -std=c99 -o src
//g++ -w -o test test.c  threadpool.c -lpthread
typedef  struct
{
  char *str;
  char *addr;
  //char *formt;
} string; 

Q_TYPE_DEFINE(string);
Q_TYPE(string) outstring;
void Print(Q_TYPE(string) str,const char *addr,const char *fmt,...)
{
int i=0;
 va_list argp;
 va_start(argp,fmt);
 time_t lt; 
 lt=time(NULL);
 struct tm *timer=localtime(&lt);
 string newstr;
 memmove(&newstr.addr,addr,sizeof(addr));
 //memmove(newstr.formt,fmt,sizeof(fmt));
 char *buffer;
 
//sscanf(1900+timer->tm_year,timer->tm_mon,timer->tm_mday,timer->tm_wday,timer->tm_hour,timer->tm_min,timer->tm_sec,"%d.%d.%d (%d) %d:%d:%d-> ",buffer);
//strcat(newstr.str,buffer);
 for(i=0;fmt[i]!='\0';i++) 
 {
   //printf("%d",i);
  if(fmt[i]=='%')
   {
    //printf("in");
    i++;
     //putchar(fmt[i]);
    switch(fmt[i]) 
    {
    case '\0':
      printf("Invalid format, you ended with %%.");
      break;
    case 'd':
     sprintf(buffer,"%d",va_arg(argp,int));  
     strcat(newstr.str,buffer);
      break;
    case 's': 
      printf("%s",va_arg(argp,char*));
      //sprintf(buffer,"%s",va_arg(argp,char*));
     //strcat(newstr.str,va_arg(argp,char*));
      break;
    case 'f':
     sprintf(buffer,"%.1f",va_arg(argp,double));
     strcat(newstr.str,buffer);
     //printf("%.1f",va_arg(argp,double));
     break;
    default :
      printf("Invalid format.");
      break;
    }
  }
  else 
  {
   //sprintf(buffer,"%c",fmt[i]);
   //strcat(newstr.str,buffer);
   //putchar(fmt[i]);
   //printf("%c",fmt[i]);
   }
  }
  //sprintf(buffer,"%c",fmt[i]);
   //strcat(newstr.str,"\n");
   PushQueue(str,string,newstr);
  va_end(argp);
}
void showqueue(string e) 
{
  if (""==e.addr)
  {
   printf("%s; ",e.str);

  }
}
int main()
{
	/*threadpool_t *thp = threadpool_create(3,100,12);
	printf("pool inited");
	int *num = (int *)malloc(sizeof(int)*20);
	for (int i=0;i<10;i++)
	{
		num[i]=i;
		printf("add task %d\n",i);
		threadpool_add(thp,process,(void*)&num[i]);
	}
	sleep(10);
	threadpool_destroy(thp);*/
  CreateQueue(outstring,string );
  Print(outstring,"","%s","hello\n");
  //Print(outstring,"","%c",'A'); 
  //PushQueue(outstring,string,"hello");
  //PushQueue(outstring,string,"wang xue hong\n");
   double mm=2358; 
  Print(outstring,"","std:%d",mm);
  //Print("log.txt","std:%d %s %f",3,"hello word!",mm);
  //printf("string %s",PopQueue(outstring));
  TraverseQueue(outstring,string,showqueue);
  //DestroyQueue(outstring); 
   return 0;
}
void *process(void *arg)
{
	printf("thread 0x%x working on task %d\n ",pthread_self(),*(int *)arg);
	sleep(1);
	printf("task %d is end\n",*(int *)arg);
	return NULL;
}
