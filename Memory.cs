using Rocket.API.Serialisation;
using Rocket.Core.Serialization;
using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Persiafighter.Programs.RocketConfigEditor
{
    internal sealed class PermissionsMemory
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
        internal PermissionsMemory()
        {
            _rp = new RocketPermissions();
        }
        internal PermissionsMemory(string rd)
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
        internal void CopyToClipboard()
        {
            try
            {
                using (StringWriter writer = new StringWriter())
                {
                    _sr.Serialize(writer, _rp);
                    System.Windows.Forms.Clipboard.SetText(writer.ToString());
                }
            }
            catch (Exception) { }
        }
    }
    internal sealed class CommandsMemory
    {
        internal string _dir;
        internal XmlSerializer _sr = new XmlSerializer(typeof(RocketCommands));
        internal RocketCommands _rc;
        internal void DeserializeXML()
        {
            try
            {
                using (StreamReader reader = new StreamReader(_dir))
                {
                    _rc = _sr.Deserialize(reader) as RocketCommands;
                }
            }
            catch (Exception) { }
        }
        internal CommandsMemory(string rd)
        {
            try
            {
                _dir = rd;
                DeserializeXML();
            }
            catch (Exception) { }
        }
        internal void Load(string rd)
        {
            try
            {
                _dir = rd;
                DeserializeXML();
            }
            catch (Exception) { }
        }
        internal void Save()
        {
            try
            {
                using (StreamWriter reader = new StreamWriter(_dir))
                {
                    _sr.Serialize(reader, _rc);
                }
            }
            catch (Exception) { }
        }
        internal void CopyToClipboard()
        {
            try
            {
                using (StringWriter writer = new StringWriter())
                {
                    _sr.Serialize(writer, _rc);
                    System.Windows.Forms.Clipboard.SetText(writer.ToString());
                }
            }
            catch (Exception) { }
        }
    }
}
