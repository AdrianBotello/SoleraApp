@echo off

title This is the server master. Love your server master.
echo Initializing server!
echo %ProgramFiles%
echo %ProgramFiles%\MongoDB\Server\6.0\bin
start /d "%ProgramFiles%\MongoDB\Server\6.0\bin" mongod.exe --dbpath %~dp06.0\data\db --logpath %~dp06.0\log\mongod.log