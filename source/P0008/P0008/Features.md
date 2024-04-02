# P0008
A WebAssembly Blazor components library.


----- NOT UPDATED BELOW HERE -----

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


Solution and Project Names:

* Solution name is public (does not have -.Private suffix).
* Main project name is the same as the solution


Solution


Project Structure:

* Has "Project Plan.md" file.
* "Project Plan.md" file:
	* Contains project name as H1 on first line.
	* Project description on second line.
* Has appsettings.json file.
* Has appsettings.Development.json file.
* * Has Code directory.
* Code directory:
	* Has Program.cs file.
	* Program.cs file:
		* Has using System;
		* Has using Microsoft.Extensions.DependencyInjection; (separated by blank line)
		* using Microsoft.AspNetCore.Builder; (separated by blank line)
		* Has Program class.
		* Program class accessibility is left unspecified (not internal)
		* Has Main() method.
		* Main() method accessibility is left unspecified (not private)
		* No string[] args parameter.
		* Adds Razor pages.
		* Specifiles "/_Host" fallback URL.
		* Has builder creation, builder build, and app run methods.
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
* Has Routes directory.
	* Has Components director.
	* Components directory:
		* Has Index.razor file.
		* Index.razor file:
			* Contains HTML markup. (To indicate which component is responsible for layout work.)
	* Has Pages directory.
	* Pages directory:
		* Has _Host.cshtml page.
		* _Host.cshtml page:
			* Has @page "/_Host" directive.
			* Has @namespace P0003 directive.
			* Has @addTagHelper directive.
			* Has \<component type="typeof(App)" render-mode="Static" /> markup.
* Has Components directory.
	* Has App.razor file.
	* App.razor file:
		* Has @using Microsoft.AspNetCore.Components.Routing and @using Microsoft.AspNetCore.Components.Web directives.
		* Has @namespace P0003 directive.
		* Has \<Router> component, with \<NotFound> logic.

That's it!