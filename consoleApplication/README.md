# consoleApplication
This repository contains the `consoleApplication` code.

This is a .Net Console application and as such requires no additional steps to run (such as loading a web page in the browser) once the `dotnet run` command has been issued.

## Building and running
1. Change directory to the root of the code

    `cd consoleApplication`

1. Issue the `dotnet` restore command (this resolves all NuGet packages)

    `dotnet restore`

1. Issue the `dotnet` build command

    `dotnet build`

    This step isn't fully neccessary, but I like to do build and run as separate steps.

1. Issue the `dotnet` run command

    `dotnet run`

    This will start the consoleApplication and run it in the Terminal/Bash window. Once finished, contol will be returned to the Terminal/Bash window.

    This is the only command required to be issued once the NuGet packages have been restored and the application has been built.

## Licence

This licence for this project is a GNU GPL v3 licence, please see the `LICENCE` file for more details