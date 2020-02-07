using System;
using System.Linq;
using System.Dynamic;
using System.Reflection;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace VW.WebForm.Core.Model.Entities
{
    /// <summary>
    /// Base class for entities for work with web api
    /// </summary>
    [ExcludeFromCodeCoverage]
	[GeneratedCode("CrmWebApiEarlyBoundGenerator", "1.0.4.0")]
    public class Entity
    {
        /// <summary>
        /// For store entity attributes
        /// </summary>
        public Dictionary<string, object> Attributes = new Dictionary<string, object>();

		/// <summary>
        /// The formatted values
        /// </summary>
        public Dictionary<string, string> FormattedValues = new Dictionary<string, string>();
        
        /// <summary>
        /// Entity id
        /// </summary>
        public Guid Id
        {
            get => GetAttributeValue<Guid>(GetIdAttribute());
            set => SetAttributeValue(GetIdAttribute(), value);
        }

        /// <summary>
        /// Entity set name for update on web api
        /// </summary>
        public string EntitySetName => GetType().GetField(nameof(EntitySetName), BindingFlags.Public | BindingFlags.Static |
                                                                           BindingFlags.FlattenHierarchy)?.GetValue(null)?.ToString();
        /// <summary>
        /// Entity logical name
        /// </summary>
        public string EntityLogicalName => GetType().GetField(nameof(EntityLogicalName), BindingFlags.Public | BindingFlags.Static |
                                                                    BindingFlags.FlattenHierarchy)?.GetValue(null)?.ToString();


        /// <summary>
        /// Create a new entity
        /// </summary>
        public Entity() { }

        /// <summary>
        /// Create entity from expando object
        /// </summary>
        /// <param name="expandoObject"></param>
        public Entity(ExpandoObject expandoObject)
        {
		    var formattedAttributePostFix = "@OData.Community.Display.V1.FormattedValue";

            foreach (var keyValuePair in expandoObject)
            {
                var valueFieldName = keyValuePair.Key;
                var value = keyValuePair.Value;
                Type convertValueToType = null;

                if (value != null)
                {
                    if (value is string stringValue &&
                        Guid.TryParse(stringValue, out var id))
                    {
                        value = id;
                        var propertyWithEntityRefAttribute = GetPublicInstanceProperties().FirstOrDefault(x => x.GetCustomAttribute<EntityReferenceAttribute>()?.ValueField == valueFieldName);
                        if (propertyWithEntityRefAttribute != null)
                        {
                            var entityReferenceAttribute = propertyWithEntityRefAttribute.GetCustomAttribute<EntityReferenceAttribute>();
                            propertyWithEntityRefAttribute.SetValue(this, new EntityReference(entityReferenceAttribute.EntitySetName, id));
                        }
                    }
                    else if (value is ExpandoObject valueExpandoObject)
                    {
                        var propertyWithEntityAttribute = GetPublicInstanceProperties().FirstOrDefault(x => x.GetCustomAttribute<EntityAttribute>()?.AttributeName == valueFieldName);

                        if (propertyWithEntityAttribute != null)
                        {
                            value = Activator.CreateInstance(propertyWithEntityAttribute.PropertyType,
                                valueExpandoObject);
                        }
                    }
                    else
                    {
                        var propertyForField = GetPublicInstanceProperties()
                            .FirstOrDefault(x => x.Name.Equals(valueFieldName, StringComparison.CurrentCultureIgnoreCase));

                        if (propertyForField != null)
                        {
                            convertValueToType = propertyForField.PropertyType;
                        }
                    }

                    if (convertValueToType != null)
                    {
                        if (convertValueToType.IsGenericType &&
                            convertValueToType.GetGenericTypeDefinition() == typeof(Nullable<>))
                        {
                            convertValueToType = Nullable.GetUnderlyingType(convertValueToType);
                        }

                        value = Convert.ChangeType(value, convertValueToType);
                    }

                    if (valueFieldName.EndsWith(formattedAttributePostFix))
                    {
                        FormattedValues.Add(valueFieldName.Replace(formattedAttributePostFix, string.Empty), value?.ToString());
                    }
                    else
                    {
                        Attributes.Add(valueFieldName, value);
                    }
                }
            }
        }

        /// <summary>
        /// Get attribute value from dictionary by attribute name
        /// </summary>
        /// <typeparam name="T">Attribute return value type</typeparam>
        /// <param name="attributeName">Attribute name</param>
        /// <returns>Value from attributes or default value of <typeparam name="T"></typeparam></returns>
        public T GetAttributeValue<T>(string attributeName)
        {
            var keyValuePair = Attributes.FirstOrDefault(x => x.Key.Equals(attributeName, StringComparison.InvariantCultureIgnoreCase));
            return keyValuePair.Value != null ? (T)keyValuePair.Value : default(T);
        }

        /// <summary>
        /// Update attribute value in dictionary by attribute name
        /// </summary>
        /// <param name="attributeName">Attribute name</param>
        /// <param name="value">New value</param>
        public void SetAttributeValue(string attributeName, object value)
        {
            if (Attributes.ContainsKey(attributeName))
            {
                Attributes[attributeName] = value;
            }
            else
            {
                Attributes.Add(attributeName, value);
            }
        }

        /// <summary>
        /// Create a new instance of <see cref="ExpandoObject"/> from current entity
        /// </summary>
        /// <returns></returns>
        public ExpandoObject ToExpandoObject()
        {
            dynamic expando = new ExpandoObject();
            var expandoObject = expando as IDictionary<string, object>;
            foreach (var attributes in Attributes)
            {
                if (attributes.Key == GetIdAttribute())
                {
                    continue;
                }

                var value = attributes.Value;
                var key = attributes.Key;

                if (value is EntityReference entityReference)
                {
                    value = $"/{entityReference.EntitySetName}({entityReference.EntityId})";
                }
                else
                {
                    key = key.ToLower();

                    if (value is DateTime dateTimeValue)
                    {
                        var propertyForAttribute = GetPublicInstanceProperties().FirstOrDefault(x =>
                            x.Name.Equals(key, StringComparison.InvariantCultureIgnoreCase));

                        if (propertyForAttribute != null)
                        {
                            var onlyDateAttr = propertyForAttribute.GetCustomAttribute<OnlyDateAttribute>();

                            if (onlyDateAttr != null)
                            {
                                value = dateTimeValue.ToString(OnlyDateAttribute.Format);
                            }
                        }
                    }
                }

                expandoObject.Add(key, value);
            }

            return (ExpandoObject)expandoObject;
        }


        /// <summary>
        /// Gets the public instance properties.
        /// </summary>
        /// <returns></returns>
        private PropertyInfo[] GetPublicInstanceProperties()
        {
            return GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
        }

        /// <summary>
        /// Create a new <see cref="EntityReference"/> from current entity
        /// </summary>
        /// <returns></returns>
        public EntityReference ToEntityReference()
        {
            return new EntityReference(EntitySetName, Id);
        }

        /// <summary>
        /// Get current entity id attribute name
        /// </summary>
        /// <returns></returns>
        private string GetIdAttribute()
        {
            return GetType().GetField("PrimaryIdAttribute", BindingFlags.Public | BindingFlags.Static |
                                                            BindingFlags.FlattenHierarchy)?.GetValue(null)?.ToString();
        }
    }

    /// <summary>
    /// Entity reference class
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class EntityReference
    {
        /// <summary>
        /// Entity set name
        /// </summary>
        public string EntitySetName { get; set; }

        /// <summary>
        /// Entity id
        /// </summary>
        public Guid EntityId { get; set; }

        /// <summary>
        /// Create a new instance of <see cref="EntityReference"/> by entity set name and entity id
        /// </summary>
        /// <param name="entitySetName">Entity set name</param>
        /// <param name="entityId">Entity id</param>
        public EntityReference(string entitySetName, Guid entityId)
        {
            EntitySetName = entitySetName;
            EntityId = entityId;
        }
    }

    /// <summary>
    /// Entity reference attribute
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class EntityReferenceAttribute : Attribute
    {
        /// <summary>
        /// Entity set name for field
        /// </summary>
        public string EntitySetName { get; }
        /// <summary>
        /// Value field name
        /// </summary>
        public string ValueField { get; }

        /// <summary>
        /// Create a new instance by entity set name and value field
        /// </summary>
        /// <param name="entitySetName">Entity set name for field</param>
        /// <param name="valueField">Value field name</param>
        public EntityReferenceAttribute(string entitySetName, string valueField)
        {
            EntitySetName = entitySetName;
            ValueField = valueField;
        }
    }

    /// <summary>
    /// Entity attribute
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class EntityAttribute : Attribute
    {
        /// <summary>
        /// Entity logical name
        /// </summary>
        public string EntityLogicalName { get;  }

        /// <summary>
        /// Attribute name
        /// </summary>
        public string AttributeName { get; }

        /// <summary>
        /// Create a new instance of attribute
        /// </summary>
        /// <param name="entityLogicalName"></param>
        /// <param name="attributeName"></param>
        public EntityAttribute(string entityLogicalName, string attributeName)
        {
            EntityLogicalName = entityLogicalName;
            AttributeName = attributeName;
        }
    }

    /// <summary>
    /// Only date attribute
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class OnlyDateAttribute : Attribute
    {
        public const string Format = "yyyy-MM-dd";
    } 
}
