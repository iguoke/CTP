#ifndef __GLOBALS_H__
#define __GLOBALS_H__
#include "Enum.h"
#include "Struct.h"
#include "threadpool.h"
#include "Queue.h"
#include "CtpMd.h"
/*#include <stdlib.h>
#include <stdio.h>
#include <stdarg.h>
#include "time.h"
#include <string.h>
#include "threadpool.h"
#include <stdlib.h>
#include <pthread.h>
#include <unistd.h>
#include <assert.h>
#include <signal.h>
#include <errno.h>
*/
void OnFront(void (*fun)());
void OnLogin(void *,void(*fun)(void*));
void OnMarket(void*,void(*fun)(void*));
void CreateApi(void *,void (*fun)(void *));
void Connect(void *,char *,void (*fun)(void *,char *));
void Login(void *,char*, char*, char*,void (*fun)(void *,char*, char*, char*));
void SubMarketData(void *,char *,void (*fun)(void*,char *));
void Print(StringQ *,const char *,const char *,...);
#endif 
