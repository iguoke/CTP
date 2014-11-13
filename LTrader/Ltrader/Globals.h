#ifndef __GLOBALS_H__
#define __GLOBALS_H__
/** WARNING: This code is fresh and potentially isn't correct yet. */
#include "Queue.h"
#include <stdlib.h>
#include <stdio.h>
void showqueue(string e);
void Print(StringQ *q,const char *addr,const char *fmt,...);
void OnFrontConnected(void (*fun)());
void CTPMDOnFrontConnected();
#endif 
