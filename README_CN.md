[English](https://github.com/ENDERMANYK/Api/blob/master/README.md) | 简体中文
## Project Earth API

Project Earth 的核心API

## 它是干什么的

API处理大部分游戏功能 - 除了AR模式.

## 构建

- Git 这个库
- 用IDE打开sln
- 构建 & 运行

## 设置 Project Earth 服务器

### 获取API部分

- 获取已经编译好的文件 [Release](https://github.com/ENDERMANYK/Api/releases)或者从jackcaver的[Actions](https://github.com/jackcaver/Api/actions)中获取
- 获取数据文件[ApiData](https://github.com/jackcaver/ApiData), 将其重命名为data，并将其放置于API执行文件旁边。你同时也需要 Minecraft Earth 资源包 , 将下载下来的文件重命名为 `vanilla.zip` 并放置于 `data/resourcepacks` 文件夹下(如果不存在自己创建一个)
- 你可以从此处获取资源包 [点我](https://web.archive.org/web/20210624200250if_/https://cdn.mceserv.net/availableresourcepack/resourcepacks/dba38e59-091a-4826-b76a-a08d7de5a9e2-1301b0c257a311678123b9e7325d0d6c61db3c35).

### 设置

- API方面:
- 前往 `data/config/apiconfig.json`, 将 `"baseServerIP"` 那一行后面改为你的本地IPV4地址 示例:`"baseServerIP": "http://192.168.1.1"`
- 双击exe启动API
- 现在你需要让Minecraft Earth与API连接. 安卓设备可以使用补丁程序 [源码](https://github.com/Project-Earth-Team/PatcherApp), 你可以在这里找到编译好的文件[点我](https://ci.rtm516.co.uk/job/ProjectEarth/job/PatcherApp/job/master/lastBuild/).
- 启动补丁APP, 点击右上角的三个点, 将你在`data/config/apiconfig.json` 输入的IP输入进**Locator Server**, 示例:`http://192.168.1.1`
- 点击补丁程序中间的 **PATCH AND INSTALL**, 等待完成并安装 Project Earth应用.
- 启动Project Earth 应用, 如果一切正常你应该会下载一个更新。

### 获取CloudBurst部分

**这部分是支持AR的，如果你设备不支持AR无需配置**
- **你需要Java 8来运行CloudBurst**
- **如果你不知道如何操作，[Release](https://github.com/ENDERMANYK/Api/releases)里有已经配置好的文件，你只需要设置连接服务即可。**
- 使用此[Cloudburst](https://github.com/Project-Earth-Team/Server)分支. 你可以在这里找到编译好的文件 [点我](https://ci.rtm516.co.uk/job/ProjectEarth/job/Server/job/earth-inventory/).
- 运行一次 Cloudburst 以生成文件.
- 在plugins文件夹里, 你需要 [GenoaPlugin](https://github.com/jackcaver/GenoaPlugin), 和 [GenoaAllocatorPlugin](https://github.com/jackcaver/GenoaAllocatorPlugin). 你可以在这里找到编译好的文件 [点我](https://github.com/jackcaver/GenoaPlugin/actions/workflows/CI.yml) and [点我](https://github.com/jackcaver/GenoaAllocatorPlugin/actions/workflows/CI.yml). **注: 务必重命名 GenoaAllocatorPlugin.jar 为 ZGenoaAllocatorPlugin.jar, 否则你将会遇到Class加载问题**

### 设置

- Cloudburst方面:
- 首次运行Cloudburst.jar应该会出错, 编辑cloudburst.yml文件, 将最后一排改为:

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

- 同时将cloudburst.yml第一行地址改为API可以连接的地址。 示例:`earth-api: "192.168.1.1/1/api"`
- 在 `plugins` 文件夹中，创建 ```GenoaAllocatorPlugin``` 文件夹, 在此文件夹中，创建一个包含base64加密密钥的 `key.txt` 文件。 示例key

 ```
/g1xCS33QYGC+F2s016WXaQWT8ICnzJvdqcVltNtWljrkCyjd5Ut4tvy2d/IgNga0uniZxv/t0hELdZmvx+cdA==
```

- 同时在`GenoaAllocatorPlugin`中创建一个`ip.txt`文件，在里面输入你的本地IPV4地址, 示例:`192.168.1.1`
- 打开`server.properties` 文件, 将第九行改为 `spawn-protection=0`, 第十四行改为 `gamemode=1`, 第二十四行改为`xbox-auth=false`.
- API方面:
- 前往`data/config/apiconfig.json`, 然后在末尾添加以下内容:

```json
"multiplayerAuthKeys": {
        "你在ip.txt中输入的IP": "和key.txt文件中相同的key"
 }
```

- 启动API和Cloudburst. 如果一切正常API窗口中会显示一个服务器已连接。
- 如果你遇到问题, 按照步骤重试, 或者在QQ群:256653980交流。
