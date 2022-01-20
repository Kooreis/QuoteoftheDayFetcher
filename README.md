# Python Documentation

# Python Quote Fetcher

This Python script fetches a quote of the day from a REST API and prints it to the console. The quote is fetched from the following API: `https://quotes.rest/qod`.

## Libraries Used

### Requests

[Requests](https://docs.python-requests.org/en/latest/) is a Python library used for making various types of HTTP requests like GET and POST. In this script, it is used to make a GET request to the quote API.

### JSON

[JSON](https://docs.python.org/3/library/json.html) (JavaScript Object Notation) is a standard text-based format for representing structured data based on JavaScript object syntax. It is commonly used for transmitting data in web applications. In this script, it is used to parse the JSON response from the quote API.

## Function Explanation

### fetch_quote()

This function fetches the quote of the day from the API. It makes a GET request to the API using the `requests.get()` function and parses the JSON response using `json.loads()`. It then extracts the quote and the author from the parsed JSON data and returns them in a formatted string.

## Execution

To execute the script, simply run the following command:

```bash
python fetch_quote.py
```

This will print the quote of the day to the console.

---

# C# Documentation

# CSharp Quote of the Day Script

This script is written in C# and its main function is to fetch a quote of the day from an online API and display it in the console along with the author of the quote.

## Libraries Used

The script uses the following libraries:

- **System**: This is a fundamental library in C# that provides base functionalities such as Console for input/output operations.

- **System.Net.Http**: This library provides a modern, programmable interface to HTTP services. In this script, it is used to send a GET request to the API and receive the response.

- **System.Threading.Tasks**: This library provides types that simplify the work of writing concurrent and asynchronous code. The main feature of this library used in this script is the Task class, which represents a single operation that does not return a value and that usually executes asynchronously.

- **Newtonsoft.Json.Linq**: This library is used for parsing JSON. In this script, it is used to parse the JSON response from the API into a JObject, which can then be used to extract the quote and author.

## How the Script Works

The script starts by creating an instance of HttpClient, which is used to send HTTP requests and receive HTTP responses from a URI identified by the API.

The Main method is marked as async because it contains an await expression. The await expression suspends execution of the method until the awaited task completes.

The script then sends a GET request to the API and waits for the response. If the response indicates success, it reads the response body as a string.

The response body is then parsed into a JObject using the JObject.Parse method. The quote and author are extracted from the JObject and displayed in the console.

If an HttpRequestException is caught, the script displays an error message in the console. This exception is thrown when an error occurs while sending the HTTP request or receiving the HTTP response.

## Usage

To run the script, you need to have .NET Core installed on your machine. You can then use the `dotnet run` command in the terminal to execute the script.

---

# Java Documentation

# QuoteFetcher

This Java script fetches a random quote from the Quotable API and prints it to the console. 

## How it works

The script sends a GET request to the Quotable API and reads the response. If the HTTP response code is not 200 (indicating a successful request), it throws a RuntimeException. If the request is successful, it reads the response line by line and prints each line to the console.

## Imported Libraries

- `java.io.BufferedReader`: This class reads text from a character-input stream, buffering characters so as to provide for the efficient reading of characters, arrays, and lines.

- `java.io.InputStreamReader`: This class is a bridge from byte streams to character streams. It reads bytes and decodes them into characters using a specified charset.

- `java.net.HttpURLConnection`: A URLConnection with support for HTTP-specific features. This class is used to make a connection to the API and send a GET request.

- `java.net.URL`: A class that represents a Uniform Resource Locator, a pointer to a "resource" on the World Wide Web.

- `java.nio.charset.StandardCharsets`: This class defines constants for the standard charsets. This script uses the UTF-8 charset to decode the API response.

## Usage

To run the script, simply execute the `main` method in the `QuoteFetcher` class. The script does not require any arguments.

---
