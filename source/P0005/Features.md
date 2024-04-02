# P0005
A Windows Forms class library.

Project File:

* Empty lines between group sections.
* Labeled group sections.
* Main property group
	* OutputType = Library
	* net8.0-windows
	* No warnings for numbers: 1573;1587;1591
	* No implicit usings.
	* No nullable.
* Package property group:
	* Version
	* Author
	* Company
	* Copyright
	* Description
	* RepositoryUrl
	* PackageLicenseExpression
	* PackageRequireLicenseAcceptance


Solution and Project Names:

* Solution name is public (does not have -.Private suffix).
* Main project name is the same as the solution


Solution


Project Structure:

* Has "Project Plan.md" file.
* "Project Plan.md" file:
	* Contains project name as H1 on first line.
	* Project description on second line.
* Has Code directory.
* Code directory:
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
	* Has Classes directory:
		* Has Class1.cs file.
			* using System;
			* public non-static class.

That's it!