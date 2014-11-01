#include "Globals.h"

void Print(Q_TYPE(string) *str,const char *addr,const char *fmt,...)
{
int i=0;
 va_list argp;
 va_start(argp,fmt);
 time_t lt; 
 lt=time(NULL);
 struct tm *timer=localtime(&lt);
 string newstr;
 char buf[sizeof(addr)]={0};
 memmove(buf,addr,sizeof(addr));
 newstr.addr=buf;
 //memmove(newstr.formt,fmt,sizeof(fmt));
 char buffer[256]={0};
 char bufstring[2048]={0};
//sscanf(1900+timer->tm_year,timer->tm_mon,timer->tm_mday,timer->tm_wday,timer->tm_hour,timer->tm_min,timer->tm_sec,"%d.%d.%d (%d) %d:%d:%d-> ",buffer);
//strcat(newstr.str,buffer);
 for(i=0;fmt[i]!='\0';i++) 
 {
  if(fmt[i]=='%')
   {
    //printf("in");
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
      //fputs(va_arg(argp,char*),stdout);
      break;
    case 'f':
     //printf("%.1f\n",va_arg(argp,double));
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
   //putchar(fmt[i]);
   //printf("%c",fmt[i]);
   }
  }
   //sprintf(buffer,"%c",fmt[i]);
   strcat(bufstring,"\n");
   newstr.str=bufstring;
  //printf("%s\n",newstr.addr);
  PushQueue((*str),string,newstr);
  //printf("hahhh\n");
  va_end(argp);
}
/*void showqueue(string e) 
{
  if (0==strcmp(e.addr,""))
  {
   printf("%s",e.str);

  }
}
*/
/*int  main()
{ 
  Q_TYPE(string) outstring;
  CreateQueue(outstring,string);  
 //Print("","---- start ----\n"); 
  double mm=2358; 
  Print(&outstring,"","std:%d %s %f",3,"hello word!",mm);
  //Print("log.txt","std:%d %s %f",3,"hello word!",mm);
 //gcc -w threadpool.cc -o thread -lpthread
  TraverseQueue(outstring,string,showqueue);
  DestroyQueue(outstring);
 return 0;
}
*/
