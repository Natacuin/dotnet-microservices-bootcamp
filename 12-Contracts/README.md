## Create the project
Rather than including the class _CreateNotification_ in both projects, this repository uses a Class Library project type. The class is copied to the new project, and then it is removed from the Account Service and Notification Service projects. The Class Library project is shared with the other two projects.

``` powershell
dotnet new classlib -n BestBank.Contracts
```
