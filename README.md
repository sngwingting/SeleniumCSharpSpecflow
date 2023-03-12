# TestApp
Fun test automation side project in Selenium C# Nunit with Specflow designed to upskill and learn more
## Project description
This project uses Selenium C# NUnit with Specflow Framework which uses easy-to-read Gherkin syntax. <br />
![image](https://user-images.githubusercontent.com/127433509/224539153-8e6af5cb-c7c0-4854-b5b8-bc01f4203b38.png)

In addition to performing the tests, you can generate screenshots which are recorded on step fail, reporting using Livingdocs and uses explicit waits for all actions. <br />
A demo website which resets every hour is tested in this test project.
## Class descriptions
Hooks.cs -> used to define the code running before and after each scenario and initialises the driver object. <br />
Classes found under the Pages folder -> Defines web elements for each page and their methods (follows Page Object Model). <br />
Classes found under the Specflow folder -> Contains Specflow Feature classes written in Gherkin syntax. These feature classes map onto the classes under the Tests folder to retrieve the methods. <br />
CustomControls.cs -> Defines all actions such as clicks, asserts but can also be used for any custom component such as custom dropdowns. <br />
DriverHelper.cs -> contains the IWebdriver which is passed to all classes that need to call the Driver object. <br />
TestBase.cs -> base class that contains miscellaneous methods such as taking a screenshot when an exception is thrown. <br />
urlManager.cs -> Class defining different URLs as properties and all methods related to URL management. <br />
WaitManager.cs -> Class defining wait times and all wait-related methods. The generic wait time is 10 seconds before throwing an exception.

## Report generation
This project generates a JSON file when run (TestExecution.json) found in bin\Debug\net6.0\. <br />
A simple command can generate an HTML file from this JSON through the developer powershell: <br />
test-assembly <solution dll path> -t <TestExecution.json path>. <br />
Once HTML file is generated we can open it in a browser to view pass/fail results and a summary of all tests ran.
![image](https://user-images.githubusercontent.com/127433509/224539687-18ff83fc-2c49-4b6e-9e08-6c4c2a35705c.png)

## Screenshot generation
Screenshots are automatically generated on failed step and appear in the Screenshots folder. <br />
Naming convention used for naming the PNG screenshot is: <br />
feature_timestamp.png <br />
Example: Login_20230312103909137.png
