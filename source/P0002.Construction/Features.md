# P0002.Construction
Library construction console application: .NET8.0, basic, no default dependencies, public


Project File:

* Empty lines between group sections.
* Labeled group sections.
* Main property group
	* Labeled with "Main"
	* Output type Exe.
	* net8.0
	* No warnings for numbers: 1573;1587;1591
	* No implicit usings.
	* No nullable.
* Package property group:
	* Labeled with "Package" 
	* Version
	* Author
	* Company
	* Copyright
	* Description
	* RepositoryUrl
	* No PackageLicenseExpression (Since it is an application, and will thus not be packaged.)
	* No PackageRequireLicenseAcceptance (Since it is an application, and will thus not be packaged.)
* Project references item group:
	* Labeled with "Project References"
	* References the P0002 library project (using a relative path, which generally happens by default).


Solution and Project Names:

* Solution name is public (does not have -.Private suffix).
* Main project name is the same as the solution.


Solution File

* P0002.Construction is the first project in the P0002.Construction solution file, so that when the solution is opened for the first time, the construction project is chosen as the default startup project.


Project Structure:

* Has "Project Plan.md" file.
* "Project Plan.md" file:
	* Contains project name as H1 on first line.
	* Project description on second line.
* Has Code directory
* Code directory:
	* Has Program.cs file.
	* Program.cs file:
		* using System;
		* Program class accessibility is left unspecified (not internal)
		* Main() method accessibility is left unspecified (not private)
		* No string[] args parameter.
		* Console.WriteLine() method, with standard "Hello World!" value.
	* Has Documentation.cs file.
	* Documentation.cs file:
		* using System;
		* public static class
		* Project description in XML documentation comment on class.
		* Empty class body.
	* Has Instances.cs file.
	* Instances.cs file:
		* using System;
		* public static class
		* Blank line in class body.

That's it!