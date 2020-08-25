# Ad-portal

# 1. Helpful articles:
  - [Onion Architecture](https://www.thinktocode.com/2018/08/16/onion-architecture/)
  - [RESTful API](https://docs.microsoft.com/en-us/aspnet/web-api/overview/older-versions/build-restful-apis-with-aspnet-web-api)  
  - [Jwt token](https://jwt.io/introduction/)
  - [CQRS](https://www.e4developer.com/2018/03/11/cqrs-a-simple-explanation/)
  - [Unit Of Work](https://www.c-sharpcorner.com/UploadFile/b1df45/unit-of-work-in-repository-pattern/)
# Project structure 

In this project we chose **onion architecture** 
Ad-Portal project uses Onion layered architecture.
Base project structure:
![alt text](https://lh3.googleusercontent.com/W1PBZ8be4rMo51YMk4_TSVhZPbyR72WTvXnX7sBuYbFybD8uBCL_ft6S5LI87RMx7E-9kAPViHF_ToZbxY9x0BjYIprkqjar-s9Y84PmMHrX1IbnRIwbfmD1EBLvytFNnVOi_4wsLGspyFfD5LyO4F7EwkYzq1M6DgnIfNlcpumKVjAW6pWeeiHIErqRyOdO_3cfd4qADrxHhT4cciusBkBxv68EdtboKrghBufNBlhUR3J0aDuEItol2FvYPFy0LmcRNCNQz760quX2HP5FmtRg6K42zLzXHzvXQy92tft2RWyWVQS5fLjFSyOj2yU7IdRhRR0K-F9uPLwN6JBWt8N1wNsdabCwA9uyU81W1_VblY9eX9oc_0zxtGTX0FA_kTgz1ZflKJh8cKoISMKuCnBKa5uM1Q06fK11M-T8oYUtUnP2Sx10xOdQGp0qgDCycXXxZ1Ma9XmthNfsgi1wyh8HB1WM72h_Bv6z4_V_FqSE1QvqbAduRydbXENH8ZoH9DHgnjla1vx4bbw79x0oNB6EFBAEaFKPYij76VEzM6M6C1sjc9d2Jg4eB2FUxPEJ1xkLI2yv2VWjQC5bGCErP2SIsOUsmUmPQUNVwIpg5lVbVLBTxlhRB9AF5kDSbZXd2REO8q9F2xih4vm4mzq7KkWpD4SIDXM6Y3FWHCCO5K2vhx5g7A6SgRDlKX94aw=w462-h454-no?authuser=0)

 The primary proposition of this architecture is good coupling.
  What is coupling ? It is the level of dependency of one thing upon another. The higher the coupling, the lower the ability to change and evolve the system.
   [Read more about onion architecture](https://www.thinktocode.com/2018/08/16/onion-architecture/)
   
 Also used Unit of work pattern
 The Unit of Work pattern is used to group one or more operations (usually database CRUD operations) into a single transaction or “unit of work” so that all operations either    pass or fail as one. In simple word we can say that for a specific user action, say booking on a website, all the transactions like insert/update/delete and so on are done in one single transaction, rather than doing multiple database transactions. This means, one unit of work here involves insert/update/delete operations, all in one single transaction so that all operations either pass or fail as one.

## API layer
This layer contains all configuration, startup, controller files. In controllers uses CQRS. CQRS is an architectural pattern. 
CQRS is an architectural pattern, where the acronym stands for Command Query Responsibility Segregation. We can talk about CQRS when the data read operations are separated from the data write operations, and they happen on a different interface.



```csharp
  public async Task<ActionResult<List<VehicleDto>>> ListAsync()
    {
        return await uow.Mediator.Send(new List.Query());
    }
```

As you can see request body information is mapped to the List.Query class and it is passed to the appropriate handler by using Send command.

## Application layer

Business layer logic(BLL) - this is the use case layer, calling to the Domain Services(Persistance) layer using Domain Entities and the Infrastructure services. Also provides or acts as an interface to the outside world, which can be achieved through using the Outer UI layer.

## Persistance  layer

The Domain layer is where all the business rules belong. By controlling the domain through the API, and inserting all business logic within the domain, we have a portable application.

For database we use MySql.

## Domain layer

It defines the state and behavior of your application. When looking at the domain classes, you should be able to determine the purpose of your application.
