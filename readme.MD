
![Logo](https://vansah.com/wp-content/uploads/2022/06/512x512.png)

# Vansah C# Binder
Vansah's API can be used to integrate Vansah with various tools, automation and development frameworks including third-party applications. This .NET Binder is used for .NET automation projects with C#. Example tools would be Selenium with (.NET C#) 

##  Tools and Languages
-	C# Language
-	Visual Studio 2022
-	Jira cloud workspace with Vansah installed

## Prerequisite

* [Generate Vansah Connect Token ](https://docs.vansah.com/docs-base/generate-a-vansah-api-token-from-jira/)
* Vansah should have at least 1 Test Case to run
* [Download VansahNode.cs C# binder from Github ](https://github.com/testpointcorp/Vansah-CSharp-Binder/blob/main/VansahNode.cs)
* Selenium dependency should be installed


## Usage/Examples

### Step 1

Include VansahNode.cs into your Project directory

![image](https://github.com/testpointcorp/Vansah-CSharp-Binder/assets/95007067/c6fbd00a-d88d-4048-a5ef-c6a1312643e7)


### Step 2

Configure VansahNode.cs file and paste your vansah connect token here 
[Generate Vansah Connect Token ](https://docs.vansah.com/docs-base/generate-a-vansah-api-token-from-jira/)


![image](https://github.com/testpointcorp/Vansah-CSharp-Binder/assets/95007067/768343ee-7b5d-4117-87f4-2a160ace5c28)


### Step 3
Add your Test Case Key and the result


👋 Note : 

The Test Case must be linked to an Asset such as Jira Issue Key or TestFolder Identifier for which you want to send the Test Results.

The Test Case Key and Jira Issue Key are case sensitive.

```c#
[Test]
        public void TestCase1()
        {   
          VansahNode execute = new VansahNode();

            //Provide your Jira Issue Key
            execute.SetJIRA_ISSUE_KEY("TEST-1");
                   
            try
            {
                Assert.Pass();

                //Provide Your Test Case Key and Result 
                //0 = N/A, 1 = FAILED, 2 = PASSED, 3 = UNTESTED
                execute.AddQuickTestFromJiraIssue("TEST-C1", 2);
            }
            catch (Exception ex)
            {
                //Provide Your Test Case Key and Result 
                //0 = N/A, 1 = FAILED, 2 = PASSED, 3 = UNTESTED
                execute.AddQuickTestFromJiraIssue("TEST-C1", 1);

            }
 ```
### Step 4
Run your Tests

![image](https://github.com/testpointcorp/Vansah-CSharp-Binder/assets/95007067/5b5e8b91-0040-4c0d-b23e-56dbd2de3a29)

![image](https://github.com/testpointcorp/Vansah-CSharp-Binder/assets/95007067/bdf39c41-aa71-4e73-b2e3-1dabf277e228)



### Step 5
Check you Issue on Jira for the run

![image](https://github.com/testpointcorp/Vansah-CSharp-Binder/assets/95007067/e97a50f2-177e-4b2d-92d1-7f19504f580d)




## Available Functions

#### Add Quick Test

```c#
AddQuickTestFromJiraIssue(string testcase, int result);
AddQuickTestFromTestFolders(string testcase, int result);  
```
| Description                     |
:-------------------------------- |
|To create a test run without logging the results to each of the test steps|

#### Add Tests

```c#
//To Create a Test Run Identifier
AddTestRunFromJiraIssue(string testcase);
AddTestRunFromTestFolder(string testcase); 

//Add Test Log to each step
AddTestLog(int result, string comment, int testStepRow, bool sendScreenShot, IWebDriver driver);

//To Update the Test Log
UpdateTestLog(int result, string comment, bool sendScreenShot, IWebDriver driver);

//To Remove the Current Test Log
RemoveTestLog();

//To Remove the Current Test Run
RemoveTestRun();

```
| Description                     |
:-------------------------------- |
|Follow Above functions to add Test results to each of your Test Steps of the Test Case|

#### Add Test Properties

```c#
//To Set the TestFolder as an Asset
SetTESTFOLDERS_ID(string tESTFOLDERS_ID);

//To Set the Jira Issue as an Asset
SetJIRA_ISSUE_KEY(string jIRA_ISSUE_KEY);

//To Set the Sprint in the Test Run Properties
SetSPRINT_NAME(string SPRINT_NAME);

//To Set the Version/Release in the Test Run Properties
SetRELEASE_NAME(string RELEASE_NAME);

//To Set the Environment in the Test Run Properties
SetENVIRONMENT_NAME(string ENVIRONMENT_NAME);

```
| Description                     |
:-------------------------------- |
|Above functions are use to declare the Asset and Test Properties|


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


## Support
For questions, suggestions, or other requests, please reach out to us through our support channels: https://community.vansah.com/ to raise a ticket: https://vansahapp.atlassian.net/servicedesk/customer/portals

--

© 2023 Vansah®. All rights reserved, See license.md for details.

https://www.vansah.com
