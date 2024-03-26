# VansahNode Integration for .NET (C#)

## Overview
The `VansahNode` class provides a .NET interface to interact with the Vansah API, enabling automated testing workflows and integration with Vansah's test management capabilities. This class allows for the creation, updating, and deletion of test runs and logs, including support for uploading screenshots associated with test steps.

## Features
- Set custom API URL and tokens for authentication.
- Add, update, and remove test runs and logs.
- Support for JIRA issue and test folder associations.
- Automated screenshot uploads for test logs.

## Prerequisites
- .NET compatible development environment.
- Newtonsoft.Json package for JSON handling.
- An active Vansah account with API access.

## Installation
1. Ensure the Newtonsoft.Json package is installed in your project.
2. Include the `VansahNode.cs` file in your project directory.

## Usage

### Configuration
Before sending requests to Vansah API, configure the `VansahNode` with your API token and URL (if not using the default).

```csharp
VansahNode vansahNode = new VansahNode();
vansahNode.SetVansahToken = "Your Token Here";
// Optional: Set a custom API URL
vansahNode.SetVansahURL = "https://custom.vansahnode.app";
```

### Creating a Test Run
You can create a test run associated with a JIRA issue or a test folder.

```csharp
// For a JIRA issue
vansahNode.AddTestRunFromJiraIssue("JIRA_ISSUE_KEY");

// For a test folder
vansahNode.AddTestRunFromTestFolder("TEST_FOLDER_ID");

```

### Adding a Test Log
Add a test log to a run, optionally including a screenshot.

```csharp
// Without screenshot
vansahNode.AddTestLog(result, "Comment about the result", testStepRow);

// With screenshot
vansahNode.AddTestLog(result, "Comment about the result", testStepRow, @"path\to\screenshot.png");

```

### Updating and Removing Logs/Runs
You can update or remove test logs and runs using their respective methods.

```csharp
// Update a test log
vansahNode.UpdateTestLog(result, "Updated comment");

// Remove a test log
vansahNode.RemoveTestLog();

// Remove a test run
vansahNode.RemoveTestRun();
```

## Developed By

[Vansah](https://vansah.com/)




