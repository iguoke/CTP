#ifndef __Queue_H__
#define __Queue_H__
#include "Struct.h"
#include <stdio.h>
#include "Macros.h"
#include <string.h>
/*#define Q_TYPE(_ET) Queue_##_ET
//#define Q_DEFINE(ET,queue)
#define Q_TYPE_DEFINE(ET) typedef struct{ET *base;int front,rear,length;size_t size;} Queue_##ET;

#define CreateQueue(name,et) name.base=(et *) malloc(4*sizeof(et));if (!name.base){printf("Insufficient_memory\n");exit(EXIT_FAILURE);}name.front=0;name.rear=0;name.size=4;name.length=0;

#define DestroyQueue(name) if(name.base){free(name.base);}name.base=NULL;name.front=0;name.rear=0;name.length=0;

#define FullQueue(name,et) et *newbase;newbase=(et *)malloc(2*name.size*sizeof(et));if(! newbase){printf("Insufficient_memory\n");exit(EXIT_FAILURE);}  size_t start=(name.front+1)%name.size; if (start<2){memmove(newbase,name.base+start,(name.size-1)*sizeof(et));}else {memmove(newbase,name.base+start,(name.size-name.front-1)*sizeof(et));memmove(newbase+(name.size-name.front-1),name.base,name.rear*sizeof(et));}name.front=2*name.size-1;name.rear=name.size-1;name.size*=2;free(name.base);name.base=newbase;

#define PushQueue(name,et,e){name.rear=(name.rear+1)%name.size;if(name.rear==name.front){FullQueue(name,et);}name.base[name.rear]=e;name.length++;}

#define PopQueue(name)({if(name.front==name.rear){fprintf(stderr,"can't Pop,Queue is empty!\n");exit(EXIT_FAILURE);}name.front=(name.front+1)%name.size;name.length--;name.base[name.front];})
 
#define TraverseQueue(name,et,funname) void (*vi)(et); for(int TraverseQueue=1;TraverseQueue<=name.length;TraverseQueue++){funname(name.base[(name.front+TraverseQueue)%name.size]);}
*/
/*
typedef  int ElemType ;
typedef struct
{
  ElemType *base;
  int front;
  int rear;
  size_t size;
  int length;
} IOQueue;

void showqueue(ElemType e) 
{
 printf("elem= %d; ",e);
}
void  CreateIOQueue(IOQueue *Q,int size)
{
 (*Q).base=(ElemType *)malloc(size*sizeof(ElemType));
  if (!(*Q).base)
  {
   printf("Insufficient_memory\n");
   exit(EXIT_FAILURE);
  }
  (*Q).front=0;
  (*Q).rear=0;
  (*Q).size=size;
  (*Q).length=0;
} 

void IOQueueTraverse(IOQueue *Q,void (*vi)(ElemType))
{
 int m=0;
 for(int i=1;i<=Q->length;i++)
  {
   m=(Q->front+i)%Q->size;
   vi(Q->base[m]);
  }
 printf("\n");
}
void DestroyIOQueue(IOQueue *Q)
{
  if((*Q).base)
  {
    free((*Q).base);
  }
  (*Q).base=NULL;
  (*Q).front=0;
  (*Q).rear=0;
  (*Q).length=0;
}
void ClearIOQueue(IOQueue *Q)
{
 (*Q).front=0;
 (*Q).rear=0;
}
bool IOQueueEmpty(IOQueue *Q)
{
 if (Q->front==Q->rear)
  return true;
 else 
  return false;
}
int IOQueueLength(IOQueue *Q)
{
  return Q->length;
}
ElemType  GetIOQueueHead(IOQueue *Q)
{
  if(Q->front==Q->rear)
  {
   fprintf(stderr,"IOQueue is empty!\n");
   exit(EXIT_FAILURE);
  }
  else
  return Q->base[(Q->front+1)%Q->size];
}
void IOQueueFull(IOQueue *Q)
{
 ElemType *newbase;
 newbase=(ElemType *)malloc(2*(*Q).size*sizeof(ElemType));
 if(! newbase)
 {
   printf("Insufficient_memory\n");
   exit(EXIT_FAILURE);
 } 
  size_t start=((*Q).front+1)%(*Q).size;
 if (start<2)
 {
  memmove(newbase,(*Q).base+start,((*Q).size-1)*sizeof(ElemType));
 }
 else 
 {
  memmove(newbase,(*Q).base+start,((*Q).size-(*Q).front-1)*sizeof(ElemType));
  memmove(newbase+((*Q).size-(*Q).front-1),(*Q).base,(*Q).rear*sizeof(ElemType));
  //printf("hahah\n");
 }
 (*Q).front=2*(*Q).size-1;
 (*Q).rear=(*Q).size-1;
 (*Q).size*=2;
 free((*Q).base);
 (*Q).base=newbase;
}
void  IOQueuePush(IOQueue *Q,ElemType e)
{
 (*Q).rear=((*Q).rear+1)%(*Q).size;
 if((*Q).rear==(*Q).front)
 {
  IOQueueFull(Q);
 }
  memcpy(Q->base+Q->rear,&e,sizeof(ElemType));
  (*Q).length++;
}
ElemType  IOQueuePop(IOQueue *Q)
{
 if((*Q).front==(*Q).rear)
 {
  fprintf(stderr,"can't Pop,Queue is empty!\n");
   exit(EXIT_FAILURE);
 }
 (*Q).front=((*Q).front+1)%(*Q).size;
 (*Q).length--;
 return (*Q).base[(*Q).front];
}

int main()
{
   printf("Hello word!%d\n",3);
   IOQueue queue;
   CreateIOQueue(&queue,4);
   ClearIOQueue(&queue);
   ElemType e=100;
   IOQueuePush(&queue,e);
   IOQueuePop(&queue);
   for(int j=1;j<=300;j++)
   {
     IOQueuePush(&queue,j);
     if(j%7==0)
     IOQueuePop(&queue);
   }
   printf("\n");
  IOQueueTraverse(&queue,showqueue); 
  printf("   length=%d\n",queue.length);
  DestroyIOQueue(&queue);
    return 0;
}
*/
#endif
