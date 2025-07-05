rm -rf /home/hifu/git/Bastion/Bastion/bin/
dotnet restore
dotnet build
cp /home/hifu/git/Bastion/Bastion/bin/Debug/netstandard2.1/Bastion.dll /home/hifu/.local/share/com.kesomannen.gale/riskofrain2/profiles/testing/BepInEx/plugins/
cp /home/hifu/git/Bastion/Bastion/bin/Debug/netstandard2.1/Bastion.pdb /home/hifu/.local/share/com.kesomannen.gale/riskofrain2/profiles/testing/BepInEx/plugins/
cp /home/hifu/git/Bastion/BastionUnity/AssetBundles/StandaloneWindows/bastion /home/hifu/.local/share/com.kesomannen.gale/riskofrain2/profiles/testing/BepInEx/plugins/AssetBundles/