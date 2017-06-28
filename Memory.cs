using Rocket.API.Serialisation;
using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Persiafighter.Programs.RocketConfigEditor
{
    public sealed class Memory
    {
        internal string _rd;
        internal XmlSerializer _sr = new XmlSerializer(typeof(RocketPermissions));
        internal RocketPermissions _rp;
        internal void DeserializeXML()
        {
            try
            {
                using (StreamReader reader = new StreamReader(_rd))
                {
                    _rp = _sr.Deserialize(reader) as RocketPermissions;
                }
            }
            catch (Exception) { }
        }
        internal Memory(string rd)
        {
            try
            {
                _rd = rd;
                DeserializeXML();
            }
            catch (Exception) { }
        }
        internal void Load(string rd)
        {
            try
            {
                _rd = rd;
                DeserializeXML();
            }
            catch (Exception) { }
        }
        internal void Save()
        {
            try
            {
                using (StreamWriter reader = new StreamWriter(_rd))
                {
                    _sr.Serialize(reader, _rp);
                }
            }
            catch (Exception) { }
        }
    }
}
