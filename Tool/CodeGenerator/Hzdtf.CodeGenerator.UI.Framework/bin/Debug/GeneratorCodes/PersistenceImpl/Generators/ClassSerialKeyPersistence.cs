﻿﻿using hzdtd.Model.Standard;
using Hzdtf.MySql.Standard;
using Hzdtf.Utility.Standard.Attr;
using System;
using hzdtd.Persistence.Contract.Standard;

namespace hzdtd.MySql.Standard
{
    /// <summary>
    /// 班级流水键持久化
    /// @ 黄振东
    /// </summary>
    [Inject]
    public partial class ClassSerialKeyPersistence : MySqlDapperBase<ClassSerialKeyInfo>, IClassSerialKeyPersistence
    {
        /// <summary>
        /// 表名
        /// </summary>
        public override string Table => "class_serial_key";

        /// <summary>
        /// 插入字段名称集合
        /// </summary>
        private readonly static string[] INSERT_FIELD_NAMES = new string[]
        {
            "key",
        };

        /// <summary>
        /// 更新字段名称集合
        /// </summary>
        private readonly static string[] UPDATE_FIELD_NAMES = new string[]
        {
            "key",
        };

        /// <summary>
        /// 所有字段映射集合
        /// </summary>
        private readonly static string[] FIELD_MAP_PROPS = new string[]
        {
            "id Id",
            "key Key",
        };

        /// <summary>
        /// 根据字段名获取模型的值
        /// </summary>
        /// <param name="model">模型</param>
        /// <param name="field">字段名</param>
        /// <returns>值</returns>
        protected override object GetValueByFieldName(ClassSerialKeyInfo model, string field)
        {
            switch (field)
            {
﻿                case "id":
                    return model.Id;

﻿                case "key":
                    return model.Key;

                default:
                    return null;
            }
        }

        /// <summary>
        /// 插入字段名集合
        /// </summary>
        /// <returns>插入字段名集合</returns>
        protected override string[] InsertFieldNames() => INSERT_FIELD_NAMES;

        /// <summary>
        /// 更新字段名称集合
        /// </summary>
        /// <returns>更新字段名称集合</returns>
        protected override string[] UpdateFieldNames() => UPDATE_FIELD_NAMES;

		/// <summary>
        /// 所有字段映射集合
        /// </summary>
        /// <returns>所有字段映射集合</returns>
        public override string[] AllFieldMapProps() => FIELD_MAP_PROPS;
    }
}
