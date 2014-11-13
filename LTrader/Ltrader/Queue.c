#include "Queue.h"
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
 pthread_rwlock_init (&(*q).rwlock,NULL);
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
 pthread_rwlock_destroy(&(*q).rwlock);//销毁读写锁
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


/*void showqueue(int e) 
{
  printf("elem= %d; ",e);
}
int main()
{
  Q_TYPE_DEFINE(int);
  Q_TYPE(int) queue;
  CreateQueue(queue,int);
  for(int x=1;x<=100;x++)
   {
    if (x%3!=0)
     {    
      PushQueue(queue,int,x);
     }
    else
     {
       printf("delete:%d\n",PopQueue(queue));
     }
   }
  TraverseQueue(queue,int,showqueue);
  Q_TYPE_DEFINE(char);
  Q_TYPE(char) queuec;
  CreateQueue(queuec,char);
  PushQueue(queuec,char,'A');
  PushQueue(queuec,char,'b');
  printf("queuec %c",PopQueue(queuec));

  DestroyQueue(queue);
  DestroyQueue(queuec);
return 0;
}*/
