# Steps to install in Azure

## Login to cli in azure
az login

## deploy to a subscription with Azure CLI
possibly: cd to Infrastructure first

az deployment sub create --location eastus --template-file CraftedSpecially.bicep