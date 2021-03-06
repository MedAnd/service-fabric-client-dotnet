# Start-SFPartitionRestart
This API will restart some or all replicas or instances of the specified partition.
## Description

This API is useful for testing failover.
                
                If used to target a stateless service partition, RestartPartitionMode must be AllReplicasOrInstances.
                
                Call the GetPartitionRestartProgress API using the same OperationId to get the progress.



## Required Parameters
#### -ServiceId

The identity of the service. This ID is typically the full name of the service without the 'fabric:' URI scheme.
                    Starting from version 6.0, hierarchical names are delimited with the "~" character.
                    For example, if the service name is "fabric:/myapp/app1/svc1", the service identity would be 
"myapp~app1~svc1" in 6.0+ and "myapp/app1/svc1" in previous versions.



#### -PartitionId

The identity of the partition.



#### -OperationId

A GUID that identifies a call of this API.  This is passed into the corresponding GetProgress API



#### -RestartPartitionMode

Describe which partitions to restart. Possible values include: 'Invalid', 'AllReplicasOrInstances', 
'OnlyActiveSecondaries'



