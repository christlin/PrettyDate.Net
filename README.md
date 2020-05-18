# PrettyDate.Net

PrittyDate.Net is a .Net library to provide pretty date conversion from regular DateTime Object.

### Installation

```
Install-Package PrettyDate.Net -Version 1.0.0
```
 

### Usage

PrettyDate.Net does not need any other depenedncies other than core classes in .Net Framework.

Here is an example of the usage

```C#
// 90 seconds ago.
Console.WriteLine(PrettyDate.From(DateTime.Now.AddSeconds(-90)));
// 25 minutes ago.
Console.WriteLine(PrettyDate.From(DateTime.Now.AddMinutes(-25)));
// 45 minutes ago.
Console.WriteLine(PrettyDate.From(DateTime.Now.AddMinutes(-45)));
// 4 hours ago.
Console.WriteLine(PrettyDate.From(DateTime.Now.AddHours(-4)));
// 15 days ago.
Console.WriteLine(PrettyDate.From(DateTime.Now.AddDays(-7))); 
// 150 days ago.
Console.WriteLine(PrettyDate.From(DateTime.Now.AddDays(-150))); 
// 2 years ago.
Console.WriteLine(PrettyDate.From(DateTime.Now.AddDays(-715)));
```
