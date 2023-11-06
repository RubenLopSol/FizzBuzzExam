**Ruben Lopez Sole**
​
# FizzBuzz RESTful API
​
This is a FizzBuzz RESTful API project implemented in C# using the .NET Framework 4.8.
It provides an API endpoint that generates a FizzBuzz series based on a starting number and a limit defined in the configuration.
​
## Features
​
- Generate a FizzBuzz series based on a provided starting number and a configured limit.
- Replace numbers divisible by 3 with `Fizz`.
- Replace numbers divisible by 5 with `Buzz`.
- Replace numbers divisible by both 3 and 5 with `FizzBuzz`.
​
## Prerequisites
​
- **Visual Studio**: Ensure that you have Visual Studio installed to work with this project.
- `C#` and .net framework `v4.8` are required to run this project.
​
### Getting Started
​
1. Clone this repository to your local machine.
2. Open the solution in Visual Studio.
​
### Build and Run
​
Build and run the project in Visual Studio to start the FizzBuzz API.
Usage
​
Clients can send POST requests to the `http:localhost:5472/FizzBuzz.svc.cs/generate` endpoint with a JSON payload containing the startNumber. The API will return the FizzBuzz series as a JSON response.
​
## API Endpoint
​
- **HTTP Method**: `POST``
- **Endpoint**: `/generate`
​
### Request :label:
​
- The API endpoint accepts a JSON request with the following structure to receive integer values for the startNumber:
​
  ```json
  {
    "startNumber": 1
  }
  ```
​
### Response :outbox_tray:
​
The API will respond with a JSON object containing the FizzBuzz series:
​
```json
{
  "series": ["1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz"]
}
```
​
### Configuration
​
To set the limit for the FizzBuzz series, you can configure the limit in the `appsettings.json`` file as follows:
​
```json
{
  "FizzBuzzLimit": 15
}
```
