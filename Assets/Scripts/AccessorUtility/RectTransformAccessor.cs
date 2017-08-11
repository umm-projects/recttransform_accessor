using UnityEngine;

namespace AccessorUtility {

    /// <summary>
    /// DI っぽく MonoBehaviour に機能を提供するためのインタフェース
    /// </summary>
    public interface IRectTransformAccessor {
    }

    /// <summary>
    /// IRectTransformAccessor の拡張クラス
    /// </summary>
    public static class RectTransformAccessorExtension {

        /// <summary>
        /// IRectTransformAccessor を実装しているクラスに `.RectTransform()` として Getter を提供する
        /// </summary>
        /// <param name="self">IRectTransformAccessor のインスタンス</param>
        /// <returns>RectTransform のインスタンス</returns>
        public static RectTransform RectTransform(this IRectTransformAccessor self) {
            // ReSharper disable once SuspiciousTypeConversion.Global
            MonoBehaviour monoBehaviour = self as MonoBehaviour;
            if (monoBehaviour == null) {
                return null;
            }
            // 未セットの場合に、GetComponent した結果をキャッシュさせる
            if (!monoBehaviour.PropertyExists<RectTransform>()) {
                RectTransform rectTransform = monoBehaviour.gameObject.GetComponent<RectTransform>();
                monoBehaviour.PropertySet(rectTransform);
            }
            return monoBehaviour.PropertyGet<RectTransform>();
        }

    }

}