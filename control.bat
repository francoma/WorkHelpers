@echo off
setlocal
set v_usr=*****
set v_pass=*****
set v_usrDB=*****
set v_passDB=*****
set v_DB=*****

cls

sqlplus -s %v_usrDB%@%v_DB%/%v_passDB% @c:\Temp\unix\CTMs\genJson.sql > c:\Temp\unix\CTMs\readjson.js
if errorlevel == 1 goto :ErrorSQL

findstr /V /R "^ERROR:$" c:\Temp\unix\CTMs\readjson.js > c:\Temp\unix\CTMs\temp_readjson.js
findstr /V /R "^ORA-28002" c:\Temp\unix\CTMs\temp_readjson.js > c:\Temp\unix\CTMs\readjson.js
del c:\Temp\unix\CTMs\temp_readjson.js

c:\pscp -pw %v_pass% -l %v_usr% c:\Temp\unix\CTMs\readjson.js 10.7.15.169:/tmp/temp  2> c:\Temp\unix\CTMs\salida.log
if errorlevel == 1 goto :ErrorComando

c:\plink -v -ssh -pw %v_pass% -l %v_usr% 10.7.15.169 chmod 777 /tmp/temp/readjson.js 2> c:\Temp\unix\CTMs\salida.log
if errorlevel == 1 goto :ErrorComando

c:\plink.exe -batch -pw %v_pass% %v_usr%@10.7.15.169 ./run.sh 2> c:\Temp\unix\CTMs\salida.log
if errorlevel == 1 goto :ErrorComando

pause
goto :EOF

:ErrorComando
echo Hubo un error al dar permisos a la carpeta donde se copia el archivo. Verifique el password del usuario y pruebe nuevamente
pause
goto :EOF

:ErrorSQL
echo Ocurrio un error al ejecutar el proceso
pause
goto :EOF

