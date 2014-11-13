#ifndef __IO_H__
#define __IO_H__
#include <stdlib.h>
#include <stdio.h>
#include <stdarg.h>
#include "time.h"
#include "Struct.h"

//#include "Queue.h"
//#include "Globals.h"
//#define Print(Qname,et,...) { PushQueue(Qname,et,"hello");}

 /*void Print(const char *addr,const char *fmt,...);
 {
 int i=0;
 va_list argp;
 va_start(argp,fmt);
 time_t lt;
 lt=time(NULL);
 struct tm *timer=localtime(&lt); 
if(""==addr)
{  
 printf("%d.%d.%d (%d) %d:%d:%d-> ",1900+timer->tm_year,timer->tm_mon,timer->tm_mday,timer->tm_wday,timer->tm_hour,timer->tm_min,timer->tm_sec); 
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
      printf("%d",va_arg(argp,int));
      
      break;
    case 's':
      fputs(va_arg(argp,char*),stdout);
      
      break;
    case 'f':
     printf("%.1f",va_arg(argp,double));
     break;
    default :
      printf("Invalid format.");
      break;
    }
  }
  else 
  {
   putchar(fmt[i]);
   //printf("%c",fmt[i]);
   }
  }
  putchar('\n');
 }
 else
 {
  FILE *fp;
  if((fp=fopen(addr,"a"))!=NULL)
 {
  fprintf(fp,"%d.%d.%d (%d) %d:%d:%d-> ",1900+timer->tm_year,timer->tm_mon,timer->tm_mday,timer->tm_wday,timer->tm_hour,timer->tm_min,timer->tm_sec); 
 for(i=0;fmt[i]!='\0';i++) 
 {
  if(fmt[i]=='%')
   {
    //printf("in");
    i++;
    switch(fmt[i]) 
    {
    case '\0':
      fprintf(fp,"Invalid format, you ended with %%.");
      break;
    case 'd':
      fprintf(fp,"%d",va_arg(argp,int));
      
      break;
    case 's':
      fputs(va_arg(argp,char*),fp);
      
      break;
    case 'f':
     fprintf(fp,"%.1f",va_arg(argp,double));
     break;
    default :
      fprintf(fp,"Invalid format.");
      break;
    }
  }
  else 
  {
   fputc(fmt[i],fp);
   //printf("%c",fmt[i]);
   }
  }
  fputc('\n',fp); 
 }
 fclose(fp);
} 
va_end(argp); 
}*/
#endif
