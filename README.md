# group-project-starter
This is a simple .NET app which offers a RESTful service and a static HTML page. I'm favoriong simplicity here over good software engineering practices. I repeat: **this is not a good way to develop an API and a web page**. This two-part project is primarly about getting all of the other things around the code to work. I want you to spend as little time actually coding as possible. In fact, **you may use generative AI for as much of the C# and HTML work as you like.** 

To run this code, I recommend using VS Code. Instructions on using VS Code for C# development can be found [here](https://code.visualstudio.com/docs/languages/csharp). Once VS Code is configured, you should be able to run the solution by pressing F5. This will provide feedback in the "Debug Console" and open your browser to https://localhost:7163/. You should then be able to reach "/products" or "/home.html" directly from your browser. The browser is a good option for these two paths because they utilize an HTTP GET method for requesting data from your local server.

If you are attempting to perform an HTTP POST, PUT, or DELETE, then you will likely need a more robust tool than the browser. I asked ChatGPT for additional information about what tools you should use for more in-depth HTTP testing. It provided the following response. As a long-time software engineer, I can vouch for curl and Postman. I have used both frequently.  I cannot vouch for hopscotch, as I haven't used it. I doubt a web-based tool works well with localhost though. If you have another tool you've used in the past to test HTTP requests, you're welcome to do that.

### Option 1: **Using `curl` (Cross-platform)**
`curl` is a command-line tool available on both Windows and macOS by default (for macOS since modern versions). It's one of the easiest ways to make HTTP requests directly from the terminal or command prompt.

#### Steps:
1. **Open the Terminal/Command Prompt**:
   - On **macOS**, open **Terminal** (available by default).
   - On **Windows**, you can use **Command Prompt**, **PowerShell**, or **Windows Terminal** (modern Windows versions have `curl` pre-installed).

2. **Use the `curl` Command for a POST Request**:
   Here's a basic `POST` request example where you're sending JSON data:

   ```bash
   curl -X POST https://jsonplaceholder.typicode.com/posts \
   -H "Content-Type: application/json" \
   -d '{"title": "foo", "body": "bar", "userId": 1}'
   ```

   **Explanation**:
   - `-X POST`: Specifies that the HTTP method is `POST`.
   - `-H "Content-Type: application/json"`: Sets the content type to JSON.
   - `-d '{"key": "value"}'`: Sends the data payload in JSON format.

#### Advantages:
- **Cross-platform**: Works on both Windows and macOS without much setup.
- **Simple**: No installation required for most users.
- **Versatile**: Handles all HTTP methods (GET, POST, PUT, DELETE, etc.).

#### Teaching Tip:
- Start with an example API like `https://jsonplaceholder.typicode.com/` which is great for testing and learning.
- Show how changing the payload affects the request.

### Option 2: **Postman (GUI Tool for Windows/macOS)**
For users who may be uncomfortable with the command line, Postman is a GUI tool that allows users to easily create and test HTTP requests.

#### Steps:
1. **Download Postman**:
   - Available for both **Windows** and **macOS**: [https://www.postman.com/downloads/](https://www.postman.com/downloads/).

2. **Create a POST Request**:
   - Open Postman and click **New Request**.
   - Choose the **POST** method from the dropdown.
   - Enter the request URL, for example: `https://jsonplaceholder.typicode.com/posts`.
   - Go to the **Body** tab, select **raw**, and choose **JSON** from the dropdown.
   - Enter the JSON data you want to send, for example:
     ```json
     {
       "title": "foo",
       "body": "bar",
       "userId": 1
     }
     ```

3. **Send the Request**:
   - Click **Send**, and Postman will show the response from the server.

#### Advantages:
- **Graphical Interface**: Ideal for beginners who are not comfortable with the terminal.
- **Cross-platform**: Works on both Windows and macOS.
- **Visual Feedback**: Shows both the request and response in a user-friendly interface.

#### Teaching Tip:
- Guide users through creating requests and understanding the response (status codes, headers, body).
- Use a sample API like `https://jsonplaceholder.typicode.com/` for easy experimentation.

### Option 3: **Use an Online Tool (No Installation Needed)**
For users who don't want to install anything, there are several websites where they can perform HTTP requests directly in their browser.

#### Example: **Hoppscotch** (formerly Postwoman)
- Website: [https://hoppscotch.io/](https://hoppscotch.io/)
- Users can create and test `POST` requests directly in their browser without any setup.

#### Steps:
1. **Go to the Website**: [https://hoppscotch.io/](https://hoppscotch.io/).
2. **Set up the POST Request**:
   - Choose **POST** from the dropdown.
   - Enter the URL: `https://jsonplaceholder.typicode.com/posts`.
   - Click on the **Body** tab and choose **JSON**.
   - Enter the data:
     ```json
     {
       "title": "foo",
       "body": "bar",
       "userId": 1
     }
     ```

3. **Send the Request**:
   - Click **Send** to submit the request and see the response.

#### Advantages:
- **No installation required**: Works directly in the browser.
- **Beginner-friendly**: Minimal setup, easy to use.

#### Teaching Tip:
- Walk users through the process of crafting requests, explaining each part of the request and response.

---

### Which Option to Choose?
- **If your users are comfortable with the command line**, go with `curl` since it's fast, easy, and available by default.
- **If they prefer a graphical interface**, Postman is more user-friendly and provides good visual feedback.
- **If they don’t want to install anything**, use an online tool like Hoppscotch to get them familiar with making HTTP requests in a browser.

All three options provide an easy way to perform `POST` requests, allowing users to practice without needing complex setup.
