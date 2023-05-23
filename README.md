# Test Netzsch
To run the test please follow these steps:

- Run Server
    - cd .\NetschTest\src\NetzschTestServer\
    - dotnet restore
    - dotnet run
- Run Command Client
    - cd .\NetschTest\src\NetzschClientConsole\
    - dotnet restore
    - dotnet run
- Run Web Client
    - cd .\NetschTest\src\NetzschClientWeb\
    - dotnet restore
    - npm i @microsoft/signalr @types/node
    - dotnet run