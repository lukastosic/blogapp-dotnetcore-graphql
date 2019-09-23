# Blog app GraphQL api

This is (work in progress) blog application backend with GraphQL.

Application is based on `Conduit` application, or better known as `RealWorld` example application - can be found on [https://github.com/gothinkster/realworld](https://github.com/gothinkster/realworld)

## Database

It is using entity framework, but at the moment only hard coded `InMemory` database.

At the moment only couple of Entities are actually used:
* Person
* Article

## How to run/use

Load in visual studio (code) and just run the app. It will start on localhost:5001 (by default).

Go to `https://localhost:5001/ui/playground` to open Graph QL user interface where you can play with queries and see schema and docs.

## Structure

Overall - the app is using Repository pattern to manage data.

* `Contracts` folder contains repository interfaces
* `Entities` folder contains entities definitions for database layer. Additionaly there are `DatabaseContext.cs` that sets up context and `SampleDataInitializer.cs` that prefills data.
* `GraphQL` contains all funtions for GraphQL
* `GraphQL` -> `GraphQLTypes` contains all Graph QL Type defintions
* `GraphQL` -> `GraphQLQueries` contains all Graph QL Query definitions
* `GraphQL` -> `GraphQLSchema` contains schema definitions
* `Repository` folder contains implementation of interfaces from `Contracts`
* `Controllers` folder is left just as an sample standard REST API controller
