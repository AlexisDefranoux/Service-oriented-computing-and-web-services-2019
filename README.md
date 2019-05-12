# SoCWS-project
Service oriented computing and web services 2019

## Branches
- master : Velib Project
- TP-Alexis-Defranoux
- TP-Mathieu-Paillart
- TP-Corentin-Artaud

## Project choices

| Extensions | Status |
|:----------:|:------:|
| IWS        | Work in progress|
| Async      | Work in progress|
| Cache      | Done   |
| Monitoring | -      |
| Google api | Done	  |
| Gui-webForm| Done   |
| Deployment | -      |

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

- Il contiendra aussi étape après étape toutes les phases pour tester la compilation, le déploiement et le monitoring de vos projets.

1. Compilation :
```
blabl
```
2. Déploiement :
```
blablab
```
3. Monitoring : 
```

```
## Architecture diagram 

- Il contiendra aussi une présentation graphique type slides de votre architecture et des extensions traités

![](https://i.imgur.com/2pMTsWO.png)


## Work repartition

- vous devrez aussi présenter les extensions que vous avez traitées seul ou votre % d'investissement dans une extension traitée à deux.

|Extensions  | Mathieu Paillart | Corentin Artaud | Alexis Defranoux |
|:----------:|:------:|:------:|:------:|
| IWS        |        |        |        |
| Async      |        |        |        |
| Cache      |        |        |        |
| Monitoring |        |        |        |
| Google api |  	  |        |        |
| Gui-webForm|        |        |        |
| Deployment |        |        |        |
| Total      |        |        |        |

