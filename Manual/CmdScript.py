# If you don't know what you're doing don't edit below unless you understand the code
source = "curl -o NAME https://raw.githubusercontent.com/Unturned-Datamining/Unturned-Datamining/09b5dd59b7981ff4f27ca917f31689b12fbdaec1/Assembly-CSharp/SDG.Unturned/NAME"
toReplace = "NAME"
# replaceWith is Configurable, to change what files to download
replaceWith = ["EffectSpawner.cs","CommentComponent.cs","BinaryRandomComponent.cs","LogMessengerComponent.cs","EngineCurvesComponent.cs"," LightningWeatherComponent.cs"," CustomWeatherComponent.cs"," LODGroupAdditionalData.cs","FallDamageOverride.cs","ParticleSystemCollisionAudio.cs","TemperatureTrigger.cs","Achievement.cs","Acid.cs","Barrier.cs","Rocket.cs","ImpactGrenade.cs","StickyGrenade.cs","Grenade.cs","CSteamID.cs","Carepackage.cs","CarepackageDestroy.cs","Distraction.cs","Flashbang.cs","Buoyancy.cs","LightLOD.cs","NightLight.cs","FlickeringLight.cs","BlinkingLight.cs","UnturnedAudioMixer.cs"," UndergroundWhitelistVolume.cs"," KillVolume.cs","EffectVolume.cs"," OxygenVolume.cs"," DeadzoneVolume.cs"," CullingVolume.cs"," GrassDisplacement.cs"," GraphicsSettings.cs"," DynamicWaterTransparentSortComponent.cs"," UseableEventHook.cs","NPCGlobalEventHook.cs","UseableGunEventHook.cs","UseableEventHook.cs","CustomWeatherEventHook.cs","ActivationEventHook.cs","WeatherEventHook.cs","CollisionEventHook.cs","VehicleTurretEventHook.cs","InteractableObjectBinaryStateEventHook.cs","DestroyEventHook.cs","VehicleEventHook.cs","TextChatEventHook.cs","InteractableObjectQuestEventHook.cs","CollisionTeleporter.cs","TimerEventHook.cs","ClientTextChatMessenger.cs","ServerTextChatMessenger.cs","NpcGlobalEventMessenger.cs"]
outputText = ""

for replacement in replaceWith:
    outputText += source.replace(toReplace,replacement) + "\n"
print(outputText)
# Paste `outputText` into cmd prompt to download the files from github.