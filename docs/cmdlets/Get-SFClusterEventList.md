# Get-SFClusterEventList
Gets all Cluster-related events.
## Description

The response is list of ClusterEvent objects.



## Required Parameters
#### -StartTimeUtc

The start time of a lookup query in ISO UTC yyyy-MM-ddTHH:mm:ssZ.



#### -EndTimeUtc

The end time of a lookup query in ISO UTC yyyy-MM-ddTHH:mm:ssZ.



## Optional Parameters
#### -ServerTimeout

The server timeout for performing the operation in seconds. This timeout specifies the time duration that the client 
is willing to wait for the requested operation to complete. The default value for this parameter is 60 seconds.



#### -EventsTypesFilter

This is a comma separated string specifying the types of FabricEvents that should only be included in the response.



#### -ExcludeAnalysisEvents

This param disables the retrieval of AnalysisEvents if true is passed.



#### -SkipCorrelationLookup

This param disables the search of CorrelatedEvents information if true is passed. otherwise the CorrelationEvents get 
processed and HasCorrelatedEvents field in every FabricEvent gets populated.



