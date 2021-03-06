# Get-SFDeployedServicePackage
Gets the list of service packages deployed on a Service Fabric node.
## Description

Returns the information about the service packages deployed on a Service Fabric node for the given application.



## Required Parameters
#### -NodeName

The name of the node.



#### -ApplicationId

The identity of the application. This is typically the full name of the application without the 'fabric:' URI scheme.
                    Starting from version 6.0, hierarchical names are delimited with the "~" character.
                    For example, if the application name is "fabric:/myapp/app1", the application identity would be 
"myapp~app1" in 6.0+ and "myapp/app1" in previous versions.



#### -ServicePackageName

The name of the service package.



