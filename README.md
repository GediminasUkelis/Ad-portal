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
![alt text](https://lh3.googleusercontent.com/tOYPcONAjd9AZwCBx5Cnq1e5j-_LLUR4DY_Tg8Hebq4JBPleqgLAvdimQXtvou94tOCHyQ6Nxf00bfKxRAB77CFexNCszUb9qxpqD9cC8cnspQ_GvRnRQ4rf9PV2cAWVUU3pOH1iCFDuRCL67mkD3USBW-7e3kUW8DjxL0H_by1m5YyXVEsiYEIdccexY-y5cJXVgUjKO_XA7ibLbsYGl4yNxxcVT_KJMldQzG3zQIYQ_JBYFlm4ZFEhogZc-VWawCmjrzQD2xz4YFgHacqBJ9fI2hQz6usInWoIYVIdDS9rXBS-yaaOWqU1qEbzLeFYzcowNbjYJegy4MxK9m5t5Wsl2TtIj_Isl8_A5PlPWFOgOHkNtFnHWBtUa7MdZQrS_Ch0YrKkh2kkeOv_KJ8CMiJdft48wW7zshDFCYveGJdyoz5yUaIMJpJtlCXFxlC4ZDm48iFUpbFVNF1JFIgmzlfQXDBVmN3LvkcZ-lgNFvnCCvVdY-iNHVnqtf0hQg6RA47HBx5lOBv6qB2N-d1Hr6SV0DGoZN68O7nWYiXHcKHBEcmXfIaxP-whYDmyD0wRVJ2Iy3jBXWvijk9SCvMBlOshoUYkwsDSj50RA56hTrBXXlvEYIAC9Rbx-AIVxIXDyegFEZ6bgGUurvwXY3xI4Oi_0BwyA0hgtbteH3YQdbeK0ISoMFDW0ZJ03C_mGw=w462-h454-no?authuser=0)

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
