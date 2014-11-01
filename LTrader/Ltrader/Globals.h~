#ifndef __GLOBALS_H__
#define __GLOBALS_H__
/** WARNING: This code is fresh and potentially isn't correct yet. */
#include "Queue.h"
#include <stdlib.h>
#include <stdio.h>
typedef  struct
{
  char *str;
  char *addr;
  //char *formt;
} string; 
Q_TYPE_DEFINE(string);
void Print(Q_TYPE(string),const char *addr,const char *fmt,...);
/*{

 int i=0;
 va_list argp;
 va_start(argp,fmt);
 time_t lt; 
 lt=time(NULL);
 struct tm *timer=localtime(&lt);
 string newstr;
 memmove(newstr.addr,addr,sizeof(addr));
 //memmove(newstr.formt,fmt,sizeof(fmt));
 char *buffer;

sscanf(1900+timer->tm_year,timer->tm_mon,timer->tm_mday,timer->tm_wday,timer->tm_hour,timer->tm_min,timer->tm_sec,"%d.%d.%d (%d) %d:%d:%d-> ",buffer);
strcat(newstr.str,buffer);
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
     strcat(newstr.str,buffer);
      break;
    case 's': 
      strcat(newstr.str,va_arg(argp,char*));
      //fputs(va_arg(argp,char*),stdout);
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
   sprintf(buffer,"%c",fmt[i]);
   strcat(newstr.str,buffer);
   //putchar(fmt[i]);
   //printf("%c",fmt[i]);
   }
  }
  //sprintf(buffer,"%c",fmt[i]);
   strcat(newstr.str,"\n");
   //PushQueue(str,string,newstr);
  va_end(argp); 
}*/
#endif 
