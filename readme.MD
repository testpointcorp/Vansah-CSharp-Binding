
![Logo](https://vansah.com/wp-content/uploads/2022/06/512x512.png)

# Vansah C# Binder
Vansah's API can be used to integrate Vansah with various tools, automation and development frameworks including third-party applications. This .NET Binder is used for .NET automation projects with C#. Example tools would be Selenium with (.NET C#) 

##  Tools and Languages
-	C# Language
-	Visual Studio 2022
-	Jira cloud workspace with Vansah installed

## Prerequisite

* [Generate Vansah Connect Token ](https://vansahapp.atlassian.net/wiki/spaces/VANSAH/pages/33872/Generate+a+Vansah+API+Token+From+Jira)
* Vansah should have at least 1 Test Case to run
* [Download VansahNode.cs C# binder from Github ](https://github.com/testpointcorp/Vansah-CSharp-Binder/blob/main/VansahNode.cs)
* Selenium dependency should be installed


## Usage/Examples

### Step 1

Include VansahNode.cs into your Project directory

![image](https://github.com/testpointcorp/Vansah-CSharp-Binder/assets/95007067/c6fbd00a-d88d-4048-a5ef-c6a1312643e7)


### Step 2

Configure VansahNode.cs file and paste your vansah connect token here 
![image](https://github.com/testpointcorp/Vansah-CSharp-Binder/assets/95007067/768343ee-7b5d-4117-87f4-2a160ace5c28)


### Step 3
Add your Test Case Key and the result into 
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

![image](https://github.com/testpointcorp/Vansah-CSharp-Binder/assets/95007067/bdf39c41-aa71-4e73-b2e3-1dabf277e228)

![image](https://github.com/testpointcorp/Vansah-CSharp-Binder/assets/95007067/5b5e8b91-0040-4c0d-b23e-56dbd2de3a29)

### Step 5
Check you Issue on Jira for the run

![image](https://github.com/testpointcorp/Vansah-CSharp-Binder/assets/95007067/e97a50f2-177e-4b2d-92d1-7f19504f580d)


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
