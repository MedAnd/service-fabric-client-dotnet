# New-SFImageStoreUploadSession
Commit an image store upload session.
## Description

When all file chunks have been uploaded, the upload session needs to be committed explicitly to complete the upload. 
Image store preserves the upload session until the expiration time, which is 30 minutes after the last chunk received.



