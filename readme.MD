<div align="center">
  <img src="https://user-images.githubusercontent.com/95007067/245728119-98d2b310-a43c-4d17-8a67-cc47d8ff9b3a.png" />
</div>

<h1 align="center" style="background-color:cornflowerblue !important;
    color: white !important;">
  Vansah C# Binder
</h1>


Vansah's API is designed to facilitate the integration of Vansah with a wide range of tools, automation, and development frameworks, including third-party applications. One such integration option is the .NET Vansah Binder, which enables automation projects using .NET and C#. For instance, a commonly used tool in this context is Selenium, which can be utilized alongside (.NET C#).

##  Tools and Languages
-	C# Language
-	Jira cloud workspace with [Vansah Test Management For Jira](https://marketplace.atlassian.com/apps/1224250/vansah-test-management-for-jira) installed


## Prerequisite

* [Generate Vansah Connect Token ](https://docs.vansah.com/docs-base/generate-a-vansah-api-token-from-jira/)
* [Atleast 1 Test Case linked to a Jira Issue to run](https://docs.vansah.com/docs-base/linking-test-cases-to-a-jira-issue/)
* [Download Vansah API-Binding for C# from Github](https://github.com/testpointcorp/vansahSeleniumCSharpDotNetDemo)
* [Selenium dependency should be installed ](https://github.com/testpointcorp/Vansah-CSharp-Binder/wiki/How-to-Install-Selenium-Dependency-in-Visual-Studio%3F)

## Usage/Examples

### Step 1

Include [VansahNode.cs](https://github.com/testpointcorp/vansahSeleniumCSharpDotNetDemo/blob/main/VansahNode.cs) into your Project directory

![image](https://user-images.githubusercontent.com/95007067/245723781-a90ce9e1-9dd4-4623-93d5-228210fa1489.png)

### Step 2

Configure VansahNode.cs file and paste your vansah connect token here 
[Generate Vansah Connect Token ](https://docs.vansah.com/docs-base/generate-a-vansah-api-token-from-jira/)


![image](https://user-images.githubusercontent.com/95007067/245725004-0ed5e90b-6930-4b9e-8fa0-e7077305b933.png)


### Step 3
Provide your Jira Issue Key, Test Case Key and the result as per the below snippet

👋 Note : 

The Test Case must be [Linked](https://docs.vansah.com/docs-base/linking-test-cases-to-a-jira-issue/) to an Asset such as Jira Issue Key or TestFolder Identifier for which you want to send the Test Results. 

```c#
[Test]
        public void TestCase1()
        {   
          VansahNode execute = new VansahNode();

            //Provide your Jira Issue Key
            execute.SetJira_Issue_Key("Test-1");
                   
            try
            {
                Assert.Pass();

                //Provide Your Test Case Key and Result 
                //n/a, failed, passed, untested
                execute.AddQuickTestFromJiraIssue("Test-C1", "passed");
            }
            catch (Exception ex)
            {
                //Provide Your Test Case Key and Result 
                //n/a, failed, passed, untested
                execute.AddQuickTestFromJiraIssue("Test-C1", "failed");

            }
        }
 ```
### Step 4
Run your Tests

![image](https://user-images.githubusercontent.com/95007067/245725721-556bd502-1704-444d-ba03-422607e5c6fa.png)

![image](https://user-images.githubusercontent.com/95007067/245726916-ebdff6b0-2a6a-410a-935a-a9c44ef7f9be.png)



### Step 5
Check your Jira instance for the issue related to the run

![image](https://user-images.githubusercontent.com/95007067/248912620-19f28df0-d48a-4779-883b-d721638dfb12.png)

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
SetTestFolders_Id(string testFolders_Id);

//To Set the Jira Issue as an Asset
SetJira_Issue_Key(string jira_Issue_Key);

//To Set the Sprint in the Test Run Properties
SetSprint_Name(string sprint_Name);

//To Set the Version/Release in the Test Run Properties
SetRelease_Name(string release_Name);

//To Set the Environment in the Test Run Properties
SetEnvironment_Name(string environment_Name);

```
| Description                     |
:-------------------------------- |
|Above functions are use to declare the Asset and Test Properties|

## Support
If you have any questions, suggestions, or other requests, please don't hesitate to contact us through our support channels. You can visit our community website at https://community.vansah.com/ to raise a ticket. Additionally, you can reach us through our customer portal at https://vansahapp.atlassian.net/servicedesk/customer/portals.

<div align="center">
  © 2023 Vansah®. All rights reserved.
</div>

