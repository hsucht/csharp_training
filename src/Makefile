OUTPUT=$(shell mono Helloworld.exe)

test: compile run
	@if [ "$(OUTPUT)" == "Hello, World!" ]; then echo success; fi

compile: Helloworld.cs
	mcs Helloworld.cs

run:
	mono Helloworld.exe
