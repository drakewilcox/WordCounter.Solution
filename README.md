# _WORD COUNTER_

#### _WORD COUNTER C# TESTING PROJECT_, _Mar. 3, 2020_

#### By _**Drake Wilcox**_

## Description

_This is a Friday project for week 2 of the C# unit at Epicodus that implements using MSTest in a C# Console Program that allows the user to input a word, and a sentence, and returns a count for how many instances of the word are included in the sentence._

## Specifications:

| Specification | Example Input | Example Output |
| :-------------:|:-------------:|:-------------:|
| When the user inputs nothing, the appication returns with an error . | "" | "Please Enter a Word and a Sentence" |
| When the user inputs a word and a sentence, the appication returns with the amount of times that word occurs | Word: "Mystery" Sentence: "Its all a Mystery" | Word Count: 1 |
| When the sentence contains words that include the input word, the word count does not increase | Word: "hood" Sentence: "The hooded soldier fought bravely." | Word Count: 0 |
The Application account for lower and uppercase letters | Word: "CAT" Sentence: "Damn, that's a cute cat. | Word Count: 1 |

## Setup/Installation Requirements

To use this application, follow the following instructions. 

#### Installing .NET core

##### For macOS: 

* Dowload [this .NET Core SDK](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) which will prompt a .pkg file download from Microsoft.

* Open the file. This will launch and walk you through installation steps. Use default settings. 

* Confirm the installation is successful by opening the terminal and running the command ``$ dotnet --version``. You should see something like ``2.2.105`` in response.

##### For Windows: 
* Visit the [Microsoft .NET Installation Guide](https://docs.microsoft.com/en-us/dotnet/framework/install/).

#### Installing donet script

* After installing .NET Core, run the command `` dotnet tool install -g dotnet-script `` in Terminal. 

#### Application Setup:
_Clone this repository via Terminal using the following commands:_
* ``$ cd desktop``
* ``$ git clone "repository link" ``
* ``$ cd ProjectName.Solution``

_To Run this Console Application, enter the following command in the Terminal:_

* ``$ dotnet run``

_To view the source code of this application, open the folder in the Text Editor of your choice. (Example: to open via Visual Code enter the command ``code . `` in Terminal.)_

## Technologies Used
* _Git_
* _C#_
* _.NET Core 2.2_
* _dotnet script_
* _VS Code_

### License

*This webpage is licensed under the MIT license.*

Copyright (c) 2020 **_Drake Wilcox_**