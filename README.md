# dot-net-microservices
This repository is meant to explain with simple samples how to design and develop microservices using .NET and C#. This hands-on guide will take you on a journey through the world of microservices architecture and help you craft scalable, maintainable, and fault-tolerant applications.

### Technologies
![.NET](https://img.shields.io/badge/.NET-512BD4?style=flat&logo=dotnet&logoColor=white) 
![C#](https://img.shields.io/badge/C%23-239120?style=flat&logo=c-sharp&logoColor=white) 
![Docker](https://img.shields.io/badge/Docker-2496ED?style=flat&logo=docker&logoColor=white)
![MongoDB](https://img.shields.io/badge/MongoDB-47A248?style=flat&logo=mongodb&logoColor=white) 
![PostgreSQL](https://img.shields.io/badge/PostgreSQL-316192?style=flat&logo=postgresql&logoColor=white) 
![RabbitMQ](https://img.shields.io/badge/RabbitMQ-FF6600?style=flat&logo=rabbitmq&logoColor=white)

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg?style=flat)](./LICENSE)

# Summary
This repository pretends to be a base for a small course about how to build microservices with .Net and C#. In the repository there are several .Net projects simulating 2 microservices of a fictinional Bank System.

The first microservices is the Account Management, and the second one is the Notification service of the Bank system. As you can see in the following image even both microservices are built with .Net, the Account Management Service uses MongoDB as Database and the API's are built with the Controller approach. The Notification service was built using the minimal API approach and PostgreSQL as the database. The entire repository is based on the Julio Casal course that can be found at [YouTube](https://www.youtube.com/watch?v=ByYyk8eMG6c).

![image](https://github.com/Nattanahel-Chaves/dot-net-microservices/assets/118920372/85658d0a-9847-4fd2-a153-b63dba3f988a)

Each folder in the repository contains only the code for one of the microservices, in a different stage of development. For instance, the folder 02-Account Service is the first version of the service, while the 09-Account Service is the final version of the same service. Inside each project the README file will gide you about the commands and tasks to be completed.

# How to install it?
1. Clone the repository
2. Install [dotnet](https://dotnet.microsoft.com/en-us/download/dotnet).
3. Install docker.
4. Move to the subfolders and follow the instructions.

# How to run it?
If you want to run the final version of the entiry project:
1. Go to the 10-Infrastructure folder and run `docker-compose up` command.
2. Go to the 11-NotificationService folder and run the `dotnet run` command.
3. Go to the 09-AccountService folder and run the `dotnet run` command.
4. In the Account Service endpoint append `swagger`add at least one account and then edit it. Make sure the balance is less than 50 in the PUT request. You can interact with the endpoint with a tool like Postman too.
5. In the Notification service endpoint append `swagger` and execute a GET request. You can interact with the endpoint with a tool like Postman too.
6. Optional. If you want to emulate Notification Service 500 errors go to the `program.cs` file and change the following line of code frm `false` to `true`:

```C#
var emulate500Error = false;
```


# Chapters

- [The most basic microservice in .Net](https://github.com/Nattanahel-Chaves/dot-net-microservices/tree/main/01-Basic#readme) 
- [Account Management Service with in memory DB.](https://github.com/Nattanahel-Chaves/dot-net-microservices/tree/main/02-AccountService#readme)
- [Account Management Service using MongoDB.](https://github.com/Nattanahel-Chaves/dot-net-microservices/tree/main/03-AccountService#readme)
- [Docker-Compose to start MongoDB](https://github.com/Nattanahel-Chaves/dot-net-microservices/tree/main/04-Infrastructure#readme)
- [Notification Service with in memory DB](https://github.com/Nattanahel-Chaves/dot-net-microservices/tree/main/05-NotificationService#readme)
- [Notification Service with PostgreSQL and Entity Framework.](https://github.com/Nattanahel-Chaves/dot-net-microservices/tree/main/06-NotificationService#readme)
- [Docker-Compose to start MongoDB and PostgreSQL](https://github.com/Nattanahel-Chaves/dot-net-microservices/tree/main/07-Infrastructure#readme)
- [Account Management Service invoking Notification Service.](https://github.com/Nattanahel-Chaves/dot-net-microservices/tree/main/08-AccountService#readme)
- [Account Management Service producing and sending messages to RabbitMQ.](https://github.com/Nattanahel-Chaves/dot-net-microservices/tree/main/09-AccountService#readme)
- [Docker-Compose to start MongoDB, PostgreSQL and RabbitMQ.](https://github.com/Nattanahel-Chaves/dot-net-microservices/tree/main/10-Infrastructure#readme)
- [Notification Service consumming messages from RabbitMQ.](https://github.com/Nattanahel-Chaves/dot-net-microservices/tree/main/11-NotificationService#readme)
- [Contracts share between services](https://github.com/Nattanahel-Chaves/dot-net-microservices/tree/main/12-Contracts#readme)
