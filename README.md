# dotnetCoreProjects
The repository will contain a collection of evolving .Net Core projects which are written and built using both a MacBook Air and a PC running Ubuntu 14.04

## Building and running
To build and run any of these projects (unless explictly stated otherwise in the project's `README.md` file) the `dotnet` commands are used.

For example, lets say that I wanted to build my consoleApplicaiton code.

1. Change directory to the root of the code

    `cd consoleApplication`

1. Issue the `dotnet` restore command (this resolves all nuget packages)

    `dotnet restore`

1. Issue the `dotnet` build command

    `dotnet build`

    This step isn't fully neccessary, but I like to do build and run as separate steps.

1. Issue the `dotnet` run command

    `dotnet run`

    This will start the consoleApplication and run it in the Terminal/Bash window. Once finished, contol will be returned to the Terminal/Bash windwo

## Licence

Each project will have its own licence file (and will ususally be GNU GPL v3), but please check the relevant `LICENCE` file in project's directory.