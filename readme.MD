
![Logo](https://vansah.com/wp-content/uploads/2022/06/512x512.png)

# Vansah C# Binder
Vansah's API can be used to integrate Vansah with various tools, automation and development frameworks including third-party applications. This .NET Binder is used for .NET automation projects with C#. Example tools would be Selenium with (.NET C#)



    Download and import the VansahNode.cs File into your Nunit Framework

   

## API Reference

#### Add Test Run

```http
  POST https://prod.vansahnode.app/api/v1/run
```
| Description                     |
:-------------------------------- |
|To create a Test Run Identifier and even this api can be used to a perform quick test |

#### Delete Test Run

```http
  POST https://prod.vansahnode.app/api/v1/run/${test_run_identifier}
```

| Description                     |
:-------------------------------- |
|To delete a test run for a test Case |

#### Add Test Log

```http
  POST https://prod.vansahnode.app/api/v1/logs
```
| Description                     |
:-------------------------------- |
|To add a test log against a test step |

#### Update Test Log

```http
  POST https://prod.vansahnode.app/api/v1/logs/${testLogIdentifier}
```

| Description                     |
:-------------------------------- |
|To update the current/existing test log of a test step|

#### Delete Test Log

```http
  POST https://prod.vansahnode.app/api/v1/logs/${testLogIdentifier}
```
| Description                     |
:-------------------------------- |
|To delete a test log of a test step|

#### Get Test Steps

```http
  GET https://prod.vansahnode.app/api/v1/testCase/list/testScripts?caseKey=${caseKey}
```

| Description                     |
:-------------------------------- |
|To get the test case script|




##  Dependencies And Plugins Used

- Selenium.WebDriver
- Selenium.WebDriver.ChromeDriver

## Authentication
Vansah current node api's expects vansahConnectToken as Authentication that can be passed in the header of a api request. 

<a href="https://community.vansah.com/posts/how-to-create-a-vansah-api-token-in-jira">Generate your own token from here</a>
<img src="![image](https://github.com/testpointcorp/Vansah-CSharp-Binder/assets/95007067/e13e0d45-a012-4abd-9618-2916a256b5f0) style="width:250px"/">

## Usage/Examples

```java
//Nunit Test Function
[Test]
public void TestWebUrl()
{
           
//Running Test Case for an Issue
testExecute.AddTestRunFromJiraIssue(testCase);
driver.Url = "https://vansah.com";
driver.Manage().Window.Maximize();
if (driver.Url.Equals("https://vansah.com/"))
    {

    //0 = N/A, 1 = FAILED, 2 = PASSED, 3 = UNTESTED
    //Add logs for each step function(ResultID, AcutalResultComment, TestStepID, screenshotTrueorFalse, chromedriver/OtherBroswerdriver);
    testExecute.AddTestLog(2, "As expected, Url is opened", 1, false, driver);

    }
    else
    {
    //0 = N/A, 1 = FAILED, 2 = PASSED, 3 = UNTESTED
    //Add logs for each step function(ResultID, AcutalResultComment, TestStepID, screenshotTrueorFalse, chromedriver/OtherBroswerdriver);
    testExecute.AddTestLog(2, "URL not Found", 1,false , driver);
    }
}
```
## Support
For questions, suggestions, or other requests, please reach out to us through our support channels: https://community.vansah.com/ to raise a ticket: https://vansahapp.atlassian.net/servicedesk/customer/portals

--

© 2022 Vansah®. All rights reserved, See license.md for details.

https://www.vansah.com
