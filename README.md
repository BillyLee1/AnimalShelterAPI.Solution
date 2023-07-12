# _AnimalShelterAPI.Solution_

#### By _**Billy Lee**_

#### _A simple API to look up cats and dogs in an animal shelter._

## Technologies Used

* _C#_
* _.NET6_
* _MySQLWorkbench_
* _SQL Database_
* _AspNetCore.Mvc_
* _AspNetCore_
* _Linq_
* _Swagger_
* _Postman_

## Description

_A simple API to look up, add, edit, or delete cats and dogs from an animal shelter. Each entity has an ID, age, species, and name. Version 2 contains workers information. There you can also add, edit, or delete workers. Each entity also has an ID, age, role, and name._

## Setup/Installation Requirements
* _Follow the steps below_

#### Installing .NET & MySQL
* _First, install .NET 6_
* _If it is not installed, please install .NET 6 with this link (https://dotnet.microsoft.com/en-us/download/dotnet/6.0)_
* _Open the file_
* _Follow the installation intructions_
* _To confirm the the installation, on your command line in your terminal type "dotnet --version"_
* _install MySQL. Follow the instructions in here(https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql)._

#### Installing Postman
* _Use this link to install Postman https://www.postman.com/downloads/_

#### Cloning the repository and Configuring appsettings.json
* _Clone the repository_
* _Navigate to the 'Factory.Solution' directory on your computer_
* _Open it in VSCode or any text editor of your choosing_
* _ Go to the "Factory" Directory_
* _Create a new file called "appsettings.json_
* _In the appsettings.json file you will add the following code below_
* _{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=animalshelter_api;uid=[YOUR USERNAME];pwd=[YOUR PASSWORD];"
  }
}



#### To add a migration and development server:_
* _Navigate to 'AnimalShelterAPI.Solution' in your command line_
* _From there navigate to 'AnimalShelterAPI'_
* _Run the command "dotnet build"_
* _Run the command "dotnet tool install --global dotnet-ef --version 6.0.0"_
* _Run the command "dotnet add package Microsoft.EntityFrameworkCore.Design -v 6.0.0"_
* _Run the command "dotnet ef migrations add Initial"_
* _Run "dotnet ef database update" in your command line._
* _Then run the command "dotnet watch run"_


### API Documentation

 _The URLs for the local servers hosting the API are https://localhost:5000 or https://localhost:5001_

#### HTTP Request Link Structure
```
Version: Animals or Workers

GET /api/{version}
POST /api/{version}
GET /api/{version}/{id}
PUT /api/{version}/{id}
DELETE /api/{version}/{id}
```
#### Return Codes
```
GET requests should return a "200 ok" when successful.
POST requests should return a "201" when successful.
PUT and DELETE requests should return "204" when successful.
_Other codes may indicate that the request was written incorrectly. So please double check your request if that happens_
```
#### Sample Queries
https://localhost:5001/api/animals/2
https://localhost:5001/api/workers/2

#### Sample JSON Response
```
Version = animals:
{
  "animalId": 1,
  "name": "Soju",
  "species": "Cat",
  "age": 3,
}

Version = workerss:
{
  "workerId": 1,
  "name": "John",
  "species": "Vet",
  "age": 44,
}
```

### Versioning

* _There are currently two different version, 1.0 and 2.0. Animals and Workers_

* _Install dotnet add package Microsoft.AspNetCore.Mvc.Versioning_

* _On the swagger page, you may select the version you would like to use on the top right corner of the webpage._

## Known Bugs

* _No bugs currently._


## License

_Please let me know if you see any bugs within this project. You can contact me through Discord or email me at codingbillylee@gmail.com_

[Copyright](https://opensource.org/licenses/MIT) (c) _2023_ _Billy Lee_
