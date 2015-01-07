﻿
namespace Anycmd.Engine.Ac.InOuts
{
    using System;

    /// <summary>
    /// 更新静态职责分离角色集时的输入或输出参数类型。
    /// </summary>
    public class SsdSetUpdateIo : ISsdSetUpdateIo
    {
        public string Name { get; set; }

        public int SsdCard { get; set; }

        public int IsEnabled { get; set; }

        public string Description { get; set; }

        public Guid Id { get; set; }
    }
}
