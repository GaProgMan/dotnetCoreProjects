# webpack-ts
This repository contains the `webpack-ts` code.

This is a .NET Core MVC application which has some `npm` dependencies (see `Dependencies` section below). As such anyone wanting to build and run this application will need to install the dependencies before running it.

# webpack-ts layout and basic description

webpack-ts is an MVC application with [TypeScript](https://www.typescriptlang.org/) and [webpack](https://webpack.js.org/) support built in. The source layout matches that of a standard .NET Core MVC application, with a small number of exceptions:

1. content/js
1. wwwroot/app
1. package.json
1. tsconfg.json
1. webpack.config.js

The `content/js` directory contains a selection of TypeScript files, which will be transpiled by the webpack plugin [awesome-typescript-loader](https://github.com/s-panferov/awesome-typescript-loader).

The `wwwroot/app` directory will contain all bundles that are created by webpack (after any transpilation from TypeScript has taken place).

The `package.json` file is an npm configuration file, which tells npm which packages to install in order to build and run this application.

The `tsconfig.json` file is a TypeScript configuration file. This is used by the awesome-typescript-loader plugin to transpile any TypeScript files to JavaScript before bundling them with webpack.

The `webpack.config.js` file is a webpack configuration file. This describes the entry points, outputs and plugins that webpack must use to bundle our JavaScript.

## Building and Running webpack-ts

1. Download and install all of the npm packages

    `npm install`

1. Restore all required .NET Core packages:

    `dotnet restore`

1. Transpile all TypeScript and build all JavaScript bundles:

    `webpack`

1. Build and run the application:

    `dotnet run`

## Licence

This project uses the MIT licence, please see the `license.md` file for more details.
