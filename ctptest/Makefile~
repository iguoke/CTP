MD: main.o MD.o 
	g++  -o MD main.o MD.o -L. -lthostmduserapi
main.o: main.cpp MD.cpp MD.h
	g++ -C main.cpp
MD.o: MD.cpp MD.h
	g++ -C MD.cpp


clean:
	rm MD MD.o main,o
