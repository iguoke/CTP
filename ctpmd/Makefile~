#######################MD################################ 
md:Main.o MdAccount.o 
	g++ -g -o md Main.o MdAccount.o -lthostmduserapi -lpthread
Main.o:Main.cpp Main.h
	g++ -g -c  Main.cpp
MdAccount.o:MdAccount.cpp MdAccount.h
	g++ -g -c  MdAccount.cpp -lthostmduserapi
clean:
	rm -f *.o


