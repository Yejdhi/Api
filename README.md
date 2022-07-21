## Project Earth Api
Project Earth 的核心API

## 这个组件有什么作用？
核心 API 处理大部分游戏功能 - 几乎所有不是直接 AR 游戏的东西都在这里完成。

## 编译
 - 拉取这个仓库
 - 在您选择的 IDE 中打开 sln
 - 编译和运行

## 设置 Project Earth 服务器。

### 获取所有文件

- Api 的编译副本，您可以从 [Release](https://github.com/ENDERMANYK/Api/releases) 下载
- [ApiData](https://github.com/ENDERMANYK/ApiData) 存储库，您还需要 Minecraft Earth 资源包文件，重命名为 `vanilla.zip` 并放置在 ApiData 存储库的 `resourcepacks` 子文件夹中。
- 您可以从 [这里](https://web.archive.org/web/20210624200250if_/https://cdn.mceserv.net/availableresourcepack/resourcepacks/dba38e59-091a-4826-b76a-a08d7de5a9e2-1301b0c257a311678123b9e7325d0d6c61db3c35) 获取资源包。

### 注意：仅当您想玩 AR 游戏而不是设置服务器时才这样做。
- 我们的 [Cloudburst](https://github.com/Project-Earth-Team/Server) 分支。 可以在 [这里](https://ci.rtm516.co.uk/job/ProjectEarth/job/Server/job/earth-inventory/) 找到它的编译。 这个 jar 可以位于 Api 的其他地方。
- 运行 Cloudburst 一次以生成文件。
- 在 plugins 文件夹中，您需要 [GenoaPlugin](https://github.com/Project-Earth-Team/GenoaPlugin) 和 [GenoaAllocatorPlugin](https://github.com/Project-Earth-Team/GenoaAllocatorPlugin)。 可以在 [此处](https://ci.rtm516.co.uk/job/ProjectEarth/job/GenoaPlugin/job/master/) 和 [此处](https://ci.rtm516.co.uk/job/ProjectEarth/job/GenoaAllocatorPlugin/job/main/) 找到用于此的编译。 注意：确保将 GenoaAllocatorPlugin.jar 重命名为 ZGenoaAllocatorPlugin.jar，否则会遇到class加载问题

### 配置
- 在 Api 处
- 打开 data/config/apiconfig.json，并在文件末尾添加以下内容：
```
"multiplayerAuthKeys": {
        "Your cloudburst server IP here": "the same key you put in key.txt earlier" 
}
```
- 还将 `"baseServerIP"` 更改为您的本地 IPV4。 示例：`"baseServerIP": "http://192.168.1.1"`
- 在 cloudburst 处
- 在 plugins 文件夹中，创建一个 GenoaAllocatorPlugin 文件夹，并在其中创建一个包含 base64 加密密钥的 key.txt 文件。 一个示例密钥是
```/g1xCS33QYGC+F2s016WXaQWT8ICnzJvdqcVltNtWljrkCyjd5Ut4tvy2d/IgNga0uniZxv/t0hELdZmvx+cdA==```
- 编辑 cloudburst.yml 文件，并将核心 api url 更改为您的 Api 可以访问的 url。 示例：`earth-api: "192.168.1.1/1/api"`
- 启动 Api
- 启动 cloudburst。 片刻之后，Api 应该会提到正在连接的服务器。
- 如果您遇到问题，请重试您的步骤，或 [通过 discord 联系我们](https://discord.gg/Zf9aYZACU4)
- 如果一切正常，您的下一个操作是让 Minecraft Earth 与您的 Api 对话。 如果您使用的是 Android，则可以使用 [我们的补丁程序](https://github.com/Project-Earth-Team/PatcherApp)，可以在 [此处](https://ci.rtm516.co.uk/job/ProjectEarth/job/PatcherApp/job/master/lastBuild/) 找到用于此的编译。 如果您在 IOS 上，则无需越狱即可完成此操作的唯一方法是使用 DNS，例如 bind9。 对此的设置超出了本指南的范围。
