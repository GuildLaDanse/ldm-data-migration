﻿namespace LaDanse.Target.Configurations
{
    public static class MySqlBuilderTypes
    {
        public const string Guid = "CHAR(36)";
        
        public const string ForeignKey = Guid;
        
        public const string DateTime = "DATETIME";
        
        public const string Text = "TEXT";
        
        public const string LongText = "LONGTEXT";
        
        public const string UnsignedInt = "INT UNSIGNED";
        
        public const string SignedInt = "INT";
        
        public const string Enum = "TINYINT";

        public static string String(int length, bool isFixedLength = false)
        {
            if (isFixedLength)
            {
                return $"char({length})";
            }
            else
            {
                return $"varchar({length})";
            }
        }
    }
}