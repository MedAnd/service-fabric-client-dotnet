# Get-SFNode
Gets the list of nodes in the Service Fabric cluster.
## Description

The response includes the name, status, ID, health, uptime, and other details about the nodes.



## Optional Parameters
#### -NodeStatusFilter

Allows filtering the nodes based on the NodeStatus. Only the nodes that are matching the specified filter value will 
be returned. The filter value can be one of the following. Possible values include: 'default', 'all', 'up', 'down', 
'enabling', 'disabling', 'disabled', 'unknown', 'removed'



#### -MaxResults

The maximum number of results to be returned as part of the paged queries. This parameter defines the upper bound on 
the number of results returned. The results returned can be less than the specified maximum results if they do not fit 
in the message as per the max message size restrictions defined in the configuration. If this parameter is zero or not 
specified, the paged query includes as many results as possible that fit in the return message.



#### -ServerTimeout

The server timeout for performing the operation in seconds. This timeout specifies the time duration that the client 
is willing to wait for the requested operation to complete. The default value for this parameter is 60 seconds.



