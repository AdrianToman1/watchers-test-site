# watchers-test-site

A test site for The Watchers project.

The Watchers is a simple, self-hosted, low cost / no-cost website availability monitor. I had been using my personal Blog as the target website to test it, but who wants to take there own blog down just to test another project. The Watchers Test Site was created to provide dedicated URLs for testing different error status codes. 

Since The Watchers Test Site is a companion project to the The Watchers project it has the same general properties of being simple, self-hosted, low cost / no-cost, servless and hosted in Azure.

The Watchers Test Site was another learn by doing exercise for me. I have written a few Azure Functions before, but had never created Azure Functions that had an HTTP trigger.

I did learn that the implementation of HTTP triggers is optimised for a RESTful API use case that returns JSON. There is no templating for HTML results and you need to override the default route prefix.
