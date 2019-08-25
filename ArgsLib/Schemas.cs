using System;
using System.Collections.Generic;
using System.Linq;

namespace ArgsLib
{
    public class Schemas
    {
        List<SchemasType> _schemasTypes = new List<SchemasType>();
        public Schemas(string schemaConfig)
        {
            schemaConfig.Split(",").ToList().ForEach(config =>
            {
                var schemaTypes = config.Split(":");
                _schemasTypes.Add(new SchemasType(schemaTypes[0], schemaTypes[1]));
            });
            
        }

        public object GetValue(string name, string strValue)
        {
            var typeName = _schemasTypes.SingleOrDefault(u => u.Flag == name)?.Type;
            switch (typeName)
            {
                case "bool":
                    return strValue == "true";
                case "int":
                    return int.TryParse(strValue, out int resultInt) == true ? resultInt : 0;
                case "string":
                    return strValue ?? string.Empty;
                default:
                    throw new NotSupportedException($"当前不支持{name}类型");
            }
        }
    }

    internal class SchemasType
    {
        public SchemasType(string name, string type)
        {
            Flag = name;
            Type = type;
        }

        public string Flag { get; private set; }
        public string Type { get; private set; }

    }
}
