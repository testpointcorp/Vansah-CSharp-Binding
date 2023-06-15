<div align="center">
  <img src="https://user-images.githubusercontent.com/95007067/245728119-98d2b310-a43c-4d17-8a67-cc47d8ff9b3a.png" />
</div>

# Vansah C# Binder
Vansah's API can be used to integrate Vansah with various tools, automation and development frameworks including third-party applications. This .NET Binder is used for .NET automation projects with C#. Example tools would be Selenium with (.NET C#) 

##  Tools and Languages
-	C# Language
-	Jira cloud workspace with [Vansah Test Management For Jira](https://marketplace.atlassian.com/apps/1224250/vansah-test-management-for-jira) installed

## Prerequisite

* [Generate Vansah Connect Token ](https://docs.vansah.com/docs-base/generate-a-vansah-api-token-from-jira/)
* [Atleast 1 Test Case linked to a Jira Issue to run](https://docs.vansah.com/docs-base/linking-test-cases-to-a-jira-issue/)
* [Download VansahNode.cs C# binder from Github ](https://github.com/testpointcorp/Vansah-CSharp-Binder/blob/main/VansahNode.cs)
* Selenium dependency should be installed


## Usage/Examples

### Step 1

Include [VansahNode.cs](https://github.com/testpointcorp/Vansah-CSharp-Binder/blob/main/VansahNode.cs) into your Project directory

![image](https://user-images.githubusercontent.com/95007067/245723781-a90ce9e1-9dd4-4623-93d5-228210fa1489.png)



### Step 2

Configure VansahNode.cs file and paste your vansah connect token here 
[Generate Vansah Connect Token ](https://docs.vansah.com/docs-base/generate-a-vansah-api-token-from-jira/)


![image](https://user-images.githubusercontent.com/95007067/245725004-0ed5e90b-6930-4b9e-8fa0-e7077305b933.png)


### Step 3
Add your Test Case Key and the result


👋 Note : 

The Test Case must be [Linked](https://docs.vansah.com/docs-base/linking-test-cases-to-a-jira-issue/) to an Asset such as Jira Issue Key or TestFolder Identifier for which you want to send the Test Results. 

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
                //N/A, FAILED, PASSED, UNTESTED
                execute.AddQuickTestFromJiraIssue("TEST-C1", "PASSED");
            }
            catch (Exception ex)
            {
                //Provide Your Test Case Key and Result 
                //N/A, FAILED, PASSED, UNTESTED
                execute.AddQuickTestFromJiraIssue("TEST-C1", "FAILED");

            }
        }
 ```
### Step 4
Run your Tests

![image](https://user-images.githubusercontent.com/95007067/245725721-556bd502-1704-444d-ba03-422607e5c6fa.png)

![image](https://user-images.githubusercontent.com/95007067/245726916-ebdff6b0-2a6a-410a-935a-a9c44ef7f9be.png)



### Step 5
Check you Issue on Jira for the run

![image](https://user-images.githubusercontent.com/95007067/245727514-8b77246f-d9d1-4db1-843b-c36dbd99d028.png)




## Available Functions

#### Add Quick Test

```c#
AddQuickTestFromJiraIssue(string testCase, string result);
AddQuickTestFromTestFolders(string testCase, string result);  
```
| Description                     |
:-------------------------------- |
|To create a test run without logging the results to each of the test steps|

#### Add Tests

```c#
//To Create a Test Run Identifier
AddTestRunFromJiraIssue(string testCase);
AddTestRunFromTestFolder(string testCase); 

//Add Test Log to each step
AddTestLog(string result, string comment, int testStepRow, bool sendScreenShot, IWebDriver driver);

//To Update the Test Log
UpdateTestLog(string result, string comment, bool sendScreenShot, IWebDriver driver);

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
SetTESTFOLDERS_ID(string testFolders_Id);

//To Set the Jira Issue as an Asset
SetJIRA_ISSUE_KEY(string jira_Issue_Key);

//To Set the Sprint in the Test Run Properties
SetSPRINT_NAME(string sprint_Name);

//To Set the Version/Release in the Test Run Properties
SetRELEASE_NAME(string release_Name);

//To Set the Environment in the Test Run Properties
SetENVIRONMENT_NAME(string environment_Name);

```
| Description                     |
:-------------------------------- |
|Above functions are use to declare the Asset and Test Properties|


## API Reference

### Refer to Vansah API Docs  -> [Vansah API Docs](https://apidoc.vansah.com/)

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
