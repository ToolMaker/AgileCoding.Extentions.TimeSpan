AgileCoding.Extensions.TimeSpan
===============================

Overview
--------

AgileCoding.Extensions.TimeSpan is a .NET library that offers a set of extension methods for handling TimeSpans more effectively. It's built for .NET 6.0.

Installation
------------

This library is distributed via NuGet. To install, use the following command in the NuGet Package Manager console:

bash

`Install-Package AgileCoding.Extensions.TimeSpan -Version 2.0.5`

Features
--------

This library offers the following extension methods:

-   `ToTimeSpan`: Converts a string to a TimeSpan.
-   `ToTimeSpan<IExceptionType>`: Converts a string to a TimeSpan, and throws a specified exception if the conversion fails.

Usage
-----

Here is an example of how you can use these methods in your code:

```csharp
using AgileCoding.Extentions.TimeSpans;

string timeString = "10:00:00";

// Convert string to TimeSpan without throwing exception on failure.
TimeSpan time = timeString.ToTimeSpan();

// Convert string to TimeSpan and throw exception on failure.
TimeSpan validTime = timeString.ToTimeSpan<FormatException>("Invalid TimeSpan format.");
```

Documentation
-------------

For more detailed information about the usage of this library, refer to the [official documentation](https://github.com/ToolMaker/AgileCoding.Extentions.TimeSpan/wiki).

License
-------

This project is licensed under the terms of the MIT license. For more information, refer to the [LICENSE](https://github.com/ToolMaker/AgileCoding.Extentions.TimeSpan/blob/main/LICENSE) file.

Contributing
------------

Contributions are welcome! Please see our [contributing guidelines](https://github.com/ToolMaker/AgileCoding.Extentions.TimeSpan/blob/main/CONTRIBUTING.md) for more details.