CreateBuilder()
↓
Register services
↓
Build()
↓
Configure middleware
↓
Map endpoints
↓
Run()

What is the Middleware Pipeline?
Simple definition

The middleware pipeline is an ordered sequence of components that every HTTP request and response passes through.

Think of it like a conveyor belt for requests.

HTTP Request
   ↓
Middleware 1
   ↓
Middleware 2
   ↓
Middleware 3
   ↓
Endpoint (Controller)
   ↓
Middleware 3 (back)
   ↑
Middleware 2 (back)
   ↑
Middleware 1 (back)
   ↑
HTTP Response
