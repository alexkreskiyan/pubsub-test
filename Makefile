restore:
	dotnet restore
build:
	dotnet build

run-controller:
	dotnet exec ./bin/Debug/netcoreapp1.1/PubSub.dll controller

run-listener:
	dotnet exec ./bin/Debug/netcoreapp1.1/PubSub.dll listener
