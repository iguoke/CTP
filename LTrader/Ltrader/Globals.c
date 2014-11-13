#include "Globals.h"
//static pthread_rwlock_t rwlock;//读写锁对象
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
void Print(StringQ *q,const char *addr,const char *fmt,...)
{
 pthread_rwlock_wrlock(&(*q).rwlock);
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
   //pthread_rwlock_wrlock(&(*q).rwlock);
   pushStringQ(q,newstr);
   //pthread_rwlock_unlock(&(*q).rwlock);
   va_end(argp);
   pthread_rwlock_unlock(&(*q).rwlock);
}
void OnFront(void (*fun)())
{
  (*fun)();
}
void OnLogin(void *acc,void(*fun)(void*))
{
  (*fun)(acc);
}
void OnMarket(void *marketdata,void(*fun)(void*))
{
  (*fun)(marketdata);
}
void CreateApi(void *api,void (*fun)(void *))
{
 //printf("hhhhhhhh");
  (*fun)(api);
}
void Connect(void *api,char *s,void (*fun)(void *,char *))
{
  (*fun)(api,s);
}
void Login(void *api,char* pInvestor, char* pPwd, char* pBroker,void (*fun)(void *,char* pInvestor, char* pPwd, char* pBroker))
{
  (*fun)(api,pInvestor,pPwd,pBroker);
}
void SubMarketData(void *api,char *inst,void (*fun)(void*,char *))
{
 (*fun)(api,inst);
}
