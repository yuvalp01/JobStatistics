# JobStatistics


## Getting started:

* Clone the project
* Click on the *PandoGReact.sln* to open the solution in visual studio
* Under the PandoGReact project open the *appsettings.Development.json* and make sure you have an sql instance *.\\sqlexpress01* or just replace it to fit your local db
* From command line inside the PandoGReact folder run: **dotnet ef database update**. This will create you a local database with the name "JobsDb" and will seed sample data
* cd one level down to the *clientApp* folder and run: **npm install**
* Click the play button in Visual Studio. This will build and run both client server side and the chart will appear in its fake statistical data (more focus on the frontend)

## Check the server side 
There are actually 2 versions of the app: the default one is using fake statistical data from the db directly from the tables prefix with the "stats" schema - this will present
an almost identical chart as depicted in the spec.
The other version is using more relistic real-life data being processed into statistical data. It's a better showcase but without a lot of data the chart will look distorted.
To switch to this version all you need to do is *StartUp.cs* line and comment out **line 33** and commnent in **line 34**. This way it will use the **RawDataRepository** instead 
of **StatisticsRepository**



  
