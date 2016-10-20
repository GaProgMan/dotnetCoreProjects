# consoleAppWithUnitTests
This repository contains the `consoleAppWithUnitTests` code.

This is a .Net Console application and as such requires no additional steps to run (such as loading a web page in the browser) once the `dotnet run` command has been issued.

# consoleAppWithUnitTests layout and basic description

This project is based on the .NET Core Unit tests tutorial, which you can read about [here](https://docs.microsoft.com/en-us/dotnet/articles/core/testing/unit-testing-with-dotnet-test), and is split into two sections:

1. `App` + `Library` (within /src)
2. `Test-Library` (within /test/test-library)

### App + Library

The application and library code are reliatively simple:

`Library` contains a single class called `Thing`, which has a single method called `Get`. `Get`has the following non-trivial process:

1. Takes two integers as parameters
1. Sums the two paramters
1. Stores the result of the sum in a String (via [String Interpolation](https://msdn.microsoft.com/en-GB/library/dn961160.aspx?f=255&MSPPError=-2147217396))
1. Using a JSON Deserialiser, deserialises the string back into an integer
1. Returns the new integer.

`Application` contains a single call to `Thing`'s `Get` method and displays the value returned on the console.

### Test-Library

The `Test-Library` contains a single class (`LibraryTest`) which makes use of the `Library` class. It `Assert`'s that the returned value of calling the `Get` method is correct, then exits.

#### project.json

As the test library requires use of the Library classes, it needs to be referenced within the Test-Library `project.json`. The `project.json` contains this section:

    "library": {
      "target": "project"
    }

This tells the .NET Core compiler that we need the project called `library` and that it should be loaded as a project. Without `target: project` here, the .NET Core compiler will attempt to load `library` from NuGet (or a similar source).

## Unit Tests in .NET Core

The dependencies section of `test-library`'s `project.json` looks like this:

    "dependencies": {
        "System.Runtime.Serialization.Primitives": "4.1.1",
        "xunit": "2.1.0",
        "dotnet-test-xunit": "1.0.0-rc2-192208-24",
        "library": {
            "target": "project"
        }
    }

The important lines for unit tests are:

    "xunit": "2.1.0",
    "dotnet-test-xunit": "1.0.0-rc2-192208-24",

You can read more about `xunit` at the [`xunit` GitHub page](https://xunit.github.io/)

`xunit` is run against `test-library` by following these steps (assuming you are in the root directory of the project):

1. Change directory to `test`:

    `cd test`

1. Change directory to `test-library`:

    `cd test-library`

1. Issue the `dotnet test` command:

    `dotnet test`

    This will start the .NET Core test framework and pass `test-library`'s project.json to it.

    Any dependencies that have not yet been restored (either from NuGet or from libraries) will be restored, before further processing.

    After this, `xunit` will be called and the tests in `test-library` will be processed.

## Licence

This licence for this project is a GNU GPL v3 licence, please see the `LICENCE` file for more details
