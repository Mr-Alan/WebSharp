# Welcome to your WebSharp Electron Application - convert

## What's in the folder

This folder contains all of the files necessary for your application.

```
.
|--- .eslintrc.json
|--- .gitignore
|--- .vscode                           // VS Code integration
     |--- launch.json                  // Launch Configurations
     |--- settings.json
|--- .vscodeignore
|--- convert-quickstart.md        // The document you are reading now
|--- index.html                       // Html to be displayed in the app window
|--- jsconfig.json
|--- main.js                          // Defines the electron main process
|--- node_modules
     |--- All the node files used to run the electron application
|--- package.json                     // Various project metadata
|--- README.md
|--- renderer.js                      // Required in index.html and executed in the renderer process for that window 
|--- src                              // sources
     |--- convert.js                    // javascript code implementation
     |--- Main                             
          |--- nuget.config                 // Configuring NuGet behavior
          |--- packages.config              // Used to track installed packages
          |--- MainWindow.cs                // Controls the applications main event lifecycle via managed code
          |--- MainWindow.csproj            // Project          
          |--- MainWindow.sln               // Solution
     |--- ConvertUI
          |--- nuget.config           // Configuring NuGet behavior
          |--- packages.config        // Used to track installed packages
          |--- ConvertUI.cs               // Application Implementation
          |--- ConvertUI.csproj           // Project          
          |--- ConvertUI.sln              // Solution          
     |--- Build.sln                         // Global project build solution
```

* This folder contains all of the files necessary for your application
* `package.json` - this is the manifest file in which you declare your application.  The format of package.json is exactly the same as that of Node’s modules, and the script specified by the main field is the startup script of your app, which will run the `main` process.  `Note:` If the main field is not present in package.json, Electron will attempt to load an index.js.
* `main.js` - this is the main file where you will provide the implementation of your application.  The main.js should create windows and handle system events.
* `index.html` - this is the web page you want to show.
* `src/convert.js` - this src file defines calls the ConvertUI C# expression that will be printed to the console by default.
* `src/ConvertUI/ConvertUI.cs` - this src file is the C# managed code implementation of the application that prints to the console by default.
* `src/ConvertUI/ConvertUI.sln` and `src/ConvertUI/ConvertUI.csproj` - this solution file builds the files that make up the C# managed code implementation of the application.
* `src/Main/MainWindow.cs` - this src file is the C# managed code implementation of the application that allow the control of the application lifecycle events.
* `src/Main/MainWindow.sln` and `src/Main/MainWindow.csproj` - this solution file builds the files that make up the C# managed code implementation of the application that allow the control of the application lifecycle events.
* `src/Build.sln` - this solution file is a solution of solutions to provide a general build of the source projects `src/Main/MainWindow.sln` and `src/ConvertUI/ConvertUI.sln`.

## Get up and running straight away
* press `F5` to open a new window with your application loaded.
  * On Windows look for `Launch Windows` target
  * On Mac select the `Launch Mac` target
* run your command from the command terminal `npm start`.
  * (`Ctrl+Shift+P` or `Cmd+Shift+P` on Mac) and typing `View:Toggle Integrated Terminal`
  * Use the (`Ctrl+'` or `Cmd+'` on Mac) keyboard shortcut with the backtick character.
  * Use the `View | Toggle Integrated Terminal` menu command.

## Debugging
* Requires `Node.js` and the `Chrome Debugger`.
  * Install the [Chrome Debugger](https://marketplace.visualstudio.com/items?itemName=msjsdiag.debugger-for-chrome) with `ext install debugger-for-chrome`

## Explore the WebSharp Electron Application docs
* you can view the WebSharp Electron Application information by clicking [here](https://github.com/xamarin/WebSharp/blob/master/docs/getting-started/getting-started-websharp-electron-application.md)

