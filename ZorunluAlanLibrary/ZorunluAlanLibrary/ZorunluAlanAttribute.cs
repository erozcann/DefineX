using System;
using System.Reflection;

namespace ZorunluAlanLibrary
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true, Inherited = true)]
    public class ZorunluAlanAttribute : Attribute
    {
        public static bool Dogrula(object dogrulanacakEntity)
        {
            Type dogrulanacakTur = dogrulanacakEntity.GetType();
            PropertyInfo[] properties = dogrulanacakTur.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (PropertyInfo property in properties)
            {
                object[] attributes = property.GetCustomAttributes(typeof(ZorunluAlanAttribute), true);
                if (attributes.Length > 0)
                {
                    object value = property.GetValue(dogrulanacakEntity);
                    if (value == null || string.IsNullOrEmpty(value.ToString()))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
