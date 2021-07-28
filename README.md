# GraphQL-Presentation

## How to get started:

First, to get all the example queries, download Postman and import the postman queries located at ```./Postman Requests```

### Microsoft Visual Studio C# REST API
  To get started, navigate to ```./Backend REST API/GraphQL-Presentation-REST-API/GraphQL-Presentation-REST-API.sln``` A run the .sln file.
  Make sure you have the necessary NuGet packages installed then hit the 'run' button. This should run the back-end REST API at ```https://localhost:5001```
  
  Example query:
  GET https://localhost:5001/Interns
  
### GraphQL Layer
  To get started, make sure you have NodeJS installed on your machine, this will handle dependencies.
  
  To get the server running, navigate to the directory ```./GraphQL Server``` and run the command:
  
  ```NODE_TLS_REJECT_UNAUTHORIZED="0" npm run start```
  
  The first half of the command turns off authorization, which is needed since the back-end REST API is hosted locally.
  
  From there, go to your browser and go to the URL: http://localhost:4000/ and you can execute queries.
  
  Example querys:
  
  ```
  query {
    interns {
      id
      name
      about
    }
  }
  ```
  ```
  query {
    intern(id: 1) {
      name
      age
      languages
      projects
    }
  }
  ```
