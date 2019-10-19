# Cosmic
A succinct and powerful command line query tool for Azure Cosmos DB

## Installation
```
dotnet tool install --global cosmic
```

## Usage
Connect to an Azure Cosmos DB account:
```
cosmic connect -n foo -c AccountEndpoint=https://****.documents.azure.com:443/;AccountKey=****==;
```

Query an Azure Cosmos DB account (where 'foo' is the name of a previously created connection):
```
cosmic query foo/db/container "SELECT * FROM c"
```

Delete documents from an Azure Cosmos DB account:
```
cosmic delete foo/db/container "SELECT * FROM c"
```

You can pipe data out to a file...
```
cosmic query foo/db/container "SELECT * FROM c" > data.json
```

...and then load data back in:
```
cosmic load foo/db/container data.json
```
