namespace ExoScan.Helpers
{
    /// <summary>
    /// Generic base class for enum to string conversion
    /// </summary>
    public abstract class EnumHelper<TEnum> where TEnum : struct, Enum
    {
        protected readonly Dictionary<string, TEnum> StringToEnum;
        protected readonly Dictionary<TEnum, string> EnumToString;

        protected EnumHelper(Dictionary<string, TEnum> mappings)
        {
            StringToEnum = mappings;
            EnumToString = mappings.ToDictionary(x => x.Value, x => x.Key);
        }

        /// <summary>
        /// Convert string to enum
        /// </summary>
        public virtual TEnum GetEnumValue(string value, TEnum defaultValue)
        {
            if (string.IsNullOrEmpty(value))
                return defaultValue;

            return StringToEnum.TryGetValue(value, out var result) ? result : defaultValue;
        }

        public virtual TEnum GetEnumValue(string value)
        {
            if (string.IsNullOrEmpty(value))
                return default;

            return StringToEnum.TryGetValue(value, out var result) ? result : default;
        }

        /// <summary>
        /// Convert enum to string
        /// </summary>
        public virtual string ToString(TEnum value)
        {
            return EnumToString.TryGetValue(value, out var result) ? result : string.Empty;
        }

        /// <summary>
        /// Convert multiple strings to combined enum (for Flags enums)
        /// </summary>
        public virtual TEnum GetCombinedEnumValue(params string[] values)
        {
            if (!typeof(TEnum).IsDefined(typeof(FlagsAttribute), false))
                throw new InvalidOperationException($"{typeof(TEnum).Name} is not a Flags enum");

            int combined = 0;
            foreach (var value in values)
            {
                var enumValue = GetEnumValue(value);
                combined |= Convert.ToInt32(enumValue);
            }
            return (TEnum)Enum.ToObject(typeof(TEnum), combined);
        }

        /// <summary>
        /// Convert combined enum to list of strings (for Flags enums)
        /// </summary>
        public virtual List<string> ToStringList(TEnum value)
        {
            if (!typeof(TEnum).IsDefined(typeof(FlagsAttribute), false))
                return new List<string> { ToString(value) };

            var result = new List<string>();
            int intValue = Convert.ToInt32(value);

            foreach (var kvp in EnumToString)
            {
                int enumIntValue = Convert.ToInt32(kvp.Key);
                if (enumIntValue != 0 && (intValue & enumIntValue) == enumIntValue)
                {
                    result.Add(kvp.Value);
                }
            }

            return result;
        }
    }

}

