# theory-works
Эта ветка предназначена для теоретической практики. 
Если нужно сделать правку - делайте форк и кидайт Pull Request

Либо же создаем отдельную ветку, базируясь от этой.
И кидаем оттуда PR.

Безмозгло не надо срать в ветку.

# Установка
1. Установить [git bash](https://git-scm.com/downloads) и [dotnet sdk](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)
2. Открыть Powershell или CMD и прописать следующие команды:
```
git clone https://github.com/DocNITE/for_college.git
cd for_college
git submodule init
git submodule update
git checkout theory-works
```
3. Писать код!

# Сборка
1. Открыть Powershell или CMD и прописать следующее:
```
dotnet build
```
или для релиза
```
dotnet build -c release
```

# В случае каких-то проблем
Создавайте `issue` и описываете проблемы. 
Могут быть проблемы на уровне компиляции проекта.
Скорее всего из-за криво собраной архитектуры.
