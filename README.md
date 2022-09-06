English | [简体中文](https://github.com/ENDERMANYK/Api/blob/master/README_CN.md)
## Project Earth API
The Core API for Project Earth

## What does this component do?
The core API handles the bulk of game functionality - pretty much everything that isn't direct AR gameplay is done here.

## Building
 - Git this repository
 - Open the sln in your IDE of choice
 - Build & run

## Setting up the Project Earth server infrastructure.

### Getting the API Part

- A built copy of the Api, which you can download from [Release](https://github.com/ENDERMANYK/Api/releases)
- The [ApiData](https://github.com/ENDERMANYK/ApiData) repo, you'll also need the Minecraft Earth resource pack file, renamed to `vanilla.zip` and placed in the `data/resourcepacks` folder of the ApiData repo. 
- You can procure the resourcepack from [here](https://web.archive.org/web/20210624200250if_/https://cdn.mceserv.net/availableresourcepack/resourcepacks/dba38e59-091a-4826-b76a-a08d7de5a9e2-1301b0c257a311678123b9e7325d0d6c61db3c35).

### Setting up
- On the API side:
- Go to `data/config/apiconfig.json`, change the `"baseServerIP"` to your local IPV4. Sample:`"baseServerIP": "http://192.168.1.1"`
- Start up the API
- Now you need to get Minecraft Earth to talk to your API. If you're on Android, you can utilize [the patcher](https://github.com/Project-Earth-Team/PatcherApp), The CI for this can be found [here](https://ci.rtm516.co.uk/job/ProjectEarth/job/PatcherApp/job/master/lastBuild/).
- Start the Patcher, click the three dots locate upper right corner, put the IP you write in `data/config/apiconfig.json` in **Locator Server**, Sample:`http://192.168.1.1`
- Click **PATCH AND INSTALL** in the Patcher, wait it done and install the Project Earth APP.
- Start the Project Earth APP, if everything works fine you now should download a update.

### Getting the CloudBurst Part
**Only do this if you want play AR game instead setup a server.**
- **You need Java 8 to run the CloudBurst.**
- **You can also skip this part if you download the preset version from [Release](https://github.com/ENDERMANYK/Api/releases).**
- Our fork of [Cloudburst](https://github.com/Project-Earth-Team/Server). Builds of this can be found [here](https://ci.rtm516.co.uk/job/ProjectEarth/job/Server/job/earth-inventory/). This jar can be located elsewhere from the API things.
- Run Cloudburst once to generate the file structure.
- In the plugins folder, you'll need [GenoaPlugin](https://github.com/jackcaver/GenoaPlugin), and [GenoaAllocatorPlugin](https://github.com/jackcaver/GenoaAllocatorPlugin). The CI for this can be found [here](https://github.com/jackcaver/GenoaPlugin/actions/workflows/CI.yml) and [here](https://github.com/jackcaver/GenoaAllocatorPlugin/actions/workflows/CI.yml). **Note: make sure to rename your GenoaAllocatorPlugin.jar to ZGenoaAllocatorPlugin.jar, or you will run into issues with class loading** 
### Setting up
- On the cloudburst side:
- You should get error when you run the Cloudburst.jar, edit the cloudburst.yml file, change the last part to:
```
# These settings will override the generator set in server.properties and allows loading multiple levels
worlds:
  world:
    generator: genoa:void
    options: overworld
  nether:
    generator: genoa:void
    options: nether
```
- Also in the cloudburst.yml file, change the core API url to the url your API will be accessible from. Sample:`earth-api: "192.168.1.1/1/api"`
- Within the `plugins` folder, create a `GenoaAllocatorPlugin` folder, and in there, make a `key.txt` file containing a base64 encryption key. An example key is
 ```
/g1xCS33QYGC+F2s016WXaQWT8ICnzJvdqcVltNtWljrkCyjd5Ut4tvy2d/IgNga0uniZxv/t0hELdZmvx+cdA==
```
- Also in the `GenoaAllocatorPlugin` folder, make a `ip.txt` file containing your local IPV4, Sample:`192.168.1.1`.
- Open the `server.properties` file, change the line 9 to `spawn-protection=0`, line 14 to `gamemode=1`, line 24 to `xbox-auth=false`.
- On the API side:
- Go to `data/config/apiconfig.json`, and add the following at the end of file:
```json
"multiplayerAuthKeys": {
        "The IP YOU PUT IN ip.txt": "the same key you put in key.txt"
 }
```
- Start up the API and cloudburst. After a short while the API should mention a server being connected.
- If you run into issues, retrace your steps, or [contact us on discord](https://discord.gg/Zf9aYZACU4)
