# Get-SFBackupsFromBackupLocation
Gets the list of backups available for the specified backed up entity at the specified backup location.
## Description

Gets the list of backups available for the specified backed up entity (Application, Service or Partition) at the 
specified backup location (FileShare or Azure Blob Storage).



## Required Parameters
#### -ConnectionString

The connection string to connect to the Azure blob store.



#### -ContainerName

The name of the container in the blob store to store and enumerate backups from.



#### -Path

UNC path of the file share where to store or enumerate backups from.



## Optional Parameters
#### -StartDateTimeFilter

Specifies the start date time in ISO8601 from which to enumerate backups. If not specified, backups are enumerated 
from the beginning.



#### -EndDateTimeFilter

Specifies the end date time in ISO8601 till which to enumerate backups. If not specified, backups are enumerated till 
the end.



#### -Latest

If specified as true, gets the most recent backup (within the specified time range) for every partition under the 
specified backup entity.



#### -FriendlyName

Friendly name for this backup storage.



#### -PrimaryUserName

Primary user name to access the file share.



#### -PrimaryPassword

Primary password to access the share location.



#### -SecondaryUserName

Secondary user name to access the file share.



#### -SecondaryPassword

Secondary password to access the share location



#### -ApplicationName

The name of the application, including the 'fabric:' URI scheme.



#### -ServiceName

The full name of the service with 'fabric:' URI scheme.



#### -PartitionId

The partition ID indentifying the partition.



#### -ServerTimeout

The server timeout for performing the operation in seconds. This timeout specifies the time duration that the client 
is willing to wait for the requested operation to complete. The default value for this parameter is 60 seconds.



#### -MaxResults

The maximum number of results to be returned as part of the paged queries. This parameter defines the upper bound on 
the number of results returned. The results returned can be less than the specified maximum results if they do not fit 
in the message as per the max message size restrictions defined in the configuration. If this parameter is zero or not 
specified, the paged query includes as many results as possible that fit in the return message.



