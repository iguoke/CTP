#ifndef __IO_H__
#define __IO_H__
#include <stdlib.h>
#include <stdio.h>
#include <stdarg.h>
#include "time.h"
#include "Struct.h"
#include <string.h>
typedef  struct
{
   char *str;
   char *addr;
  //char *formt;
} string;
typedef struct
{
  string *base;
  int front,rear,length;
  size_t size;
} StringQ; 
void createStringQ(StringQ *q)
{ 
 (*q).base=(string *) malloc(4*sizeof(string));
 if (!(*q).base)
  {
   printf("Insufficient_memory\n");
   exit(EXIT_FAILURE);
  }
 (*q).front=0;
 (*q).rear=0;
 (*q).size=4;
 (*q).length=0;
}
void destroyStringQ(StringQ *q) 
{
 if((*q).base)
  {
    free((*q).base);
  }
 (*q).base=NULL;
 (*q).front=0;
 (*q).rear=0;
 (*q).length=0;
}
void fullStringQ(StringQ *q)
{
 string *newbase;
 newbase=(string *)malloc(2*(*q).size*sizeof(string));
 if(! newbase)
  { 
   printf("Insufficient_memory\n");
   exit(EXIT_FAILURE);
  }  
 size_t start=((*q).front+1)%(*q).size; 
 if (start<2)
 {
  memmove(newbase,(*q).base+start,((*q).size-1)*sizeof(string));
 }
 else
  {
   memmove(newbase,(*q).base+start,((*q).size-(*q).front-1)*sizeof(string));
   memmove(newbase+((*q).size-(*q).front-1),(*q).base,(*q).rear*sizeof(string));
  }
 (*q).front=2*(*q).size-1;
 (*q).rear=(*q).size-1;
 (*q).size*=2;
 free((*q).base);
 (*q).base=newbase;
}
void pushStringQ(StringQ *q,string e)
{
 (*q).rear=((*q).rear+1)%(*q).size;if((*q).rear==(*q).front)
 {
  fullStringQ(q);
 }
 (*q).base[(*q).rear]=e;
 (*q).length++;
}

string popStringQ(StringQ *q)
{ 
 if((*q).front==(*q).rear)
  {
   fprintf(stderr,"can't Pop,Queue is empty!\n");
   exit(EXIT_FAILURE);
  }
 (*q).front=((*q).front+1)%(*q).size;
 (*q).length--;
 return (*q).base[(*q).front];
}
 
void traverseStringQ(StringQ *q,void (*fun)(string))
{
 for(int TraverseQueue=1;TraverseQueue<=(*q).length;TraverseQueue++)
 {
  fun((*q).base[((*q).front+TraverseQueue)%(*q).size]);
 }
}
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
