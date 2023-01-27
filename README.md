This is repository that holds a console application to reproduce an issue using the dapr run command.

### Issue
The dapr runtime stales when it tries to log a large application log. 
By using this test solution I found that with with different values the issue behaves differently. For example:
* If the threshold is set to 12000 or lower, dapr logs the application log and it exits successfully.
* If the threshold is set to 13000 (I did not test other numbers near this value), dapr doesn't log the app log and it exits successfully.
* if the threshold is set to 14000 or higher, dapr doesn't log the app logs and it stales and never finishes.

The threshold can be changed within the `./ConsoleApp1/Program.cs` file

### Run the issue
In the root folder

`dapr run --app-id console-logging-test --app-port 5000 -- dotnet run --project ./ConsoleApp1/ConsoleApp1.csproj`
