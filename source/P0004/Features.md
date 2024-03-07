# P0004
A non-WebAssembly Razor components Razor class library.

Project File:

* Empty lines between group sections.
* Labeled group sections.
* Main property group
	* OutputType = Exe
	* net8.0
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
* Has Microsoft.AspNetCore.Components.Web package reference.
* Has Folder Include="wwwroot\" element.


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
* Has Components directory.
	* Has App.razor file.
	* App.razor file:
		* Has @using Microsoft.AspNetCore.Components.Routing and @using Microsoft.AspNetCore.Components.Web directives.
		* Has @namespace P0003 directive.
		* Has \<Router> component, with \<NotFound> logic.
* Has wwwroot directory.
	* Directory is empty.
	* (Directory is included in the project file.)

That's it!