# P0002
Library: .NET Standard 2.1, basic, no default dependencies, public


Project File:

* Empty lines between group sections.
* Labeled group sections.
* Main property group
	* OutputType unspecified (because library is the default option if unspecified)
	* netstandard2.1
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

* Has complementary P0002.Construction solution with construction 
	There are two solutions so that at-a-glance you can see which project dependencies are required by the library, and which by both the library and the construction code.


Project Structure:

* Has "Project Plan.md" file.
* "Project Plan.md" file:
	* Contains project name as H1 on first line.
	* Project description on second line.
* Has Code directory
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

That's it!