## Project Earth Api
Project Earth 的核心API

## 他能做什么？
核心API处理大部分游戏功能 - 几乎所有不是直接AR游戏玩法的东西都在这里完成。

## 构建
 - Git 这个库
 - 用你选择的IDE打开sln
 - 构建 & 运行

## 设置 Project Earth 服务器。

### 获取所有

- 你可以在[Release](https://github.com/ENDERMANYK/Api/releases)下载api的副本。
- The [ApiData](https://github.com/ENDERMANYK/ApiData) repo, 你还需要 Minecraft Earth 资源包文件, 重命名为`vanilla.zip`放到ApiData子文件夹`resourcepacks` 中。
- 你可以在[此处](https://web.archive.org/web/20210624200250if_/https://cdn.mceserv.net/availableresourcepack/resourcepacks/dba38e59-091a-4826-b76a-a08d7de5a9e2-1301b0c257a311678123b9e7325d0d6c61db3c35)获取资源包。

### 注意: 只有你想要玩AR游戏而不是设置服务器时才执行此操作
- 我们的[Cloudburst](https://github.com/Project-Earth-Team/Server)分支。 可以在[这里](https://ci.rtm516.co.uk/job/ProjectEarth/job/Server/job/earth-inventory/)找到，这个jar可以位于api的其他地方。
- 运行一次 Cloudburst 以生成文件。
- 在plugins文件夹, 你需要 [GenoaPlugin](https://github.com/Project-Earth-Team/GenoaPlugin), 和 [GenoaAllocatorPlugin](https://github.com/Project-Earth-Team/GenoaAllocatorPlugin). 这 CI 可以在 [这里](https://ci.rtm516.co.uk/job/ProjectEarth/job/GenoaPlugin/job/master/) 和 [这里](https://ci.rtm516.co.uk/job/ProjectEarth/job/GenoaAllocatorPlugin/job/main/)找到。 **注: 务必重命名 GenoaAllocatorPlugin.jar 为 ZGenoaAllocatorPlugin.jar, 否则你将会遇到Class加载问题** 

### 设置
- 在Api方：
- 转到`data/config/apiconfig.json`, 然后在末尾添加以下内容:
```json
"multiplayerAuthKeys": {
        "你的cloudburst 服务器 IP": "和key.txt文件中相同的key"
 }
```
- 同时更改 ```"baseServerIP"``` 为你的IPV4地址。 示例:```"baseServerIP": "http://192.168.1.1"```
- 在Cloudburst 方面：
- 在 `plugins` 文件夹中，创建 ```GenoaAllocatorPlugin``` 文件夹, 在此文件夹中，创建一个包含base64加密密钥的 `key.txt` 文件。 一个示例key：
```
/g1xCS33QYGC+F2s016WXaQWT8ICnzJvdqcVltNtWljrkCyjd5Ut4tvy2d/IgNga0uniZxv/t0hELdZmvx+cdA==
```
- 修改 cloudburst.yml 文件, 并将核心 API URL 更改为可从中获取 API 的 URL。 示例:```earth-api: "192.168.1.1/1/api"```

- 启动Api
- 启动Cloudburst. 一会后 Api 会提到一个服务器被连接。
- 如果你遇到问题, 按照步骤重试, 或者在[Discord](https://discord.gg/Zf9aYZACU4)上联系我们。
- 如果一切正常, 下一个挑战是让Minecraft Earth连接到api。如果你使用的是安卓, 你可以使用我们的 [patcher](https://github.com/Project-Earth-Team/PatcherApp), 可以在[这里](https://ci.rtm516.co.uk/job/ProjectEarth/job/PatcherApp/job/master/lastBuild/)找到CI。 如果你使用的是IOS, 唯一不用越狱的方法是使用DNS, 例如 bind9。设置这个超出了本指南的范围。
