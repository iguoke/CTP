#ifndef __dbg_h__
#define __dbg_h__
#include <stdio.h>
#include <stdlib.h>
#include "Io.h"
#define LOGPRINT(M,...) Print("Log.txt",M,##__VA_ARGS__)
#define ERRORPRINT(Ma,...) Print("Error.txt",M,##__VA_ARGS__)
#define MALLOC(p,s) if(!((p)=malloc(s))){fprintf(stderr,"Insufficient_memory");exit(EXIT_FAILURE);}
#define CALLOC(p,n,s) if(!((p)=calloc(n,s))){fprintf(stderr,"Insufficient_memory");exit(EXIT_FAILURE);}
#define REALLOC(p,s) if(!((p)=realloc(p,s))) {fprintf(stderr,"Insufficient_memory");exit(EXIT_FAILURE);}

#endif

