# EntityFrameworkCoreExamples

This repository is just for me to learn and play around with the functionalities of Entity Framework (Core)

All Examples are done with MySQL instead of MSSQL
_________________________________________________________________________________________________________________________________________________________

<b>Some general things to get started</b>

NuGet Packages needed:

Microsoft.EntityFrameworkCore -> Basic Package for EF Core, installs some other Packages that it needs to work

Microsoft.EntityFrameworkCore.Tools -> Is required for the actions within the Package Manager Console like add migration etc.

Pomelo.EntityFrameworkCore.MySql -> Database provider for MySQL (not required when using MSSQL)

<b>Important:</b> Make sure that the Versions of these NuGet Packages are compatible to each other
<br><br><br>
Basic commands for the Package Manager Console:

add-migration {mirgation_name}

remove-mirgation {mirgation_name}

update-database

_________________________________________________________________________________________________________________________________________________________

<b>Projects within this Repository</b>

EF_Core_Basics 

-> Basics of Entity Framework like Adding/Removing/Changing/Selecteing Items etc.



Ef_Core_Scaffolding

-> Usually EF Core is "Code First", to do "Database First" you need something called Scaffolding. 

-> What it does, is taking existing databases/tables and genearating the files like migrations etc. we need for using them with EF Core 



EF_Core_InMemory

-> Using EF Core without an actual Database, all is stored on the Computers Memory

-> Maybe useful for Testing? :) 
