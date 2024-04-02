# D8S.E0013-P0009
A blog (static HTML web application, with Tailwind CSS + Tailwind CSS typography).


## Adding Tailwind CSS typography

1. npm install -D @tailwindcss/typography
1. modify the tailwind.config.js file.
1. Include Tailwind CSS file and inter font in the page HTML (via layout):

@*Use Tailwind CSS*@
\<link rel="stylesheet" type="text/css" href="/css-out/tailwind.css"/>

@*Use Inter font.*@
\<link href='https://rsms.me/inter/inter.css' rel='stylesheet' type='text/css'>

1. Wrap some text in an HTML element that uses the "prose" Tailwind CSS Typography class. (\<div class="prose">...\</div>)
1. In the Program.cs file, add the line: app.UseStaticFiles();


## /Routes/Components/ not /Components/Pages/

For static HTML web applications, components that are pages (route endpoints) are in the /Routes/Components/ directory, not /Components/Pages/ (like they are in WebAssembly