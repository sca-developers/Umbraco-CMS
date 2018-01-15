﻿using System.Runtime.Serialization;
using Umbraco.Core.Models.Entities;

namespace Umbraco.Core.Models
{
    /// <summary>
    /// Represents a Tag, which is composed of a Text, Group and NodeCount property.
    /// </summary>
    public interface ITag : IEntity, IRememberBeingDirty
    {
        [DataMember]
        string Text { get; set; }

        [DataMember]
        string Group { get; set; }

        int NodeCount { get; }

        //TODO: enable this at some stage
        //int ParentId { get; set; }
    }
}
