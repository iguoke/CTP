objects = main.o kbd.o command.o display.o \
insert.o search.o files.o utils.o

test : $(objects)
cc -o test $(objects)

$(objects) : defs.h
kbd.o command.o files.o : command.h
display.o insert.o search.o files.o : buffer.h

.PHONY : clean
clean :
rm test $(objects)
