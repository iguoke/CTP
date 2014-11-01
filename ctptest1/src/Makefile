#Makefile for Futures Trader
CC = g++
INC = -I../include
LIB = -lthostmduserapi -lthosttraderapi
SRC = main.cpp MD.cpp TD.cpp
BIN = ../bin
CFLAGS = -g -Wall -m32 -fPIC
TARGET = TestTrader

all:$(TARGET)
	#cp $(TARGET) $(BIN)
$(TARGET):$(SRC)
	$(CC)  $(INC) $(SRC) -L../lib $(LIB) -o $(TARGET)
clean:
	rm -f $(BIN)/* *.o $(TARGET)

