<!-- 220502.102528 -->

<h2 align="center">

  <img src="resource/image/logo/custom-avatar-web-service-template-logo-512x350.png" alt="Custom Avatar Web Service logo" width="384">
  <br>
  How to create a custom web service for Netsmart's myAvatar™ EHR
  <br>

</h2>

# About this repository

The main purpose of this repository is to provide [detailed instructions](Creating%20a%20custom%20myAvatar%20web%20service%20from%20scratch%20.md) that you can use to create the foundation of a custom myAvatar™ web service.

The secondary purpose of this repository is to provide an [example](src/) of what you'll end up with if you follow the instructions, which you can also use as a template for development.

# Requirements

More information about these requirements are in the documentation, but basically you will need:

* [Visual Studio Community 2022](https://visualstudio.microsoft.com/vs/)
* [.NET Framework 4.8.x](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net48)
* An understanding of the C# programming language
* A place to host your web service that your myAvatar™ environments have access to (via HTTPS)

# Related projects and additional reading

* [MAWS](https://github.com/spectrum-health-systems/MAWS)<br>
These instructions are what I used to create the MyAvatool Web Service (MAWS), a custom myAvatar™ web service that we use at [Spectrum Health Systems](https://www.spectrumhealthsystems.org/).

* [Netsmart web service application template]()<br>
A template for using Netsmart Web Services.

* [ScriptLinkStandard](https://github.com/rcskids/ScriptLinkStandard)<br>
A Class Library designed to assist developers in creating SOAP web services that can be consumed by Netsmart's myAvatar solution using ScriptLink.

* [AvatarScriptLink.NET](https://rarelysimple.github.io/RarelySimple.AvatarScriptLink/)<br>
A .NET Standard library designed to help accelerate the safe and stable adoption of ScriptLink extensions for the Netsmart myAvatar electronic medical record.

***

<h3 align="center">

  [![Developed by](https://img.shields.io/badge/developed%20by-A%20Pretty%20Cool%20Program-17806D)](https://github.com/APrettyCoolProgram)

</h3>