# Makefile for FNA ABI Compatibility Files
# Written by Ethan "flibitijibibo" Lee

all: FNA Game Graphics GamerServices Graphics Input.Touch Net Storage Video Xact

FNA: fnacopy
	mcs FNA.cs -target:library -r:FNA.dll

Game: fnacopy
	mcs FNA.Game.cs -target:library -r:FNA.dll -r:FNA.NetStub.dll

GamerServices: fnacopy
	mcs FNA.GamerServices.cs -target:library -r:FNA.dll -r:FNA.NetStub.dll

Graphics: fnacopy
	mcs FNA.Graphics.cs -target:library -r:FNA.dll

Input.Touch: fnacopy
	mcs FNA.Input.Touch.cs -target:library -r:FNA.dll

Net: fnacopy
	mcs FNA.Net.cs -target:library -r:FNA.dll -r:FNA.NetStub.dll

Storage: fnacopy
	mcs FNA.Storage.cs -target:library -r:FNA.dll

Video: fnacopy
	mcs FNA.Video.cs -target:library -r:FNA.dll

Xact: fnacopy
	mcs FNA.Xact.cs -target:library -r:FNA.dll

fnacopy: clean
	cp ../bin/Debug/FNA.dll .
	cp ../../FNA.NetStub/bin/Debug/FNA.NetStub.dll .

clean:
	rm -f *.dll
