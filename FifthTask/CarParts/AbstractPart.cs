﻿using System;
using System.Xml.Serialization;

namespace CollectionsAndExceptions.CarParts
{
    [Serializable]
    [XmlInclude(typeof(Engine))]
    [XmlInclude(typeof(Chassis))]
    [XmlInclude(typeof(Transmission))]
    public abstract class AbstractPart
    {
        protected abstract string Specification();

        public override string ToString() => Specification();
    }
}
