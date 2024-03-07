# D8S.E0013-P0003
A static HTML website with Razor pages using Razor components for rendering.


## How this works

In the Program.cs file, there are two simple statements:

	1. builder.Services.AddRazorPages() - Adds the ability to route a request to a Razor page by matching the URL against a @page directive value in a Razor page.
	2. app.MapFallbackToPage("/_Host") - Given a request URL, if no matching Razor page is found for a URL, then use the Razor page at /_Host.

There is a _Host.cshtml page that does nothing except use the Razor component tag helper to statically (not dynamically) render a Razor component specified by type to HTML:

\<component type="typeof(App)" render-mode="Static" />

This then calls the App Razor component in the App.razor file, which again performs routing based on the URL by matching @page directive values in Razor components (not Razor pages).

\<Router AppAssembly="@typeof(App).Assembly">
    \<Found Context="routeData">
        \<RouteView RouteData="@routeData" />
    \</Found>
    \<NotFound>
        \<PageTitle>Not found\</PageTitle>
        \<p role="alert">Sorry, there's nothing at this address.\</p>
    \</NotFound>
\</Router>

It's important to understand: this Razor component routing occurs *after* Razor page routing. Thus here are the matching routes for a few URLs:

    * "/" -> Index.razor (component).
        The URL "/" does not match any @page directive values amoung Razor pages, so use the fallback URL "/_Host". This matches the _Host.cshtml page, which renders the App component. The App component then uses the Router component to route to the Index.razor component becase it specifies the @page directive value "/".
    * "/Page1" -> Page1.cshtml (page).
        The URL "/Page1" matches the @page directive "/Page1" in the Razor page.
    * "/Page2" -> Page2.razor (component).
        The URL "/Page2" does not match any Razor page @page directive values, so the fallback URL "/_Host" is used. This matches the _Host.cshtml page, which renders the App component. The App component then uses the Router component to route to the Page2.razor component becase it specifies the @page directive value "/Page2".
    * "/DoesNotExist" -> "Sorry, there's nothing at this address.".
        The URL "/" does not match any @page directive values amoung Razor pages, so use the fallback URL "/_Host". This matches the _Host.cshtml page, which renders the App component. The App component then uses the Router component to try and match the URL among the available Razor component routes. However, none match, so the Router component uses its <NotFound> component logic.

Within both Razor components, a Test.razor component is used. This shows

For layouts, each routed component ("/" for Index.razor, or "Page2" for Page2.razor) would specify its own layout. This is to say, the App component does *not* specify the Razor component layout, the routed component does.