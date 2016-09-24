# consoleApplication
This repository contains the `consoleApplication` code.

This is a .Net Console application and as such requires no additional steps to run (such as loading a web page in the browser) once the `dotnet run` command has been issued.

# consoleApplication layout and basic description
At the time of writing (vary late in the evening of 9/9/2016) this application is made of three layers:

- Program
- BLL (or Business Logic Layer)
- DataLayer

The `BLL` is responsible for creating instances of classes, which are described in the `DataLayer`. These classes are then consumed within the `Program` classes.

The following is the execution path for `consoleApplication`:

1. The `Main` method from within Program.cs is called
1. The `GenerateMyObject` method of the static class `MyObjectFactory` is called
1. An instance of `MyObject` is returned from `GenerateMyObject`
1. An instance of the `LogicController` class is created and the instance of `MyObject` is passed to it.
1. The `RunLogic` method of the `LogicControlller` instance is run
1. The contents of the `MyObject` instances `Title` field are used to print a message to the console window
1. Application exits 

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

## medico Reference

As of 24/09/2016 this project is intrinsically linked to [`medico`](http://wiki.gaprogman.com/index.php?title=Medico). This is because the [medico Medication Class Json Format](http://wiki.gaprogman.com/index.php?title=Medico_-_Medicine_Class_Format) was used to implement and test JSON parsing.

### Warning to potential devs

In the `MyFileReader` class (as of 24/09/2016) there is this wonderful line of code:

    Path.Combine(binLocation, @"../../../../JsonFiles/");

There is a code comment block explaining this particularly egregious line. It is recommended that devs take a look at the comment block and become familiar with the layout of the project files. 

## Licence

This licence for this project is a GNU GPL v3 licence, please see the `LICENCE` file for more details