# HRng
HRng is a collection of Facebook scraping tools, designed with human resources and content seeding operations in community projects and organizations in mind.

## Installation
HRng is a Visual Studio .NET solution, therefore, Visual Studio or `dotnet` (Linux/macOS only) is required, along with the .NET Core 3.1 SDK and runtime.

To get started with HRng, simply open and build the solution in Visual Studio, or `cd` into the solution directory and run `dotnet build` if you're using `dotnet`.

## Usage
HRng comes with an example implementation for the backend called **LibTests**.
Build the project, then run the `LibTests(.exe)` file in the build output (`bin/`) to check it out.

## Structure
HRng is divided into 2 main components: the **backend** and the **frontend**.

The backend's source can be found in the **HRngBackend** directory/project.
Currently, there's no frontend implementation yet, but an example of how to use the backend can be found in the **LibTests** directory/project.

## Contributing
Pull requests are welcome.
For major changes, please open an issue first to discuss what you'd like to change.

Any feature change requires **LibTests** to be updated accordingly.