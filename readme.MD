
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

- Vansah Connect Token 
- Selenium.WebDriver
- Selenium.WebDriver.ChromeDriver
