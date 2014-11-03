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
extern Q_TYPE(string) outstring;
void Print(Q_TYPE(string) *,const char *addr,const char *fmt,...);
void showqueue(string e);

void OnFrontConnected(void (*fun)());
void CTPOnFrontConnected();
#endif 
