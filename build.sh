#!/bin/bash
# Build and run pipeline for WindowsFormsApp1 using LocalAgent (run from parent repo root)

dotnet run --project ../LocalAgent/LocalAgent.csproj -- ConsoleApp1/pipeline.yml
dotnet run --project ../LocalAgent/LocalAgent.csproj -- WebApplication1/pipeline.yml

# Don'r run this in linux, it will fail because WindowsFormsApp1 is a windows forms app. This is just an example of how to run the pipeline for a windows forms app.
# dotnet run --project ../LocalAgent/LocalAgent.csproj -- WindowsFormsApp1 pipeline.yml

