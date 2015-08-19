OUTPUT=$(shell mono helloworld.exe)

test: compile run
	@if [ "$(OUTPUT)" == "Hello, World!" ]; then echo success; fi

compile: helloworld.cs
	mcs helloworld.cs

run:
	mono helloworld.exe
