# consoleAppWithUnitTests
This repository contains the `consoleAppWithUnitTests` code.

This is a .Net Console application and as such requires no additional steps to run (such as loading a web page in the browser) once the `dotnet run` command has been issued.

# consoleAppWithUnitTests layout and basic description

This project is based on the .NET Core Unit tests tutorial, which you can read about [here](https://docs.microsoft.com/en-us/dotnet/articles/core/testing/unit-testing-with-dotnet-test), and is split into two sections:

1. `App` + `Library` (within /src)
2. `Test-Library` (within /test/test-library)

### App + Library

The application and library code are reliatively simple:

Library contains a single class called `Thing`, which has a single method called `Get`. `Get`has the following non-trivial process:

1. Takes two integers as parameters
1. Sums the two paramters
1. Stores the result of the sum in a String (via [String Interpolation](https://msdn.microsoft.com/en-GB/library/dn961160.aspx?f=255&MSPPError=-2147217396)
1. Using a JSON Deserialiser, deserialises the string back into an integer
1. Returns the new integer.

Application contains a single call to `Thing`'s `Get` method and displays the value returned on the console.

### Test-Library

The `Test-Library` contains a single class (`LibraryTest`) which makes use of the `Library` class. It `Assert`'s that the returned value of calling the `Get` method is correct, then exits.

#### project.json

As the test library requires use of the Library classes, it needs to be referenced within the Test-Library `project.json`. The `project.json` contains this section:

    "library": {
      "target": "project"
    }

This tells the .NET Core compiler that we need the project called `library` and that it should be loaded as a project. Without `target: project` here, the .NET Core compiler will attempt to load `library` from NuGet (or a similar source).

## Building and running
1. Change directory to the root of the code

    `cd consoleAppWithUnitTests`

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
