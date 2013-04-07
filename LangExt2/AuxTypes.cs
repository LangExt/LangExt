using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LangExt2
{
    /// <summary>
    /// プレースホルダーとして使用することを前提とした型です。
    /// </summary>
    public enum Placeholder { }

    /// <summary>
    /// 値がないことを表すための型です。
    /// </summary>
    public enum Unit
    {
        /// <summary>
        /// Unit型の唯一の値として使用するための列挙子です。
        /// </summary>
        _
    }
}
