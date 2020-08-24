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
![alt text](https://lh3.googleusercontent.com/gYlCGmT4UBrilm5riWeIZGsCwI35yDumeaAIn-TEK4NGf1sSgilHVkqxjuoz2fIpFZkGBYuFXqiCWY5NY16aZHwYloxON4BJ85PM_2QL8lIT0kigHQ23I7ynRi94sBGVczQYJLlIZUtiuB55gO5Wu_OWbHOMTZYkgROQHAq05yUW7sVt-ry4X6nZQHCv5Sz7ZzGrFidyyzPcBqe3lskQQPnEy5121_SbJjc3gi2-L4O5Fno5IFRMErxVVdUINEMd4paScS6Up_gfSIKwO1Tg4n6xQ-OjGhEL1WbLWgHzu81yctcaJGsXp_S4HYIIL9QIa4eE8lPH6NecAkZEG7nbh0iXcRM9n6-Q5GU98cg9_jiFR9Ufz5pdHMUsiMZsKScsqWMFITAkkQ25blUWIBzDTDku7PFQJCbVRRbXyFx-lcK_SFMA1Le4w47JRihlOTI-NyqHb81FiOwLtzHRRHJhsA3bgj5k4-ftfTjRIl72Qat6h6rDIVkpH7g8j1Z_cKA5P8Tj_ci_dWIYmLhQ7xtAakafbcxIyHV63YoGROiOgCNjc2UOKMpzrSDn_MGB9m0oodYpbcuoTV1_7v3iRCgrkT77obmAuy-VdMJg_ZDhaKA3dTeFyiRX6yq-OrssfF_hfvy2bZfawOIJxLp5azR7S395GykLkpP6GExS55hb4qYRcsQ-i3KqWjNt11WnXw=w462-h454-no?authuser=0)

 The primary proposition of this architecture is good coupling.
  What is coupling ? It is the level of dependency of one thing upon another. The higher the coupling, the lower the ability to change and evolve the system.
   [Read more about onion architecture](https://www.thinktocode.com/2018/08/16/onion-architecture/)
   
 Also used Unit of work pattern
 The Unit of Work pattern is used to group one or more operations (usually database CRUD operations) into a single transaction or “unit of work” so that all operations either    pass or fail as one. In simple word we can say that for a specific user action, say booking on a website, all the transactions like insert/update/delete and so on are done in one single transaction, rather than doing multiple database transactions. This means, one unit of work here involves insert/update/delete operations, all in one single transaction so that all operations either pass or fail as one.

## API layer
This layer contains all configuration, startup, controller files. In controllers uses CQRS. CQRS is an architectural pattern. 
CQRS is an architectural pattern, where the acronym stands for Command Query Responsibility Segregation. We can talk about CQRS when the data read operations are separated from the data write operations, and they happen on a different interface.
![alt text](https://lh3.googleusercontent.com/JhLpjJAH2SDFpSfM7A3Tr3qwDkjmSGyyoSnMPGXSeXh0KPB69_kCxw3NJ0wRx0D_BESHwZ3Eq8jEXT0J1njifjr34vXSfJgWTU0cvSmEsbs2RgMRRXQWbHl2OYzh1kwYd6r052vr1uN57O5Ix3h42VA_pokm_FGCcPvap-hePqIz4Uv8h5lW5LH5NmGCsGnkd8NdscAvgUqKK8ql3VZuhz_Ksx62ppmaYF7Z8vPG4gZIB0zkX2F5BH_UdKgqN35tO86ucfydu0EpVpegJxGi2r1bGOU4vndu5GoO9WIT9IIvmp-V3d3kJNLLQLajVSY_8zGH_3U9-ydQjOiiLk9uI7TXFS0F138PTWYdVEbnFR2Ej-0ZYkwHudODdqKDqxZvW_ixNKn34NoM9hTr6AXMobRsdQ2FhDoGsJbfgUSL4T1kBVzs6yzaJ60qJD985UnZBaQwNDagJD0-ntqtTdEui1vQnafSY2H4LFNxRZxBwoeSF-i-6pBjt5qgEh1cjHmU8sO7qTZfrcTV60Hi64IDgmh6aJRdQ15oK-YKSBa_hTKw8nLmWY6ne-WP2637N7Kh14_USM_pO89Q1XgaxbRFzqkJ5C_pVL83wdJTtOFvN2NwgX8tvNiGnu9OdeZdBlPfCCPKjQ455vi4ggDC0cb28KJm_Rc6Ra7J3UvgZRoK06eH2QKweqMDdDde8JUDQQ=w584-h100-no?authuser=0)

As you can see request body information is mapped to the List.Query class and it is passed to the appropriate handler by using Send command.

## Application layer

Business layer logic(BLL) - this is the use case layer, calling to the Domain Services(Persistance) layer using Domain Entities and the Infrastructure services. Also provides or acts as an interface to the outside world, which can be achieved through using the Outer UI layer.

## Persistance  layer

The Domain layer is where all the business rules belong. By controlling the domain through the API, and inserting all business logic within the domain, we have a portable application.

For database we use MySql.

## Domain layer

It defines the state and behavior of your application. When looking at the domain classes, you should be able to determine the purpose of your application.
