# SoCWS-project
Service oriented computing and web services 2019

## Branches
- master : Velib Project
- TP-Alexis-Defranoux
- TP-Mathieu-Paillart
- TP-Corentin-Artaud

## Project choices

| Extensions | Status | Points |
|:----------:|:------:|:------:|
| Gui-webForm| Done   | 6 |
| Async      | Done   | 3 |
| Cache      | Done   | 10 |
| Google api | Done	  | 10 |
| Deployment | Work in progress | ~~10~~ |
| Monitoring | Done | 5 |
| Total |--------- | 34 |

## Features description

- **Development :**

    - Graphical User Interface for the client (Grade Scale : 6 points). Winforms is only an old simple framework to prototype basic graphical interfaces. Here, you can rather developp Web interfaces with WebForms (close to winforms design method to easily implement dynamic and interactive asp.net web pages) or other graphical client in other plateforms.

    - Asynchronous Access : Replace all the accesses to WS (beetween Velib WS and IWS, between IWS and WS Clients) with asynchronous ones. Some indications can be find just below. (Grade Scale : 3 points)

    - Cache management Add a cache in IWS, to reduce communications between Velib WS and IWS and propose various cache management policies (Grade Scale : 10 points)

    - Functional extensions : use the google API and Velib API to plan the best way from one place to another using Velib (Grade Scale : 10 points)

- **Deployment :**
    - Of course the main interest of IWS is to be a kind of proxy in your company network to manage accesses to the external Velib WS. The natural architecture for that is to deploy IWS on a local server for virtualization for example with docker. Be careful this operation is not so simple because IWS must be a .Net Core project to deploy it on docker and unfortunately complete WCF is not supported on ASP .Net Core (only the client part in WCF !). Some indications can be find just below. (Mark Scale : 10 points)

- **Monitoring :**
    - Extend IWS with monitoring functionalities, i.e. various indicators that you can get and compute about the IWS activity. For example, the number of clients during a given period, the number of client requests during a given period, the current average delay for the IWS to response, the number of requests on WS Velib during a given period and more according to your extensions (ex. cache monitoring). Your creativity is key to find various relevant indicators mainly based on statistical methods. All this information will be accessible through a second WS attached to IWS. A specific client will be developed to access to this Monitor WS remotely. This specific client will display some of this monitor information graphically or textually using some console tools. (Mark Scale : 5 points)

## How to use ? 

1. On Visual Studio, start the log servor
2. Next the IWS
3. Then start monitoring console
4. At the end, the GUI velib

Thank to the monitoring console, you can display the log of the IWS storage on the log servor. For example :
```
5/14/2019 12:19:07 AM : GetNeerestStationand the method duration is : 00:00:00.2323227
```

## Architecture diagram 

![](https://i.imgur.com/c6nzQkb.png)


## Work repartition

|Extensions  | Mathieu Paillart | Corentin Artaud | Alexis Defranoux |
|:----------:|:------:|:------:|:------:|
| Gui-webForm| 30     |  0     |   70   |
| Async      |   0    |  50    |  50    |
| Cache      | 0      |  90    |  10    |
| Google api |  100   |    0   |   0    |
| ~~Deployment~~ |    |        |        |
| Monitoring |  33    |    33  |  33    |
| Total      |  166   |   173  |  163   |

