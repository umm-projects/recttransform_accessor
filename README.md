# What?

* MonoBehaviour に対して RectTransform へのアクセサ (もどき) を提供します

# Why?

* `.RectTransform` っていうプロパティを毎回書くのがめんどかったので実装しました

# Install

```shell
$ npm install github:umm-projects/recttransform_accessor.git
```

# Usage

```csharp
using UnityEngine;
// using する
using AccessorUtility;

// IRectTransformAccessor をインタフェースに追加するのがポイントです
// (RequireComponent は必須ではありません)
[RequireComponent(typeof(RectTransform))]
public class Hoge : MonoBehaviour, IRectTransformAccessor {

    public void Fuga() {
        Debug.Log(this.RectTransform().sizeDelta);
    }

}
```

# License

Copyright (c) 2017 Tetsuya Mori

Released under the MIT license, see [LICENSE.txt](LICENSE.txt)

