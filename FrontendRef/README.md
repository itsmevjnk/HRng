# FrontendRef
A reference frontend for HRngBackend.
This supersedes LibTests as the reference implementation for HRng's frontend, even though LibTests will continue to be used for backend function testing.

## Installation
Build this project using Visual Studio or `dotnet` (refer to the solution's `README.md`).

## Usage
After building, execute the `FrontendRef` executable (`FrontendRef.exe` on Windows) in the `bin/Debug/netcoreapp3.1/` directory.
The usage of the executable is as follows:
```
FrontendRef --chrome/--firefox [--headless] (list of paths to order files)
    --chrome  : Use Chrome/Chromium for performing operations.
    --firefox : Use Firefox for performing operations.
    --headless: Start the browser in headless mode (i.e. no GUI).
                Optional.
```
Actions are grouped into order files, whose example can be found in the `Order.example.xml` file in this directory. 
All relative file paths referenced in the order file are relative to the executable's working directory.
Therefore, absolute file paths are recommended.

## Contributing
Pull requests are welcome.
For major changes, please open an issue first to discuss what you'd like to change.
