using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace MSProjectReadXml
{
    public class ReadXmlProject
    {
        private XDocument _xml;
        private Project _projectObject;
        private List<string> _extendedAttributesNames;

        public ReadXmlProject()
        {
            this._projectObject = new Project();
            this._extendedAttributesNames = new List<string>();
        }

        public void LoadFile(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentNullException(nameof(filePath));

            if (!File.Exists(filePath))
                throw new ArgumentNullException(nameof(filePath));

            try
            {
                this._xml = XDocument.Load(filePath);
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }

        public Project Deserialize()
        {
            try
            {
                XNamespace xNamespace = this._xml.Root.GetDefaultNamespace();
                XmlSerializer serializer = new XmlSerializer(typeof(Project), xNamespace.NamespaceName);
                this._projectObject = serializer.Deserialize(this._xml.CreateReader()) as Project;
                this.MergeExtendedAttributes();
                return this._projectObject;
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }

        private void MergeExtendedAttributes()
        {
            this._projectObject
                .Tasks
                .Where(t => t.ExtendedAttribute.Any()).ToList()
                .ForEach((task) =>
                {
                    task.ExtendedAttribute.ForEach((taskAttribute) =>
                    {
                        ExtendedAttribute attr = this._projectObject.ExtendedAttributes
                                                                    .Find(attr => attr.FieldID == taskAttribute.FieldID);
                        taskAttribute.Alias = attr.Alias;
                        taskAttribute.FieldName = attr.FieldName;
                    });
                });
        }

        public void SetExtendedAttributesNames(List<string> extendedAttributesNames)
        {
            this._extendedAttributesNames = extendedAttributesNames;
        }
    }
}
