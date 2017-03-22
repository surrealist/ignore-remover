# ignore-remover
Delete ignored files and folders recursively.

## Screen captures

Recursively delete 8 folders

![image](https://cloud.githubusercontent.com/assets/344784/24207601/de9ad4ac-0f53-11e7-9214-ff38da2a2a4b.png)


In one big folder that contains a huge number of projects.
I can save a lot of space.

![2017-03-22_21-46-05](https://cloud.githubusercontent.com/assets/344784/24207128/a880410a-0f52-11e7-9bbc-4b8b86c18fd8.png)

## How to use
After clone this repository to your machine.
```
> dotnet restore
> dotnet build

# to delete ignore folders starts from current folder
> dotnet run

# specify starting path to delete ignore folders
> dotnet run "c:\a\path" 
```

## Becareful!
This app delete your folders and files permanently (not store in recycled bin / cannot undo).
**Use it at your on risk**.

## Contributors needed
Please add and check issues and grab some to work on it. Thanks.