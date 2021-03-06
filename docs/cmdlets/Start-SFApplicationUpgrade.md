# Start-SFApplicationUpgrade
Starts upgrading an application in the Service Fabric cluster.
## Description

Validates the supplied application upgrade parameters and starts upgrading the application if the parameters are valid.



## Required Parameters
#### -ApplicationId

The identity of the application. This is typically the full name of the application without the 'fabric:' URI scheme.
                    Starting from version 6.0, hierarchical names are delimited with the "~" character.
                    For example, if the application name is "fabric:/myapp/app1", the application identity would be 
"myapp~app1" in 6.0+ and "myapp/app1" in previous versions.



#### -Name

The name of the target application, including the 'fabric:' URI scheme.



#### -TargetApplicationTypeVersion

The target application type version (found in the application manifest) for the application upgrade.



#### -Parameters

List of application parameters with overridden values from their default values specified in the application manifest.



#### -UpgradeKind

The kind of upgrade out of the following possible values. Possible values include: 'Invalid', 'Rolling'



## Optional Parameters
#### -RollingUpgradeMode

The mode used to monitor health during a rolling upgrade. The values are UnmonitoredAuto, UnmonitoredManual, and 
Monitored. Possible values include: 'Invalid', 'UnmonitoredAuto', 'UnmonitoredManual', 'Monitored'



#### -UpgradeReplicaSetCheckTimeoutInSeconds

The maximum amount of time to block processing of an upgrade domain and prevent loss of availability when there are 
unexpected issues. When this timeout expires, processing of the upgrade domain will proceed regardless of availability 
loss issues. The timeout is reset at the start of each upgrade domain. Valid values are between 0 and 42949672925 
inclusive. (unsigned 32-bit integer).



#### -ForceRestart

If true, then processes are forcefully restarted during upgrade even when the code version has not changed (the 
upgrade only changes configuration or data).



#### -FailureAction

The compensating action to perform when a Monitored upgrade encounters monitoring policy or health policy violations.
                    Invalid indicates the failure action is invalid. Rollback specifies that the upgrade will start 
rolling back automatically.
                    Manual indicates that the upgrade will switch to UnmonitoredManual upgrade mode.
                    . Possible values include: 'Invalid', 'Rollback', 'Manual'



#### -HealthCheckWaitDurationInMilliseconds

The amount of time to wait after completing an upgrade domain before applying health policies. It is first interpreted 
as a string representing an ISO 8601 duration. If that fails, then it is interpreted as a number representing the 
total number of milliseconds.



#### -HealthCheckStableDurationInMilliseconds

The amount of time that the application or cluster must remain healthy before the upgrade proceeds to the next upgrade 
domain. It is first interpreted as a string representing an ISO 8601 duration. If that fails, then it is interpreted 
as a number representing the total number of milliseconds.



#### -HealthCheckRetryTimeoutInMilliseconds

The amount of time to retry health evaluation when the application or cluster is unhealthy before FailureAction is 
executed. It is first interpreted as a string representing an ISO 8601 duration. If that fails, then it is interpreted 
as a number representing the total number of milliseconds.



#### -UpgradeTimeoutInMilliseconds

The amount of time the overall upgrade has to complete before FailureAction is executed. It is first interpreted as a 
string representing an ISO 8601 duration. If that fails, then it is interpreted as a number representing the total 
number of milliseconds.



#### -UpgradeDomainTimeoutInMilliseconds

The amount of time each upgrade domain has to complete before FailureAction is executed. It is first interpreted as a 
string representing an ISO 8601 duration. If that fails, then it is interpreted as a number representing the total 
number of milliseconds.



#### -ConsiderWarningAsError

Indicates whether warnings are treated with the same severity as errors.



#### -MaxPercentUnhealthyDeployedApplications

The maximum allowed percentage of unhealthy deployed applications. Allowed values are Byte values from zero to 100.
                    The percentage represents the maximum tolerated percentage of deployed applications that can be 
unhealthy before the application is considered in error.
                    This is calculated by dividing the number of unhealthy deployed applications over the number of 
nodes where the application is currently deployed on in the cluster.
                    The computation rounds up to tolerate one failure on small numbers of nodes. Default percentage is 
zero.



#### -MaxPercentUnhealthyPartitionsPerService

The maximum allowed percentage of unhealthy partitions per service. Allowed values are Byte values from zero to 100
                    
                    The percentage represents the maximum tolerated percentage of partitions that can be unhealthy 
before the service is considered in error.
                    If the percentage is respected but there is at least one unhealthy partition, the health is 
evaluated as Warning.
                    The percentage is calculated by dividing the number of unhealthy partitions over the total number 
of partitions in the service.
                    The computation rounds up to tolerate one failure on small numbers of partitions. Default 
percentage is zero.



#### -MaxPercentUnhealthyReplicasPerPartition

The maximum allowed percentage of unhealthy replicas per partition. Allowed values are Byte values from zero to 100.
                    
                    The percentage represents the maximum tolerated percentage of replicas that can be unhealthy 
before the partition is considered in error.
                    If the percentage is respected but there is at least one unhealthy replica, the health is 
evaluated as Warning.
                    The percentage is calculated by dividing the number of unhealthy replicas over the total number of 
replicas in the partition.
                    The computation rounds up to tolerate one failure on small numbers of replicas. Default percentage 
is zero.



#### -MaxPercentUnhealthyServices

The maximum maximum allowed percentage of unhealthy services. Allowed values are Byte values from zero to 100.
                    
                    The percentage represents the maximum tolerated percentage of services that can be unhealthy 
before the application is considered in error.
                    If the percentage is respected but there is at least one unhealthy service, the health is 
evaluated as Warning.
                    This is calculated by dividing the number of unhealthy services of the specific service type over 
the total number of services of the specific service type.
                    The computation rounds up to tolerate one failure on small numbers of services. Default percentage 
is zero.



#### -ServiceTypeHealthPolicyMap

The map with service type health policy per service type name. The map is empty by default.



#### -ServerTimeout

The server timeout for performing the operation in seconds. This timeout specifies the time duration that the client 
is willing to wait for the requested operation to complete. The default value for this parameter is 60 seconds.



