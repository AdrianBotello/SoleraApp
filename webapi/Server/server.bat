@echo off

title This is the server master. Love your server master.

echo Initializing server!
taskkill /f /im mongod.exe
start /d "%ProgramFiles%\MongoDB\Server\6.0\bin" mongod.exe --dbpath %~dp06.0\data\db --logpath %~dp06.0\log\mongod.log