# Cash Office Helper (Visual)

Guided workflow tool for closing accounting procedures. 

I created this as a tool to assist me but also just to see if I could.

## Overview

This program was originally made as a C# console based application. This version instead uses Blazor Pages to make it more accessible and to focus on a more visual approach with clickable/tappable buttons compared to before.

A few things this application does:

- Shows/hides menu buttons as needed based on progress
- Features different workflows for weekdays and saturday nights
- Has guides written for each step (though the process for other stores may be different)
- Optionally runs on a port (the base code includes this by default) to be accessible as a website through tailscale or other VPN solutions.
    - This was my workflow with it, makes it easy to have it open as a website on my phone to keep track of things while I do my work.
- Has debug messages print in console

## Tech Stack

- C# and .NET 9.0
- Blazor Server, Razor Components
- Dependency Injection for state management (See `ProgressTrackerService.cs`)
- HTML & CSS for UI

## Future Goals

- [ ] Have this instead link to a sql* database for data persistence, potentially with API
- [ ] Small tools built in for calculations