Dotnet core+ 			Xunit/NUnit -deployment stratery -
				Devops(CI)
				Azure(CD)

Q : what is azure Devops?
Q : what are the steps of XUnit in .Net Core?
Q : what is pipeline(CI/CD)?
Q : Application Architeture?

c:/> md azurewithcore
c:/azurewithcore/> md src
c:/ azurewithcore/> md text

c:/azurewithcore/src/>dotnet new webapi --name azurewithcore  
c:/azurewithcore/test/>dotnet new xunit -n corewebapiazure.Test

c:/azurewithcore/test/>dotnet new xunit -n corewebapiazure.Test

c:/azurewithcore/ dotnet new sln --name corewebapi

c:/azurewithcore/ dotnet sln add src\corewebapiazure\corewebapiazure.csproj 

c:/azurewithcore/ dotnet sln add text\corewebapiazure.Test\corewebapiazure.Test.csproj 


dotnet add test/corewebapiazure.Test/corewebapiazure.Test.csproj reference src/corewebapiazure/corewebapiazure.csproj

11-08-2023
----------
What is the Architeture of Application.
	1. Core webapi solution
	2. Unit Test solution
	3. GitHub Account (Repository is created)
    4. Devops (intigration of repository -achieving continous integration)
	5. Azure (With Devops with Github repository with Application-- continous deployment).

https://dotnetplaybook.com/build-test-and-deploy-a-rest-api-with-azure-devops/

https://github.com/spetz/asp-net-core-samples/blob/master/src/1.Options/App/Controllers/ValuesController.cs

Dotnet test ------for test commnd 

in UnitText1 (pass the worng values if test fail then pass correct value)
Like : 
Assert.Equal("Tausheem",strobj);

Three accounts needed as below:
github.com - tausheemshakil@gmail.com
dev.azure.com - tausheemshakil@gmail.com
portal.azure.com - tausheemshakil@gmail.com
Please make sure to use same email Id for all three accounts, else we wont be able to achieve CI/ CD

URL for repository :
https://github.com/tausheemshakil/DotnetCoreApp.git 

Download GitHub desktop
create new repository on GitHub

some git commnad

echo "# DotnetCoreApp" >> README.md
git init
git add .
git commit -m "first commit"
git branch -M main
git remote add origin https://github.com/tausheemshakil/DotnetCoreApp.git
git push -u origin main

16-08-2023
----------
devops has so many feature
one of many feature is "pipelne"
"pipeline"(Unit Test, integration) ia a delegation model of devops to notify to any repository to achieve callback(CI)

Why we need devops?


--------------------
now we can check Application support of CI or Not? 






  