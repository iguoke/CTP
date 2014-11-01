#ifndef __THREADPOOL_H_
#define __THREADPOOL_H_

typedef struct threadpool_t threadpool_t;

threadpool_t *threadpool_create(int min_thr_num,int max_thr_num,int queue_max_size);
int threadpool_add(threadpool_t *pool,void*(*fuction)(void *arg),void *arg);
int threadpool_destroy(threadpool_t *pool);
int threadpool_all_threadnum(threadpool_t *pool);
int threadpool_busy_threadnum(threadpool_t *pool);
#endif
