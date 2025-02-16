## **HotCocoChinook**

A learning project I'm making to practice C# using C# 13, .net 9 (SDK 9) Hot Chocolate 14 (GraphQL) and latest postgres docker.

## **Introduction**

Using GraphQL as the middle ware between database and the consuming user. Learning how to better program, develop, and plan out larger projects in C#.

## **Installation**

To install Project Title, follow these steps:

1. Clone the repository: **`git clone https://github.com/kittytree/HotCocoChinook.git`**
2. Install Postgres Docker: https://hub.docker.com/_/postgres/ following the docker gudie for your OS or IDE. I used https://wiki.archlinux.org/title/Docker along with https://www.jetbrains.com/help/idea/running-a-dbms-image.html. I don't suggest running as no auth and Randomly publish all exposed ports, use auth and properly set ports as needed. Only tcp 5421 needs to be bound to a random port preferabbly in the 10k range and bind to localhost or correct IP
3. Build the project: Run the docker container and feed it the file **`HotCocoChinook/Chinook_PostgreSql.sql`**.
4. Start the project: **`dotnet run --no-hot-reload`**
5. Navigate to the URL as described in launch **`HotCocoChinook/Properties/launchsettings.json`**

## **License**

Project Title is released under the GNU License. See the **[LICENSE](https://github.com/kittytree/HotCocoChinook/blob/master/LICENSE)** file for details.

## **Authors and Acknowledgment**

- .SQL is from https://github.com/lerocha/chinook-database/tree/master
