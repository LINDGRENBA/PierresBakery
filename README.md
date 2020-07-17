# _Pierre's Bakery_

#### _C# Test Driven Development practice for Epicodus, 07.17.2020_

#### By _**Brittany Lindgren**_

## Description

_Have you gotten your daily serving of bread and pastries? No? Well don't worry. Now you can order both Bread and Pastries from Pierre's Bakery, a small family owned business that values community... and delicious bread._

## Specifications

| Behavior   |   Input   |  Output |  Met? (Y/N)  |
|----------|:-------------:|------:|-----------:|
| Program will create a **Bread class** | n/a | Bread(){} | Y |
| Program will create a **Pastry class** | n/a | Pastry(){} | Y |
| Program will create an **instance of Bread** with **one paramater** - NumOfLoaves | n/a | Bread(){NumOfLoaves;} | Y |
| Program will create an **instance of Pastry** with **one paramater** - NumOfPastries | n/a | Pastry(){NumOfPastries;} | Y |
| Program will **calculate total cost for bread** | 2 loaves of bread | $10 | Y |
| Program will **calculate total cost for pastry** | 1 pastry, 3 pastries, 20 pastries | $2, $5, $34 | N |
|  |  |  |  |



## Setup/Installation Requirements


  1. Follow this [link to the project repository](https://github.com/LINDGRENBA/PierresBakery) on GitHub.  
  2. Click on the "Clone or download" button to copy the project link.     
  3. If you are comfortable with the command line, you can copy the project link and clone it through your command line with the command `git clone`. Otherwise, I recommend choosing "**Download ZIP**".     
   4. Once the ZIP file has finished downloading, you can right click on the file to view the zip folder in your downloads.     
  5. Right click on the project ZIP folder that you have just downloaded and choose the option "**Copy To...**", then choose the location where you would like to save this folder.      
  6. Navigate to the final location where you have chosen to save the project folder.      
  7. To view the code itself, right click, choose **open with...** and open using a text editor such as VS Code or Atom, etc.
  8. Once you are inside of your text editor, open the terminal. If you are in VS Code for example, this can be done by clicking on `Terminal` at the top of the editor and then selecting `New Terminal`. **You can navigate to different directories in the project by typing `cd DirectoryName` to go down into specific directories or `cd ..` to go back up one directory. 
  9. Navigate into the Pierres.Tests directory by typing `cd Pierres.Tests` into your terminal and hitting enter. From inside of the Pierres.Tests directory, type the command `dotnet restore` into your terminal and hit enter. You should see object files appear. They should be greyed out. Then type the command `dotnet build` into the terminal and hit enter again. You should see a bin folder appear and it should look greyed out. To return to the root / main directory type `cd ..` into your terminal and hit `enter`.
  10. Navigate to the Pierres directory by typing `cd Pierres` in your terminal and hitting `enter`. Then type the command `dotnet build` into your terminal and hit enter. You should see files appear inside of your bin folder. The bin folder should appear greyed out. 


#### Additional Setup/Installation Notes:

* No additional code is necessary to view this project.   
* Do not alter the bin/ or obj/ directories or any of the files in them.

## Known Bugs

| Bug : Message |  Situation  | Resolved (Y/N) |  How was the issue resolved?  |
| ------- | ----- | ------ | ------- |
| Models\Bread.cs(11,7): error CS0201: Only assignment, call, increment, decrement, await, and new object expressions can be used as a statement [C:\Users\blindgren\Desktop\EPICODUS\Full Time Bootcamp\CS-and-NETCore\independent-projects\Pierres.Solution\Pierres\Pierres.csproj] | Running constructor test | Y |  Change paramater for first test to int data type  | 


## Support and contact details

_Please feel free to contact the authors through GitHub (LINDGRENBA) with any feedback, questions or concerns._

## Technologies Used

* C# 
* .NET-Core 2.2
* Visual Studio Code
* Git Version Control 
* GitHub

### License

*This site is licensed under the MIT license.*

Copyright (c) 2020 **_{Brittany Lindgren}_**