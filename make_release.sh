rm -rf obj
rm -rf bin

dotnet build RF5_RF4_Chara.csproj -f net6.0 -c Release

zip -j 'RF5_RF4_Chara_v1.0.0.zip' './bin/Release/net6.0/RF5_RF4_Chara.dll'
